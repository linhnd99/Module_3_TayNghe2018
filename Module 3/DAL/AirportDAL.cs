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
    class AirportDAL
    {
        public List<Airport> GetAllAirports()
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStrings"].ToString());
                sqlcon.Open();
                string sql = "SELECT * FROM Airports";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                SqlDataReader rd = cmd.ExecuteReader();
                List<Airport> res = new List<Airport>();
                while (rd.Read())
                {
                    Airport one = new Airport(rd["ID"].ToString(), rd["CountryID"].ToString(), rd["IATACode"].ToString(), rd["Name"].ToString());
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

        public Airport GetAirportWithID(string id)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStrings"].ToString());
                sqlcon.Open();
                string sql = "SELECT * FROM Airtports WHERE ID=" + id;
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    sqlcon.Close();
                    return new Airport(rd["ID"].ToString(), rd["CountryID"].ToString(), rd["IATACode"].ToString(), rd["Name"].ToString());
                }
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            return null;
        }
    }
}
