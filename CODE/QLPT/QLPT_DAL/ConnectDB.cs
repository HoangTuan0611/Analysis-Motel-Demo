﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLPT_DAL
{
    public class ConnectDB
    {
        public static SqlConnection connect;


        public static void MoKetNoi()
        {

            if (ConnectDB.connect == null)
                ConnectDB.connect = new SqlConnection(@"Data Source=DESKTOP-19MG1RT\SQLEXPRESS01;Initial Catalog=DataQLPT;Integrated Security=SSPI;");

            if (ConnectDB.connect.State != ConnectionState.Open)
                ConnectDB.connect.Open();
        }

        public void DongKetNoi()
        {
            if (ConnectDB.connect != null)
            {

                if (ConnectDB.connect.State == ConnectionState.Open)
                    ConnectDB.connect.Close();
            }

        }
        //insert update delete 
        public void ExcuteQuery(string strSQL)
        {
            try
            {
                MoKetNoi();
                SqlCommand sqlcmd = new SqlCommand(strSQL, connect);
                sqlcmd.ExecuteNonQuery();
                DongKetNoi();
            }
            catch
            {

            }
        }

        public DataTable GetDataTable(string strSQL)//lệnh select.....
        {
            try
            {
                MoKetNoi();
                DataTable dt = new DataTable();
                SqlDataAdapter sqlda = new SqlDataAdapter(strSQL, connect);
                sqlda.Fill(dt);
               
                DongKetNoi();
                return dt;

            }
            catch
            {
                return null;
            }
        }
       
        public static string _ChuoiKetNoi = (@"Data Source=DESKTOP-SSFHDII\SQLEXPRESS;; Database=DataQLPT ;Integrated Security=SSPI");
        public static DataTable GetDanhSach(string strSQL)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(_ChuoiKetNoi);
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = strSQL;
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public DataTable GetDataTableDSS(string strSQL)//lệnh select.....
        {
            try
            {
                MoKetNoi();
                DataTable dt = new DataTable();
                SqlCommand sqlcmd = new SqlCommand(@"SELECT IDENTITY(INT,1,1) AS stt, masach, tensach, theloai, tacgia, tinhtrang INTO #TableTemp FROM DanhSachSach", connect);
                sqlcmd.ExecuteNonQuery();
                SqlDataAdapter sqlda = new SqlDataAdapter(strSQL, connect);
                sqlda.Fill(dt);
                DongKetNoi();
                return dt;

            }
            catch
            {
                return null;
            }
        }
        public DataTable GetDataTablePhieuMuon(string a, string strSQL)//lệnh select.....
        {
            try
            {
                MoKetNoi();
                DataTable dt = new DataTable();
                SqlCommand sqlcmd = new SqlCommand(@"SELECT IDENTITY(INT,1,1) AS stt, masach, tensach, theloai, tacgia INTO #TableTemp FROM PhieuMuonSach where iddocgia='" + a + "'", connect);
                sqlcmd.ExecuteNonQuery();
                SqlDataAdapter sqlda = new SqlDataAdapter(strSQL, connect);
                sqlda.Fill(dt);
                DongKetNoi();
                return dt;

            }
            catch
            {
                return null;
            }
        }
        public DataTable GetDataTableBaoCaoII(string a, string strSQL)//lệnh select.....
        {
            try
            {
                MoKetNoi();
                DataTable dt = new DataTable();
                SqlCommand sqlcmd = new SqlCommand(@"SELECT IDENTITY(INT,1,1) AS stt, masach, tensach, ngaymuon, songaytratre INTO #TableTemp FROM BaoCaoII where songaytratre > 0 and BaoCaoII.ngay =" + a + "", connect);
                sqlcmd.ExecuteNonQuery();
                SqlDataAdapter sqlda = new SqlDataAdapter(strSQL, connect);
                sqlda.Fill(dt);
                DongKetNoi();
                return dt;

            }
            catch
            {
                return null;
            }
        }
        public DataTable GetDataTableBaoCaoI(string a, string strSQL)//lệnh select.....
        {
            try
            {
                MoKetNoi();
                DataTable dt = new DataTable();
                SqlCommand sqlcmd = new SqlCommand(@"SELECT IDENTITY(INT,1,1) AS stt, theloai, soluotmuon, tile INTO #TableTemp FROM BaoCaoI where BaoCaoI.thang ='" + a + "'", connect);
                sqlcmd.ExecuteNonQuery();
                SqlDataAdapter sqlda = new SqlDataAdapter(strSQL, connect);
                sqlda.Fill(dt);
                DongKetNoi();
                return dt;

            }
            catch
            {
                return null;
            }
        }

        public string GetValue(string strSQL)//lệnh select..... lấy dữ liệu ở 1 cột trong bảng!
        {
            string temp = null;
            MoKetNoi();
            SqlCommand sqlcmd = new SqlCommand(strSQL, connect);
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            while (sqldr.Read())
                temp = sqldr[0].ToString();
            DongKetNoi();
            return temp;
        }

        public static DataTable GetReport(string strSQL)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(_ChuoiKetNoi);
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = conn;
                comm.CommandType = CommandType.Text;
                comm.CommandText = strSQL;
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
    }
}

