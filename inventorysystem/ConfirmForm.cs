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
    public partial class ConfirmForm : Form
    {
        private MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        public Form3 Myparent { get; set; }
        public ConfirmForm()
        {
            InitializeComponent();
            con.ConnectionString = @"server=localhost;database=inventorymgcsharp;userid=root;password=;";
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
           // this.Close();
        }

        private void ConfirmForm_Load(object sender, EventArgs e)
        {
            label9.Text = Form1.username;
            richTextBox1.Text = Myparent.ItemList;
        }

        private void ConfirmForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Myparent.Enabled = true;
        }

                
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            Myparent.ItemList = "";
            Myparent.TotalPrice = 0;
            Myparent.UpdateQuery = "";
            this.Close();
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            try
            {
                //Userdetail user = new Userdetail();
                userdetail user = new userdetail();

                string query = "INSERT INTO orders(user,details,price) VALUES('"+label9.Text+"','" + Myparent.ItemList + "'," + Myparent.TotalPrice + ");" + Myparent.UpdateQuery + "";
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully");
                clear_btn_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
