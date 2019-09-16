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
    class CountryDAL
    {

        public List<Country> GetAllCountries()
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStrings"].ToString());
                sqlcon.Open();
                string sql = "SELECT (ID, Name) FROM Countries";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                SqlDataReader rd = cmd.ExecuteReader();
                List<Country> res = new List<Country>();
                while (rd.Read())
                {
                    Country temp = new Country(rd["ID"].ToString(), rd["Name"].ToString());
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
