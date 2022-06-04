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
using Quan_Li_Sinh_Vien.COURSE;
using Quan_Li_Sinh_Vien.STUDENT;
using Word = Microsoft.Office.Interop.Word;

namespace Quan_Li_Sinh_Vien.SCORE
{
    public partial class PrintScoreForm : Form
    {
        public PrintScoreForm()
        {
            InitializeComponent();
        }
        Score score = new Score();
        Student student = new Student();
        Course course = new Course();
        private void PrintScoreForm_Load(object sender, EventArgs e)
        {
            dataGridViewStudent.DataSource = student.getStudents(new SqlCommand ("SELECT id, fname,lname FROM Student"));
            dataGridViewScore.DataSource = score.getStudentsScore();
            listBoxCourse.DataSource = course.getAllCourse();
            listBoxCourse.DisplayMember = "label";
            listBoxCourse.ValueMember = "id";
            dataGridViewScore.ReadOnly = true;
            dataGridViewScore.AllowUserToAddRows = false;
            dataGridViewStudent.ReadOnly = true;
            dataGridViewStudent.AllowUserToAddRows = false;
        }

        private void listBoxCourse_Click(object sender, EventArgs e)
        {
            dataGridViewScore.DataSource = score.getCourseScore(int.Parse(listBoxCourse.SelectedValue.ToString()));
        }

        private void dataGridViewStudent_Click(object sender, EventArgs e)
        {
            dataGridViewScore.DataSource = score.getStudentScores(int.Parse(dataGridViewStudent.CurrentRow.Cells[0].Value.ToString()));
        }

        private void labelreset_Click(object sender, EventArgs e)    
        {
            dataGridViewScore.DataSource = score.getStudentsScore();
        }

        private void bt_SaveToTextFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word Document(*.docx)|*.docx";
            sfd.FileName = "export.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Export_Data_To_Word(dataGridViewScore, sfd.FileName);
                MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            if (DGV.Rows.Count != 0)
            {
                int RowCount = DGV.Rows.Count;
                int ColumnCount = DGV.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //add rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
                    }//end row loop
                }//end colum loop

                Word.Document oDoc = new Word.Document();
                oDoc.Application.Visible = true;
                //page orintation
                oDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;
                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";
                    }
                }
                //table fomart
                oRange.Text = oTemp;

                object Separator = Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                        Type.Missing, Type.Missing, ref ApplyBorders,
                                        Type.Missing, Type.Missing, Type.Missing,
                                        Type.Missing, Type.Missing, Type.Missing,
                                        Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);
                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //hearder row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                //add header row manually
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
                }
                //table style   
                oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                //hearder text
                foreach (Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Word.Range hearderRange = section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    hearderRange.Fields.Add(hearderRange, Word.WdFieldType.wdFieldPage);
                    hearderRange.Text = "your hearder text";
                    hearderRange.Font.Size = 16;
                    hearderRange.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }
                //save the file
                oDoc.SaveAs(filename);
            }
        }

        
    }
}   
