namespace QuanLyQuanNet
{
	partial class frmNguoiDung
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnDatMon = new System.Windows.Forms.Button();
			this.txtTongTien = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtTGConLai = new System.Windows.Forms.TextBox();
			this.txtTongTG = new System.Windows.Forms.TextBox();
			this.txtTGSuDung = new System.Windows.Forms.TextBox();
			this.txtTenTK = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnThemMon = new System.Windows.Forms.Button();
			this.btnLogout = new System.Windows.Forms.Button();
			this.flpDichVu = new System.Windows.Forms.FlowLayoutPanel();
			this.timerCal = new System.Windows.Forms.Timer(this.components);
			this.lbSoMay = new System.Windows.Forms.Label();
			this.lvMenu = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.lvMenu);
			this.panel1.Controls.Add(this.btnDatMon);
			this.panel1.Controls.Add(this.txtTongTien);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.btnThemMon);
			this.panel1.Controls.Add(this.btnLogout);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(824, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(389, 775);
			this.panel1.TabIndex = 0;
			// 
			// btnDatMon
			// 
			this.btnDatMon.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnDatMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDatMon.Location = new System.Drawing.Point(222, 717);
			this.btnDatMon.Name = "btnDatMon";
			this.btnDatMon.Size = new System.Drawing.Size(154, 45);
			this.btnDatMon.TabIndex = 7;
			this.btnDatMon.Text = "Đặt món";
			this.btnDatMon.UseVisualStyleBackColor = false;
			this.btnDatMon.Click += new System.EventHandler(this.btnDatMon_Click);
			// 
			// txtTongTien
			// 
			this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTongTien.Location = new System.Drawing.Point(33, 681);
			this.txtTongTien.Name = "txtTongTien";
			this.txtTongTien.ReadOnly = true;
			this.txtTongTien.Size = new System.Drawing.Size(341, 30);
			this.txtTongTien.TabIndex = 6;
			this.txtTongTien.Text = "78,000 VND";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(28, 653);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 25);
			this.label2.TabIndex = 5;
			this.label2.Text = "Tổng tiền:";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel2.Controls.Add(this.lbSoMay);
			this.panel2.Controls.Add(this.txtTGConLai);
			this.panel2.Controls.Add(this.txtTongTG);
			this.panel2.Controls.Add(this.txtTGSuDung);
			this.panel2.Controls.Add(this.txtTenTK);
			this.panel2.Controls.Add(this.label14);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(385, 213);
			this.panel2.TabIndex = 3;
			// 
			// txtTGConLai
			// 
			this.txtTGConLai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTGConLai.Location = new System.Drawing.Point(217, 180);
			this.txtTGConLai.Name = "txtTGConLai";
			this.txtTGConLai.ReadOnly = true;
			this.txtTGConLai.Size = new System.Drawing.Size(154, 30);
			this.txtTGConLai.TabIndex = 7;
			this.txtTGConLai.Text = "05:35";
			// 
			// txtTongTG
			// 
			this.txtTongTG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTongTG.Location = new System.Drawing.Point(217, 108);
			this.txtTongTG.Name = "txtTongTG";
			this.txtTongTG.ReadOnly = true;
			this.txtTongTG.Size = new System.Drawing.Size(154, 30);
			this.txtTongTG.TabIndex = 8;
			this.txtTongTG.Text = "00:35";
			// 
			// txtTGSuDung
			// 
			this.txtTGSuDung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTGSuDung.Location = new System.Drawing.Point(217, 144);
			this.txtTGSuDung.Name = "txtTGSuDung";
			this.txtTGSuDung.ReadOnly = true;
			this.txtTGSuDung.Size = new System.Drawing.Size(154, 30);
			this.txtTGSuDung.TabIndex = 8;
			this.txtTGSuDung.Text = "00:35";
			// 
			// txtTenTK
			// 
			this.txtTenTK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTenTK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.txtTenTK.Location = new System.Drawing.Point(217, 72);
			this.txtTenTK.Name = "txtTenTK";
			this.txtTenTK.ReadOnly = true;
			this.txtTenTK.Size = new System.Drawing.Size(154, 30);
			this.txtTenTK.TabIndex = 9;
			this.txtTenTK.Text = "ABC";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(14, 111);
			this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(142, 25);
			this.label14.TabIndex = 5;
			this.label14.Text = "Tổng thời gian:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(14, 183);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(160, 25);
			this.label5.TabIndex = 4;
			this.label5.Text = "Thời gian còn lại:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(14, 147);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(174, 25);
			this.label3.TabIndex = 5;
			this.label3.Text = "Thời gian sử dụng:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(14, 77);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(137, 25);
			this.label1.TabIndex = 6;
			this.label1.Text = "Tên tài khoản:";
			// 
			// btnThemMon
			// 
			this.btnThemMon.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnThemMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThemMon.Location = new System.Drawing.Point(19, 271);
			this.btnThemMon.Name = "btnThemMon";
			this.btnThemMon.Size = new System.Drawing.Size(140, 59);
			this.btnThemMon.TabIndex = 2;
			this.btnThemMon.Text = "Thêm món";
			this.btnThemMon.UseVisualStyleBackColor = false;
			this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
			// 
			// btnLogout
			// 
			this.btnLogout.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogout.Location = new System.Drawing.Point(220, 271);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(154, 59);
			this.btnLogout.TabIndex = 2;
			this.btnLogout.Text = "Đăng xuất";
			this.btnLogout.UseVisualStyleBackColor = false;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// flpDichVu
			// 
			this.flpDichVu.AutoScroll = true;
			this.flpDichVu.Location = new System.Drawing.Point(13, 13);
			this.flpDichVu.Margin = new System.Windows.Forms.Padding(16);
			this.flpDichVu.Name = "flpDichVu";
			this.flpDichVu.Padding = new System.Windows.Forms.Padding(8);
			this.flpDichVu.Size = new System.Drawing.Size(780, 750);
			this.flpDichVu.TabIndex = 1;
			// 
			// timerCal
			// 
			this.timerCal.Interval = 1000;
			this.timerCal.Tick += new System.EventHandler(this.timerCal_Tick);
			// 
			// lbSoMay
			// 
			this.lbSoMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbSoMay.ForeColor = System.Drawing.Color.Navy;
			this.lbSoMay.Location = new System.Drawing.Point(91, 19);
			this.lbSoMay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbSoMay.Name = "lbSoMay";
			this.lbSoMay.Size = new System.Drawing.Size(207, 39);
			this.lbSoMay.TabIndex = 10;
			this.lbSoMay.Text = "Máy số";
			this.lbSoMay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lvMenu
			// 
			this.lvMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.lvMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lvMenu.GridLines = true;
			this.lvMenu.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvMenu.Location = new System.Drawing.Point(22, 349);
			this.lvMenu.MultiSelect = false;
			this.lvMenu.Name = "lvMenu";
			this.lvMenu.Size = new System.Drawing.Size(352, 301);
			this.lvMenu.TabIndex = 8;
			this.lvMenu.UseCompatibleStateImageBehavior = false;
			this.lvMenu.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Tên món";
			this.columnHeader1.Width = 150;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Số lượng";
			this.columnHeader2.Width = 80;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Thành tiền";
			this.columnHeader3.Width = 100;
			// 
			// frmNguoiDung
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1213, 775);
			this.Controls.Add(this.flpDichVu);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmNguoiDung";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmNguoiDung";
			this.Load += new System.EventHandler(this.frmNguoiDung_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtTGConLai;
		private System.Windows.Forms.TextBox txtTGSuDung;
		private System.Windows.Forms.TextBox txtTenTK;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.FlowLayoutPanel flpDichVu;
		private System.Windows.Forms.Button btnThemMon;
		private System.Windows.Forms.Button btnDatMon;
		private System.Windows.Forms.TextBox txtTongTien;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTongTG;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Timer timerCal;
		private System.Windows.Forms.Label lbSoMay;
		private System.Windows.Forms.ListView lvMenu;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
	}
}