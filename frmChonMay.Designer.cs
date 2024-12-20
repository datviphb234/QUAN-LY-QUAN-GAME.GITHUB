namespace QuanLyQuanNet
{
	partial class frmChonMay
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
			this.flComputer = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// flComputer
			// 
			this.flComputer.AutoScroll = true;
			this.flComputer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flComputer.Location = new System.Drawing.Point(0, 0);
			this.flComputer.Margin = new System.Windows.Forms.Padding(8);
			this.flComputer.Name = "flComputer";
			this.flComputer.Padding = new System.Windows.Forms.Padding(12);
			this.flComputer.Size = new System.Drawing.Size(1187, 715);
			this.flComputer.TabIndex = 0;
			// 
			// frmChonMay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1187, 715);
			this.Controls.Add(this.flComputer);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "frmChonMay";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmChonMay";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmChonMay_FormClosed);
			this.Load += new System.EventHandler(this.frmChonMay_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flComputer;
	}
}