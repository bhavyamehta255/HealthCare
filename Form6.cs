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

namespace Final_health_care
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amit\Documents\Visual Studio 2010\Projects\healthcare\healthcare\final health care.mdf;Integrated Security=True;Connect Timeout=30");
            cn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM patient1 where p_name=@p",cn);
            cmd.Parameters.AddWithValue("@p", textBox1.Text);
            SqlDataReader rd = cmd.ExecuteReader();
            richTextBox1.Visible = true;
            while (rd.Read())
            {
                richTextBox1.Text = rd["p_name"] + "--" + rd["p_phone_no"] + "--"+rd["p_blood_group"]+"  " ;
            }
            
            rd.Close();
            cn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Form1 f1 = new Form1();
            //f1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            
            f3.Show();
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
