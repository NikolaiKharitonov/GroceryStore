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
    public partial class authorization : Form
    {
        public authorization()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
        }

        private void authorization_Load(object sender, EventArgs e)
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
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=COMPUTER;Initial Catalog=GroceryStore;Integrated Security=True"))
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandText = "select Password from [UsersPractica] where Email = '" + textBox1.Text + "'";
                        string Password = Convert.ToString(cmd.ExecuteScalar());
                        if (Password != "")
                        {
                            if (textBox2.Text == Password)
                            {
                                cmd.CommandText = "select Role from [UsersPractica] where Email = '" + textBox1.Text + "'";
                                string Role = Convert.ToString(cmd.ExecuteScalar());
                                switch (Role)
                                {
                                    case "admin":
                                        {
                                            menuAdmin menuadm = new menuAdmin();
                                            menuadm.Show();
                                            this.Hide();
                                        }
                                        break;
                                    case "seller":
                                        {
                                            menuProdavec user = new menuProdavec();
                                            user.Show();
                                            this.Hide();
                                        }
                                        break;
                                    case "Klient":
                                        {
                                            menuKlient user = new menuKlient();
                                            user.Show();
                                            this.Hide();
                                        }
                                        break;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Вы ввели неверный Email или пароль!");
                            }
                        }


                        else { MessageBox.Show("Вы ввели неверный Email или пароль!"); }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        con.Close();
                    }


                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
    }
}
