using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AjansOtomasyon
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        public static int kullanici_yetki;
       
        private void button1_Click(object sender, EventArgs e)
        {
            string kullanici_adi = textBox1.Text;
            string kullanici_sifre = textBox2.Text;

            KullaniciDataProvider kdp = new KullaniciDataProvider();

            if (kullanici_adi == "mansurtocoglu" || kullanici_adi == "MANSURTOCOGLU")
                kullanici_yetki = 5;
            else
                kullanici_yetki = 1;

            kdp.kontrolEt(kullanici_adi,kullanici_sifre);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
