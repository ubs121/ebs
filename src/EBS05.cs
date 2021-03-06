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
	public class EBS05 : EBSForm {
		private AxOWC11.AxSpreadsheet sheet;
		private System.ComponentModel.Container components = null;

		public EBS05() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			ebs = "EBS05";

			DataRow[] descRows = DB.GetDesc(ebs);
			int k = 1, c = 2; // col='B'
			for (; k<=11; k++) {
				for (int i=0; i<6 && i < descRows.Length; i++, c++) {
					map.Add(ColNo(c), descRows[i]["c_Id"].ToString());
				}
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(EBS05));
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
			this.panelHead.Size = new System.Drawing.Size(760, 24);
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
			this.sheet.Size = new System.Drawing.Size(760, 493);
			this.sheet.TabIndex = 0;
			// 
			// EBS05
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(760, 517);
			this.Controls.Add(this.sheet);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "EBS05";
			this.Text = "EBS05 маягт - Сурлагын дүнгийн тайлан";
			this.Controls.SetChildIndex(this.panelHead, 0);
			this.Controls.SetChildIndex(this.sheet, 0);
			((System.ComponentModel.ISupportInitialize)(this.sheet)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		public override void ClearContent() {
			sheet.get_Range("B3", "BN24").ClearContents();
		}

		public override void LoadData() {
			Cursor.Current = Cursors.WaitCursor;

			try {
				if (DB.dsEbs.Ebs05.Select("c_arcid=" + arcid).Length == 0) {
					DB.LoadEBS(ebs, arcid);

					if (DB.dsEbs.Ebs05.Rows.Count == 0) return;
				}

				string col = "";
				
				for (int j=3; j<=24; j++) {
					string lesson = GetValue(sheet, "A" + j, "");

					for (int k=1; k<=11; k++) {
						for (int i=0; i<6; i++) {
							col = ColNo((k-1)*6 + i + 2);
							DataRow val = DB.dsEbs.Ebs05.FindByc_ArcIdc_DescIdc_Classc_Lesson(arcid, map[col].ToString(), k, lesson);
							if (val != null) SetValue(sheet, col + j, val["c_Count"]);
						}
					}
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

			try {
				DB.ClearEBS(ebs, arcid);

				for (int j=3; j<=24; j++) {
					string lesson = GetValue(sheet, "A" + j, "");

					for (int k=1; k<=11; k++) {
						for (int i=0; i<6; i++) {
							string col = ColNo((k-1)*6 + i + 2);
							int val = GetValue(sheet, col + j);
							if (val > 0) DB.SaveEBS(arcid, map[col].ToString(), k, lesson, val);
						}
					}
				}
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
			finally {
				Cursor.Current = Cursors.Default;
			}
		}

	}
}
