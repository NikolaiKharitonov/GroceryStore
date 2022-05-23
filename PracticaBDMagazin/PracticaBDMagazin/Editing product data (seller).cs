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
    enum rowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class Editing_product_data__seller_ : Form
    {
        DataBase dataBase = new DataBase();

        int selectedRow;
        public Editing_product_data__seller_()
        {
            InitializeComponent();
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Name", "Наименование");
            dataGridView1.Columns.Add("Price", "Цена");
            dataGridView1.Columns.Add("Category", "Категория");
            dataGridView1.Columns.Add("ExpirationDate", "Срок годности");
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

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            menuProdavec nazad = new menuProdavec();
            nazad.Show();
            this.Close();
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
                RefresDataGrid(dataGridView1);
            }
            else
            {
                MessageBox.Show("Цена должна иметь числовой формат!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dataBase.closeConnection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Editing_product_data__seller__Load(object sender, EventArgs e)
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
