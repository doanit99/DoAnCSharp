using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCao_QLNhanVien.EF
{
	internal class TaiKhoanDAO
	{
		SqlConnection conn = null;
		SqlCommand cmd = null;
		SqlDataAdapter apt = null;
		KetNoi kn = new KetNoi();

		public TaiKhoanDAO()
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
			sql = "SELECT Ten_TKhoan, Mat_Khau, Loai_TKhoan FROM tblTaiKhoan";
			cmd = new SqlCommand(sql, conn);
			apt = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			apt.Fill(dt);
			return dt;
		}

		//insert data
		public void InsertOne(TaiKhoan tk)
		{
			string sql = "INSERT INTO tblTaiKhoan(Ten_TKhoan,Mat_Khau,Loai_TKhoan)";
			sql += "VALUES(N'" + tk.Ten_TKhoan + "',N'" + tk.Mat_Khau + "',N'" + tk.Loai_TKhoan + "')";
			cmd = new SqlCommand(sql, conn);
			cmd.ExecuteNonQuery();
		}

		//
		public int TenTaiKhoanDaTonTai(string ten_TKhoan)
		{

			int count;
			string sql = "SELECT COUNT(Ten_TKhoan) FROM tblTaiKhoan WHERE Ten_TKhoan = @ten_TKhoan";

			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				cmd.Parameters.AddWithValue("@ten_TKhoan", ten_TKhoan);
				count = Convert.ToInt32(cmd.ExecuteScalar());
			}

			return count;
		}

		//delete data
		public void DeleteOne(string ten_TKhoan)
		{
			string sql = "DELETE FROM tblTaiKhoan WHERE Ten_TKhoan='" + ten_TKhoan + "'";
			cmd = new SqlCommand(sql, conn);
			cmd.ExecuteNonQuery();
		}

	
	}
}
