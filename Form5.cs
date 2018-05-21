using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_health_care
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text=="admin" && pwd.Text=="admin")
            {
                Form7 f7= new Form7();
                Hide();
                f7.Show();
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void pwd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
