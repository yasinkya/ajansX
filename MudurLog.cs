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

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void MudurLog_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dukkanDataSet1.tblUrun' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tblUrunTableAdapter.Fill(this.dukkanDataSet1.tblUrun);

        }
    }
}
