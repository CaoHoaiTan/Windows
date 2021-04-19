using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;

namespace DataBusinessLayer
{
	public class DBBusiness
	{
		DBLayer db;
		public DBBusiness()
		{
			db = new DBLayer();
		}
		public DataSet getTho()
		{
			return db.ExecuteQueryDataSet("SELECT * FROM Tho", CommandType.Text, null);
		}
		public DataSet getNhomTho()
		{
			return db.ExecuteQueryDataSet("SELECT * FROM NhomTho", CommandType.Text, null);

		}
		public DataSet getXe()
        {
			return db.ExecuteQueryDataSet("SELECT * FROM Xe", CommandType.Text, null);
        }
		public DataSet getKhach()
        {
			return db.ExecuteQueryDataSet("SELECT * FROM Khach", CommandType.Text, null);
        }
		public bool insertXe(ref string err,string MaXe,string HangXe,string ChuXe)
        {
			return db.MyExecuteNonQuery("spInsertXe", CommandType.StoredProcedure, ref err
				, new SqlParameter("@MaXe", MaXe)
				, new SqlParameter("@HangXe", HangXe)
				, new SqlParameter("@ChuXe", ChuXe));
        }
		public bool insertTho(ref string err, string MaTho,
			string TenTho, string SDT, string DiaChi, string MaNhomTho)
		{
			return db.MyExecuteNonQuery("spInsertTho", CommandType.StoredProcedure, ref err
				, new SqlParameter("@MaTho", MaTho)
				, new SqlParameter("@TenTho", TenTho)
				, new SqlParameter("@SDT", SDT)
				, new SqlParameter("@DiaChi", DiaChi)
				, new SqlParameter("@MaNhomTho", MaNhomTho));
		}
		public bool deleteTho(ref string err, string MaTho)
		{
			return db.MyExecuteNonQuery("spDeleteTho", CommandType.StoredProcedure, ref err
				, new SqlParameter("@MaTho", MaTho));
		}
		public bool deleteXe(ref string err,string MaXe)
        {
			return db.MyExecuteNonQuery("spDeleteXe", CommandType.StoredProcedure, ref err
				, new SqlParameter("@MaXe", MaXe));
        }
		public bool updateTho(ref string err, string MaTho,
			string TenTho, string SDT, string DiaChi, string MaNhomTho)
		{
			return db.MyExecuteNonQuery("spUpdateTho", CommandType.StoredProcedure, ref err
				, new SqlParameter("@MaTho", MaTho)
				, new SqlParameter("@TenTho", TenTho)
				, new SqlParameter("@SDT", SDT)
				, new SqlParameter("@DiaChi", DiaChi)
				, new SqlParameter("@MaNhomTho", MaNhomTho));
		}
		public bool updateXe(ref string err,string MaXe,string HangXe,string ChuXe)
        {
			return db.MyExecuteNonQuery("spUpdateXe", CommandType.StoredProcedure, ref err
				, new SqlParameter("@MaXe", MaXe)
				, new SqlParameter("HangXe", HangXe)
				, new SqlParameter("@ChuXe", ChuXe));
        }
		public bool insertNhomTho(ref string err, string MaNhomTho, string TenNhom,
			string TruongNhom)
		{
			return db.MyExecuteNonQuery("spInsertNhomTho", CommandType.StoredProcedure, ref err
				, new SqlParameter("@MaNhomTho", MaNhomTho)
				, new SqlParameter("@TenNhomTho", TenNhom)
				, new SqlParameter("@NhomTruong", TruongNhom));
		}
		public bool deleteNhomTho(ref string err, string MaNhomTho)
		{
			return db.MyExecuteNonQuery("spDeleteNhomTho", CommandType.StoredProcedure, ref err
				, new SqlParameter("@MaNhomTho", MaNhomTho));
		}
		public bool updateNhomTho(ref string err, string MaNhomTho, string TenNhom,
			string TruongNhom)
		{
			return db.MyExecuteNonQuery("spUpdateNhomTho", CommandType.StoredProcedure, ref err
				, new SqlParameter("@MaNhomTho", MaNhomTho)
				, new SqlParameter("@TenNhomTho", TenNhom)
				, new SqlParameter("@NhomTruong", TruongNhom));
		}
	}
}
