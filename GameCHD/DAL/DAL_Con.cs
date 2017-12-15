using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace DLL
{
    public class DAL_Con
    {
        SqlConnection ketnoi = new SqlConnection(ConfigurationManager.ConnectionStrings["chuoiketnoi"].ConnectionString);
        public SqlConnection Ketnoi()
        {
            try
            {
                if (ketnoi.State == ConnectionState.Closed)
                    ketnoi.Open();
                return ketnoi;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
