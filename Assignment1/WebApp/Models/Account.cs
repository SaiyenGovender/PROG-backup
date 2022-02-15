using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Account
    {
        public string User { get; set; }

        public string Pass { get; set; }

        public string FavCities { get; set; }

        public string City  { get; set; }

        public int errorCount { get; set; }

    }
}