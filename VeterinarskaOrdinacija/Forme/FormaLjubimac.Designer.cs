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
            this.grpOsnovno.Size = new System.Drawing.Size(460, 270);
            this.grpOsnovno.TabStop = false;
            this.grpOsnovno.Text = "Osnovni podaci";

            int y = 30;
            this.lblVrsta.Location = new System.Drawing.Point(12, y + 3);
            this.lblVrsta.Size = new System.Drawing.Size(90, 20);
            this.lblVrsta.Text = "Vrsta:";
            this.cmbVrsta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVrsta.Location = new System.Drawing.Point(110, y);
            this.cmbVrsta.Size = new System.Drawing.Size(180, 23);
            this.cmbVrsta.SelectedIndexChanged += new System.EventHandler(this.cmbVrsta_SelectedIndexChanged);

            y += 36;
            this.lblIme.Location = new System.Drawing.Point(12, y + 3);
            this.lblIme.Size = new System.Drawing.Size(90, 20);
            this.lblIme.Text = "Ime:";
            this.txtIme.Location = new System.Drawing.Point(110, y);
            this.txtIme.Size = new System.Drawing.Size(300, 23);

            y += 36;
            this.lblDatum.Location = new System.Drawing.Point(12, y + 3);
            this.lblDatum.Size = new System.Drawing.Size(90, 20);
            this.lblDatum.Text = "Datum rođenja:";
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatum.CustomFormat = "dd.MM.yyyy.";
            this.dtpDatum.Location = new System.Drawing.Point(110, y);
            this.dtpDatum.Size = new System.Drawing.Size(180, 23);

            y += 36;
            this.grpPol.Controls.Add(this.rbMuski);
            this.grpPol.Controls.Add(this.rbZenski);
            this.grpPol.Location = new System.Drawing.Point(12, y);
            this.grpPol.Size = new System.Drawing.Size(280, 50);
            this.grpPol.TabStop = false;
            this.grpPol.Text = "Pol";
            this.rbMuski.Location = new System.Drawing.Point(15, 22);
            this.rbMuski.Size = new System.Drawing.Size(80, 20);
            this.rbMuski.Text = "Muški";
            this.rbZenski.Location = new System.Drawing.Point(120, 22);
            this.rbZenski.Size = new System.Drawing.Size(80, 20);
            this.rbZenski.Text = "Ženski";

            y += 56;
            this.lblTezina.Location = new System.Drawing.Point(12, y + 3);
            this.lblTezina.Size = new System.Drawing.Size(90, 20);
            this.lblTezina.Text = "Težina (kg):";
            this.numTezina.DecimalPlaces = 2;
            this.numTezina.Increment = new decimal(new int[] { 1, 0, 0, 65536 }); // 0.1
            this.numTezina.Maximum = 200;
            this.numTezina.Minimum = new decimal(new int[] { 1, 0, 0, 131072 }); // 0.01
            this.numTezina.Location = new System.Drawing.Point(110, y);
            this.numTezina.Size = new System.Drawing.Size(120, 23);
            this.numTezina.Value = 1;

            y += 36;
            this.lblVlasnik.Location = new System.Drawing.Point(12, y + 3);
            this.lblVlasnik.Size = new System.Drawing.Size(90, 20);
            this.lblVlasnik.Text = "Vlasnik:";
            this.cmbVlasnik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVlasnik.Location = new System.Drawing.Point(110, y);
            this.cmbVlasnik.Size = new System.Drawing.Size(300, 23);

            //
            // pnlPas
            //
            this.pnlPas.Controls.Add(this.grpPas);
            this.pnlPas.Location = new System.Drawing.Point(12, 290);
            this.pnlPas.Size = new System.Drawing.Size(460, 160);
            //
            this.grpPas.Controls.Add(this.lblRasaPas);
            this.grpPas.Controls.Add(this.txtRasaPas);
            this.grpPas.Controls.Add(this.chkDresiran);
            this.grpPas.Controls.Add(this.lblVisina);
            this.grpPas.Controls.Add(this.numVisina);
            this.grpPas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPas.TabStop = false;
            this.grpPas.Text = "Specifično za psa";
            //
            this.lblRasaPas.Location = new System.Drawing.Point(12, 28);
            this.lblRasaPas.Size = new System.Drawing.Size(90, 20);
            this.lblRasaPas.Text = "Rasa:";
            this.txtRasaPas.Location = new System.Drawing.Point(110, 25);
            this.txtRasaPas.Size = new System.Drawing.Size(300, 23);
            //
            this.lblVisina.Location = new System.Drawing.Point(12, 64);
            this.lblVisina.Size = new System.Drawing.Size(90, 20);
            this.lblVisina.Text = "Visina (cm):";
            this.numVisina.Maximum = 200;
            this.numVisina.Minimum = 1;
            this.numVisina.Location = new System.Drawing.Point(110, 61);
            this.numVisina.Size = new System.Drawing.Size(120, 23);
            this.numVisina.Value = 30;
            //
            this.chkDresiran.Location = new System.Drawing.Point(110, 95);
            this.chkDresiran.Size = new System.Drawing.Size(220, 22);
            this.chkDresiran.Text = "Dresiran za čuvanje";
            this.chkDresiran.UseVisualStyleBackColor = true;

            //
            // pnlMacka
            //
            this.pnlMacka.Controls.Add(this.grpMacka);
            this.pnlMacka.Location = new System.Drawing.Point(12, 290);
            this.pnlMacka.Size = new System.Drawing.Size(460, 160);
            //
            this.grpMacka.Controls.Add(this.lblRasaMacka);
            this.grpMacka.Controls.Add(this.txtRasaMacka);
            this.grpMacka.Controls.Add(this.lblBojaKrzna);
            this.grpMacka.Controls.Add(this.txtBojaKrzna);
            this.grpMacka.Controls.Add(this.chkKucna);
            this.grpMacka.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMacka.TabStop = false;
            this.grpMacka.Text = "Specifično za mačku";
            //
            this.lblRasaMacka.Location = new System.Drawing.Point(12, 28);
            this.lblRasaMacka.Size = new System.Drawing.Size(90, 20);
            this.lblRasaMacka.Text = "Rasa:";
            this.txtRasaMacka.Location = new System.Drawing.Point(110, 25);
            this.txtRasaMacka.Size = new System.Drawing.Size(300, 23);
            //
            this.lblBojaKrzna.Location = new System.Drawing.Point(12, 64);
            this.lblBojaKrzna.Size = new System.Drawing.Size(90, 20);
            this.lblBojaKrzna.Text = "Boja krzna:";
            this.txtBojaKrzna.Location = new System.Drawing.Point(110, 61);
            this.txtBojaKrzna.Size = new System.Drawing.Size(300, 23);
            //
            this.chkKucna.Location = new System.Drawing.Point(110, 95);
            this.chkKucna.Size = new System.Drawing.Size(220, 22);
            this.chkKucna.Text = "Kućna mačka";
            this.chkKucna.UseVisualStyleBackColor = true;

            //
            // pnlPapagaj
            //
            this.pnlPapagaj.Controls.Add(this.grpPapagaj);
            this.pnlPapagaj.Location = new System.Drawing.Point(12, 290);
            this.pnlPapagaj.Size = new System.Drawing.Size(460, 160);
            //
            this.grpPapagaj.Controls.Add(this.lblBojaPapagaj);
            this.grpPapagaj.Controls.Add(this.txtBojaPapagaj);
            this.grpPapagaj.Controls.Add(this.chkPrica);
            this.grpPapagaj.Controls.Add(this.lblReci);
            this.grpPapagaj.Controls.Add(this.numReci);
            this.grpPapagaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPapagaj.TabStop = false;
            this.grpPapagaj.Text = "Specifično za papagaja";
            //
            this.lblBojaPapagaj.Location = new System.Drawing.Point(12, 28);
            this.lblBojaPapagaj.Size = new System.Drawing.Size(90, 20);
            this.lblBojaPapagaj.Text = "Boja:";
            this.txtBojaPapagaj.Location = new System.Drawing.Point(110, 25);
            this.txtBojaPapagaj.Size = new System.Drawing.Size(300, 23);
            //
            this.lblReci.Location = new System.Drawing.Point(12, 64);
            this.lblReci.Size = new System.Drawing.Size(90, 20);
            this.lblReci.Text = "Broj reči:";
            this.numReci.Maximum = 10000;
            this.numReci.Location = new System.Drawing.Point(110, 61);
            this.numReci.Size = new System.Drawing.Size(120, 23);
            //
            this.chkPrica.Location = new System.Drawing.Point(110, 95);
            this.chkPrica.Size = new System.Drawing.Size(220, 22);
            this.chkPrica.Text = "Može da priča";
            this.chkPrica.UseVisualStyleBackColor = true;

            //
            // btnSacuvaj / btnOtkazi
            //
            this.btnSacuvaj.Location = new System.Drawing.Point(260, 465);
            this.btnSacuvaj.Size = new System.Drawing.Size(100, 32);
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);

            this.btnOtkazi.Location = new System.Drawing.Point(370, 465);
            this.btnOtkazi.Size = new System.Drawing.Size(100, 32);
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);

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
    }
}
