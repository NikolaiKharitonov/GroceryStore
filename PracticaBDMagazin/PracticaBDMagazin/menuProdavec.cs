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
    public partial class menuProdavec : Form
    {
        public menuProdavec()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 nazad = new Form1();
            nazad.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Viewing_the_product_list__seller_ run = new Viewing_the_product_list__seller_();
            run.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Work_schedule__seller_ run = new Work_schedule__seller_();
            run.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Editing_product_data__administrator_ run = new Editing_product_data__administrator_();
            run.Show();
            this.Close();
        }
    }
}
