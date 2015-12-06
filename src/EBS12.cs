using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace EBS {
	/// <summary>
	/// Summary description for EBS12.
	/// </summary>
	public class EBS12 : Form {
		private int rid;
		private Panel panelHead;
		private Label label1;
		private ComboBox comboRegion;
		private Panel panel2;
		private Label label6;
		private ComboBox comboSpec;
		private Label label5;
		private Label label4;
		private Label label3;
		private ComboBox comboType;
		private Label label2;
		private DataGrid gridSchool;
		private CheckBox checkIsBranch;
		private TextBox textSid;
		private TextBox textName;
		private DataGridTableStyle dataGridTableStyle1;
		private DataGridTextBoxColumn dataGridTextBoxColumn1;
		private DataGridTextBoxColumn dataGridTextBoxColumn2;
		private DataGridTextBoxColumn dataGridTextBoxColumn3;
		private DataGridTextBoxColumn dataGridTextBoxColumn4;
		private DataGridBoolColumn dataGridBoolColumn1;
		private DataGridTextBoxColumn dataGridTextBoxColumn5;
		private TextBox textNote;
		private System.Windows.Forms.Panel panel1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public EBS12() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			comboRegion.DataSource = DB.Regions;
			comboRegion.DisplayMember = "c_Name";
			comboRegion.ValueMember = "c_Rid";

			BindControls();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(EBS12));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.comboRegion = new System.Windows.Forms.ComboBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.textNote = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.checkIsBranch = new System.Windows.Forms.CheckBox();
			this.comboSpec = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textSid = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboType = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.gridSchool = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridBoolColumn1 = new System.Windows.Forms.DataGridBoolColumn();
			this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridSchool)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.comboRegion);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(656, 24);
			this.panel1.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Аймаг:";
			// 
			// comboRegion
			// 
			this.comboRegion.DisplayMember = "c_Name";
			this.comboRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboRegion.Location = new System.Drawing.Point(56, 0);
			this.comboRegion.Name = "comboRegion";
			this.comboRegion.Size = new System.Drawing.Size(184, 21);
			this.comboRegion.TabIndex = 1;
			this.comboRegion.ValueMember = "c_Rid";
			this.comboRegion.SelectedIndexChanged += new System.EventHandler(this.comboRegion_SelectedIndexChanged);
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.textNote);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.checkIsBranch);
			this.panel2.Controls.Add(this.comboSpec);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.textSid);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.textName);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.comboType);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.gridSchool);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 24);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(656, 453);
			this.panel2.TabIndex = 5;
			// 
			// textNote
			// 
			this.textNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textNote.Location = new System.Drawing.Point(64, 64);
			this.textNote.Multiline = true;
			this.textNote.Name = "textNote";
			this.textNote.Size = new System.Drawing.Size(568, 24);
			this.textNote.TabIndex = 28;
			this.textNote.Text = "";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 64);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 16);
			this.label6.TabIndex = 27;
			this.label6.Text = "Тайлбар:";
			// 
			// checkIsBranch
			// 
			this.checkIsBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkIsBranch.Location = new System.Drawing.Point(152, 8);
			this.checkIsBranch.Name = "checkIsBranch";
			this.checkIsBranch.Size = new System.Drawing.Size(128, 16);
			this.checkIsBranch.TabIndex = 26;
			this.checkIsBranch.Text = "салбар сургууль";
			// 
			// comboSpec
			// 
			this.comboSpec.Items.AddRange(new object[] {
														   "ердийн",
														   "тусгай",
														   "авъяастны",
														   "цогцолбор",
														   "хувийн"});
			this.comboSpec.Location = new System.Drawing.Point(416, 32);
			this.comboSpec.Name = "comboSpec";
			this.comboSpec.Size = new System.Drawing.Size(152, 21);
			this.comboSpec.TabIndex = 25;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(352, 32);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 16);
			this.label5.TabIndex = 24;
			this.label5.Text = "Онцлог:";
			// 
			// textSid
			// 
			this.textSid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textSid.Location = new System.Drawing.Point(64, 8);
			this.textSid.Name = "textSid";
			this.textSid.Size = new System.Drawing.Size(72, 20);
			this.textSid.TabIndex = 23;
			this.textSid.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 16);
			this.label4.TabIndex = 22;
			this.label4.Text = "Код:";
			// 
			// textName
			// 
			this.textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textName.Location = new System.Drawing.Point(64, 32);
			this.textName.Name = "textName";
			this.textName.Size = new System.Drawing.Size(264, 20);
			this.textName.TabIndex = 21;
			this.textName.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 16);
			this.label3.TabIndex = 20;
			this.label3.Text = "Нэр:";
			// 
			// comboType
			// 
			this.comboType.Items.AddRange(new object[] {
														   "үндсэн",
														   "бага",
														   "дунд",
														   "лицей"});
			this.comboType.Location = new System.Drawing.Point(416, 8);
			this.comboType.Name = "comboType";
			this.comboType.Size = new System.Drawing.Size(152, 21);
			this.comboType.TabIndex = 19;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(352, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 16);
			this.label2.TabIndex = 18;
			this.label2.Text = "Хэв шинж:";
			// 
			// gridSchool
			// 
			this.gridSchool.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.gridSchool.CaptionText = "Сургуулиуд";
			this.gridSchool.DataMember = "";
			this.gridSchool.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.gridSchool.Location = new System.Drawing.Point(8, 104);
			this.gridSchool.Name = "gridSchool";
			this.gridSchool.ReadOnly = true;
			this.gridSchool.Size = new System.Drawing.Size(640, 336);
			this.gridSchool.TabIndex = 17;
			this.gridSchool.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																								   this.dataGridTableStyle1});
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.DataGrid = this.gridSchool;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.dataGridTextBoxColumn1,
																												  this.dataGridTextBoxColumn2,
																												  this.dataGridBoolColumn1,
																												  this.dataGridTextBoxColumn3,
																												  this.dataGridTextBoxColumn4,
																												  this.dataGridTextBoxColumn5});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "School";
			// 
			// dataGridTextBoxColumn1
			// 
			this.dataGridTextBoxColumn1.Format = "";
			this.dataGridTextBoxColumn1.FormatInfo = null;
			this.dataGridTextBoxColumn1.HeaderText = "Код";
			this.dataGridTextBoxColumn1.MappingName = "c_Sid";
			this.dataGridTextBoxColumn1.ReadOnly = true;
			this.dataGridTextBoxColumn1.Width = 75;
			// 
			// dataGridTextBoxColumn2
			// 
			this.dataGridTextBoxColumn2.Format = "";
			this.dataGridTextBoxColumn2.FormatInfo = null;
			this.dataGridTextBoxColumn2.HeaderText = "Нэр";
			this.dataGridTextBoxColumn2.MappingName = "c_Name";
			this.dataGridTextBoxColumn2.Width = 200;
			// 
			// dataGridBoolColumn1
			// 
			this.dataGridBoolColumn1.FalseValue = false;
			this.dataGridBoolColumn1.HeaderText = "салбар эсэх";
			this.dataGridBoolColumn1.MappingName = "c_IsBranch";
			this.dataGridBoolColumn1.NullValue = ((object)(resources.GetObject("dataGridBoolColumn1.NullValue")));
			this.dataGridBoolColumn1.TrueValue = true;
			this.dataGridBoolColumn1.Width = 75;
			// 
			// dataGridTextBoxColumn3
			// 
			this.dataGridTextBoxColumn3.Format = "";
			this.dataGridTextBoxColumn3.FormatInfo = null;
			this.dataGridTextBoxColumn3.HeaderText = "Хэв шинж";
			this.dataGridTextBoxColumn3.MappingName = "c_Type";
			this.dataGridTextBoxColumn3.Width = 75;
			// 
			// dataGridTextBoxColumn4
			// 
			this.dataGridTextBoxColumn4.Format = "";
			this.dataGridTextBoxColumn4.FormatInfo = null;
			this.dataGridTextBoxColumn4.HeaderText = "Онцлог";
			this.dataGridTextBoxColumn4.MappingName = "c_Special";
			this.dataGridTextBoxColumn4.Width = 75;
			// 
			// dataGridTextBoxColumn5
			// 
			this.dataGridTextBoxColumn5.Format = "";
			this.dataGridTextBoxColumn5.FormatInfo = null;
			this.dataGridTextBoxColumn5.HeaderText = "Тайлбар";
			this.dataGridTextBoxColumn5.MappingName = "c_Note";
			this.dataGridTextBoxColumn5.Width = 300;
			// 
			// EBS12
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(656, 477);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "EBS12";
			this.Text = "EBS12 маягт - ЕБС-ийн байршлын тайлан";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EBS12_KeyDown);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridSchool)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void comboRegion_SelectedIndexChanged(object sender, System.EventArgs e) {
			try {
				rid = Convert.ToInt32(comboRegion.SelectedValue);
				DB.LoadSchool(rid);
			}
			catch {}
		}

		private void BindControls() {
			try {
				textSid.DataBindings.Add("Text", DB.Schools, "c_Sid");
				textName.DataBindings.Add("Text", DB.Schools, "c_Name");
				checkIsBranch.DataBindings.Add("Checked", DB.Schools, "c_IsBranch");
				comboType.DataBindings.Add("Text", DB.Schools, "c_Type");
				comboSpec.DataBindings.Add("Text", DB.Schools, "c_Special");
				textNote.DataBindings.Add("Text", DB.Schools, "c_Note");

				gridSchool.DataSource = DB.Schools;
			}
			catch {}
		}

		private void EBS12_KeyDown(object sender, KeyEventArgs e) {
			switch (e.KeyData) {
				case Keys.ControlKey | Keys.S: 
					SaveSchool(); 
					break;
				case Keys.ControlKey | Keys.N: 
					NewSchool(); 
					break;
				case Keys.Delete: 
					DeleteSchool(); 
					break;
				case Keys.F5: 
					comboRegion_SelectedIndexChanged(sender, e); 
					break;
			}
		}

		private void SaveSchool() {
			Cursor.Current = Cursors.WaitCursor;

			try {
				this.BindingContext[DB.Schools, ""].EndCurrentEdit();
				DataRowView row  = (DataRowView)this.BindingContext[DB.Schools, ""].Current;
				School s = new School();
				s.sid = Convert.ToInt32(row["c_Sid"]);
				if (s.sid > 0) {
					s.rid = Convert.ToInt32(comboRegion.SelectedValue);
					s.name = row["c_Name"].ToString();
					s.type = row["c_Type"].ToString();
					s.spec = row["c_Special"].ToString();
					s.isbranch = Convert.ToBoolean(row["c_IsBranch"]);
					s.note = row["c_Note"].ToString();

					DB.Save(s);
				}
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message, "EBS", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally {
				Cursor.Current = Cursors.Default;
			}
		}

		private void NewSchool() {
			try {
				this.BindingContext[DB.Schools, ""].EndCurrentEdit();
				this.BindingContext[DB.Schools, ""].AddNew();
				textSid.Text = "";
				textName.Text = "";
				checkIsBranch.Checked = false;
				comboType.SelectedIndex = 0;
				comboSpec.SelectedIndex = 0;
				textNote.Text = "";
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message, "EBS", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void DeleteSchool() {
			if (MessageBox.Show("Устгах уу?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
				Cursor.Current = Cursors.WaitCursor;

				if (this.BindingContext[DB.Schools, ""].Count > 0) {
					try {
						DataRowView row  = (DataRowView)this.BindingContext[DB.Schools, ""].Current;
						DB.DeleteSchool(Convert.ToInt32(row["c_Sid"]), rid);
					}
					catch (Exception ex) {
						MessageBox.Show(ex.Message, "EBS", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}

				Cursor.Current = Cursors.Default;
			}
		}
	}
}
