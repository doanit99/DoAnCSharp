namespace BaoCao_QLNhanVien
{
	partial class frmNhanVien
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
			this.lblIDNV = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pbHinh = new System.Windows.Forms.PictureBox();
			this.btnChonHinh = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.cbGioiTinh = new System.Windows.Forms.ComboBox();
			this.btnXoa = new System.Windows.Forms.Button();
			this.dTPNgaySinh = new System.Windows.Forms.DateTimePicker();
			this.btnSua = new System.Windows.Forms.Button();
			this.maskedTxtNgayTao = new System.Windows.Forms.MaskedTextBox();
			this.btnThem = new System.Windows.Forms.Button();
			this.cbPhongBan = new System.Windows.Forms.ComboBox();
			this.cbMaCV = new System.Windows.Forms.ComboBox();
			this.txtSDT = new System.Windows.Forms.TextBox();
			this.txtLuong = new System.Windows.Forms.TextBox();
			this.txtSoCMT = new System.Windows.Forms.TextBox();
			this.txtHoTen = new System.Windows.Forms.TextBox();
			this.txtQueQuan = new System.Windows.Forms.TextBox();
			this.txtIDNV = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.btnTroVe = new System.Windows.Forms.Button();
			this.dgvDanhSachNV = new System.Windows.Forms.DataGridView();
			this.ID_NhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ho_Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Gioi_Tinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ngay_Sinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Hinh = new System.Windows.Forms.DataGridViewImageColumn();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtTimKiem = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.tblNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.tblNhanVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.tblNhanVienBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.tblNhanVienBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbHinh)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNV)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource3)).BeginInit();
			this.SuspendLayout();
			// 
			// lblIDNV
			// 
			this.lblIDNV.AutoSize = true;
			this.lblIDNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIDNV.Location = new System.Drawing.Point(154, 26);
			this.lblIDNV.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
			this.lblIDNV.Name = "lblIDNV";
			this.lblIDNV.Size = new System.Drawing.Size(116, 22);
			this.lblIDNV.TabIndex = 0;
			this.lblIDNV.Text = "ID Nhân Viên";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(153, 63);
			this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 22);
			this.label2.TabIndex = 1;
			this.label2.Text = "Chức Vụ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(153, 101);
			this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 22);
			this.label3.TabIndex = 1;
			this.label3.Text = "Phòng Ban";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(0, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(153, 181);
			this.label5.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(93, 22);
			this.label5.TabIndex = 1;
			this.label5.Text = "Ngày Sinh";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(23, 221);
			this.label6.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(83, 22);
			this.label6.TabIndex = 1;
			this.label6.Text = "Giới Tính";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(19, 402);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(89, 22);
			this.label7.TabIndex = 3;
			this.label7.Text = "Ngày Tạo";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(19, 255);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(93, 22);
			this.label12.TabIndex = 2;
			this.label12.Text = "Quê Quán";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.pbHinh);
			this.groupBox1.Controls.Add(this.btnChonHinh);
			this.groupBox1.Controls.Add(this.btnLuu);
			this.groupBox1.Controls.Add(this.cbGioiTinh);
			this.groupBox1.Controls.Add(this.btnXoa);
			this.groupBox1.Controls.Add(this.dTPNgaySinh);
			this.groupBox1.Controls.Add(this.btnSua);
			this.groupBox1.Controls.Add(this.maskedTxtNgayTao);
			this.groupBox1.Controls.Add(this.btnThem);
			this.groupBox1.Controls.Add(this.cbPhongBan);
			this.groupBox1.Controls.Add(this.cbMaCV);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.txtSDT);
			this.groupBox1.Controls.Add(this.txtLuong);
			this.groupBox1.Controls.Add(this.txtSoCMT);
			this.groupBox1.Controls.Add(this.txtHoTen);
			this.groupBox1.Controls.Add(this.txtQueQuan);
			this.groupBox1.Controls.Add(this.txtIDNV);
			this.groupBox1.Controls.Add(this.label13);
			this.groupBox1.Controls.Add(this.label14);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.lblIDNV);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Location = new System.Drawing.Point(12, 61);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(553, 519);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin";
			// 
			// pbHinh
			// 
			this.pbHinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.pbHinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pbHinh.Location = new System.Drawing.Point(23, 26);
			this.pbHinh.Name = "pbHinh";
			this.pbHinh.Size = new System.Drawing.Size(98, 136);
			this.pbHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbHinh.TabIndex = 11;
			this.pbHinh.TabStop = false;
			// 
			// btnChonHinh
			// 
			this.btnChonHinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnChonHinh.Location = new System.Drawing.Point(23, 172);
			this.btnChonHinh.Name = "btnChonHinh";
			this.btnChonHinh.Size = new System.Drawing.Size(98, 31);
			this.btnChonHinh.TabIndex = 14;
			this.btnChonHinh.Text = "Chọn hình";
			this.btnChonHinh.Click += new System.EventHandler(this.btnChonHinh_Click);
			// 
			// btnLuu
			// 
			this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLuu.Location = new System.Drawing.Point(424, 452);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(87, 38);
			this.btnLuu.TabIndex = 9;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = true;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// cbGioiTinh
			// 
			this.cbGioiTinh.FormattingEnabled = true;
			this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
			this.cbGioiTinh.Location = new System.Drawing.Point(165, 219);
			this.cbGioiTinh.Name = "cbGioiTinh";
			this.cbGioiTinh.Size = new System.Drawing.Size(347, 24);
			this.cbGioiTinh.TabIndex = 10;
			// 
			// btnXoa
			// 
			this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.Location = new System.Drawing.Point(291, 452);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(87, 38);
			this.btnXoa.TabIndex = 9;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// dTPNgaySinh
			// 
			this.dTPNgaySinh.Location = new System.Drawing.Point(273, 179);
			this.dTPNgaySinh.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
			this.dTPNgaySinh.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
			this.dTPNgaySinh.Name = "dTPNgaySinh";
			this.dTPNgaySinh.Size = new System.Drawing.Size(239, 22);
			this.dTPNgaySinh.TabIndex = 9;
			this.dTPNgaySinh.Value = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
			// 
			// btnSua
			// 
			this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSua.Location = new System.Drawing.Point(157, 452);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(87, 38);
			this.btnSua.TabIndex = 9;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// maskedTxtNgayTao
			// 
			this.maskedTxtNgayTao.Location = new System.Drawing.Point(165, 402);
			this.maskedTxtNgayTao.Name = "maskedTxtNgayTao";
			this.maskedTxtNgayTao.Size = new System.Drawing.Size(347, 22);
			this.maskedTxtNgayTao.TabIndex = 10;
			// 
			// btnThem
			// 
			this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.Location = new System.Drawing.Point(27, 452);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(87, 38);
			this.btnThem.TabIndex = 9;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// cbPhongBan
			// 
			this.cbPhongBan.FormattingEnabled = true;
			this.cbPhongBan.Items.AddRange(new object[] {
            "Sale",
            "Maketing"});
			this.cbPhongBan.Location = new System.Drawing.Point(273, 99);
			this.cbPhongBan.Name = "cbPhongBan";
			this.cbPhongBan.Size = new System.Drawing.Size(239, 24);
			this.cbPhongBan.TabIndex = 6;
			// 
			// cbMaCV
			// 
			this.cbMaCV.FormattingEnabled = true;
			this.cbMaCV.Items.AddRange(new object[] {
            "TP",
            "GD"});
			this.cbMaCV.Location = new System.Drawing.Point(272, 61);
			this.cbMaCV.Name = "cbMaCV";
			this.cbMaCV.Size = new System.Drawing.Size(239, 24);
			this.cbMaCV.TabIndex = 6;
			// 
			// txtSDT
			// 
			this.txtSDT.Location = new System.Drawing.Point(165, 366);
			this.txtSDT.Name = "txtSDT";
			this.txtSDT.Size = new System.Drawing.Size(347, 22);
			this.txtSDT.TabIndex = 10;
			// 
			// txtLuong
			// 
			this.txtLuong.Location = new System.Drawing.Point(164, 330);
			this.txtLuong.Name = "txtLuong";
			this.txtLuong.Size = new System.Drawing.Size(348, 22);
			this.txtLuong.TabIndex = 10;
			// 
			// txtSoCMT
			// 
			this.txtSoCMT.Location = new System.Drawing.Point(164, 294);
			this.txtSoCMT.Name = "txtSoCMT";
			this.txtSoCMT.Size = new System.Drawing.Size(348, 22);
			this.txtSoCMT.TabIndex = 10;
			// 
			// txtHoTen
			// 
			this.txtHoTen.Location = new System.Drawing.Point(274, 140);
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.Size = new System.Drawing.Size(239, 22);
			this.txtHoTen.TabIndex = 10;
			// 
			// txtQueQuan
			// 
			this.txtQueQuan.Location = new System.Drawing.Point(164, 257);
			this.txtQueQuan.Name = "txtQueQuan";
			this.txtQueQuan.Size = new System.Drawing.Size(348, 22);
			this.txtQueQuan.TabIndex = 10;
			// 
			// txtIDNV
			// 
			this.txtIDNV.Location = new System.Drawing.Point(273, 26);
			this.txtIDNV.Name = "txtIDNV";
			this.txtIDNV.Size = new System.Drawing.Size(239, 22);
			this.txtIDNV.TabIndex = 0;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(19, 292);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(76, 22);
			this.label13.TabIndex = 5;
			this.label13.Text = "Số CMT";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(19, 366);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(125, 22);
			this.label14.TabIndex = 5;
			this.label14.Text = "Số Điện Thoại";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(19, 332);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 22);
			this.label1.TabIndex = 5;
			this.label1.Text = "Lương";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(154, 140);
			this.label15.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(70, 22);
			this.label15.TabIndex = 1;
			this.label15.Text = "Họ Tên";
			// 
			// btnTroVe
			// 
			this.btnTroVe.BackColor = System.Drawing.Color.Transparent;
			this.btnTroVe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTroVe.BackgroundImage")));
			this.btnTroVe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnTroVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTroVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTroVe.ForeColor = System.Drawing.Color.Transparent;
			this.btnTroVe.Location = new System.Drawing.Point(15, 12);
			this.btnTroVe.Name = "btnTroVe";
			this.btnTroVe.Size = new System.Drawing.Size(54, 38);
			this.btnTroVe.TabIndex = 9;
			this.btnTroVe.UseVisualStyleBackColor = false;
			this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
			// 
			// dgvDanhSachNV
			// 
			this.dgvDanhSachNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDanhSachNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_NhanVien,
            this.Ho_Ten,
            this.Gioi_Tinh,
            this.Ngay_Sinh,
            this.Hinh});
			this.dgvDanhSachNV.Location = new System.Drawing.Point(22, 61);
			this.dgvDanhSachNV.Name = "dgvDanhSachNV";
			this.dgvDanhSachNV.RowHeadersWidth = 51;
			this.dgvDanhSachNV.RowTemplate.Height = 24;
			this.dgvDanhSachNV.Size = new System.Drawing.Size(558, 438);
			this.dgvDanhSachNV.TabIndex = 10;
			this.dgvDanhSachNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachNV_CellContentClick);
			// 
			// ID_NhanVien
			// 
			this.ID_NhanVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ID_NhanVien.DataPropertyName = "ID_NhanVien";
			this.ID_NhanVien.HeaderText = "ID";
			this.ID_NhanVien.MinimumWidth = 6;
			this.ID_NhanVien.Name = "ID_NhanVien";
			// 
			// Ho_Ten
			// 
			this.Ho_Ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Ho_Ten.DataPropertyName = "Ho_Ten";
			this.Ho_Ten.HeaderText = "Họ và tên";
			this.Ho_Ten.MinimumWidth = 6;
			this.Ho_Ten.Name = "Ho_Ten";
			// 
			// Gioi_Tinh
			// 
			this.Gioi_Tinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Gioi_Tinh.DataPropertyName = "Gioi_Tinh";
			this.Gioi_Tinh.HeaderText = "Giới Tính";
			this.Gioi_Tinh.MinimumWidth = 6;
			this.Gioi_Tinh.Name = "Gioi_Tinh";
			// 
			// Ngay_Sinh
			// 
			this.Ngay_Sinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Ngay_Sinh.DataPropertyName = "Ngay_Sinh";
			this.Ngay_Sinh.HeaderText = "Ngày sinh";
			this.Ngay_Sinh.MinimumWidth = 6;
			this.Ngay_Sinh.Name = "Ngay_Sinh";
			// 
			// Hinh
			// 
			this.Hinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Hinh.DataPropertyName = "Hinh";
			this.Hinh.HeaderText = "Hinh";
			this.Hinh.MinimumWidth = 6;
			this.Hinh.Name = "Hinh";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.txtTimKiem);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.dgvDanhSachNV);
			this.groupBox2.Location = new System.Drawing.Point(587, 61);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(600, 519);
			this.groupBox2.TabIndex = 11;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Danh sách";
			// 
			// txtTimKiem
			// 
			this.txtTimKiem.Location = new System.Drawing.Point(109, 25);
			this.txtTimKiem.Name = "txtTimKiem";
			this.txtTimKiem.Size = new System.Drawing.Size(217, 22);
			this.txtTimKiem.TabIndex = 12;
			this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(22, 31);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(62, 16);
			this.label9.TabIndex = 11;
			this.label9.Text = "Tìm kiếm";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Red;
			this.label8.Location = new System.Drawing.Point(417, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(363, 37);
			this.label8.TabIndex = 12;
			this.label8.Text = "QUẢN LÝ NHÂN VIÊN";
			// 
			// frmNhanVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1199, 643);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.btnTroVe);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "frmNhanVien";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý nhân viên";
			this.Load += new System.EventHandler(this.frmNhanVien_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbHinh)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNV)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tblNhanVienBindingSource3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblIDNV;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtSoCMT;
		private System.Windows.Forms.TextBox txtIDNV;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox cbMaCV;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.MaskedTextBox maskedTxtNgayTao;
		private System.Windows.Forms.ComboBox cbPhongBan;
		private System.Windows.Forms.TextBox txtSDT;
		private System.Windows.Forms.TextBox txtLuong;
		private System.Windows.Forms.TextBox txtHoTen;
		private System.Windows.Forms.TextBox txtQueQuan;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Button btnTroVe;
		private System.Windows.Forms.DataGridView dgvDanhSachNV;
		
		private System.Windows.Forms.BindingSource tblNhanVienBindingSource;
		
		private System.Windows.Forms.BindingSource tblNhanVienBindingSource1;
		private System.Windows.Forms.BindingSource tblNhanVienBindingSource2;
		
		private System.Windows.Forms.BindingSource tblNhanVienBindingSource3;
		private System.Windows.Forms.DateTimePicker dTPNgaySinh;
		private System.Windows.Forms.ComboBox cbGioiTinh;
		private System.Windows.Forms.PictureBox pbHinh;
		private System.Windows.Forms.Button btnChonHinh;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtTimKiem;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_NhanVien;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ho_Ten;
		private System.Windows.Forms.DataGridViewTextBoxColumn Gioi_Tinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_Sinh;
		private System.Windows.Forms.DataGridViewImageColumn Hinh;
	}
}