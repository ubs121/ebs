using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace EBS {
	/// <summary>
	/// Summary description for EBS01.
	/// </summary>
	public class EBS09 : EBSForm {
		private AxOWC11.AxSpreadsheet sheet;
		private System.ComponentModel.Container components = null;

		public EBS09() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            ebs = "EBS09";

			DataRow[] descRows = DB.GetDesc(ebs);
			for (int i=0; i<descRows.Length; i++) {
				map.Add(descRows[i]["c_SheetCol"].ToString(), descRows[i]["c_Id"].ToString());
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(EBS09));
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
			this.panelHead.Size = new System.Drawing.Size(664, 24);
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
			this.sheet.Location = new System.Drawing.Point(0, 24);
			this.sheet.Name = "sheet";
			this.sheet.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("sheet.OcxState")));
			this.sheet.Size = new System.Drawing.Size(664, 477);
			this.sheet.TabIndex = 0;
			// 
			// EBS09
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(664, 501);
			this.Controls.Add(this.sheet);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "EBS09";
			this.Text = "EBS09 маягт - Ажиллагчдын тайлан";
			this.Controls.SetChildIndex(this.panelHead, 0);
			this.Controls.SetChildIndex(this.sheet, 0);
			((System.ComponentModel.ISupportInitialize)(this.sheet)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		public override void ClearContent() {
			sheet.get_Range("B3", "G32").ClearContents();
		}

		public override void LoadData() {
			
			Cursor.Current = Cursors.WaitCursor;

			try {
				if (DB.dsEbs.Ebs09.Select("c_arcid=" + arcid).Length == 0) {
					DB.LoadEBS(ebs, arcid);
					if (DB.dsEbs.Ebs09.Rows.Count == 0) return;
				}
			}
			catch (Exception ex) {
				MessageBox.Show("Өгөгдөл ачаалах үеийн алдаа: " + ex.Message);
			}
			
			foreach (string i in map.Keys) {
				for (int j=3; j<=32; j++) {
					try {
						string staff = GetValue(sheet, "A" + j, "");
						DataRow val = DB.dsEbs.Ebs09.FindByc_ArcIdc_DescIdc_Staff(arcid, map[i].ToString(), staff);
						if (val != null) SetValue(sheet, i + j, val["c_Count"]);
					}
					catch (Exception ex) {
						MessageBox.Show("Нүд=" + i + j + ":" + ex.Message);
					}
				}
			}
			
			Cursor.Current = Cursors.Default;
		}

		public override void SaveData() {
			
			Cursor.Current = Cursors.WaitCursor;

			DB.ClearEBS(ebs, arcid);

			foreach (string i in map.Keys) {
				for (int j=3; j<=32; j++) {
					try {
						string staff = GetValue(sheet, "A" + j, "");
						int val = GetValue(sheet, i + j);
						if (val > 0) DB.SaveEBS(arcid, map[i].ToString(), staff, val);
					}
					catch (Exception ex) {
						MessageBox.Show("Нүд=" + i + j + ":" + ex.Message);
					}
				}
			}
			
			Cursor.Current = Cursors.Default;
		}
	}
}
