using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using VeterinarskaOrdinacija.Modeli;
using VeterinarskaOrdinacija.Podaci;
using VeterinarskaOrdinacija.Pomocno;

namespace VeterinarskaOrdinacija.Forme
{
    public partial class FormaGlavna : Form
    {
        // Skladišta — jedno polje po tipu (bez generičkih klasa).
        private readonly SkladisteVlasnika _skladisteVlasnika = new SkladisteVlasnika();
        private readonly SkladistePasa _skladistePasa = new SkladistePasa();
        private readonly SkladisteMacaka _skladisteMacaka = new SkladisteMacaka();
        private readonly SkladistePapagaja _skladistePapagaja = new SkladistePapagaja();
        private readonly SkladistePregleda _skladistePregleda = new SkladistePregleda();

        // BindingList-e za "live" prikaz u DataGridView-ovima.
        private readonly BindingList<Vlasnik> _bindVlasnici = new BindingList<Vlasnik>();
        private readonly BindingList<Ljubimac> _bindLjubimci = new BindingList<Ljubimac>();
        private readonly BindingList<Pregled> _bindPregledi = new BindingList<Pregled>();

        public FormaGlavna()
        {
            InitializeComponent();
            UcitajSveIzSkladista();
            PostaviGridove();
            PopuniFiltere();
            PopuniTreeView();

            lblStatusKorisnik.Text = "Korisnik: " + Sesija.KorisnickoIme;
            tmrVreme.Start();
        }

        private void UcitajSveIzSkladista()
        {
            _skladisteVlasnika.Ucitaj();
            _skladistePasa.Ucitaj();
            _skladisteMacaka.Ucitaj();
            _skladistePapagaja.Ucitaj();
            _skladistePregleda.Ucitaj();
            OsveziBindingListe();
        }

        private void OsveziBindingListe()
        {
            _bindVlasnici.Clear();
            foreach (var v in _skladisteVlasnika.Lista.OrderBy(x => x.Prezime))
                _bindVlasnici.Add(v);

            _bindLjubimci.Clear();
            foreach (var p in _skladistePasa.Lista) _bindLjubimci.Add(p);
            foreach (var m in _skladisteMacaka.Lista) _bindLjubimci.Add(m);
            foreach (var pp in _skladistePapagaja.Lista) _bindLjubimci.Add(pp);

            _bindPregledi.Clear();
            foreach (var pr in _skladistePregleda.Lista.OrderByDescending(x => x.DatumPregleda))
                _bindPregledi.Add(pr);
        }

        // Lista svih ljubimaca jednog vlasnika (spaja iz tri skladišta).
        private List<Ljubimac> LjubimciVlasnika(Guid vlasnikId)
        {
            var lista = new List<Ljubimac>();
            lista.AddRange(_skladistePasa.Lista.Where(p => p.VlasnikId == vlasnikId));
            lista.AddRange(_skladisteMacaka.Lista.Where(m => m.VlasnikId == vlasnikId));
            lista.AddRange(_skladistePapagaja.Lista.Where(p => p.VlasnikId == vlasnikId));
            return lista;
        }

        private Ljubimac PronadjiLjubimca(Guid id)
        {
            Ljubimac l = _skladistePasa.Pronadji(id);
            if (l != null) return l;
            l = _skladisteMacaka.Pronadji(id);
            if (l != null) return l;
            return _skladistePapagaja.Pronadji(id);
        }

        private void ObrisiLjubimcaIzPravogSkladista(Ljubimac l)
        {
            if (l is Pas) _skladistePasa.Obrisi(l.Id);
            else if (l is Macka) _skladisteMacaka.Obrisi(l.Id);
            else if (l is Papagaj) _skladistePapagaja.Obrisi(l.Id);
        }

        #region Grid setup

        private void PostaviGridove()
        {
            // ---- Vlasnici ----
            dgvVlasnici.AutoGenerateColumns = false;
            dgvVlasnici.Columns.Clear();
            dgvVlasnici.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Ime", DataPropertyName = "Ime", Width = 110 });
            dgvVlasnici.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Prezime", DataPropertyName = "Prezime", Width = 130 });
            dgvVlasnici.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Telefon", DataPropertyName = "Telefon", Width = 110 });
            dgvVlasnici.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Email", DataPropertyName = "Email", Width = 160 });
            dgvVlasnici.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Adresa", DataPropertyName = "Adresa", Width = 200 });
            dgvVlasnici.DataSource = _bindVlasnici;

            // ---- Ljubimci ----
            dgvLjubimci.AutoGenerateColumns = false;
            dgvLjubimci.Columns.Clear();
            dgvLjubimci.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Ime", DataPropertyName = "Ime", Width = 110 });
            dgvLjubimci.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Vrsta", DataPropertyName = "Vrsta", Width = 80 });
            var kolVlasnik = new DataGridViewTextBoxColumn
            { HeaderText = "Vlasnik", Name = "colVlasnik", Width = 160 };
            dgvLjubimci.Columns.Add(kolVlasnik);
            dgvLjubimci.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Pol", DataPropertyName = "Pol", Width = 60 });
            dgvLjubimci.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Datum rođenja",
                DataPropertyName = "DatumRodjenja",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd.MM.yyyy." }
            });
            dgvLjubimci.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Starost", DataPropertyName = "Starost", Width = 60 });
            dgvLjubimci.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Težina (kg)", DataPropertyName = "Tezina", Width = 80 });
            var kolOpis = new DataGridViewTextBoxColumn
            { HeaderText = "Opis", Name = "colOpis", Width = 240 };
            dgvLjubimci.Columns.Add(kolOpis);
            dgvLjubimci.DataSource = _bindLjubimci;
            dgvLjubimci.CellFormatting += DgvLjubimci_CellFormatting;

            // ---- Pregledi ----
            dgvPregledi.AutoGenerateColumns = false;
            dgvPregledi.Columns.Clear();
            dgvPregledi.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Datum",
                DataPropertyName = "DatumPregleda",
                Width = 130,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd.MM.yyyy. HH:mm" }
            });
            var kolLjubimac = new DataGridViewTextBoxColumn
            { HeaderText = "Ljubimac", Name = "colLjubimac", Width = 140 };
            dgvPregledi.Columns.Add(kolLjubimac);
            var kolVlasnikP = new DataGridViewTextBoxColumn
            { HeaderText = "Vlasnik", Name = "colVlasnikPregled", Width = 160 };
            dgvPregledi.Columns.Add(kolVlasnikP);
            dgvPregledi.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Dijagnoza", DataPropertyName = "Dijagnoza", Width = 220 });
            dgvPregledi.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Veterinar", DataPropertyName = "Veterinar", Width = 100 });
            dgvPregledi.DataSource = _bindPregledi;
            dgvPregledi.CellFormatting += DgvPregledi_CellFormatting;
        }

        private void DgvLjubimci_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= _bindLjubimci.Count) return;
            var lj = _bindLjubimci[e.RowIndex];
            var ime = dgvLjubimci.Columns[e.ColumnIndex].Name;
            if (ime == "colVlasnik")
            {
                var v = _skladisteVlasnika.Pronadji(lj.VlasnikId);
                e.Value = v != null ? v.PunoIme : "(nepoznat)";
            }
            else if (ime == "colOpis")
            {
                e.Value = lj.Opis();
            }
        }

        private void DgvPregledi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= _bindPregledi.Count) return;
            var pr = _bindPregledi[e.RowIndex];
            var ime = dgvPregledi.Columns[e.ColumnIndex].Name;
            if (ime == "colLjubimac")
            {
                var lj = PronadjiLjubimca(pr.LjubimacId);
                e.Value = lj != null ? lj.Ime + " (" + lj.Vrsta + ")" : "(obrisan)";
            }
            else if (ime == "colVlasnikPregled")
            {
                var lj = PronadjiLjubimca(pr.LjubimacId);
                if (lj == null) { e.Value = "—"; return; }
                var v = _skladisteVlasnika.Pronadji(lj.VlasnikId);
                e.Value = v != null ? v.PunoIme : "—";
            }
        }

        #endregion

        #region Filteri

        private void PopuniFiltere()
        {
            // Filter ljubimaca po vrsti
            cmbFilterVrsta.Items.Clear();
            cmbFilterVrsta.Items.AddRange(new object[] { "Sve vrste", "Pas", "Macka", "Papagaj" });
            cmbFilterVrsta.SelectedIndex = 0;

            // Filter ljubimaca po vlasniku
            cmbFilterVlasnik.Items.Clear();
            cmbFilterVlasnik.Items.Add("Svi vlasnici");
            foreach (var v in _skladisteVlasnika.Lista.OrderBy(x => x.Prezime))
                cmbFilterVlasnik.Items.Add(v);
            cmbFilterVlasnik.SelectedIndex = 0;

            // Filter pregleda po ljubimcu
            cmbFilterLjubimac.Items.Clear();
            cmbFilterLjubimac.Items.Add("Svi ljubimci");
            foreach (var p in _skladistePasa.Lista) cmbFilterLjubimac.Items.Add(p);
            foreach (var m in _skladisteMacaka.Lista) cmbFilterLjubimac.Items.Add(m);
            foreach (var pp in _skladistePapagaja.Lista) cmbFilterLjubimac.Items.Add(pp);
            cmbFilterLjubimac.SelectedIndex = 0;
        }

        private void PrimeniFilterLjubimaca()
        {
            var vrsta = cmbFilterVrsta.SelectedItem as string;
            var vlasnikItem = cmbFilterVlasnik.SelectedItem;

            IEnumerable<Ljubimac> svi =
                _skladistePasa.Lista.Cast<Ljubimac>()
                .Concat(_skladisteMacaka.Lista.Cast<Ljubimac>())
                .Concat(_skladistePapagaja.Lista.Cast<Ljubimac>());

            if (!string.IsNullOrEmpty(vrsta) && vrsta != "Sve vrste")
                svi = svi.Where(l => l.Vrsta == vrsta);

            var vl = vlasnikItem as Vlasnik;
            if (vl != null) svi = svi.Where(l => l.VlasnikId == vl.Id);

            _bindLjubimci.Clear();
            foreach (var l in svi) _bindLjubimci.Add(l);
        }

        private void PrimeniFilterPregleda()
        {
            var ljItem = cmbFilterLjubimac.SelectedItem as Ljubimac;

            IEnumerable<Pregled> svi = _skladistePregleda.Lista
                .OrderByDescending(x => x.DatumPregleda);

            if (ljItem != null) svi = svi.Where(p => p.LjubimacId == ljItem.Id);

            _bindPregledi.Clear();
            foreach (var p in svi) _bindPregledi.Add(p);
        }

        #endregion

        #region TreeView

        private void PopuniTreeView()
        {
            trvNavigacija.BeginUpdate();
            trvNavigacija.Nodes.Clear();
            var koren = trvNavigacija.Nodes.Add("Vlasnici");

            foreach (var v in _skladisteVlasnika.Lista.OrderBy(x => x.Prezime))
            {
                var vNode = koren.Nodes.Add("v_" + v.Id, v.PunoIme);
                vNode.Tag = v;

                foreach (var l in LjubimciVlasnika(v.Id))
                {
                    var lNode = vNode.Nodes.Add("l_" + l.Id, l.Ime + " (" + l.Vrsta + ")");
                    lNode.Tag = l;

                    foreach (var pr in _skladistePregleda.ZaLjubimca(l.Id))
                    {
                        var pNode = lNode.Nodes.Add("p_" + pr.Id,
                            pr.DatumPregleda.ToString("dd.MM.yyyy.") + " — " +
                            (string.IsNullOrEmpty(pr.Dijagnoza) ? "(bez dijagnoze)" : pr.Dijagnoza));
                        pNode.Tag = pr;
                    }
                }
            }

            koren.Expand();
            trvNavigacija.EndUpdate();
        }

        private void trvNavigacija_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null || e.Node.Tag == null) return;

            if (e.Node.Tag is Vlasnik v)
            {
                tcGlavni.SelectedTab = tabVlasnici;
                SelektujUDgv(dgvVlasnici, _bindVlasnici, x => x.Id == v.Id);
            }
            else if (e.Node.Tag is Ljubimac l)
            {
                tcGlavni.SelectedTab = tabLjubimci;
                SelektujUDgv(dgvLjubimci, _bindLjubimci, x => x.Id == l.Id);
            }
            else if (e.Node.Tag is Pregled p)
            {
                tcGlavni.SelectedTab = tabPregledi;
                SelektujUDgv(dgvPregledi, _bindPregledi, x => x.Id == p.Id);
            }
        }

        private void trvNavigacija_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node == null || e.Node.Tag == null) return;
            OtvoriDetalje(e.Node.Tag);
        }

        // Centralna metoda — dupli klik otvara details view (samo za čitanje).
        // Za izmenu se koristi dugme "Izmeni" koje otvara istu formu u edit modu.
        private void OtvoriDetalje(object entitet)
        {
            if (entitet is Vlasnik v)
            {
                using (var f = new FormaVlasnik(v))
                {
                    f.PrikaziKaoDetalje();
                    f.ShowDialog(this);
                }
            }
            else if (entitet is Ljubimac l)
            {
                using (var f = new FormaLjubimac(_skladisteVlasnika.Lista, l))
                {
                    f.PrikaziKaoDetalje();
                    f.ShowDialog(this);
                }
            }
            else if (entitet is Pregled p)
            {
                using (var f = new FormaPregled(SviLjubimci(), p))
                {
                    f.PrikaziKaoDetalje();
                    f.ShowDialog(this);
                }
            }
        }

        private void dgvVlasnici_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            OtvoriDetalje(SelektovaniVlasnik());
        }

        private void dgvLjubimci_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            OtvoriDetalje(SelektovaniLjubimac());
        }

        private void dgvPregledi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            OtvoriDetalje(SelektovaniPregled());
        }

        private void SelektujUDgv<T>(DataGridView dgv, BindingList<T> lista, Func<T, bool> uslov)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (uslov(lista[i]))
                {
                    dgv.ClearSelection();
                    dgv.Rows[i].Selected = true;
                    if (dgv.Rows[i].Visible)
                        dgv.FirstDisplayedScrollingRowIndex = i;
                    return;
                }
            }
        }

        #endregion

        #region Vlasnici — akcije

        private void btnDodajVlasnika_Click(object sender, EventArgs e)
        {
            using (var f = new FormaVlasnik())
            {
                if (f.ShowDialog(this) == DialogResult.OK)
                {
                    _skladisteVlasnika.Dodaj(f.Rezultat);
                    OsveziSve();
                }
            }
        }

        private void btnIzmeniVlasnika_Click(object sender, EventArgs e)
        {
            var v = SelektovaniVlasnik();
            if (v == null) { MessageBox.Show("Izaberite vlasnika iz tabele.", "Info"); return; }
            using (var f = new FormaVlasnik(v))
            {
                if (f.ShowDialog(this) == DialogResult.OK)
                {
                    _skladisteVlasnika.Azuriraj(f.Rezultat);
                    OsveziSve();
                }
            }
        }

        private void btnObrisiVlasnika_Click(object sender, EventArgs e)
        {
            var v = SelektovaniVlasnik();
            if (v == null) { MessageBox.Show("Izaberite vlasnika iz tabele.", "Info"); return; }

            var brojLjubimaca = LjubimciVlasnika(v.Id).Count;
            var poruka = brojLjubimaca > 0
                ? $"Vlasnik {v.PunoIme} ima {brojLjubimaca} ljubimaca koji će takođe biti obrisani (i njihovi pregledi). Nastavi?"
                : $"Obrisati vlasnika {v.PunoIme}?";

            if (MessageBox.Show(poruka, "Brisanje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            foreach (var l in LjubimciVlasnika(v.Id))
            {
                _skladistePregleda.ObrisiZaLjubimca(l.Id);
                ObrisiLjubimcaIzPravogSkladista(l);
            }
            _skladisteVlasnika.Obrisi(v.Id);
            OsveziSve();
        }

        private void txtPretragaVlasnika_TextChanged(object sender, EventArgs e)
        {
            var q = txtPretragaVlasnika.Text.Trim().ToLowerInvariant();
            _bindVlasnici.Clear();
            foreach (var v in _skladisteVlasnika.Lista
                .OrderBy(x => x.Prezime)
                .Where(x => string.IsNullOrEmpty(q)
                            || (x.Ime ?? "").ToLowerInvariant().Contains(q)
                            || (x.Prezime ?? "").ToLowerInvariant().Contains(q)
                            || (x.Telefon ?? "").ToLowerInvariant().Contains(q)))
                _bindVlasnici.Add(v);
        }

        private Vlasnik SelektovaniVlasnik()
        {
            if (dgvVlasnici.CurrentRow == null) return null;
            return dgvVlasnici.CurrentRow.DataBoundItem as Vlasnik;
        }

        #endregion

        #region Ljubimci — akcije

        private void btnDodajLjubimca_Click(object sender, EventArgs e)
        {
            if (_skladisteVlasnika.Lista.Count == 0)
            {
                MessageBox.Show("Prvo unesite barem jednog vlasnika.", "Info");
                return;
            }
            using (var f = new FormaLjubimac(_skladisteVlasnika.Lista))
            {
                if (f.ShowDialog(this) != DialogResult.OK) return;
                SacuvajNovogLjubimca(f.Rezultat);
                OsveziSve();
            }
        }

        private void btnIzmeniLjubimca_Click(object sender, EventArgs e)
        {
            var l = SelektovaniLjubimac();
            if (l == null) { MessageBox.Show("Izaberite ljubimca iz tabele.", "Info"); return; }
            using (var f = new FormaLjubimac(_skladisteVlasnika.Lista, l))
            {
                if (f.ShowDialog(this) != DialogResult.OK) return;
                AzurirajLjubimca(f.Rezultat);
                OsveziSve();
            }
        }

        private void btnObrisiLjubimca_Click(object sender, EventArgs e)
        {
            var l = SelektovaniLjubimac();
            if (l == null) { MessageBox.Show("Izaberite ljubimca iz tabele.", "Info"); return; }

            var broj = _skladistePregleda.ZaLjubimca(l.Id).Count;
            var poruka = broj > 0
                ? $"Ljubimac {l.Ime} ima {broj} pregleda koji će biti obrisani. Nastavi?"
                : $"Obrisati ljubimca {l.Ime}?";

            if (MessageBox.Show(poruka, "Brisanje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            _skladistePregleda.ObrisiZaLjubimca(l.Id);
            ObrisiLjubimcaIzPravogSkladista(l);
            OsveziSve();
        }

        private void btnIstorija_Click(object sender, EventArgs e)
        {
            var l = SelektovaniLjubimac();
            if (l == null) { MessageBox.Show("Izaberite ljubimca iz tabele.", "Info"); return; }
            using (var f = new FormaIstorija(l, _skladistePregleda))
            {
                f.ShowDialog(this);
            }
            OsveziSve();
        }

        private void cmbFilterVrsta_SelectedIndexChanged(object sender, EventArgs e)
            => PrimeniFilterLjubimaca();

        private void cmbFilterVlasnik_SelectedIndexChanged(object sender, EventArgs e)
            => PrimeniFilterLjubimaca();

        private void SacuvajNovogLjubimca(Ljubimac l)
        {
            if (l is Pas pas) _skladistePasa.Dodaj(pas);
            else if (l is Macka m) _skladisteMacaka.Dodaj(m);
            else if (l is Papagaj pp) _skladistePapagaja.Dodaj(pp);
        }

        private void AzurirajLjubimca(Ljubimac l)
        {
            if (l is Pas pas) _skladistePasa.Azuriraj(pas);
            else if (l is Macka m) _skladisteMacaka.Azuriraj(m);
            else if (l is Papagaj pp) _skladistePapagaja.Azuriraj(pp);
        }

        private Ljubimac SelektovaniLjubimac()
        {
            if (dgvLjubimci.CurrentRow == null) return null;
            return dgvLjubimci.CurrentRow.DataBoundItem as Ljubimac;
        }

        #endregion

        #region Pregledi — akcije

        private void btnDodajPregled_Click(object sender, EventArgs e)
        {
            var sviLjubimci = SviLjubimci();
            if (sviLjubimci.Count == 0)
            {
                MessageBox.Show("Prvo unesite barem jednog ljubimca.", "Info");
                return;
            }
            using (var f = new FormaPregled(sviLjubimci))
            {
                if (f.ShowDialog(this) != DialogResult.OK) return;
                _skladistePregleda.Dodaj(f.Rezultat);
                OsveziSve();
            }
        }

        private void btnIzmeniPregled_Click(object sender, EventArgs e)
        {
            var p = SelektovaniPregled();
            if (p == null) { MessageBox.Show("Izaberite pregled iz tabele.", "Info"); return; }
            using (var f = new FormaPregled(SviLjubimci(), p))
            {
                if (f.ShowDialog(this) != DialogResult.OK) return;
                _skladistePregleda.Azuriraj(f.Rezultat);
                OsveziSve();
            }
        }

        private void btnObrisiPregled_Click(object sender, EventArgs e)
        {
            var p = SelektovaniPregled();
            if (p == null) { MessageBox.Show("Izaberite pregled iz tabele.", "Info"); return; }
            if (MessageBox.Show($"Obrisati pregled od {p.DatumPregleda:dd.MM.yyyy.}?",
                "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            _skladistePregleda.Obrisi(p.Id);
            OsveziSve();
        }

        private void cmbFilterLjubimac_SelectedIndexChanged(object sender, EventArgs e)
            => PrimeniFilterPregleda();

        private Pregled SelektovaniPregled()
        {
            if (dgvPregledi.CurrentRow == null) return null;
            return dgvPregledi.CurrentRow.DataBoundItem as Pregled;
        }

        private List<Ljubimac> SviLjubimci()
        {
            var lista = new List<Ljubimac>();
            lista.AddRange(_skladistePasa.Lista.Cast<Ljubimac>());
            lista.AddRange(_skladisteMacaka.Lista.Cast<Ljubimac>());
            lista.AddRange(_skladistePapagaja.Lista.Cast<Ljubimac>());
            return lista;
        }

        #endregion

        #region Toolbar / Meni

        private void OsveziSve()
        {
            OsveziBindingListe();
            PopuniFiltere();
            PopuniTreeView();
        }

        private void btnOsvezi_Click(object sender, EventArgs e) => OsveziSve();

        private void tsbOsvezi_Click(object sender, EventArgs e) => OsveziSve();

        private void miOdjava_Click(object sender, EventArgs e)
        {
            Sesija.Odjavi();
            Close();
        }

        private void miIzlaz_Click(object sender, EventArgs e)
        {
            // Ne nuluje Sesija — Program.cs vidi da je korisnik bio ulogovan i ne vraća na prijavu.
            Application.Exit();
        }

        private void miOProgramu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Veterinarska ordinacija\n" +
                "Završni rad — WinForms\n\n" +
                "Ulogovan: " + Sesija.KorisnickoIme,
                "O programu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tmrVreme_Tick(object sender, EventArgs e)
        {
            lblStatusVreme.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        #endregion
    }
}
