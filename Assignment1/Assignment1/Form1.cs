using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Assignment1
{

    
    public partial class Form1 : Form
    {

        // StreamWriter d = File.AppendText("Data.txt");



        //StreamReader dr = new StreamReader("Data.txt");

    

       public string User { get; set; }

        ArrayList Data = new ArrayList();       //array list format [0][6]
        //string userType;                                        //txt file format [0][6]    use counter to keep positioning 
        
     

      


    public Form1()
        {
            
             InitializeComponent();
            

            var lines = File.ReadAllLines("Data.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                
                Data.Add(lines[i].ToString());
            }

            hideTab();
            
           if (ClassUserType.userType.Equals("User"))
            {
               button1.Visible = false;
           }


       


        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            

            hideTab(); //calls hideTab method

            tabControl1.TabPages.Add(tpCapture); //adds 

            tabControl1.SelectedTab = tpCapture;

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

            cmbCity.Items.Clear();            

            Boolean bFound = false;
            for (int i = 0; i < Data.Count; i++)
            {
                bFound = false;
                for (int j = 0; j < cmbCity.Items.Count; j++)
                {

                    if (Data[i].ToString().Equals(cmbCity.Items[j].ToString()))
                    {
                        bFound = true;
                    }
                }

                if (bFound != true)
                {
                    cmbCity.Items.Add(Data[i].ToString());
                }

                i = i + 6;      // forces counter to read cities due to array format [0][6] where city is first is always first value stored ([0][0] , [1][0],[2][0])
            }

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'progPoeDatabaseDataSet.ForecastData' table. You can move, or remove it, as needed.
            //this.forecastDataTableAdapter.Fill(this.progPoeDatabaseDataSet.ForecastData);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            

            hideTab();

            tabControl1.TabPages.Add(tpSearch); //adds the Search city tab to tabControl1
           
            tabControl1.SelectedTab = tpSearch;     //selects the Search city tab on tabControl1

            cmbCity.Items.Clear();


        
            Program.sqlConn.Open();

            SqlCommand scmd = new SqlCommand("Select Distinct(City) FROM ForecastData", Program.sqlConn);  //what statement will be used to filter data

            scmd.Connection = Program.sqlConn;

            DataTable data = new DataTable();

            SqlDataReader sdr = scmd.ExecuteReader();

            data.Load(sdr);

            for (int i = 0; i < data.Rows.Count; i++)
            {
                cmbCity.Items.Add(data.Rows[i][0]);
            }


            Program.sqlConn.Close();
        
        }

        private void button3_Click(object sender, EventArgs e)
        {



            hideTab();

            tabControl1.TabPages.Add(tpSearchMulti);  //adds the Search multiple cities tab to tabControl1

            checkedListBox1.Items.Clear();

            tabControl1.SelectedTab = tpSearchMulti;   //selects the Search multiple cities tab on tabControl1

            Program.sqlConn.Open();

            SqlCommand scmd = new SqlCommand("Select Distinct(City) FROM ForecastData", Program.sqlConn);  //what statement will be used to filter data

            scmd.Connection = Program.sqlConn;

            DataTable data = new DataTable();

            SqlDataReader sdr = scmd.ExecuteReader();

            data.Load(sdr);

            for (int i = 0; i < data.Rows.Count; i++)
            {
                checkedListBox1.Items.Add(data.Rows[i][0]);
            }


            Program.sqlConn.Close();
        }

            private void button4_Click(object sender, EventArgs e)
        {
            
           // string connectionString;
           // SqlConnection conn;

            // Program.ConnString= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saiypher\Desktop\work\BCAD2\PROGbackup\Assignment1\Assignment1\ProgPoeDatabase.mdf;Integrated Security=True";
          
            // conn = new SqlConnection(Program.ConnString);

            // string sql = "";

            
           // 

            
        
            string sDate;
            sDate = dateTimePicker1.Value.ToLongDateString();

                if ((tbCity.Text == null) || (nudPre.Value > 100) || (nudPre.Value < 0) || (nudHum.Value > 100) || (nudPre.Value < 0))
            {
                MessageBox.Show("Please full all details");
            }
            else
            {


                //    sql = "Insert into ForecastData(City,Date,MinTemp,Maxtemp,Preciptation,Humdity,Wind) values( " + tbCity.Text+ ", " + dateTimePicker1.Value.Date + ", " + nudMinTemp.Value + ", " + nudMaxTemp.Value + ", " + nudPre.Value + ", " + nudHum.Value + ", " + nudWind.Value +" )";
                Program.sqlConn.Open();
                
                string cmd = "Insert into ForecastData VALUES (@City,@Date,@MinTemp,@Maxtemp,@Preciptation,@Humidty,@Wind)";

                //  SqlCommand scmd = new SqlCommand("Insert into ForecastData(City,Date,MinTemp,Maxtemp,Preciptation,Humdity,Wind) values( " + tbCity.Text + ", " + dateTimePicker1.Value.Date + ", " + nudMinTemp.Value + ", " + nudMaxTemp.Value + ", " + nudPre.Value + ", " + nudHum.Value + ", " + nudWind.Value + ")");

                SqlCommand scmd = new SqlCommand(cmd);
                scmd.Connection = Program.sqlConn;

                scmd.Parameters.AddWithValue("@City",tbCity.Text);
                scmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value.Date);
                scmd.Parameters.AddWithValue("@MinTemp", nudMinTemp.Value);
                scmd.Parameters.AddWithValue("@Maxtemp", nudMaxTemp.Value);
                scmd.Parameters.AddWithValue("@Preciptation", nudPre.Value);
               scmd.Parameters.AddWithValue("@Humidty", nudHum.Value);
                scmd.Parameters.AddWithValue("@Wind", nudWind.Value);

                scmd.ExecuteNonQuery();



                //SqlDataReader sdr = scmd.ExecuteReader();


                nudMinTemp.Value = 0;                           //sets all values of the inputs to the default
                nudMaxTemp.Value = 0;
                nudPre.Value = 0;
                nudHum.Value = 0;
                nudWind.Value = 0;
                tbCity.Clear();
                Program.sqlConn.Close();
                MessageBox.Show("New forecast added");
            }
         
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            // dataGridView2.Rows.Clear();

            SqlCommand scmd = new SqlCommand("Select * from ForecastData WHERE City = '" + cmbCity.Text + "' AND Date > '" + dtpStartDate.Value + "' AND Date < '" + dtpEndDate.Value + "';", Program.sqlConn);

            Program.sqlConn.Open();

            DataTable datatable = new DataTable();

            SqlDataReader sdr = scmd.ExecuteReader();

            datatable.Load(sdr);

            dataGridView2.DataSource = datatable;

            Program.sqlConn.Close();



            
        
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
         
        }

        private void button6_Click(object sender, EventArgs e)
        {

            //  dataGridView1.Rows.Clear();
            Program.sqlConn.Open();


            foreach (string items in checkedListBox1.CheckedItems)
            {
                SqlCommand scmd = new SqlCommand("Select * from ForecastData WHERE City = '" + items + "' AND Date > '" + dtStart.Value + "' AND Date < '" + dtEnd.Value + "';", Program.sqlConn);

                
                DataTable datatable = new DataTable();

                SqlDataReader sdr = scmd.ExecuteReader();

                datatable.Load(sdr);

               // dataGridView1.Rows.Add(sdr.GetString(1),sdr.GetDateTime(2).Date, sdr.GetInt32(3), sdr.GetInt32(4), sdr.GetInt32(5), sdr.GetInt32(6), sdr.GetInt32(7));

               dataGridView1.DataSource = datatable;

               

            }

            Program.sqlConn.Close();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            Boolean bFound = false;
            for (int i = 0; i < Data.Count; i++)
            {
                bFound = false;
                for (int j = 0; j < checkedListBox1.Items.Count; j++)               
                {

                    if (Data[i].ToString().Equals(checkedListBox1.Items[j].ToString()))          //checks if city from data has already been added to checklist Cities
                    {
                        bFound = true;
                    }
                }

                if (bFound != true)                                                              //if city from array list data is not found in checklist cities it then adds it to the checklist
                {
                    checkedListBox1.Items.Add(Data[i].ToString());
                }

                i = i + 6;                                                                      //sets the position of reader of the arraylist to the next city due to format which data is stored in arraylist 
            }

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        public void hideTab()
        {
            tabControl1.TabPages.Remove(tpCapture);

            tabControl1.TabPages.Remove(tpSearch);

            tabControl1.TabPages.Remove(tpSearchMulti);

            
        }

      //  public void startSplash()
        //{
       //     Application.Run(new FormSplash());
      //  }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void forecastDataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void forecastDataBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
        
        }
    }

   

}
