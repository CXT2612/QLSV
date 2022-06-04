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
    public partial class RemoveCourseForm : Form
    {
        public RemoveCourseForm()
        {
            InitializeComponent();
        }
        Course course = new Course();
        private void bt_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                int CourseId = Convert.ToInt32(textBoxCourseID.Text);

                if ((MessageBox.Show("Bạn có chắc chắn muốn xóa khóa học này không ?", "Xóa khóa học", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (course.deleteCourse(CourseId))
                    {
                        MessageBox.Show("Khóa học đã được xóa", "Xóa khóa học", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxCourseID.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Khóa học không được xóa", "Xóa khóa học", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập một ID hợp lệ", "Xóa khóa học", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
