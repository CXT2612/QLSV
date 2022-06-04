
namespace Quan_Li_Sinh_Vien.STUDENT
{
    partial class PrintStudentForm
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
            this.components = new System.ComponentModel.Container();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button_ToPrinter = new System.Windows.Forms.Button();
            this.button_SaveToTextFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radiobtNo = new System.Windows.Forms.RadioButton();
            this.radiobtYes = new System.Windows.Forms.RadioButton();
            this.radiobtFemale = new System.Windows.Forms.RadioButton();
            this.radiobtMale = new System.Windows.Forms.RadioButton();
            this.radiobtAll = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Check = new System.Windows.Forms.Button();
            this.addstudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addstudentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 95);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(735, 214);
            this.dataGridView1.TabIndex = 9;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(279, 26);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(97, 26);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "AND";
            // 
            // button_ToPrinter
            // 
            this.button_ToPrinter.BackColor = System.Drawing.Color.Blue;
            this.button_ToPrinter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_ToPrinter.ForeColor = System.Drawing.Color.White;
            this.button_ToPrinter.Location = new System.Drawing.Point(432, 324);
            this.button_ToPrinter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_ToPrinter.Name = "button_ToPrinter";
            this.button_ToPrinter.Size = new System.Drawing.Size(148, 32);
            this.button_ToPrinter.TabIndex = 7;
            this.button_ToPrinter.Text = "To Printer";
            this.button_ToPrinter.UseVisualStyleBackColor = false;
            this.button_ToPrinter.Click += new System.EventHandler(this.button_ToPrinter_Click);
            // 
            // button_SaveToTextFile
            // 
            this.button_SaveToTextFile.BackColor = System.Drawing.Color.Blue;
            this.button_SaveToTextFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_SaveToTextFile.ForeColor = System.Drawing.Color.White;
            this.button_SaveToTextFile.Location = new System.Drawing.Point(160, 324);
            this.button_SaveToTextFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_SaveToTextFile.Name = "button_SaveToTextFile";
            this.button_SaveToTextFile.Size = new System.Drawing.Size(148, 32);
            this.button_SaveToTextFile.TabIndex = 6;
            this.button_SaveToTextFile.Text = "Save To Doc File";
            this.button_SaveToTextFile.UseVisualStyleBackColor = false;
            this.button_SaveToTextFile.Click += new System.EventHandler(this.button_SaveToTextFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Birthday Between";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(131, 26);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(101, 26);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // radiobtNo
            // 
            this.radiobtNo.AutoSize = true;
            this.radiobtNo.Checked = true;
            this.radiobtNo.Location = new System.Drawing.Point(180, 0);
            this.radiobtNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radiobtNo.Name = "radiobtNo";
            this.radiobtNo.Size = new System.Drawing.Size(51, 23);
            this.radiobtNo.TabIndex = 1;
            this.radiobtNo.TabStop = true;
            this.radiobtNo.Text = "NO";
            this.radiobtNo.UseVisualStyleBackColor = true;
            this.radiobtNo.CheckedChanged += new System.EventHandler(this.radiobtNo_CheckedChanged);
            // 
            // radiobtYes
            // 
            this.radiobtYes.AutoSize = true;
            this.radiobtYes.Location = new System.Drawing.Point(124, 0);
            this.radiobtYes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radiobtYes.Name = "radiobtYes";
            this.radiobtYes.Size = new System.Drawing.Size(56, 23);
            this.radiobtYes.TabIndex = 0;
            this.radiobtYes.Text = "YES";
            this.radiobtYes.UseVisualStyleBackColor = true;
            this.radiobtYes.CheckedChanged += new System.EventHandler(this.radiobtYes_CheckedChanged);
            // 
            // radiobtFemale
            // 
            this.radiobtFemale.AutoSize = true;
            this.radiobtFemale.Location = new System.Drawing.Point(96, 29);
            this.radiobtFemale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radiobtFemale.Name = "radiobtFemale";
            this.radiobtFemale.Size = new System.Drawing.Size(71, 23);
            this.radiobtFemale.TabIndex = 3;
            this.radiobtFemale.Text = "Female";
            this.radiobtFemale.UseVisualStyleBackColor = true;
            // 
            // radiobtMale
            // 
            this.radiobtMale.AutoSize = true;
            this.radiobtMale.Location = new System.Drawing.Point(42, 29);
            this.radiobtMale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radiobtMale.Name = "radiobtMale";
            this.radiobtMale.Size = new System.Drawing.Size(58, 23);
            this.radiobtMale.TabIndex = 2;
            this.radiobtMale.Text = "Male";
            this.radiobtMale.UseVisualStyleBackColor = true;
            // 
            // radiobtAll
            // 
            this.radiobtAll.AutoSize = true;
            this.radiobtAll.Checked = true;
            this.radiobtAll.Location = new System.Drawing.Point(4, 29);
            this.radiobtAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radiobtAll.Name = "radiobtAll";
            this.radiobtAll.Size = new System.Drawing.Size(44, 23);
            this.radiobtAll.TabIndex = 1;
            this.radiobtAll.TabStop = true;
            this.radiobtAll.Text = "All";
            this.radiobtAll.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.radiobtNo);
            this.groupBox2.Controls.Add(this.radiobtYes);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(167, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(380, 54);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Use Date Range: ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.button_Check);
            this.groupBox1.Controls.Add(this.radiobtFemale);
            this.groupBox1.Controls.Add(this.radiobtMale);
            this.groupBox1.Controls.Add(this.radiobtAll);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(639, 72);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // button_Check
            // 
            this.button_Check.BackColor = System.Drawing.Color.Blue;
            this.button_Check.ForeColor = System.Drawing.Color.White;
            this.button_Check.Location = new System.Drawing.Point(551, 24);
            this.button_Check.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Check.Name = "button_Check";
            this.button_Check.Size = new System.Drawing.Size(83, 32);
            this.button_Check.TabIndex = 4;
            this.button_Check.Text = "CHECK";
            this.button_Check.UseVisualStyleBackColor = false;
            this.button_Check.Click += new System.EventHandler(this.button_Check_Click);
            // 
            // addstudentBindingSource
            // 
            this.addstudentBindingSource.DataMember = "Addstudent";
            // 
            // PrintStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 370);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_ToPrinter);
            this.Controls.Add(this.button_SaveToTextFile);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PrintStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintStudentForm";
            this.Load += new System.EventHandler(this.PrintStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addstudentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource addstudentBindingSource;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_ToPrinter;
        private System.Windows.Forms.Button button_SaveToTextFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radiobtNo;
        private System.Windows.Forms.RadioButton radiobtYes;
        private System.Windows.Forms.RadioButton radiobtFemale;
        private System.Windows.Forms.RadioButton radiobtMale;
        private System.Windows.Forms.RadioButton radiobtAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Check;
    }
}