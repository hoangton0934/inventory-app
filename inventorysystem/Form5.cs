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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            
        }

       
        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton24_Click_1(object sender, EventArgs e)
        {
            try
            {
                String id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=inventorymgcsharp;");
                string query = "delete from orders where id='" + id + "';";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Order Deleted");

                FillMyOrdeers();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No item Selected");
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label9.Text = Form1.username;
            FillMyOrdeers();
        }

        void FillMyOrdeers()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=inventorymgcsharp;");
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT id,details,price,paid FROM `orders` where user ='" + label9.Text + "'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        
    }
}
