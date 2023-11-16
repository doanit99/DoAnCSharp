using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCao_QLNhanVien.EF
{
	internal class ChucVu
	{
		public int ID_ChucVu { get; }
		public string Ma_ChucVu { set; get; }
		public string Ten_ChucVu { set; get; }
		public string Ghi_Chu { set; get; }

		public ChucVu() { }

		public ChucVu(string ma_ChucVu, string ten_ChucVu, string ghi_Chu)
		{
			
			Ma_ChucVu =ma_ChucVu;
			Ten_ChucVu= ten_ChucVu;
			Ghi_Chu= ghi_Chu;
		}
	}

	

	
}
