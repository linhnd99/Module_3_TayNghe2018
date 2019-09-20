using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using Module_3.DTO;
using System.Windows.Forms;
using System.Globalization;

namespace Module_3.DAL
{
    class RouteDAL
    {
        public List<Route> GetAllRoutes()
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStrings"].ToString());
                sqlcon.Open();
                string sql = "SELECT ID,DepartureAirportID, ArrivalAirportID, Distance, FlightTime FROM Routes";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                SqlDataReader rd = cmd.ExecuteReader();
                List<Route> res = new List<Route>();
                while (rd.Read())
                {
                    DateTime temp = Convert.ToDateTime(rd["FlightTime"]);
                    //DateTime.ParseExact(rd["FlightTime"].ToString(), "dd/MM/yy", CultureInfo.InvariantCulture)
                    res.Add(new Route(rd["ID"].ToString(), rd["DepartureAirportID"].ToString(), rd["ArrivalAirportID"].ToString(), Convert.ToDouble(rd["Distance"]), temp));
                    
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

        public Route GetRouteWithID(string routeID)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStrings"].ToString());
                sqlcon.Open();
                string sql = "SELECT (ID,DepartureAirportID, ArrivalAirportID, Distance, FlightTime) FROM Routes WHERE ID='" + routeID+"'";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    sqlcon.Close();
                    return new Route(rd["ID"].ToString(), rd["DepartureAirportID"].ToString(), rd["ArrivalAirportID"].ToString(), Convert.ToDouble(rd["Distance"]), DateTime.ParseExact(rd["FlightTime"].ToString(), "hh:mm:ss dd/MM/yy", CultureInfo.InvariantCulture));
                }
                sqlcon.Close();
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            return null;
        }

        public Route GetRouteWithDepartureAirportIDAndArrivalAirportID(string departureID, string arrivalID)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStrings"].ToString());
                sqlcon.Open();
                string sql = "SELECT ID, DepartureAirportID, ArrivalAirportID, Distance, FlightTime FROM Routes WHERE DepartureAirportID='" + departureID + "' and ArrivalAirportID='" + arrivalID+"'";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                SqlDataReader rd = cmd.ExecuteReader();
                //List<Route> res = new List<Route>();
                Route res = new Route();
                while (rd.Read())
                {
                    //res.Add(new Route(rd["ID"].ToString(), rd["DepartureAirportID"].ToString(), rd["ArrivalAirportID"].ToString(), Convert.ToDouble(rd["Distance"]), DateTime.ParseExact(rd["FlightTime"].ToString(),"hh:mm:ss dd/MM/yy", CultureInfo.InvariantCulture)));
                    DateTime temp = Convert.ToDateTime(rd["FlightTime"]);
                    res = new Route(rd["ID"].ToString(), rd["DepartureAirportID"].ToString(), rd["ArrivalAirportID"].ToString(), Convert.ToDouble(rd["Distance"]), temp);
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
