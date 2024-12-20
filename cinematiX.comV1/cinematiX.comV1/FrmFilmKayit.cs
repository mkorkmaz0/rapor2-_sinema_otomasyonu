using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinematiX.comV1
{
    public partial class FrmFilmKayit : Form
    {
        public FrmFilmKayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "1";
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "2";
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "3";
        }

        private void rb4_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "4";
        }

        private void rb5_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "5";
        }

        private void rb6_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "6";
        }

        private void rb7_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "7";
        }

        private void rb8_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "8";
        }

        private void rb9_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "9";
        }

        private void rb10_CheckedChanged(object sender, EventArgs e)
        {
            lblRating.Text = "10";
        }

        private void lblRating_Click(object sender, EventArgs e)
        {

        }

        string resimYolu = "";
        private void btnResimYukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "RESİM SEÇME EKRANI";
            ofd.Filter = "PNG | *.png | JPG-JPEG | *jpg;*.jpeg | All Files | *.*";
            ofd.FilterIndex = 3;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pBResim.Image = new Bitmap(ofd.FileName);
                resimYolu = ofd.FileName.ToString();
            }
        }

        private void lblKarakter_Click(object sender, EventArgs e)
        {
            int count = txtFilmDetay.Text.Length;
            int backdown = 300 - count;
            lblKarakter.Text = backdown.ToString();
            if (count > 20)
            {
                lblKarakter.ForeColor = Color.Teal;
            }
            else if (count > 10)
            {
                lblKarakter.ForeColor = Color.Purple;
            }
            else
            {
                lblKarakter.ForeColor = Color.Red;
            }
        }

        private void FrmFilmKayit_Load(object sender, EventArgs e)
        {
            yListesiGetir();
        }

        void yListesiGetir()
        {
            string connection = "select * from Tbl_Yonetmenler ORDER BY AdiSoyadi ASC";
            fYonetmenPaneli.Controls.Clear();
            connection.Open();
            SqlCommand command = new SqlCommand(sorgu,connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                yListeAraci vehicle= new yListeAraci();
                vehicle.lblAdi.Text= reader["AdiSoyadi"].ToString();
                fYonetmenPaneli.Controls.Add(vehicle);
            }
            connection.close();
        }
    }
    
}
