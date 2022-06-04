using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quan_Li_Sinh_Vien.STUDENT;
using Quan_Li_Sinh_Vien.COURSE;
using System.Data.SqlClient;

namespace Quan_Li_Sinh_Vien.SCORE
{
    public partial class ManageScoreForm : Form
    {
        public ManageScoreForm()
        {
            InitializeComponent();
        }
        Score score = new Score();
        Student student = new Student();
        Course course = new Course();
        string data = "score";
        
        private void ManageScoreForm_Load(object sender, EventArgs e)
        {

            textBoxSelectCourse.DataSource = course.getAllCourse();
            textBoxSelectCourse.DisplayMember = "label";
            textBoxSelectCourse.ValueMember = "id";
            dataGridView1.DataSource = score.getStudentsScore();
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void button_ShowStudent_Click(object sender, EventArgs e)
        {
            data = "student";
            SqlCommand command = new SqlCommand("SELECT id, fname, lname, bdate FROM Student");
            dataGridView1.DataSource = student.getStudents(command);
        }

        private void button_ShowScore_Click(object sender, EventArgs e)
        {
            data = "score";
            dataGridView1.DataSource = score.getStudentsScore();
        }

        private void buttonAddScore_Click(object sender, EventArgs e)
        {
            try
            {
                int Student_ID = Convert.ToInt32(textBoxStudentID.Text);
                int Course_ID = Convert.ToInt32(textBoxSelectCourse.SelectedValue);
                double ScoreGK = Convert.ToDouble(textBoxScoreGK.Text);
                double ScoreCK = Convert.ToDouble(textBoxScoreCK.Text);
                string GhiChu = textBoxGhiChu.Text;
                if (score.studentScoreExist(Student_ID, Course_ID))
                {
                    MessageBox.Show("Sinh viên đã có điểm môn này !", "Thêm điểm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (verif())
                {
                    if (score.InsertScore(Student_ID, Course_ID, ScoreGK,ScoreCK, GhiChu))
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
            if ((textBoxStudentID.Text.Trim() == "")
                || (textBoxSelectCourse.Text.Trim() == "")
                || ((textBoxScoreGK.Text.Trim() == "") && (textBoxScoreCK.Text.Trim() == ""))
                )
            {
                return false;
            }
            else return true;
        }

        private void button_Remove_Click(object sender, EventArgs e)
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
        public void getDataFromDataGridView()
        {
            if(data =="student")
            {
                textBoxStudentID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
            else if(data =="score")
            {
                textBoxStudentID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBoxSelectCourse.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value;
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            getDataFromDataGridView();
        }

        private void button_AvgScoreByCourse_Click(object sender, EventArgs e)
        {
            AvgScoreByCourse ASBC = new AvgScoreByCourse();
            ASBC.Show(this);
        }
    }
}
