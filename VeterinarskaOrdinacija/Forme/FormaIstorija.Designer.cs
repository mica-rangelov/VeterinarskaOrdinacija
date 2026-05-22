namespace VeterinarskaOrdinacija.Forme
{
    partial class FormaIstorija
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.SplitContainer split;
        private System.Windows.Forms.ListBox lstPregledi;
        private System.Windows.Forms.TextBox txtDetalji;
        private System.Windows.Forms.Panel pnlDugmad;
        private System.Windows.Forms.Button btnNovi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnZatvori;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblNaslov = new System.Windows.Forms.Label();
            this.split = new System.Windows.Forms.SplitContainer();
            this.lstPregledi = new System.Windows.Forms.ListBox();
            this.txtDetalji = new System.Windows.Forms.TextBox();
            this.pnlDugmad = new System.Windows.Forms.Panel();
            this.btnNovi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.split)).BeginInit();
            this.split.Panel1.SuspendLayout();
            this.split.Panel2.SuspendLayout();
            this.split.SuspendLayout();
            this.pnlDugmad.SuspendLayout();
            this.SuspendLayout();
            //
            // lblNaslov
            //
            this.lblNaslov.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNaslov.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNaslov.Location = new System.Drawing.Point(0, 0);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Padding = new System.Windows.Forms.Padding(10, 8, 10, 0);
            this.lblNaslov.Size = new System.Drawing.Size(720, 32);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // split
            //
            this.split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.split.Location = new System.Drawing.Point(0, 32);
            this.split.Name = "split";
            //
            // split.Panel1
            //
            this.split.Panel1.Controls.Add(this.lstPregledi);
            //
            // split.Panel2
            //
            this.split.Panel2.Controls.Add(this.txtDetalji);
            this.split.Size = new System.Drawing.Size(720, 368);
            this.split.SplitterDistance = 280;
            this.split.TabIndex = 1;
            //
            // lstPregledi
            //
            this.lstPregledi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPregledi.IntegralHeight = false;
            this.lstPregledi.Location = new System.Drawing.Point(0, 0);
            this.lstPregledi.Name = "lstPregledi";
            this.lstPregledi.Size = new System.Drawing.Size(280, 368);
            this.lstPregledi.TabIndex = 0;
            this.lstPregledi.SelectedIndexChanged += new System.EventHandler(this.lstPregledi_SelectedIndexChanged);
            //
            // txtDetalji
            //
            this.txtDetalji.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDetalji.Location = new System.Drawing.Point(0, 0);
            this.txtDetalji.Multiline = true;
            this.txtDetalji.Name = "txtDetalji";
            this.txtDetalji.ReadOnly = true;
            this.txtDetalji.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetalji.Size = new System.Drawing.Size(436, 368);
            this.txtDetalji.TabIndex = 0;
            //
            // pnlDugmad
            //
            this.pnlDugmad.Controls.Add(this.btnNovi);
            this.pnlDugmad.Controls.Add(this.btnObrisi);
            this.pnlDugmad.Controls.Add(this.btnZatvori);
            this.pnlDugmad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDugmad.Location = new System.Drawing.Point(0, 400);
            this.pnlDugmad.Name = "pnlDugmad";
            this.pnlDugmad.Size = new System.Drawing.Size(720, 50);
            this.pnlDugmad.TabIndex = 2;
            //
            // btnNovi
            //
            this.btnNovi.Location = new System.Drawing.Point(10, 10);
            this.btnNovi.Name = "btnNovi";
            this.btnNovi.Size = new System.Drawing.Size(120, 30);
            this.btnNovi.TabIndex = 0;
            this.btnNovi.Text = "Novi pregled";
            this.btnNovi.UseVisualStyleBackColor = true;
            this.btnNovi.Click += new System.EventHandler(this.btnNovi_Click);
            //
            // btnObrisi
            //
            this.btnObrisi.Location = new System.Drawing.Point(135, 10);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(120, 30);
            this.btnObrisi.TabIndex = 1;
            this.btnObrisi.Text = "Obriši pregled";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            //
            // btnZatvori
            //
            this.btnZatvori.Anchor = ((System.Windows.Forms.AnchorStyles)
                ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZatvori.Location = new System.Drawing.Point(600, 10);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(100, 30);
            this.btnZatvori.TabIndex = 2;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            //
            // FormaIstorija
            //
            this.CancelButton = this.btnZatvori;
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.split);
            this.Controls.Add(this.pnlDugmad);
            this.Controls.Add(this.lblNaslov);
            this.Icon = global::VeterinarskaOrdinacija.Properties.Resources.AppIcon;
            this.MinimumSize = new System.Drawing.Size(600, 350);
            this.Name = "FormaIstorija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Istorija pregleda";
            this.split.Panel1.ResumeLayout(false);
            this.split.Panel2.ResumeLayout(false);
            this.split.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.split)).EndInit();
            this.split.ResumeLayout(false);
            this.pnlDugmad.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
