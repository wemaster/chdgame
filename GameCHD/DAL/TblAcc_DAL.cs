using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace DLL
{
    public class TblAcc_DAL:DAL_Con
    {
        /// <summary>
        /// hiển thị câu test theo acc
        /// </summary>
        /// <param name="IDAcc"></param>
        /// <returns></returns>
        public DataTable SelectCauTest(int IDAcc)
        {
            SqlCommand cmd = new SqlCommand("Tbl_Acc_SelectIDTest", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDAcc", IDAcc);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable ViewAccID(int IDAcc)
        {
            SqlCommand cmd = new SqlCommand("ACC_SELETCT_ID", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDAcc", IDAcc);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable ViewAccName(string NameAcc)
        {
            SqlCommand cmd = new SqlCommand("TblAcc_seletc_name", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NameAcc", NameAcc);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable ViewAcc2(int IDTT, int IDSubjects)
        {
            SqlCommand cmd = new SqlCommand("TblAcc_SELECT_TT", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDTT",IDTT);
            cmd.Parameters.AddWithValue("@IDSubjects",IDSubjects);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable ViewAccBoss()
        {
            SqlCommand cmd = new SqlCommand("TblBoss_ViewAccBoss", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable CheckLogin(string NameAcc, string PassAcc)
        {
            SqlCommand cmd = new SqlCommand("TblAcc_login", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NameAcc", NameAcc);
            cmd.Parameters.AddWithValue("@PassAcc", PassAcc);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable ViewIDClass(int IDClass,int IDAcc)
        {
            SqlCommand cmd = new SqlCommand("TblAcc_SELECT_CLASS", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDClass", IDClass);
            cmd.Parameters.AddWithValue("@IDAcc", IDAcc);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int UpdateExpPoint(int IDAcc,double Exp,double Point)
        {
            SqlCommand cmd = new SqlCommand("Tbl_Acc_UPDATE_Exp_Point", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDAcc", IDAcc);
            cmd.Parameters.AddWithValue("@ExpAcc", Exp);
            cmd.Parameters.AddWithValue("@Point", Point);
            return cmd.ExecuteNonQuery();
        }
        public int UpdateLevel(int IDAcc, int Level)
        {
            SqlCommand cmd = new SqlCommand("Tbl_Acc_UPDATE_Level", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDAcc", IDAcc);
            cmd.Parameters.AddWithValue("@Level", Level);
            return cmd.ExecuteNonQuery();
        }
        public int UpdateNumWin(int IDAcc, int NumWin)
        {
            SqlCommand cmd = new SqlCommand("Tbl_Acc_UPDATE_NumWin", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDAcc", IDAcc);
            cmd.Parameters.AddWithValue("@NumWin",NumWin);
            return cmd.ExecuteNonQuery();
        }
        public int UpdateNumLose(int IDAcc, int NumLose)
        {
            SqlCommand cmd = new SqlCommand("Tbl_Acc_UPDATE_NumLose", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDAcc", IDAcc);
            cmd.Parameters.AddWithValue("@NumLose",NumLose);
            return cmd.ExecuteNonQuery();
        }
        public int UpdateNumRank(int IDAcc, int NumRank)
        {
            SqlCommand cmd = new SqlCommand("Tbl_Acc_UPDATE_NumRank", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDAcc", IDAcc);
            cmd.Parameters.AddWithValue("@NumRank", NumRank);
            return cmd.ExecuteNonQuery();
        }
        public DataTable SelectAccViewMem()
        {
            SqlCommand cmd = new SqlCommand("TblAcc_SelectviewMem", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int RegTaiKhoan(string NameAcc, string Pwd, string email, string dateReg)
        {
            SqlCommand cmd = new SqlCommand("TblAcc_Reg", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NameAcc", NameAcc);
            cmd.Parameters.AddWithValue("@Pwd", Pwd);
             cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@DateReg", dateReg);
            return cmd.ExecuteNonQuery();
        }
        public int UpdateClass(int IDAcc,int IDClass)
        {
            SqlCommand cmd = new SqlCommand("TblAcc_UpdateClass", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDAcc", IDAcc);
            cmd.Parameters.AddWithValue("@IDClass", IDClass);
            return cmd.ExecuteNonQuery();
        }
    }
}
