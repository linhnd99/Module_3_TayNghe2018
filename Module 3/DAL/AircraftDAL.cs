using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Module_3.DAL
{
    class AircraftDAL
    {
        SqlConnection sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ToString());
        SqlCommand sqlcmd;

    }
}
