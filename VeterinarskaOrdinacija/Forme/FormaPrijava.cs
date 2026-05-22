using System;
using System.Drawing;
using System.Windows.Forms;
using VeterinarskaOrdinacija.Podaci;
using VeterinarskaOrdinacija.Pomocno;
using VeterinarskaOrdinacija.Properties;

namespace VeterinarskaOrdinacija.Forme
{
    public partial class FormaPrijava : Form
    {
        private readonly SkladisteKorisnika _skladiste;

        public FormaPrijava()
        {
            InitializeComponent();
            _skladiste = new SkladisteKorisnika();
            _skladiste.Ucitaj();

            picLogo.Image = Resources.Logo;

            txtKorisnik.Focus();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            erpGreska.Clear();

            if (string.IsNullOrWhiteSpace(txtKorisnik.Text))
            {
                erpGreska.SetError(txtKorisnik, "Unesite korisničko ime.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtLozinka.Text))
            {
                erpGreska.SetError(txtLozinka, "Unesite lozinku.");
                return;
            }

            var korisnik = _skladiste.Prijavi(txtKorisnik.Text.Trim(), txtLozinka.Text);
            if (korisnik == null)
            {
                lblPoruka.ForeColor = Color.Firebrick;
                lblPoruka.Text = "Pogrešno korisničko ime ili lozinka.";
                txtLozinka.Clear();
                txtLozinka.Focus();
                return;
            }

            Sesija.UlogovaniKorisnik = korisnik;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
