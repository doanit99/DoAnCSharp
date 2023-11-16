using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCao_QLNhanVien.EF
{
	internal class NhanVienDAO
	{
		SqlConnection conn=null;
		SqlCommand cmd=null;
		SqlDataAdapter apt=null;
		KetNoi kn = new KetNoi();
		public NhanVienDAO()
		{
			conn = kn.GetConnect();
			if (conn.State == ConnectionState.Closed)
			{
				conn.Open();
			}
		}
		//Lấy ra dữ liệu
		public DataTable getList()
		{
			//Get all data
			//string sql = "SELECT tblNhanVien.ID_NhanVien, tblChuVu.Ten_ChucVu, tblPhongBan.Ten_PhongBan,tblNhanVien.Hinh, tblNhanVien.Ho_Ten, tblNhanVien.Ngay_Sinh, tblNhanVien.Gioi_Tinh, tblNhanVien.Que_Quan, tblNhanVien.So_CMT, tblNhanVien.Luong, tblNhanVien.So_DienThoai, tblNhanVien.Ngay_Tao";
			//sql += " FROM tblNhanVien";
			//sql += " INNER JOIN tblChuVu ON tblChuVu.Ma_ChucVu = tblNhanVien.Ma_ChucVu";
			//sql += " INNER JOIN tblPhongBan ON tblPhongBan.Ma_PhongBan = tblNhanVien.Ma_PhongBan";

			//Get data
			string sql = "SELECT tblNhanVien.ID_NhanVien, tblNhanVien.Ho_Ten, tblNhanVien.Gioi_Tinh, tblNhanVien.Ngay_Sinh, tblNhanVien.Hinh";
			sql += " FROM tblNhanVien";
			cmd = new SqlCommand(sql, conn);
			apt = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			apt.Fill(dt);
			return dt;
		}

		//Lấy ra 1 chuổi kí tự
		//Lấy ra tên chức vụ
		public string getChucVu(string id_NhanVien)
		{
			string sql = "SELECT tblChuVu.Ten_ChucVu";
			sql += " FROM tblNhanVien";
			sql += " INNER JOIN tblChuVu ON tblChuVu.Ma_ChucVu = tblNhanVien.Ma_ChucVu";
			sql += " WHERE tblNhanVien.ID_NhanVien = '" + id_NhanVien + "'";

			cmd = new SqlCommand(sql, conn);
			apt = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			apt.Fill(dt);

			if (dt.Rows.Count > 0)
			{
				string chucVu = dt.Rows[0]["Ten_ChucVu"].ToString();
				return chucVu;
			}
			else
			{
				return "Không tìm thấy chức vụ";
			}
		}
		//Lấy ra tên phòng ban
		public string getPhongBan(string id_NhanVien)
		{
			string sql = "SELECT tblPhongBan.Ten_PhongBan";
			sql += " FROM tblNhanVien";
			sql += " INNER JOIN tblPhongBan ON tblPhongBan.Ma_PhongBan = tblNhanVien.Ma_PhongBan";
			sql += " WHERE tblNhanVien.ID_NhanVien = '" + id_NhanVien + "'";

			cmd = new SqlCommand(sql, conn);
			apt = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			apt.Fill(dt);

			if (dt.Rows.Count > 0)
			{
				string pb = dt.Rows[0]["Ten_PhongBan"].ToString();
				return pb;
			}
			else
			{
				return "Không tìm thấy phòng ban";
			}
		}
		//Lấy ra quê quán
		public string getQueQuan(string id_NhanVien)
		{
			string sql = "SELECT tblNhanVien.Que_Quan";
			sql += " FROM tblNhanVien";
			sql += " WHERE tblNhanVien.ID_NhanVien = '" + id_NhanVien + "'";

			cmd = new SqlCommand(sql, conn);
			apt = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			apt.Fill(dt);

			if (dt.Rows.Count > 0)
			{
				string qq = dt.Rows[0]["Que_Quan"].ToString();
				return qq;
			}
			else
			{
				return "Chưa cập nhật";
			}
		}
		//Lấy ra số cmt
		public string getSoCMT(string id_NhanVien)
		{
			string sql = "SELECT tblNhanVien.So_CMT";
			sql += " FROM tblNhanVien";
			sql += " WHERE tblNhanVien.ID_NhanVien = '" + id_NhanVien + "'";

			cmd = new SqlCommand(sql, conn);
			apt = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			apt.Fill(dt);

			if (dt.Rows.Count > 0)
			{
				string cmt = dt.Rows[0]["So_CMT"].ToString();
				return cmt;
			}
			else
			{
				return "Chưa cập nhật";
			}
		}
		//Lấy ra Luong
		public string getLuong(string id_NhanVien)
		{
			string sql = "SELECT tblNhanVien.Luong";
			sql += " FROM tblNhanVien";
			sql += " WHERE tblNhanVien.ID_NhanVien = '" + id_NhanVien + "'";

			cmd = new SqlCommand(sql, conn);
			apt = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			apt.Fill(dt);

			if (dt.Rows.Count > 0)
			{
				string luong = dt.Rows[0]["Luong"].ToString();
				return luong;
			}
			else
			{
				return "Chưa cập nhật";
			}
		}
		//Lấy ra So_DienThoai
		public string getSDT(string id_NhanVien)
		{
			string sql = "SELECT tblNhanVien.So_DienThoai";
			sql += " FROM tblNhanVien";
			sql += " WHERE tblNhanVien.ID_NhanVien = '" + id_NhanVien + "'";

			cmd = new SqlCommand(sql, conn);
			apt = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			apt.Fill(dt);

			if (dt.Rows.Count > 0)
			{
				string sdt = dt.Rows[0]["So_DienThoai"].ToString();
				return sdt;
			}
			else
			{
				return "Chưa cập nhật";
			}
		}
		//Lấy ra Ngay_Tao
		public string getNgayTao(string id_NhanVien)
		{
			string sql = "SELECT tblNhanVien.Ngay_Tao";
			sql += " FROM tblNhanVien";
			sql += " WHERE tblNhanVien.ID_NhanVien = '" + id_NhanVien + "'";

			cmd = new SqlCommand(sql, conn);
			apt = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			apt.Fill(dt);

			if (dt.Rows.Count > 0)
			{
				string ngaytao = dt.Rows[0]["Ngay_Tao"].ToString();
				return ngaytao;
			}
			else
			{
				return "Chưa cập nhật";
			}
		}
		//thêm mẫu tin
		public void InsertOne(NhanVien nv)
		{
			string sql = "INSERT INTO tblNhanVien (Ma_ChucVu, Ma_PhongBan, Hinh, Ho_Ten, Ngay_Sinh, Gioi_Tinh, Que_Quan, So_CMT, Luong, So_DienThoai, Ngay_Tao)";
			sql += " VALUES (@Ma_ChucVu, @Ma_PhongBan, @Hinh, @Ho_Ten, @Ngay_Sinh, @Gioi_Tinh, @Que_Quan, @So_CMT, @Luong, @So_DienThoai, @Ngay_Tao)";

			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@Ma_ChucVu", nv.Ma_ChucVu);
				cmd.Parameters.AddWithValue("@Ma_PhongBan", nv.Ma_PhongBan);
				cmd.Parameters.AddWithValue("@Hinh", nv.Hinh); // Mảng byte chứa hình ảnh
				cmd.Parameters.AddWithValue("@Ho_Ten", nv.Ho_Ten);
				cmd.Parameters.AddWithValue("@Ngay_Sinh", nv.Ngay_Sinh);
				cmd.Parameters.AddWithValue("@Gioi_Tinh", nv.Gioi_Tinh);
				cmd.Parameters.AddWithValue("@Que_Quan", nv.Que_Quan);
				cmd.Parameters.AddWithValue("@So_CMT", nv.So_CMT);
				cmd.Parameters.AddWithValue("@Luong", nv.Luong);
				cmd.Parameters.AddWithValue("@So_DienThoai", nv.So_DienThoai);
				cmd.Parameters.AddWithValue("@Ngay_Tao", nv.Ngay_Tao);

				cmd.ExecuteNonQuery();
			}
		}
		//update data
		public void UpdateOne(int iD_NhanVien, NhanVien nv)
		{
			string sql = "UPDATE tblNhanVien SET Ma_ChucVu=@Ma_ChucVu, Ma_PhongBan=@Ma_PhongBan, Hinh=@Hinh, Ho_Ten=@Ho_Ten, Ngay_Sinh=@Ngay_Sinh, Gioi_Tinh=@Gioi_Tinh, Que_Quan=@Que_Quan, So_CMT=@So_CMT, Luong=@Luong, So_DienThoai=@So_DienThoai" ;
			sql += " WHERE ID_NhanVien=@iD_NhanVien";
			cmd = new SqlCommand(sql, conn);
			cmd.Parameters.AddWithValue("@iD_NhanVien", iD_NhanVien);
			cmd.Parameters.AddWithValue("@Ma_ChucVu", nv.Ma_ChucVu);
			cmd.Parameters.AddWithValue("@Ma_PhongBan", nv.Ma_PhongBan);
			cmd.Parameters.AddWithValue("@Hinh", nv.Hinh); // Mảng byte chứa hình ảnh
			cmd.Parameters.AddWithValue("@Ho_Ten", nv.Ho_Ten);
			cmd.Parameters.AddWithValue("@Ngay_Sinh", nv.Ngay_Sinh);
			cmd.Parameters.AddWithValue("@Gioi_Tinh", nv.Gioi_Tinh);
			cmd.Parameters.AddWithValue("@Que_Quan", nv.Que_Quan);
			cmd.Parameters.AddWithValue("@So_CMT", nv.So_CMT);
			cmd.Parameters.AddWithValue("@Luong", nv.Luong);
			cmd.Parameters.AddWithValue("@So_DienThoai", nv.So_DienThoai);
			cmd.ExecuteNonQuery();
		}

		//delete data
		public void DeleteOne(int iD_NhanVien)
		{
			string sql = "DELETE FROM tblNhanVien WHERE ID_NhanVien='" + iD_NhanVien + "'";
			cmd = new SqlCommand(sql, conn);
			cmd.ExecuteNonQuery();
		}

		//search data
		public DataTable SearchOne(string Ho_Ten)
		{
			string sql = "SELECT tblNhanVien.ID_NhanVien, tblNhanVien.Ho_Ten, tblNhanVien.Gioi_Tinh, tblNhanVien.Ngay_Sinh, tblNhanVien.Hinh";
			sql += " FROM tblNhanVien WHERE Ho_Ten LIKE @Ho_Ten OR Gioi_Tinh LIKE @Ho_Ten";
			cmd = new SqlCommand(sql, conn);
			cmd.Parameters.AddWithValue("@Ho_Ten", "%" + Ho_Ten + "%");
			apt = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			apt.Fill(dt);
			return dt;
		}

		
	}
}
