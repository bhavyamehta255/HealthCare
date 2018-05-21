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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amit\Documents\Visual Studio 2010\Projects\healthcare\healthcare\final health care.mdf;Integrated Security=True;Connect Timeout=30");
            cn.Open();
           
          
                    SqlCommand cmd = new SqlCommand("DELETE FROM patient1 WHERE p_name=@cn", cn);
                    cmd.Parameters.AddWithValue("@cn", textBox3.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfully");
                    
               
            
            cn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amit\Documents\Visual Studio 2010\Projects\healthcare\healthcare\final health care.mdf;Integrated Security=True;Connect Timeout=30");
            cn.Open();
            SqlCommand cmd = new SqlCommand("update patient1 SET p_phone_no=@pphone WHERE p_name=@pname",cn);

            cmd.Parameters.AddWithValue("@pname",textBox1.Text );
            cmd.Parameters.AddWithValue("@pphone", textBox2.Text);
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Updated Successfully");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
