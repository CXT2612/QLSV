using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Sinh_Vien.COURSE
{
    public partial class AddCourseForm : Form
    {
        public AddCourseForm()
        {
            InitializeComponent();
        }
        Course course = new Course();
        private void bt_Add_Click(object sender, EventArgs e)
        {
            if (textBoxCourseID.Text =="")
            {
                MessageBox.Show("Vui lòng nhập Id", "Thêm khóa học", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            else if (verif())
            {
                int Id = Convert.ToInt32(textBoxCourseID.Text);
                string lable = textBoxLabel.Text;
                int stc  = Convert.ToInt32(textBoxSTC.Text);
                int hk  = Convert.ToInt32(textBoxHocKi.Text); 
                

                if (course.checkcourseid(Id) ==  false)
                {
                    MessageBox.Show("Đã có Id này trong database !", "Thêm khóa học", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (course.checkcoursename(lable) == false)
                {
                    MessageBox.Show("Tên khóa học này đã tồn tại !", "Thêm khóa học", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
                else
                {
                    if (course.InsertCourse(Id, lable, stc, hk))
                    {
                        MessageBox.Show("Khóa học mới đã được chèn", "Thêm khóa học", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Khóa học không được chèn", "Thêm khóa học", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Còn các dòng trống !", "Thêm khóa học", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        bool verif()
        {
            if ((textBoxLabel.Text.Trim() == "")
                || (textBoxSTC.Text.Trim() == "")
                || (textBoxHocKi.Text.Trim() == ""))
            {
                return false;
            }
            else return true;
        }
        private void textBoxCourseID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
