namespace QuanLyQuanNet
{
	partial class frmLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.radioChuQuan = new System.Windows.Forms.RadioButton();
			this.radioNhanVien = new System.Windows.Forms.RadioButton();
			this.radioNguoiDung = new System.Windows.Forms.RadioButton();
			this.btnThoát = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(599, 493);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.panel1.Controls.Add(this.radioChuQuan);
			this.panel1.Controls.Add(this.radioNhanVien);
			this.panel1.Controls.Add(this.radioNguoiDung);
			this.panel1.Controls.Add(this.btnThoát);
			this.panel1.Controls.Add(this.btnLogin);
			this.panel1.Controls.Add(this.txtPassword);
			this.panel1.Controls.Add(this.txtUsername);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(599, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(517, 493);
			this.panel1.TabIndex = 1;
			// 
			// radioChuQuan
			// 
			this.radioChuQuan.AutoSize = true;
			this.radioChuQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioChuQuan.Location = new System.Drawing.Point(339, 158);
			this.radioChuQuan.Name = "radioChuQuan";
			this.radioChuQuan.Size = new System.Drawing.Size(119, 29);
			this.radioChuQuan.TabIndex = 4;
			this.radioChuQuan.TabStop = true;
			this.radioChuQuan.Text = "Chủ quán";
			this.radioChuQuan.UseVisualStyleBackColor = true;
			// 
			// radioNhanVien
			// 
			this.radioNhanVien.AutoSize = true;
			this.radioNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioNhanVien.Location = new System.Drawing.Point(184, 158);
			this.radioNhanVien.Name = "radioNhanVien";
			this.radioNhanVien.Size = new System.Drawing.Size(121, 29);
			this.radioNhanVien.TabIndex = 4;
			this.radioNhanVien.TabStop = true;
			this.radioNhanVien.Text = "Nhân viên";
			this.radioNhanVien.UseVisualStyleBackColor = true;
			// 
			// radioNguoiDung
			// 
			this.radioNguoiDung.AutoSize = true;
			this.radioNguoiDung.Checked = true;
			this.radioNguoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.radioNguoiDung.Location = new System.Drawing.Point(34, 158);
			this.radioNguoiDung.Name = "radioNguoiDung";
			this.radioNguoiDung.Size = new System.Drawing.Size(133, 29);
			this.radioNguoiDung.TabIndex = 4;
			this.radioNguoiDung.TabStop = true;
			this.radioNguoiDung.Text = "Người dùng";
			this.radioNguoiDung.UseVisualStyleBackColor = true;
			// 
			// btnThoát
			// 
			this.btnThoát.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnThoát.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.btnThoát.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
			this.btnThoát.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnThoát.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoát.Location = new System.Drawing.Point(274, 389);
			this.btnThoát.Name = "btnThoát";
			this.btnThoát.Size = new System.Drawing.Size(160, 56);
			this.btnThoát.TabIndex = 3;
			this.btnThoát.Text = "Thoát";
			this.btnThoát.UseVisualStyleBackColor = true;
			this.btnThoát.Click += new System.EventHandler(this.btnThoát_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
			this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.Location = new System.Drawing.Point(67, 389);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(160, 56);
			this.btnLogin.TabIndex = 3;
			this.btnLogin.Text = "Đăng nhập";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(231, 305);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(241, 36);
			this.txtPassword.TabIndex = 1;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// txtUsername
			// 
			this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsername.Location = new System.Drawing.Point(231, 240);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(241, 36);
			this.txtUsername.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(29, 312);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(115, 29);
			this.label3.TabIndex = 1;
			this.label3.Text = "Mật khẩu:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(29, 247);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(164, 29);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên tài khoản:";
			this.label2.DoubleClick += new System.EventHandler(this.label2_DoubleClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.label1.Location = new System.Drawing.Point(126, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(222, 48);
			this.label1.TabIndex = 0;
			this.label1.Text = "Đăng nhập";
			// 
			// frmLogin
			// 
			this.AcceptButton = this.btnLogin;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.ClientSize = new System.Drawing.Size(1116, 493);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.frmLogin_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnThoát;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.RadioButton radioNguoiDung;
		private System.Windows.Forms.RadioButton radioChuQuan;
		private System.Windows.Forms.RadioButton radioNhanVien;
	}
}

