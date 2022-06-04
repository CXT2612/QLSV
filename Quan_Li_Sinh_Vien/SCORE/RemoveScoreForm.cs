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
    public partial class RemoveScoreForm : Form
    {
        public RemoveScoreForm()
        {
            InitializeComponent();
        }
        Score score = new Score();

        private void RemoveScoreForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = score.getStudentsScore();
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void buttonRemoveScore_Click(object sender, EventArgs e)
        {
            int StudentId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int CourseId = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa điểm này không ?", "Xóa điểm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                if (score.deleteScore(StudentId, CourseId))
                {
                    MessageBox.Show("Điểm đã bị xóa", "Xóa điểm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = score.getStudentsScore();
                }
                else
                {
                    MessageBox.Show("Điểm không bị xóa", "Xóa điểm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
