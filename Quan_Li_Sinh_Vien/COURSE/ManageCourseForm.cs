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
    public partial class ManageCourseForm : Form
    {
        public ManageCourseForm()
        {
            InitializeComponent();
        }
        Course course = new Course();
        int pos;

        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            reloadListBoxData();
        }
        void reloadListBoxData()
        {
            listBoxCourse.DataSource = course.getAllCourse();
            listBoxCourse.ValueMember = "id";
            listBoxCourse.DisplayMember = "label";
            listBoxCourse.SelectedItem = null;

            labeltotalcourse.Text = ("Total Course: " + course.totalCourse());
        }
        void ShowData(int index)
        {
            DataRow dr = course.getAllCourse().Rows[index];
            listBoxCourse.SelectedIndex = index;
            textBoxCourseId.Text = dr.ItemArray[0].ToString();
            textBoxLabel.Text = dr.ItemArray[1].ToString();
            numbericUpDownSTC.Value = int.Parse(dr.ItemArray[2].ToString());
            textBoxHocKi.Text = dr.ItemArray[3].ToString();
            
        }

        private void listBoxCourse_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)listBoxCourse.SelectedItem;
            pos = listBoxCourse.SelectedIndex;
            ShowData(pos);
        }

        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            if (textBoxCourseId.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ID", "Thêm khóa học", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (course.checkcourseid(Convert.ToInt32(textBoxCourseId.Text)))
            {
                int Id = Convert.ToInt32(textBoxCourseId.Text);
                string name = textBoxLabel.Text;
                int stc = (int)numbericUpDownSTC.Value;
                int hk = Convert.ToInt32(textBoxHocKi.Text);
                
                if (name.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập tên khóa học", "Thêm khóa học", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else if (course.checkcoursename(name))
                {
                    if (course.InsertCourse(Id, name, stc, hk))
                    {
                        MessageBox.Show("Khóa học mới đã được chèn ", "Thêm khóa học", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reloadListBoxData();
                    }
                    else
                    {
                        MessageBox.Show("Khóa học không được chèn", "Thêm khóa học", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Tên khóa học này đã tồn tại !", "Thêm khóa học", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Đã có ID này trong database !", "Thêm khóa học", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonEditCourse_Click(object sender, EventArgs e)
        {
            if (textBoxCourseId.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ID", "Chỉnh sửa khóa học", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (course.checkcourseid(Convert.ToInt32(textBoxCourseId.Text)) == false)
            {
                int Id = Convert.ToInt32(textBoxCourseId.Text);
                string name = textBoxLabel.Text;
                int stc = (int)numbericUpDownSTC.Value;
                int hk = Convert.ToInt32(textBoxHocKi.Text);
                
                if (name == "")
                {
                    MessageBox.Show("Vui lòng nhập tên khóa học !", "Chỉnh sửa khóa học", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!course.checkcoursename(name, Id))
                {
                    MessageBox.Show("Tên khóa học này đã tồn tại", "Chỉnh sửa khóa học", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (course.updateCourse(Id, name, stc, hk))
                {
                    MessageBox.Show("Đã cập nhật khóa học", "Chỉnh sửa khóa học", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Khóa học không được cập nhật", "Chỉnh sửa khóa học", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                pos = 0;
            }
            else
            {
                MessageBox.Show("Không có ID này trong database !", "Chỉnh sửa khóa học", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonRemoveCourse_Click(object sender, EventArgs e)
        {
            try
            {
                int CourseId = Convert.ToInt32(textBoxCourseId.Text);

                if ((MessageBox.Show("Bạn có chắc chắn muốn xóa khóa học này không ?", "Xóa khóa học", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (course.deleteCourse(CourseId))
                    {
                        MessageBox.Show("Khóa học đã được xóa", "Xóa khóa học", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxCourseId.Text = "";
                        textBoxLabel.Text = "";
                        numbericUpDownSTC.Value = 3;
                        textBoxHocKi.Text = "";
                        
                        reloadListBoxData();
                    }
                    else
                    {
                        MessageBox.Show("Khóa học không được xóa", "Xóa khóa học", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập một ID hợp lệ !", "Delete course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            pos = 0;
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            pos = 0;
            ShowData(0);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (pos < (course.getAllCourse().Rows.Count - 1))
            {
                pos = pos + 1;
                ShowData(pos);
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (pos > 0)
            {
                pos = pos - 1;
                ShowData(pos);
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            pos = course.getAllCourse().Rows.Count - 1;
            ShowData(pos);
        }
    }
}
