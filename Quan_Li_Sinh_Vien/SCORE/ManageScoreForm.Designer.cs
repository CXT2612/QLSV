
namespace Quan_Li_Sinh_Vien.SCORE
{
    partial class ManageScoreForm
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
            this.buttonAddScore = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxGhiChu = new System.Windows.Forms.TextBox();
            this.textBoxScoreGK = new System.Windows.Forms.TextBox();
            this.textBoxSelectCourse = new System.Windows.Forms.ComboBox();
            this.textBoxStudentID = new System.Windows.Forms.TextBox();
            this.button_Remove = new System.Windows.Forms.Button();
            this.button_AvgScoreByCourse = new System.Windows.Forms.Button();
            this.button_ShowStudent = new System.Windows.Forms.Button();
            this.button_ShowScore = new System.Windows.Forms.Button();
            this.textBoxScoreCK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddScore
            // 
            this.buttonAddScore.BackColor = System.Drawing.Color.Lime;
            this.buttonAddScore.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonAddScore.ForeColor = System.Drawing.Color.White;
            this.buttonAddScore.Location = new System.Drawing.Point(42, 314);
            this.buttonAddScore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddScore.Name = "buttonAddScore";
            this.buttonAddScore.Size = new System.Drawing.Size(124, 34);
            this.buttonAddScore.TabIndex = 62;
            this.buttonAddScore.Text = "Add";
            this.buttonAddScore.UseVisualStyleBackColor = false;
            this.buttonAddScore.Click += new System.EventHandler(this.buttonAddScore_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(371, 57);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(535, 331);
            this.dataGridView1.TabIndex = 61;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // textBoxGhiChu
            // 
            this.textBoxGhiChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxGhiChu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxGhiChu.Location = new System.Drawing.Point(156, 219);
            this.textBoxGhiChu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxGhiChu.Multiline = true;
            this.textBoxGhiChu.Name = "textBoxGhiChu";
            this.textBoxGhiChu.Size = new System.Drawing.Size(196, 84);
            this.textBoxGhiChu.TabIndex = 58;
            // 
            // textBoxScoreGK
            // 
            this.textBoxScoreGK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxScoreGK.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxScoreGK.Location = new System.Drawing.Point(156, 138);
            this.textBoxScoreGK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxScoreGK.Name = "textBoxScoreGK";
            this.textBoxScoreGK.Size = new System.Drawing.Size(196, 23);
            this.textBoxScoreGK.TabIndex = 57;
            // 
            // textBoxSelectCourse
            // 
            this.textBoxSelectCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxSelectCourse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxSelectCourse.FormattingEnabled = true;
            this.textBoxSelectCourse.Location = new System.Drawing.Point(156, 93);
            this.textBoxSelectCourse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSelectCourse.Name = "textBoxSelectCourse";
            this.textBoxSelectCourse.Size = new System.Drawing.Size(196, 27);
            this.textBoxSelectCourse.TabIndex = 55;
            // 
            // textBoxStudentID
            // 
            this.textBoxStudentID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxStudentID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxStudentID.Location = new System.Drawing.Point(156, 53);
            this.textBoxStudentID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxStudentID.Name = "textBoxStudentID";
            this.textBoxStudentID.Size = new System.Drawing.Size(102, 23);
            this.textBoxStudentID.TabIndex = 54;
            // 
            // button_Remove
            // 
            this.button_Remove.BackColor = System.Drawing.Color.Lime;
            this.button_Remove.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_Remove.ForeColor = System.Drawing.Color.White;
            this.button_Remove.Location = new System.Drawing.Point(207, 314);
            this.button_Remove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(124, 34);
            this.button_Remove.TabIndex = 63;
            this.button_Remove.Text = "Remove";
            this.button_Remove.UseVisualStyleBackColor = false;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // button_AvgScoreByCourse
            // 
            this.button_AvgScoreByCourse.BackColor = System.Drawing.Color.Lime;
            this.button_AvgScoreByCourse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_AvgScoreByCourse.ForeColor = System.Drawing.Color.White;
            this.button_AvgScoreByCourse.Location = new System.Drawing.Point(42, 353);
            this.button_AvgScoreByCourse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_AvgScoreByCourse.Name = "button_AvgScoreByCourse";
            this.button_AvgScoreByCourse.Size = new System.Drawing.Size(290, 34);
            this.button_AvgScoreByCourse.TabIndex = 64;
            this.button_AvgScoreByCourse.Text = "Avg Score By Course";
            this.button_AvgScoreByCourse.UseVisualStyleBackColor = false;
            this.button_AvgScoreByCourse.Click += new System.EventHandler(this.button_AvgScoreByCourse_Click);
            // 
            // button_ShowStudent
            // 
            this.button_ShowStudent.BackColor = System.Drawing.Color.Lime;
            this.button_ShowStudent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_ShowStudent.ForeColor = System.Drawing.Color.White;
            this.button_ShowStudent.Location = new System.Drawing.Point(371, 26);
            this.button_ShowStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_ShowStudent.Name = "button_ShowStudent";
            this.button_ShowStudent.Size = new System.Drawing.Size(268, 25);
            this.button_ShowStudent.TabIndex = 65;
            this.button_ShowStudent.Text = "Show Student";
            this.button_ShowStudent.UseVisualStyleBackColor = false;
            this.button_ShowStudent.Click += new System.EventHandler(this.button_ShowStudent_Click);
            // 
            // button_ShowScore
            // 
            this.button_ShowScore.BackColor = System.Drawing.Color.Lime;
            this.button_ShowScore.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_ShowScore.ForeColor = System.Drawing.Color.White;
            this.button_ShowScore.Location = new System.Drawing.Point(638, 26);
            this.button_ShowScore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_ShowScore.Name = "button_ShowScore";
            this.button_ShowScore.Size = new System.Drawing.Size(268, 25);
            this.button_ShowScore.TabIndex = 66;
            this.button_ShowScore.Text = "Show Score";
            this.button_ShowScore.UseVisualStyleBackColor = false;
            this.button_ShowScore.Click += new System.EventHandler(this.button_ShowScore_Click);
            // 
            // textBoxScoreCK
            // 
            this.textBoxScoreCK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxScoreCK.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxScoreCK.Location = new System.Drawing.Point(156, 178);
            this.textBoxScoreCK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxScoreCK.Name = "textBoxScoreCK";
            this.textBoxScoreCK.Size = new System.Drawing.Size(196, 23);
            this.textBoxScoreCK.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(58, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 72;
            this.label5.Text = "Ghi Chú:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(27, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 71;
            this.label4.Text = "Điểm Cuối Kì:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(27, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 70;
            this.label3.Text = "Điểm Giữa Kì:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 69;
            this.label2.Text = "Chọn Môn Học:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(74, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "SV ID:";
            // 
            // ManageScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 414);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxScoreCK);
            this.Controls.Add(this.button_ShowScore);
            this.Controls.Add(this.button_ShowStudent);
            this.Controls.Add(this.button_AvgScoreByCourse);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.buttonAddScore);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxGhiChu);
            this.Controls.Add(this.textBoxScoreGK);
            this.Controls.Add(this.textBoxSelectCourse);
            this.Controls.Add(this.textBoxStudentID);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ManageScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageScoreForm";
            this.Load += new System.EventHandler(this.ManageScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddScore;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxGhiChu;
        private System.Windows.Forms.TextBox textBoxScoreGK;
        private System.Windows.Forms.ComboBox textBoxSelectCourse;
        private System.Windows.Forms.TextBox textBoxStudentID;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.Button button_AvgScoreByCourse;
        private System.Windows.Forms.Button button_ShowStudent;
        private System.Windows.Forms.Button button_ShowScore;
        private System.Windows.Forms.TextBox textBoxScoreCK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}