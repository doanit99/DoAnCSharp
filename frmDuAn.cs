using BaoCao_QLNhanVien.EF;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaoCao_QLNhanVien
{
	public partial class frmDuAn : Form
	{
		
		NhanVienDAO nvDao = new NhanVienDAO();
		DuAnDAO daDao=new DuAnDAO();
		public frmDuAn()
		{
			ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
			InitializeComponent();
			
		}

		private void frmDuAn_Load(object sender, EventArgs e)
		{
			txtID.Enabled = false;
			btnXoa.Enabled = false;
			btnSua.Enabled = false;
			loadDSDuAn();

			cbduAn.DataSource = daDao.getList();
			cbduAn.DisplayMember = "Ten_Da";
			cbduAn.ValueMember = "Id_Da";

			cbNhanVien.DataSource = nvDao.getList(); ;
			cbNhanVien.DisplayMember = "Ho_Ten";
			cbNhanVien.ValueMember = "ID_NhanVien";

			


		}

		private void loadDSDuAn()
		{
			dgvDuAn.DataSource = daDao.getList();
		}
		//Load data in table DuAnNhanVien
		private void loadDSDuAnNhanVien()
		{
			int idDuAn = Convert.ToInt16(txtID.Text);
			dgvNVInDuAn.DataSource = daDao.getDataDuAnNhanVien(idDuAn);
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtMaDA.Text.Length.Equals(0))
				{
					throw new Exception("Mã dự án không được để trống");
				}
				if (txtTenDA.Text.Length.Equals(0))
				{
					throw new Exception("Tên dự không được để trống");
				}

				string ma_Da = txtMaDA.Text;
				if (daDao.KiemTraMaDuAn(ma_Da) > 0)
				{
					throw new Exception("Mã dự án đã tồn tại");
				}
				string ten_Da = txtTenDA.Text;
				int soNV_Da;
				if (txtSoNV.Text != "")
				{
					soNV_Da = Convert.ToInt16(txtSoNV.Text);
				}
				else
				{
					throw new Exception("Lỗi số nhân viên");
				}
				
				string mota_Da=txtMoTaDA.Text;

				DuAn da = new DuAn(ma_Da, ten_Da, soNV_Da, mota_Da);

				daDao.InsertOne(da);
				loadDSDuAn();
				MessageBox.Show("Thêm thành công", "Thông báo");
				txtID.Text = "";
				txtMaDA.Text = "";
				txtTenDA.Text = "";
				txtSoNV.Text = "";
				txtMoTaDA.Text = "";
				btnXoa.Enabled = false;
				btnSua.Enabled = false;

				cbduAn.DataSource = daDao.getList();
				cbduAn.DisplayMember = "Ten_Da";
				cbduAn.ValueMember = "Id_Da";

				cbNhanVien.DataSource = nvDao.getList(); ;
				cbNhanVien.DisplayMember = "Ho_Ten";
				cbNhanVien.ValueMember = "ID_NhanVien";



			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dgvDuAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				int RowIndex = e.RowIndex;
				if (RowIndex == -1 || RowIndex >= dgvDuAn.Rows.Count - 1)
				{
					throw new Exception("Chưa chọn dự án nào");
				}

				txtID.Text = dgvDuAn.Rows[RowIndex].Cells["Id_Da"].Value.ToString();
				txtMaDA.Text = dgvDuAn.Rows[RowIndex].Cells["ma_Da"].Value.ToString();
				txtTenDA.Text = dgvDuAn.Rows[RowIndex].Cells["ten_Da"].Value.ToString();
				txtSoNV.Text = dgvDuAn.Rows[RowIndex].Cells["soNV_Da"].Value.ToString();
				txtMoTaDA.Text = dgvDuAn.Rows[RowIndex].Cells["mota_Da"].Value.ToString();

				btnXoa.Enabled = true;
				btnSua.Enabled = true;

				loadDSDuAnNhanVien();
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
				if (txtMaDA.Text.Length.Equals(0))
				{
					throw new Exception("Mã dự án không được để trống");
				}
				if (txtTenDA.Text.Length.Equals(0))
				{
					throw new Exception("Tên dự không được để trống");
				}
				string id_Da = txtID.Text;
				string ma_Da = txtMaDA.Text;
				if (daDao.KiemTraMaDuAn(ma_Da) > 0)
				{
					throw new Exception("Mã dự án đã tồn tại");
				}
				string ten_Da = txtTenDA.Text;
				int soNV_Da;
				if (txtSoNV.Text != "")
				{
					soNV_Da = Convert.ToInt16(txtSoNV.Text);
				}
				else
				{
					throw new Exception("Lỗi số nhân viên");
				}

				string mota_Da = txtMoTaDA.Text;

				DuAn da = new DuAn(ma_Da, ten_Da, soNV_Da, mota_Da);


				daDao.UpdateOne(id_Da, da);
				loadDSDuAn();
				MessageBox.Show("Cập nhật thành công", "Thông báo");
				txtID.Text = "";
				txtMaDA.Text = "";
				txtTenDA.Text = "";
				txtSoNV.Text = "";
				txtMoTaDA.Text = "";
				btnXoa.Enabled = false;
				btnSua.Enabled = false;

				cbduAn.DataSource = daDao.getList();
				cbduAn.DisplayMember = "Ten_Da";
				cbduAn.ValueMember = "Id_Da";

				cbNhanVien.DataSource = nvDao.getList(); ;
				cbNhanVien.DisplayMember = "Ho_Ten";
				cbNhanVien.ValueMember = "ID_NhanVien";

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
				int Id_Da = Convert.ToInt16(txtID.Text);
				daDao.DeleteOne(Id_Da);
				daDao.DeleteProjectAndEmployeeInProject(Id_Da);
				loadDSDuAn();
				MessageBox.Show("Xóa thành công", "Thông báo");
				txtID.Text = "";
				txtMaDA.Text = "";
				txtTenDA.Text = "";
				txtSoNV.Text = "";
				txtMoTaDA.Text = "";
				btnXoa.Enabled = false;
				btnSua.Enabled = false;

				cbduAn.DataSource = daDao.getList();
				cbduAn.DisplayMember = "Ten_Da";
				cbduAn.ValueMember = "Id_Da";

				cbNhanVien.DataSource = nvDao.getList(); ;
				cbNhanVien.DisplayMember = "Ho_Ten";
				cbNhanVien.ValueMember = "ID_NhanVien";

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			txtID.Text = "";
			txtMaDA.Text = "";
			txtTenDA.Text = "";
			txtSoNV.Text = "";
			txtMoTaDA.Text = "";
			btnXoa.Enabled = false;
			btnSua.Enabled = false;

			cbduAn.DataSource = daDao.getList();
			cbduAn.DisplayMember = "Ten_Da";
			cbduAn.ValueMember = "Id_Da";

			cbNhanVien.DataSource = nvDao.getList(); ;
			cbNhanVien.DisplayMember = "Ho_Ten";
			cbNhanVien.ValueMember = "ID_NhanVien";

			MessageBox.Show("Dữ liệu đã được reset", "Thông báo");
		}

		private void btnTroVe_Click(object sender, EventArgs e)
		{
			DialogResult traloi = MessageBox.Show("Bạn có chắc muốn thoát không?", "thông báo",MessageBoxButtons.OKCancel);
			if (traloi == DialogResult.OK)
			{
				this.Close();
			}
		}

		//Thêm nhân viên vào dự án
		private void btnThemNVDA_Click(object sender, EventArgs e)
		{
			try { 
				if (cbduAn.Text.Length.Equals(0))
				{
					throw new Exception("Mã dự án không được để trống");
				}
				if (cbNhanVien.Text.Length.Equals(0))
				{
					throw new Exception("Tên nhân viên không được để trống");
				}
				int selectedProjectID = Convert.ToInt16(cbduAn.SelectedValue.ToString());
				int selectedEmployeeID = Convert.ToInt16(cbNhanVien.SelectedValue.ToString());

				if (daDao.IsEmployeeInProject(selectedProjectID, selectedEmployeeID)==true)
				{
					MessageBox.Show("Nhân viên đã tham gia dự án này!");
					return;
				}
				//Kiểm tra đủ nhân viên chưa
				if(daDao.CheckEnoughEmployee(selectedProjectID, selectedEmployeeID) == true)
				{
					// Thêm nhân viên vào dự án
					if (daDao.AddEmployeeToProject(selectedProjectID, selectedEmployeeID) == true)
					{
						MessageBox.Show("Nhân viên đã được thêm vào dự án thành công!");
						loadDSDuAnNhanVien();
					}
					else
					{
						MessageBox.Show("Đã xảy ra lỗi khi thêm nhân viên vào dự án!");
					}
				}
				else
				{
					MessageBox.Show("Đã đủ nhân viên tham gia dự án");
				}
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//Employee join project
		private void dgvNVInDuAn_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				int RowIndex = e.RowIndex;
				if (RowIndex == -1 || RowIndex >= dgvNVInDuAn.Rows.Count - 1)
				{
					throw new Exception("Chưa chọn nhân viên nào");
				}

				//cbduAn.Text = dgvNVInDuAn.Rows[RowIndex].Cells["Id_Da"].Value.ToString();
				cbNhanVien.Text = dgvNVInDuAn.Rows[RowIndex].Cells["Ho_Ten"].Value.ToString();

				loadDSDuAnNhanVien();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}

		private void btnXoa1NV_Click(object sender, EventArgs e)
		{
			
			try
			{
				string idNhanVien = cbNhanVien.Text;
				
				daDao.DeleteOneEmployeeInProject(idNhanVien);
				
				MessageBox.Show("Xóa thành công", "Thông báo");
				

				cbduAn.DataSource = daDao.getList();
				cbduAn.DisplayMember = "Ten_Da";
				cbduAn.ValueMember = "Id_Da";

				cbNhanVien.DataSource = nvDao.getList(); ;
				cbNhanVien.DisplayMember = "Ho_Ten";
				cbNhanVien.ValueMember = "ID_NhanVien";

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		//Xuất file
		private void ExportToExcel(DataGridView dataGridView, string filePath)
		{
			try
			{
				// Create an Excel package
				using (var excelPackage = new ExcelPackage())
				{
					// Create a new worksheet
					var excelWorksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

					// Export data from DataGridView to Excel
					for (int i = 1; i <= dataGridView.Columns.Count; i++)
					{
						excelWorksheet.Cells[1, i].Value = dataGridView.Columns[i - 1].HeaderText;
					}

					for (int i = 0; i < dataGridView.Rows.Count; i++)
					{
						for (int j = 0; j < dataGridView.Columns.Count; j++)
						{
							excelWorksheet.Cells[i + 2, j + 1].Value = dataGridView.Rows[i].Cells[j].Value?.ToString() ?? "";
						}
					}

					// Save the Excel file
					FileInfo excelFile = new FileInfo(filePath);
					excelPackage.SaveAs(excelFile);
				}

				MessageBox.Show("Export to Excel successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error exporting to Excel: {ex.Message}\nStackTrace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void btnXuatFile_Click(object sender, EventArgs e)
		{
			try
			{
				string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				string filePath = Path.Combine(desktopPath, "DataExport.xlsx");

				ExportToExcel(dgvDuAn, filePath);
				MessageBox.Show("Export to Excel successful!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error exporting to Excel: {ex.Message}\nStackTrace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
