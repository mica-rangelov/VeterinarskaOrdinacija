using System;
using System.Windows.Forms;
using VeterinarskaOrdinacija.Modeli;
using VeterinarskaOrdinacija.Pomocno;

namespace VeterinarskaOrdinacija.Forme
{
    public partial class FormaVlasnik : Form
    {
        public Vlasnik Rezultat { get; private set; }

        public FormaVlasnik()
        {
            InitializeComponent();
            Rezultat = new Vlasnik();
            Text = "Novi vlasnik";
        }

        public FormaVlasnik(Vlasnik postojeci) : this()
        {
            Text = "Izmena vlasnika";
            Rezultat = new Vlasnik
            {
                Id = postojeci.Id,
                Ime = postojeci.Ime,
                Prezime = postojeci.Prezime,
                Telefon = postojeci.Telefon,
                Email = postojeci.Email,
                Adresa = postojeci.Adresa
            };
            txtIme.Text = postojeci.Ime;
            txtPrezime.Text = postojeci.Prezime;
            mtxtTelefon.Text = postojeci.Telefon;
            txtEmail.Text = postojeci.Email;
            txtAdresa.Text = postojeci.Adresa;
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
            if (!Validator.ValidnoIme(txtPrezime.Text))
            {
                erpGreska.SetError(txtPrezime, "Prezime mora imati 2+ slova.");
                ok = false;
            }
            if (!Validator.ValidanTelefon(mtxtTelefon.Text))
            {
                erpGreska.SetError(mtxtTelefon, "Neispravan format telefona.");
                ok = false;
            }
            if (!Validator.ValidanEmail(txtEmail.Text))
            {
                erpGreska.SetError(txtEmail, "Neispravan email.");
                ok = false;
            }
            if (string.IsNullOrWhiteSpace(txtAdresa.Text))
            {
                erpGreska.SetError(txtAdresa, "Adresa je obavezna.");
                ok = false;
            }

            if (!ok) return;

            Rezultat.Ime = txtIme.Text.Trim();
            Rezultat.Prezime = txtPrezime.Text.Trim();
            Rezultat.Telefon = mtxtTelefon.Text.Trim();
            Rezultat.Email = txtEmail.Text.Trim();
            Rezultat.Adresa = txtAdresa.Text.Trim();

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
            Text = "Detalji vlasnika";
            txtIme.ReadOnly = true;
            txtPrezime.ReadOnly = true;
            mtxtTelefon.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtAdresa.ReadOnly = true;
            btnSacuvaj.Visible = false;
            btnOtkazi.Text = "Zatvori";
        }
    }
}
