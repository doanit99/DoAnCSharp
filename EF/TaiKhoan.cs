using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCao_QLNhanVien.EF
{
	internal class TaiKhoan
	{
		public int Id_TKhoan { get; }
		public string Ten_TKhoan { set; get; }
		public string Mat_Khau { set; get; }
		public int Loai_TKhoan { set; get; }

		public TaiKhoan() { }

		public TaiKhoan(string ten_TKhoan, string mat_Khau, int loai_TKhoan)
		{
			Ten_TKhoan = ten_TKhoan;
			Mat_Khau = mat_Khau;
			Loai_TKhoan = loai_TKhoan;
		}
	}
}
