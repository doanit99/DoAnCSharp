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
	public partial class frmPhongBan : Form
	{
		PhongBanDAO pbDao = new PhongBanDAO();
		public frmPhongBan()
		{
			InitializeComponent();
		}

		private void frmPhongBan_Load(object sender, EventArgs e)
		{
			txtID.Enabled = false;
			btnXoa.Enabled = false;
			btnSua.Enabled = false;
			loadDSPhongBan();
		}

		private void loadDSPhongBan()
		{
			dgvPhongBan.DataSource = pbDao.getList();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtMaPB.Text.Length.Equals(0))
				{
					throw new Exception("Mã phòng ban không được để trống");
				}
				if (txtTenPB.Text.Length.Equals(0))
				{
					throw new Exception("Tên phòng ban không được để trống");
				}
				string ma_PhongBan = txtMaPB.Text;
				if (pbDao.KiemTraMaPhongBan(ma_PhongBan) > 0)
				{
					throw new Exception("Mã phòng ban đã tồn tại");
				}
				string ten_PhongBan = txtTenPB.Text;
				string dia_Chi = txtDiaChi.Text;
				string ghi_Chu = txtGhiChu.Text;

				PhongBan pb = new PhongBan(ma_PhongBan, ten_PhongBan, dia_Chi, ghi_Chu);

				pbDao.InsertOne(pb);
				loadDSPhongBan();
				MessageBox.Show("Thêm thành công", "Thông báo");
				txtID.Text = "";
				txtMaPB.Text = "";
				txtTenPB.Text = "";
				txtDiaChi.Text = "";
				txtGhiChu.Text = "";
				btnXoa.Enabled = false;
				btnSua.Enabled = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dgvPhongBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				int RowIndex = e.RowIndex;
				if (RowIndex == -1 || RowIndex >= dgvPhongBan.Rows.Count - 1)
				{
					throw new Exception("Chưa chọn phòng ban");
				}

				txtID.Text = dgvPhongBan.Rows[RowIndex].Cells["ID_PhongBan"].Value.ToString();
				txtMaPB.Text = dgvPhongBan.Rows[RowIndex].Cells["Ma_PhongBan"].Value.ToString();
				txtTenPB.Text = dgvPhongBan.Rows[RowIndex].Cells["Ten_PhongBan"].Value.ToString();
				txtDiaChi.Text = dgvPhongBan.Rows[RowIndex].Cells["Dia_Chi"].Value.ToString();
				txtGhiChu.Text = dgvPhongBan.Rows[RowIndex].Cells["Ghi_chu"].Value.ToString();

				btnXoa.Enabled = true;
				btnSua.Enabled = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			try
			{
				string iD_PhongBan = txtID.Text;
				string ma_PhongBan = txtMaPB.Text;
				string ten_PhongBan = txtTenPB.Text;
				string dia_Chi = txtDiaChi.Text;
				string ghi_Chu = txtGhiChu.Text;

				PhongBan pb = new PhongBan(ma_PhongBan, ten_PhongBan, dia_Chi, ghi_Chu);


				pbDao.UpdateOne(iD_PhongBan, pb);
				loadDSPhongBan();
				MessageBox.Show("Cập nhật thành công", "Thông báo");
				txtID.Text = "";
				txtMaPB.Text = "";
				txtTenPB.Text = "";
				txtDiaChi.Text = "";
				txtGhiChu.Text = "";
				btnXoa.Enabled = false;
				btnSua.Enabled = false;
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
				string iD_PhongBan = txtID.Text;

				DialogResult traloi = MessageBox.Show("Bạn có chắc muốn xóa không?", "thông báo", MessageBoxButtons.OKCancel);
				if (traloi == DialogResult.OK)
				{
					pbDao.DeleteOne(iD_PhongBan);
					loadDSPhongBan();
					MessageBox.Show("Xóa thành công", "Thông báo");
					txtID.Text = "";
					txtMaPB.Text = "";
					txtTenPB.Text = "";
					txtDiaChi.Text = "";
					txtGhiChu.Text = "";
					btnXoa.Enabled = false;
					btnSua.Enabled = false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			txtID.Text = "";
			txtMaPB.Text = "";
			txtTenPB.Text = "";
			txtDiaChi.Text = "";
			txtGhiChu.Text = "";
			btnXoa.Enabled = false;
			btnSua.Enabled = false;
			MessageBox.Show("Dữ liệu đã được reset", "Thông báo");
		}

		private void btnTroVe_Click(object sender, EventArgs e)
		{
			DialogResult traloi = MessageBox.Show("Bạn có chắc muốn thoát không?", "thông báo", MessageBoxButtons.OKCancel);
			if (traloi == DialogResult.OK)
			{
				this.Close();
			}
		}
	}
}
