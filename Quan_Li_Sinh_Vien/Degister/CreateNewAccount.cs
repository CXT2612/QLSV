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
using Quan_Li_Sinh_Vien.Degister;
namespace Quan_Li_Sinh_Vien
{
    public partial class CreateNewAccount : Form
    {
        public CreateNewAccount()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Close();
        }
        User user = new User();
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxSV_ID.Text);
            string password = textBoxPassword.Text;

            if (verif())
            {
                if (user.InsertLoGin_SV(id, password))
                {
                    MessageBox.Show("New SV Added", "Add SV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add SV", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Còn các thông tin trống", "Add SV", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool verif()
        {
            if ((textBoxSV_ID.Text.Trim() == "")
               || (textBoxPassword.Text.Trim() == "")
               )

            {
                return false;
            }
            else
            {
                return true;
            }
        }
        
    }
    
}

