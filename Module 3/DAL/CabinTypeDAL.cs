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
    class CabinTypeDAL
    {
        public List<CabinType> GetAllCabinTypes()
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStrings"].ToString());
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            return null;
        }

        public CabinType GetCabinTypeWithId(string id)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStrings"].ToString());
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            return null;
        }
    }
}
