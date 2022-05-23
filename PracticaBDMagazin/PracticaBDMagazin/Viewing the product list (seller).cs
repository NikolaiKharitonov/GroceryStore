using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaBDMagazin
{
    public partial class Viewing_the_product_list__seller_ : Form
    {
        public Viewing_the_product_list__seller_()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            menuProdavec nazad = new menuProdavec();
            nazad.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groceryStoreDataSet);

        }

        private void Viewing_the_product_list__seller__Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "groceryStoreDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.groceryStoreDataSet.Product);

        }

        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {
            
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
            if (button2.Enabled == true)
            {
                productDataGridView.Sort(productDataGridView.Columns[compare], ListSortDirection.Descending);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 nazad = new Form1();
            nazad.Show();
            this.Close();
        }
    }
}
