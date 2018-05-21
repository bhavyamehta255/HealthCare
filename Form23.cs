using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;


namespace Final_health_care
{
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void d_name_TextChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click_2(object sender, EventArgs e)
        {
            bool flag = true;
            if (d_name.Text.Length == 0)
            {
                flag = false;
                ErrorProvider ep = new ErrorProvider();
                ep.SetError(d_name, "Required");
            }
            if (d_email.Text.Length == 0)
            {
                flag = false;
                ErrorProvider ep = new ErrorProvider();
                ep.SetError(d_email, "Required");
            }
            if (d_address.Text.Length == 0)
            {
                flag = false;
                ErrorProvider ep = new ErrorProvider();
                ep.SetError(d_address, "Required");
            }
            if (qualification.Text.Length == 0)
            {
                flag = false;
                ErrorProvider ep = new ErrorProvider();
                ep.SetError(qualification, "Required");
            }
            if (experience.Text.Length == 0)
            {
                flag = false;
                ErrorProvider ep = new ErrorProvider();
                ep.SetError(experience, "Required");
            }
            if (d_contact_no.Text.Length == 0)
            {
                flag = false;
                ErrorProvider ep = new ErrorProvider();
                ep.SetError(d_contact_no, "Required");
            }


            if (specialization.Text.Length == 0)
            {
                flag = false;
                ErrorProvider ep = new ErrorProvider();
                ep.SetError(specialization, "Required");
            }
            if (flag == true)
            {
                SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amit\Documents\Visual Studio 2010\Projects\healthcare\healthcare\final health care.mdf;Integrated Security=True;Connect Timeout=30");
                cn.Open();
                SqlCommand cmd = new SqlCommand("insert into doctor1 values(@da,@db,@dc,@dd,@de,@df,@dg,@dh)", cn);
                cmd.Parameters.AddWithValue("@da", d_name.Text);
                cmd.Parameters.AddWithValue("@db", d_email.Text);
                cmd.Parameters.AddWithValue("@dc", d_address.Text);
                cmd.Parameters.AddWithValue("@dd", qualification.Text);
                cmd.Parameters.AddWithValue("@de", experience.Text);
                cmd.Parameters.AddWithValue("@df", specialization.Text);
                cmd.Parameters.AddWithValue("@dg", d_contact_no.Text);
                cmd.Parameters.AddWithValue("@dh", certificate.Text);

                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Doctor record inserted successfully..");
                this.Hide();
                Form4 f4 = new Form4();
                f4.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            d_name.Text = "";
            d_email.Text = "";
            d_address.Text = "";
            qualification.Text = "";
            experience.Text = "";
            specialization.Text = "";
            d_contact_no.Text = "";
            certificate.Text = "";
        }

        private void Form23_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }

}

