using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Module_3.DTO;
using System.Windows.Forms;

namespace Module_3.DAL
{
    class ScheduleDAL
    {
        public List<Schedule> GetAllSchedules ()
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStrings"].ToString());
                sqlcon.Open();
                string sql = "SELECT (ID,Date,Time,AircraftID,RouteID,FlightNumber,EconomyPrice,Confirmed) FROM Schedules";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                SqlDataReader rd = cmd.ExecuteReader();
                List<Schedule> res = new List<Schedule>();
                while (rd.Read())
                {
                    Schedule one = new Schedule(rd["ID"].ToString(), DateTime.Parse(rd["Date"].ToString()), DateTime.Parse(rd["Time"].ToString()), rd["AircraftID"].ToString(), rd["RouteID"].ToString(), int.Parse(rd["FlightNumber"].ToString()), double.Parse(rd["EconomyPrice"].ToString()), bool.Parse(rd["Confirmed"].ToString()));
                    res.Add(one);
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

        public List<Schedule> GetScheduleWithParameters(Dictionary<string,string> param)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStrings"].ToString());
                sqlcon.Open();
                string sql = "SELECT (ID,Date,Time,AircraftID,RouteID,FlightNumber,EconomyPrice,Confirmed) FROM Schedules WHERE ";
                bool check = false;
                foreach (string first in param.Keys)
                {
                    sql = sql + first + "=" + param[first] + " AND ";
                    check = true;
                }
                if (check) sql.Remove(sql.Length - 1 - 4, 4);
                Console.WriteLine("search parameters sql : " + sql);

                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                SqlDataReader rd = cmd.ExecuteReader();
                List<Schedule> res = new List<Schedule>();
                while (rd.Read())
                {
                    Schedule one = new Schedule(rd["ID"].ToString(), DateTime.Parse(rd["Date"].ToString()), DateTime.Parse(rd["Time"].ToString()), rd["AircraftID"].ToString(), rd["RouteID"].ToString(), int.Parse(rd["FlightNumber"].ToString()), double.Parse(rd["EconomyPrice"].ToString()), bool.Parse(rd["Confirmed"].ToString()));
                    res.Add(one);
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

        public List<Schedule> GetScheduleWithRouteID(string routeID)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStrings"].ToString());
                sqlcon.Open();
                string sql = "SELECT(ID, Date, Time, AircraftID, RouteID, FlightNumber, EconomyPrice, Confirmed) FROM Schedules WHERE RouteID=" + routeID;
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                SqlDataReader rd = cmd.ExecuteReader();
                List<Schedule> res = new List<Schedule>();
                while(rd.Read())
                {
                    res.Add(new Schedule(rd["ID"].ToString(), DateTime.Parse(rd["Date"].ToString()), DateTime.Parse(rd["Time"].ToString()), rd["AircraftID"].ToString(), rd["RouteID"].ToString(), int.Parse(rd["FlightNumber"].ToString()), double.Parse(rd["EconomyPrice"].ToString()), bool.Parse(rd["Confirmed"].ToString())));
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
