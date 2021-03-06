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
	public class EBS03 : EBSForm {
		private AxOWC11.AxSpreadsheet sheet;
		private System.ComponentModel.Container components = null;

		public EBS03() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			ebs = "EBS03";

			DataRow[] descRows = DB.GetDesc(ebs);
			for (int c = 2; c<=43; c+=3) {
				map.Add(c, descRows[0]["c_Id"].ToString());
				map.Add(c+1, descRows[1]["c_Id"].ToString());
				map.Add(c+2, descRows[2]["c_Id"].ToString());
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(EBS03));
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
			this.panelHead.Size = new System.Drawing.Size(736, 24);
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
			this.sheet.Size = new System.Drawing.Size(736, 493);
			this.sheet.TabIndex = 0;
			// 
			// EBS03
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(736, 517);
			this.Controls.Add(this.sheet);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "EBS03";
			this.Text = "EBS03 маягт - Төрөлжсөн болон гүнзгийрүүлсэн сургалтанд хамрагдсан сурагчдын тайл" +
				"ан";
			this.Controls.SetChildIndex(this.panelHead, 0);
			this.Controls.SetChildIndex(this.sheet, 0);
			((System.ComponentModel.ISupportInitialize)(this.sheet)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		public override void ClearContent() {
			sheet.get_Range("C2", "M43").ClearContents();
		}

		public override void LoadData() {
			Cursor.Current = Cursors.WaitCursor;

			try {
				if (DB.dsEbs.Ebs03.Select("c_arcid=" + arcid).Length == 0) {
					DB.LoadEBS(ebs, arcid);

					if (DB.dsEbs.Ebs03.Rows.Count == 0) return;
				}

				foreach (int j in map.Keys) {
					int k = 1;
					for (char i='C'; i<='M'; i++, k++) {
						int lrow = ((j - 2)/3)*3 + 2;
						string lesson = sheet.get_Range("A" + lrow, "A" + lrow).Value2.ToString();
						
						DataRow val = DB.dsEbs.Ebs03.FindByc_ArcIdc_DescIdc_Classc_Lesson(arcid, map[j].ToString(), k, lesson);
						if (val != null) SetValue(sheet, i + "" + j, val["c_Count"]);
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
				int k = 1;
				for (char i='C'; i<='M'; i++, k++) {
					try {
						int lrow = ((j - 2)/3)*3 + 2;
						string lesson = GetValue(sheet, "A" + lrow, "");
						int val = GetValue(sheet, i + "" + j);
						if (val > 0) DB.SaveEBS(arcid, map[j].ToString(), k, lesson, val);
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
