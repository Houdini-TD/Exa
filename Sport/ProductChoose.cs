using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sport
{
    public partial class ProductChoose : Form
    {
        public ProductChoose()
        {
            InitializeComponent();
            loadData();

        }

        private void loadData()
        {
            dataGridView1.DataSource = SQL.ExecuteQuery("select * from Product").DataTable;
            SQL.LoadDataToComboBox("select ProductManufacturer from Product", "ProductManufacturer", "ProductQuantityInStock", comboBox1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SQL.ExecuteQuery($"select * from Product where ProductManufacturer = {comboBox1.Text}").DataTable;
        }
    }
}
