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
    public partial class Oyunculistesi : UserControl
    {
        public Oyunculistesi()
        {
            InitializeComponent();
        }

        //connectionstring
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-7EPCTQ4;Initial Catalog=cinemaiXVT;Integrated Security=True");

        private void Oyunculistesi_Load(object sender, EventArgs e)
        {
            connection.Open();
            string sorgu = "select * from TBl_Oyuncular WHERE ID=@p1";
            SqlCommand command = new SqlCommand(sorgu, connection);
            command.Parameters.AddWithValue("@p1", lblId.Text);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                //işlemler buraya gelicek
                lblCinsiyet.Text = reader["CINSIYET"].ToString();
            }
            connection.Close();
            if (lblCinsiyet.Text == "0")
            {
                //erkek
                pbCinsiyet.ImageLocation = @"C:\\Users\\melik\\Downloads\\m.png";
            }
            else
            {
                //kadın
                pbCinsiyet.ImageLocation = @"C:\\Users\\melik\\Downloads\\f.png";
            }
        }


        private void btnDetayGor_Click(object sender, EventArgs e)
        {
            connection.Open();
            string sorgu = "select * from TBl_Oyuncular WHERE ID=@p1";
            SqlCommand command = new SqlCommand(sorgu, connection);
            command.Parameters.AddWithValue("@p1", lblId.Text);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                //işlemler buraya gelicek
                //MessageBox.Show("BİYOGRAFİ: " + reader["Biyografi"].ToString(), reader["AdiSoyadi"].ToString());
                MessageBox.Show("BİYOGRAFİ: " + reader["BIYOGRAFI"].ToString(), reader["ADSOYAD"].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            connection.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand delete = new SqlCommand("delete from TBl_Oyuncular WHERE ID=@p1", connection);
            delete.Parameters.AddWithValue("@p1", lblId.Text);
            delete.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show(lblAdSoyad.Text + "kişisine ait bilgiler silinmiştir");
            this.Hide();//userconrol araçlarını gizlemiş olduk tüm araçlar gizlenmiyecektir
        }
    }
}
