namespace cinematiX.comV1
{
    partial class Oyunculistesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Oyunculistesi));
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDetayGor = new System.Windows.Forms.Button();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.pbCinsiyet = new System.Windows.Forms.PictureBox();
            this.pBResimDetay = new System.Windows.Forms.PictureBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbCinsiyet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBResimDetay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(519, 37);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(89, 45);
            this.btnSil.TabIndex = 18;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDetayGor
            // 
            this.btnDetayGor.BackColor = System.Drawing.Color.Turquoise;
            this.btnDetayGor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetayGor.FlatAppearance.BorderSize = 0;
            this.btnDetayGor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetayGor.ForeColor = System.Drawing.Color.White;
            this.btnDetayGor.Location = new System.Drawing.Point(369, 37);
            this.btnDetayGor.Name = "btnDetayGor";
            this.btnDetayGor.Size = new System.Drawing.Size(144, 45);
            this.btnDetayGor.TabIndex = 17;
            this.btnDetayGor.Text = "DETAY GÖR";
            this.btnDetayGor.UseVisualStyleBackColor = false;
            this.btnDetayGor.Click += new System.EventHandler(this.btnDetayGor_Click);
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCinsiyet.ForeColor = System.Drawing.Color.Teal;
            this.lblCinsiyet.Location = new System.Drawing.Point(251, 42);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(73, 31);
            this.lblCinsiyet.TabIndex = 16;
            this.lblCinsiyet.Text = "label1";
            this.lblCinsiyet.Visible = false;
            // 
            // pbCinsiyet
            // 
            this.pbCinsiyet.Image = ((System.Drawing.Image)(resources.GetObject("pbCinsiyet.Image")));
            this.pbCinsiyet.Location = new System.Drawing.Point(115, 7);
            this.pbCinsiyet.Name = "pbCinsiyet";
            this.pbCinsiyet.Size = new System.Drawing.Size(41, 32);
            this.pbCinsiyet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCinsiyet.TabIndex = 15;
            this.pbCinsiyet.TabStop = false;
            // 
            // pBResimDetay
            // 
            this.pBResimDetay.Image = ((System.Drawing.Image)(resources.GetObject("pBResimDetay.Image")));
            this.pBResimDetay.Location = new System.Drawing.Point(12, 0);
            this.pBResimDetay.Name = "pBResimDetay";
            this.pBResimDetay.Size = new System.Drawing.Size(100, 87);
            this.pBResimDetay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBResimDetay.TabIndex = 14;
            this.pBResimDetay.TabStop = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblId.ForeColor = System.Drawing.Color.Teal;
            this.lblId.Location = new System.Drawing.Point(118, 42);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(73, 31);
            this.lblId.TabIndex = 13;
            this.lblId.Text = "label1";
            this.lblId.Visible = false;
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.ForeColor = System.Drawing.Color.Teal;
            this.lblAdSoyad.Location = new System.Drawing.Point(162, 11);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(73, 31);
            this.lblAdSoyad.TabIndex = 12;
            this.lblAdSoyad.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 87);
            this.panel1.TabIndex = 11;
            // 
            // Oyunculistesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDetayGor);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.pbCinsiyet);
            this.Controls.Add(this.pBResimDetay);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.panel1);
            this.Name = "Oyunculistesi";
            this.Size = new System.Drawing.Size(612, 87);
            this.Load += new System.EventHandler(this.Oyunculistesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCinsiyet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBResimDetay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDetayGor;
        public System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.PictureBox pbCinsiyet;
        public System.Windows.Forms.PictureBox pBResimDetay;
        public System.Windows.Forms.Label lblId;
        public System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Panel panel1;
    }
}
