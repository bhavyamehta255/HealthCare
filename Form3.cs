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
    public partial class Form3 : Form 
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p_name.Text = "";
            p_email.Text = "";
            p_address.Text = "";
            p_blood_group.Text = "";
            p_med_history.Text = "";
            p_disease.Text = "";
            p_prescription.Text = "";
          
            p_phone_no.Text = "";
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            bool flag = true;
            if (p_name.Text.Length == 0)
            {
                flag = false;
                ErrorProvider ep = new ErrorProvider();
                ep.SetError(p_name, "Required");
            }
            if (p_email.Text.Length == 0)
            {
                flag = false;
                ErrorProvider ep = new ErrorProvider();
                ep.SetError(p_email, "Required");
            }
            if (p_address.Text.Length == 0)
            {
                flag = false;
                ErrorProvider ep = new ErrorProvider();
                ep.SetError(p_address, "Required");
            }
            if (p_blood_group.Text.Length == 0)
            {
                flag = false;
                ErrorProvider ep = new ErrorProvider();
                ep.SetError(p_blood_group, "Required");
            }
            if (p_med_history.Text.Length == 0)
            {
                flag = false;
                ErrorProvider ep = new ErrorProvider();
                ep.SetError(p_med_history, "Required");
            }
            if (p_disease.Text.Length == 0)
            {
                flag = false;
                ErrorProvider ep = new ErrorProvider();
                ep.SetError(p_disease, "Required");
            }
           
            
            if (p_phone_no.Text.Length == 0)
            {
                flag = false;
                ErrorProvider ep = new ErrorProvider();
                ep.SetError(p_phone_no, "Required");
            }
            if (flag == true)
            {


                    SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amit\Documents\Visual Studio 2010\Projects\healthcare\healthcare\final health care.mdf;Integrated Security=True;Connect Timeout=30");

                    cn.Open();
                    SqlCommand cmd = new SqlCommand("insert into patient1 values(@pa,@pb,@pc,@pd,@pe,@pf,@pg)", cn);
                    cmd.Parameters.AddWithValue("@pa", p_name.Text);
                    cmd.Parameters.AddWithValue("@pb", p_email.Text);
                    cmd.Parameters.AddWithValue("@pc", p_address.Text);
                    cmd.Parameters.AddWithValue("@pd", p_blood_group.Text);
                    cmd.Parameters.AddWithValue("@pe", p_med_history.Text);
                    cmd.Parameters.AddWithValue("@pf", p_disease.Text);
                    cmd.Parameters.AddWithValue("@pg", p_phone_no.Text);
                    cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("Patient record inserted successfully..");

                    Form5 f5 = new Form5();
                    f5.Show();
                    cn.Close();
                
                
                    
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
           
            if (op.ShowDialog() == DialogResult.OK)
            {
                PictureBox p = new PictureBox();
                 p.Image = new Bitmap(op.FileName);
                p_doc.Text = op.FileName;
            }

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();

            if (op.ShowDialog() == DialogResult.OK)
            {
                PictureBox p = new PictureBox();
                p.Image = new Bitmap(op.FileName);
                p_doc.Text = op.FileName;
            }
        }

        private void p_blood_group_TextChanged(object sender, EventArgs e)
        {

        }

        private void p_phone_no_TextChanged(object sender, EventArgs e)
        {

        }

        private void p_prescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void p_disease_TextChanged(object sender, EventArgs e)
        {

        }

        private void p_med_history_TextChanged(object sender, EventArgs e)
        {

        }

        private void p_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void p_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void p_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void p_doc_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form5 f5 = new Form5();
            this.Hide();
            f5.Show();        
        }
    }
}
