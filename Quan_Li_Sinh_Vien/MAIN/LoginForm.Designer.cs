
namespace Quan_Li_Sinh_Vien
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Login = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButtonStudent = new System.Windows.Forms.RadioButton();
            this.radioButtonHumanResource = new System.Windows.Forms.RadioButton();
            this.labelNewUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Login.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Login.Location = new System.Drawing.Point(177, 92);
            this.Login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(170, 30);
            this.Login.TabIndex = 17;
            this.Login.Text = "Account Login:";
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_login.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_login.Location = new System.Drawing.Point(242, 258);
            this.button_login.Margin = new System.Windows.Forms.Padding(2);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(93, 37);
            this.button_login.TabIndex = 16;
            this.button_login.Text = "LOGIN";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button_cancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_cancel.Location = new System.Drawing.Point(125, 258);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(95, 36);
            this.button_cancel.TabIndex = 15;
            this.button_cancel.Text = "CANCEL";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxpassword.Location = new System.Drawing.Point(182, 201);
            this.textBoxpassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.PasswordChar = '*';
            this.textBoxpassword.Size = new System.Drawing.Size(155, 26);
            this.textBoxpassword.TabIndex = 14;
            // 
            // textBoxusername
            // 
            this.textBoxusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxusername.Location = new System.Drawing.Point(182, 159);
            this.textBoxusername.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(155, 28);
            this.textBoxusername.TabIndex = 13;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Password.Location = new System.Drawing.Point(70, 203);
            this.Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(92, 24);
            this.Password.TabIndex = 12;
            this.Password.Text = "Password";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Username.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Username.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Username.Location = new System.Drawing.Point(70, 159);
            this.Username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(94, 24);
            this.Username.TabIndex = 11;
            this.Username.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(52, 173);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(9, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // radioButtonStudent
            // 
            this.radioButtonStudent.AutoSize = true;
            this.radioButtonStudent.Checked = true;
            this.radioButtonStudent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioButtonStudent.Location = new System.Drawing.Point(140, 331);
            this.radioButtonStudent.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonStudent.Name = "radioButtonStudent";
            this.radioButtonStudent.Size = new System.Drawing.Size(80, 23);
            this.radioButtonStudent.TabIndex = 18;
            this.radioButtonStudent.TabStop = true;
            this.radioButtonStudent.Text = "ADMIN";
            this.radioButtonStudent.UseVisualStyleBackColor = true;
            // 
            // radioButtonHumanResource
            // 
            this.radioButtonHumanResource.AutoSize = true;
            this.radioButtonHumanResource.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioButtonHumanResource.Location = new System.Drawing.Point(242, 331);
            this.radioButtonHumanResource.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonHumanResource.Name = "radioButtonHumanResource";
            this.radioButtonHumanResource.Size = new System.Drawing.Size(97, 23);
            this.radioButtonHumanResource.TabIndex = 19;
            this.radioButtonHumanResource.Text = "STUDENT";
            this.radioButtonHumanResource.UseVisualStyleBackColor = true;
            // 
            // labelNewUser
            // 
            this.labelNewUser.AutoSize = true;
            this.labelNewUser.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelNewUser.Location = new System.Drawing.Point(9, 334);
            this.labelNewUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNewUser.Name = "labelNewUser";
            this.labelNewUser.Size = new System.Drawing.Size(119, 16);
            this.labelNewUser.TabIndex = 20;
            this.labelNewUser.Text = "New User Student ?";
            this.labelNewUser.Click += new System.EventHandler(this.labelNewUser_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(388, 362);
            this.Controls.Add(this.labelNewUser);
            this.Controls.Add(this.radioButtonHumanResource);
            this.Controls.Add(this.radioButtonStudent);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.textBoxpassword);
            this.Controls.Add(this.textBoxusername);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.TextBox textBoxpassword;
        private System.Windows.Forms.TextBox textBoxusername;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButtonStudent;
        private System.Windows.Forms.RadioButton radioButtonHumanResource;
        private System.Windows.Forms.Label labelNewUser;
    }
}