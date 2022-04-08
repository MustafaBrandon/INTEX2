
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace INTEX.Models
{
    public static class DbHelper
    {
        //Used to get sensitive data from the environment and build the connection string so no sensitive data is exposed
        public static string GetRDSConnectionString(string dbname = "UCAPS")
        {
            if (string.IsNullOrEmpty(dbname)) return null;

            string username = Environment.GetEnvironmentVariable("RDS_USERNAME");
            string password = Environment.GetEnvironmentVariable("RDS_PASSWORD");
            string hostname = Environment.GetEnvironmentVariable("RDS_HOSTNAME");
            //string port = "3306";

            return "Data Source=" + hostname + ";Initial Catalog=" + dbname + ";User ID=" + username + ";Password=" + password + ";";
        }
    }
}
