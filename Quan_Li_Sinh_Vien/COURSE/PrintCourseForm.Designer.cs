
namespace Quan_Li_Sinh_Vien.COURSE
{
    partial class PrintCourseForm
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
            this.bt_ToPrinter = new System.Windows.Forms.Button();
            this.bt_SaveToTextFile = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_ToPrinter
            // 
            this.bt_ToPrinter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_ToPrinter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_ToPrinter.ForeColor = System.Drawing.Color.White;
            this.bt_ToPrinter.Location = new System.Drawing.Point(255, 249);
            this.bt_ToPrinter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_ToPrinter.Name = "bt_ToPrinter";
            this.bt_ToPrinter.Size = new System.Drawing.Size(182, 32);
            this.bt_ToPrinter.TabIndex = 11;
            this.bt_ToPrinter.Text = "To Printer";
            this.bt_ToPrinter.UseVisualStyleBackColor = false;
            this.bt_ToPrinter.Click += new System.EventHandler(this.bt_ToPrinter_Click);
            // 
            // bt_SaveToTextFile
            // 
            this.bt_SaveToTextFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_SaveToTextFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bt_SaveToTextFile.ForeColor = System.Drawing.Color.White;
            this.bt_SaveToTextFile.Location = new System.Drawing.Point(9, 249);
            this.bt_SaveToTextFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_SaveToTextFile.Name = "bt_SaveToTextFile";
            this.bt_SaveToTextFile.Size = new System.Drawing.Size(182, 32);
            this.bt_SaveToTextFile.TabIndex = 10;
            this.bt_SaveToTextFile.Text = "Save To Text File";
            this.bt_SaveToTextFile.UseVisualStyleBackColor = false;
            this.bt_SaveToTextFile.Click += new System.EventHandler(this.bt_SaveToTextFile_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(428, 226);
            this.dataGridView1.TabIndex = 9;
            // 
            // PrintCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 298);
            this.Controls.Add(this.bt_ToPrinter);
            this.Controls.Add(this.bt_SaveToTextFile);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PrintCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrintCourseForm";
            this.Load += new System.EventHandler(this.PrintCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_ToPrinter;
        private System.Windows.Forms.Button bt_SaveToTextFile;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}