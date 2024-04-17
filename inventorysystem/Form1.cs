using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventorysystem
{
    public partial class Form1 : Form
    {
        public static string username;
        public Form1()
        {
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void clear_btn_Click(object sender, EventArgs e)
        {
            
            string myconnectionString = @"server=localhost;database=inventorymgcsharp;userid=root;password=;";
            MySqlConnection con = null;
            MySqlCommand cmd;
            MySqlDataReader dr;
            if (comboBox1.Text == "Admin")
            {
                try
                {
                    con = new MySqlConnection(myconnectionString);
                    con.Open();
                    label5.Text = "con su";
                    cmd = new MySqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM login_tb WHERE Username = '" + textBox1.Text + "'  AND Password = '" + textBox2.Text + "' ";
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Sucess");
                        this.Hide();
                        username = textBox1.Text;
                        Form2 adf = new Form2();
                        adf.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("PLEASE ENTER THE CORRECT USERNAME AND PASSWORD");
                    }
                }
                finally
                {
                    if (con != null)
                    {
                        con.Close();
                    }
                }
            }
            else if (comboBox1.Text == "Member")
            {
                try
                {
                    con = new MySqlConnection(myconnectionString);
                    con.Open();
                    cmd = new MySqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM userlogin_tb WHERE Username = '" + textBox1.Text + "'  AND Password = '" + textBox2.Text + "' ";
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Sucess");
                        this.Hide();
                        username = textBox1.Text;
                        Form3 f3 = new Form3();
                        f3.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("PLEASE ENTER THE CORRECT USERNAME AND PASSWORD");
                    }
                }
                finally
                {
                    if (con != null)
                    {
                        con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("!!!PLEASE ENTER THE CORRECT USERNAME AND PASSWORD");
            }
        }
    }
}
