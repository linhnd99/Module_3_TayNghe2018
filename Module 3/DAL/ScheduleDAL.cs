using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Module_3.DTO;

namespace Module_3.DAL
{
    class ScheduleDAL
    {
        private static SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ToString());

        public static List<Schedule> GetAllSchedules ()
        {
            sqlcon.Open();
            string sql = "SELECT (ID,Date,Time,AircraftID,RouteID,FlightNumber,EconomyPrice,Confirmed) FROM Schedules";
            SqlCommand cmd = new SqlCommand(sql, sqlcon);
            SqlDataReader rd = cmd.ExecuteReader();
            List<Schedule> res = new List<Schedule>();
            while (rd.Read())
            {
                Schedule one = new Schedule(rd["ID"].ToString(), rd["Date"].ToString(), rd["Time"].ToString(), rd["AircraftID"].ToString(), rd["RouteID"].ToString(), int.Parse(rd["FlightNumber"].ToString()), double.Parse(rd["EconomyPrice"].ToString()), bool.Parse(rd["Confirmed"].ToString()));
                res.Add(one);
            }
            sqlcon.Close();
            return res;
        }

        public static List<Schedule> SearchParameters(Dictionary<string,string> param)
        {
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
                Schedule one = new Schedule(rd["ID"].ToString(), rd["Date"].ToString(), rd["Time"].ToString(), rd["AircraftID"].ToString(), rd["RouteID"].ToString(), int.Parse(rd["FlightNumber"].ToString()), double.Parse(rd["EconomyPrice"].ToString()), bool.Parse(rd["Confirmed"].ToString()));
                res.Add(one);
            }
            sqlcon.Close();
            return res;
        }
    }
}
