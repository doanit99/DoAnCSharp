using BaoCao_QLNhanVien.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCao_QLNhanVien
{
	public partial class frmDangNhap : Form
	{
		DangNhapDAO dnDao=new DangNhapDAO();
		public frmDangNhap()
		{
			InitializeComponent();
		}

		private void frmDangNhap_Load(object sender, EventArgs e)
		{

		}

		

		private void btnDangNhap_Click(object sender, EventArgs e)
		{
			try
			{
				string ten_TKhoan = txtTenTK.Text;
				string mat_Khau = txtMatKhau.Text;
				if (dnDao.DangNhap(ten_TKhoan, mat_Khau) == null)
				{
					MessageBox.Show("Đăng nhập thất bại");
					txtTenTK.Text = "";
					txtMatKhau.Text="";
					
					
				}
				else if (dnDao.DangNhap(ten_TKhoan, mat_Khau) == "0")
				{

					MessageBox.Show("Đăng nhập thành công");
					FrmTrangChu trangchu = new FrmTrangChu();
					trangchu.Show();
					this.Hide();
					
					

				}


			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void picBoxClose_Click(object sender, EventArgs e)
		{
			DialogResult traloi = MessageBox.Show("Bạn có chắc muốn thoát không?", "thông báo", MessageBoxButtons.OKCancel);
			if (traloi == DialogResult.OK)
			{
				Application.Exit();
			}
		}
	}
}
