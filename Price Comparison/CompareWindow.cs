using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Price_Comparison
{
    public partial class CompareWindow : Form
    {
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();

        public CompareWindow(DataTable dt1, DataTable dt2)
        {
            InitializeComponent();

            this.dt1 = dt1;
            this.dt2 = dt2;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns.Add("productName", "Номенклатура");
            dataGridView1.Columns.Add("code", "Артикул");
            dataGridView1.Columns.Add("price1C", "Цена 1C");
            dataGridView1.Columns.Add("priceOnliner", "Цена Onliner");

            Compare();
        }

        private void Compare()
        {
            foreach (DataRow rowDt1 in dt1.Rows)
            {
                var cellsDt1 = rowDt1.ItemArray;
                string product = cellsDt1[0].ToString();
                string codeDt1 = cellsDt1[1].ToString();
                string priceDt1 = cellsDt1[2].ToString();

                foreach (DataRow rowDt2 in dt2.Rows)
                {
                    var cellsDt2 = rowDt2.ItemArray;
                    string codeDt2 = cellsDt2[1].ToString();
                    string priceDt2 = cellsDt2[2].ToString();

                    if (codeDt1.Equals(codeDt2))
                    {
                        if (!priceDt1.Equals(priceDt2)) 
                        {
                            int rowNumber = dataGridView1.Rows.Add();
                            dataGridView1.Rows[rowNumber].Cells["productName"].Value = product;
                            dataGridView1.Rows[rowNumber].Cells["code"].Value = codeDt1;
                            dataGridView1.Rows[rowNumber].Cells["price1C"].Value = priceDt1;
                            dataGridView1.Rows[rowNumber].Cells["priceOnliner"].Value = priceDt2;
                        }
                    }
                }
            }
        }
    }
}
