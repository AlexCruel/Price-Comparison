using ClosedXML.Excel;
using System.Data;

namespace Price_Comparison
{
    public partial class Main : Form
    {
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();

        public Main()
        {
            InitializeComponent();

            openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm"; 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (XLWorkbook wb = new XLWorkbook(openFileDialog1.FileName))
                {
                    OpenFile(1, wb, dt1);
                    OpenFile(2, wb, dt2);
                }
            }
        }

        private void OpenFile(int number, XLWorkbook wb, DataTable dt)
        {
            bool isFirstRow = true;
            var rows = wb.Worksheet(number).RowsUsed();

            foreach (var row in rows)
            {
                if (isFirstRow)
                {
                    // adding a column
                    foreach (IXLCell cell in row.Cells())
                        dt.Columns.Add(cell.Value.ToString());
                    isFirstRow = false;
                }
                else
                {
                    // adding a row
                    dt.Rows.Add();
                    int i = 0;
                    foreach (IXLCell cell in row.Cells())
                        dt.Rows[dt.Rows.Count - 1][i++] = cell.Value.ToString();
                }
            }

            if (number == 1)
            {
                dataGridView1.DataSource = dt.DefaultView;
            }
            else 
                dataGridView2.DataSource = dt.DefaultView;
        }

        private void compareBtn_Click(object sender, EventArgs e)
        {
            CompareWindow compareWindow = new CompareWindow(dt1, dt2);
            compareWindow.ShowDialog();
        }
    }
}