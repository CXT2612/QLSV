using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Sinh_Vien.STUDENT
{
    public partial class UpdateDeleteStudentForm : Form
    {
        public UpdateDeleteStudentForm()
        {
            InitializeComponent();
        }
        Student student = new Student();
        private void bt_Find_Click(object sender, EventArgs e)
        {
            if (textboxID.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int id = int.Parse(textboxID.Text);
                SqlCommand command = new SqlCommand("Select id, fname, lname, bdate, gender, phone, address, group_id FROM Student WHERE id = " + id);
                DataTable table = student.getStudents(command);
                if (table.Rows.Count > 0)
                {
                    textboxFname.Text = table.Rows[0]["fname"].ToString();
                    textboxLname.Text = table.Rows[0]["lname"].ToString();
                    DatetimePicker1.Value = (DateTime)table.Rows[0]["bdate"];
                    if (table.Rows[0]["gender"].ToString() == "0")
                    {
                        radioButtonFemale.Checked = true;
                    }
                    else
                    {
                        radioButtonMale.Checked = true;

                    }
                    textBoxPhone.Text = table.Rows[0]["phone"].ToString();
                    textBoxAddress.Text = table.Rows[0]["address"].ToString();
                    textBoxID_Class.Text = table.Rows[0]["group_id"].ToString();
                    
                }
                else
                {
                    MessageBox.Show("Không tìm thấy", "Tìm sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        
        private void textboxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void bt_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = Convert.ToInt32(textboxID.Text);

                if ((MessageBox.Show("Bạn muốn xóa sinh viên này ?", "Xóa sinh viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (student.deleteStudent(studentID))
                    {
                        MessageBox.Show("Đã xóa sinh viên", "Xóa sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textboxID.Text = "";
                        textboxFname.Text = "";
                        textboxLname.Text = "";
                        textBoxAddress.Text = "";
                        textBoxPhone.Text = "";
                        DatetimePicker1.Value = DateTime.Now;
                        textBoxID_Class.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Xóa sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập ID sinh viên", "Xóa sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        bool verif()
        {
            if ((textboxFname.Text.Trim() == "")
                || (textboxLname.Text.Trim() == "")
                || (textBoxPhone.Text.Trim() == "")
                )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void bt_Edit_Click(object sender, EventArgs e)
        {
            if (textboxID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên !", "Chỉnh sửa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (student.checkIdstudent(Convert.ToInt32(textboxID.Text)) == true)
            {
                MessageBox.Show("Sinh viên không có trong database !", "Chỉnh sửa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int id;
                string fname = textboxFname.Text;
                string lname = textboxLname.Text;
                DateTime bdate = DatetimePicker1.Value;
                string phone = textBoxPhone.Text;
                string adrs = textBoxAddress.Text;
                string gender = "1";
                int cls = Convert.ToInt32(textBoxID_Class.Text);

                if (radioButtonFemale.Checked)
                {
                    gender = "0";
                }
                int born_year = DatetimePicker1.Value.Year;
                int this_year = DateTime.Now.Year;

                if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
                {
                    MessageBox.Show("Tuổi sinh viên phải từ 10 đến 100 tuổi !", "Ngày sinh không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else if (verif())
                {
                    try
                    {
                        id = Convert.ToInt32(textboxID.Text);

                        if (student.updateStudent(id, fname, lname, bdate, gender, phone, adrs, cls))
                        {
                            MessageBox.Show("Thông tin sinh viên được cập nhật", "Chỉnh sửa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Lỗi", "Chỉnh sửa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Chỉnh sửa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Còn các dòng trống", "Chỉnh sửa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        
        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
    }
}
