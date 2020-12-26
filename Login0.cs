using Ajans_X.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ajans_X
{
    public partial class Login0 : Form
    {
        public Login0()
        {
            InitializeComponent();
        }
        CultureInfo cultures = new CultureInfo("en-US");
        private void button1_Click(object sender, EventArgs e)
        {
            classes.Actress worker = new classes.Actress () ;

            worker.Name = textBox1.Text;
            worker.Surname = textBox2.Text;
            worker.Age = Convert.ToInt32( textBox3.Text);
            worker.OffDays = dateTimePicker1.Value;
            worker.Salary = Convert.ToInt64( textBox4.Text);

            worker.Role = comboBox1.SelectedItem.ToString();
            worker.Status = Convert.ToBoolean( comboBox2.SelectedItem);

            string[] datas = new string[] { "1", worker.Name, worker.Surname, worker.Age.ToString(), worker.OffDays.ToString(), worker.Salary.ToString(), worker.Role, worker.Status.ToString(), "yok" };

            dataGridView1.Rows.Add(datas);

            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //classes.RadioProject radioprj= new classes.RadioProject();

            //radioprj.Id = 1;
            //radioprj.PrjName = "reklam";
            //radioprj.Start = DateTime.Parse("2020-10-09");
            ////radioprj.Finish = Convert.ToDateTime("2020-15-09");
            //radioprj.Price=1000000.99F;
            //radioprj.Rworker = new Actress();
            //radioprj.OfficeW = new OfficeWorker();

            //MessageBox.Show(radioprj.Start.ToString()+"\n"+radioprj.Price.ToString());



        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
