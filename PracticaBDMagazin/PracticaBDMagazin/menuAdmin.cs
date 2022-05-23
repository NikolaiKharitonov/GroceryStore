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
    public partial class menuAdmin : Form
    {
        public menuAdmin()
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
            Product_registration__administrator_ run = new Product_registration__administrator_();
            run.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User_Management__Administrator_ run = new User_Management__Administrator_();
            run.Show();
            this.Close();
        }
    }
}
