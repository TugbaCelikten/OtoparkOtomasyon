namespace OtoparkOtomasyon
{
    partial class GunlukSatisRapor
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbToplamBilgi = new System.Windows.Forms.GroupBox();
            this.lblToplamUcretBilgi = new System.Windows.Forms.Label();
            this.lblToplamAracBilgi = new System.Windows.Forms.Label();
            this.lblToplamUcretBaslik = new System.Windows.Forms.Label();
            this.lblToplamAracBaslik = new System.Windows.Forms.Label();
            this.gbToplamBilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(313, 286);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Plaka";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Araç Tip";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Abone";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Süre";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ücret";
            // 
            // gbToplamBilgi
            // 
            this.gbToplamBilgi.Controls.Add(this.lblToplamUcretBilgi);
            this.gbToplamBilgi.Controls.Add(this.lblToplamAracBilgi);
            this.gbToplamBilgi.Controls.Add(this.lblToplamUcretBaslik);
            this.gbToplamBilgi.Controls.Add(this.lblToplamAracBaslik);
            this.gbToplamBilgi.Location = new System.Drawing.Point(332, 12);
            this.gbToplamBilgi.Name = "gbToplamBilgi";
            this.gbToplamBilgi.Size = new System.Drawing.Size(200, 100);
            this.gbToplamBilgi.TabIndex = 1;
            this.gbToplamBilgi.TabStop = false;
            this.gbToplamBilgi.Text = "Toplam Bilgiler";
            // 
            // lblToplamUcretBilgi
            // 
            this.lblToplamUcretBilgi.AutoSize = true;
            this.lblToplamUcretBilgi.Location = new System.Drawing.Point(117, 59);
            this.lblToplamUcretBilgi.Name = "lblToplamUcretBilgi";
            this.lblToplamUcretBilgi.Size = new System.Drawing.Size(41, 13);
            this.lblToplamUcretBilgi.TabIndex = 15;
            this.lblToplamUcretBilgi.Text = " 0 Saat";
            // 
            // lblToplamAracBilgi
            // 
            this.lblToplamAracBilgi.AutoSize = true;
            this.lblToplamAracBilgi.Location = new System.Drawing.Point(117, 31);
            this.lblToplamAracBilgi.Name = "lblToplamAracBilgi";
            this.lblToplamAracBilgi.Size = new System.Drawing.Size(53, 13);
            this.lblToplamAracBilgi.TabIndex = 14;
            this.lblToplamAracBilgi.Text = "00 xx 000";
            // 
            // lblToplamUcretBaslik
            // 
            this.lblToplamUcretBaslik.AutoSize = true;
            this.lblToplamUcretBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamUcretBaslik.Location = new System.Drawing.Point(6, 57);
            this.lblToplamUcretBaslik.Name = "lblToplamUcretBaslik";
            this.lblToplamUcretBaslik.Size = new System.Drawing.Size(93, 15);
            this.lblToplamUcretBaslik.TabIndex = 13;
            this.lblToplamUcretBaslik.Text = "Toplam Ücret";
            // 
            // lblToplamAracBaslik
            // 
            this.lblToplamAracBaslik.AutoSize = true;
            this.lblToplamAracBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamAracBaslik.Location = new System.Drawing.Point(6, 29);
            this.lblToplamAracBaslik.Name = "lblToplamAracBaslik";
            this.lblToplamAracBaslik.Size = new System.Drawing.Size(87, 15);
            this.lblToplamAracBaslik.TabIndex = 12;
            this.lblToplamAracBaslik.Text = "Toplam Araç";
            // 
            // GunlukSatisRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 308);
            this.Controls.Add(this.gbToplamBilgi);
            this.Controls.Add(this.listView1);
            this.Name = "GunlukSatisRapor";
            this.Text = "GunlukSatisRapor";
            this.gbToplamBilgi.ResumeLayout(false);
            this.gbToplamBilgi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox gbToplamBilgi;
        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.Label lblToplamUcretBilgi;
        public System.Windows.Forms.Label lblToplamAracBilgi;
        private System.Windows.Forms.Label lblToplamUcretBaslik;
        private System.Windows.Forms.Label lblToplamAracBaslik;
    }
}