using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Hotelier_Hotel_ManagementSystem
{
    class SqlConnectionClass
    {
        /*public static string ConReturn()
        {
            //return (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + System.IO.Path.GetFullPath("HotelierbaseDataSet") + ";Integrated Security = True; Connect Timeout=30;");
            return (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\DataBase\Hotelierbase.mdf;Integrated Security = True");
        }*/
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["Hotelier_Hotel_ManagementSystem.Properties.Settings.HotelierbaseConnectionString"].ConnectionString;
    }
}
