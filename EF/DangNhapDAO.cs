using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCao_QLNhanVien.EF
{
	internal class DangNhapDAO
	{
		SqlConnection conn = null;
		SqlCommand cmd = null;
		SqlDataAdapter apt = null;
		KetNoi kn = new KetNoi();

		public DangNhapDAO()
		{
			conn = kn.GetConnect();
			if (conn.State == ConnectionState.Closed)
			{
				conn.Open();
			}
		}

		

		//Đăng nhập
		public string DangNhap(string ten_TKhoan, string mat_Khau)
		{
				string sql = "SELECT Loai_TKhoan FROM tblTaiKhoan WHERE Ten_TKhoan = @ten_TKhoan AND Mat_Khau=@mat_Khau";
				cmd = new SqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("@ten_TKhoan", ten_TKhoan);
				cmd.Parameters.AddWithValue("@mat_Khau", mat_Khau);

				object kq = cmd.ExecuteScalar();//ExecuteScalar được sử dụng trả về một giá trị duy nhất

				if (kq != null)
				{
					return kq.ToString();
				}
			return null;
			
		}

		


	}
}
