using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DLL
{
    public class TblTest_DAL:DAL_Con
    {
        public DataTable ViewTest_update()
        {
            SqlCommand cmd = new SqlCommand("TblTest_select_update", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// Hiển thị câu hỏi theo ID Test
        /// </summary>
        /// <param name="IDSub"></param>
        /// <param name="IDTT"></param>
        /// <param name="IDTest"></param>
        /// <returns></returns>
        public DataTable ViewTestID(int IDSub, int IDTT, int IDTest)
        {
            SqlCommand cmd = new SqlCommand("TblTest_SELECT_ID", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDSub", IDSub);
            cmd.Parameters.AddWithValue("@IDTT", IDTT);
            cmd.Parameters.AddWithValue("@IDTest", IDTest);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// hiển thị câu hỏi theo tình trạng
        /// </summary>
        /// <param name="IDTT"></param>
        /// <returns></returns>
        public DataTable ViewTestIDTT(int IDTT)
        {
            SqlCommand cmd = new SqlCommand("TblTest_selectIDTT", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDTT", IDTT);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// Thêm câu hỏi
        /// </summary>
        /// <param name="IdSub"></param>
        /// <param name="Content"></param>
        /// <param name="TestA"></param>
        /// <param name="TestB"></param>
        /// <param name="TestC"></param>
        /// <param name="TestD"></param>
        /// <param name="TestCorect"></param>
        /// <param name="TimeTest"></param>
        /// <param name="IDTT"></param>
        /// <param name="Phan"></param>
        /// <param name="Chuong"></param>
        /// <returns></returns>
        public int INSERT(int IdSub, string Content, string TestA, string TestB, string TestC, string TestD, string TestCorect, string TimeTest,int IDTT, int Phan, int Chuong)
        {
            SqlCommand cmd = new SqlCommand("TblTest_Insert", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            ////truyen tham so cho thu tuc
            cmd.Parameters.AddWithValue("@IDSub", IdSub);
            cmd.Parameters.AddWithValue("@Content", Content);
            cmd.Parameters.AddWithValue("@TestA", TestA);
            cmd.Parameters.AddWithValue("@TestB", TestB);
            cmd.Parameters.AddWithValue("@TestC", TestC);
            cmd.Parameters.AddWithValue("@TestD", TestD);
            cmd.Parameters.AddWithValue("@TestCrect", TestCorect);
            cmd.Parameters.AddWithValue("@TimeTest", TimeTest);
            cmd.Parameters.AddWithValue("@IDTT", IDTT);
            cmd.Parameters.AddWithValue("@IDPhan", Phan);
            cmd.Parameters.AddWithValue("@IDChuong", Chuong);
            return cmd.ExecuteNonQuery();
        }
        /// <summary>
        /// sửa câu hỏi 
        /// </summary>
        /// <param name="IDTest"></param>
        /// <param name="IdSub"></param>
        /// <param name="Content"></param>
        /// <param name="TestA"></param>
        /// <param name="TestB"></param>
        /// <param name="TestC"></param>
        /// <param name="TestD"></param>
        /// <param name="TestCorect"></param>
        /// <param name="TimeTest"></param>
        /// <returns></returns>
        public int UPDATE(int IDTest,int IdSub, string Content, string TestA, string TestB, string TestC, string TestD, string TestCorect, string TimeTest)
        {
            SqlCommand cmd = new SqlCommand("TblTest_UPDATE", Ketnoi());
            cmd.CommandType = CommandType.StoredProcedure;
            //truyen tham so cho thu tuc
            cmd.Parameters.AddWithValue("@IDTest", IDTest);
            cmd.Parameters.AddWithValue("@IDSub", IdSub);
            cmd.Parameters.AddWithValue("@Content", Content);
            cmd.Parameters.AddWithValue("@TestA", TestA);
            cmd.Parameters.AddWithValue("@TestB", TestB);
            cmd.Parameters.AddWithValue("@TestC", TestC);
            cmd.Parameters.AddWithValue("@TestD", TestD);
            cmd.Parameters.AddWithValue("@TestCrect", TestCorect);
            cmd.Parameters.AddWithValue("@TimeTest", TimeTest);
            return cmd.ExecuteNonQuery();
        }
    }
}
