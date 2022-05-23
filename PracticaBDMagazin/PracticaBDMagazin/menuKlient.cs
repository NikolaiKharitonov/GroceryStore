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
    public partial class menuKlient : Form
    {
        public menuKlient()
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
            Profile__buyer_ run = new Profile__buyer_();
            run.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Viewing_the_product_list__buyer_ run = new Viewing_the_product_list__buyer_();
            run.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Purchase__buyer_ run = new Purchase__buyer_();
            run.Show();
            this.Close();
        }
    }
}
