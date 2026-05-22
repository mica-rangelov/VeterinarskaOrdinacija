using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VeterinarskaOrdinacija.Modeli;
using VeterinarskaOrdinacija.Podaci;

namespace VeterinarskaOrdinacija.Forme
{
    public partial class FormaIstorija : Form
    {
        private readonly Ljubimac _ljubimac;
        private readonly SkladistePregleda _skladiste;

        public FormaIstorija(Ljubimac ljubimac, SkladistePregleda skladiste)
        {
            InitializeComponent();
            _ljubimac = ljubimac;
            _skladiste = skladiste;

            Text = $"Istorija pregleda — {ljubimac.Ime} ({ljubimac.Vrsta})";
            lblNaslov.Text = $"{ljubimac.Ime} — {ljubimac.Opis()}";

            UcitajPreglede();
        }

        private void UcitajPreglede()
        {
            lstPregledi.Items.Clear();
            var pregledi = _skladiste.ZaLjubimca(_ljubimac.Id);
            foreach (var p in pregledi)
            {
                var stavka = $"{p.DatumPregleda:dd.MM.yyyy. HH:mm}  —  {p.Dijagnoza}";
                lstPregledi.Items.Add(new StavkaIstorije(p, stavka));
            }
            if (lstPregledi.Items.Count > 0) lstPregledi.SelectedIndex = 0;
            else PrikaziDetalje(null);
        }

        private void lstPregledi_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stavka = lstPregledi.SelectedItem as StavkaIstorije;
            PrikaziDetalje(stavka?.Pregled);
        }

        private void PrikaziDetalje(Pregled p)
        {
            if (p == null)
            {
                txtDetalji.Text = "(nema pregleda)";
                return;
            }
            txtDetalji.Text =
                $"Datum: {p.DatumPregleda:dd.MM.yyyy. HH:mm}\r\n" +
                $"Veterinar: {p.Veterinar}\r\n\r\n" +
                $"DIJAGNOZA:\r\n{p.Dijagnoza}\r\n\r\n" +
                $"TERAPIJA:\r\n{(string.IsNullOrEmpty(p.Terapija) ? "(nema)" : p.Terapija)}\r\n\r\n" +
                $"NAPOMENE:\r\n{(string.IsNullOrEmpty(p.Napomene) ? "(nema)" : p.Napomene)}";
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            var lista = new List<Ljubimac> { _ljubimac };
            using (var f = new FormaPregled(lista, _ljubimac.Id))
            {
                if (f.ShowDialog(this) != DialogResult.OK) return;
                _skladiste.Dodaj(f.Rezultat);
                UcitajPreglede();
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            var stavka = lstPregledi.SelectedItem as StavkaIstorije;
            if (stavka == null) return;
            if (MessageBox.Show($"Obrisati pregled od {stavka.Pregled.DatumPregleda:dd.MM.yyyy.}?",
                "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            _skladiste.Obrisi(stavka.Pregled.Id);
            UcitajPreglede();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            Close();
        }

        private class StavkaIstorije
        {
            public Pregled Pregled { get; }
            private readonly string _tekst;
            public StavkaIstorije(Pregled p, string tekst)
            {
                Pregled = p;
                _tekst = tekst;
            }
            public override string ToString() => _tekst;
        }
    }
}
