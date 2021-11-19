using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

//conString class used to simplify the connection string process throughout the application

namespace c3305879_Assign2
{
    public class conString
    {
        public static SqlConnection con; //create SqlConnection variable con

        static conString()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString); //assigning con a new SqlConnection value.
        }
    }
}
