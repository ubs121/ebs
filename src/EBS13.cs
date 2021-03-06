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
	public class EBS13 : EBSForm {
		private AxOWC11.AxSpreadsheet sheet;
		private System.ComponentModel.Container components = null;

		public EBS13() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			ebs = "EBS13";

			DataRow[] descRows = DB.GetDesc(ebs);
			int k = 1, c = 2; // col='B'
			for (; k<=10; k++) {
				for (int i=0; i<5 && i < descRows.Length; i++, c++) {
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(EBS13));
			this.sheet = new AxOWC11.AxSpreadsheet();
			((System.ComponentModel.ISupportInitialize)(this.sheet)).BeginInit();
			this.SuspendLayout();
			
			// 
			// sheet
			// 
			this.sheet.DataSource = null;
			this.sheet.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sheet.Enabled = true;
			this.sheet.Location = new System.Drawing.Point(0, 24);
			this.sheet.Name = "sheet";
			this.sheet.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("sheet.OcxState")));
			this.sheet.Size = new System.Drawing.Size(680, 493);
			this.sheet.TabIndex = 0;
			// 
			// EBS13
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(680, 517);
			this.Controls.Add(this.sheet);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "EBS13";
			this.Text = "EBS13 маягт - Үндсэн сурах бичгийн хүрэлцээ, хангамжийн тайлан";
			this.Controls.SetChildIndex(this.panelHead, 0);
			this.Controls.SetChildIndex(this.sheet, 0);
			((System.ComponentModel.ISupportInitialize)(this.sheet)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		public override void ClearContent() {
			sheet.get_Range("B4", "AY23").ClearContents();
		}

		public override void LoadData() {
			
			Cursor.Current = Cursors.WaitCursor;

			try {
				if (DB.dsEbs.Ebs13.Select("c_arcid=" + arcid).Length == 0) {
					DB.LoadEBS(ebs, arcid);

					if (DB.dsEbs.Ebs13.Rows.Count == 0) return;
				}

				for (int j=4; j<=23; j++) {
					string lesson = GetValue(sheet, "A" + j, "");
					for (int k=1; k<=10; k++) {
						for (int i=0; i<5; i++) {
							string col = ColNo((k-1)*5 + i + 2);
							DataRow val = DB.dsEbs.Ebs13.FindByc_ArcIdc_DescIdc_Classc_Lesson(arcid, map[col].ToString(), k, lesson);
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

				for (int j=4; j<=23; j++) {
					string lesson = GetValue(sheet, "A" + j, "");
					for (int k=1; k<=10; k++) {
						for (int i=0; i<5; i++) {
							string col = ColNo((k-1)*5 + i + 2);
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
