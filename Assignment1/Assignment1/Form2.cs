using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
   

    public partial class Form2 : Form
    {
      

        public Form2()
        {
            Thread Time = new Thread(new ThreadStart(startSplash));
            Time.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            Time.Abort();
        }

        public void startSplash()
        {
            Application.Run(new FormSplash());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                Boolean bUserFound = false;             //user txt file format username (nextline) password    
                Boolean bPassFound = false;

            string pass;
            string user;
            Boolean found;

            user = tbUser.Text;
            pass = tbPass.Text;

            Program.sqlConn.Open();

            SqlCommand scmd = new SqlCommand("Select UserType from Users where Username = '" + user + "' AND  Password = '" + pass + "';", Program.sqlConn );  //what statement will be used to filter data

            scmd.Connection = Program.sqlConn;

            DataTable data = new DataTable();

            SqlDataReader sdr =  scmd.ExecuteReader();

           
       

            data.Load(sdr);
            try
            {
                ClassUserType.userType = data.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("username of password is incorrect");
            
            }
         


            if (data.Rows.Count == 0 )  //if no records of the user is found they cant go to the next form
            {
                found = false;
            }
            else
            {
                found = true;
            }
            if (found == true)
            {
                Form1 tables = new Form1();
                tables.User = ClassUserType.userType; 
                tables.Show();
                this.Hide();
            }

            Program.sqlConn.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.microsoft.com");
        }
    }
}
