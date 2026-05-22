using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VeterinarskaOrdinacija.Modeli;
using VeterinarskaOrdinacija.Pomocno;

namespace VeterinarskaOrdinacija.Forme
{
    public partial class FormaPregled : Form
    {
        public Pregled Rezultat { get; private set; }
        private readonly bool _izmena;

        public FormaPregled(List<Ljubimac> ljubimci)
        {
            InitializeComponent();
            _izmena = false;
            Text = "Novi pregled";
            Rezultat = new Pregled
            {
                Veterinar = Sesija.KorisnickoIme
            };

            PopuniLjubimce(ljubimci);

            // MaxDate i Value se postavljaju u istom trenutku — inače drugi DateTime.Now
            // bude par milisekundi kasnije i Value > MaxDate baca ArgumentOutOfRangeException.
            // Daje se i mali tampon (1 min) za slučaj da prozor stoji otvoren neko vreme.
            var sada = DateTime.Now;
            dtpDatum.MaxDate = sada.AddMinutes(1);
            dtpDatum.Value = sada;
            lblVeterinar.Text = "Veterinar: " + Sesija.KorisnickoIme;
        }

        public FormaPregled(List<Ljubimac> ljubimci, Pregled postojeci) : this(ljubimci)
        {
            _izmena = true;
            Text = "Izmena pregleda";
            Rezultat = new Pregled
            {
                Id = postojeci.Id,
                LjubimacId = postojeci.LjubimacId,
                DatumPregleda = postojeci.DatumPregleda,
                Dijagnoza = postojeci.Dijagnoza,
                Terapija = postojeci.Terapija,
                Napomene = postojeci.Napomene,
                Veterinar = postojeci.Veterinar
            };

            for (int i = 0; i < cmbLjubimac.Items.Count; i++)
            {
                if (((Ljubimac)cmbLjubimac.Items[i]).Id == postojeci.LjubimacId)
                {
                    cmbLjubimac.SelectedIndex = i;
                    break;
                }
            }
            dtpDatum.Value = postojeci.DatumPregleda;
            txtDijagnoza.Text = postojeci.Dijagnoza;
            txtTerapija.Text = postojeci.Terapija;
            txtNapomene.Text = postojeci.Napomene;
            lblVeterinar.Text = "Veterinar: " + (postojeci.Veterinar ?? "—");
        }

        // Konstruktor sa preselektovanim ljubimcem — koristi se iz FormaIstorija.
        public FormaPregled(List<Ljubimac> ljubimci, Guid ljubimacId) : this(ljubimci)
        {
            for (int i = 0; i < cmbLjubimac.Items.Count; i++)
            {
                if (((Ljubimac)cmbLjubimac.Items[i]).Id == ljubimacId)
                {
                    cmbLjubimac.SelectedIndex = i;
                    cmbLjubimac.Enabled = false;
                    break;
                }
            }
        }

        private void PopuniLjubimce(List<Ljubimac> ljubimci)
        {
            cmbLjubimac.Items.Clear();
            foreach (var l in ljubimci.OrderBy(x => x.Ime))
                cmbLjubimac.Items.Add(l);
            if (cmbLjubimac.Items.Count > 0) cmbLjubimac.SelectedIndex = 0;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            erpGreska.Clear();
            bool ok = true;

            if (cmbLjubimac.SelectedItem == null)
            {
                erpGreska.SetError(cmbLjubimac, "Izaberite ljubimca.");
                ok = false;
            }
            if (!Validator.ValidanDatumPregleda(dtpDatum.Value))
            {
                erpGreska.SetError(dtpDatum, "Datum ne sme biti u budućnosti.");
                ok = false;
            }
            if (string.IsNullOrWhiteSpace(txtDijagnoza.Text))
            {
                erpGreska.SetError(txtDijagnoza, "Dijagnoza je obavezna.");
                ok = false;
            }

            if (!ok) return;

            Rezultat.LjubimacId = ((Ljubimac)cmbLjubimac.SelectedItem).Id;
            Rezultat.DatumPregleda = dtpDatum.Value;
            Rezultat.Dijagnoza = txtDijagnoza.Text.Trim();
            Rezultat.Terapija = (txtTerapija.Text ?? string.Empty).Trim();
            Rezultat.Napomene = (txtNapomene.Text ?? string.Empty).Trim();
            if (!_izmena) Rezultat.Veterinar = Sesija.KorisnickoIme;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        // Prikaz "Detalji" — sva polja samo za čitanje, Sačuvaj sakriven.
        public void PrikaziKaoDetalje()
        {
            Text = "Detalji pregleda";
            cmbLjubimac.Enabled = false;
            dtpDatum.Enabled = false;
            txtDijagnoza.ReadOnly = true;
            txtTerapija.ReadOnly = true;
            txtNapomene.ReadOnly = true;
            btnSacuvaj.Visible = false;
            btnOtkazi.Text = "Zatvori";
        }
    }
}
