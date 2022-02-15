using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    static class Program
    {
        public static string ConnString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saiypher\Desktop\work\BCAD2\PROG backup\Assignment1\Assignment1\ProgPoeDatabase.mdf;Integrated Security=True";
        public static SqlConnection sqlConn = new SqlConnection(ConnString);
     //   public static SqlCommand scmd = new SqlCommand("Select * from ForecastData", Program.sqlConn);
     //   public static SqlDataReader sdr = scmd.ExecuteReader();
    

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
            
        }
    }
}
