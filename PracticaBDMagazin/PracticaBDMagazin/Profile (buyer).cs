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
    public partial class Profile__buyer_ : Form
    {
        public Profile__buyer_()
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

        private void usersPracticaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersPracticaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groceryStoreDataSet);

        }

        private void usersPracticaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.usersPracticaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groceryStoreDataSet);

        }

        private void Profile__buyer__Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "groceryStoreDataSet.Buyer". При необходимости она может быть перемещена или удалена.
            this.buyerTableAdapter.Fill(this.groceryStoreDataSet.Buyer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.buyerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groceryStoreDataSet);
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Image Files(*.BMP; *.JPG;*GIF;*.PNG)| *.BMP;*.JPG;*GIF;*.PNG|All files(*, *) | *.*";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                }
                catch 
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
            }
        }

        private void imagePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
            
        }

        private void otzavTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void otzavLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
