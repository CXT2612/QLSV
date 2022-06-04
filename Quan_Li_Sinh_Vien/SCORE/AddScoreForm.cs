using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Sinh_Vien.SCORE
{
    public partial class AddScoreForm : Form
    {
        public AddScoreForm()
        {
            InitializeComponent();
        }
        Score score = new Score();
        
        private void buttonAddScore_Click(object sender, EventArgs e)
        {
            try
            {
                int Student_ID = Convert.ToInt32(textBoxSVID.Text);
                int Course_ID = Convert.ToInt32(textBoxSelectCourse.SelectedValue);
                double ScoreGK = Convert.ToDouble(textBoxDiemGK.Text);
                double ScoreCK = Convert.ToDouble(textBoxDiemCK.Text);
                string GhiChu = textBoxGhiChu.Text;
                if (score.studentScoreExist(Student_ID, Course_ID))
                {
                    MessageBox.Show("Sinh viên đã có điểm môn này !", "Thêm điểm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (verif())
                {
                    if (score.InsertScore(Student_ID, Course_ID, ScoreGK, ScoreCK, GhiChu))
                    {
                        MessageBox.Show("Thêm điểm mới", "Thêm điểm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Thêm điểm", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thêm điểm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool verif()
        {
            if ((textBoxSVID.Text.Trim() == "")
                || (textBoxSelectCourse.Text.Trim() == "")
                || ((textBoxDiemGK.Text.Trim() == "") && (textBoxDiemCK.Text.Trim() =="" ))
                )
            {
                return false;
            }
            else return true;
        }
        
        private void AddScoreForm_Load(object sender, EventArgs e)
        {
            textBoxSelectCourse.DataSource = score.getAllCourse();
            textBoxSelectCourse.DisplayMember = "label";
            textBoxSelectCourse.ValueMember = "id";
            SqlCommand command = new SqlCommand("SELECT id,fname,lname FROM Student");
            dataGridView1.DataSource = score.getStudents(command);
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBoxSVID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
