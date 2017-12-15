using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DLL
{
    public class TblClass_DAL:DAL_Con
    {
        public DataTable ViewCL()
        {
            SqlCommand cmd = new SqlCommand("TblClass_SELECT", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
