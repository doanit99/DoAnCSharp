using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCao_QLNhanVien.EF
{
	internal class NhanVien
	{
	
		public int ID_NhanVien { get;}
		public string Ma_ChucVu { get; set; }
		public string Ma_PhongBan { get; set; }

		public byte[] Hinh { get; set; }
		public string Ho_Ten { get; set; }
		public string Ngay_Sinh { get; set; }
		public string Gioi_Tinh { get; set; }
		public string Que_Quan { get; set; }
		public string So_CMT { get; set; }
		public double Luong { get; set; }
		public string So_DienThoai { get; set; }
		public string Ngay_Tao { get; set; }

		public NhanVien() { }

		public NhanVien( string ma_ChucVu, string ma_PhongBan, byte[] hinh, string ho_Ten, string ngay_Sinh, string gioi_Tinh, string que_Quan, string so_CMT, double luong, string so_DienThoai, string ngay_Tao)
		{
			
			Ma_ChucVu = ma_ChucVu;
			Ma_PhongBan = ma_PhongBan;
			Hinh = hinh;
			Ho_Ten = ho_Ten;
			Ngay_Sinh = ngay_Sinh;
			Gioi_Tinh = gioi_Tinh;
			Que_Quan = que_Quan;
			So_CMT = so_CMT;
			Luong = luong;
			So_DienThoai = so_DienThoai;
			Ngay_Tao = ngay_Tao;
		}
	}
}
