namespace OtoparkOtomasyon
{
    partial class FrmOtoparkArac
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbGiris = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.cbAbone = new System.Windows.Forms.CheckBox();
            this.cbKontak = new System.Windows.Forms.CheckBox();
            this.lstbAracTip = new System.Windows.Forms.ListBox();
            this.lblAracTip = new System.Windows.Forms.Label();
            this.tbPlaka = new System.Windows.Forms.TextBox();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.gbOtoparkArac = new System.Windows.Forms.GroupBox();
            this.lstbOtoparkArac = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbAracBilgi = new System.Windows.Forms.GroupBox();
            this.lblSureBilgi = new System.Windows.Forms.Label();
            this.lblUcretBilgi = new System.Windows.Forms.Label();
            this.lblPlakaBilgi = new System.Windows.Forms.Label();
            this.lblSureBaslik = new System.Windows.Forms.Label();
            this.lblUcretBaslik = new System.Windows.Forms.Label();
            this.lblPlakaBaslik = new System.Windows.Forms.Label();
            this.btnGunlukSatisRapor = new System.Windows.Forms.Button();
            this.gbGiris.SuspendLayout();
            this.gbOtoparkArac.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.gbAracBilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGiris
            // 
            this.gbGiris.Controls.Add(this.btnEkle);
            this.gbGiris.Controls.Add(this.cbAbone);
            this.gbGiris.Controls.Add(this.cbKontak);
            this.gbGiris.Controls.Add(this.lstbAracTip);
            this.gbGiris.Controls.Add(this.lblAracTip);
            this.gbGiris.Controls.Add(this.tbPlaka);
            this.gbGiris.Controls.Add(this.lblPlaka);
            this.gbGiris.Location = new System.Drawing.Point(13, 13);
            this.gbGiris.Name = "gbGiris";
            this.gbGiris.Size = new System.Drawing.Size(245, 276);
            this.gbGiris.TabIndex = 0;
            this.gbGiris.TabStop = false;
            this.gbGiris.Text = "Giriş";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(152, 229);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(69, 29);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cbAbone
            // 
            this.cbAbone.AutoSize = true;
            this.cbAbone.Location = new System.Drawing.Point(164, 200);
            this.cbAbone.Name = "cbAbone";
            this.cbAbone.Size = new System.Drawing.Size(57, 17);
            this.cbAbone.TabIndex = 4;
            this.cbAbone.Text = "Abone";
            this.cbAbone.UseVisualStyleBackColor = true;
            // 
            // cbKontak
            // 
            this.cbKontak.AutoSize = true;
            this.cbKontak.Location = new System.Drawing.Point(79, 201);
            this.cbKontak.Name = "cbKontak";
            this.cbKontak.Size = new System.Drawing.Size(79, 17);
            this.cbKontak.TabIndex = 3;
            this.cbKontak.Text = "Kontak Var";
            this.cbKontak.UseVisualStyleBackColor = true;
            // 
            // lstbAracTip
            // 
            this.lstbAracTip.Location = new System.Drawing.Point(67, 55);
            this.lstbAracTip.Name = "lstbAracTip";
            this.lstbAracTip.Size = new System.Drawing.Size(172, 134);
            this.lstbAracTip.TabIndex = 0;
            // 
            // lblAracTip
            // 
            this.lblAracTip.AutoSize = true;
            this.lblAracTip.Location = new System.Drawing.Point(7, 55);
            this.lblAracTip.Name = "lblAracTip";
            this.lblAracTip.Size = new System.Drawing.Size(49, 13);
            this.lblAracTip.TabIndex = 2;
            this.lblAracTip.Text = "Araç Tipi";
            // 
            // tbPlaka
            // 
            this.tbPlaka.Location = new System.Drawing.Point(67, 20);
            this.tbPlaka.Name = "tbPlaka";
            this.tbPlaka.Size = new System.Drawing.Size(172, 20);
            this.tbPlaka.TabIndex = 1;
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Location = new System.Drawing.Point(7, 20);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(34, 13);
            this.lblPlaka.TabIndex = 0;
            this.lblPlaka.Text = "Plaka";
            // 
            // gbOtoparkArac
            // 
            this.gbOtoparkArac.Controls.Add(this.lstbOtoparkArac);
            this.gbOtoparkArac.Location = new System.Drawing.Point(278, 13);
            this.gbOtoparkArac.Name = "gbOtoparkArac";
            this.gbOtoparkArac.Size = new System.Drawing.Size(332, 429);
            this.gbOtoparkArac.TabIndex = 1;
            this.gbOtoparkArac.TabStop = false;
            this.gbOtoparkArac.Text = "Otoparktaki Araçlar";
            // 
            // lstbOtoparkArac
            // 
            this.lstbOtoparkArac.ContextMenuStrip = this.contextMenuStrip1;
            this.lstbOtoparkArac.FormattingEnabled = true;
            this.lstbOtoparkArac.Location = new System.Drawing.Point(10, 23);
            this.lstbOtoparkArac.Name = "lstbOtoparkArac";
            this.lstbOtoparkArac.Size = new System.Drawing.Size(316, 394);
            this.lstbOtoparkArac.TabIndex = 0;
            this.lstbOtoparkArac.SelectedIndexChanged += new System.EventHandler(this.lstbOtoparkArac_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışYapToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 26);
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.CikisYap_Click);
            // 
            // gbAracBilgi
            // 
            this.gbAracBilgi.Controls.Add(this.lblSureBilgi);
            this.gbAracBilgi.Controls.Add(this.lblUcretBilgi);
            this.gbAracBilgi.Controls.Add(this.lblPlakaBilgi);
            this.gbAracBilgi.Controls.Add(this.lblSureBaslik);
            this.gbAracBilgi.Controls.Add(this.lblUcretBaslik);
            this.gbAracBilgi.Controls.Add(this.lblPlakaBaslik);
            this.gbAracBilgi.Location = new System.Drawing.Point(13, 295);
            this.gbAracBilgi.Name = "gbAracBilgi";
            this.gbAracBilgi.Size = new System.Drawing.Size(245, 112);
            this.gbAracBilgi.TabIndex = 2;
            this.gbAracBilgi.TabStop = false;
            this.gbAracBilgi.Text = "Araç Bilgisi/Durum";
            // 
            // lblSureBilgi
            // 
            this.lblSureBilgi.AutoSize = true;
            this.lblSureBilgi.Location = new System.Drawing.Point(73, 60);
            this.lblSureBilgi.Name = "lblSureBilgi";
            this.lblSureBilgi.Size = new System.Drawing.Size(41, 13);
            this.lblSureBilgi.TabIndex = 11;
            this.lblSureBilgi.Text = " 0 Saat";
            // 
            // lblUcretBilgi
            // 
            this.lblUcretBilgi.AutoSize = true;
            this.lblUcretBilgi.Location = new System.Drawing.Point(76, 89);
            this.lblUcretBilgi.Name = "lblUcretBilgi";
            this.lblUcretBilgi.Size = new System.Drawing.Size(29, 13);
            this.lblUcretBilgi.TabIndex = 10;
            this.lblUcretBilgi.Text = "0 TL";
            // 
            // lblPlakaBilgi
            // 
            this.lblPlakaBilgi.AutoSize = true;
            this.lblPlakaBilgi.Location = new System.Drawing.Point(76, 31);
            this.lblPlakaBilgi.Name = "lblPlakaBilgi";
            this.lblPlakaBilgi.Size = new System.Drawing.Size(53, 13);
            this.lblPlakaBilgi.TabIndex = 9;
            this.lblPlakaBilgi.Text = "00 xx 000";
            // 
            // lblSureBaslik
            // 
            this.lblSureBaslik.AutoSize = true;
            this.lblSureBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSureBaslik.Location = new System.Drawing.Point(7, 60);
            this.lblSureBaslik.Name = "lblSureBaslik";
            this.lblSureBaslik.Size = new System.Drawing.Size(37, 15);
            this.lblSureBaslik.TabIndex = 8;
            this.lblSureBaslik.Text = "Süre";
            // 
            // lblUcretBaslik
            // 
            this.lblUcretBaslik.AutoSize = true;
            this.lblUcretBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUcretBaslik.Location = new System.Drawing.Point(7, 87);
            this.lblUcretBaslik.Name = "lblUcretBaslik";
            this.lblUcretBaslik.Size = new System.Drawing.Size(41, 15);
            this.lblUcretBaslik.TabIndex = 7;
            this.lblUcretBaslik.Text = "Ücret";
            // 
            // lblPlakaBaslik
            // 
            this.lblPlakaBaslik.AutoSize = true;
            this.lblPlakaBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlakaBaslik.Location = new System.Drawing.Point(7, 30);
            this.lblPlakaBaslik.Name = "lblPlakaBaslik";
            this.lblPlakaBaslik.Size = new System.Drawing.Size(43, 15);
            this.lblPlakaBaslik.TabIndex = 6;
            this.lblPlakaBaslik.Text = "Plaka";
            // 
            // btnGunlukSatisRapor
            // 
            this.btnGunlukSatisRapor.Location = new System.Drawing.Point(13, 413);
            this.btnGunlukSatisRapor.Name = "btnGunlukSatisRapor";
            this.btnGunlukSatisRapor.Size = new System.Drawing.Size(245, 29);
            this.btnGunlukSatisRapor.TabIndex = 6;
            this.btnGunlukSatisRapor.Text = "Günlük Satış Raporu";
            this.btnGunlukSatisRapor.UseVisualStyleBackColor = true;
            this.btnGunlukSatisRapor.Click += new System.EventHandler(this.btnGunlukSatisRapor_Click);
            // 
            // FrmOtoparkArac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 475);
            this.Controls.Add(this.btnGunlukSatisRapor);
            this.Controls.Add(this.gbAracBilgi);
            this.Controls.Add(this.gbOtoparkArac);
            this.Controls.Add(this.gbGiris);
            this.Name = "FrmOtoparkArac";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmOtoparkArac_Load);
            this.gbGiris.ResumeLayout(false);
            this.gbGiris.PerformLayout();
            this.gbOtoparkArac.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbAracBilgi.ResumeLayout(false);
            this.gbAracBilgi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGiris;
        private System.Windows.Forms.TextBox tbPlaka;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.Label lblAracTip;
        private System.Windows.Forms.CheckBox cbKontak;
        private System.Windows.Forms.ListBox lstbAracTip;
        private System.Windows.Forms.CheckBox cbAbone;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox gbOtoparkArac;
        private System.Windows.Forms.ListBox lstbOtoparkArac;
        private System.Windows.Forms.GroupBox gbAracBilgi;
        private System.Windows.Forms.Label lblSureBilgi;
        private System.Windows.Forms.Label lblUcretBilgi;
        private System.Windows.Forms.Label lblPlakaBilgi;
        private System.Windows.Forms.Label lblSureBaslik;
        private System.Windows.Forms.Label lblUcretBaslik;
        private System.Windows.Forms.Label lblPlakaBaslik;
        private System.Windows.Forms.Button btnGunlukSatisRapor;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

