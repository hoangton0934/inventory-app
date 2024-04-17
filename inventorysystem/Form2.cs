

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
    public partial class Form2 : Form
    {
        public static string username;
        private MySqlConnection con = new MySqlConnection();
        
        public Form2()
        {
            con.ConnectionString = @"server=localhost;database=inventorymgcsharp;userid=root;password=;";
            InitializeComponent();
            slide_panel.Height = button1.Height;
            dashboard_panel.BringToFront();
        }

        //The method executes when the user home button clicks
        private void user_home_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            username = label1.Text;
            Form3 user_home = new Form3();
            user_home.ShowDialog();
            user_home = null;
            this.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            slide_panel.Height = button1.Height;
            slide_panel.Top = button1.Top;
            dashboard_panel.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            slide_panel.Height = button2.Height;
            slide_panel.Top = button2.Top;
            add_manager_panel.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            slide_panel.Height = button3.Height;
            slide_panel.Top = button3.Top;
            this.Hide();
            Form6 f6 = new Form6();
            f6.ShowDialog();
            f6 = null;
            this.Show();
        }

        

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = Form1.username;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void item_check_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
            f4 = null;
            this.Show();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void find_btn_Click(object sender, EventArgs e)
        {
            try
            {


                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO userlogin_tb(FirstN,LastN,Username,PhoneNumber,Password,Usertype) Values ('" + MfnameTxt.Text + "','" + MlnameTxt.Text + "','" + MusernameTxt.Text + "','" + MphonenumTxt.Text + "','" + MpassTxt.Text + "','" + typecomboTxt.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Save Data");
                MfnameTxt.Text = "";
                MlnameTxt.Text = "";
                MusernameTxt.Text = "";
                MphonenumTxt.Text = "";
                MpassTxt.Text = "";
                typecomboTxt.Text = "";
                MrepassTxt.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void MrepassTxt_OnValueChanged(object sender, EventArgs e)
        {
            if (MrepassTxt.Text == MpassTxt.Text)
            {
                lab_math.ForeColor = System.Drawing.Color.Green;
                lab_math.Text = "Matched";
            }
            else
            {
                lab_math.ForeColor = System.Drawing.Color.Red;
                lab_math.Text = "Not matched";
            }
        }

        private void check_orders_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
            f4 = null;
            this.Show();
        }
    }
}
