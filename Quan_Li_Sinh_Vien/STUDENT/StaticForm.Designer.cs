
namespace Quan_Li_Sinh_Vien.STUDENT
{
    partial class StaticForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelMale = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelFemale = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.labelTotal);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 108);
            this.panel1.TabIndex = 0;
            // 
            // labelTotal
            // 
            this.labelTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTotal.Location = new System.Drawing.Point(0, 0);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(310, 108);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "Total Students: 100";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTotal.Click += new System.EventHandler(this.labelTotal_Click);
            this.labelTotal.MouseEnter += new System.EventHandler(this.labelTotal_MouseEnter);
            this.labelTotal.MouseLeave += new System.EventHandler(this.labelTotal_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.labelMale);
            this.panel2.Location = new System.Drawing.Point(-2, 106);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 124);
            this.panel2.TabIndex = 1;
            // 
            // labelMale
            // 
            this.labelMale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMale.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelMale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMale.Location = new System.Drawing.Point(0, 0);
            this.labelMale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMale.Name = "labelMale";
            this.labelMale.Size = new System.Drawing.Size(153, 124);
            this.labelMale.TabIndex = 1;
            this.labelMale.Text = "Male: 50%";
            this.labelMale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMale.MouseEnter += new System.EventHandler(this.labelMale_MouseEnter);
            this.labelMale.MouseLeave += new System.EventHandler(this.labelMale_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.labelFemale);
            this.panel3.Location = new System.Drawing.Point(151, 106);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 124);
            this.panel3.TabIndex = 2;
            // 
            // labelFemale
            // 
            this.labelFemale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFemale.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelFemale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFemale.Location = new System.Drawing.Point(0, 0);
            this.labelFemale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFemale.Name = "labelFemale";
            this.labelFemale.Size = new System.Drawing.Size(158, 124);
            this.labelFemale.TabIndex = 1;
            this.labelFemale.Text = "Female: 50%";
            this.labelFemale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFemale.MouseEnter += new System.EventHandler(this.labelFamale_MouseEnter);
            this.labelFemale.MouseLeave += new System.EventHandler(this.labelFamale_MouseLeave);
            // 
            // StaticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 232);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StaticForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaticForm";
            this.Load += new System.EventHandler(this.StaticForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelMale;
        private System.Windows.Forms.Label labelFemale;
    }
}