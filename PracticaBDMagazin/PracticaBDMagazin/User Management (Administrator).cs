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
    public partial class User_Management__Administrator_ : Form
    {
        public User_Management__Administrator_()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            menuAdmin nazad = new menuAdmin();
            nazad.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 nazad = new Form1();
            nazad.Show();
            this.Close();
        }

        private void usersPracticaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersPracticaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groceryStoreDataSet);

        }

        private void User_Management__Administrator__Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "groceryStoreDataSet.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter.Fill(this.groceryStoreDataSet.Table);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "groceryStoreDataSet.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter.Fill(this.groceryStoreDataSet.Table);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "groceryStoreDataSet.UsersPractica". При необходимости она может быть перемещена или удалена.
            this.usersPracticaTableAdapter.Fill(this.groceryStoreDataSet.UsersPractica);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tableBindingSource.MoveNext();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tableBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.tableBindingSource.RemoveCurrent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Validate();
            tableBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(this.groceryStoreDataSet);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            tableBindingSource.AddNew();
        }

        private void usersPracticaBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void patronymicTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void roleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
