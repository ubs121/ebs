using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace EBS {
	/// <summary>
	/// Summary description for MapReport.
	/// </summary>
	public class MapReport : Form {
		private PictureBox pictureBox1;
		private Panel panelHead;
		private Label label2;
		private ComboBox comboYear;
		private Label label1;
		private ComboBox comboRegion;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MapReport() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			for (int i=0; i<5; i++) {
				comboYear.Items.Add(Convert.ToString(DateTime.Now.Year-i));
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MapReport));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panelHead = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.comboYear = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comboRegion = new System.Windows.Forms.ComboBox();
			this.panelHead.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 24);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(728, 469);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panelHead.Controls.Add(this.label2);
			this.panelHead.Controls.Add(this.comboYear);
			this.panelHead.Controls.Add(this.label1);
			this.panelHead.Controls.Add(this.comboRegion);
			this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelHead.Location = new System.Drawing.Point(0, 0);
			this.panelHead.Name = "panel1";
			this.panelHead.Size = new System.Drawing.Size(728, 24);
			this.panelHead.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(328, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(24, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Он:";
			// 
			// comboYear
			// 
			this.comboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboYear.Location = new System.Drawing.Point(360, 2);
			this.comboYear.Name = "comboYear";
			this.comboYear.Size = new System.Drawing.Size(96, 21);
			this.comboYear.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Үзүүлэлт:";
			// 
			// comboRegion
			// 
			this.comboRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboRegion.Items.AddRange(new object[] {
															 "Материаллаг бааз",
															 "Сурагчдын тоо",
															 "Багш нарын тоо"});
			this.comboRegion.Location = new System.Drawing.Point(72, 0);
			this.comboRegion.Name = "comboRegion";
			this.comboRegion.Size = new System.Drawing.Size(240, 21);
			this.comboRegion.TabIndex = 1;
			// 
			// MapReport
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(728, 493);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.panelHead);
			this.Name = "MapReport";
			this.Text = "MapReport";
			this.panelHead.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
	}
}
