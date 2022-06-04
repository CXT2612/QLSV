
namespace Quan_Li_Sinh_Vien.STUDENT
{
    partial class ManageStudentForm
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
            this.LabelTotalStudents = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button_Search = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.RadioButtonFemale = new System.Windows.Forms.RadioButton();
            this.RadioButtonMale = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxLname = new System.Windows.Forms.TextBox();
            this.textBoxFname = new System.Windows.Forms.TextBox();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID_Class = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTotalStudents
            // 
            this.LabelTotalStudents.AutoSize = true;
            this.LabelTotalStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.LabelTotalStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelTotalStudents.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.LabelTotalStudents.Location = new System.Drawing.Point(632, 431);
            this.LabelTotalStudents.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelTotalStudents.Name = "LabelTotalStudents";
            this.LabelTotalStudents.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelTotalStudents.Size = new System.Drawing.Size(129, 23);
            this.LabelTotalStudents.TabIndex = 79;
            this.LabelTotalStudents.Text = "Total Students: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(306, 47);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(478, 370);
            this.dataGridView1.TabIndex = 78;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.BackColor = System.Drawing.Color.Red;
            this.button_Reset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_Reset.ForeColor = System.Drawing.Color.White;
            this.button_Reset.Location = new System.Drawing.Point(351, 448);
            this.button_Reset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(88, 34);
            this.button_Reset.TabIndex = 77;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = false;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // button_Remove
            // 
            this.button_Remove.BackColor = System.Drawing.Color.Red;
            this.button_Remove.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_Remove.ForeColor = System.Drawing.Color.White;
            this.button_Remove.Location = new System.Drawing.Point(246, 448);
            this.button_Remove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(88, 34);
            this.button_Remove.TabIndex = 76;
            this.button_Remove.Text = "Remove";
            this.button_Remove.UseVisualStyleBackColor = false;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(348, 16);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 16);
            this.label9.TabIndex = 75;
            this.label9.Text = "Search Fname, Lname, Address:";
            // 
            // button_Search
            // 
            this.button_Search.BackColor = System.Drawing.Color.Red;
            this.button_Search.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_Search.ForeColor = System.Drawing.Color.White;
            this.button_Search.Location = new System.Drawing.Point(697, 9);
            this.button_Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(88, 29);
            this.button_Search.TabIndex = 74;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxSearch.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxSearch.Location = new System.Drawing.Point(549, 9);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(144, 30);
            this.textBoxSearch.TabIndex = 73;
            // 
            // RadioButtonFemale
            // 
            this.RadioButtonFemale.AutoSize = true;
            this.RadioButtonFemale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.RadioButtonFemale.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.RadioButtonFemale.Location = new System.Drawing.Point(198, 145);
            this.RadioButtonFemale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioButtonFemale.Name = "RadioButtonFemale";
            this.RadioButtonFemale.Size = new System.Drawing.Size(66, 20);
            this.RadioButtonFemale.TabIndex = 70;
            this.RadioButtonFemale.TabStop = true;
            this.RadioButtonFemale.Text = "Female";
            this.RadioButtonFemale.UseVisualStyleBackColor = false;
            // 
            // RadioButtonMale
            // 
            this.RadioButtonMale.AutoSize = true;
            this.RadioButtonMale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.RadioButtonMale.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.RadioButtonMale.Location = new System.Drawing.Point(113, 145);
            this.RadioButtonMale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioButtonMale.Name = "RadioButtonMale";
            this.RadioButtonMale.Size = new System.Drawing.Size(53, 20);
            this.RadioButtonMale.TabIndex = 69;
            this.RadioButtonMale.TabStop = true;
            this.RadioButtonMale.Text = "Male";
            this.RadioButtonMale.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(35, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 68;
            this.label4.Text = "Address";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxPhone.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxPhone.Location = new System.Drawing.Point(100, 171);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(182, 23);
            this.textBoxPhone.TabIndex = 67;
            this.textBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhone_KeyPress);
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.Red;
            this.button_Add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_Add.ForeColor = System.Drawing.Color.White;
            this.button_Add.Location = new System.Drawing.Point(29, 448);
            this.button_Add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(88, 34);
            this.button_Add.TabIndex = 66;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.BackColor = System.Drawing.Color.Red;
            this.button_Edit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_Edit.ForeColor = System.Drawing.Color.White;
            this.button_Edit.Location = new System.Drawing.Point(139, 448);
            this.button_Edit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(88, 34);
            this.button_Edit.TabIndex = 65;
            this.button_Edit.Text = "Edit";
            this.button_Edit.UseVisualStyleBackColor = false;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxAddress.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxAddress.Location = new System.Drawing.Point(100, 206);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(182, 80);
            this.textBoxAddress.TabIndex = 63;
            // 
            // textBoxLname
            // 
            this.textBoxLname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxLname.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxLname.Location = new System.Drawing.Point(100, 85);
            this.textBoxLname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLname.Name = "textBoxLname";
            this.textBoxLname.Size = new System.Drawing.Size(182, 23);
            this.textBoxLname.TabIndex = 62;
            // 
            // textBoxFname
            // 
            this.textBoxFname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxFname.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxFname.Location = new System.Drawing.Point(100, 52);
            this.textBoxFname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFname.Name = "textBoxFname";
            this.textBoxFname.Size = new System.Drawing.Size(182, 23);
            this.textBoxFname.TabIndex = 61;
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxStudentID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxStudentID.Location = new System.Drawing.Point(100, 20);
            this.textBoxStudentID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(107, 23);
            this.textBoxStudentID.TabIndex = 60;
            this.textBoxStudentID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStudentID_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dateTimePicker1.Location = new System.Drawing.Point(100, 115);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(182, 23);
            this.dateTimePicker1.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(36, 303);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 58;
            this.label8.Text = "ID_Class";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(44, 173);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 57;
            this.label7.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(36, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 56;
            this.label6.Text = "GenDer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(26, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 55;
            this.label5.Text = "BirthDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(25, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 54;
            this.label3.Text = "Last name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(22, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 53;
            this.label2.Text = "First name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "Student ID";
            // 
            // textBoxID_Class
            // 
            this.textBoxID_Class.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxID_Class.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxID_Class.Location = new System.Drawing.Point(100, 301);
            this.textBoxID_Class.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxID_Class.Name = "textBoxID_Class";
            this.textBoxID_Class.Size = new System.Drawing.Size(182, 23);
            this.textBoxID_Class.TabIndex = 80;
            // 
            // ManageStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 492);
            this.Controls.Add(this.textBoxID_Class);
            this.Controls.Add(this.LabelTotalStudents);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.RadioButtonFemale);
            this.Controls.Add(this.RadioButtonMale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxLname);
            this.Controls.Add(this.textBoxFname);
            this.Controls.Add(this.textBoxStudentID);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManageStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageStudentForm";
            this.Load += new System.EventHandler(this.ManageStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTotalStudents;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.RadioButton RadioButtonFemale;
        private System.Windows.Forms.RadioButton RadioButtonMale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxLname;
        private System.Windows.Forms.TextBox textBoxFname;
        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxID_Class;
    }
}