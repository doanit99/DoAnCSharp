using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCao_QLNhanVien.EF
{
	internal class DuAn
	{
		public int Id_Da { get; }
		public string Ma_Da { get; set; }
		public string Ten_Da {  get; set; }
		public int SoNV_Da {  get; set; }
		public string Mota_Da {  get; set; }

		public DuAn() { }

		public DuAn(string ma_Da, string ten_Da, int soNV_Da, string mota_Da)
		{
			Ma_Da = ma_Da;
			Ten_Da = ten_Da;
			SoNV_Da = soNV_Da;
			Mota_Da = mota_Da;
		}
	}
}
