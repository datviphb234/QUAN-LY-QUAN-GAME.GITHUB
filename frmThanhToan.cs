using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using BUS;

namespace QuanLyQuanNet
{
	public partial class frmThanhToan : Form
	{
		List<HoaDon_DTO> listHD = null;
		NguoiDung_DTO user = null;
		NhanVien_DTO empl = null;
		CultureInfo culture = new CultureInfo("vi-VN");
		public frmThanhToan(List<HoaDon_DTO> hoaDon_DTOs,NguoiDung_DTO user, NhanVien_DTO empl)
		{
			InitializeComponent();
			this.user = user;
			this.listHD = hoaDon_DTOs;
			dgvHoaDon.DataSource = listHD;
			txtTenNguoiDung.Text = user.TenTK;
			this.empl = empl;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnThanhToan_Click(object sender, EventArgs e)
		{
			foreach (var item in listHD)
			{
				HoaDon_BUS.Instance.ThanhToan(item.MaHD, empl.MaNV);
			}
			this.Close();
		}

		private void frmThanhToan_Load(object sender, EventArgs e)
		{
			double sumAmount = 0;
			foreach (var item in listHD)
			{
				sumAmount += item.TongTien;
			}
			txtSoLuong.Text = listHD.Count.ToString();
			txtTongTien.Text = sumAmount.ToString("#,###", culture);
		}
	}
}
