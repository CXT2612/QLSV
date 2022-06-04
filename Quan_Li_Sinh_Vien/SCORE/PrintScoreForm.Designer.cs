
namespace Quan_Li_Sinh_Vien.SCORE
{
    partial class PrintScoreForm
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
            this.listBoxCourse = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewScore = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_SaveToTextFile = new System.Windows.Forms.Button();
            this.labelreset = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxCourse
            // 
            this.listBoxCourse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listBoxCourse.FormattingEnabled = true;
            this.listBoxCourse.ItemHeight = 19;
            this.listBoxCourse.Location = new System.Drawing.Point(9, 93);
            this.listBoxCourse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxCourse.Name = "listBoxCourse";
            this.listBoxCourse.Size = new System.Drawing.Size(187, 213);
            this.listBoxCourse.TabIndex = 48;
            this.listBoxCourse.Click += new System.EventHandler(this.listBoxCourse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(9, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 49;
            this.label1.Text = "Course List:";
            // 
            // dataGridViewScore
            // 
            this.dataGridViewScore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScore.Location = new System.Drawing.Point(200, 58);
            this.dataGridViewScore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewScore.Name = "dataGridViewScore";
            this.dataGridViewScore.RowHeadersWidth = 51;
            this.dataGridViewScore.RowTemplate.Height = 24;
            this.dataGridViewScore.Size = new System.Drawing.Size(538, 252);
            this.dataGridViewScore.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(196, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 51;
            this.label2.Text = "Score List:";
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Location = new System.Drawing.Point(742, 91);
            this.dataGridViewStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.RowHeadersWidth = 51;
            this.dataGridViewStudent.RowTemplate.Height = 24;
            this.dataGridViewStudent.Size = new System.Drawing.Size(267, 219);
            this.dataGridViewStudent.TabIndex = 52;
            this.dataGridViewStudent.Click += new System.EventHandler(this.dataGridViewStudent_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(742, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 53;
            this.label3.Text = "Student List:";
            // 
            // bt_SaveToTextFile
            // 
            this.bt_SaveToTextFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_SaveToTextFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_SaveToTextFile.ForeColor = System.Drawing.Color.White;
            this.bt_SaveToTextFile.Location = new System.Drawing.Point(200, 315);
            this.bt_SaveToTextFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_SaveToTextFile.Name = "bt_SaveToTextFile";
            this.bt_SaveToTextFile.Size = new System.Drawing.Size(538, 41);
            this.bt_SaveToTextFile.TabIndex = 54;
            this.bt_SaveToTextFile.Text = "Save To Text File";
            this.bt_SaveToTextFile.UseVisualStyleBackColor = false;
            this.bt_SaveToTextFile.Click += new System.EventHandler(this.bt_SaveToTextFile_Click);
            // 
            // labelreset
            // 
            this.labelreset.AutoSize = true;
            this.labelreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelreset.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelreset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelreset.Location = new System.Drawing.Point(296, 20);
            this.labelreset.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelreset.Name = "labelreset";
            this.labelreset.Size = new System.Drawing.Size(52, 21);
            this.labelreset.TabIndex = 55;
            this.labelreset.Text = "Reset";
            this.labelreset.Click += new System.EventHandler(this.labelreset_Click);
            // 
            // PrintScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 366);
            this.Controls.Add(this.labelreset);
            this.Controls.Add(this.bt_SaveToTextFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewStudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxCourse);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PrintScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintScoreForm";
            this.Load += new System.EventHandler(this.PrintScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_SaveToTextFile;
        private System.Windows.Forms.Label labelreset;
    }
}