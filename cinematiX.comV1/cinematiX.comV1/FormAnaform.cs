using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinematiX.comV1
{
    public partial class FormAnaform : Form
    {
        public FormAnaform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }


        public string kisiadiSoyadi = "";
        private void FormAnaform_Load(object sender, EventArgs e)
        {
            MessageBox.Show(kisiadiSoyadi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmYonetmenKayit frm = new FrmYonetmenKayit();
            frm.ShowDialog();
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            FrmYonetmenListesi frm = new FrmYonetmenListesi();
            frm.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            FrmOyuncuKayit frm = new FrmOyuncuKayit();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmOyuncuListesi frm = new FrmOyuncuListesi();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmSalonKayit frm = new FrmSalonKayit();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmFilmKayit frm=new FrmFilmKayit();
            frm.ShowDialog();
        }
    }
}
