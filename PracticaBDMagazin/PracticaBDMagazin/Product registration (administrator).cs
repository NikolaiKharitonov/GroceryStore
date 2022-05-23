using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PracticaBDMagazin
{
    public partial class Product_registration__administrator_ : Form
    {
        public Product_registration__administrator_()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            menuAdmin nazad = new menuAdmin();
            nazad.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Editing_product_data__administrator_ run = new Editing_product_data__administrator_();
            run.Show();
            this.Close();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groceryStoreDataSet);

        }

        private void Product_registration__administrator__Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "groceryStoreDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.groceryStoreDataSet.Product);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < productDataGridView.RowCount; i++)
                {
                    productDataGridView.Rows[i].Selected = false;
                    for (int j = 0; j <= 1; j++)
                    {
                        if (productDataGridView.Rows[i].Cells[j] != null)
                        {
                            if (productDataGridView.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                            {
                                productDataGridView.Rows[i].Selected = true;
                                productDataGridView.FirstDisplayedScrollingRowIndex = i;
                            }
                        }
                    }
                }
            }
            catch
            {


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var compare = listBox1.SelectedIndex;
            if (button1.Enabled == true)
            {
                productDataGridView.Sort(productDataGridView.Columns[compare], ListSortDirection.Ascending);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var compare = listBox1.SelectedIndex;
            if (button1.Enabled == true)
            {
                productDataGridView.Sort(productDataGridView.Columns[compare], ListSortDirection.Descending);
            }
        }

        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {            
                     
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groceryStoreDataSet);

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.productBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 nazad = new Form1();
            nazad.Show();
            this.Close();
        }
    }
}
