using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImportTool.ViewModels;
using Microsoft.Office.Interop.Excel;

namespace ImportTool
{
    public partial class ImportTool : Form
    {
        public List<CLIENT> ClientList { get; set; }
        public ImportTool()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel Office |*.xls; *.xlsx";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.tetBx.Text = ofd.FileName;
            } 
        }

        private void butOK_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            Microsoft.Office.Interop.Excel.Range xlRange;

            int iRow, iCol;
            string strFileName; 

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            strFileName = this.tetBx.Text;
            xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlWorkBook = xlApp.Workbooks.Open(strFileName);
            xlWorkSheet = xlWorkBook.Worksheets["Sheet1"];
            xlRange = xlWorkSheet.UsedRange;

            for (iCol = 1; iCol <= xlWorkSheet.Columns.Count; iCol++)
            {
                if (xlWorkSheet.Cells[1, iCol].value == null)
                {
                    break;    
                }
                else
                {
                    DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                    col.HeaderText = xlWorkSheet.Cells[1, iCol].value;
                    int colIndex = dataGridView1.Columns.Add(col);    
                }
            } 

            for (iRow = 2; iCol <= xlWorkSheet.Rows.Count; iRow++)
            {
                if (xlWorkSheet.Cells[iRow, 1].value == null)
                {
                    break;
                }
                else
                {

                    List<string> data = new List<string>();
                    CLIENT client = new CLIENT();
                    List<string> emptyRowValues = new List<string>();
                    for (int i = 1 ;i <= xlWorkSheet.UsedRange.Columns.Count; i++) 
                    {
                        if(xlWorkSheet.Cells[iRow, i].value!=null)
                        {
                            data.Add(xlWorkSheet.Cells[iRow, i].value.ToString());

                        }
                        else
                        {
                            data.Add(" ");
                        }
                        

                    }
                    /*ClientList.Add(client); */
                    dataGridView1.Rows.Add(data.ToArray());
                }
                
            }

            xlWorkBook.Close();
            xlApp.Quit(); 

        }

        private void ImportTool_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void tetBx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}






