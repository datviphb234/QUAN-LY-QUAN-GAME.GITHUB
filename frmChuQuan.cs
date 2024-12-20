using BUS;
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

namespace QuanLyQuanNet
{
	public partial class frmChuQuan : Form
	{
		bool add = false;
		double tongTien = 0;
		CultureInfo culture = new CultureInfo("vi-VN");
		public frmChuQuan()
		{
			InitializeComponent();
		}
		void resetTextbox()
		{
			txtMaNV.ResetText();
			txtTenNV.ResetText();
			txtDiaChi.ResetText();
			txtSdt.ResetText();
			txtMatKhau.ResetText();
		}

		void turnOff()
		{
			btnEditNV.Enabled = false;
			btnSave.Enabled = false;
			btnDelete.Enabled = false;

			btnAddNV.Enabled = true;
			grTextboxNV.Enabled = false;

		}

		void turnOn()
		{
			btnEditNV.Enabled = false;
			btnAddNV.Enabled = false;

			btnSave.Enabled = true;
			btnDelete.Enabled = false;

			grTextboxNV.Enabled = true;
		}
		void load()
		{
			turnOff();
			resetTextbox();
			dgvNhanVien.DataSource = NhanVien_BUS.Instance.getAll();
		}
		private void frmChuQuan_Load(object sender, EventArgs e)
		{
			txtMaNV.Enabled = false;
			load();
			loadThongKe();
		}

		void loadThongKe()
		{
			List<HoaDon_DTO> list = HoaDon_BUS.Instance.getAll();
			dgvThongKe.DataSource = list;
			foreach (var item in list)
			{
				tongTien += item.TongTien;
			}
			txtTongTien.Text = tongTien.ToString("#,###", culture);
		}
		private void btnCloseNV_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnAddNV_Click(object sender, EventArgs e)
		{
			add = true;
			turnOn();
			resetTextbox();
			txtTenNV.Focus();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (add)
			{
				try
				{
					string HoTen = txtTenNV.Text;
					string DiaChi = txtDiaChi.Text;
					string SDT = txtSdt.Text;
					string MatKhau = txtMatKhau.Text;
					NhanVien_DTO item = new NhanVien_DTO(HoTen, DiaChi, SDT, MatKhau);
					NhanVien_BUS.Instance.add(item);
					load();
				}
				catch (Exception)
				{
				}
			}
			else
			{
				try
				{
					int MaNV = Convert.ToInt32(txtMaNV.Text);
					string HoTen = txtTenNV.Text;
					string DiaChi = txtDiaChi.Text;
					string SDT = txtSdt.Text;
					string MatKhau = txtMatKhau.Text;
					NhanVien_DTO item = new NhanVien_DTO(MaNV, HoTen, DiaChi, SDT, 2, MatKhau);
					NhanVien_BUS.Instance.update(item);
					load();
				}
				catch (Exception)
				{
				}
			}
		}

		private void btnEditNV_Click(object sender, EventArgs e)
		{
			add = false;
			turnOn();
			txtTenNV.Focus();
		}

		private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int r = dgvNhanVien.CurrentCell.RowIndex;
			txtMaNV.Text = dgvNhanVien.Rows[r].Cells[0].Value.ToString();
			txtTenNV.Text = dgvNhanVien.Rows[r].Cells[1].Value.ToString();
			txtDiaChi.Text = dgvNhanVien.Rows[r].Cells[2].Value.ToString();
			txtSdt.Text = dgvNhanVien.Rows[r].Cells[3].Value.ToString();
			txtMatKhau.Text = dgvNhanVien.Rows[r].Cells[5].Value.ToString();

			btnEditNV.Enabled = true;
			btnDelete.Enabled = true;
		}

		private void btnReload_Click(object sender, EventArgs e)
		{
			load();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				if (MessageBox.Show("Bạn có muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				{
					int MaNV = Convert.ToInt32(txtMaNV.Text);
					NhanVien_BUS.Instance.delete(MaNV);
					load();
				}
			}
			catch (Exception)
			{
			}

		}

		private void btnThongKe_Click(object sender, EventArgs e)
		{
			tongTien = 0;
			List<HoaDon_DTO> list = HoaDon_BUS.Instance.ThongKe(dateFrom.Value, dateTo.Value);
			dgvThongKe.DataSource = list;
			foreach (var item in list)
			{
				tongTien += item.TongTien;
			}
			txtTongTien.Text = tongTien.ToString("#,###", culture);
		}
	}
}
