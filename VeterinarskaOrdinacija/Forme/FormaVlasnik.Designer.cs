namespace VeterinarskaOrdinacija.Forme
{
    partial class FormaVlasnik
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox grpPodaci;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.MaskedTextBox mtxtTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdresa;
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
            this.grpPodaci = new System.Windows.Forms.GroupBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.mtxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.erpGreska = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpPodaci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpGreska)).BeginInit();
            this.SuspendLayout();
            //
            // grpPodaci
            //
            this.grpPodaci.Controls.Add(this.lblIme);
            this.grpPodaci.Controls.Add(this.txtIme);
            this.grpPodaci.Controls.Add(this.lblPrezime);
            this.grpPodaci.Controls.Add(this.txtPrezime);
            this.grpPodaci.Controls.Add(this.lblTelefon);
            this.grpPodaci.Controls.Add(this.mtxtTelefon);
            this.grpPodaci.Controls.Add(this.lblEmail);
            this.grpPodaci.Controls.Add(this.txtEmail);
            this.grpPodaci.Controls.Add(this.lblAdresa);
            this.grpPodaci.Controls.Add(this.txtAdresa);
            this.grpPodaci.Location = new System.Drawing.Point(12, 12);
            this.grpPodaci.Name = "grpPodaci";
            this.grpPodaci.Size = new System.Drawing.Size(420, 240);
            this.grpPodaci.TabIndex = 0;
            this.grpPodaci.TabStop = false;
            this.grpPodaci.Text = "Lični podaci";
            //
            // lblIme
            //
            this.lblIme.Location = new System.Drawing.Point(12, 33);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(90, 20);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime:";
            //
            // txtIme
            //
            this.txtIme.Location = new System.Drawing.Point(110, 30);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(280, 23);
            this.txtIme.TabIndex = 1;
            //
            // lblPrezime
            //
            this.lblPrezime.Location = new System.Drawing.Point(12, 69);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(90, 20);
            this.lblPrezime.TabIndex = 2;
            this.lblPrezime.Text = "Prezime:";
            //
            // txtPrezime
            //
            this.txtPrezime.Location = new System.Drawing.Point(110, 66);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(280, 23);
            this.txtPrezime.TabIndex = 3;
            //
            // lblTelefon
            //
            this.lblTelefon.Location = new System.Drawing.Point(12, 105);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(90, 20);
            this.lblTelefon.TabIndex = 4;
            this.lblTelefon.Text = "Telefon:";
            //
            // mtxtTelefon
            //
            this.mtxtTelefon.Location = new System.Drawing.Point(110, 102);
            this.mtxtTelefon.Mask = "+999 0000000000";
            this.mtxtTelefon.Name = "mtxtTelefon";
            this.mtxtTelefon.PromptChar = '_';
            this.mtxtTelefon.Size = new System.Drawing.Size(280, 23);
            this.mtxtTelefon.TabIndex = 5;
            //
            // lblEmail
            //
            this.lblEmail.Location = new System.Drawing.Point(12, 141);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(90, 20);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            //
            // txtEmail
            //
            this.txtEmail.Location = new System.Drawing.Point(110, 138);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(280, 23);
            this.txtEmail.TabIndex = 7;
            //
            // lblAdresa
            //
            this.lblAdresa.Location = new System.Drawing.Point(12, 177);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(90, 20);
            this.lblAdresa.TabIndex = 8;
            this.lblAdresa.Text = "Adresa:";
            //
            // txtAdresa
            //
            this.txtAdresa.Location = new System.Drawing.Point(110, 174);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(280, 23);
            this.txtAdresa.TabIndex = 9;
            //
            // btnSacuvaj
            //
            this.btnSacuvaj.Location = new System.Drawing.Point(230, 265);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(100, 32);
            this.btnSacuvaj.TabIndex = 1;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            //
            // btnOtkazi
            //
            this.btnOtkazi.Location = new System.Drawing.Point(335, 265);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(100, 32);
            this.btnOtkazi.TabIndex = 2;
            this.btnOtkazi.Text = "Otkaži";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            //
            // erpGreska
            //
            this.erpGreska.ContainerControl = this;
            //
            // FormaVlasnik
            //
            this.AcceptButton = this.btnSacuvaj;
            this.CancelButton = this.btnOtkazi;
            this.ClientSize = new System.Drawing.Size(444, 310);
            this.Controls.Add(this.grpPodaci);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.btnOtkazi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = global::VeterinarskaOrdinacija.Properties.Resources.AppIcon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormaVlasnik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vlasnik";
            this.grpPodaci.ResumeLayout(false);
            this.grpPodaci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpGreska)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}
