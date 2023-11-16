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
	public partial class frmTaiKhoan : Form
	{
		TaiKhoanDAO tkDao = new TaiKhoanDAO();
		public frmTaiKhoan()
		{
			InitializeComponent();
		}

		private void frmTaiKhoan_Load(object sender, EventArgs e)
		{
			
			btnXoa.Enabled = false;
			
			loadDSTaiKhoan();
		}

		private void loadDSTaiKhoan()
		{
			dgvTaiKhoan.DataSource = tkDao.getList();
		}


		//
		//public string HashPassword(string password)
		//{
		//	string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
		//	return hashedPassword;
		//}


		private void btnThem_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtTK.Text.Length.Equals(0))
				{
					throw new Exception("Tên tài khoản không được để trống");
				}
				if (txtMK.Text.Length.Equals(0))
				{
					throw new Exception("Mật khẩu không được để trống");
				}
				string ten_TKhoan = txtTK.Text;
				string mat_Khau = txtMK.Text;
				if (tkDao.TenTaiKhoanDaTonTai(ten_TKhoan) > 0)
				{
					throw new Exception("Tên tài khoản đã tồn tại");
				}
				int loai_TKhoan;
				if (cbLoaiTK.SelectedItem != null)
				{
					loai_TKhoan = Convert.ToInt16(cbLoaiTK.SelectedIndex);
				}
				else
				{
					throw new Exception("Lỗi loại tài khoản");
				}
				

				TaiKhoan tk = new TaiKhoan(ten_TKhoan, mat_Khau, loai_TKhoan);

				tkDao.InsertOne(tk);
				loadDSTaiKhoan();
				MessageBox.Show("Thêm thành công", "Thông báo");

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				int RowIndex = e.RowIndex;
				if (RowIndex == -1 || RowIndex >= dgvTaiKhoan.Rows.Count - 1)
				{
					throw new Exception("Chưa chọn tài khoản");
				}

				txtTK.Text = dgvTaiKhoan.Rows[RowIndex].Cells["Ten_TKhoan"].Value.ToString();
				txtMK.Text = dgvTaiKhoan.Rows[RowIndex].Cells["Mat_Khau"].Value.ToString();
				cbLoaiTK.Text = dgvTaiKhoan.Rows[RowIndex].Cells["Loai_TKhoan"].Value.ToString();

				txtTK.Enabled = false;
				txtMK.Enabled = false;
				cbLoaiTK.Enabled=false;
				btnXoa.Enabled = true;
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			try
			{
				string ten_TKhoan = txtTK.Text;
				tkDao.DeleteOne(ten_TKhoan);
				loadDSTaiKhoan();
				MessageBox.Show("Xóa thành công", "Thông báo");

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			
			txtTK.Text = "";
			txtMK.Text = "";
			cbLoaiTK.Text = "";
			txtTK.Enabled = true;
			txtMK.Enabled = true;
			cbLoaiTK.Enabled = true;

			MessageBox.Show("Dữ liệu đã được reset", "Thông báo");
		}

		private void btnTroVe_Click(object sender, EventArgs e)
		{
			DialogResult traloi = MessageBox.Show("bạn có chắc muốn thoát không?", "thông báo", MessageBoxButtons.OKCancel);
			if (traloi == DialogResult.OK)
			{
				this.Close();
			}
		}
	}
}
