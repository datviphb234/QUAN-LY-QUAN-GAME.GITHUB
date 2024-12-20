namespace QuanLyQuanNet
{
	partial class frmChuQuan
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageNV = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnCloseNV = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnEditNV = new System.Windows.Forms.Button();
			this.btnReload = new System.Windows.Forms.Button();
			this.btnAddNV = new System.Windows.Forms.Button();
			this.grTextboxNV = new System.Windows.Forms.GroupBox();
			this.txtMatKhau = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtSdt = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTenNV = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMaNV = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvNhanVien = new System.Windows.Forms.DataGridView();
			this.tabPageThongKe = new System.Windows.Forms.TabPage();
			this.panel4 = new System.Windows.Forms.Panel();
			this.txtTongTien = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dgvThongKe = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnThongKe = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.dateTo = new System.Windows.Forms.DateTimePicker();
			this.dateFrom = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPageNV.SuspendLayout();
			this.panel1.SuspendLayout();
			this.grTextboxNV.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
			this.tabPageThongKe.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageNV);
			this.tabControl1.Controls.Add(this.tabPageThongKe);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1174, 770);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPageNV
			// 
			this.tabPageNV.Controls.Add(this.panel1);
			this.tabPageNV.Controls.Add(this.grTextboxNV);
			this.tabPageNV.Controls.Add(this.dgvNhanVien);
			this.tabPageNV.Location = new System.Drawing.Point(4, 34);
			this.tabPageNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageNV.Name = "tabPageNV";
			this.tabPageNV.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageNV.Size = new System.Drawing.Size(1166, 732);
			this.tabPageNV.TabIndex = 0;
			this.tabPageNV.Text = "Quản lý nhân viên";
			this.tabPageNV.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnCloseNV);
			this.panel1.Controls.Add(this.btnDelete);
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Controls.Add(this.btnEditNV);
			this.panel1.Controls.Add(this.btnReload);
			this.panel1.Controls.Add(this.btnAddNV);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(857, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(305, 318);
			this.panel1.TabIndex = 2;
			// 
			// btnCloseNV
			// 
			this.btnCloseNV.AutoSize = true;
			this.btnCloseNV.Location = new System.Drawing.Point(163, 220);
			this.btnCloseNV.Name = "btnCloseNV";
			this.btnCloseNV.Size = new System.Drawing.Size(126, 48);
			this.btnCloseNV.TabIndex = 0;
			this.btnCloseNV.Text = "Đóng";
			this.btnCloseNV.UseVisualStyleBackColor = true;
			this.btnCloseNV.Click += new System.EventHandler(this.btnCloseNV_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.AutoSize = true;
			this.btnDelete.Location = new System.Drawing.Point(20, 220);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(126, 48);
			this.btnDelete.TabIndex = 0;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnSave
			// 
			this.btnSave.AutoSize = true;
			this.btnSave.Location = new System.Drawing.Point(163, 129);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(126, 48);
			this.btnSave.TabIndex = 0;
			this.btnSave.Text = "Lưu";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnEditNV
			// 
			this.btnEditNV.AutoSize = true;
			this.btnEditNV.Location = new System.Drawing.Point(20, 129);
			this.btnEditNV.Name = "btnEditNV";
			this.btnEditNV.Size = new System.Drawing.Size(126, 48);
			this.btnEditNV.TabIndex = 0;
			this.btnEditNV.Text = "Sửa";
			this.btnEditNV.UseVisualStyleBackColor = true;
			this.btnEditNV.Click += new System.EventHandler(this.btnEditNV_Click);
			// 
			// btnReload
			// 
			this.btnReload.AutoSize = true;
			this.btnReload.Location = new System.Drawing.Point(163, 31);
			this.btnReload.Name = "btnReload";
			this.btnReload.Size = new System.Drawing.Size(126, 48);
			this.btnReload.TabIndex = 0;
			this.btnReload.Text = "Làm mới";
			this.btnReload.UseVisualStyleBackColor = true;
			this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
			// 
			// btnAddNV
			// 
			this.btnAddNV.AutoSize = true;
			this.btnAddNV.Location = new System.Drawing.Point(20, 31);
			this.btnAddNV.Name = "btnAddNV";
			this.btnAddNV.Size = new System.Drawing.Size(126, 48);
			this.btnAddNV.TabIndex = 0;
			this.btnAddNV.Text = "Thêm";
			this.btnAddNV.UseVisualStyleBackColor = true;
			this.btnAddNV.Click += new System.EventHandler(this.btnAddNV_Click);
			// 
			// grTextboxNV
			// 
			this.grTextboxNV.Controls.Add(this.txtMatKhau);
			this.grTextboxNV.Controls.Add(this.label8);
			this.grTextboxNV.Controls.Add(this.txtSdt);
			this.grTextboxNV.Controls.Add(this.label4);
			this.grTextboxNV.Controls.Add(this.txtDiaChi);
			this.grTextboxNV.Controls.Add(this.label3);
			this.grTextboxNV.Controls.Add(this.txtTenNV);
			this.grTextboxNV.Controls.Add(this.label2);
			this.grTextboxNV.Controls.Add(this.txtMaNV);
			this.grTextboxNV.Controls.Add(this.label1);
			this.grTextboxNV.Dock = System.Windows.Forms.DockStyle.Left;
			this.grTextboxNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grTextboxNV.Location = new System.Drawing.Point(4, 5);
			this.grTextboxNV.Name = "grTextboxNV";
			this.grTextboxNV.Size = new System.Drawing.Size(853, 318);
			this.grTextboxNV.TabIndex = 1;
			this.grTextboxNV.TabStop = false;
			this.grTextboxNV.Text = "Thông tin nhân viên:";
			// 
			// txtMatKhau
			// 
			this.txtMatKhau.Location = new System.Drawing.Point(214, 260);
			this.txtMatKhau.Name = "txtMatKhau";
			this.txtMatKhau.Size = new System.Drawing.Size(469, 34);
			this.txtMatKhau.TabIndex = 3;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(29, 260);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(115, 29);
			this.label8.TabIndex = 0;
			this.label8.Text = "Mật khẩu:";
			// 
			// txtSdt
			// 
			this.txtSdt.Location = new System.Drawing.Point(214, 210);
			this.txtSdt.Name = "txtSdt";
			this.txtSdt.Size = new System.Drawing.Size(469, 34);
			this.txtSdt.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(29, 215);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(160, 29);
			this.label4.TabIndex = 0;
			this.label4.Text = "Số điện thoại:";
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Location = new System.Drawing.Point(214, 154);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(469, 34);
			this.txtDiaChi.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(29, 159);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 29);
			this.label3.TabIndex = 0;
			this.label3.Text = "Địa chỉ:";
			// 
			// txtTenNV
			// 
			this.txtTenNV.Location = new System.Drawing.Point(214, 99);
			this.txtTenNV.Name = "txtTenNV";
			this.txtTenNV.Size = new System.Drawing.Size(469, 34);
			this.txtTenNV.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(170, 29);
			this.label2.TabIndex = 0;
			this.label2.Text = "Tên nhân viên:";
			// 
			// txtMaNV
			// 
			this.txtMaNV.Location = new System.Drawing.Point(214, 45);
			this.txtMaNV.Name = "txtMaNV";
			this.txtMaNV.Size = new System.Drawing.Size(469, 34);
			this.txtMaNV.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã nhân viên:";
			// 
			// dgvNhanVien
			// 
			this.dgvNhanVien.AllowUserToResizeColumns = false;
			this.dgvNhanVien.AllowUserToResizeRows = false;
			this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvNhanVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvNhanVien.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dgvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dgvNhanVien.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dgvNhanVien.Location = new System.Drawing.Point(4, 323);
			this.dgvNhanVien.Name = "dgvNhanVien";
			this.dgvNhanVien.ReadOnly = true;
			this.dgvNhanVien.RowHeadersWidth = 51;
			this.dgvNhanVien.RowTemplate.Height = 24;
			this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvNhanVien.Size = new System.Drawing.Size(1158, 404);
			this.dgvNhanVien.TabIndex = 0;
			this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
			// 
			// tabPageThongKe
			// 
			this.tabPageThongKe.Controls.Add(this.panel4);
			this.tabPageThongKe.Controls.Add(this.panel3);
			this.tabPageThongKe.Controls.Add(this.panel2);
			this.tabPageThongKe.Location = new System.Drawing.Point(4, 34);
			this.tabPageThongKe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageThongKe.Name = "tabPageThongKe";
			this.tabPageThongKe.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tabPageThongKe.Size = new System.Drawing.Size(1166, 732);
			this.tabPageThongKe.TabIndex = 1;
			this.tabPageThongKe.Text = "Thống kê";
			this.tabPageThongKe.UseVisualStyleBackColor = true;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.txtTongTien);
			this.panel4.Controls.Add(this.label7);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(4, 614);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1158, 113);
			this.panel4.TabIndex = 2;
			// 
			// txtTongTien
			// 
			this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTongTien.Location = new System.Drawing.Point(849, 34);
			this.txtTongTien.Name = "txtTongTien";
			this.txtTongTien.Size = new System.Drawing.Size(297, 36);
			this.txtTongTien.TabIndex = 1;
			this.txtTongTien.Text = "0 VND";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(716, 39);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(127, 31);
			this.label7.TabIndex = 0;
			this.label7.Text = "Tổng tiền:";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.dgvThongKe);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(4, 95);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1158, 519);
			this.panel3.TabIndex = 1;
			// 
			// dgvThongKe
			// 
			this.dgvThongKe.AllowUserToResizeColumns = false;
			this.dgvThongKe.AllowUserToResizeRows = false;
			this.dgvThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvThongKe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvThongKe.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvThongKe.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dgvThongKe.Location = new System.Drawing.Point(0, 0);
			this.dgvThongKe.Name = "dgvThongKe";
			this.dgvThongKe.ReadOnly = true;
			this.dgvThongKe.RowHeadersWidth = 51;
			this.dgvThongKe.RowTemplate.Height = 24;
			this.dgvThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvThongKe.Size = new System.Drawing.Size(1158, 519);
			this.dgvThongKe.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnThongKe);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.dateTo);
			this.panel2.Controls.Add(this.dateFrom);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(4, 5);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1158, 90);
			this.panel2.TabIndex = 0;
			// 
			// btnThongKe
			// 
			this.btnThongKe.Location = new System.Drawing.Point(485, 25);
			this.btnThongKe.Name = "btnThongKe";
			this.btnThongKe.Size = new System.Drawing.Size(146, 41);
			this.btnThongKe.TabIndex = 3;
			this.btnThongKe.Text = "Thống kê";
			this.btnThongKe.UseVisualStyleBackColor = true;
			this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(689, 33);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 25);
			this.label6.TabIndex = 2;
			this.label6.Text = "Đến";
			// 
			// dateTo
			// 
			this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTo.Location = new System.Drawing.Point(759, 28);
			this.dateTo.Name = "dateTo";
			this.dateTo.Size = new System.Drawing.Size(150, 30);
			this.dateTo.TabIndex = 1;
			// 
			// dateFrom
			// 
			this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateFrom.Location = new System.Drawing.Point(263, 28);
			this.dateFrom.Name = "dateFrom";
			this.dateFrom.Size = new System.Drawing.Size(150, 30);
			this.dateFrom.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(179, 33);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(36, 25);
			this.label5.TabIndex = 0;
			this.label5.Text = "Từ";
			// 
			// frmChuQuan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1174, 770);
			this.Controls.Add(this.tabControl1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmChuQuan";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Chủ quán";
			this.Load += new System.EventHandler(this.frmChuQuan_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPageNV.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.grTextboxNV.ResumeLayout(false);
			this.grTextboxNV.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
			this.tabPageThongKe.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageNV;
		private System.Windows.Forms.TabPage tabPageThongKe;
		private System.Windows.Forms.DataGridView dgvNhanVien;
		private System.Windows.Forms.GroupBox grTextboxNV;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTenNV;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtMaNV;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSdt;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnAddNV;
		private System.Windows.Forms.Button btnCloseNV;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnEditNV;
		private System.Windows.Forms.Button btnReload;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnThongKe;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dateTo;
		private System.Windows.Forms.DateTimePicker dateFrom;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView dgvThongKe;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtTongTien;
		private System.Windows.Forms.TextBox txtMatKhau;
		private System.Windows.Forms.Label label8;
	}
}