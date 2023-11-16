namespace BaoCao_QLNhanVien
{
	partial class FrmTrangChu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrangChu));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuChucVu = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuPhongBan = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuDuAn = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuQLHS = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuHSNV = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuQLHT = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuQLTK = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuThoat = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.SkyBlue;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuDanhMuc,
            this.toolStripMenuQLHS,
            this.toolStripMenuQLHT,
            this.toolStripMenuThoat});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(900, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenuDanhMuc
			// 
			this.toolStripMenuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuChucVu,
            this.toolStripMenuPhongBan,
            this.toolStripMenuDuAn});
			this.toolStripMenuDanhMuc.ForeColor = System.Drawing.SystemColors.ControlText;
			this.toolStripMenuDanhMuc.Name = "toolStripMenuDanhMuc";
			this.toolStripMenuDanhMuc.Size = new System.Drawing.Size(90, 24);
			this.toolStripMenuDanhMuc.Text = "Danh mục";
			// 
			// toolStripMenuChucVu
			// 
			this.toolStripMenuChucVu.Name = "toolStripMenuChucVu";
			this.toolStripMenuChucVu.Size = new System.Drawing.Size(163, 26);
			this.toolStripMenuChucVu.Text = "Chức vụ";
			this.toolStripMenuChucVu.Click += new System.EventHandler(this.toolStripMenuChucVu_Click);
			// 
			// toolStripMenuPhongBan
			// 
			this.toolStripMenuPhongBan.Name = "toolStripMenuPhongBan";
			this.toolStripMenuPhongBan.Size = new System.Drawing.Size(163, 26);
			this.toolStripMenuPhongBan.Text = "Phòng Ban";
			this.toolStripMenuPhongBan.Click += new System.EventHandler(this.toolStripMenuPhongBan_Click);
			// 
			// toolStripMenuDuAn
			// 
			this.toolStripMenuDuAn.Name = "toolStripMenuDuAn";
			this.toolStripMenuDuAn.Size = new System.Drawing.Size(163, 26);
			this.toolStripMenuDuAn.Text = "Dự Án";
			this.toolStripMenuDuAn.Click += new System.EventHandler(this.toolStripMenuDuAn_Click);
			// 
			// toolStripMenuQLHS
			// 
			this.toolStripMenuQLHS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuHSNV});
			this.toolStripMenuQLHS.Name = "toolStripMenuQLHS";
			this.toolStripMenuQLHS.Size = new System.Drawing.Size(113, 24);
			this.toolStripMenuQLHS.Text = "Quản lý hồ sơ";
			// 
			// toolStripMenuHSNV
			// 
			this.toolStripMenuHSNV.Name = "toolStripMenuHSNV";
			this.toolStripMenuHSNV.Size = new System.Drawing.Size(224, 26);
			this.toolStripMenuHSNV.Text = "Hồ sơ nhân viên";
			this.toolStripMenuHSNV.Click += new System.EventHandler(this.toolStripMenuHSNV_Click);
			// 
			// toolStripMenuQLHT
			// 
			this.toolStripMenuQLHT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuQLTK});
			this.toolStripMenuQLHT.Name = "toolStripMenuQLHT";
			this.toolStripMenuQLHT.Size = new System.Drawing.Size(136, 24);
			this.toolStripMenuQLHT.Text = "Quản lý hệ thống";
			// 
			// toolStripMenuQLTK
			// 
			this.toolStripMenuQLTK.Name = "toolStripMenuQLTK";
			this.toolStripMenuQLTK.Size = new System.Drawing.Size(224, 26);
			this.toolStripMenuQLTK.Text = "Quản lý tài khoản";
			this.toolStripMenuQLTK.Click += new System.EventHandler(this.toolStripMenuQLTK_Click);
			// 
			// toolStripMenuThoat
			// 
			this.toolStripMenuThoat.Name = "toolStripMenuThoat";
			this.toolStripMenuThoat.Size = new System.Drawing.Size(61, 24);
			this.toolStripMenuThoat.Text = "Thoát";
			this.toolStripMenuThoat.Click += new System.EventHandler(this.toolStripMenuThoat_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(204, 112);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(511, 47);
			this.label1.TabIndex = 1;
			this.label1.Text = "PHẦN MỀM QUẢN LÝ NHÂN SỰ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Palace Script MT", 19F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(424, 172);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(291, 30);
			this.label2.TabIndex = 2;
			this.label2.Text = "Design by Nguyen Bach Doan";
			// 
			// FrmTrangChu
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(900, 506);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FrmTrangChu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý nhân sự";
			this.Load += new System.EventHandler(this.FrmTrangChu_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuDanhMuc;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuChucVu;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuPhongBan;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuDuAn;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuQLHS;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuQLHT;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuThoat;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuHSNV;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuQLTK;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

