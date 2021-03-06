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
	public class EBS07 : EBSForm {
		private AxOWC11.AxSpreadsheet sheet;
		private System.ComponentModel.Container components = null;

		public EBS07() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			ebs = "EBS07";
			
			DataRow[] descRows = DB.GetDesc(ebs + "_");
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(EBS07));
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
			this.sheet.Size = new System.Drawing.Size(768, 485);
			this.sheet.TabIndex = 0;
			this.sheet.Enter += new System.EventHandler(this.sheet_Enter);
			// 
			// EBS07
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(768, 509);
			this.Controls.Add(this.sheet);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "EBS07";
			this.Text = " EBS07 маягт - Багшлах боловсон хүчний тайлан";
			this.Controls.SetChildIndex(this.panelHead, 0);
			this.Controls.SetChildIndex(this.sheet, 0);
			((System.ComponentModel.ISupportInitialize)(this.sheet)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void sheet_Enter(object sender, System.EventArgs e) {
		
		}

		public override void ClearContent() {
			sheet.get_Range("B3", "AC29").ClearContents();
		}

		public override void LoadData() {
			Cursor.Current = Cursors.WaitCursor;

			try {
				if (DB.dsEbs.Ebs07.Select("c_arcid=" + arcid).Length == 0) {
					DB.LoadEBS(ebs, arcid);

					if (DB.dsEbs.Ebs07.Rows.Count == 0) return;
				}
			
				for (int j=3; j<=29; j++) {
					string prof = GetValue(sheet, "A" + j, "");
					foreach (string i in map.Keys) {
						DataRow val = DB.dsEbs.Ebs07.FindByc_ArcIdc_DescIdc_Prof(arcid, map[i].ToString(), prof);
						if (val != null) SetValue(sheet, i + j, val["c_Count"]);
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

			foreach (string i in map.Keys) {
				for (int j=3; j<=29; j++) {
					try {
						string prof = GetValue(sheet, "A" + j, "");
						int val = GetValue(sheet, i + j);
						if (val > 0) DB.SaveEBS(arcid, map[i].ToString(), prof, val);
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
