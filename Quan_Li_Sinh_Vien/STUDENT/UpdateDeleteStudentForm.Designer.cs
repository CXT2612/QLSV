
namespace Quan_Li_Sinh_Vien.STUDENT
{
    partial class UpdateDeleteStudentForm
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
            this.bt_Remove = new System.Windows.Forms.Button();
            this.bt_Edit = new System.Windows.Forms.Button();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bt_Find = new System.Windows.Forms.Button();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.DatetimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textboxLname = new System.Windows.Forms.TextBox();
            this.textboxFname = new System.Windows.Forms.TextBox();
            this.textboxID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID_Class = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_Remove
            // 
            this.bt_Remove.AutoSize = true;
            this.bt_Remove.BackColor = System.Drawing.Color.Blue;
            this.bt_Remove.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_Remove.ForeColor = System.Drawing.Color.Transparent;
            this.bt_Remove.Location = new System.Drawing.Point(363, 251);
            this.bt_Remove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_Remove.Name = "bt_Remove";
            this.bt_Remove.Size = new System.Drawing.Size(115, 35);
            this.bt_Remove.TabIndex = 34;
            this.bt_Remove.Text = "Remove";
            this.bt_Remove.UseVisualStyleBackColor = false;
            this.bt_Remove.Click += new System.EventHandler(this.bt_Remove_Click);
            // 
            // bt_Edit
            // 
            this.bt_Edit.BackColor = System.Drawing.Color.Blue;
            this.bt_Edit.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_Edit.ForeColor = System.Drawing.Color.Transparent;
            this.bt_Edit.Location = new System.Drawing.Point(130, 251);
            this.bt_Edit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_Edit.Name = "bt_Edit";
            this.bt_Edit.Size = new System.Drawing.Size(115, 35);
            this.bt_Edit.TabIndex = 33;
            this.bt_Edit.Text = "Edit";
            this.bt_Edit.UseVisualStyleBackColor = false;
            this.bt_Edit.Click += new System.EventHandler(this.bt_Edit_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxAddress.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxAddress.Location = new System.Drawing.Point(381, 39);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(250, 80);
            this.textBoxAddress.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Olive;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(319, 141);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "ID_Class";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Olive;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(325, 42);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Address";
            // 
            // bt_Find
            // 
            this.bt_Find.BackColor = System.Drawing.Color.Blue;
            this.bt_Find.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_Find.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_Find.Location = new System.Drawing.Point(206, 36);
            this.bt_Find.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_Find.Name = "bt_Find";
            this.bt_Find.Size = new System.Drawing.Size(80, 28);
            this.bt_Find.TabIndex = 27;
            this.bt_Find.Text = "Find";
            this.bt_Find.UseVisualStyleBackColor = false;
            this.bt_Find.Click += new System.EventHandler(this.bt_Find_Click);
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.BackColor = System.Drawing.Color.Olive;
            this.radioButtonFemale.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioButtonFemale.ForeColor = System.Drawing.Color.White;
            this.radioButtonFemale.Location = new System.Drawing.Point(206, 167);
            this.radioButtonFemale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(66, 20);
            this.radioButtonFemale.TabIndex = 26;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = false;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.BackColor = System.Drawing.Color.Olive;
            this.radioButtonMale.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radioButtonMale.ForeColor = System.Drawing.Color.White;
            this.radioButtonMale.Location = new System.Drawing.Point(121, 167);
            this.radioButtonMale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(53, 20);
            this.radioButtonMale.TabIndex = 25;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = false;
            // 
            // DatetimePicker1
            // 
            this.DatetimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.DatetimePicker1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DatetimePicker1.Location = new System.Drawing.Point(106, 136);
            this.DatetimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DatetimePicker1.Name = "DatetimePicker1";
            this.DatetimePicker1.Size = new System.Drawing.Size(181, 23);
            this.DatetimePicker1.TabIndex = 24;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxPhone.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxPhone.Location = new System.Drawing.Point(106, 197);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(181, 23);
            this.textBoxPhone.TabIndex = 23;
            this.textBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhone_KeyPress);
            // 
            // textboxLname
            // 
            this.textboxLname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textboxLname.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textboxLname.Location = new System.Drawing.Point(106, 105);
            this.textboxLname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxLname.Name = "textboxLname";
            this.textboxLname.Size = new System.Drawing.Size(181, 23);
            this.textboxLname.TabIndex = 22;
            // 
            // textboxFname
            // 
            this.textboxFname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textboxFname.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textboxFname.Location = new System.Drawing.Point(106, 72);
            this.textboxFname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxFname.Name = "textboxFname";
            this.textboxFname.Size = new System.Drawing.Size(181, 23);
            this.textboxFname.TabIndex = 21;
            // 
            // textboxID
            // 
            this.textboxID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textboxID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textboxID.Location = new System.Drawing.Point(106, 39);
            this.textboxID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textboxID.Name = "textboxID";
            this.textboxID.Size = new System.Drawing.Size(97, 23);
            this.textboxID.TabIndex = 20;
            this.textboxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxID_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Olive;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(51, 200);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Olive;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Olive;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(46, 168);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Olive;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(33, 141);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "BirthDate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Olive;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Olive;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID";
            // 
            // textBoxID_Class
            // 
            this.textBoxID_Class.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxID_Class.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxID_Class.Location = new System.Drawing.Point(381, 138);
            this.textBoxID_Class.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxID_Class.Name = "textBoxID_Class";
            this.textBoxID_Class.Size = new System.Drawing.Size(250, 23);
            this.textBoxID_Class.TabIndex = 82;
            // 
            // UpdateDeleteStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 305);
            this.Controls.Add(this.textBoxID_Class);
            this.Controls.Add(this.bt_Remove);
            this.Controls.Add(this.bt_Edit);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bt_Find);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.DatetimePicker1);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textboxLname);
            this.Controls.Add(this.textboxFname);
            this.Controls.Add(this.textboxID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UpdateDeleteStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateDeleteStudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button bt_Remove;
        public System.Windows.Forms.Button bt_Edit;
        public System.Windows.Forms.TextBox textBoxAddress;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button bt_Find;
        public System.Windows.Forms.RadioButton radioButtonFemale;
        public System.Windows.Forms.RadioButton radioButtonMale;
        public System.Windows.Forms.DateTimePicker DatetimePicker1;
        public System.Windows.Forms.TextBox textBoxPhone;
        public System.Windows.Forms.TextBox textboxLname;
        public System.Windows.Forms.TextBox textboxFname;
        public System.Windows.Forms.TextBox textboxID;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxID_Class;
    }
}