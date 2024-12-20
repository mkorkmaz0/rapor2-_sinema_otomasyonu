using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace cinematiX.comV1
{
    public partial class FrmYonetmenListesi : Form
    {
        public FrmYonetmenListesi()
        {
            InitializeComponent();
        }
        //connectionstring
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-7EPCTQ4;Initial Catalog=cinemaiXVT;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FrmYonetmenListesi_Load(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            connection.Open();
            string sorgu = "select * from Tbl_Yonetmenler ORDER BY AdiSoyadi ASC";//DESC
            SqlCommand command = new SqlCommand(sorgu,connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) 
            {
                //işlemler buraya gelicek
                YonetmenListesi arac = new YonetmenListesi();
                arac.pBResimDetay.ImageLocation = reader["Resim"].ToString();
                arac.lblId.Text = reader["ID"].ToString();
                arac.lblAdSoyad.Text = reader ["AdiSoyadi"].ToString();
                ListePaneli.Controls.Add(arac);
            }
            connection.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ListePaneli.Controls.Clear();
            connection.Open();
            SqlCommand search = new SqlCommand("select * from Tbl_Yonetmenler where AdiSoyadi LIKE ' ORDER BY AdiSoyadi ASC %" + txtSearch.Text+ "%' ORDER BY AdiSoyadi ASC ", connection);
            SqlDataReader reader = search.ExecuteReader();
            while (reader.Read()) 
            {
                YonetmenListesi arac = new YonetmenListesi();
                arac.pBResimDetay.ImageLocation = reader["Resim"].ToString();
                arac.lblId.Text = reader["ID"].ToString();
                arac.lblAdSoyad.Text = reader["AdiSoyadi"].ToString();
                ListePaneli.Controls.Add(arac);
            }
            connection.Close();
        }
    }
}
