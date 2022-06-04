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
using Quan_Li_Sinh_Vien.SCORE;
using Quan_Li_Sinh_Vien.RESULT;


namespace Quan_Li_Sinh_Vien
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm ATF = new AddStudentForm();
            ATF.Show(this);
        }


        private void EditRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm UDSF = new UpdateDeleteStudentForm();
            UDSF.Show(this);
        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintStudentForm PSF = new PrintStudentForm();
            PSF.Show(this);
        }

        private void ManageStudentsFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStudentForm MSF = new ManageStudentForm();
            MSF.Show(this);
        }

        private void AddCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            COURSE.AddCourseForm ACF = new COURSE.AddCourseForm();
            ACF.Show(this);
        }

        private void EditCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCourseForm ECF = new EditCourseForm();
            ECF.Show(this);
        }

        private void RemoveCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCourseForm RCF =new RemoveCourseForm();
            RCF.Show(this);
        }

        private void PrintToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintCourseForm PCF = new PrintCourseForm();
            PCF.Show(this);
        }

        private void ManageCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCourseForm MCF = new ManageCourseForm();
            MCF.Show(this);
        }

        private void AddScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScoreForm ASF = new AddScoreForm();
            ASF.Show(this);
        }

        private void RemoveScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveScoreForm RSF = new RemoveScoreForm();
            RSF.Show(this);
        }

        private void ManageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScoreForm MSF = new ManageScoreForm();
            MSF.Show(this);
        }

        private void AvgScoreByCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvgScoreByCourse ASBC = new AvgScoreByCourse();
            ASBC.Show(this);
        }

        private void PrintToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PrintScoreForm PSF = new PrintScoreForm();
            PSF.Show(this);
        }

        private void AvgResultByScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvgResultByScoreForm ARBSF =new AvgResultByScoreForm();
            ARBSF.Show(this);
        }

        

        private void StaticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticForm SF = new StaticForm();
            SF.Show(this);
        }
    }
}
