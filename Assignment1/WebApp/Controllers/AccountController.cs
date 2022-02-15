using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Web.Mvc.Html;
using System.Web.UI.HtmlControls;
using System.Text;

namespace WebApp.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader sdr;

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Tables()
        {
            return View();
        }

        //methods
        void connectionString()
        {
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Saiypher\Desktop\work\BCAD2\PROG backup\Assignment1\Assignment1\ProgPoeDatabase.mdf;Integrated Security=True";
        }

        [HttpPost]
        public ActionResult Verify(Account acc)
        {
            ViewBag.ErrorMessage = null;
            connectionString();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = "Select * from Users where Username = '" + acc.User + "' AND  Password = '" + acc.Pass + "'";
            sdr = cmd.ExecuteReader();
   
            if (sdr.Read())
            {

                acc.FavCities = sdr.GetString(3);
               
                conn.Close();
                return View(acc);
            }
            else
            {
                conn.Close();
               
                ViewBag.ErrorMessage = "Email not found or matched";
                return View("Login");
            }

          
        }
        [HttpPost]
        public ActionResult Tables(Account acc)
        {
            connectionString();
            conn.Open();
            cmd.Connection = conn;
           
            cmd.CommandText = "Select Top 1 * FROM ForecastData WHERE City = '" + acc.FavCities + "' ORDER BY Date";
           
            sdr = cmd.ExecuteReader();
          
            if (sdr.Read())
            {
                string output = sdr.GetString(1) + " DATE :" + sdr.GetDateTime(2).Date + " Minimum Temeratures °C:" + sdr.GetInt32(3) + " Maximum Temeratures °C:" + sdr.GetInt32(4) + " Preciptation %:" + sdr.GetInt32(5) + " Humidty %:" + sdr.GetInt32(6) + " Wind km/h:" + sdr.GetInt32(7);
                acc.City = output;
                conn.Close();
                return View(acc);
            }
            else
            {
                acc.City = "Error data could not found";
                conn.Close();
                return View(acc);
            }
                    
        }

        
    }
}