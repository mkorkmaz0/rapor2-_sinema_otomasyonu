namespace cinematiX.comV1
{
    partial class SalonListesi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalonListesi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSalonAdi = new System.Windows.Forms.Label();
            this.lblKoltukSayisi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 90);
            this.panel1.TabIndex = 0;
            this.panel1.MouseLeave += new System.EventHandler(this.ayril);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gel);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseLeave += new System.EventHandler(this.ayril);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gel);
            // 
            // lblSalonAdi
            // 
            this.lblSalonAdi.AutoSize = true;
            this.lblSalonAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSalonAdi.ForeColor = System.Drawing.Color.Teal;
            this.lblSalonAdi.Location = new System.Drawing.Point(99, 12);
            this.lblSalonAdi.Name = "lblSalonAdi";
            this.lblSalonAdi.Size = new System.Drawing.Size(73, 31);
            this.lblSalonAdi.TabIndex = 2;
            this.lblSalonAdi.Text = "label1";
            // 
            // lblKoltukSayisi
            // 
            this.lblKoltukSayisi.AutoSize = true;
            this.lblKoltukSayisi.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKoltukSayisi.ForeColor = System.Drawing.Color.Turquoise;
            this.lblKoltukSayisi.Location = new System.Drawing.Point(219, 48);
            this.lblKoltukSayisi.Name = "lblKoltukSayisi";
            this.lblKoltukSayisi.Size = new System.Drawing.Size(70, 28);
            this.lblKoltukSayisi.TabIndex = 3;
            this.lblKoltukSayisi.Text = "label2";
            this.lblKoltukSayisi.MouseLeave += new System.EventHandler(this.ayril);
            this.lblKoltukSayisi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Turquoise;
            this.label1.Location = new System.Drawing.Point(101, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Koltuk Sayısı";
            this.label1.MouseLeave += new System.EventHandler(this.ayril);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gel);
            // 
            // SalonListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblKoltukSayisi);
            this.Controls.Add(this.lblSalonAdi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "SalonListesi";
            this.Size = new System.Drawing.Size(323, 90);
            this.MouseLeave += new System.EventHandler(this.ayril);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gel);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblSalonAdi;
        public System.Windows.Forms.Label lblKoltukSayisi;
        public System.Windows.Forms.Label label1;
    }
}
