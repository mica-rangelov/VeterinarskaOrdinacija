using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VeterinarskaOrdinacija.Modeli;
using VeterinarskaOrdinacija.Pomocno;

namespace VeterinarskaOrdinacija.Forme
{
    public partial class FormaLjubimac : Form
    {
        public Ljubimac Rezultat { get; private set; }
        private readonly bool _izmena;
        private readonly Ljubimac _polazni;

        public FormaLjubimac(List<Vlasnik> vlasnici)
        {
            InitializeComponent();
            _izmena = false;
            Text = "Novi ljubimac";

            PopuniVrste();
            PopuniVlasnike(vlasnici);
            cmbVrsta.SelectedIndex = 0;
            rbMuski.Checked = true;
            dtpDatum.MaxDate = DateTime.Today;
            dtpDatum.Value = DateTime.Today;
            PrikaziPanelZaVrstu();
        }

        public FormaLjubimac(List<Vlasnik> vlasnici, Ljubimac postojeci) : this(vlasnici)
        {
            _izmena = true;
            _polazni = postojeci;
            Text = "Izmena ljubimca";

            cmbVrsta.SelectedItem = postojeci.Vrsta;
            cmbVrsta.Enabled = false; // Vrsta se ne menja prilikom izmene.
            txtIme.Text = postojeci.Ime;
            dtpDatum.Value = postojeci.DatumRodjenja;
            if (postojeci.Pol == Pol.Muski) rbMuski.Checked = true; else rbZenski.Checked = true;
            numTezina.Value = (decimal)Math.Max((double)numTezina.Minimum, postojeci.Tezina);

            // Selektuj vlasnika
            for (int i = 0; i < cmbVlasnik.Items.Count; i++)
            {
                if (((Vlasnik)cmbVlasnik.Items[i]).Id == postojeci.VlasnikId)
                {
                    cmbVlasnik.SelectedIndex = i;
                    break;
                }
            }

            PrikaziPanelZaVrstu();
            PopuniSpecificnaPolja(postojeci);
        }

        private void PopuniVrste()
        {
            cmbVrsta.Items.Clear();
            cmbVrsta.Items.AddRange(new object[] { "Pas", "Macka", "Papagaj" });
        }

        private void PopuniVlasnike(List<Vlasnik> vlasnici)
        {
            cmbVlasnik.Items.Clear();
            foreach (var v in vlasnici.OrderBy(x => x.Prezime))
                cmbVlasnik.Items.Add(v);
            if (cmbVlasnik.Items.Count > 0) cmbVlasnik.SelectedIndex = 0;
        }

        private void cmbVrsta_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrikaziPanelZaVrstu();
        }

        private void PrikaziPanelZaVrstu()
        {
            pnlPas.Visible = false;
            pnlMacka.Visible = false;
            pnlPapagaj.Visible = false;

            var vrsta = cmbVrsta.SelectedItem as string;
            if (vrsta == "Pas") pnlPas.Visible = true;
            else if (vrsta == "Macka") pnlMacka.Visible = true;
            else if (vrsta == "Papagaj") pnlPapagaj.Visible = true;
        }

        private void PopuniSpecificnaPolja(Ljubimac lj)
        {
            if (lj is Pas pas)
            {
                txtRasaPas.Text = pas.Rasa;
                chkDresiran.Checked = pas.DresiranZaCuvanje;
                numVisina.Value = (decimal)Math.Max((double)numVisina.Minimum, pas.Visina);
            }
            else if (lj is Macka m)
            {
                txtRasaMacka.Text = m.Rasa;
                chkKucna.Checked = m.KucnaMacka;
                txtBojaKrzna.Text = m.BojaKrzna;
            }
            else if (lj is Papagaj pp)
            {
                txtBojaPapagaj.Text = pp.Boja;
                chkPrica.Checked = pp.MozeDaPrica;
                numReci.Value = pp.BrojNaucenihReci;
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            erpGreska.Clear();
            bool ok = true;

            if (!Validator.ValidnoIme(txtIme.Text))
            {
                erpGreska.SetError(txtIme, "Ime mora imati 2+ slova.");
                ok = false;
            }
            if (!Validator.ValidanDatumRodjenja(dtpDatum.Value))
            {
                erpGreska.SetError(dtpDatum, "Datum mora biti u prošlosti.");
                ok = false;
            }
            var tezina = (double)numTezina.Value;
            if (!Validator.ValidnaTezina(tezina))
            {
                erpGreska.SetError(numTezina, "Težina mora biti > 0.");
                ok = false;
            }
            if (cmbVlasnik.SelectedItem == null)
            {
                erpGreska.SetError(cmbVlasnik, "Izaberite vlasnika.");
                ok = false;
            }
            var vrsta = cmbVrsta.SelectedItem as string;
            if (string.IsNullOrEmpty(vrsta))
            {
                erpGreska.SetError(cmbVrsta, "Izaberite vrstu.");
                ok = false;
            }

            // Vrsta-specifična validacija
            if (vrsta == "Pas" && string.IsNullOrWhiteSpace(txtRasaPas.Text))
            {
                erpGreska.SetError(txtRasaPas, "Unesite rasu.");
                ok = false;
            }
            if (vrsta == "Macka" && string.IsNullOrWhiteSpace(txtRasaMacka.Text))
            {
                erpGreska.SetError(txtRasaMacka, "Unesite rasu.");
                ok = false;
            }
            if (vrsta == "Macka" && string.IsNullOrWhiteSpace(txtBojaKrzna.Text))
            {
                erpGreska.SetError(txtBojaKrzna, "Unesite boju krzna.");
                ok = false;
            }
            if (vrsta == "Papagaj" && string.IsNullOrWhiteSpace(txtBojaPapagaj.Text))
            {
                erpGreska.SetError(txtBojaPapagaj, "Unesite boju.");
                ok = false;
            }

            if (!ok) return;

            Ljubimac lj = NapraviLjubimca(vrsta);
            lj.Ime = txtIme.Text.Trim();
            lj.DatumRodjenja = dtpDatum.Value.Date;
            lj.Pol = rbMuski.Checked ? Pol.Muski : Pol.Zenski;
            lj.Tezina = tezina;
            lj.VlasnikId = ((Vlasnik)cmbVlasnik.SelectedItem).Id;

            // Sačuvaj postojeći Id ako je izmena (samo ako je isti tip)
            if (_izmena && _polazni != null && _polazni.GetType() == lj.GetType())
                lj.Id = _polazni.Id;

            PostaviSpecificnaPolja(lj, vrsta);

            Rezultat = lj;
            DialogResult = DialogResult.OK;
            Close();
        }

        private Ljubimac NapraviLjubimca(string vrsta)
        {
            if (vrsta == "Pas") return new Pas();
            if (vrsta == "Macka") return new Macka();
            return new Papagaj();
        }

        private void PostaviSpecificnaPolja(Ljubimac lj, string vrsta)
        {
            if (lj is Pas pas)
            {
                pas.Rasa = txtRasaPas.Text.Trim();
                pas.DresiranZaCuvanje = chkDresiran.Checked;
                pas.Visina = (double)numVisina.Value;
            }
            else if (lj is Macka m)
            {
                m.Rasa = txtRasaMacka.Text.Trim();
                m.KucnaMacka = chkKucna.Checked;
                m.BojaKrzna = txtBojaKrzna.Text.Trim();
            }
            else if (lj is Papagaj pp)
            {
                pp.Boja = txtBojaPapagaj.Text.Trim();
                pp.MozeDaPrica = chkPrica.Checked;
                pp.BrojNaucenihReci = (int)numReci.Value;
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        // Prikaz "Detalji" — sva polja samo za čitanje, Sačuvaj sakriven.
        public void PrikaziKaoDetalje()
        {
            Text = "Detalji ljubimca";

            cmbVrsta.Enabled = false;
            txtIme.ReadOnly = true;
            dtpDatum.Enabled = false;
            rbMuski.Enabled = false;
            rbZenski.Enabled = false;
            numTezina.Enabled = false;
            cmbVlasnik.Enabled = false;

            // Pas
            txtRasaPas.ReadOnly = true;
            chkDresiran.Enabled = false;
            numVisina.Enabled = false;

            // Macka
            txtRasaMacka.ReadOnly = true;
            chkKucna.Enabled = false;
            txtBojaKrzna.ReadOnly = true;

            // Papagaj
            txtBojaPapagaj.ReadOnly = true;
            chkPrica.Enabled = false;
            numReci.Enabled = false;

            btnSacuvaj.Visible = false;
            btnOtkazi.Text = "Zatvori";
        }
    }
}
