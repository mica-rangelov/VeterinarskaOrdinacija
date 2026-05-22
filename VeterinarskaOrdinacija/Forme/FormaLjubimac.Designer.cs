namespace VeterinarskaOrdinacija.Forme
{
    partial class FormaLjubimac
    {
        private System.ComponentModel.IContainer components = null;

        // Zajednička polja
        private System.Windows.Forms.GroupBox grpOsnovno;
        private System.Windows.Forms.Label lblVrsta;
        private System.Windows.Forms.ComboBox cmbVrsta;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.GroupBox grpPol;
        private System.Windows.Forms.RadioButton rbMuski;
        private System.Windows.Forms.RadioButton rbZenski;
        private System.Windows.Forms.Label lblTezina;
        private System.Windows.Forms.NumericUpDown numTezina;
        private System.Windows.Forms.Label lblVlasnik;
        private System.Windows.Forms.ComboBox cmbVlasnik;

        // Pas
        private System.Windows.Forms.Panel pnlPas;
        private System.Windows.Forms.GroupBox grpPas;
        private System.Windows.Forms.Label lblRasaPas;
        private System.Windows.Forms.TextBox txtRasaPas;
        private System.Windows.Forms.CheckBox chkDresiran;
        private System.Windows.Forms.Label lblVisina;
        private System.Windows.Forms.NumericUpDown numVisina;

        // Macka
        private System.Windows.Forms.Panel pnlMacka;
        private System.Windows.Forms.GroupBox grpMacka;
        private System.Windows.Forms.Label lblRasaMacka;
        private System.Windows.Forms.TextBox txtRasaMacka;
        private System.Windows.Forms.CheckBox chkKucna;
        private System.Windows.Forms.Label lblBojaKrzna;
        private System.Windows.Forms.TextBox txtBojaKrzna;

        // Papagaj
        private System.Windows.Forms.Panel pnlPapagaj;
        private System.Windows.Forms.GroupBox grpPapagaj;
        private System.Windows.Forms.Label lblBojaPapagaj;
        private System.Windows.Forms.TextBox txtBojaPapagaj;
        private System.Windows.Forms.CheckBox chkPrica;
        private System.Windows.Forms.Label lblReci;
        private System.Windows.Forms.NumericUpDown numReci;

        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.ErrorProvider erpGreska;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpOsnovno = new System.Windows.Forms.GroupBox();
            this.lblVrsta = new System.Windows.Forms.Label();
            this.cmbVrsta = new System.Windows.Forms.ComboBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.grpPol = new System.Windows.Forms.GroupBox();
            this.rbMuski = new System.Windows.Forms.RadioButton();
            this.rbZenski = new System.Windows.Forms.RadioButton();
            this.lblTezina = new System.Windows.Forms.Label();
            this.numTezina = new System.Windows.Forms.NumericUpDown();
            this.lblVlasnik = new System.Windows.Forms.Label();
            this.cmbVlasnik = new System.Windows.Forms.ComboBox();

            this.pnlPas = new System.Windows.Forms.Panel();
            this.grpPas = new System.Windows.Forms.GroupBox();
            this.lblRasaPas = new System.Windows.Forms.Label();
            this.txtRasaPas = new System.Windows.Forms.TextBox();
            this.chkDresiran = new System.Windows.Forms.CheckBox();
            this.lblVisina = new System.Windows.Forms.Label();
            this.numVisina = new System.Windows.Forms.NumericUpDown();

            this.pnlMacka = new System.Windows.Forms.Panel();
            this.grpMacka = new System.Windows.Forms.GroupBox();
            this.lblRasaMacka = new System.Windows.Forms.Label();
            this.txtRasaMacka = new System.Windows.Forms.TextBox();
            this.chkKucna = new System.Windows.Forms.CheckBox();
            this.lblBojaKrzna = new System.Windows.Forms.Label();
            this.txtBojaKrzna = new System.Windows.Forms.TextBox();

            this.pnlPapagaj = new System.Windows.Forms.Panel();
            this.grpPapagaj = new System.Windows.Forms.GroupBox();
            this.lblBojaPapagaj = new System.Windows.Forms.Label();
            this.txtBojaPapagaj = new System.Windows.Forms.TextBox();
            this.chkPrica = new System.Windows.Forms.CheckBox();
            this.lblReci = new System.Windows.Forms.Label();
            this.numReci = new System.Windows.Forms.NumericUpDown();

            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.erpGreska = new System.Windows.Forms.ErrorProvider(this.components);

            this.grpOsnovno.SuspendLayout();
            this.grpPol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTezina)).BeginInit();
            this.pnlPas.SuspendLayout();
            this.grpPas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVisina)).BeginInit();
            this.pnlMacka.SuspendLayout();
            this.grpMacka.SuspendLayout();
            this.pnlPapagaj.SuspendLayout();
            this.grpPapagaj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numReci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpGreska)).BeginInit();
            this.SuspendLayout();
            //
            // grpOsnovno
            //
            this.grpOsnovno.Controls.Add(this.lblVrsta);
            this.grpOsnovno.Controls.Add(this.cmbVrsta);
            this.grpOsnovno.Controls.Add(this.lblIme);
            this.grpOsnovno.Controls.Add(this.txtIme);
            this.grpOsnovno.Controls.Add(this.lblDatum);
            this.grpOsnovno.Controls.Add(this.dtpDatum);
            this.grpOsnovno.Controls.Add(this.grpPol);
            this.grpOsnovno.Controls.Add(this.lblTezina);
            this.grpOsnovno.Controls.Add(this.numTezina);
            this.grpOsnovno.Controls.Add(this.lblVlasnik);
            this.grpOsnovno.Controls.Add(this.cmbVlasnik);
            this.grpOsnovno.Location = new System.Drawing.Point(12, 12);
            this.grpOsnovno.Name = "grpOsnovno";
            this.grpOsnovno.Size = new System.Drawing.Size(460, 270);
            this.grpOsnovno.TabIndex = 0;
            this.grpOsnovno.TabStop = false;
            this.grpOsnovno.Text = "Osnovni podaci";
            //
            // lblVrsta
            //
            this.lblVrsta.Location = new System.Drawing.Point(12, 33);
            this.lblVrsta.Name = "lblVrsta";
            this.lblVrsta.Size = new System.Drawing.Size(90, 20);
            this.lblVrsta.TabIndex = 0;
            this.lblVrsta.Text = "Vrsta:";
            //
            // cmbVrsta
            //
            this.cmbVrsta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVrsta.Location = new System.Drawing.Point(110, 30);
            this.cmbVrsta.Name = "cmbVrsta";
            this.cmbVrsta.Size = new System.Drawing.Size(180, 23);
            this.cmbVrsta.TabIndex = 1;
            this.cmbVrsta.SelectedIndexChanged += new System.EventHandler(this.cmbVrsta_SelectedIndexChanged);
            //
            // lblIme
            //
            this.lblIme.Location = new System.Drawing.Point(12, 69);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(90, 20);
            this.lblIme.TabIndex = 2;
            this.lblIme.Text = "Ime:";
            //
            // txtIme
            //
            this.txtIme.Location = new System.Drawing.Point(110, 66);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(300, 23);
            this.txtIme.TabIndex = 3;
            //
            // lblDatum
            //
            this.lblDatum.Location = new System.Drawing.Point(12, 105);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(90, 20);
            this.lblDatum.TabIndex = 4;
            this.lblDatum.Text = "Datum rođenja:";
            //
            // dtpDatum
            //
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatum.CustomFormat = "dd.MM.yyyy.";
            this.dtpDatum.Location = new System.Drawing.Point(110, 102);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(180, 23);
            this.dtpDatum.TabIndex = 5;
            //
            // grpPol
            //
            this.grpPol.Controls.Add(this.rbMuski);
            this.grpPol.Controls.Add(this.rbZenski);
            this.grpPol.Location = new System.Drawing.Point(12, 138);
            this.grpPol.Name = "grpPol";
            this.grpPol.Size = new System.Drawing.Size(280, 50);
            this.grpPol.TabIndex = 6;
            this.grpPol.TabStop = false;
            this.grpPol.Text = "Pol";
            //
            // rbMuski
            //
            this.rbMuski.Location = new System.Drawing.Point(15, 22);
            this.rbMuski.Name = "rbMuski";
            this.rbMuski.Size = new System.Drawing.Size(80, 20);
            this.rbMuski.TabIndex = 0;
            this.rbMuski.Text = "Muški";
            //
            // rbZenski
            //
            this.rbZenski.Location = new System.Drawing.Point(120, 22);
            this.rbZenski.Name = "rbZenski";
            this.rbZenski.Size = new System.Drawing.Size(80, 20);
            this.rbZenski.TabIndex = 1;
            this.rbZenski.Text = "Ženski";
            //
            // lblTezina
            //
            this.lblTezina.Location = new System.Drawing.Point(12, 197);
            this.lblTezina.Name = "lblTezina";
            this.lblTezina.Size = new System.Drawing.Size(90, 20);
            this.lblTezina.TabIndex = 7;
            this.lblTezina.Text = "Težina (kg):";
            //
            // numTezina
            //
            this.numTezina.DecimalPlaces = 2;
            this.numTezina.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            this.numTezina.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            this.numTezina.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            this.numTezina.Location = new System.Drawing.Point(110, 194);
            this.numTezina.Name = "numTezina";
            this.numTezina.Size = new System.Drawing.Size(120, 23);
            this.numTezina.TabIndex = 8;
            this.numTezina.Value = new decimal(new int[] { 1, 0, 0, 0 });
            //
            // lblVlasnik
            //
            this.lblVlasnik.Location = new System.Drawing.Point(12, 233);
            this.lblVlasnik.Name = "lblVlasnik";
            this.lblVlasnik.Size = new System.Drawing.Size(90, 20);
            this.lblVlasnik.TabIndex = 9;
            this.lblVlasnik.Text = "Vlasnik:";
            //
            // cmbVlasnik
            //
            this.cmbVlasnik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVlasnik.Location = new System.Drawing.Point(110, 230);
            this.cmbVlasnik.Name = "cmbVlasnik";
            this.cmbVlasnik.Size = new System.Drawing.Size(300, 23);
            this.cmbVlasnik.TabIndex = 10;
            //
            // pnlPas
            //
            this.pnlPas.Controls.Add(this.grpPas);
            this.pnlPas.Location = new System.Drawing.Point(12, 290);
            this.pnlPas.Name = "pnlPas";
            this.pnlPas.Size = new System.Drawing.Size(460, 160);
            this.pnlPas.TabIndex = 1;
            //
            // grpPas
            //
            this.grpPas.Controls.Add(this.lblRasaPas);
            this.grpPas.Controls.Add(this.txtRasaPas);
            this.grpPas.Controls.Add(this.chkDresiran);
            this.grpPas.Controls.Add(this.lblVisina);
            this.grpPas.Controls.Add(this.numVisina);
            this.grpPas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPas.Name = "grpPas";
            this.grpPas.TabIndex = 0;
            this.grpPas.TabStop = false;
            this.grpPas.Text = "Specifično za psa";
            //
            // lblRasaPas
            //
            this.lblRasaPas.Location = new System.Drawing.Point(12, 28);
            this.lblRasaPas.Name = "lblRasaPas";
            this.lblRasaPas.Size = new System.Drawing.Size(90, 20);
            this.lblRasaPas.TabIndex = 0;
            this.lblRasaPas.Text = "Rasa:";
            //
            // txtRasaPas
            //
            this.txtRasaPas.Location = new System.Drawing.Point(110, 25);
            this.txtRasaPas.Name = "txtRasaPas";
            this.txtRasaPas.Size = new System.Drawing.Size(300, 23);
            this.txtRasaPas.TabIndex = 1;
            //
            // lblVisina
            //
            this.lblVisina.Location = new System.Drawing.Point(12, 64);
            this.lblVisina.Name = "lblVisina";
            this.lblVisina.Size = new System.Drawing.Size(90, 20);
            this.lblVisina.TabIndex = 2;
            this.lblVisina.Text = "Visina (cm):";
            //
            // numVisina
            //
            this.numVisina.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            this.numVisina.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numVisina.Location = new System.Drawing.Point(110, 61);
            this.numVisina.Name = "numVisina";
            this.numVisina.Size = new System.Drawing.Size(120, 23);
            this.numVisina.TabIndex = 3;
            this.numVisina.Value = new decimal(new int[] { 30, 0, 0, 0 });
            //
            // chkDresiran
            //
            this.chkDresiran.Location = new System.Drawing.Point(110, 95);
            this.chkDresiran.Name = "chkDresiran";
            this.chkDresiran.Size = new System.Drawing.Size(220, 22);
            this.chkDresiran.TabIndex = 4;
            this.chkDresiran.Text = "Dresiran za čuvanje";
            this.chkDresiran.UseVisualStyleBackColor = true;
            //
            // pnlMacka
            //
            this.pnlMacka.Controls.Add(this.grpMacka);
            this.pnlMacka.Location = new System.Drawing.Point(12, 290);
            this.pnlMacka.Name = "pnlMacka";
            this.pnlMacka.Size = new System.Drawing.Size(460, 160);
            this.pnlMacka.TabIndex = 2;
            //
            // grpMacka
            //
            this.grpMacka.Controls.Add(this.lblRasaMacka);
            this.grpMacka.Controls.Add(this.txtRasaMacka);
            this.grpMacka.Controls.Add(this.lblBojaKrzna);
            this.grpMacka.Controls.Add(this.txtBojaKrzna);
            this.grpMacka.Controls.Add(this.chkKucna);
            this.grpMacka.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMacka.Name = "grpMacka";
            this.grpMacka.TabIndex = 0;
            this.grpMacka.TabStop = false;
            this.grpMacka.Text = "Specifično za mačku";
            //
            // lblRasaMacka
            //
            this.lblRasaMacka.Location = new System.Drawing.Point(12, 28);
            this.lblRasaMacka.Name = "lblRasaMacka";
            this.lblRasaMacka.Size = new System.Drawing.Size(90, 20);
            this.lblRasaMacka.TabIndex = 0;
            this.lblRasaMacka.Text = "Rasa:";
            //
            // txtRasaMacka
            //
            this.txtRasaMacka.Location = new System.Drawing.Point(110, 25);
            this.txtRasaMacka.Name = "txtRasaMacka";
            this.txtRasaMacka.Size = new System.Drawing.Size(300, 23);
            this.txtRasaMacka.TabIndex = 1;
            //
            // lblBojaKrzna
            //
            this.lblBojaKrzna.Location = new System.Drawing.Point(12, 64);
            this.lblBojaKrzna.Name = "lblBojaKrzna";
            this.lblBojaKrzna.Size = new System.Drawing.Size(90, 20);
            this.lblBojaKrzna.TabIndex = 2;
            this.lblBojaKrzna.Text = "Boja krzna:";
            //
            // txtBojaKrzna
            //
            this.txtBojaKrzna.Location = new System.Drawing.Point(110, 61);
            this.txtBojaKrzna.Name = "txtBojaKrzna";
            this.txtBojaKrzna.Size = new System.Drawing.Size(300, 23);
            this.txtBojaKrzna.TabIndex = 3;
            //
            // chkKucna
            //
            this.chkKucna.Location = new System.Drawing.Point(110, 95);
            this.chkKucna.Name = "chkKucna";
            this.chkKucna.Size = new System.Drawing.Size(220, 22);
            this.chkKucna.TabIndex = 4;
            this.chkKucna.Text = "Kućna mačka";
            this.chkKucna.UseVisualStyleBackColor = true;
            //
            // pnlPapagaj
            //
            this.pnlPapagaj.Controls.Add(this.grpPapagaj);
            this.pnlPapagaj.Location = new System.Drawing.Point(12, 290);
            this.pnlPapagaj.Name = "pnlPapagaj";
            this.pnlPapagaj.Size = new System.Drawing.Size(460, 160);
            this.pnlPapagaj.TabIndex = 3;
            //
            // grpPapagaj
            //
            this.grpPapagaj.Controls.Add(this.lblBojaPapagaj);
            this.grpPapagaj.Controls.Add(this.txtBojaPapagaj);
            this.grpPapagaj.Controls.Add(this.chkPrica);
            this.grpPapagaj.Controls.Add(this.lblReci);
            this.grpPapagaj.Controls.Add(this.numReci);
            this.grpPapagaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPapagaj.Name = "grpPapagaj";
            this.grpPapagaj.TabIndex = 0;
            this.grpPapagaj.TabStop = false;
            this.grpPapagaj.Text = "Specifično za papagaja";
            //
            // lblBojaPapagaj
            //
            this.lblBojaPapagaj.Location = new System.Drawing.Point(12, 28);
            this.lblBojaPapagaj.Name = "lblBojaPapagaj";
            this.lblBojaPapagaj.Size = new System.Drawing.Size(90, 20);
            this.lblBojaPapagaj.TabIndex = 0;
            this.lblBojaPapagaj.Text = "Boja:";
            //
            // txtBojaPapagaj
            //
            this.txtBojaPapagaj.Location = new System.Drawing.Point(110, 25);
            this.txtBojaPapagaj.Name = "txtBojaPapagaj";
            this.txtBojaPapagaj.Size = new System.Drawing.Size(300, 23);
            this.txtBojaPapagaj.TabIndex = 1;
            //
            // lblReci
            //
            this.lblReci.Location = new System.Drawing.Point(12, 64);
            this.lblReci.Name = "lblReci";
            this.lblReci.Size = new System.Drawing.Size(90, 20);
            this.lblReci.TabIndex = 2;
            this.lblReci.Text = "Broj reči:";
            //
            // numReci
            //
            this.numReci.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numReci.Location = new System.Drawing.Point(110, 61);
            this.numReci.Name = "numReci";
            this.numReci.Size = new System.Drawing.Size(120, 23);
            this.numReci.TabIndex = 3;
            //
            // chkPrica
            //
            this.chkPrica.Location = new System.Drawing.Point(110, 95);
            this.chkPrica.Name = "chkPrica";
            this.chkPrica.Size = new System.Drawing.Size(220, 22);
            this.chkPrica.TabIndex = 4;
            this.chkPrica.Text = "Može da priča";
            this.chkPrica.UseVisualStyleBackColor = true;
            //
            // btnSacuvaj
            //
            this.btnSacuvaj.Location = new System.Drawing.Point(260, 465);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(100, 32);
            this.btnSacuvaj.TabIndex = 4;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            //
            // btnOtkazi
            //
            this.btnOtkazi.Location = new System.Drawing.Point(370, 465);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(100, 32);
            this.btnOtkazi.TabIndex = 5;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            //
            // erpGreska
            //
            this.erpGreska.ContainerControl = this;
            //
            // FormaLjubimac
            //
            this.AcceptButton = this.btnSacuvaj;
            this.CancelButton = this.btnOtkazi;
            this.ClientSize = new System.Drawing.Size(484, 510);
            this.Controls.Add(this.grpOsnovno);
            this.Controls.Add(this.pnlPas);
            this.Controls.Add(this.pnlMacka);
            this.Controls.Add(this.pnlPapagaj);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.btnOtkazi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = global::VeterinarskaOrdinacija.Properties.Resources.AppIcon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormaLjubimac";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ljubimac";
            this.grpOsnovno.ResumeLayout(false);
            this.grpOsnovno.PerformLayout();
            this.grpPol.ResumeLayout(false);
            this.grpPol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTezina)).EndInit();
            this.pnlPas.ResumeLayout(false);
            this.grpPas.ResumeLayout(false);
            this.grpPas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVisina)).EndInit();
            this.pnlMacka.ResumeLayout(false);
            this.grpMacka.ResumeLayout(false);
            this.grpMacka.PerformLayout();
            this.pnlPapagaj.ResumeLayout(false);
            this.grpPapagaj.ResumeLayout(false);
            this.grpPapagaj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numReci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpGreska)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}
