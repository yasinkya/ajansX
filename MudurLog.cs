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
    public partial class MudurLog : Form
    {
        public MudurLog()
        {
            InitializeComponent();
        }
        database.DB_Connection database;
        private void MudurLog_Load(object sender, EventArgs e)
        {
            database = new database.DB_Connection();
        }
        

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvList.DataSource = database.ActressesList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            dgvList.DataSource = database.OfficersList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvList.DataSource = database.ProjectsList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvList.DataSource = database.CompaniesList();
        }
        private void button5_Click(object sender, EventArgs e)
        {

        }

        
    }
}
