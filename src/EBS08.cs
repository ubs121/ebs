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
	public class EBS08 : EBSForm {
		private AxOWC11.AxSpreadsheet sheet;
		private System.ComponentModel.Container components = null;

		public EBS08() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			ebs = "EBS08";

			DataRow[] descRows = DB.GetDesc(ebs);
			for (int i=0; i<descRows.Length; i++) {
				map.Add(Convert.ToInt32(descRows[i]["c_SheetRow"]), descRows[i]["c_Id"].ToString());
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(EBS08));
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
			this.panelHead.Size = new System.Drawing.Size(656, 24);
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
			this.sheet.Size = new System.Drawing.Size(656, 461);
			this.sheet.TabIndex = 0;
			// 
			// EBS08
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(656, 485);
			this.Controls.Add(this.sheet);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "EBS08";
			this.Text = "EBS08 маягт - Үндсэн багш нарын шилжилт хөдөлгөөн";
			this.Controls.SetChildIndex(this.panelHead, 0);
			this.Controls.SetChildIndex(this.sheet, 0);
			((System.ComponentModel.ISupportInitialize)(this.sheet)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		
		public override void ClearContent() {
			sheet.get_Range("B2", "C20").ClearContents();
		}


		public override void LoadData() {
			
			Cursor.Current = Cursors.WaitCursor;

			try {
				if (DB.dsEbs.Ebs08.Select("c_arcid=" + arcid).Length == 0) {
					DB.LoadEBS(ebs, arcid);
					if (DB.dsEbs.Ebs08.Rows.Count == 0) return;
				}
			
				foreach (int j in map.Keys) {
					DataRow val = DB.dsEbs.Ebs08.FindByc_ArcIdc_DescId(arcid, map[j].ToString());
					if (val != null) {
						SetValue(sheet, "B" + j, val["c_Count"]);
						SetValue(sheet, "C" + j, val["c_CountFe"]);
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

			DB.ClearEBS(ebs, arcid);

			foreach (int j in map.Keys) {
				try {
					int val1 = GetValue(sheet, "B" + j);
					int val2 = GetValue(sheet, "C" + j);
					if (val1 > 0 || val2 > 0) DB.SaveEBS(arcid, map[j].ToString(), val1, val2);
				}
				catch (Exception ex) {
					MessageBox.Show(ex.Message);
				}
			}
			
			Cursor.Current = Cursors.Default;
		}
	}
}
