using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanNet
{
	public partial class frmLogin : Form
	{
		public frmLogin()
		{
			InitializeComponent();
		}

		private void frmLogin_Load(object sender, EventArgs e)
		{

		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string username = txtUsername.Text;
			string password = txtPassword.Text;
			bool checkLogin = false;
			if (radioNguoiDung.Checked)
			{
				var item = NguoiDung_BUS.Instance.checkLogin(username, password);
				checkLogin = true;
				if (item != null)
				{
					frmChonMay frmChonMay = new frmChonMay(item);
					frmChonMay.Show();
				}
			}
			else
			{
				int role = radioChuQuan.Checked ? 1 : 2;   // role = 1: la chu quan, role = 2 la nhan vien
				NhanVien_DTO item = NhanVien_BUS.Instance.checkLogin(username, password, role);
				if (item != null)
				{
					checkLogin = true;
					if (role == 1)
					{
						frmChuQuan frmChuQuan = new frmChuQuan();
						frmChuQuan.Show();
					}
					else
					{
						frmNhanVien frmNhan = new frmNhanVien(item);
						frmNhan.Show();
					}
				}
			}

			if (!checkLogin)
			{
				MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
			}
		}

		private void btnThoát_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void label2_DoubleClick(object sender, EventArgs e)
		{
		}
	}
}
