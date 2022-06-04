using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Sinh_Vien.STUDENT
{
    public partial class StaticForm : Form
    {
        public StaticForm()
        {
            InitializeComponent();
        }
        Student student = new Student();
        Color panTotalColor;
        Color panMaleColor;
        Color panFemaleColor;
        private void StaticForm_Load(object sender, EventArgs e)
        {
            panTotalColor = panel1.BackColor;
            panMaleColor = panel2.BackColor;
            panFemaleColor = panel3.BackColor;
            double totalStudent = Convert.ToDouble(student.totalStudent());
            double totalMale = Convert.ToDouble(student.totalMaleStudent());
            double totalFemale = Convert.ToDouble(student.totalFemaleStudent());

            double malePercentage = totalMale * 100 / totalStudent;
            double femalePercentage = totalFemale * 100 / totalStudent;
            labelTotal.Text = ("Total Studentt: " + totalStudent.ToString());
            labelMale.Text = ("Male: " + malePercentage.ToString("0.00") + "%");
            labelFemale.Text = ("Female: " + femalePercentage.ToString("0.00") +"%");
        }

        private void labelTotal_MouseEnter(object sender, EventArgs e)
        {
            panel1.BackColor = Color.White;
            labelTotal.ForeColor = panTotalColor;
        }

        private void labelTotal_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = panTotalColor;
            labelTotal.ForeColor = Color.White;
        }

        private void labelMale_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.White;
            labelMale.ForeColor = panMaleColor;
        }

        private void labelMale_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = panMaleColor;
            labelMale.ForeColor = Color.White;
        }

        private void labelFamale_MouseEnter(object sender, EventArgs e)
        {
            panel3.BackColor = Color.White;
            labelFemale.ForeColor = panFemaleColor;
        }

        private void labelFamale_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = panFemaleColor;
            labelFemale.ForeColor = Color.White;
        }

        private void labelTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
