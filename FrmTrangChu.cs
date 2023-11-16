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

	public partial class FrmTrangChu : Form
	{
		private frmChucVu chucvuForm = null;
		private frmDuAn duanForm = null;
		private frmNhanVien nhanvienForm = null;
		private frmTaiKhoan taikhoanForm = null;
		private frmPhongBan phongbanForm = null;
		public FrmTrangChu()
		{
			InitializeComponent();
			
		}

		private void toolStripMenuThoat_Click(object sender, EventArgs e)
		{
			DialogResult traloi = MessageBox.Show("Bạn có chắc muốn thoát không?", "thông báo", MessageBoxButtons.OKCancel);
			if (traloi == DialogResult.OK)
			{
				Application.Exit();
			}
		}

		private void toolStripMenuChucVu_Click(object sender, EventArgs e)
		{
			if (chucvuForm == null)
			{
				chucvuForm = new frmChucVu();
				chucvuForm.FormClosed += (s, args) => chucvuForm = null;
				chucvuForm.Show();
			}
			else
			{
			
				chucvuForm.Focus();
			}
		}

		private void toolStripMenuPhongBan_Click(object sender, EventArgs e)
		{
			if (phongbanForm == null)
			{
				phongbanForm = new frmPhongBan();
				phongbanForm.FormClosed += (s, args) => phongbanForm = null;
				phongbanForm.Show();
			}
			else
			{

				phongbanForm.Focus();
			}
			
		}

		private void toolStripMenuDuAn_Click(object sender, EventArgs e)
		{
			if (duanForm == null)
			{
				duanForm = new frmDuAn();
				duanForm.FormClosed += (s, args) => duanForm = null;
				duanForm.Show();
			}
			else
			{

				duanForm.Focus();
			}
			
		}

		private void toolStripMenuQLTK_Click(object sender, EventArgs e)
		{
			if (taikhoanForm == null)
			{
				taikhoanForm = new frmTaiKhoan();
				taikhoanForm.FormClosed += (s, args) => taikhoanForm = null;
				taikhoanForm.Show();
			}
			else
			{

				taikhoanForm.Focus();
			}
			
		}

		private void FrmTrangChu_Load(object sender, EventArgs e)
		{
			
			
		}

		private void toolStripMenuHSNV_Click(object sender, EventArgs e)
		{
			if (nhanvienForm == null)
			{
				nhanvienForm = new frmNhanVien();
				nhanvienForm.FormClosed += (s, args) => nhanvienForm = null;
				nhanvienForm.Show();
			}
			else
			{

				nhanvienForm.Focus();
			}
			
		}

		
	}
}
