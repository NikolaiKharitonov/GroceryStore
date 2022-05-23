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
    public partial class Work_schedule__seller_ : Form
    {
        public Work_schedule__seller_()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            menuProdavec nazad = new menuProdavec();
            nazad.Show();
            this.Close();
        }

        private void workScheduleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.workScheduleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groceryStoreDataSet);

        }

        private void Work_schedule__seller__Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "groceryStoreDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.groceryStoreDataSet.Product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "groceryStoreDataSet.WorkSchedule". При необходимости она может быть перемещена или удалена.
            this.workScheduleTableAdapter.Fill(this.groceryStoreDataSet.WorkSchedule);

        }

        private void workScheduleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
