using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Quan_Li_Sinh_Vien.STUDENT
{
    public partial class PrintStudentForm : Form
    {
        public PrintStudentForm()
        {
            InitializeComponent();
        }
        Student student = new Student();

        private void PrintStudentForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Student");
            fillGrid(command);
            if (radiobtNo.Checked)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }
        public void fillGrid(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn piCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            //colum 7 is the image colum index
            
            dataGridView1.AllowUserToAddRows = false;
        }

        private void radiobtYes_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }

        private void radiobtNo_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void button_Check_Click(object sender, EventArgs e)
        {
            //display data on the datagridview depending on what the user have selected
            SqlCommand command;
            string query;
            //check if the radiobt yes is checked 
            //that mean the user want to use a date range
            if (radiobtYes.Checked)
            {
                //get the data values 
                string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");

                if (radiobtMale.Checked)
                {
                    query = "SELECT * FROM Student WHERE gender = '1' AND bdate BETWEEN ' " + date1 + "'AND'" + date2 + "'";
                }
                else if (radiobtFemale.Checked)
                {
                    query = "SELECT * FROM Student WHERE gender = '0' AND bdate BETWEEN ' " + date1 + "'AND'" + date2 + "'";
                }
                else
                {
                    query = "SELECT * FROM Student WHERE bdate BETWEEN ' " + date1 + "'AND'" + date2 + "'";
                }

                command = new SqlCommand(query);
                fillGrid(command);
            }
            else //display data without a birthday range
            {
                if (radiobtMale.Checked)
                {
                    query = "SELECT * FROM Student WHERE gender = '1'";
                }
                else if (radiobtFemale.Checked)
                {
                    query = "SELECT * FROM Student WHERE gender = '0'";
                }
                else
                {
                    query = "SELECT * FROM Student";
                }

                command = new SqlCommand(query);
                fillGrid(command);
            }
        }

        private void button_SaveToTextFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word Document(*.docx)|*.docx";
            sfd.FileName = "export.docx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Export_Data_To_Word(dataGridView1, sfd.FileName);
                MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_ToPrinter_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Print Document";
            printDlg.Document = printDoc;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;

            if (printDlg.ShowDialog() == DialogResult.OK) printDoc.Print();
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
                //SAVE IMAGE
                
                //save the file
                oDoc.SaveAs(filename);
            }
        }
    }
}
