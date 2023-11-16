namespace BaoCao_QLNhanVien
{
	partial class frmChucVu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChucVu));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtGhiChu = new System.Windows.Forms.TextBox();
			this.txtTenCV = new System.Windows.Forms.TextBox();
			this.txtMaCV = new System.Windows.Forms.TextBox();
			this.txtTimKiem = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvChucVu = new System.Windows.Forms.DataGridView();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnTroVe = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.ID_ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ma_ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ten_ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ghi_Chu = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.txtGhiChu);
			this.groupBox1.Controls.Add(this.txtTenCV);
			this.groupBox1.Controls.Add(this.txtMaCV);
			this.groupBox1.Controls.Add(this.txtTimKiem);
			this.groupBox1.Controls.Add(this.txtID);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 63);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(775, 310);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Nhập thông tin";
			// 
			// txtGhiChu
			// 
			this.txtGhiChu.Location = new System.Drawing.Point(147, 220);
			this.txtGhiChu.Multiline = true;
			this.txtGhiChu.Name = "txtGhiChu";
			this.txtGhiChu.Size = new System.Drawing.Size(402, 67);
			this.txtGhiChu.TabIndex = 2;
			// 
			// txtTenCV
			// 
			this.txtTenCV.Location = new System.Drawing.Point(147, 174);
			this.txtTenCV.Name = "txtTenCV";
			this.txtTenCV.Size = new System.Drawing.Size(402, 24);
			this.txtTenCV.TabIndex = 2;
			// 
			// txtMaCV
			// 
			this.txtMaCV.Location = new System.Drawing.Point(147, 125);
			this.txtMaCV.Name = "txtMaCV";
			this.txtMaCV.Size = new System.Drawing.Size(402, 24);
			this.txtMaCV.TabIndex = 1;
			// 
			// txtTimKiem
			// 
			this.txtTimKiem.Location = new System.Drawing.Point(147, 31);
			this.txtTimKiem.Name = "txtTimKiem";
			this.txtTimKiem.Size = new System.Drawing.Size(402, 24);
			this.txtTimKiem.TabIndex = 2;
			this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(147, 73);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(402, 24);
			this.txtID.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(22, 220);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 18);
			this.label5.TabIndex = 0;
			this.label5.Text = "Ghi Chú";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(22, 180);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(93, 18);
			this.label4.TabIndex = 0;
			this.label4.Text = "Tên Chức Vụ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(22, 131);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 18);
			this.label3.TabIndex = 0;
			this.label3.Text = "Mã Chức Vụ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(22, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 18);
			this.label2.TabIndex = 0;
			this.label2.Text = "ID Chức Vụ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(22, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tìm kiếm";
			// 
			// dgvChucVu
			// 
			this.dgvChucVu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.dgvChucVu.ColumnHeadersHeight = 29;
			this.dgvChucVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_ChucVu,
            this.Ma_ChucVu,
            this.Ten_ChucVu,
            this.Ghi_Chu});
			this.dgvChucVu.Location = new System.Drawing.Point(17, 35);
			this.dgvChucVu.Name = "dgvChucVu";
			this.dgvChucVu.RowHeadersWidth = 51;
			this.dgvChucVu.Size = new System.Drawing.Size(738, 168);
			this.dgvChucVu.TabIndex = 0;
			this.dgvChucVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChucVu_CellContentClick_1);
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.Color.Transparent;
			this.btnThem.FlatAppearance.BorderSize = 0;
			this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.Location = new System.Drawing.Point(252, 392);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(85, 30);
			this.btnThem.TabIndex = 2;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnSua
			// 
			this.btnSua.BackColor = System.Drawing.Color.Transparent;
			this.btnSua.FlatAppearance.BorderSize = 0;
			this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSua.Location = new System.Drawing.Point(451, 392);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(85, 30);
			this.btnSua.TabIndex = 2;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = false;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.Color.Transparent;
			this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.Location = new System.Drawing.Point(641, 391);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(85, 31);
			this.btnXoa.TabIndex = 2;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = false;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnTroVe
			// 
			this.btnTroVe.BackColor = System.Drawing.Color.Transparent;
			this.btnTroVe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTroVe.BackgroundImage")));
			this.btnTroVe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnTroVe.FlatAppearance.BorderSize = 0;
			this.btnTroVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTroVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTroVe.Location = new System.Drawing.Point(12, 12);
			this.btnTroVe.Name = "btnTroVe";
			this.btnTroVe.Size = new System.Drawing.Size(58, 30);
			this.btnTroVe.TabIndex = 2;
			this.btnTroVe.UseVisualStyleBackColor = false;
			this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
			// 
			// btnReset
			// 
			this.btnReset.BackColor = System.Drawing.Color.Transparent;
			this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnReset.FlatAppearance.BorderSize = 0;
			this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReset.ForeColor = System.Drawing.Color.Black;
			this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnReset.Location = new System.Drawing.Point(75, 391);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(85, 30);
			this.btnReset.TabIndex = 2;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = false;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Red;
			this.label6.Location = new System.Drawing.Point(245, 12);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(330, 37);
			this.label6.TabIndex = 3;
			this.label6.Text = "QUẢN LÝ CHỨC VỤ";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.dgvChucVu);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(12, 445);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(775, 225);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Danh sách chức vụ";
			// 
			// ID_ChucVu
			// 
			this.ID_ChucVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ID_ChucVu.DataPropertyName = "ID_ChucVu";
			this.ID_ChucVu.HeaderText = "Id Chức vụ";
			this.ID_ChucVu.MinimumWidth = 6;
			this.ID_ChucVu.Name = "ID_ChucVu";
			// 
			// Ma_ChucVu
			// 
			this.Ma_ChucVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Ma_ChucVu.DataPropertyName = "Ma_ChucVu";
			this.Ma_ChucVu.HeaderText = "Mã chức vụ";
			this.Ma_ChucVu.MinimumWidth = 6;
			this.Ma_ChucVu.Name = "Ma_ChucVu";
			// 
			// Ten_ChucVu
			// 
			this.Ten_ChucVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Ten_ChucVu.DataPropertyName = "Ten_ChucVu";
			this.Ten_ChucVu.HeaderText = "Tên chức vụ";
			this.Ten_ChucVu.MinimumWidth = 6;
			this.Ten_ChucVu.Name = "Ten_ChucVu";
			// 
			// Ghi_Chu
			// 
			this.Ghi_Chu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Ghi_Chu.DataPropertyName = "Ghi_Chu";
			this.Ghi_Chu.HeaderText = "Ghi chú";
			this.Ghi_Chu.MinimumWidth = 6;
			this.Ghi_Chu.Name = "Ghi_Chu";
			// 
			// frmChucVu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(806, 707);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnTroVe);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "frmChucVu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý chức vụ";
			this.Load += new System.EventHandler(this.frmChucVu_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvChucVu;
		private System.Windows.Forms.TextBox txtGhiChu;
		private System.Windows.Forms.TextBox txtTenCV;
		private System.Windows.Forms.TextBox txtMaCV;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnTroVe;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.TextBox txtTimKiem;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_ChucVu;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ma_ChucVu;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ten_ChucVu;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ghi_Chu;
	}
}