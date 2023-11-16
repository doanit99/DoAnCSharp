using BaoCao_QLNhanVien.EF;
using OfficeOpenXml;
using OfficeOpenXml.Drawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCao_QLNhanVien
{

	public partial class frmNhanVien : Form
	{
		
		NhanVienDAO nvDao=new NhanVienDAO();
		ChucVuDAO cvDao=new ChucVuDAO();
		PhongBanDAO pbDao=new PhongBanDAO();
		string instertupdate="";
		public frmNhanVien()
		{
			// Thiết lập LicenseContext
			InitializeComponent();
		}

		private void frmNhanVien_Load(object sender, EventArgs e)
		{
			txtIDNV.Enabled = false;
			cbMaCV.Enabled = false;
			cbPhongBan.Enabled = false;
			txtHoTen.Enabled = false;
			dTPNgaySinh.Enabled = false;
			cbGioiTinh.Enabled = false;
			txtQueQuan.Enabled = false;
			txtSoCMT.Enabled = false;
			txtLuong.Enabled = false;
			txtSoCMT.Enabled = false;
			txtSDT.Enabled = false;
			maskedTxtNgayTao.Enabled = false;
			string Ngay_Tao = DateTime.Now.ToString();
			maskedTxtNgayTao.Text = Ngay_Tao;

			pbHinh.Image = Properties.Resources.HinhDaiDien;
			btnChonHinh.Enabled=false;
			btnLuu.Enabled = false;
			btnXoa.Enabled = false;
			loadDSNhanVien();
			loadDSChucVu();
			loadDSPhongBan();

			// Tạo một DataGridViewImageColumn
			if (dgvDanhSachNV.Columns[4] is DataGridViewImageColumn)
			{
				DataGridViewImageColumn pic = (DataGridViewImageColumn)dgvDanhSachNV.Columns[4];
				pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
			}

		}
		private void loadDSNhanVien()
		{
			dgvDanhSachNV.DataSource=nvDao.getList();
			
		}

		private void loadDSChucVu()
		{
			cbMaCV.DataSource = cvDao.getList();
			cbMaCV.DisplayMember = "Ten_ChucVu";
			cbMaCV.ValueMember = "Ma_ChucVu";
		}

		private void loadDSPhongBan()
		{
			cbPhongBan.DataSource = pbDao.getList();
			cbPhongBan.DisplayMember = "Ten_PhongBan";
			cbPhongBan.ValueMember = "Ma_PhongBan";

			
		}
		private byte[] ImageToByteArray(PictureBox pictureBox)
		{
			MemoryStream ms = new MemoryStream();
			pictureBox.Image.Save(ms, pictureBox.Image.RawFormat);
			return ms.ToArray();
		}
		private void btnLuu_Click(object sender, EventArgs e)
		{
			try {
				if (cbMaCV.Text.Length.Equals(0))
				{
					throw new Exception("Tên phòng ban không được để trống");
				}
				if (cbMaCV.Text.Length.Equals(0))
				{
					throw new Exception("Tên chức vụ không được để trống");
				}
				if (txtHoTen.Text.Length.Equals(0))
				{
					throw new Exception("Họ tên không được để trống");
				}
				if (dTPNgaySinh.Text.Length.Equals(0))
				{
					throw new Exception("Ngày sinh không được để trống");
				}
				if (cbGioiTinh.Text.Length.Equals(0))
				{
					throw new Exception("Giới tính không được để trống");
				}
				if (txtQueQuan.Text.Length.Equals(0))
				{
					throw new Exception("Quê quán không được để trống");
				}


				//string ma_ChucVu = cbMaCV.SelectedValue.ToString();
				string ma_ChucVu = string.Empty;
				if (cbMaCV.SelectedItem != null)
				{
					ma_ChucVu = cbMaCV.SelectedValue.ToString();
				}
				else
				{
					throw new Exception("Lỗi mã chức vụ");
				}
				//string ma_PhongBan = cbPhongBan.SelectedValue.ToString();
				string ma_PhongBan = string.Empty;
				if (cbPhongBan.SelectedItem != null)
				{
					ma_PhongBan = cbPhongBan.SelectedValue.ToString();
				}
				else
				{
					throw new Exception("Lỗi mã phòng ban");
				}

				byte[] hinh = ImageToByteArray(pbHinh);
				string ho_Ten= txtHoTen.Text;
				string ngay_Sinh = dTPNgaySinh.Text;
				string gioi_Tinh = cbGioiTinh.Text;
				string que_Quan = txtQueQuan.Text;
				string so_CMT = txtSoCMT.Text;
				double luong=0;
				if (txtLuong.Text != "")
				{
					luong = Convert.ToDouble(txtLuong.Text);
				}
				else
				{
					throw new Exception("Lỗi lương");
				}
				string so_DienThoai = txtSDT.Text;
				string Ngay_Tao = DateTime.Now.ToString();
				maskedTxtNgayTao.Text = Ngay_Tao;

				NhanVien nv = new NhanVien(ma_ChucVu, ma_PhongBan, hinh, ho_Ten, ngay_Sinh, gioi_Tinh,que_Quan, so_CMT, luong, so_DienThoai, Ngay_Tao);	
				switch (instertupdate)
				{
					case "inster":
						{
							nvDao.InsertOne(nv);
							loadDSNhanVien();
							MessageBox.Show("Thêm thành công", "Thông báo");

							
							cbMaCV.Text = "";
							cbPhongBan.Text = "";
							txtHoTen.Text = "";
							dTPNgaySinh.Text = "";
							cbGioiTinh.Text = "";
							txtQueQuan.Text = "";
							txtSoCMT.Text = "";
							txtLuong.Text = "";
							txtSDT.Text = "";
							maskedTxtNgayTao.Text = "";
							pbHinh.Image = Properties.Resources.HinhDaiDien;

							cbMaCV.Enabled = false;
							cbPhongBan.Enabled = false;
							txtHoTen.Enabled = false;
							dTPNgaySinh.Enabled = false;
							cbGioiTinh.Enabled = false;
							txtQueQuan.Enabled = false;
							txtSoCMT.Enabled = false;
							txtSDT.Enabled = false;
							txtLuong.Enabled = false;

							btnChonHinh.Enabled = false;
							btnXoa.Enabled = false;
							btnSua.Enabled = false;
							btnThem.Enabled = true;
							break;
						}
					case "update":
						{
							int id_NhanVien = Convert.ToInt16(txtIDNV.Text);
							nvDao.UpdateOne(id_NhanVien,nv);
							loadDSNhanVien();
							MessageBox.Show("Cập nhật thành công", "Thông báo");

							
							cbMaCV.Text = "";
							cbPhongBan.Text = "";
							txtHoTen.Text = "";
							dTPNgaySinh.Text = "";
							cbGioiTinh.Text = "";
							txtQueQuan.Text = "";
							txtSoCMT.Text = "";
							txtLuong.Text = "";
							txtSDT.Text = "";
							maskedTxtNgayTao.Text = "";
							pbHinh.Image = Properties.Resources.HinhDaiDien;

							cbMaCV.Enabled = false;
							cbPhongBan.Enabled = false;
							txtHoTen.Enabled = false;
							dTPNgaySinh.Enabled = false;
							cbGioiTinh.Enabled = false;
							txtQueQuan.Enabled = false;
							txtSoCMT.Enabled = false;
							txtSDT.Enabled = false;
							txtLuong.Enabled = false;

							btnChonHinh.Enabled = false;
							btnXoa.Enabled = false;
							btnSua.Enabled = false;
							btnThem.Enabled = true;
							break;
						}
					
				}
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			instertupdate = "inster";
			
			cbMaCV.Enabled = true;
			cbPhongBan.Enabled = true;
			txtHoTen.Enabled = true;
			dTPNgaySinh.Enabled = true;
			cbGioiTinh.Enabled = true;
			txtQueQuan.Enabled = true;
			txtSoCMT.Enabled = true;
			txtLuong.Enabled = true;
			txtSDT.Enabled = true;

			//txtIDNV.Text = Convert.ToInt16("").ToString();
			cbMaCV.Text = "";
			cbPhongBan.Text = "";
			txtHoTen.Text = "";
			dTPNgaySinh.Text = "";
			cbGioiTinh.Text = "";
			txtQueQuan.Text = "";
			txtSoCMT.Text = "";
			txtLuong.Text = "";
			txtSDT.Text = "";
			maskedTxtNgayTao.Text = "";

			btnChonHinh.Enabled = true;
			btnLuu.Enabled = true;

		}

		private void dgvDanhSachNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				int RowIndex = e.RowIndex;
				if (RowIndex == -1 || RowIndex >= dgvDanhSachNV.Rows.Count - 1)
				{
					throw new Exception("Chưa chọn nhân viên");
				}
				
				txtIDNV.Text = dgvDanhSachNV.Rows[RowIndex].Cells["ID_NhanVien"].Value.ToString();
				string Idnv= dgvDanhSachNV.Rows[RowIndex].Cells["ID_NhanVien"].Value.ToString();
				if (txtIDNV.Text.Length > 0)
				{
					string tam= nvDao.getChucVu(Idnv).ToString();
					cbMaCV.Text = tam;
					string tam2 = nvDao.getPhongBan(Idnv).ToString();
					cbPhongBan.Text = tam2;
					string tam3 = nvDao.getQueQuan(Idnv).ToString();
					txtQueQuan.Text = tam3;
					string tam4 = nvDao.getSoCMT(Idnv).ToString();
					txtSoCMT.Text = tam4;
					string tam5 = nvDao.getLuong(Idnv).ToString();
					txtLuong.Text = tam5;
					string tam6 = nvDao.getSDT(Idnv).ToString();
					txtSDT.Text = tam6;
					string tam7 = nvDao.getNgayTao(Idnv).ToString();
					maskedTxtNgayTao.Text = tam7;
				}
				//cbMaCV.Text = dgvDanhSachNV.Rows[RowIndex].Cells["Ten_ChucVu"].Value.ToString();
				//cbPhongBan.Text = dgvDanhSachNV.Rows[RowIndex].Cells["Ten_PhongBan"].Value.ToString();


				if (dgvDanhSachNV.Rows[RowIndex].Cells["Hinh"].Value.GetType() == typeof(byte[]))
				{
					byte[] imageData = (byte[])dgvDanhSachNV.Rows[RowIndex].Cells["Hinh"].Value;
					using (MemoryStream ms = new MemoryStream(imageData))
					{
						pbHinh.Image = Image.FromStream(ms);
					}
				}
				else
				{
					pbHinh.Image = Properties.Resources.HinhDaiDien;
				}

				txtHoTen.Text = dgvDanhSachNV.Rows[RowIndex].Cells["Ho_Ten"].Value.ToString();
				dTPNgaySinh.Text = dgvDanhSachNV.Rows[RowIndex].Cells["Ngay_Sinh"].Value.ToString();
				cbGioiTinh.Text = dgvDanhSachNV.Rows[RowIndex].Cells["Gioi_Tinh"].Value.ToString();
				//txtQueQuan.Text = dgvDanhSachNV.Rows[RowIndex].Cells["Que_Quan"].Value.ToString();
				//txtSoCMT.Text = dgvDanhSachNV.Rows[RowIndex].Cells["So_CMT"].Value.ToString();
				//txtLuong.Text = dgvDanhSachNV.Rows[RowIndex].Cells["Luong"].Value.ToString();
				//txtLuong.Text = dgvDanhSachNV.Rows[RowIndex].Cells["So_DienThoai"].Value.ToString();
				//maskedTxtNgayTao.Text = dgvDanhSachNV.Rows[RowIndex].Cells["Ngay_Tao"].Value.ToString();

				btnSua.Enabled = true;
				btnXoa.Enabled = true;
				btnLuu.Enabled = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}


		private void btnChonHinh_Click(object sender, EventArgs e)
		{
			OpenFileDialog openfile = new OpenFileDialog();
			openfile.Filter = "jpg|*.jpg|png|*.png|gif|*.gif|bmp|.*bmp|Tất cả|*.*";
			if (openfile.ShowDialog() == DialogResult.OK)
			{
				//String pathFile = openfile.FileName;
				//pbHinh.Image = new Bitmap(pathFile);
				pbHinh.ImageLocation = openfile.FileName;
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			instertupdate = "update";
			cbMaCV.Enabled = true;
			cbPhongBan.Enabled = true;
			txtHoTen.Enabled = true;
			dTPNgaySinh.Enabled = true;
			cbGioiTinh.Enabled = true;
			txtQueQuan.Enabled = true;
			txtSoCMT.Enabled = true;
			txtLuong.Enabled = true;
			txtSDT.Enabled = true;

			btnChonHinh.Enabled = true;
			btnThem.Enabled = false;
			btnLuu.Enabled = true;
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			try
			{
				int id_NhanVien = Convert.ToInt16(txtIDNV.Text);

				DialogResult traloi = MessageBox.Show("Bạn có chắc muốn xóa không?", "thông báo", MessageBoxButtons.OKCancel);
				if (traloi == DialogResult.OK)
				{
					nvDao.DeleteOne(id_NhanVien);
					loadDSNhanVien();
					MessageBox.Show("Xóa thành công", "Thông báo");

					
					cbMaCV.Text = "";
					cbPhongBan.Text = "";
					txtHoTen.Text = "";
					dTPNgaySinh.Text = "";
					cbGioiTinh.Text = "";
					txtQueQuan.Text = "";
					txtSoCMT.Text = "";
					txtLuong.Text = "";
					txtSDT.Text = "";
					maskedTxtNgayTao.Text = "";
					pbHinh.Image = Properties.Resources.HinhDaiDien;

					cbMaCV.Enabled = false;
					cbPhongBan.Enabled = false;
					txtHoTen.Enabled = false;
					dTPNgaySinh.Enabled = false;
					cbGioiTinh.Enabled = false;
					txtQueQuan.Enabled = false;
					txtSoCMT.Enabled = false;
					txtLuong.Enabled = false;
					txtSDT.Enabled = false;

					btnChonHinh.Enabled = false;
					btnXoa.Enabled = false;
					btnSua.Enabled = false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}

		private void btnTroVe_Click(object sender, EventArgs e)
		{
			DialogResult traloi = MessageBox.Show("Bạn có chắc muốn thoát không?", "thông báo", MessageBoxButtons.OKCancel);
			if (traloi == DialogResult.OK)
			{
				this.Close();
			}
		}

		private void txtTimKiem_TextChanged(object sender, EventArgs e)
		{
			try
			{
				string Ten_NhanVien = txtTimKiem.Text;
				if (string.IsNullOrEmpty(Ten_NhanVien))
				{

					loadDSNhanVien();
				}
				else
				{

					dgvDanhSachNV.DataSource = nvDao.SearchOne(Ten_NhanVien);
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		






		

	}
}
