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
    public partial class Purchase__buyer_ : Form
    {
        string connectionString = @"Data Source=COMPUTER;Initial Catalog=GroceryStore;Integrated Security=True";
        public Purchase__buyer_()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            menuKlient nazad = new menuKlient();
            nazad.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 nazad = new Form1();
            nazad.Show();
            this.Close();
        }

        private void purchaseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.purchaseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groceryStoreDataSet);

        }

        private void Purchase__buyer__Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "groceryStoreDataSet.Purchase". При необходимости она может быть перемещена или удалена.
            this.purchaseTableAdapter.Fill(this.groceryStoreDataSet.Purchase);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Введите дату!");
                    return;
                }
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Введите название товара!");
                    return;
                }
                if (textBox3.Text == "")
                {
                    MessageBox.Show("Введите количество!");
                    return;
                }
                if (textBox4.Text == "")
                {
                    MessageBox.Show("Введите сумму!");
                    return;
                }
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("PurchasePOKUPKA33", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@DateOfPurchase", textBox1.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Price", textBox2.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Quantity", textBox3.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Amount", textBox4.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Продукт куплен");
                Clear();
            }
        }
        void Clear()
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
        }
    }
}
