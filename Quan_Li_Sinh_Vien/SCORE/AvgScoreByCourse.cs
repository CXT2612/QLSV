using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Sinh_Vien.SCORE
{
    public partial class AvgScoreByCourse : Form
    {
        public AvgScoreByCourse()
        {
            InitializeComponent();
        }
        Score score = new Score();
        private void AvgScoreByCourse_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = score.getAvgScoreByCourse();
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
        }
    }
}
