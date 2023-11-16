using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCao_QLNhanVien.EF
{
	internal class PhongBanDAO
	{
		SqlConnection conn = null;
		SqlCommand cmd = null;
		SqlDataAdapter apt = null;
		KetNoi kn = new KetNoi();

		public PhongBanDAO()
		{
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
			sql = "SELECT * FROM tblPhongBan";
			cmd = new SqlCommand(sql, conn);
			apt = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			apt.Fill(dt);
			return dt;
		}

		//insert data
		public void InsertOne(PhongBan pb)
		{
			string sql = "INSERT INTO tblPhongBan(Ma_PhongBan,Ten_PhongBan,Dia_Chi,Ghi_chu)";
			sql += "VALUES(N'" + pb.Ma_PhongBan + "',N'" + pb.Ten_PhongBan + "',N'" + pb.Dia_Chi + "',N'" + pb.Ghi_chu + "')";
			cmd = new SqlCommand(sql, conn);
			cmd.ExecuteNonQuery();
		}

		//update data
		public void UpdateOne(string iD_PhongBan, PhongBan pb)
		{
			string sql = "UPDATE tblPhongBan SET Ma_PhongBan= N'" + pb.Ma_PhongBan + "',Ten_PhongBan=N'" + pb.Ten_PhongBan+ "',Dia_Chi=N'" + pb.Dia_Chi + "',Ghi_chu=N'" + pb.Ghi_chu + "'";
			sql += "WHERE ID_PhongBan='" + iD_PhongBan + "'";
			cmd = new SqlCommand(sql, conn);
			cmd.ExecuteNonQuery();
		}

		//delete data
		public void DeleteOne(string iD_PhongBan)
		{
			string sql = "DELETE FROM tblPhongBan WHERE ID_PhongBan='" + iD_PhongBan + "'";
			cmd = new SqlCommand(sql, conn);
			cmd.ExecuteNonQuery();
		}

		//check exists data
		public int KiemTraMaPhongBan(string ma_PhongBan)
		{

			int count;
			string sql = "SELECT COUNT(Ma_PhongBan) FROM tblPhongBan WHERE Ma_PhongBan = @ma_PhongBan";

			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@ma_PhongBan", ma_PhongBan);
				count = Convert.ToInt32(cmd.ExecuteScalar());
			}

			return count;
		}
	}
}
