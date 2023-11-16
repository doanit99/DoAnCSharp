namespace BaoCao_QLNhanVien
{
	partial class frmDuAn
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDuAn));
			this.dgvDuAn = new System.Windows.Forms.DataGridView();
			this.Id_Da = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ma_Da = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ten_Da = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SoNV_Da = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MoTa_Da = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtMoTaDA = new System.Windows.Forms.TextBox();
			this.txtSoNV = new System.Windows.Forms.TextBox();
			this.txtTenDA = new System.Windows.Forms.TextBox();
			this.txtMaDA = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnThemNVDA = new System.Windows.Forms.Button();
			this.cbNhanVien = new System.Windows.Forms.ComboBox();
			this.cbduAn = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnTroVe = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnXuatFile = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.btnXoa1NV = new System.Windows.Forms.Button();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.dgvNVInDuAn = new System.Windows.Forms.DataGridView();
			this.Ho_Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvDuAn)).BeginInit();
			this.panel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvNVInDuAn)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvDuAn
			// 
			this.dgvDuAn.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgvDuAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDuAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Da,
            this.ma_Da,
            this.Ten_Da,
            this.SoNV_Da,
            this.MoTa_Da});
			this.dgvDuAn.GridColor = System.Drawing.SystemColors.ControlLight;
			this.dgvDuAn.Location = new System.Drawing.Point(26, 87);
			this.dgvDuAn.Name = "dgvDuAn";
			this.dgvDuAn.RowHeadersWidth = 51;
			this.dgvDuAn.RowTemplate.Height = 24;
			this.dgvDuAn.Size = new System.Drawing.Size(543, 118);
			this.dgvDuAn.TabIndex = 0;
			this.dgvDuAn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDuAn_CellContentClick);
			// 
			// Id_Da
			// 
			this.Id_Da.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Id_Da.DataPropertyName = "Id_Da";
			this.Id_Da.HeaderText = "Id Dự án";
			this.Id_Da.MinimumWidth = 6;
			this.Id_Da.Name = "Id_Da";
			// 
			// ma_Da
			// 
			this.ma_Da.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ma_Da.DataPropertyName = "ma_Da";
			this.ma_Da.HeaderText = "Mã dự án";
			this.ma_Da.MinimumWidth = 6;
			this.ma_Da.Name = "ma_Da";
			// 
			// Ten_Da
			// 
			this.Ten_Da.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Ten_Da.DataPropertyName = "ten_Da";
			this.Ten_Da.HeaderText = "Tên dự án";
			this.Ten_Da.MinimumWidth = 6;
			this.Ten_Da.Name = "Ten_Da";
			// 
			// SoNV_Da
			// 
			this.SoNV_Da.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.SoNV_Da.DataPropertyName = "SoNV_Da";
			this.SoNV_Da.HeaderText = "Số nhân viên ";
			this.SoNV_Da.MinimumWidth = 6;
			this.SoNV_Da.Name = "SoNV_Da";
			// 
			// MoTa_Da
			// 
			this.MoTa_Da.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.MoTa_Da.DataPropertyName = "mota_Da";
			this.MoTa_Da.HeaderText = "Mô tả dự án";
			this.MoTa_Da.MinimumWidth = 6;
			this.MoTa_Da.Name = "MoTa_Da";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.txtMoTaDA);
			this.panel1.Controls.Add(this.txtSoNV);
			this.panel1.Controls.Add(this.txtTenDA);
			this.panel1.Controls.Add(this.txtMaDA);
			this.panel1.Controls.Add(this.txtID);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(12, 311);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(576, 278);
			this.panel1.TabIndex = 1;
			// 
			// txtMoTaDA
			// 
			this.txtMoTaDA.Location = new System.Drawing.Point(185, 175);
			this.txtMoTaDA.Multiline = true;
			this.txtMoTaDA.Name = "txtMoTaDA";
			this.txtMoTaDA.Size = new System.Drawing.Size(312, 81);
			this.txtMoTaDA.TabIndex = 2;
			// 
			// txtSoNV
			// 
			this.txtSoNV.Location = new System.Drawing.Point(185, 137);
			this.txtSoNV.Name = "txtSoNV";
			this.txtSoNV.Size = new System.Drawing.Size(312, 22);
			this.txtSoNV.TabIndex = 2;
			// 
			// txtTenDA
			// 
			this.txtTenDA.Location = new System.Drawing.Point(185, 100);
			this.txtTenDA.Name = "txtTenDA";
			this.txtTenDA.Size = new System.Drawing.Size(312, 22);
			this.txtTenDA.TabIndex = 2;
			// 
			// txtMaDA
			// 
			this.txtMaDA.Location = new System.Drawing.Point(185, 62);
			this.txtMaDA.Name = "txtMaDA";
			this.txtMaDA.Size = new System.Drawing.Size(312, 22);
			this.txtMaDA.TabIndex = 2;
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(185, 21);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(312, 22);
			this.txtID.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(31, 171);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(115, 25);
			this.label5.TabIndex = 1;
			this.label5.Text = "Mô tả dự án";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(31, 133);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(127, 25);
			this.label3.TabIndex = 0;
			this.label3.Text = "Số nhân viên";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(31, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 25);
			this.label2.TabIndex = 0;
			this.label2.Text = "Tên dự án";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(31, 58);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(94, 25);
			this.label6.TabIndex = 0;
			this.label6.Text = "Mã dự án";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(31, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID dự án";
			// 
			// btnThemNVDA
			// 
			this.btnThemNVDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThemNVDA.Location = new System.Drawing.Point(176, 159);
			this.btnThemNVDA.Name = "btnThemNVDA";
			this.btnThemNVDA.Size = new System.Drawing.Size(73, 39);
			this.btnThemNVDA.TabIndex = 5;
			this.btnThemNVDA.Text = "Thêm";
			this.btnThemNVDA.UseVisualStyleBackColor = true;
			this.btnThemNVDA.Click += new System.EventHandler(this.btnThemNVDA_Click);
			// 
			// cbNhanVien
			// 
			this.cbNhanVien.FormattingEnabled = true;
			this.cbNhanVien.Location = new System.Drawing.Point(30, 104);
			this.cbNhanVien.Name = "cbNhanVien";
			this.cbNhanVien.Size = new System.Drawing.Size(242, 24);
			this.cbNhanVien.TabIndex = 4;
			// 
			// cbduAn
			// 
			this.cbduAn.FormattingEnabled = true;
			this.cbduAn.Location = new System.Drawing.Point(30, 47);
			this.cbduAn.Name = "cbduAn";
			this.cbduAn.Size = new System.Drawing.Size(242, 24);
			this.cbduAn.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(250, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(283, 37);
			this.label4.TabIndex = 0;
			this.label4.Text = "QUẢN LÝ DỰ ÁN";
			// 
			// btnReset
			// 
			this.btnReset.BackColor = System.Drawing.Color.Transparent;
			this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
			this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReset.Location = new System.Drawing.Point(86, 21);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(64, 37);
			this.btnReset.TabIndex = 2;
			this.btnReset.UseVisualStyleBackColor = false;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.Color.Transparent;
			this.btnThem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThem.BackgroundImage")));
			this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.Location = new System.Drawing.Point(167, 21);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(64, 37);
			this.btnThem.TabIndex = 2;
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnSua
			// 
			this.btnSua.BackColor = System.Drawing.Color.Transparent;
			this.btnSua.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSua.BackgroundImage")));
			this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSua.Location = new System.Drawing.Point(245, 21);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(63, 37);
			this.btnSua.TabIndex = 2;
			this.btnSua.UseVisualStyleBackColor = false;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnTroVe
			// 
			this.btnTroVe.BackColor = System.Drawing.Color.Transparent;
			this.btnTroVe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTroVe.BackgroundImage")));
			this.btnTroVe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnTroVe.FlatAppearance.BorderSize = 0;
			this.btnTroVe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.btnTroVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTroVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTroVe.Location = new System.Drawing.Point(12, 6);
			this.btnTroVe.Name = "btnTroVe";
			this.btnTroVe.Size = new System.Drawing.Size(68, 37);
			this.btnTroVe.TabIndex = 2;
			this.btnTroVe.UseVisualStyleBackColor = true;
			this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.Color.Transparent;
			this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
			this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.Location = new System.Drawing.Point(323, 21);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(62, 37);
			this.btnXoa.TabIndex = 2;
			this.btnXoa.UseVisualStyleBackColor = false;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(13, 49);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(575, 169);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Danh sách";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.btnXuatFile);
			this.groupBox2.Controls.Add(this.btnSua);
			this.groupBox2.Controls.Add(this.btnXoa);
			this.groupBox2.Controls.Add(this.btnReset);
			this.groupBox2.Controls.Add(this.btnThem);
			this.groupBox2.Location = new System.Drawing.Point(12, 225);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(576, 80);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Chức năng";
			// 
			// btnXuatFile
			// 
			this.btnXuatFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXuatFile.BackgroundImage")));
			this.btnXuatFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnXuatFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnXuatFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
			this.btnXuatFile.ForeColor = System.Drawing.Color.Black;
			this.btnXuatFile.Location = new System.Drawing.Point(404, 21);
			this.btnXuatFile.Name = "btnXuatFile";
			this.btnXuatFile.Size = new System.Drawing.Size(65, 37);
			this.btnXuatFile.TabIndex = 3;
			this.btnXuatFile.UseVisualStyleBackColor = true;
			this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.Transparent;
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.btnXoa1NV);
			this.groupBox3.Controls.Add(this.cbNhanVien);
			this.groupBox3.Controls.Add(this.btnThemNVDA);
			this.groupBox3.Controls.Add(this.cbduAn);
			this.groupBox3.Location = new System.Drawing.Point(601, 311);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(278, 278);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Thêm nhân viên vào dự án";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(27, 83);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(110, 18);
			this.label8.TabIndex = 8;
			this.label8.Text = "Chọn nhân viên";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(30, 26);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(84, 18);
			this.label7.TabIndex = 7;
			this.label7.Text = "Chọn dự án";
			// 
			// btnXoa1NV
			// 
			this.btnXoa1NV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnXoa1NV.Location = new System.Drawing.Point(30, 159);
			this.btnXoa1NV.Name = "btnXoa1NV";
			this.btnXoa1NV.Size = new System.Drawing.Size(84, 37);
			this.btnXoa1NV.TabIndex = 6;
			this.btnXoa1NV.Text = "Xóa";
			this.btnXoa1NV.UseVisualStyleBackColor = true;
			this.btnXoa1NV.Click += new System.EventHandler(this.btnXoa1NV_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.Transparent;
			this.groupBox4.Controls.Add(this.dgvNVInDuAn);
			this.groupBox4.Location = new System.Drawing.Point(601, 60);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(278, 245);
			this.groupBox4.TabIndex = 7;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Danh sách nhân viên tham gia dư án";
			// 
			// dgvNVInDuAn
			// 
			this.dgvNVInDuAn.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			this.dgvNVInDuAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvNVInDuAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ho_Ten});
			this.dgvNVInDuAn.Location = new System.Drawing.Point(7, 27);
			this.dgvNVInDuAn.Name = "dgvNVInDuAn";
			this.dgvNVInDuAn.RowHeadersWidth = 51;
			this.dgvNVInDuAn.RowTemplate.Height = 24;
			this.dgvNVInDuAn.Size = new System.Drawing.Size(265, 212);
			this.dgvNVInDuAn.TabIndex = 0;
			this.dgvNVInDuAn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNVInDuAn_CellContentClick);
			// 
			// Ho_Ten
			// 
			this.Ho_Ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Ho_Ten.DataPropertyName = "Ho_Ten";
			this.Ho_Ten.HeaderText = "Họ tên nhân viên";
			this.Ho_Ten.MinimumWidth = 6;
			this.Ho_Ten.Name = "Ho_Ten";
			// 
			// frmDuAn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(905, 601);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnTroVe);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dgvDuAn);
			this.Controls.Add(this.groupBox1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "frmDuAn";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý dự án";
			this.Load += new System.EventHandler(this.frmDuAn_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDuAn)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvNVInDuAn)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvDuAn;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtMoTaDA;
		private System.Windows.Forms.TextBox txtSoNV;
		private System.Windows.Forms.TextBox txtTenDA;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnTroVe;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.TextBox txtMaDA;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id_Da;
		private System.Windows.Forms.DataGridViewTextBoxColumn ma_Da;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ten_Da;
		private System.Windows.Forms.DataGridViewTextBoxColumn SoNV_Da;
		private System.Windows.Forms.DataGridViewTextBoxColumn MoTa_Da;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox cbNhanVien;
		private System.Windows.Forms.ComboBox cbduAn;
		private System.Windows.Forms.Button btnThemNVDA;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.DataGridView dgvNVInDuAn;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ho_Ten;
		private System.Windows.Forms.Button btnXoa1NV;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnXuatFile;
	}
}