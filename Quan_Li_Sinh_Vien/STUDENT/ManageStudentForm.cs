using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Sinh_Vien.STUDENT
{
    public partial class ManageStudentForm : Form
    {
        public ManageStudentForm()
        {
            InitializeComponent();
        }
        Student student = new Student();
        public void fillGrid(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn piCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            //colum 7 is the image colum index
            dataGridView1.AllowUserToAddRows = false;

            //Dem sinh vien
            LabelTotalStudents.Text = ("Total Students: " + dataGridView1.Rows.Count);
        }

        private void ManageStudentForm_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("SELECT * FROM Student"));
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBoxStudentID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxFname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxLname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;
            //GENGER
            RadioButtonFemale.Checked = true;
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "1")
            {
               RadioButtonMale.Checked = true;
            }
            textBoxPhone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBoxAddress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBoxID_Class.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM  Student WHERE CONCAT(fname,lname,address) LIKE'%" + textBoxSearch.Text + "%'");
            fillGrid(command);
        }


        private void button_Reset_Click(object sender, EventArgs e)
        {
            textBoxStudentID.Text = "";
            textBoxFname.Text = "";
            textBoxLname.Text = "";
            textBoxAddress.Text = "";
            textBoxPhone.Text = "";
            textBoxID_Class.Text = "";
            RadioButtonMale.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                int studentID = Convert.ToInt32(textBoxStudentID.Text);

                if ((MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không", "Xóa học sinh", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (student.deleteStudent(studentID))
                    {
                        MessageBox.Show("Sinh viên đã bị xóa", "Xóa học sinh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxStudentID.Text = "";
                        textBoxFname.Text = "";
                        textBoxLname.Text = "";
                        textBoxAddress.Text = "";
                        textBoxPhone.Text = "";
                        textBoxID_Class.Text = "";
                        dateTimePicker1.Value = DateTime.Now;
                        fillGrid(new SqlCommand("SELECT * FROM Student"));
                    }
                    else
                    {
                        MessageBox.Show("Lỗi", "Xóa học sinh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên", "Xóa học sinh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            if (textBoxStudentID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên !", "Chỉnh sửa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (student.checkIdstudent(Convert.ToInt32(textBoxStudentID.Text)) == true)
            {
                MessageBox.Show("Sinh viên không có trong database !", "Chỉnh sửa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int id;
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
                    MessageBox.Show("Tuổi sinh viên phải từ 10 đến 100 tuổi !", "Ngày sinh không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else if (verif())
                {
                    try
                    {
                        id = Convert.ToInt32(textBoxStudentID.Text);

                        if (student.updateStudent(id, fname, lname, bdate, gender, phone, adrs, cls))
                        {
                            MessageBox.Show("Thông tin sinh viên được cập nhật", "Chỉnh sửa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fillGrid(new SqlCommand("SELECT * FROM Student"));
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
        bool verif()
        {
            if ((textBoxFname.Text.Trim() == "")
                || (textBoxLname.Text.Trim() == "")
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

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (textBoxStudentID.Text.Trim()=="")
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
                else if (verif())
                {
                    if (student.InsertStudents(id, fname, lname, bdate, gender, phone, adrs, cls))
                    {
                        MessageBox.Show("Sinh viên đã được thêm vào !", "Thêm sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillGrid(new SqlCommand("SELECT * FROM Student"));
                    }
                    else
                    {
                        MessageBox.Show("Lỗi!", "Thêm sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void textBoxStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
