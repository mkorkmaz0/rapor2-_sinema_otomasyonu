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
    public partial class FrmAcilis : Form
    {
        public FrmAcilis()
        {
            InitializeComponent();
        }
        //sql connection proje yolu
        //SqlConnection connection= new SqlConnection("Data Source=Veritabanı_Yolu;Inital Catalog=Veritabanının_Adı;Itegrated Security=True");
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-7EPCTQ4;Initial Catalog=cinemaiXVT;Integrated Security=True");



        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            //Kullanıcı Girişi İşlemleri
            //select insert update delete
            //Şart koşulu WHERE dir.
            connection.Open();

            //SqlCommand command = new SqlCommand("select KulaniciAdi,KullaniciSifre Adsoyad from dbo.Tbl_Kullanicilar WHERE KulaniciAdi=@p1 AND KullaniciSifre=@p2", connection);
            SqlCommand command = new SqlCommand("select * from dbo.Tbl_Kullanicilar WHERE KulaniciAdi=@p1 AND KullaniciSifre=@p2", connection);

            command.Parameters.AddWithValue("@p1",textKullaniciAdi.Text);
            command.Parameters.AddWithValue("@p2",textSifre.Text);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read()) //okuma işl. doru ise yada veriler eşleşiyorsa yapılacak işlemler
            {
                //MessageBox.Show("GİRİŞ BAŞARILI");
                FormAnaform form = new FormAnaform();
                form.kisiadiSoyadi = reader["AdSoyad"].ToString();
                form.Show();//showdialog
                this.Hide();
            }
            else 
            {
                MessageBox.Show("KULLANICI BULUNAMADI! Tekrar Deneyiniz... Kullanıcı veya şifre hatalı ");
            }

            connection.Close();

            textKullaniciAdi.Text = "";
            textSifre.Text = "";
            textKullaniciAdi.Focus();//imleci konumlandır

            //Kullanıcı Giriş İşlemi Sorgulama
            //connection.Open();
            //if (connection.State == ConnectionState.Open) 
            //{
            //    MessageBox.Show("Başarılı!");
            //}
            //connection.Close();
        }
    }
}
