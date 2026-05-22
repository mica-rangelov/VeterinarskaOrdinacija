namespace VeterinarskaOrdinacija.Forme
{
    partial class FormaPrijava
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblKorisnik;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.TextBox txtKorisnik;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblPoruka;
        private System.Windows.Forms.ErrorProvider erpGreska;
        private System.Windows.Forms.ToolTip ttHint;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblKorisnik = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.txtKorisnik = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.lblPoruka = new System.Windows.Forms.Label();
            this.erpGreska = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttHint = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpGreska)).BeginInit();
            this.SuspendLayout();
            //
            // picLogo
            //
            this.picLogo.Location = new System.Drawing.Point(30, 10);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(300, 100);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.picLogo.TabStop = false;
            //
            // lblNaslov
            //
            this.lblNaslov.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblNaslov.Location = new System.Drawing.Point(30, 120);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(300, 30);
            this.lblNaslov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNaslov.Text = "Veterinarska ordinacija";
            //
            // lblKorisnik
            //
            this.lblKorisnik.Location = new System.Drawing.Point(30, 170);
            this.lblKorisnik.Name = "lblKorisnik";
            this.lblKorisnik.Size = new System.Drawing.Size(120, 20);
            this.lblKorisnik.Text = "Korisničko ime:";
            //
            // txtKorisnik
            //
            this.txtKorisnik.Location = new System.Drawing.Point(150, 168);
            this.txtKorisnik.Name = "txtKorisnik";
            this.txtKorisnik.Size = new System.Drawing.Size(180, 23);
            //
            // lblLozinka
            //
            this.lblLozinka.Location = new System.Drawing.Point(30, 205);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(120, 20);
            this.lblLozinka.Text = "Lozinka:";
            //
            // txtLozinka
            //
            this.txtLozinka.Location = new System.Drawing.Point(150, 203);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(180, 23);
            //
            // btnPrijava
            //
            this.btnPrijava.Location = new System.Drawing.Point(60, 250);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(110, 32);
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            //
            // btnOdustani
            //
            this.btnOdustani.Location = new System.Drawing.Point(190, 250);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(110, 32);
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            //
            // lblPoruka
            //
            this.lblPoruka.Location = new System.Drawing.Point(30, 295);
            this.lblPoruka.Name = "lblPoruka";
            this.lblPoruka.Size = new System.Drawing.Size(300, 20);
            this.lblPoruka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // erpGreska
            //
            this.erpGreska.ContainerControl = this;
            //
            // FormaPrijava
            //
            this.AcceptButton = this.btnPrijava;
            this.CancelButton = this.btnOdustani;
            this.ClientSize = new System.Drawing.Size(360, 330);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblNaslov);
            this.Controls.Add(this.lblKorisnik);
            this.Controls.Add(this.txtKorisnik);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.lblPoruka);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = global::VeterinarskaOrdinacija.Properties.Resources.AppIcon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormaPrijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.ttHint.SetToolTip(this.btnPrijava, "Prijavite se u sistem (Enter)");
            this.ttHint.SetToolTip(this.btnOdustani, "Zatvori aplikaciju (Esc)");
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpGreska)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
