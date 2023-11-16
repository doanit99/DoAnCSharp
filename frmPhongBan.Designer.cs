namespace BaoCao_QLNhanVien
{
	partial class frmPhongBan
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhongBan));
			this.dgvPhongBan = new System.Windows.Forms.DataGridView();
			this.panel = new System.Windows.Forms.Panel();
			this.txtGhiChu = new System.Windows.Forms.TextBox();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.txtTenPB = new System.Windows.Forms.TextBox();
			this.txtMaPB = new System.Windows.Forms.TextBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnTroVe = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.ID_PhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ma_PhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ten_PhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Dia_Chi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ghi_Chu = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).BeginInit();
			this.panel.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvPhongBan
			// 
			this.dgvPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPhongBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PhongBan,
            this.Ma_PhongBan,
            this.Ten_PhongBan,
            this.Dia_Chi,
            this.Ghi_Chu});
			this.dgvPhongBan.Location = new System.Drawing.Point(31, 71);
			this.dgvPhongBan.Name = "dgvPhongBan";
			this.dgvPhongBan.RowHeadersWidth = 51;
			this.dgvPhongBan.RowTemplate.Height = 24;
			this.dgvPhongBan.Size = new System.Drawing.Size(732, 136);
			this.dgvPhongBan.TabIndex = 0;
			this.dgvPhongBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhongBan_CellContentClick);
			// 
			// panel
			// 
			this.panel.BackColor = System.Drawing.Color.Transparent;
			this.panel.Controls.Add(this.txtGhiChu);
			this.panel.Controls.Add(this.txtDiaChi);
			this.panel.Controls.Add(this.txtTenPB);
			this.panel.Controls.Add(this.txtMaPB);
			this.panel.Controls.Add(this.txtID);
			this.panel.Controls.Add(this.label5);
			this.panel.Controls.Add(this.label4);
			this.panel.Controls.Add(this.label3);
			this.panel.Controls.Add(this.label2);
			this.panel.Controls.Add(this.label1);
			this.panel.Location = new System.Drawing.Point(13, 307);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(775, 309);
			this.panel.TabIndex = 1;
			// 
			// txtGhiChu
			// 
			this.txtGhiChu.Location = new System.Drawing.Point(173, 206);
			this.txtGhiChu.Multiline = true;
			this.txtGhiChu.Name = "txtGhiChu";
			this.txtGhiChu.Size = new System.Drawing.Size(375, 85);
			this.txtGhiChu.TabIndex = 1;
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Location = new System.Drawing.Point(173, 163);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(375, 22);
			this.txtDiaChi.TabIndex = 1;
			// 
			// txtTenPB
			// 
			this.txtTenPB.Location = new System.Drawing.Point(173, 122);
			this.txtTenPB.Name = "txtTenPB";
			this.txtTenPB.Size = new System.Drawing.Size(375, 22);
			this.txtTenPB.TabIndex = 1;
			// 
			// txtMaPB
			// 
			this.txtMaPB.Location = new System.Drawing.Point(173, 80);
			this.txtMaPB.Name = "txtMaPB";
			this.txtMaPB.Size = new System.Drawing.Size(375, 22);
			this.txtMaPB.TabIndex = 1;
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(173, 35);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(375, 22);
			this.txtID.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(13, 202);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(79, 25);
			this.label5.TabIndex = 0;
			this.label5.Text = "Ghi chú";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(13, 163);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 25);
			this.label4.TabIndex = 0;
			this.label4.Text = "Địa chỉ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(13, 122);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(147, 25);
			this.label3.TabIndex = 0;
			this.label3.Text = "Tên Phòng ban";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(140, 25);
			this.label2.TabIndex = 0;
			this.label2.Text = "Mã Phòng ban";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(131, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID Phòng ban";
			// 
			// btnReset
			// 
			this.btnReset.BackColor = System.Drawing.Color.Transparent;
			this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
			this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReset.Location = new System.Drawing.Point(82, 31);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(66, 34);
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
			this.btnThem.Location = new System.Drawing.Point(168, 31);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(66, 34);
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
			this.btnSua.Location = new System.Drawing.Point(252, 31);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(67, 34);
			this.btnSua.TabIndex = 2;
			this.btnSua.UseVisualStyleBackColor = false;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.Color.Transparent;
			this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
			this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.Location = new System.Drawing.Point(334, 31);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(69, 34);
			this.btnXoa.TabIndex = 2;
			this.btnXoa.UseVisualStyleBackColor = false;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnTroVe
			// 
			this.btnTroVe.BackColor = System.Drawing.Color.Transparent;
			this.btnTroVe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTroVe.BackgroundImage")));
			this.btnTroVe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnTroVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTroVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTroVe.Location = new System.Drawing.Point(13, 9);
			this.btnTroVe.Name = "btnTroVe";
			this.btnTroVe.Size = new System.Drawing.Size(61, 34);
			this.btnTroVe.TabIndex = 2;
			this.btnTroVe.UseVisualStyleBackColor = false;
			this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Red;
			this.label6.Location = new System.Drawing.Point(227, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(380, 37);
			this.label6.TabIndex = 3;
			this.label6.Text = "QUẢN LÝ PHÒNG BAN";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Location = new System.Drawing.Point(13, 49);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(775, 164);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Danh sách";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.btnXoa);
			this.groupBox2.Controls.Add(this.btnReset);
			this.groupBox2.Controls.Add(this.btnThem);
			this.groupBox2.Controls.Add(this.btnSua);
			this.groupBox2.Location = new System.Drawing.Point(13, 219);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(448, 82);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Chức năng";
			// 
			// ID_PhongBan
			// 
			this.ID_PhongBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ID_PhongBan.DataPropertyName = "ID_PhongBan";
			this.ID_PhongBan.HeaderText = "Id phòng ban";
			this.ID_PhongBan.MinimumWidth = 6;
			this.ID_PhongBan.Name = "ID_PhongBan";
			// 
			// Ma_PhongBan
			// 
			this.Ma_PhongBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Ma_PhongBan.DataPropertyName = "Ma_PhongBan";
			this.Ma_PhongBan.HeaderText = "Mã phòng ban";
			this.Ma_PhongBan.MinimumWidth = 6;
			this.Ma_PhongBan.Name = "Ma_PhongBan";
			// 
			// Ten_PhongBan
			// 
			this.Ten_PhongBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Ten_PhongBan.DataPropertyName = "Ten_PhongBan";
			this.Ten_PhongBan.HeaderText = "Tên phòng ban";
			this.Ten_PhongBan.MinimumWidth = 6;
			this.Ten_PhongBan.Name = "Ten_PhongBan";
			// 
			// Dia_Chi
			// 
			this.Dia_Chi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Dia_Chi.DataPropertyName = "Dia_Chi";
			this.Dia_Chi.HeaderText = "Địa chỉ";
			this.Dia_Chi.MinimumWidth = 6;
			this.Dia_Chi.Name = "Dia_Chi";
			// 
			// Ghi_Chu
			// 
			this.Ghi_Chu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Ghi_Chu.DataPropertyName = "Ghi_Chu";
			this.Ghi_Chu.HeaderText = "Ghi chú";
			this.Ghi_Chu.MinimumWidth = 6;
			this.Ghi_Chu.Name = "Ghi_Chu";
			// 
			// frmPhongBan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 632);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnTroVe);
			this.Controls.Add(this.panel);
			this.Controls.Add(this.dgvPhongBan);
			this.Controls.Add(this.groupBox1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "frmPhongBan";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý phòng ban";
			this.Load += new System.EventHandler(this.frmPhongBan_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).EndInit();
			this.panel.ResumeLayout(false);
			this.panel.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvPhongBan;
		private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.TextBox txtGhiChu;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.TextBox txtTenPB;
		private System.Windows.Forms.TextBox txtMaPB;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnTroVe;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_PhongBan;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ma_PhongBan;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ten_PhongBan;
		private System.Windows.Forms.DataGridViewTextBoxColumn Dia_Chi;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ghi_Chu;
	}
}