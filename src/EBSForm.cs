using System;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;

namespace EBS {
	public class EBSForm : Form {
		protected long arcid;
		protected int year, rid, sid;
		protected Hashtable map = new Hashtable();
		protected ComboBox comboSchool;
		protected ComboBox comboYear;
		protected ComboBox comboRegion;
		protected Panel panelHead;
		protected Label labelSchool;
		protected Label labelYear;
		protected Label labelRegion;
		private System.Windows.Forms.PrintPreviewDialog dlgPreview;
		private System.Windows.Forms.Button buttonSchool;
		private System.Drawing.Printing.PrintDocument printDocument;
		private System.Windows.Forms.Label labelArcid;
		protected string ebs;

		public long Arcid {
			get {
				return arcid;
			}
			set {
				arcid = value;

				LoadData();
			}
		}

		public EBSForm() {
			InitializeComponent();

			for (int i=0; i<5; i++) {
				comboYear.Items.Add(Convert.ToString(DateTime.Now.Year - i));
			}
		}

		private void comboRegion_SelectedIndexChanged(object sender, System.EventArgs e) {
			try {
				rid = Convert.ToInt32(comboRegion.SelectedValue);
			}
			catch {
				rid = 0;
			}

			if (comboRegion.SelectedValue.Equals(0)) {
				labelSchool.Visible = false;
				comboSchool.Visible = false;
				buttonSchool.Text = ">>";
			}
			else {
				if (labelSchool.Visible) {
					FillSchool();
				}
			}

			arcid_changed();
		}

		private void buttonSchool_Click(object sender, System.EventArgs e) {
			if (labelSchool.Visible) {
				labelSchool.Visible = false;
				comboSchool.Visible = false;
				buttonSchool.Text = ">>";
				sid = 0;

			}
			else {
				labelSchool.Visible = true;
				comboSchool.Visible = true;
				buttonSchool.Text = "<<";

				FillSchool();

				try {
					sid = Convert.ToInt32(comboSchool.SelectedValue);
				}
				catch {
					sid = 0;
				}
			}

			arcid_changed();
		}

		private void comboSchool_SelectedIndexChanged(object sender, System.EventArgs e) {
			try {
				sid = Convert.ToInt32(comboSchool.SelectedValue);
			}
			catch {
				sid = 0;
			}

			arcid_changed();
		}

		private void comboYear_SelectedIndexChanged(object sender, System.EventArgs e) {
			try {
				year = Convert.ToInt32(comboYear.SelectedItem.ToString());
			}
			catch {
				year = DateTime.Now.Year;
			}

			arcid_changed();
		}

		protected void arcid_changed() {
			arcid = year;
			if (rid > 0)  {
				arcid = arcid*100 + rid;
				if (sid > 0) arcid = arcid*100 + sid;
			}
			
			if (arcid > 0) {
				labelArcid.Text = arcid.ToString();
				// clear
				ClearContent();
				// fill data
				LoadData();
			}
		}

		public virtual void ClearContent() {
		}

		public virtual void NewData() {
			if (MessageBox.Show("Энэ команд нь одоо байгаа өгөгдлийг устгаж доод түвшний нэгжүүдээс\r\nтоон мэдээллийг нийлбэрчлэн үүсгэх болно. Үүсгэх үү?", "EBS", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
				DB.SumEBS(ebs, arcid);

				arcid_changed();
			}
		}


		public virtual void LoadData() {
		}

		public virtual void SaveData() {
		}

		public virtual void DeleteData() {
			ClearContent();
		}

		public string ColNo(int c) {
			c = c - 1;
			int n = c / 26;
			string col = "" + (char)('A' + c % 26);
			if (n > 0) col = (char)('A' + n - 1) + col;

			return col;
		}

		protected void SetValue(AxOWC11.AxSpreadsheet sheet, string cell, object val) {
			sheet.get_Range(cell, cell).Value2 = val;
		}

		protected int GetValue(AxOWC11.AxSpreadsheet sheet, string cell) {
			int val = 0;
			try {
				val = Convert.ToInt32(sheet.get_Range(cell, cell).Value2);
			}
			catch {
				val = 0;
			}

			return val;
		}

		private void comboSchool_DropDown(object sender, System.EventArgs e) {
			
		}

		private void FillSchool() {
			DB.LoadSchool(rid);

			comboSchool.BeginUpdate();
			comboSchool.DataSource = DB.Schools;
			comboSchool.DisplayMember = "c_Name";
			comboSchool.ValueMember = "c_Sid";
			comboSchool.EndUpdate();
		}

		private void comboRegion_DropDown(object sender, System.EventArgs e) {
			if (comboRegion.Items.Count == 0) {
				comboRegion.BeginUpdate();
				comboRegion.DataSource = DB.Regions;
				comboRegion.DisplayMember = "c_Name";
				comboRegion.ValueMember = "c_Rid";
				comboRegion.EndUpdate();
			}
		}

		private void RefreshContent() {
			arcid_changed();
		}


		[System.Runtime.InteropServices.DllImport("gdi32.dll")]
		public static extern long BitBlt (IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);

		private Bitmap memoryImage;

		private void CaptureScreen() {
			Graphics mygraphics = this.CreateGraphics();
			Size s = this.Size;
			memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
			Graphics memoryGraphics = Graphics.FromImage(memoryImage);
			IntPtr dc1 = mygraphics.GetHdc();
			IntPtr dc2 = memoryGraphics.GetHdc();
			BitBlt(dc2, 0, 40, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
			mygraphics.ReleaseHdc(dc1);
			memoryGraphics.ReleaseHdc(dc2);
		}
		
		private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) {
			e.Graphics.DrawImage(memoryImage, 0, 0);
		}

		private void PrintPreview() {
			CaptureScreen();
			dlgPreview.ShowDialog();
		}


		private void keyDown(object sender, KeyEventArgs e) {
			switch (e.KeyData) {
				case Keys.ControlKey | Keys.S: 
					SaveData(); 
					break;
				case Keys.ControlKey | Keys.N:
					NewData();
					break;
				case Keys.ShiftKey | Keys.Delete:
					DeleteData();
					break;
				case Keys.ControlKey | Keys.P:
					PrintPreview();
					break;
				case Keys.F5:
					Refresh();
					break;
			}
		}

		private void InitializeComponent() {
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(EBSForm));
			this.panelHead = new System.Windows.Forms.Panel();
			this.buttonSchool = new System.Windows.Forms.Button();
			this.labelSchool = new System.Windows.Forms.Label();
			this.comboSchool = new System.Windows.Forms.ComboBox();
			this.labelYear = new System.Windows.Forms.Label();
			this.comboYear = new System.Windows.Forms.ComboBox();
			this.labelRegion = new System.Windows.Forms.Label();
			this.comboRegion = new System.Windows.Forms.ComboBox();
			this.dlgPreview = new System.Windows.Forms.PrintPreviewDialog();
			this.printDocument = new System.Drawing.Printing.PrintDocument();
			this.labelArcid = new System.Windows.Forms.Label();
			this.panelHead.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelHead
			// 
			this.panelHead.Controls.Add(this.labelArcid);
			this.panelHead.Controls.Add(this.buttonSchool);
			this.panelHead.Controls.Add(this.labelSchool);
			this.panelHead.Controls.Add(this.comboSchool);
			this.panelHead.Controls.Add(this.labelYear);
			this.panelHead.Controls.Add(this.comboYear);
			this.panelHead.Controls.Add(this.labelRegion);
			this.panelHead.Controls.Add(this.comboRegion);
			this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelHead.Location = new System.Drawing.Point(0, 0);
			this.panelHead.Name = "panelHead";
			this.panelHead.Size = new System.Drawing.Size(688, 24);
			this.panelHead.TabIndex = 4;
			// 
			// buttonSchool
			// 
			this.buttonSchool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSchool.Location = new System.Drawing.Point(189, 1);
			this.buttonSchool.Name = "buttonSchool";
			this.buttonSchool.Size = new System.Drawing.Size(28, 21);
			this.buttonSchool.TabIndex = 8;
			this.buttonSchool.Text = ">>";
			this.buttonSchool.Click += new System.EventHandler(this.buttonSchool_Click);
			// 
			// labelSchool
			// 
			this.labelSchool.Location = new System.Drawing.Point(222, 3);
			this.labelSchool.Name = "labelSchool";
			this.labelSchool.Size = new System.Drawing.Size(56, 13);
			this.labelSchool.TabIndex = 7;
			this.labelSchool.Text = "Сургууль:";
			this.labelSchool.Visible = false;
			// 
			// comboSchool
			// 
			this.comboSchool.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboSchool.Location = new System.Drawing.Point(278, 2);
			this.comboSchool.Name = "comboSchool";
			this.comboSchool.Size = new System.Drawing.Size(184, 21);
			this.comboSchool.TabIndex = 6;
			this.comboSchool.Visible = false;
			this.comboSchool.DropDown += new System.EventHandler(this.comboSchool_DropDown);
			this.comboSchool.SelectedIndexChanged += new System.EventHandler(this.comboSchool_SelectedIndexChanged);
			// 
			// labelYear
			// 
			this.labelYear.Location = new System.Drawing.Point(464, 5);
			this.labelYear.Name = "labelYear";
			this.labelYear.Size = new System.Drawing.Size(24, 13);
			this.labelYear.TabIndex = 5;
			this.labelYear.Text = "Он:";
			// 
			// comboYear
			// 
			this.comboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboYear.Location = new System.Drawing.Point(488, 2);
			this.comboYear.Name = "comboYear";
			this.comboYear.Size = new System.Drawing.Size(72, 21);
			this.comboYear.TabIndex = 4;
			this.comboYear.SelectedIndexChanged += new System.EventHandler(this.comboYear_SelectedIndexChanged);
			// 
			// labelRegion
			// 
			this.labelRegion.Location = new System.Drawing.Point(8, 3);
			this.labelRegion.Name = "labelRegion";
			this.labelRegion.Size = new System.Drawing.Size(40, 13);
			this.labelRegion.TabIndex = 3;
			this.labelRegion.Text = "Аймаг:";
			// 
			// comboRegion
			// 
			this.comboRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboRegion.Location = new System.Drawing.Point(48, 0);
			this.comboRegion.Name = "comboRegion";
			this.comboRegion.Size = new System.Drawing.Size(136, 21);
			this.comboRegion.TabIndex = 1;
			this.comboRegion.DropDown += new System.EventHandler(this.comboRegion_DropDown);
			this.comboRegion.SelectedIndexChanged += new System.EventHandler(this.comboRegion_SelectedIndexChanged);
			// 
			// dlgPreview
			// 
			this.dlgPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.dlgPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.dlgPreview.ClientSize = new System.Drawing.Size(400, 300);
			this.dlgPreview.Document = this.printDocument;
			this.dlgPreview.Enabled = true;
			this.dlgPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("dlgPreview.Icon")));
			this.dlgPreview.Location = new System.Drawing.Point(146, 4);
			this.dlgPreview.MinimumSize = new System.Drawing.Size(375, 250);
			this.dlgPreview.Name = "dlgPreview";
			this.dlgPreview.TransparencyKey = System.Drawing.Color.Empty;
			this.dlgPreview.Visible = false;
			// 
			// printDocument
			// 
			this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
			// 
			// labelArcid
			// 
			this.labelArcid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelArcid.Location = new System.Drawing.Point(600, 4);
			this.labelArcid.Name = "labelArcid";
			this.labelArcid.Size = new System.Drawing.Size(80, 16);
			this.labelArcid.TabIndex = 9;
			// 
			// EBSForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(688, 445);
			this.Controls.Add(this.panelHead);
			this.Name = "EBSForm";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
			this.panelHead.ResumeLayout(false);
			this.ResumeLayout(false);

		}


		protected float GetValue(AxOWC11.AxSpreadsheet sheet, string cell, float defval) {
			float val = defval;
			try {
				val = Convert.ToInt32(sheet.get_Range(cell, cell).Value2);
			}
			catch {
				val = defval;
			}

			return val;
		}

		protected string GetValue(AxOWC11.AxSpreadsheet sheet, string cell, string defval) {
			string val = defval;
			try {
				val = Convert.ToString(sheet.get_Range(cell, cell).Value2);
			}
			catch {
				val = defval;
			}

			return val;
		}
	}

}
