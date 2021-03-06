using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace EBS {
	/// <summary>
	/// Summary description for EBSIND.
	/// </summary>
	public class EBSIND : EBSForm {
		private AxOWC11.AxSpreadsheet sheet;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public EBSIND() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			ebs = "EBSIND";
			DataRow[] descRows = DB.GetDesc(ebs);
			for (int i=0; i<descRows.Length; i++) {
				map.Add(descRows[i]["c_Id"].ToString(), descRows[i]["c_SheetCol"].ToString() + descRows[i]["c_SheetRow"].ToString());
			}
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if(components != null) {
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(EBSIND));
			this.sheet = new AxOWC11.AxSpreadsheet();
			((System.ComponentModel.ISupportInitialize)(this.sheet)).BeginInit();
			this.SuspendLayout();
			// 
			// comboSchool
			// 
			this.comboSchool.Name = "comboSchool";
			this.comboSchool.Size = new System.Drawing.Size(184, 21);
			// 
			// comboYear
			// 
			this.comboYear.Name = "comboYear";
			this.comboYear.Size = new System.Drawing.Size(72, 21);
			// 
			// comboRegion
			// 
			this.comboRegion.Name = "comboRegion";
			this.comboRegion.Size = new System.Drawing.Size(136, 21);
			// 
			// panelHead
			// 
			this.panelHead.Name = "panelHead";
			this.panelHead.Size = new System.Drawing.Size(792, 24);
			// 
			// labelSchool
			// 
			this.labelSchool.Name = "labelSchool";
			// 
			// labelYear
			// 
			this.labelYear.Name = "labelYear";
			// 
			// labelRegion
			// 
			this.labelRegion.Name = "labelRegion";
			// 
			// sheet
			// 
			this.sheet.DataSource = null;
			this.sheet.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sheet.Enabled = true;
			this.sheet.Location = new System.Drawing.Point(0, 0);
			this.sheet.Name = "sheet";
			this.sheet.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("sheet.OcxState")));
			this.sheet.Size = new System.Drawing.Size(792, 493);
			this.sheet.TabIndex = 5;
			this.sheet.Enter += new System.EventHandler(this.sheet_Enter_1);
			// 
			// EBSIND
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(792, 493);
			this.Controls.Add(this.sheet);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "EBSIND";
			this.Text = "EBS Үзүүлэлтүүд";
			this.Controls.SetChildIndex(this.sheet, 0);
			this.Controls.SetChildIndex(this.panelHead, 0);
			((System.ComponentModel.ISupportInitialize)(this.sheet)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		public override void ClearContent() {
			try {
				sheet.get_Range("B3", "I4").ClearContents();
				sheet.get_Range("B7", "C9").ClearContents();
				sheet.get_Range("B12", "C23").ClearContents();
			}
			catch{}
		}

		public override void LoadData() {
			Cursor.Current = Cursors.WaitCursor;

			try {
				if (DB.dsEbs.EbsInd.Select("c_arcid=" + arcid).Length == 0) {
					DB.LoadEBS(ebs, arcid);
				}
			
				foreach (DataRow row in DB.dsEbs.EbsInd.Rows) {
					SetValue(sheet, map[row["c_desc"].ToString()].ToString(), row["c_Value"]);
				}
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
			finally {
				Cursor.Current = Cursors.Default;
			}
		}

		public override void SaveData() {
			Cursor.Current = Cursors.WaitCursor;

			DB.ClearEBS(ebs, arcid);

			foreach (int j in map.Keys) {
				int k = 1;
				for (char i='C'; i<='M' && k <= 11; i++, k++) {
					try {
						int val = GetValue(sheet, i + "" + j);
						if (val > 0) DB.SaveEBS(arcid, map[j].ToString(), k, val);
					}
					catch (Exception ex) {
						MessageBox.Show("Нүд=" + i + j + ":" + ex.Message);
					}
				}
			}

			Cursor.Current = Cursors.Default;
		}

		private void sheet_Enter(object sender, System.EventArgs e) {
		
		}

		private void sheet_Enter_1(object sender, System.EventArgs e) {
		
		}

		
		

		
	}
}
