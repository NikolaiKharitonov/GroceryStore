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
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=COMPUTER;Initial Catalog=GroceryStore;Integrated Security=True"))
            {
                if(textBox1.Text == "")
                {
                    MessageBox.Show("Введите E-mail!");
                    return;
                }
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Введите Пароль!");
                    return;
                }
                if (textBox3.Text == "")
                {
                    MessageBox.Show("Повторите пароль!");
                    return;
                }
                if (textBox4.Text == "")
                {
                    MessageBox.Show("Введите Фамилию!");
                    return;
                }
                if (textBox5.Text == "")
                {
                    MessageBox.Show("Введите Имя!");
                    return;
                }
                if (textBox6.Text == "")
                {
                    MessageBox.Show("Введите Отчество!");
                    return;
                }

                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "insert into [UsersPractica] values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','Klient')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Аккаунт был создан");
                    Form1 menu = new Form1();
                    menu.Show();
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                    
                }
                finally
                { 
                    con.Close();
                }         
            }
        }
        
        
        private void registration_Load(object sender, EventArgs e)
        {

        }
    }
}
