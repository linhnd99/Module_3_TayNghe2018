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
    class TicketDAL
    {
        public List<Ticket> GetAllTickets()
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["module_3_connectionString"].ToString());
                sqlcon.Open();
                string sql = "SELECT * FROM Tickets";
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                SqlDataReader rd = cmd.ExecuteReader();
                List<Ticket> res = new List<Ticket>();
                while (rd.Read())
                {
                    Ticket temp = new Ticket(rd["id"].ToString(), rd["UserID"].ToString(), rd["ScheduleID"].ToString(),rd["CabinTypeID"].ToString(),
                        rd["Firstname"].ToString(), rd["Lastname"].ToString(),rd["Email"].ToString(),rd["Phone"].ToString(),
                        rd["PassportNumber"].ToString(), rd["PassportCountryID"].ToString(), rd["BookingReference"].ToString(),Convert.ToBoolean(rd["Confirmed"])) ;

                    res.Add(temp);
                }
                sqlcon.Close();
                return res;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            return null;
        }

        public List<Ticket> GetTicketsWithScheduleID(string scheduleid)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["module_3_connectionString"].ToString());
                sqlcon.Open();
                string sql = "SELECT * FROM Tickets WHERE ScheduleID="+scheduleid;
                SqlCommand cmd = new SqlCommand(sql, sqlcon);
                SqlDataReader rd = cmd.ExecuteReader();
                List<Ticket> res = new List<Ticket>();
                while (rd.Read())
                {
                    Ticket temp = new Ticket(rd["id"].ToString(), rd["UserID"].ToString(), rd["ScheduleID"].ToString(), rd["CabinTypeID"].ToString(),
                        rd["Firstname"].ToString(), rd["Lastname"].ToString(), rd["Email"].ToString(), rd["Phone"].ToString(),
                        rd["PassportNumber"].ToString(), rd["PassportCountryID"].ToString(), rd["BookingReference"].ToString(), Convert.ToBoolean(rd["Confirmed"]));

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
}
