using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCao_QLNhanVien.EF
{
	internal class ChucVuDAO
	{
		SqlConnection conn = null;
		SqlCommand cmd = null;
		SqlDataAdapter apt = null;
		KetNoi kn = new KetNoi();

		public ChucVuDAO() {
			conn = kn.GetConnect();
			if (conn.State == ConnectionState.Closed)
			{
				conn.Open();
			}
		}

		//get all data
		public DataTable getList()
		{
			string sql = null;
			sql = "SELECT * FROM tblChuVu";
			cmd = new SqlCommand(sql, conn);
			apt = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			apt.Fill(dt);
			return dt;
		}

		//insert data
		public void InsertOne(ChucVu cv)
		{
			string sql = "INSERT INTO tblChuVu(Ma_ChucVu,Ten_ChucVu,Ghi_Chu)";
			sql += "VALUES(N'" + cv.Ma_ChucVu + "',N'" + cv.Ten_ChucVu + "',N'" + cv.Ghi_Chu + "')";
			cmd = new SqlCommand(sql, conn);
			cmd.ExecuteNonQuery();
		}

		//update data
		public void UpdateOne(string iD_ChucVu,ChucVu cv)
		{
			string sql = "UPDATE tblChuVu SET Ma_ChucVu= N'" + cv.Ma_ChucVu + "',Ten_ChucVu=N'" + cv.Ten_ChucVu + "',Ghi_Chu=N'" + cv.Ghi_Chu + "'";
			sql += "WHERE ID_ChucVu='" + iD_ChucVu + "'";
			cmd = new SqlCommand(sql, conn);
			cmd.ExecuteNonQuery();
		}

		//delete data
		public void DeleteOne(string iD_ChucVu)
		{
			string sql = "DELETE FROM tblChuVu WHERE ID_ChucVu='" + iD_ChucVu + "'";
			cmd = new SqlCommand(sql, conn);
			cmd.ExecuteNonQuery();
		}

		//search data
		public DataTable SearchOne(string Ten_ChucVu)
		{
			string sql = "SELECT * FROM tblChuVu WHERE Ten_ChucVu = @TenChucVu OR Ma_ChucVu= @TenChucVu";
			cmd = new SqlCommand(sql, conn);
			cmd.Parameters.AddWithValue("@TenChucVu", Ten_ChucVu);
			apt = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			apt.Fill(dt);
			return dt;
		}

		//check exists data
		public int KiemTraMaChucVu(string ma_ChucVu)
		{

			int count;
			string sql = "SELECT COUNT(Ma_ChucVu) FROM tblChuVu WHERE Ma_ChucVu = @ma_ChucVu";

			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@ma_ChucVu", ma_ChucVu);
				count = Convert.ToInt32(cmd.ExecuteScalar());
			}

			return count;
		}
	}
}
