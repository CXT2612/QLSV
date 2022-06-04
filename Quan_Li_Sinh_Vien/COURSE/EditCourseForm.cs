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
    public partial class EditCourseForm : Form
    {
        public EditCourseForm()
        {
            InitializeComponent();
        }
        Course course = new Course();
        
        private void EditCourseForm_Load(object sender, EventArgs e)
        {

            comboBoxCourseId.DataSource = course.getAllCourse();
            comboBoxCourseId.DisplayMember = "label";
            comboBoxCourseId.ValueMember = "id";
            comboBoxCourseId.SelectedItem = null;
        }
        private void comboBoxCourseId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //lay du lieu
                int id = Convert.ToInt32(comboBoxCourseId.SelectedValue);
                DataTable table = new DataTable();
                table = course.getCourseById(id);
                textBoxLabel.Text = table.Rows[0][1].ToString();
                numericUpDownSTC.Value = Int32.Parse(table.Rows[0][2].ToString());
                textBoxHocKi.Text = table.Rows[0][3].ToString();
                
            }
            catch { }
        }
        private void bt_Edit_Click(object sender, EventArgs e)
        {
            if (comboBoxCourseId.Text == "")
            {
                MessageBox.Show("Vui lòng chọn ID", "Chỉnh sửa khóa học", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(verif())
            {
                string name = textBoxLabel.Text;
                int stc = (int)numericUpDownSTC.Value;
                int hk = Convert.ToInt32(textBoxHocKi.Text);
                
                int id = (int)comboBoxCourseId.SelectedValue;

                //lay lai phan kiem tra ten course

                if (!course.checkcoursename(name, id))
                {
                    MessageBox.Show("Tên khóa học này đã tồn tại", "Chỉnh sửa khóa học", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (course.updateCourse(id, name, stc, hk))
                {
                    MessageBox.Show("Đã cập nhật khóa học", "Chỉnh sửa khóa học", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillcombo(comboBoxCourseId.SelectedIndex);
                }
                else
                {
                    MessageBox.Show("Khóa học không được cập nhật", "Chỉnh sửa khóa học", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Còn dòng trống !", "Chỉnh sửa khóa học", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        bool verif()
        {
            if ((textBoxLabel.Text.Trim() == "")
                || (textBoxHocKi.Text.Trim() == ""))
            {
                return false;
            }
            else return true;
        }
        private void fillcombo(int index)
        {
            comboBoxCourseId.DataSource = course.getAllCourse();
            comboBoxCourseId.DisplayMember = "label";
            comboBoxCourseId.ValueMember = "id";
            comboBoxCourseId.SelectedIndex = index;
        }

        
    }
}
