using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DLL
{
    public class Tbl_DetailWar_DAL:DAL_Con
    {
        public int Insert(string IDAcc1, string Acc2, DateTime DayWar,int IDResult, int IDTT)
        {
            SqlCommand cmd = new SqlCommand("DetailWar_Insert", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NameWar1", IDAcc1);
            cmd.Parameters.AddWithValue("@NameWar2", Acc2);
            cmd.Parameters.AddWithValue("@DayWar", DayWar);
            cmd.Parameters.AddWithValue("@IDResult", IDResult);
            cmd.Parameters.AddWithValue("@IDTT", IDTT);
            return cmd.ExecuteNonQuery();
        }
    }
}
