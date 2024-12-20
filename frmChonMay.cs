using BUS;
using DTO;
using QuanLyQuanNet.Properties;
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
	public partial class frmChonMay : Form
	{
		NguoiDung_DTO currentUser=null;
		CultureInfo currentCulture = new CultureInfo("vi-VN");
		public frmChonMay(NguoiDung_DTO item)
		{
			InitializeComponent();
			currentUser = item;
		}


		void load()
		{
			List<May_DTO> list = May_BUS.Instance.getMayAvailable();
			foreach (May_DTO item in list)
			{
				Panel panel = new Panel();
				panel.Width = 375;
				panel.Height = 255;
				panel.BorderStyle = BorderStyle.FixedSingle;
				Label lbl = new Label();
				lbl.Tag = item;
				PictureBox pictureBox = new PictureBox();
				panel.Controls.Add(lbl);
				panel.Controls.Add(pictureBox);


				pictureBox.Size = new System.Drawing.Size(375, 195);
				pictureBox.Dock = DockStyle.Top;
				pictureBox.Tag = item;
				try
				{
					pictureBox.Image = Image.FromFile("../../images/computer.png");
				}
				catch (Exception)
				{
					pictureBox.Image = pictureBox.ErrorImage;
				}
				pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

				lbl.Text = $"{item.SoMay} - {item.GiaTienTrenGio.ToString("#,###", currentCulture)} VND";
				lbl.Size = new System.Drawing.Size(375, 58);
				lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
				lbl.Dock = DockStyle.Fill;
				panel.Tag = item;

				flComputer.Controls.Add(panel);

				panel.DoubleClick += Panel_DoubleClick;
				pictureBox.DoubleClick += PictureBox_DoubleClick;
				lbl.DoubleClick += Lbl_DoubleClick;
			}
		}

		private void Lbl_DoubleClick(object sender, EventArgs e)
		{
			Label panel = sender as Label;
			May_DTO item = panel.Tag as May_DTO;
			int totalMinute = (int)(currentUser.SoTienConLai / (item.GiaTienTrenGio / 60));
			if (totalMinute <= 0)
			{
				MessageBox.Show("Hết tiền. Vui lòng nạp thêm tiền để chơi!");
			}
			else
			{
				frmNguoiDung frmNguoiDung = new frmNguoiDung(currentUser, item);
				frmNguoiDung.Show();
				this.Close();
			}
		}

		private void PictureBox_DoubleClick(object sender, EventArgs e)
		{
			PictureBox panel = sender as PictureBox;
			May_DTO item = panel.Tag as May_DTO;

			int totalMinute = (int)(currentUser.SoTienConLai / (item.GiaTienTrenGio / 60));
			if (totalMinute <= 0)
			{
				MessageBox.Show("Hết tiền. Vui lòng nạp thêm tiền để chơi!");
			}
			else
			{
				frmNguoiDung frmNguoiDung = new frmNguoiDung(currentUser, item);
				frmNguoiDung.Show();
				this.Close();
			}
		}

		private void Panel_DoubleClick(object sender, EventArgs e)
		{
			Panel panel = sender as Panel;
			May_DTO item = panel.Tag as May_DTO;

			int totalMinute = (int)(currentUser.SoTienConLai / (item.GiaTienTrenGio / 60));
			if(totalMinute <= 0)
			{
				MessageBox.Show("Hết tiền. Vui lòng nạp thêm tiền để chơi!");
			}
			else
			{
				frmNguoiDung frmNguoiDung = new frmNguoiDung(currentUser, item);
				frmNguoiDung.Show();
				this.Close();
			}
		}

		private void FlComputer_DoubleClick(object sender, EventArgs e)
		{
			
		}

		private void frmChonMay_Load(object sender, EventArgs e)
		{
			load();
		}

		private void frmChonMay_FormClosed(object sender, FormClosedEventArgs e)
		{

		}
	}
}
