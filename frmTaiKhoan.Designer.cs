namespace BaoCao_QLNhanVien
{
	partial class frmTaiKhoan
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaiKhoan));
			this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cbLoaiTK = new System.Windows.Forms.ComboBox();
			this.txtMK = new System.Windows.Forms.TextBox();
			this.txtTK = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnTroVe = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.Ten_TKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Mat_Khau = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Loai_TKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvTaiKhoan
			// 
			this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ten_TKhoan,
            this.Mat_Khau,
            this.Loai_TKhoan});
			this.dgvTaiKhoan.Location = new System.Drawing.Point(30, 33);
			this.dgvTaiKhoan.Name = "dgvTaiKhoan";
			this.dgvTaiKhoan.RowHeadersWidth = 51;
			this.dgvTaiKhoan.RowTemplate.Height = 24;
			this.dgvTaiKhoan.Size = new System.Drawing.Size(680, 169);
			this.dgvTaiKhoan.TabIndex = 0;
			this.dgvTaiKhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellContentClick);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.cbLoaiTK);
			this.panel1.Controls.Add(this.txtMK);
			this.panel1.Controls.Add(this.txtTK);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(27, 393);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(744, 159);
			this.panel1.TabIndex = 1;
			// 
			// cbLoaiTK
			// 
			this.cbLoaiTK.FormattingEnabled = true;
			this.cbLoaiTK.Items.AddRange(new object[] {
            "Admin",
            "User"});
			this.cbLoaiTK.Location = new System.Drawing.Point(195, 99);
			this.cbLoaiTK.Name = "cbLoaiTK";
			this.cbLoaiTK.Size = new System.Drawing.Size(281, 24);
			this.cbLoaiTK.TabIndex = 2;
			// 
			// txtMK
			// 
			this.txtMK.Location = new System.Drawing.Point(195, 64);
			this.txtMK.Name = "txtMK";
			this.txtMK.Size = new System.Drawing.Size(281, 22);
			this.txtMK.TabIndex = 1;
			// 
			// txtTK
			// 
			this.txtTK.Location = new System.Drawing.Point(195, 29);
			this.txtTK.Name = "txtTK";
			this.txtTK.Size = new System.Drawing.Size(281, 22);
			this.txtTK.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(25, 98);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(133, 25);
			this.label3.TabIndex = 0;
			this.label3.Text = "Loại tài khoản";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(25, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 25);
			this.label2.TabIndex = 0;
			this.label2.Text = "Mật khẩu";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(25, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tài khoản";
			// 
			// btnReset
			// 
			this.btnReset.BackColor = System.Drawing.Color.Transparent;
			this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
			this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReset.Location = new System.Drawing.Point(17, 32);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(64, 35);
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
			this.btnThem.Location = new System.Drawing.Point(96, 32);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(62, 35);
			this.btnThem.TabIndex = 2;
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.Color.Transparent;
			this.btnXoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.BackgroundImage")));
			this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.Location = new System.Drawing.Point(174, 32);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(62, 35);
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
			this.btnTroVe.Location = new System.Drawing.Point(12, 9);
			this.btnTroVe.Name = "btnTroVe";
			this.btnTroVe.Size = new System.Drawing.Size(62, 35);
			this.btnTroVe.TabIndex = 2;
			this.btnTroVe.UseVisualStyleBackColor = false;
			this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(239, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(360, 37);
			this.label4.TabIndex = 3;
			this.label4.Text = "QUẢN LÝ TÀI KHOẢN";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.dgvTaiKhoan);
			this.groupBox1.Location = new System.Drawing.Point(27, 53);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(744, 224);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Danh sách";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.btnReset);
			this.groupBox2.Controls.Add(this.btnThem);
			this.groupBox2.Controls.Add(this.btnXoa);
			this.groupBox2.Location = new System.Drawing.Point(27, 284);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(283, 88);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Chức năng";
			// 
			// Ten_TKhoan
			// 
			this.Ten_TKhoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Ten_TKhoan.DataPropertyName = "Ten_TKhoan";
			this.Ten_TKhoan.HeaderText = "Tên tài khoản";
			this.Ten_TKhoan.MinimumWidth = 6;
			this.Ten_TKhoan.Name = "Ten_TKhoan";
			// 
			// Mat_Khau
			// 
			this.Mat_Khau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Mat_Khau.DataPropertyName = "Mat_Khau";
			this.Mat_Khau.HeaderText = "Mật khẩu";
			this.Mat_Khau.MinimumWidth = 6;
			this.Mat_Khau.Name = "Mat_Khau";
			// 
			// Loai_TKhoan
			// 
			this.Loai_TKhoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Loai_TKhoan.DataPropertyName = "Loai_TKhoan";
			this.Loai_TKhoan.HeaderText = "Loại tài khoản";
			this.Loai_TKhoan.MinimumWidth = 6;
			this.Loai_TKhoan.Name = "Loai_TKhoan";
			// 
			// frmTaiKhoan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 581);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnTroVe);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "frmTaiKhoan";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý tài khoản";
			this.Load += new System.EventHandler(this.frmTaiKhoan_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvTaiKhoan;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtMK;
		private System.Windows.Forms.TextBox txtTK;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnTroVe;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cbLoaiTK;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ten_TKhoan;
		private System.Windows.Forms.DataGridViewTextBoxColumn Mat_Khau;
		private System.Windows.Forms.DataGridViewTextBoxColumn Loai_TKhoan;
	}
}