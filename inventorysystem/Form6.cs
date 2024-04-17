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
    
    public partial class Form6 : Form
    {
        private MySqlConnection con = new MySqlConnection();
        public Form6()
        {
            InitializeComponent();
            con.ConnectionString = @"server=localhost;database=inventorymgcsharp;userid=root;password=;";
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand coman = new MySqlCommand();
                coman.Connection = con;
                string query = "select * from userlogin_tb ";
                coman.CommandText = query;
                MySqlDataAdapter da = new MySqlDataAdapter(coman);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
