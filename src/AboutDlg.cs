using System;
using System.Windows.Forms;

namespace EBS {
	public class AboutDlg : Form {
		internal System.ComponentModel.Container components = null;
		private System.Windows.Forms.TextBox textAbout;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button buttonOk;

		public AboutDlg() : base() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
		
		protected  override void  Dispose(bool disposing) {
			base.Dispose(true);
			if (disposing)
				if (components != null)
					components.Dispose();
		}
				
		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>

		private void  InitializeComponent() {
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AboutDlg));
			this.buttonOk = new System.Windows.Forms.Button();
			this.textAbout = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// buttonOk
			// 
			this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOk.Location = new System.Drawing.Point(344, 192);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(76, 23);
			this.buttonOk.TabIndex = 0;
			this.buttonOk.Text = "OK";
			// 
			// textAbout
			// 
			this.textAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.textAbout.BackColor = System.Drawing.Color.Gainsboro;
			this.textAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textAbout.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textAbout.ForeColor = System.Drawing.SystemColors.WindowText;
			this.textAbout.Location = new System.Drawing.Point(64, 8);
			this.textAbout.Multiline = true;
			this.textAbout.Name = "textAbout";
			this.textAbout.ReadOnly = true;
			this.textAbout.Size = new System.Drawing.Size(368, 168);
			this.textAbout.TabIndex = 1;
			this.textAbout.Text = "Энэ програм нь ЕБС-н статистик судалгаа, үнэлгээнд \r\nзориулагдаж БСШУЯ-ны захиалг" +
				"аар бүтээгдсэн.\r\n\r\n(c) УБИС.Сүлжээ, Мэдээллийн Системийн тэнхэм. \r\nХувилбар 2.0." +
				"  \r\n2002 он.\r\n\r\nЗохиогчид: С.Ууганбаяр, Ч.Долгоржав, И.Цэрэн-Онолт.";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(8, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(32, 32);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// AboutDlg
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.Gainsboro;
			this.ClientSize = new System.Drawing.Size(442, 223);
			this.ControlBox = false;
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.textAbout);
			this.Controls.Add(this.buttonOk);
			this.ForeColor = System.Drawing.SystemColors.WindowText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutDlg";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About EBS";
			this.ResumeLayout(false);

		}

		#endregion
	}
}