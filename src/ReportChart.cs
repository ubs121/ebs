using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace EBS {
	/// <summary>
	/// Summary description for ChartReport.
	/// </summary>
	public class ChartReport : Form {
		private AxOWC11.AxChartSpace chart;
		private Label label2;
		private ComboBox comboYear;
		private Label label1;
		private Panel panel1;
		private ComboBox comboInds;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ChartReport() {
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ChartReport));
			this.chart = new AxOWC11.AxChartSpace();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.comboYear = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comboInds = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// chart
			// 
			this.chart.DataSource = null;
			this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chart.Enabled = true;
			this.chart.Location = new System.Drawing.Point(0, 24);
			this.chart.Name = "chart";
			this.chart.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("chart.OcxState")));
			this.chart.Size = new System.Drawing.Size(664, 453);
			this.chart.TabIndex = 0;
			this.chart.Enter += new System.EventHandler(this.chart_Enter);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.comboYear);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.comboInds);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(664, 24);
			this.panel1.TabIndex = 1;
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
			// comboInds
			// 
			this.comboInds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboInds.Items.AddRange(new object[] {
														   "Материаллаг бааз",
														   "Сурагч, Багш нарын тоо"});
			this.comboInds.Location = new System.Drawing.Point(72, 0);
			this.comboInds.Name = "comboInds";
			this.comboInds.Size = new System.Drawing.Size(240, 21);
			this.comboInds.TabIndex = 1;
			this.comboInds.SelectedIndexChanged += new System.EventHandler(this.comboInds_SelectedIndexChanged);
			// 
			// ChartReport
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(664, 477);
			this.Controls.Add(this.chart);
			this.Controls.Add(this.panel1);
			this.Name = "ChartReport";
			this.Text = "ChartReport";
			((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void Chart1() {
			string[] categories = {"Car", "Sport Util", "Truck", "Minivan"};
			
			chart.Clear();
			chart.Charts.Add(0);
			//chart.Charts[0].SetData(OWC11.ChartDimensionsEnum.chDimSeriesNames, (int)OWC11.ChartSpecialDataSourcesEnum.chDataLiteral, series);
			//chart.Charts[0].SetData(OWC11.ChartDimensionsEnum.chDimCategories, (int)OWC11.ChartSpecialDataSourcesEnum.chDataLiteral, categories);
			chart.Charts[0].HasLegend = true;
			chart.Charts[0].HasTitle = true;
			chart.Charts[0].Title.Caption = comboInds.SelectedItem.ToString();
			//chart.Charts[0].Title = "Sales by last three year";
			chart.Charts[0].Axes[OWC11.ChartAxisPositionEnum.chAxisPositionLeft].NumberFormat = "0%";
			chart.Charts[0].Axes[OWC11.ChartAxisPositionEnum.chAxisPositionLeft].MajorUnit = 0.1;
			chart.Charts[0].Type = OWC11.ChartChartTypeEnum.chChartTypeColumnClustered;
			chart.Charts[0].Axes[OWC11.ChartAxisTypeEnum.chValueAxis].HasTitle = true;
			chart.Charts[0].Axes[OWC11.ChartAxisTypeEnum.chValueAxis].Title.Caption = "Утга";
			chart.Charts[0].Axes[OWC11.ChartAxisTypeEnum.chCategoryAxis].HasTitle = true;
			chart.Charts[0].Axes[OWC11.ChartAxisTypeEnum.chCategoryAxis].Title.Caption = "Он";


			chart.Charts[0].SeriesCollection.Add(0);
			chart.Charts[0].SeriesCollection.Add(1);
			chart.Charts[0].SeriesCollection.Add(2);


			float[] values = {0.2f, 0.06f, .17f, 0.13f};
			chart.Charts[0].SeriesCollection[0].Caption = "1998";
			chart.Charts[0].SeriesCollection[0].SetData(OWC11.ChartDimensionsEnum.chDimCategories, -1, categories);
			chart.Charts[0].SeriesCollection[0].SetData(OWC11.ChartDimensionsEnum.chDimValues, -1, values);

			values = new float[] {0.38f, 0.82f, 0.28f, 0.62f};

			chart.Charts[0].SeriesCollection[1].Caption = "1999";
			chart.Charts[0].SeriesCollection[1].SetData(OWC11.ChartDimensionsEnum.chDimCategories, -1, categories);
			chart.Charts[0].SeriesCollection[1].SetData(OWC11.ChartDimensionsEnum.chDimValues, -1, values);


			values = new float[] {0.42f, 0.12f, 0.55f, 0.25f};

			chart.Charts[0].SeriesCollection[2].Caption = "2000";
			chart.Charts[0].SeriesCollection[2].SetData(OWC11.ChartDimensionsEnum.chDimCategories, -1, categories);
			chart.Charts[0].SeriesCollection[2].SetData(OWC11.ChartDimensionsEnum.chDimValues, -1, values);

		}

		private void comboInds_SelectedIndexChanged(object sender, System.EventArgs e) {
			Chart1();
		}

		private void chart_Enter(object sender, System.EventArgs e) {
		
		}
	}
}
