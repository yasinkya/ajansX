using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ajans_X
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullanici_adi = textBox1.Text;
            string kullanici_sifre = textBox2.Text;
            int logtype;

            database.DB_Connection dB_Connection = new database.DB_Connection();
            logtype = dB_Connection.PassCheck(kullanici_adi, kullanici_sifre);

            if (logtype == 0)
            {
                MudurLog ml = new MudurLog();
                ml.ShowDialog();
                this.Close();
            }
            else if (logtype == 1)
            {

            }
            else
            {
                MessageBox.Show("yavaş la");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
