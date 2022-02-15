using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
            if (rbForecaster.Checked == true)
            {
                StreamWriter f = File.AppendText("Forecasters.txt");
                f.WriteLine(tbUsername.Text);
                f.WriteLine(tbPassword.Text);              
                f.Close();
            }
            else
            {
                StreamWriter g = File.AppendText("GeneralUsers.txt");
                g.WriteLine(tbUsername.Text);
                g.WriteLine(tbPassword.Text);
                g.Close();
            }
            
            this.Hide();
            Login home = new Login();
            home.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login home = new Login();
            home.ShowDialog();
        }
    }
}
