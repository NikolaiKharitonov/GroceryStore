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
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class Editing_product_data__administrator_ : Form
    {
        DataBase dataBase = new DataBase();

        int selectedRow;
        public Editing_product_data__administrator_()
        {
            InitializeComponent();
        }

        private  void CreateColumns()
        {
            dataGridView2.Columns.Add("Name","Наименование");
            dataGridView2.Columns.Add("Price", "Цена");
            dataGridView2.Columns.Add("Category", "Категория");
            dataGridView2.Columns.Add("ExpirationDate", "Срок годности");
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), record.GetInt32(1), record.GetString(2), record.GetString(3));
        }

        private void RefresDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from ProductBAZA";

            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }




        private void button4_Click(object sender, EventArgs e)
        {
            Product_registration__administrator_ nazad = new Product_registration__administrator_();
            nazad.Show();
            this.Close();
        }

       

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groceryStoreDataSet);

        }

        private void Editing_product_data__administrator__Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "groceryStoreDataSet.ProductRegistration". При необходимости она может быть перемещена или удалена.
            this.productRegistrationTableAdapter.Fill(this.groceryStoreDataSet.ProductRegistration);
            CreateColumns();
            RefresDataGrid(dataGridView2);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var Name = textBox1.Text;
            int Price;
            var Category = textBox3.Text;
            var ExpirationDate = textBox4.Text;

            if (int.TryParse(textBox2.Text, out Price))
            {
                var addQuery = $"insert into ProductBAZA (Name, Price, Category, ExpirationDate) values ('{Name}','{Price}','{Category}','{ExpirationDate}')";

                var command = new SqlCommand(addQuery, dataBase.GetConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись успешно создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefresDataGrid(dataGridView2);
            }
            else
            {
                MessageBox.Show("Цена должна иметь числовой формат!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataBase.closeConnection();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 nazad = new Form1();
            nazad.Show();
            this.Close();
        }
    }
}
