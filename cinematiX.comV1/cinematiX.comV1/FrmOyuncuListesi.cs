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

using System.Data.SqlClient;



namespace cinematiX.comV1
{
    public partial class FrmOyuncuListesi : Form
    {
        public FrmOyuncuListesi()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-7EPCTQ4;Initial Catalog=cinemaiXVT;Integrated Security=True");
        private void FrmOyuncuListesi_Load(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            connection.Open();
            string sorgu = "select * from TBL_Oyuncular ORDER BY ADSOYAD ASC";//DESC
            SqlCommand command = new SqlCommand(sorgu, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                //işlemler buraya gelicek
                Oyunculistesi arac = new Oyunculistesi();
                arac.pBResimDetay.ImageLocation = reader["RESİM"].ToString();
                arac.lblId.Text = reader["ID"].ToString();
                arac.lblAdSoyad.Text = reader["ADSOYAD"].ToString();
                ListePaneli.Controls.Add(arac);
            }
            connection.Close();
        }

      
        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            connection.Open();
            SqlCommand search = new SqlCommand("select * from TBL_Oyuncular where ADSOYAD LIKE ' ORDER BY ADSOYAD ASC %" + txtSearch.Text + "%' ORDER BY ADSOYAD ASC ", connection);
            SqlDataReader reader = search.ExecuteReader();
            while (reader.Read())
            {
                Oyunculistesi arac = new Oyunculistesi();
                arac.pBResimDetay.ImageLocation = reader["RESİM"].ToString();
                arac.lblId.Text = reader["ID"].ToString();
                arac.lblAdSoyad.Text = reader["ADSOYAD"].ToString();
                ListePaneli.Controls.Add(arac);
            }
            connection.Close();
        }

       
    }
}

