using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Sinh_Vien.STUDENT
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }
        Student student = new Student();
        private void button_Add_Click(object sender, EventArgs e)
        {
            if (textBoxStudentID.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (student.checkIdstudent(Convert.ToInt32(textBoxStudentID.Text)) == false)
            {
                MessageBox.Show("Mã sinh viên này đã có trong database !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int id = Convert.ToInt32(textBoxStudentID.Text);
                string fname = textBoxFname.Text;
                string lname = textBoxLname.Text;
                DateTime bdate = dateTimePicker1.Value;
                string phone = textBoxPhone.Text;
                string adrs = textBoxAddress.Text;
                string gender = "1";
                int cls = Convert.ToInt32(textBoxID_Class.Text);

                if (RadioButtonFemale.Checked)
                {
                    gender = "0";
                }
                int born_year = dateTimePicker1.Value.Year;
                int this_year = DateTime.Now.Year;
                if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
                {
                    MessageBox.Show("Tuổi sinh viên phải từ 10 đến 100 tuổi !", "Ngày sinh không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (verif())
                {
                    if (student.InsertStudents(id, fname, lname, bdate, gender, phone, adrs, cls ))
                    {
                        MessageBox.Show("Sinh viên đã được thêm vào !", "Thêm sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi!", "Thêm sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        bool verif()
        {
            if ((textBoxFname.Text.Trim() == "")
                || (textBoxLname.Text.Trim() == "")
                || (textBoxPhone.Text.Trim() == "")
                )
            {
                return false;
            }
            else return true;
        }
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void textBoxStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxID_Class_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
