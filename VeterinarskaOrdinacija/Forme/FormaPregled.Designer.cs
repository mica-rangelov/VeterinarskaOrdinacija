namespace VeterinarskaOrdinacija.Forme
{
    partial class FormaPregled
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox grpPodaci;
        private System.Windows.Forms.Label lblLjubimac;
        private System.Windows.Forms.ComboBox cmbLjubimac;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label lblVeterinar;

        private System.Windows.Forms.Label lblDijagnoza;
        private System.Windows.Forms.TextBox txtDijagnoza;
        private System.Windows.Forms.Label lblTerapija;
        private System.Windows.Forms.TextBox txtTerapija;
        private System.Windows.Forms.Label lblNapomene;
        private System.Windows.Forms.TextBox txtNapomene;

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
            this.grpPodaci = new System.Windows.Forms.GroupBox();
            this.lblLjubimac = new System.Windows.Forms.Label();
            this.cmbLjubimac = new System.Windows.Forms.ComboBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.lblVeterinar = new System.Windows.Forms.Label();
            this.lblDijagnoza = new System.Windows.Forms.Label();
            this.txtDijagnoza = new System.Windows.Forms.TextBox();
            this.lblTerapija = new System.Windows.Forms.Label();
            this.txtTerapija = new System.Windows.Forms.TextBox();
            this.lblNapomene = new System.Windows.Forms.Label();
            this.txtNapomene = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.erpGreska = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpPodaci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpGreska)).BeginInit();
            this.SuspendLayout();

            //
            // grpPodaci
            //
            this.grpPodaci.Controls.Add(this.lblLjubimac);
            this.grpPodaci.Controls.Add(this.cmbLjubimac);
            this.grpPodaci.Controls.Add(this.lblDatum);
            this.grpPodaci.Controls.Add(this.dtpDatum);
            this.grpPodaci.Controls.Add(this.lblVeterinar);
            this.grpPodaci.Location = new System.Drawing.Point(12, 12);
            this.grpPodaci.Size = new System.Drawing.Size(540, 120);
            this.grpPodaci.TabStop = false;
            this.grpPodaci.Text = "Pregled";

            this.lblLjubimac.Location = new System.Drawing.Point(12, 32);
            this.lblLjubimac.Size = new System.Drawing.Size(90, 20);
            this.lblLjubimac.Text = "Ljubimac:";
            this.cmbLjubimac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLjubimac.Location = new System.Drawing.Point(110, 29);
            this.cmbLjubimac.Size = new System.Drawing.Size(310, 23);

            this.lblDatum.Location = new System.Drawing.Point(12, 65);
            this.lblDatum.Size = new System.Drawing.Size(90, 20);
            this.lblDatum.Text = "Datum:";
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatum.CustomFormat = "dd.MM.yyyy. HH:mm";
            this.dtpDatum.Location = new System.Drawing.Point(110, 62);
            this.dtpDatum.Size = new System.Drawing.Size(180, 23);

            this.lblVeterinar.Location = new System.Drawing.Point(12, 92);
            this.lblVeterinar.Size = new System.Drawing.Size(500, 20);
            this.lblVeterinar.Text = "Veterinar:";

            //
            // Dijagnoza
            //
            this.lblDijagnoza.Location = new System.Drawing.Point(12, 145);
            this.lblDijagnoza.Size = new System.Drawing.Size(90, 20);
            this.lblDijagnoza.Text = "Dijagnoza:";
            this.txtDijagnoza.Location = new System.Drawing.Point(110, 145);
            this.txtDijagnoza.Multiline = true;
            this.txtDijagnoza.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDijagnoza.Size = new System.Drawing.Size(440, 60);

            //
            // Terapija
            //
            this.lblTerapija.Location = new System.Drawing.Point(12, 215);
            this.lblTerapija.Size = new System.Drawing.Size(90, 20);
            this.lblTerapija.Text = "Terapija:";
            this.txtTerapija.Location = new System.Drawing.Point(110, 215);
            this.txtTerapija.Multiline = true;
            this.txtTerapija.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTerapija.Size = new System.Drawing.Size(440, 60);

            //
            // Napomene
            //
            this.lblNapomene.Location = new System.Drawing.Point(12, 285);
            this.lblNapomene.Size = new System.Drawing.Size(90, 20);
            this.lblNapomene.Text = "Napomene:";
            this.txtNapomene.Location = new System.Drawing.Point(110, 285);
            this.txtNapomene.Multiline = true;
            this.txtNapomene.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNapomene.Size = new System.Drawing.Size(440, 60);

            //
            // btnSacuvaj / btnOtkazi
            //
            this.btnSacuvaj.Location = new System.Drawing.Point(340, 360);
            this.btnSacuvaj.Size = new System.Drawing.Size(100, 32);
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);

            this.btnOtkazi.Location = new System.Drawing.Point(450, 360);
            this.btnOtkazi.Size = new System.Drawing.Size(100, 32);
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);

            this.erpGreska.ContainerControl = this;

            //
            // FormaPregled
            //
            this.AcceptButton = this.btnSacuvaj;
            this.CancelButton = this.btnOtkazi;
            this.ClientSize = new System.Drawing.Size(564, 405);
            this.Controls.Add(this.grpPodaci);
            this.Controls.Add(this.lblDijagnoza);
            this.Controls.Add(this.txtDijagnoza);
            this.Controls.Add(this.lblTerapija);
            this.Controls.Add(this.txtTerapija);
            this.Controls.Add(this.lblNapomene);
            this.Controls.Add(this.txtNapomene);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.btnOtkazi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = global::VeterinarskaOrdinacija.Properties.Resources.AppIcon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormaPregled";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pregled";

            this.grpPodaci.ResumeLayout(false);
            this.grpPodaci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpGreska)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
