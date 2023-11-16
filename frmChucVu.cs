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
	public partial class frmChucVu : Form
	{
		ChucVuDAO cvDao = new ChucVuDAO();
		
		public frmChucVu()
		{
			InitializeComponent();
		}

		private void frmChucVu_Load(object sender, EventArgs e)
		{
			txtID.Enabled = false;
			btnXoa.Enabled = false;
			btnSua.Enabled = false;
			loadDSChucVu();
		}

		private void loadDSChucVu()
		{
			dgvChucVu.DataSource = cvDao.getList();
		}

		//
		private void btnThem_Click(object sender, EventArgs e)
		{
			
			try
			{
				if (txtMaCV.Text.Length.Equals(0))
				{
					throw new Exception("Mã chức vụ không được để trống");
				}
				if (txtTenCV.Text.Length.Equals(0))
				{
					throw new Exception("Tên chức vụ không được để trống");
				}
				

				string ma_ChucVu = txtMaCV.Text;

				if (cvDao.KiemTraMaChucVu(ma_ChucVu) > 0)
				{
					throw new Exception("Mã chức vụ đã tồn tại");
				}
				string ten_ChucVu = txtTenCV.Text;
				string ghi_Chu = txtGhiChu.Text;
				
				ChucVu cv = new ChucVu(ma_ChucVu, ten_ChucVu, ghi_Chu);

				cvDao.InsertOne(cv);
				loadDSChucVu();
				MessageBox.Show("Thêm thành công", "Thông báo");

				txtID.Text = "";
				txtMaCV.Text = "";
				txtTenCV.Text = "";
				txtGhiChu.Text = "";
				btnSua.Enabled = false;
				btnXoa.Enabled = false;

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		//
		private void dgvChucVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

			
		}

		//
		private void btnSua_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtMaCV.Text.Length.Equals(0))
				{
					throw new Exception("Mã chức vụ không được để trống");
				}
				if (txtTenCV.Text.Length.Equals(0))
				{
					throw new Exception("Tên chức vụ không được để trống");
				}

				string ma_ChucVu = txtMaCV.Text;

				
				string iD_ChucVu = txtID.Text;
				string ten_ChucVu = txtTenCV.Text;
				string ghi_Chu = txtGhiChu.Text;

				ChucVu cv = new ChucVu(ma_ChucVu, ten_ChucVu, ghi_Chu);
				

				cvDao.UpdateOne(iD_ChucVu,cv);
				loadDSChucVu();
				MessageBox.Show("Cập nhật thành công", "Thông báo");

				txtID.Text = "";
				txtMaCV.Text = "";
				txtTenCV.Text = "";
				txtGhiChu.Text = "";
				btnSua.Enabled = false;
				btnXoa.Enabled = false;

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//
		private void btnXoa_Click(object sender, EventArgs e)
		{
			try
			{
				string iD_ChucVu=txtID.Text;
				cvDao.DeleteOne(iD_ChucVu);
				loadDSChucVu();
				MessageBox.Show("Xóa thành công", "Thông báo");

				txtID.Text = "";
				txtMaCV.Text = "";
				txtTenCV.Text = "";
				txtGhiChu.Text = "";
				btnSua.Enabled = false;
				btnXoa.Enabled = false;

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//
		private void btnReset_Click(object sender, EventArgs e)
		{
			txtTimKiem.Text = "";
			txtID.Text = "";
			txtMaCV.Text = "";
			txtTenCV.Text = "";
			txtGhiChu.Text = "";
			btnSua.Enabled= false;
			btnXoa.Enabled= false;

			MessageBox.Show("Dữ liệu đã được reset", "Thông báo");
		}

		//
		private void txtTimKiem_TextChanged(object sender, EventArgs e)
		{
			
			try
			{
				string Ten_ChucVu = txtTimKiem.Text;
				if (string.IsNullOrEmpty(Ten_ChucVu)) 
				{
					
					loadDSChucVu();
				}
				else
				{
					
					dgvChucVu.DataSource = cvDao.SearchOne(Ten_ChucVu);
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//
		private void btnTroVe_Click(object sender, EventArgs e)
		{
			DialogResult traloi = MessageBox.Show("bạn có chắc muốn thoát không?", "thông báo", MessageBoxButtons.OKCancel);
			if (traloi == DialogResult.OK)
			{
				this.Close();
			}
		}

		//
		private void dgvChucVu_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				int RowIndex = e.RowIndex;
				if (RowIndex == -1 || RowIndex >= dgvChucVu.Rows.Count - 1)
				{
					throw new Exception("Chưa chọn nhân viên");
				}

				txtID.Text = dgvChucVu.Rows[RowIndex].Cells["ID_ChucVu"].Value.ToString();
				txtMaCV.Text = dgvChucVu.Rows[RowIndex].Cells["Ma_ChucVu"].Value.ToString();
				txtTenCV.Text = dgvChucVu.Rows[RowIndex].Cells["Ten_ChucVu"].Value.ToString();
				txtGhiChu.Text = dgvChucVu.Rows[RowIndex].Cells["Ghi_Chu"].Value.ToString();

				btnXoa.Enabled = true;
				btnSua.Enabled = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}
	}
}
