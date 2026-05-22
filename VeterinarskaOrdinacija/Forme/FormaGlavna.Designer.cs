namespace VeterinarskaOrdinacija.Forme
{
    partial class FormaGlavna
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.MenuStrip menuGlavni;
        private System.Windows.Forms.ToolStripMenuItem miFajl;
        private System.Windows.Forms.ToolStripMenuItem miOdjava;
        private System.Windows.Forms.ToolStripMenuItem miIzlaz;
        private System.Windows.Forms.ToolStripMenuItem miPomoc;
        private System.Windows.Forms.ToolStripMenuItem miOProgramu;

        private System.Windows.Forms.ToolStrip toolStripGlavni;
        private System.Windows.Forms.ToolStripButton tsbOsvezi;
        private System.Windows.Forms.ToolStripLabel tslInfo;

        private System.Windows.Forms.StatusStrip statusStripGlavni;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusKorisnik;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusRazmak;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusVreme;

        private System.Windows.Forms.SplitContainer split;
        private System.Windows.Forms.TreeView trvNavigacija;

        private System.Windows.Forms.TabControl tcGlavni;
        private System.Windows.Forms.TabPage tabVlasnici;
        private System.Windows.Forms.TabPage tabLjubimci;
        private System.Windows.Forms.TabPage tabPregledi;

        // Tab Vlasnici
        private System.Windows.Forms.DataGridView dgvVlasnici;
        private System.Windows.Forms.Panel pnlVlasniciTop;
        private System.Windows.Forms.Label lblPretraga;
        private System.Windows.Forms.TextBox txtPretragaVlasnika;
        private System.Windows.Forms.Panel pnlVlasniciDno;
        private System.Windows.Forms.Button btnDodajVlasnika;
        private System.Windows.Forms.Button btnIzmeniVlasnika;
        private System.Windows.Forms.Button btnObrisiVlasnika;

        // Tab Ljubimci
        private System.Windows.Forms.DataGridView dgvLjubimci;
        private System.Windows.Forms.Panel pnlLjubimciTop;
        private System.Windows.Forms.Label lblFilterVrsta;
        private System.Windows.Forms.ComboBox cmbFilterVrsta;
        private System.Windows.Forms.Label lblFilterVlasnik;
        private System.Windows.Forms.ComboBox cmbFilterVlasnik;
        private System.Windows.Forms.Panel pnlLjubimciDno;
        private System.Windows.Forms.Button btnDodajLjubimca;
        private System.Windows.Forms.Button btnIzmeniLjubimca;
        private System.Windows.Forms.Button btnObrisiLjubimca;
        private System.Windows.Forms.Button btnIstorija;

        // Tab Pregledi
        private System.Windows.Forms.DataGridView dgvPregledi;
        private System.Windows.Forms.Panel pnlPreglediTop;
        private System.Windows.Forms.Label lblFilterLjubimac;
        private System.Windows.Forms.ComboBox cmbFilterLjubimac;
        private System.Windows.Forms.Panel pnlPreglediDno;
        private System.Windows.Forms.Button btnDodajPregled;
        private System.Windows.Forms.Button btnIzmeniPregled;
        private System.Windows.Forms.Button btnObrisiPregled;
        private System.Windows.Forms.Button btnOsvezi;

        private System.Windows.Forms.Timer tmrVreme;
        private System.Windows.Forms.ToolTip ttHint;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuGlavni = new System.Windows.Forms.MenuStrip();
            this.miFajl = new System.Windows.Forms.ToolStripMenuItem();
            this.miOdjava = new System.Windows.Forms.ToolStripMenuItem();
            this.miIzlaz = new System.Windows.Forms.ToolStripMenuItem();
            this.miPomoc = new System.Windows.Forms.ToolStripMenuItem();
            this.miOProgramu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripGlavni = new System.Windows.Forms.ToolStrip();
            this.tsbOsvezi = new System.Windows.Forms.ToolStripButton();
            this.tslInfo = new System.Windows.Forms.ToolStripLabel();
            this.statusStripGlavni = new System.Windows.Forms.StatusStrip();
            this.lblStatusKorisnik = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusRazmak = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusVreme = new System.Windows.Forms.ToolStripStatusLabel();
            this.split = new System.Windows.Forms.SplitContainer();
            this.trvNavigacija = new System.Windows.Forms.TreeView();
            this.tcGlavni = new System.Windows.Forms.TabControl();
            this.tabVlasnici = new System.Windows.Forms.TabPage();
            this.dgvVlasnici = new System.Windows.Forms.DataGridView();
            this.pnlVlasniciTop = new System.Windows.Forms.Panel();
            this.lblPretraga = new System.Windows.Forms.Label();
            this.txtPretragaVlasnika = new System.Windows.Forms.TextBox();
            this.pnlVlasniciDno = new System.Windows.Forms.Panel();
            this.btnDodajVlasnika = new System.Windows.Forms.Button();
            this.btnIzmeniVlasnika = new System.Windows.Forms.Button();
            this.btnObrisiVlasnika = new System.Windows.Forms.Button();
            this.tabLjubimci = new System.Windows.Forms.TabPage();
            this.dgvLjubimci = new System.Windows.Forms.DataGridView();
            this.pnlLjubimciTop = new System.Windows.Forms.Panel();
            this.lblFilterVrsta = new System.Windows.Forms.Label();
            this.cmbFilterVrsta = new System.Windows.Forms.ComboBox();
            this.lblFilterVlasnik = new System.Windows.Forms.Label();
            this.cmbFilterVlasnik = new System.Windows.Forms.ComboBox();
            this.pnlLjubimciDno = new System.Windows.Forms.Panel();
            this.btnDodajLjubimca = new System.Windows.Forms.Button();
            this.btnIzmeniLjubimca = new System.Windows.Forms.Button();
            this.btnObrisiLjubimca = new System.Windows.Forms.Button();
            this.btnIstorija = new System.Windows.Forms.Button();
            this.tabPregledi = new System.Windows.Forms.TabPage();
            this.dgvPregledi = new System.Windows.Forms.DataGridView();
            this.pnlPreglediTop = new System.Windows.Forms.Panel();
            this.lblFilterLjubimac = new System.Windows.Forms.Label();
            this.cmbFilterLjubimac = new System.Windows.Forms.ComboBox();
            this.pnlPreglediDno = new System.Windows.Forms.Panel();
            this.btnDodajPregled = new System.Windows.Forms.Button();
            this.btnIzmeniPregled = new System.Windows.Forms.Button();
            this.btnObrisiPregled = new System.Windows.Forms.Button();
            this.btnOsvezi = new System.Windows.Forms.Button();
            this.tmrVreme = new System.Windows.Forms.Timer(this.components);
            this.ttHint = new System.Windows.Forms.ToolTip(this.components);
            this.menuGlavni.SuspendLayout();
            this.toolStripGlavni.SuspendLayout();
            this.statusStripGlavni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split)).BeginInit();
            this.split.Panel1.SuspendLayout();
            this.split.Panel2.SuspendLayout();
            this.split.SuspendLayout();
            this.tcGlavni.SuspendLayout();
            this.tabVlasnici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVlasnici)).BeginInit();
            this.pnlVlasniciTop.SuspendLayout();
            this.pnlVlasniciDno.SuspendLayout();
            this.tabLjubimci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLjubimci)).BeginInit();
            this.pnlLjubimciTop.SuspendLayout();
            this.pnlLjubimciDno.SuspendLayout();
            this.tabPregledi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledi)).BeginInit();
            this.pnlPreglediTop.SuspendLayout();
            this.pnlPreglediDno.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuGlavni
            // 
            this.menuGlavni.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuGlavni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFajl,
            this.miPomoc});
            this.menuGlavni.Location = new System.Drawing.Point(0, 0);
            this.menuGlavni.Name = "menuGlavni";
            this.menuGlavni.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuGlavni.Size = new System.Drawing.Size(1257, 30);
            this.menuGlavni.TabIndex = 3;
            // 
            // miFajl
            // 
            this.miFajl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOdjava,
            this.miIzlaz});
            this.miFajl.Name = "miFajl";
            this.miFajl.Size = new System.Drawing.Size(45, 26);
            this.miFajl.Text = "&Fajl";
            // 
            // miOdjava
            // 
            this.miOdjava.Name = "miOdjava";
            this.miOdjava.Size = new System.Drawing.Size(153, 26);
            this.miOdjava.Text = "Odjavi se";
            this.miOdjava.Click += new System.EventHandler(this.miOdjava_Click);
            // 
            // miIzlaz
            // 
            this.miIzlaz.Name = "miIzlaz";
            this.miIzlaz.Size = new System.Drawing.Size(153, 26);
            this.miIzlaz.Text = "Izlaz";
            this.miIzlaz.Click += new System.EventHandler(this.miIzlaz_Click);
            // 
            // miPomoc
            // 
            this.miPomoc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOProgramu});
            this.miPomoc.Name = "miPomoc";
            this.miPomoc.Size = new System.Drawing.Size(68, 26);
            this.miPomoc.Text = "&Pomoć";
            // 
            // miOProgramu
            // 
            this.miOProgramu.Name = "miOProgramu";
            this.miOProgramu.Size = new System.Drawing.Size(173, 26);
            this.miOProgramu.Text = "O programu";
            this.miOProgramu.Click += new System.EventHandler(this.miOProgramu_Click);
            // 
            // toolStripGlavni
            // 
            this.toolStripGlavni.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripGlavni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOsvezi,
            this.tslInfo});
            this.toolStripGlavni.Location = new System.Drawing.Point(0, 30);
            this.toolStripGlavni.Name = "toolStripGlavni";
            this.toolStripGlavni.Size = new System.Drawing.Size(1257, 31);
            this.toolStripGlavni.TabIndex = 1;
            // 
            // tsbOsvezi
            // 
            this.tsbOsvezi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbOsvezi.Name = "tsbOsvezi";
            this.tsbOsvezi.Size = new System.Drawing.Size(56, 28);
            this.tsbOsvezi.Text = "Osveži";
            this.tsbOsvezi.Click += new System.EventHandler(this.tsbOsvezi_Click);
            // 
            // tslInfo
            // 
            this.tslInfo.Name = "tslInfo";
            this.tslInfo.Size = new System.Drawing.Size(315, 28);
            this.tslInfo.Text = "Tip: kliknite na čvor u stablu za brzu navigaciju";
            // 
            // statusStripGlavni
            // 
            this.statusStripGlavni.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripGlavni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusKorisnik,
            this.lblStatusRazmak,
            this.lblStatusVreme});
            this.statusStripGlavni.Location = new System.Drawing.Point(0, 667);
            this.statusStripGlavni.Name = "statusStripGlavni";
            this.statusStripGlavni.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStripGlavni.Size = new System.Drawing.Size(1257, 26);
            this.statusStripGlavni.TabIndex = 2;
            // 
            // lblStatusKorisnik
            // 
            this.lblStatusKorisnik.Name = "lblStatusKorisnik";
            this.lblStatusKorisnik.Size = new System.Drawing.Size(64, 20);
            this.lblStatusKorisnik.Text = "Korisnik:";
            // 
            // lblStatusRazmak
            // 
            this.lblStatusRazmak.Name = "lblStatusRazmak";
            this.lblStatusRazmak.Size = new System.Drawing.Size(1176, 20);
            this.lblStatusRazmak.Spring = true;
            // 
            // lblStatusVreme
            // 
            this.lblStatusVreme.Name = "lblStatusVreme";
            this.lblStatusVreme.Size = new System.Drawing.Size(0, 20);
            // 
            // split
            // 
            this.split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split.Location = new System.Drawing.Point(0, 61);
            this.split.Name = "split";
            // 
            // split.Panel1
            // 
            this.split.Panel1.Controls.Add(this.trvNavigacija);
            // 
            // split.Panel2
            // 
            this.split.Panel2.Controls.Add(this.tcGlavni);
            this.split.Size = new System.Drawing.Size(1257, 606);
            this.split.SplitterDistance = 297;
            this.split.SplitterWidth = 5;
            this.split.TabIndex = 0;
            // 
            // trvNavigacija
            // 
            this.trvNavigacija.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvNavigacija.Location = new System.Drawing.Point(0, 0);
            this.trvNavigacija.Name = "trvNavigacija";
            this.trvNavigacija.Size = new System.Drawing.Size(297, 606);
            this.trvNavigacija.TabIndex = 0;
            this.trvNavigacija.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvNavigacija_AfterSelect);
            this.trvNavigacija.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvNavigacija_NodeMouseDoubleClick);
            // 
            // tcGlavni
            // 
            this.tcGlavni.Controls.Add(this.tabVlasnici);
            this.tcGlavni.Controls.Add(this.tabLjubimci);
            this.tcGlavni.Controls.Add(this.tabPregledi);
            this.tcGlavni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcGlavni.Location = new System.Drawing.Point(0, 0);
            this.tcGlavni.Name = "tcGlavni";
            this.tcGlavni.SelectedIndex = 0;
            this.tcGlavni.Size = new System.Drawing.Size(955, 606);
            this.tcGlavni.TabIndex = 0;
            // 
            // tabVlasnici
            // 
            this.tabVlasnici.Controls.Add(this.dgvVlasnici);
            this.tabVlasnici.Controls.Add(this.pnlVlasniciTop);
            this.tabVlasnici.Controls.Add(this.pnlVlasniciDno);
            this.tabVlasnici.Location = new System.Drawing.Point(4, 25);
            this.tabVlasnici.Name = "tabVlasnici";
            this.tabVlasnici.Padding = new System.Windows.Forms.Padding(3);
            this.tabVlasnici.Size = new System.Drawing.Size(947, 577);
            this.tabVlasnici.TabIndex = 0;
            this.tabVlasnici.Text = "Vlasnici";
            this.tabVlasnici.UseVisualStyleBackColor = true;
            // 
            // dgvVlasnici
            // 
            this.dgvVlasnici.AllowUserToAddRows = false;
            this.dgvVlasnici.AllowUserToDeleteRows = false;
            this.dgvVlasnici.ColumnHeadersHeight = 29;
            this.dgvVlasnici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVlasnici.Location = new System.Drawing.Point(3, 46);
            this.dgvVlasnici.MultiSelect = false;
            this.dgvVlasnici.Name = "dgvVlasnici";
            this.dgvVlasnici.ReadOnly = true;
            this.dgvVlasnici.RowHeadersVisible = false;
            this.dgvVlasnici.RowHeadersWidth = 51;
            this.dgvVlasnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVlasnici.Size = new System.Drawing.Size(941, 477);
            this.dgvVlasnici.TabIndex = 0;
            this.dgvVlasnici.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVlasnici_CellDoubleClick);
            // 
            // pnlVlasniciTop
            // 
            this.pnlVlasniciTop.Controls.Add(this.lblPretraga);
            this.pnlVlasniciTop.Controls.Add(this.txtPretragaVlasnika);
            this.pnlVlasniciTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVlasniciTop.Location = new System.Drawing.Point(3, 3);
            this.pnlVlasniciTop.Name = "pnlVlasniciTop";
            this.pnlVlasniciTop.Size = new System.Drawing.Size(941, 43);
            this.pnlVlasniciTop.TabIndex = 1;
            // 
            // lblPretraga
            // 
            this.lblPretraga.Location = new System.Drawing.Point(9, 13);
            this.lblPretraga.Name = "lblPretraga";
            this.lblPretraga.Size = new System.Drawing.Size(91, 21);
            this.lblPretraga.TabIndex = 0;
            this.lblPretraga.Text = "Pretraga:";
            // 
            // txtPretragaVlasnika
            // 
            this.txtPretragaVlasnika.Location = new System.Drawing.Point(103, 11);
            this.txtPretragaVlasnika.Name = "txtPretragaVlasnika";
            this.txtPretragaVlasnika.Size = new System.Drawing.Size(342, 22);
            this.txtPretragaVlasnika.TabIndex = 1;
            this.txtPretragaVlasnika.TextChanged += new System.EventHandler(this.txtPretragaVlasnika_TextChanged);
            // 
            // pnlVlasniciDno
            // 
            this.pnlVlasniciDno.Controls.Add(this.btnDodajVlasnika);
            this.pnlVlasniciDno.Controls.Add(this.btnIzmeniVlasnika);
            this.pnlVlasniciDno.Controls.Add(this.btnObrisiVlasnika);
            this.pnlVlasniciDno.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlVlasniciDno.Location = new System.Drawing.Point(3, 523);
            this.pnlVlasniciDno.Name = "pnlVlasniciDno";
            this.pnlVlasniciDno.Size = new System.Drawing.Size(941, 51);
            this.pnlVlasniciDno.TabIndex = 2;
            // 
            // btnDodajVlasnika
            // 
            this.btnDodajVlasnika.Location = new System.Drawing.Point(9, 11);
            this.btnDodajVlasnika.Name = "btnDodajVlasnika";
            this.btnDodajVlasnika.Size = new System.Drawing.Size(114, 32);
            this.btnDodajVlasnika.TabIndex = 0;
            this.btnDodajVlasnika.Text = "Dodaj";
            this.btnDodajVlasnika.UseVisualStyleBackColor = true;
            this.btnDodajVlasnika.Click += new System.EventHandler(this.btnDodajVlasnika_Click);
            // 
            // btnIzmeniVlasnika
            // 
            this.btnIzmeniVlasnika.Location = new System.Drawing.Point(131, 11);
            this.btnIzmeniVlasnika.Name = "btnIzmeniVlasnika";
            this.btnIzmeniVlasnika.Size = new System.Drawing.Size(114, 32);
            this.btnIzmeniVlasnika.TabIndex = 1;
            this.btnIzmeniVlasnika.Text = "Izmeni";
            this.btnIzmeniVlasnika.UseVisualStyleBackColor = true;
            this.btnIzmeniVlasnika.Click += new System.EventHandler(this.btnIzmeniVlasnika_Click);
            // 
            // btnObrisiVlasnika
            // 
            this.btnObrisiVlasnika.Location = new System.Drawing.Point(254, 11);
            this.btnObrisiVlasnika.Name = "btnObrisiVlasnika";
            this.btnObrisiVlasnika.Size = new System.Drawing.Size(114, 32);
            this.btnObrisiVlasnika.TabIndex = 2;
            this.btnObrisiVlasnika.Text = "Obriši";
            this.btnObrisiVlasnika.UseVisualStyleBackColor = true;
            this.btnObrisiVlasnika.Click += new System.EventHandler(this.btnObrisiVlasnika_Click);
            // 
            // tabLjubimci
            // 
            this.tabLjubimci.Controls.Add(this.dgvLjubimci);
            this.tabLjubimci.Controls.Add(this.pnlLjubimciTop);
            this.tabLjubimci.Controls.Add(this.pnlLjubimciDno);
            this.tabLjubimci.Location = new System.Drawing.Point(4, 25);
            this.tabLjubimci.Name = "tabLjubimci";
            this.tabLjubimci.Padding = new System.Windows.Forms.Padding(3);
            this.tabLjubimci.Size = new System.Drawing.Size(947, 589);
            this.tabLjubimci.TabIndex = 1;
            this.tabLjubimci.Text = "Ljubimci";
            this.tabLjubimci.UseVisualStyleBackColor = true;
            // 
            // dgvLjubimci
            // 
            this.dgvLjubimci.AllowUserToAddRows = false;
            this.dgvLjubimci.AllowUserToDeleteRows = false;
            this.dgvLjubimci.ColumnHeadersHeight = 29;
            this.dgvLjubimci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLjubimci.Location = new System.Drawing.Point(3, 54);
            this.dgvLjubimci.MultiSelect = false;
            this.dgvLjubimci.Name = "dgvLjubimci";
            this.dgvLjubimci.ReadOnly = true;
            this.dgvLjubimci.RowHeadersVisible = false;
            this.dgvLjubimci.RowHeadersWidth = 51;
            this.dgvLjubimci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLjubimci.Size = new System.Drawing.Size(941, 481);
            this.dgvLjubimci.TabIndex = 0;
            this.dgvLjubimci.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLjubimci_CellDoubleClick);
            // 
            // pnlLjubimciTop
            // 
            this.pnlLjubimciTop.Controls.Add(this.lblFilterVrsta);
            this.pnlLjubimciTop.Controls.Add(this.cmbFilterVrsta);
            this.pnlLjubimciTop.Controls.Add(this.lblFilterVlasnik);
            this.pnlLjubimciTop.Controls.Add(this.cmbFilterVlasnik);
            this.pnlLjubimciTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLjubimciTop.Location = new System.Drawing.Point(3, 3);
            this.pnlLjubimciTop.Name = "pnlLjubimciTop";
            this.pnlLjubimciTop.Size = new System.Drawing.Size(941, 51);
            this.pnlLjubimciTop.TabIndex = 1;
            // 
            // lblFilterVrsta
            // 
            this.lblFilterVrsta.Location = new System.Drawing.Point(9, 15);
            this.lblFilterVrsta.Name = "lblFilterVrsta";
            this.lblFilterVrsta.Size = new System.Drawing.Size(51, 21);
            this.lblFilterVrsta.TabIndex = 0;
            this.lblFilterVrsta.Text = "Vrsta:";
            // 
            // cmbFilterVrsta
            // 
            this.cmbFilterVrsta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterVrsta.Location = new System.Drawing.Point(66, 12);
            this.cmbFilterVrsta.Name = "cmbFilterVrsta";
            this.cmbFilterVrsta.Size = new System.Drawing.Size(159, 24);
            this.cmbFilterVrsta.TabIndex = 1;
            this.cmbFilterVrsta.SelectedIndexChanged += new System.EventHandler(this.cmbFilterVrsta_SelectedIndexChanged);
            // 
            // lblFilterVlasnik
            // 
            this.lblFilterVlasnik.Location = new System.Drawing.Point(246, 15);
            this.lblFilterVlasnik.Name = "lblFilterVlasnik";
            this.lblFilterVlasnik.Size = new System.Drawing.Size(63, 21);
            this.lblFilterVlasnik.TabIndex = 2;
            this.lblFilterVlasnik.Text = "Vlasnik:";
            // 
            // cmbFilterVlasnik
            // 
            this.cmbFilterVlasnik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterVlasnik.Location = new System.Drawing.Point(314, 12);
            this.cmbFilterVlasnik.Name = "cmbFilterVlasnik";
            this.cmbFilterVlasnik.Size = new System.Drawing.Size(262, 24);
            this.cmbFilterVlasnik.TabIndex = 3;
            this.cmbFilterVlasnik.SelectedIndexChanged += new System.EventHandler(this.cmbFilterVlasnik_SelectedIndexChanged);
            // 
            // pnlLjubimciDno
            // 
            this.pnlLjubimciDno.Controls.Add(this.btnDodajLjubimca);
            this.pnlLjubimciDno.Controls.Add(this.btnIzmeniLjubimca);
            this.pnlLjubimciDno.Controls.Add(this.btnObrisiLjubimca);
            this.pnlLjubimciDno.Controls.Add(this.btnIstorija);
            this.pnlLjubimciDno.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLjubimciDno.Location = new System.Drawing.Point(3, 535);
            this.pnlLjubimciDno.Name = "pnlLjubimciDno";
            this.pnlLjubimciDno.Size = new System.Drawing.Size(941, 51);
            this.pnlLjubimciDno.TabIndex = 2;
            // 
            // btnDodajLjubimca
            // 
            this.btnDodajLjubimca.Location = new System.Drawing.Point(9, 11);
            this.btnDodajLjubimca.Name = "btnDodajLjubimca";
            this.btnDodajLjubimca.Size = new System.Drawing.Size(114, 32);
            this.btnDodajLjubimca.TabIndex = 0;
            this.btnDodajLjubimca.Text = "Dodaj";
            this.btnDodajLjubimca.UseVisualStyleBackColor = true;
            this.btnDodajLjubimca.Click += new System.EventHandler(this.btnDodajLjubimca_Click);
            // 
            // btnIzmeniLjubimca
            // 
            this.btnIzmeniLjubimca.Location = new System.Drawing.Point(131, 11);
            this.btnIzmeniLjubimca.Name = "btnIzmeniLjubimca";
            this.btnIzmeniLjubimca.Size = new System.Drawing.Size(114, 32);
            this.btnIzmeniLjubimca.TabIndex = 1;
            this.btnIzmeniLjubimca.Text = "Izmeni";
            this.btnIzmeniLjubimca.UseVisualStyleBackColor = true;
            this.btnIzmeniLjubimca.Click += new System.EventHandler(this.btnIzmeniLjubimca_Click);
            // 
            // btnObrisiLjubimca
            // 
            this.btnObrisiLjubimca.Location = new System.Drawing.Point(254, 11);
            this.btnObrisiLjubimca.Name = "btnObrisiLjubimca";
            this.btnObrisiLjubimca.Size = new System.Drawing.Size(114, 32);
            this.btnObrisiLjubimca.TabIndex = 2;
            this.btnObrisiLjubimca.Text = "Obriši";
            this.btnObrisiLjubimca.UseVisualStyleBackColor = true;
            this.btnObrisiLjubimca.Click += new System.EventHandler(this.btnObrisiLjubimca_Click);
            // 
            // btnIstorija
            // 
            this.btnIstorija.Location = new System.Drawing.Point(389, 11);
            this.btnIstorija.Name = "btnIstorija";
            this.btnIstorija.Size = new System.Drawing.Size(160, 32);
            this.btnIstorija.TabIndex = 3;
            this.btnIstorija.Text = "Istorija pregleda...";
            this.btnIstorija.UseVisualStyleBackColor = true;
            this.btnIstorija.Click += new System.EventHandler(this.btnIstorija_Click);
            // 
            // tabPregledi
            // 
            this.tabPregledi.Controls.Add(this.dgvPregledi);
            this.tabPregledi.Controls.Add(this.pnlPreglediTop);
            this.tabPregledi.Controls.Add(this.pnlPreglediDno);
            this.tabPregledi.Location = new System.Drawing.Point(4, 25);
            this.tabPregledi.Name = "tabPregledi";
            this.tabPregledi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPregledi.Size = new System.Drawing.Size(947, 589);
            this.tabPregledi.TabIndex = 2;
            this.tabPregledi.Text = "Pregledi";
            this.tabPregledi.UseVisualStyleBackColor = true;
            // 
            // dgvPregledi
            // 
            this.dgvPregledi.AllowUserToAddRows = false;
            this.dgvPregledi.AllowUserToDeleteRows = false;
            this.dgvPregledi.ColumnHeadersHeight = 29;
            this.dgvPregledi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPregledi.Location = new System.Drawing.Point(3, 54);
            this.dgvPregledi.MultiSelect = false;
            this.dgvPregledi.Name = "dgvPregledi";
            this.dgvPregledi.ReadOnly = true;
            this.dgvPregledi.RowHeadersVisible = false;
            this.dgvPregledi.RowHeadersWidth = 51;
            this.dgvPregledi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPregledi.Size = new System.Drawing.Size(941, 481);
            this.dgvPregledi.TabIndex = 0;
            this.dgvPregledi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPregledi_CellDoubleClick);
            // 
            // pnlPreglediTop
            // 
            this.pnlPreglediTop.Controls.Add(this.lblFilterLjubimac);
            this.pnlPreglediTop.Controls.Add(this.cmbFilterLjubimac);
            this.pnlPreglediTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPreglediTop.Location = new System.Drawing.Point(3, 3);
            this.pnlPreglediTop.Name = "pnlPreglediTop";
            this.pnlPreglediTop.Size = new System.Drawing.Size(941, 51);
            this.pnlPreglediTop.TabIndex = 1;
            // 
            // lblFilterLjubimac
            // 
            this.lblFilterLjubimac.Location = new System.Drawing.Point(9, 15);
            this.lblFilterLjubimac.Name = "lblFilterLjubimac";
            this.lblFilterLjubimac.Size = new System.Drawing.Size(80, 21);
            this.lblFilterLjubimac.TabIndex = 0;
            this.lblFilterLjubimac.Text = "Ljubimac:";
            // 
            // cmbFilterLjubimac
            // 
            this.cmbFilterLjubimac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterLjubimac.Location = new System.Drawing.Point(91, 12);
            this.cmbFilterLjubimac.Name = "cmbFilterLjubimac";
            this.cmbFilterLjubimac.Size = new System.Drawing.Size(319, 24);
            this.cmbFilterLjubimac.TabIndex = 1;
            this.cmbFilterLjubimac.SelectedIndexChanged += new System.EventHandler(this.cmbFilterLjubimac_SelectedIndexChanged);
            // 
            // pnlPreglediDno
            // 
            this.pnlPreglediDno.Controls.Add(this.btnDodajPregled);
            this.pnlPreglediDno.Controls.Add(this.btnIzmeniPregled);
            this.pnlPreglediDno.Controls.Add(this.btnObrisiPregled);
            this.pnlPreglediDno.Controls.Add(this.btnOsvezi);
            this.pnlPreglediDno.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPreglediDno.Location = new System.Drawing.Point(3, 535);
            this.pnlPreglediDno.Name = "pnlPreglediDno";
            this.pnlPreglediDno.Size = new System.Drawing.Size(941, 51);
            this.pnlPreglediDno.TabIndex = 2;
            // 
            // btnDodajPregled
            // 
            this.btnDodajPregled.Location = new System.Drawing.Point(9, 11);
            this.btnDodajPregled.Name = "btnDodajPregled";
            this.btnDodajPregled.Size = new System.Drawing.Size(114, 32);
            this.btnDodajPregled.TabIndex = 0;
            this.btnDodajPregled.Text = "Dodaj";
            this.btnDodajPregled.UseVisualStyleBackColor = true;
            this.btnDodajPregled.Click += new System.EventHandler(this.btnDodajPregled_Click);
            // 
            // btnIzmeniPregled
            // 
            this.btnIzmeniPregled.Location = new System.Drawing.Point(131, 11);
            this.btnIzmeniPregled.Name = "btnIzmeniPregled";
            this.btnIzmeniPregled.Size = new System.Drawing.Size(114, 32);
            this.btnIzmeniPregled.TabIndex = 1;
            this.btnIzmeniPregled.Text = "Izmeni";
            this.btnIzmeniPregled.UseVisualStyleBackColor = true;
            this.btnIzmeniPregled.Click += new System.EventHandler(this.btnIzmeniPregled_Click);
            // 
            // btnObrisiPregled
            // 
            this.btnObrisiPregled.Location = new System.Drawing.Point(254, 11);
            this.btnObrisiPregled.Name = "btnObrisiPregled";
            this.btnObrisiPregled.Size = new System.Drawing.Size(114, 32);
            this.btnObrisiPregled.TabIndex = 2;
            this.btnObrisiPregled.Text = "Obriši";
            this.btnObrisiPregled.UseVisualStyleBackColor = true;
            this.btnObrisiPregled.Click += new System.EventHandler(this.btnObrisiPregled_Click);
            // 
            // btnOsvezi
            // 
            this.btnOsvezi.Location = new System.Drawing.Point(389, 11);
            this.btnOsvezi.Name = "btnOsvezi";
            this.btnOsvezi.Size = new System.Drawing.Size(114, 32);
            this.btnOsvezi.TabIndex = 3;
            this.btnOsvezi.Text = "Osveži";
            this.btnOsvezi.UseVisualStyleBackColor = true;
            this.btnOsvezi.Click += new System.EventHandler(this.btnOsvezi_Click);
            // 
            // tmrVreme
            // 
            this.tmrVreme.Interval = 1000;
            this.tmrVreme.Tick += new System.EventHandler(this.tmrVreme_Tick);
            // 
            // FormaGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 693);
            this.Controls.Add(this.split);
            this.Controls.Add(this.toolStripGlavni);
            this.Controls.Add(this.statusStripGlavni);
            this.Controls.Add(this.menuGlavni);
            this.Icon = global::VeterinarskaOrdinacija.Properties.Resources.AppIcon;
            this.MainMenuStrip = this.menuGlavni;
            this.MinimumSize = new System.Drawing.Size(1026, 637);
            this.Name = "FormaGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veterinarska ordinacija";
            this.menuGlavni.ResumeLayout(false);
            this.menuGlavni.PerformLayout();
            this.toolStripGlavni.ResumeLayout(false);
            this.toolStripGlavni.PerformLayout();
            this.statusStripGlavni.ResumeLayout(false);
            this.statusStripGlavni.PerformLayout();
            this.split.Panel1.ResumeLayout(false);
            this.split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.split)).EndInit();
            this.split.ResumeLayout(false);
            this.tcGlavni.ResumeLayout(false);
            this.tabVlasnici.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVlasnici)).EndInit();
            this.pnlVlasniciTop.ResumeLayout(false);
            this.pnlVlasniciTop.PerformLayout();
            this.pnlVlasniciDno.ResumeLayout(false);
            this.tabLjubimci.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLjubimci)).EndInit();
            this.pnlLjubimciTop.ResumeLayout(false);
            this.pnlLjubimciDno.ResumeLayout(false);
            this.tabPregledi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledi)).EndInit();
            this.pnlPreglediTop.ResumeLayout(false);
            this.pnlPreglediDno.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
