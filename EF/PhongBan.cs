using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCao_QLNhanVien.EF
{
	internal class PhongBan
	{
		public int ID_PhongBan { get; }
		public string Ma_PhongBan { set; get; }
		public string Ten_PhongBan { set; get; }
		public string Dia_Chi { set; get; }
		public string Ghi_chu { set; get; }

		public PhongBan() { }

		public PhongBan(string ma_PhongBan, string ten_PhongBan, string dia_Chi, string ghi_Chu)
		{

			Ma_PhongBan = ma_PhongBan;
			Ten_PhongBan = ten_PhongBan;
			Dia_Chi=dia_Chi;
			Ghi_chu = ghi_Chu;
		}
	}
}
