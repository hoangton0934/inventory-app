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
    public partial class Form3 : Form
    {
        public static string username;
        private MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        public string ItemList = "";
        public float TotalPrice = 0;
        public string UpdateQuery = "";

        public Form3()
        {
            InitializeComponent();
            con.ConnectionString = @"server=localhost;database=inventorymgcsharp;userid=root;password=;";
        }

        
        private void Form3_Load(object sender, EventArgs e)
        {
            
            fillComboBox();
            ItemList = "";
            TotalPrice = 0;
            UpdateQuery = "";

            //userdetail user = new userdetail();
            //label9.Text = user.getUname();
            label9.Text = Form1.username;
        }

        private void fillComboBox()
        {

            MySqlDataAdapter sda = new MySqlDataAdapter("select DISTINCT model from spareparts", con);
            DataSet dt = new DataSet();
            sda.Fill(dt);


            comboBox1.DataSource = dt.Tables[0];
            comboBox1.DisplayMember = "model";
            comboBox1.ValueMember  = "model";

            MySqlDataAdapter sda1 = new MySqlDataAdapter("select DISTINCT part from spareparts", con);
            DataSet dt1 = new DataSet();
            sda1.Fill(dt1);

            comboBox2.DataSource = dt1.Tables[0];
            comboBox2.DisplayMember = "part";
            comboBox2.ValueMember = "part";
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                textBox4.Text = row.Cells[3].Value.ToString();
                textBox5.Text = row.Cells[4].Value.ToString();
                textBox6.Text = row.Cells[5].Value.ToString();
            }
        }

               
        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.Show();
        }

        private void find_btn_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM spareparts WHERE model='" + comboBox1.Text + "' && part='" + comboBox2.Text + "' ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBox6.Text) >= int.Parse(textBox7.Text))
                {
                    ItemList += textBox2.Text + "" + textBox3.Text + "" + textBox4.Text + "" + textBox5.Text + "*" + textBox7.Text + Environment.NewLine;
                    TotalPrice += float.Parse(textBox5.Text) * float.Parse(textBox7.Text);
                    UpdateQuery += "UPDATE spareparts SET instock='" + (int.Parse(textBox6.Text) - int.Parse(textBox7.Text)) + "' WHERE id='" + textBox1.Text + "'; ";
                    String msg = textBox1.Text + "" + textBox2.Text + "" + textBox3.Text + "" + textBox4.Text + "*" + textBox7.Text;
                    MessageBox.Show(msg + Environment.NewLine + "Add To Cart");
                }
                else
                {
                    MessageBox.Show("Not Enough Items in Stocks");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter in Correct Format");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void continue_btn_Click(object sender, EventArgs e)
        {
            if (this.ItemList == "")
            {
                MessageBox.Show("No Items Selected");
            }
            else
            {
                var childform = new ConfirmForm();
                childform.Myparent = this;
                childform.Show();
                this.Enabled = false;
            }
        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            Form5 order = new Form5();
            this.Hide();
            order.ShowDialog();
        }
    }
}
