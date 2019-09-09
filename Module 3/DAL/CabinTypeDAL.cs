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
    class CabinTypeDAL
    {
        static SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ToString());

        public static List<CabinType> GetAllCabinTypes()
        {
            sqlcon.Open();
            string sql = "SELECT * FROM CabinTypes";
            SqlCommand cmd = new SqlCommand(sql, sqlcon);
            SqlDataReader rd = cmd.ExecuteReader();
            List<CabinType> res = new List<CabinType>();
            while (rd.Read())
            {
                res.Add(new CabinType(rd["ID"].ToString(), rd["Name"].ToString()));
            }
            sqlcon.Close();
            return res;
        }

        public static CabinType GetCabinTypeWithId(string id)
        {
            sqlcon.Open();
            string sql = "SELECT * FROM CabinTypes WHERE ID=" + id;
            SqlCommand cmd = new SqlCommand(sql, sqlcon);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                sqlcon.Close();
                return new CabinType(rd["ID"].ToString(), rd["Name"].ToString());
            }
            sqlcon.Close();
            return null;
        }
    }
}
