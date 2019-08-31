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
    class CountryDAL
    {
        static SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ToString());

        public static List<Country> GetAllCountries()
        {
            string sql = "SELECT (ID, Name) FROM Countries";
            SqlCommand cmd = new SqlCommand(sql, sqlcon);
            SqlDataReader rd = cmd.ExecuteReader();
            List<Country> res = new List<Country>();
            while (rd.Read())
            {
                Country temp = new Country(rd["ID"].ToString(), rd["Name"].ToString());
                res.Add(temp);
            }
            return res;
        }
    }
}
