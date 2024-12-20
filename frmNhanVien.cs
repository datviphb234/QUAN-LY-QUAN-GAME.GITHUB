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
using static System.Net.Mime.MediaTypeNames;

namespace QuanLyQuanNet
{
	public partial class frmNhanVien : Form
	{
		bool addDv = false;
		bool addND = false;

		NhanVien_DTO currentNV = null;
		public frmNhanVien(NhanVien_DTO currentNV)
		{
			InitializeComponent();
			this.currentNV = currentNV;
		}
		private void label10_Click(object sender, EventArgs e)
		{

		}

		private void frmNhanVien_Load(object sender, EventArgs e)
		{
			loadMay();
			loadDichVu();
			tabControl1.SelectedIndex = 0;
			txtMaDV.Enabled = false;
			txtMaND.Enabled = false;

			loadND();
		}
		void loadDichVu()
		{
			resetTextboxDichVu();
			turnOffDichVu();

			List<DichVu_DTO> list = DichVu_BUS.Instance.getAll();
			dgvDichVu.DataSource = list;
		}
		private void btnSearchMay_Click(object sender, EventArgs e)
		{
			List<May_DTO> listMay = May_BUS.Instance.getMayAvailable();
			dgvMay.DataSource = listMay;
		}
		void resetTextboxDichVu()
		{
			txtMaDV.ResetText();
			txtTenDV.ResetText();
			txtImgDV.ResetText();
			nmrGiaDV.Value = 1;
		}
		void turnOffDichVu()
		{
			btnSaveDV.Enabled = false;
			btnEditDV.Enabled = false;
			btnDeleteDV.Enabled = false;

			btnAddDV.Enabled = true;
			grDV.Enabled = false;
		}
		void turnOnDichVu()
		{
			btnSaveDV.Enabled = true;
			grDV.Enabled = true;


			btnAddDV.Enabled = false;
			btnEditDV.Enabled = false;
			btnDeleteDV.Enabled = false;
		}
		void resetTextboxMay()
		{
			txtMaMay.ResetText();
			txtSoMay.ResetText();
			nmrPriceMay.Value = 1;
		}
		void loadMay()
		{
			resetTextboxMay();
			grMay.Enabled = false;
			btnTurnOnMay.Enabled = false;
			btnTurnOff.Enabled = false;
			List<May_DTO> listMay = May_BUS.Instance.getAll();
			dgvMay.DataSource = listMay;
		}
		private void btnReloadMay_Click(object sender, EventArgs e)
		{
			loadMay();
		}

		private void dgvMay_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int r = dgvMay.CurrentCell.RowIndex;
			txtMaMay.Text = dgvMay.Rows[r].Cells[0].Value.ToString();
			txtSoMay.Text = dgvMay.Rows[r].Cells[1].Value.ToString();
			nmrPriceMay.Value = Convert.ToDecimal(dgvMay.Rows[r].Cells[2].Value.ToString());
			if (!Convert.ToBoolean(dgvMay.Rows[r].Cells[3].Value.ToString()))
			{
				radioAvailable.Checked = true;
			}
			else
			{
				radioOccupie.Checked = true;
			}
			btnTurnOnMay.Enabled = true;
			btnTurnOff.Enabled = true;
		}

		private void btnTurnOnMay_Click(object sender, EventArgs e)
		{
			if (radioAvailable.Checked)
			{
				int id = Convert.ToInt32(txtMaMay.Text);
				try
				{
					May_BUS.Instance.turnOn(id);
					List<May_DTO> listMay = May_BUS.Instance.getAll();
					dgvMay.DataSource = listMay;
					radioOccupie.Checked = true;
				}
				catch (Exception)
				{
				}

			}
		}

		private void btnTurnOff_Click(object sender, EventArgs e)
		{
			if (radioOccupie.Checked)
			{
				int id = Convert.ToInt32(txtMaMay.Text);
				try
				{
					May_BUS.Instance.turnOff(id);
					List<May_DTO> listMay = May_BUS.Instance.getAll();
					dgvMay.DataSource = listMay;
					radioAvailable.Checked = true;
				}
				catch (Exception)
				{
				}

			}
		}

		private void btnCloseDV_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnAddDV_Click(object sender, EventArgs e)
		{
			addDv = true;
			turnOnDichVu();

			resetTextboxDichVu();
			txtTenDV.Focus();

		}

		private void btnEditDV_Click(object sender, EventArgs e)
		{
			addDv = false;

			turnOnDichVu();
			txtTenDV.Focus();
		}

		private void btnRealoadDv_Click(object sender, EventArgs e)
		{
			addDv = false;

			loadDichVu();
		}

		private void btnSaveDV_Click(object sender, EventArgs e)
		{
			try
			{
				if (addDv)
				{
					string TenDV = txtTenDV.Text;
					double Gia = Convert.ToDouble(nmrGiaDV.Value);
					string HinhAnh = txtImgDV.Text;

					DichVu_DTO item = new DichVu_DTO(TenDV, Gia, HinhAnh);
					try
					{
						DichVu_BUS.Instance.add(item);
						MessageBox.Show("Thêm dịch vụ thành công");
						loadDichVu();
					}
					catch (Exception)
					{
					}
				}
				else
				{
					int MaDV = Convert.ToInt32(txtMaDV.Text);
					string TenDV = txtTenDV.Text;
					double Gia = Convert.ToDouble(nmrGiaDV.Value);
					string HinhAnh = txtImgDV.Text;

					DichVu_DTO item = new DichVu_DTO(MaDV, TenDV, Gia, HinhAnh);
					try
					{
						DichVu_BUS.Instance.update(item);
						MessageBox.Show("Thay đổi thông tin thành công");
						loadDichVu();
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnChooseImgDV_Click(object sender, EventArgs e)
		{
			// open file dialog 
			using (OpenFileDialog open = new OpenFileDialog())
			{
				// image filters  
				open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
				if (open.ShowDialog() == DialogResult.OK)
				{
					// display image in picture box

					picDV.Image = new Bitmap(open.FileName);
					txtImgDV.Text = open.FileName;
				}
			}
		}

		private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int r = dgvDichVu.CurrentCell.RowIndex;
			txtMaDV.Text = dgvDichVu.Rows[r].Cells[0].Value.ToString();
			txtTenDV.Text = dgvDichVu.Rows[r].Cells[1].Value.ToString();

			nmrGiaDV.Value = Convert.ToDecimal(dgvDichVu.Rows[r].Cells[2].Value);
			txtImgDV.Text = dgvDichVu.Rows[r].Cells[3].Value.ToString();
			try
			{
				picDV.Image = new Bitmap(txtImgDV.Text);
			}
			catch (Exception)
			{
				picDV.Image = null;
			}

			btnEditDV.Enabled = true;
			btnDeleteDV.Enabled = true;
		}

		private void btnDeleteDV_Click(object sender, EventArgs e)
		{
			if (!txtMaDV.Text.Trim().Equals(""))
			{
				if (MessageBox.Show("Bạn có muốn xóa dịch vụ này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					try
					{
						int id = Convert.ToInt32(txtMaDV.Text);
						DichVu_BUS.Instance.delete(id);
						loadDichVu();
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				MessageBox.Show("Vui lòng chọn dịch vụ muốn xóa");
			}
		}
		void resetTextboxND()
		{
			txtMaND.ResetText();
			txtTenTK.ResetText();
			nmrSoTienND.Value = 1;
			txtMatKhauND.ResetText();
		}

		void loadND()
		{
			resetTextboxND();
			grTextboxND.Enabled = false;
			btnSave.Enabled = false;
			addND = false;
			dgvNguoiDung.DataSource = NguoiDung_BUS.Instance.GetAll();

		}
		private void btnAddND_Click(object sender, EventArgs e)
		{
			addND = true;
			grTextboxND.Enabled = true;
			resetTextboxND();
			txtTenTK.Focus();
			btnAddDV.Enabled = false;
			btnSave.Enabled = true;
		}

		private void btnReload_Click(object sender, EventArgs e)
		{
			loadND();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				string TenTK = txtTenTK.Text;
				if (NguoiDung_BUS.Instance.checkDuplicateTaiKhoan(TenTK))
				{
					MessageBox.Show("Tên tài khoản đã tồn tại");
					return;
				}
				string MatKhau = txtMatKhauND.Text;
				double sotien = Convert.ToDouble(nmrSoTienND.Value);

				NguoiDung_DTO item = new NguoiDung_DTO(TenTK, MatKhau, sotien);
				NguoiDung_BUS.Instance.Add(item);
				loadND();
			}
			catch (Exception)
			{
			}
		}

		private void dgvNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int r = dgvNguoiDung.CurrentCell.RowIndex;

			txtMaND.Text = dgvNguoiDung.Rows[r].Cells[0].Value.ToString();
			txtTenTK.Text = dgvNguoiDung.Rows[r].Cells[1].Value.ToString();
			txtMatKhauND.Text = dgvNguoiDung.Rows[r].Cells[2].Value.ToString();
			nmrSoTienND.Value = Convert.ToDecimal(dgvNguoiDung.Rows[r].Cells[3].Value);
		}

		private void btnNapTien_Click(object sender, EventArgs e)
		{
			if (txtMaND.Text.Trim().Equals(""))
			{
				MessageBox.Show("Vui lòng chọn người dùng");
				return;
			}
			using(Form f = new Form())
			{
				f.Text = "Nạp tiền";
				f.FormBorderStyle = FormBorderStyle.FixedDialog;
				f.MaximizeBox = false;
				f.MinimizeBox = false;
				f.StartPosition = FormStartPosition.CenterScreen;

				Label lbTienNap = new Label();
				lbTienNap.Text = "Số tiền nạp:";
				lbTienNap.Location = new Point(10, 15);
				lbTienNap.AutoSize = true;


				NumericUpDown nmrTienNap = new NumericUpDown();
				nmrTienNap.Maximum = 100000000;
				nmrTienNap.Minimum = 0;
				nmrTienNap.Width = 200;
				nmrTienNap.Location = new Point(120, 10);



				Button btnNapTien = new Button();
				btnNapTien.Text = "Nạp tiền";
				btnNapTien.DialogResult = DialogResult.OK;
				btnNapTien.Location = new Point(335, 8);
				btnNapTien.Width = 75;
					
				Button btnCancel = new Button();
				btnCancel.Text = "Hủy";
				btnCancel.DialogResult = DialogResult.Cancel;
				btnCancel.Location = new Point(335, 38);
				btnCancel.Width = 75;

				f.AcceptButton = btnNapTien;
				f.CancelButton = btnCancel;
				f.ClientSize = new Size(420, 75);
				f.Controls.Add(lbTienNap);
				f.Controls.Add(nmrTienNap);
				f.Controls.Add(btnNapTien);
				f.Controls.Add(btnCancel);

				DialogResult result = f.ShowDialog(this);
				if (result == DialogResult.OK)
				{
					double tien = Convert.ToDouble(nmrTienNap.Value);
					int maND = Convert.ToInt32(txtMaND.Text);
					NguoiDung_BUS.Instance.napTien(maND, tien);
					loadND();
				}
			}
		}

		private void btnThanhToan_Click(object sender, EventArgs e)
		{
			if (txtMaND.Text.Trim().Equals(""))
			{
				MessageBox.Show("Vui lòng chọn người dùng để thanh toán");
				return;
			}
			List<HoaDon_DTO> listHd = HoaDon_BUS.Instance.getHDChuaThanhToan(Convert.ToInt32(txtMaND.Text));
			int MaND = Convert.ToInt32(txtMaND.Text);
			string tenTK = txtTenTK.Text;
			NguoiDung_DTO user = new NguoiDung_DTO(MaND, tenTK);
			frmThanhToan thanhToan = new frmThanhToan(listHd, user, currentNV);
			thanhToan.ShowDialog();
		}
	}
}
