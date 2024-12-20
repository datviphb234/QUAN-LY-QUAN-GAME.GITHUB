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
	public partial class frmNguoiDung : Form
	{
		NguoiDung_DTO currentUser = null;
		May_DTO currentMay = null;
		CultureInfo currentCultureInfo = new CultureInfo("vi-VN");
		DateTime startTime = DateTime.Now;
		SuDung_DTO sd = null;
		double totalMinute = 0;
		int tgConlai = 0;
		double pricePerMinute;
		DichVu_DTO d = null;
		double tongTien = 0;
		Panel currentPanel = null;
		public frmNguoiDung(NguoiDung_DTO item, May_DTO currentMay)
		{
			InitializeComponent();
			currentUser = item;
			this.currentMay = currentMay;
		}

		private void frmNguoiDung_Load(object sender, EventArgs e)
		{
			pricePerMinute = currentMay.GiaTienTrenGio / 60;
			lbSoMay.Text = currentMay.SoMay;
			May_BUS.Instance.turnOn(currentMay.MaMay);
			SuDung_BUS.Instance.add(currentMay.MaMay, currentUser.MaND);
			sd = SuDung_BUS.Instance.getLastItem();
			loadDichVu();
			loadND();
			timerCal.Start();
			txtTongTien.Text = $"0 VND";
		}
		void loadDichVu()
		{
			flpDichVu.Controls.Clear();
			List<DichVu_DTO> listDV = DichVu_BUS.Instance.getAll();
			foreach (var item in listDV)
			{
				Panel pnDV = new Panel();
				pnDV.BorderStyle = BorderStyle.FixedSingle;
				pnDV.Tag = item;
				pnDV.Size = new Size(240, 200);
				pnDV.Click += PnDV_Click;

				Label lblDV = new Label();
				lblDV.Tag = item;
				lblDV.Text = $"{item.TenDV} - {item.Gia.ToString("#,###", currentCultureInfo)} VND";
				lblDV.Size = new Size(240, 50);
				lblDV.TextAlign = ContentAlignment.MiddleCenter;
				lblDV.Dock = DockStyle.Fill;
				pnDV.Controls.Add(lblDV);
				lblDV.Click += LblDV_Click;
				PictureBox picDV = new PictureBox();
				picDV.Tag = item;
				picDV.SizeMode = PictureBoxSizeMode.StretchImage;
				picDV.Size = new Size(240, 150);
				picDV.Dock = DockStyle.Top;
				picDV.Click += PicDV_Click;
				try
				{
					picDV.Image = new Bitmap(item.HinhAnh);
				}
				catch (Exception)
				{
				}
				pnDV.Controls.Add(picDV);

				flpDichVu.Controls.Add(pnDV);
			}
		}

		private void PicDV_Click(object sender, EventArgs e)
		{
			PictureBox pic = sender as PictureBox;
			if (currentPanel != null)
			{
				currentPanel.BorderStyle = BorderStyle.FixedSingle;
			}
			currentPanel = pic.Parent as Panel;
			if (currentPanel != null)
			{
				currentPanel.BorderStyle = BorderStyle.Fixed3D;
			}

			d = pic.Tag as DichVu_DTO;
		}

		private void LblDV_Click(object sender, EventArgs e)
		{
			Label lb = sender as Label;
			if (currentPanel != null)
			{
				currentPanel.BorderStyle = BorderStyle.FixedSingle;
			}
			currentPanel = lb.Parent as Panel;
			if (currentPanel != null)
			{
				currentPanel.BorderStyle = BorderStyle.Fixed3D;
			}
			d = lb.Tag as DichVu_DTO;
		}

		private void PnDV_Click(object sender, EventArgs e)
		{
		}

		void loadND()
		{

			txtTenTK.Text = currentUser.TenTK;
			totalMinute = currentUser.SoTienConLai / pricePerMinute;
			
			string tongTG = string.Format("{0:00}:{1:00}", totalMinute / 60, totalMinute % 60);
			txtTongTG.Text = tongTG;

			TimeSpan timeUsed = DateTime.Now - startTime;
			string tgSuDung = string.Format("{0:00}:{1:00}", timeUsed.Minutes / 60, timeUsed.Minutes % 60);
			txtTGSuDung.Text = tgSuDung;

			tgConlai = Convert.ToInt32(totalMinute - timeUsed.Minutes);
			string tgConLai = string.Format("{0:00}:{1:00}", tgConlai / 60, tgConlai % 60);
			txtTGConLai.Text = tgConLai;
		}
		private void btnLogout_Click(object sender, EventArgs e)
		{
			May_BUS.Instance.turnOff(currentMay.MaMay);
			timerCal.Stop();
			if (!txtTGSuDung.Text.Equals("00:00"))
			{
				NguoiDung_BUS.Instance.dangXuat(currentUser.MaND, tgConlai * pricePerMinute);
			}
			SuDung_BUS.Instance.update(sd.MaSD);
			this.Close();
		}

		private void timerCal_Tick(object sender, EventArgs e)
		{

			TimeSpan timeUsed = DateTime.Now - startTime;
			string tgSuDung = string.Format("{0:00}:{1:00}", timeUsed.Minutes / 60, timeUsed.Minutes % 60);
			txtTGSuDung.Text = tgSuDung;
			tgConlai = Convert.ToInt32(totalMinute - timeUsed.Minutes);
			if (tgConlai <= 0)
			{
				btnLogout_Click(sender, e);
				return;
			}
			string tgConLai = string.Format("{0:00}:{1:00}", tgConlai / 60, tgConlai % 60);
			txtTGConLai.Text = tgConLai;
			if (!txtTGSuDung.Text.Equals("00:00"))
			{
				NguoiDung_BUS.Instance.dangXuat(currentUser.MaND, tgConlai * pricePerMinute);
			}
		}

		private void btnThemMon_Click(object sender, EventArgs e)
		{
			if (d != null)
			{
				bool isFind = false;
				foreach (ListViewItem item in lvMenu.Items)
				{
					if (item.Tag.Equals(d))
					{
						item.SubItems[1].Text = (Convert.ToInt32(item.SubItems[1].Text) + 1).ToString();
						isFind = true;
						item.SubItems[2].Text = $"{(d.Gia * Convert.ToInt32(item.SubItems[1].Text)).ToString("#,###", currentCultureInfo)}";
					}
				}
				if (!isFind)
				{
					ListViewItem item = new ListViewItem(d.TenDV);
					item.Tag = d;
					item.SubItems.Add("1");
					item.SubItems.Add($"{d.Gia.ToString("#,###", currentCultureInfo)}");
					lvMenu.Items.Add(item);
				}

				tongTien += d.Gia;
				txtTongTien.Text = $"{tongTien.ToString("#,###", currentCultureInfo)} VND";
			}
		}

		private void btnDatMon_Click(object sender, EventArgs e)
		{
			if(lvMenu.Items.Count > 0)
			{
				HoaDon_BUS.Instance.add(currentUser.MaND, tongTien);
				HoaDon_DTO _hoaDon = HoaDon_BUS.Instance.getLastHoaDonND(currentUser.MaND);
				if (_hoaDon != null)
				{
					foreach (ListViewItem item in lvMenu.Items)
					{
						DichVu_DTO dv = item.Tag as DichVu_DTO;
						int sl = Convert.ToInt32(item.SubItems[1].Text);
						CTHoaDon_DTO ct = new CTHoaDon_DTO(dv.MaDV, _hoaDon.MaHD, sl, dv.Gia * sl);
						CTHoaDon_BUS.Instance.add(ct);
					}
				}
				lvMenu.Items.Clear();
				tongTien = 0;
				txtTongTien.Text = "0 VND";
			}
		}
	}
}
