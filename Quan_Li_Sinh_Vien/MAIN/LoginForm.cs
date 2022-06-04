using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Li_Sinh_Vien
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (radioButtonStudent.Checked)
            {
                MY_DB db = new MY_DB();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT * FROM login WHERE username =@User AND password =@Pass", db.getConnection);
                command.Parameters.Add("@User", SqlDbType.NChar).Value = textBoxusername.Text;
                command.Parameters.Add("@Pass", SqlDbType.NChar).Value = textBoxpassword.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if ((table.Rows.Count > 0))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(radioButtonHumanResource.Checked)
            {
                MY_DB mydb = new MY_DB();
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT *  FROM login WHERE username =@id AND password =@Pass", mydb.getConnection);
                command.Parameters.Add("@id", SqlDbType.NChar).Value = textBoxusername.Text;
                command.Parameters.Add("@Pass", SqlDbType.NChar).Value = textBoxpassword.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if ((table.Rows.Count > 0))
                {
                    
                    this.DialogResult = DialogResult.Yes;
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("../../images/logo.png");
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void labelNewUser_Click(object sender, EventArgs e)
        {
            CreateNewAccount CNA = new CreateNewAccount();
            CNA.Show(this);
        }
        
    }
}
