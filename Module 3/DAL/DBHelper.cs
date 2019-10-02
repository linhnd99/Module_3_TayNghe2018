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
                "SELECT DepartureAirportID, ArrivalAirportID, Date, Time, FlightNumber, CabinTypes.Name, Schedules.ID as 'schedule_id', EconomyPrice " +
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
                    temp["Date"] = Convert.ToDateTime(rd["Date"]).ToString("dd/MM/yyyy");
                    temp["Time"] = rd["Time"].ToString();
                    temp["FlightNumber"] = rd["FlightNumber"].ToString();
                    temp["CabinType"] = rd["Name"].ToString();
                    temp["schedule_id"] = rd["schedule_id"].ToString();
                    temp["EconomyPrice"] = rd["EconomyPrice"].ToString();
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

        public List<PassengerDetail> GetPassengerListWithScheduleID(string scheduleid)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["module_3_connectionString"].ToString());
                sqlcon.Open();
                string cabintype_name = SharedData.outboundFlight.CabinType;
                string sql = "SELECT Tickets.ID as TicketID, UserID, Fistname, Lastname, Birthdate, PassportNumber, PassportCountryID, Phone " +
                    "FROM Users inner join Tickets on Users.ID = Tickets.UserID  inner join CabinTypes on Tickets.CabinTypeID = CabinTypes.ID WHERE " +
                    "Tickets.ScheduleID = '"+scheduleid+"' and CabinTypes.Name='"+ cabintype_name +"' ";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                SqlDataReader rd = cmd.ExecuteReader();
                List<PassengerDetail> res = new List<PassengerDetail>();
                while (rd.Read())
                {
                    PassengerDetail temp = new PassengerDetail(rd["TicketID"].ToString(), rd["UserID"].ToString(), rd["Firstname"].ToString(),
                        rd["Lastname"].ToString(), Convert.ToDateTime(rd["Birthdate"]),rd["PassportNumber"].ToString(), 
                        rd["PassportCountryID"].ToString(),rd["phone"].ToString());

                    res.Add(temp);
                }
                sqlcon.Close();
                return res;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            return null;
        }
    }
}
