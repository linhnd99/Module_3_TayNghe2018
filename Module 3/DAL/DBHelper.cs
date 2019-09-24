using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Module_3.DAL;
using Module_3.DTO;
using System.Collections;
using System.Windows.Forms;

namespace Module_3.DAL
{
    class DBHelper
    {
        public List<Dictionary<string,string>> GetFlightsWithParameters(Dictionary<string,string> param)
        {
            //SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-KVVMBTR\\SUDO;Initial Catalog=database_demo;Integrated Security=True");
            SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["db_module3_connectionString"].ToString());
            //System.Console.WriteLine(ConfigurationManager.ConnectionStrings["cnnString"].ToString());
            string sql =
                "SELECT DepartureAirportID, ArrivalAirportID, Date, Time, FlightNumber, CabinTypes.Name " +
                "FROM Routes inner join Schedules on Routes.ID = Schedules.RouteID " +
                "inner join Tickets on Schedules.ID=Tickets.ScheduleID "+
                "inner join CabinTypes on Tickets.CabinTypeID=CabinTypes.ID "+
                "WHERE ";
            if (param["DepartureAirportID"] != null) sql = sql + "DepartureAirportID = '" + param["DepartureAirportID"] + "' and ";
            if (param["ArrivalAirportID"] != null) sql = sql + "ArrivalAirportID = '" + param["ArrivalAirportID"] + "' and ";
            if (param["FirstDate"] != null) sql = sql + "Date>='" + param["FirstDate"] + "' and ";
            if (param["LastDate"] != null) sql = sql + "Date<='" + param["LastDate"] + "' and ";
            if (param["CabinType"] != null) sql = sql + "CabinTypes.Name='" + param["CabinType"] + "' and ";
            sql = sql.Substring(0, sql.Length - 4);

            try
            {
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                SqlDataReader rd = cmd.ExecuteReader();
                List<Dictionary<string, string>> res = new List<Dictionary<string, string>>();
                while (rd.Read())
                {
                    Dictionary<string, string> temp = new Dictionary<string, string>();
                    temp["DepartureAirportID"] = rd["DepartureAirportID"].ToString();
                    temp["ArrivalAirportID"] = rd["ArrivalAirportID"].ToString();
                    temp["Date"] = rd["Date"].ToString();
                    temp["Time"] = rd["Time"].ToString();
                    temp["FlightNumber"] = rd["FlightNumber"].ToString();
                    temp["CabinType"] = rd["Name"].ToString();
                    res.Add(temp);    
                }
                sqlcon.Close();
                return res;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Error");
            }
            return null;
        }
    }
}
