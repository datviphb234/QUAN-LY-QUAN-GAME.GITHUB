namespace QuanLyQuanNet
{
	partial class frmThanhToan
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
			this.dgvHoaDon = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTenNguoiDung = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSoLuong = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTongTien = new System.Windows.Forms.TextBox();
			this.btnThanhToan = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvHoaDon
			// 
			this.dgvHoaDon.AllowUserToResizeColumns = false;
			this.dgvHoaDon.AllowUserToResizeRows = false;
			this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvHoaDon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvHoaDon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
			this.dgvHoaDon.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dgvHoaDon.Location = new System.Drawing.Point(0, 0);
			this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvHoaDon.MultiSelect = false;
			this.dgvHoaDon.Name = "dgvHoaDon";
			this.dgvHoaDon.ReadOnly = true;
			this.dgvHoaDon.RowHeadersWidth = 51;
			this.dgvHoaDon.RowTemplate.Height = 24;
			this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvHoaDon.Size = new System.Drawing.Size(948, 362);
			this.dgvHoaDon.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(37, 398);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(155, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Tên người dùng:";
			// 
			// txtTenNguoiDung
			// 
			this.txtTenNguoiDung.Location = new System.Drawing.Point(231, 400);
			this.txtTenNguoiDung.Name = "txtTenNguoiDung";
			this.txtTenNguoiDung.ReadOnly = true;
			this.txtTenNguoiDung.Size = new System.Drawing.Size(336, 30);
			this.txtTenNguoiDung.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(42, 449);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(143, 25);
			this.label2.TabIndex = 3;
			this.label2.Text = "Tổng số lượng:";
			// 
			// txtSoLuong
			// 
			this.txtSoLuong.Location = new System.Drawing.Point(231, 449);
			this.txtSoLuong.Name = "txtSoLuong";
			this.txtSoLuong.ReadOnly = true;
			this.txtSoLuong.Size = new System.Drawing.Size(336, 30);
			this.txtSoLuong.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(42, 507);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 25);
			this.label3.TabIndex = 3;
			this.label3.Text = "Tổng tiền:";
			// 
			// txtTongTien
			// 
			this.txtTongTien.Location = new System.Drawing.Point(231, 507);
			this.txtTongTien.Name = "txtTongTien";
			this.txtTongTien.ReadOnly = true;
			this.txtTongTien.Size = new System.Drawing.Size(336, 30);
			this.txtTongTien.TabIndex = 4;
			// 
			// btnThanhToan
			// 
			this.btnThanhToan.Location = new System.Drawing.Point(579, 559);
			this.btnThanhToan.Name = "btnThanhToan";
			this.btnThanhToan.Size = new System.Drawing.Size(129, 49);
			this.btnThanhToan.TabIndex = 5;
			this.btnThanhToan.Text = "Thanh toán";
			this.btnThanhToan.UseVisualStyleBackColor = true;
			this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(765, 559);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(129, 49);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Hủy";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// frmThanhToan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(948, 648);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnThanhToan);
			this.Controls.Add(this.txtTongTien);
			this.Controls.Add(this.txtSoLuong);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtTenNguoiDung);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvHoaDon);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmThanhToan";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Thanh toán";
			this.Load += new System.EventHandler(this.frmThanhToan_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvHoaDon;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTenNguoiDung;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSoLuong;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTongTien;
		private System.Windows.Forms.Button btnThanhToan;
		private System.Windows.Forms.Button btnCancel;
	}
}