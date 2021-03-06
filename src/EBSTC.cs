using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace EBS {
	/// <summary>
	/// Summary description for EBSTeacher.
	/// </summary>
	public class EBSTeacher : EBSForm {
		private TabControl tabControl1;
		private TabPage tabPage1;
		internal Label label1;
		internal Label label7;
		internal Label label9;
		internal ComboBox comboProfession;
		internal Label label10;
		internal ComboBox comboPosition;
		internal Label label12;
		internal Label label21;
		internal ComboBox comboDegree;
		internal Label label3;
		internal Label label4;
		internal Label label5;
		internal Label label6;
		private DataGridTableStyle dataGridTableStyle1;
		private DataGridTextBoxColumn dataGridTextBoxColumn1;
		private DataGridTextBoxColumn dataGridTextBoxColumn2;
		private DataGridTextBoxColumn dataGridTextBoxColumn3;
		private DataGridTextBoxColumn dataGridTextBoxColumn4;
		private DataGridTextBoxColumn dataGridTextBoxColumn5;
		private DataGridTextBoxColumn dataGridTextBoxColumn6;
		private DataGridTextBoxColumn dataGridTextBoxColumn7;
		private DataGridTextBoxColumn dataGridTextBoxColumn8;
		private DataGridTextBoxColumn dataGridTextBoxColumn9;
		private DataGridTextBoxColumn dataGridTextBoxColumn10;
		internal TextBox textAge;
		internal TextBox textRegNo;
		internal ComboBox comboSex;
		internal TextBox textName;
		internal TextBox textFamily;
		private DataGrid gridTeacher;
		internal Label label2;
		internal ComboBox comboEducation;
		internal TextBox textWorkedYear;
		internal ComboBox comboProfDegree;
		private DataGridTextBoxColumn dataGridTextBoxColumn11;
		private System.ComponentModel.IContainer components;

		public EBSTeacher() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(EBSTeacher));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.comboProfDegree = new System.Windows.Forms.ComboBox();
			this.textWorkedYear = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textAge = new System.Windows.Forms.TextBox();
			this.textRegNo = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.comboSex = new System.Windows.Forms.ComboBox();
			this.comboEducation = new System.Windows.Forms.ComboBox();
			this.textName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.comboDegree = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.comboProfession = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.comboPosition = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.textFamily = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.gridTeacher = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn11 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn10 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn9 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridTeacher)).BeginInit();
			this.SuspendLayout();
		
			// 
			// tabControl1
			// 
			this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Location = new System.Drawing.Point(8, 256);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(656, 208);
			this.tabControl1.TabIndex = 5;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.comboProfDegree);
			this.tabPage1.Controls.Add(this.textWorkedYear);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.textAge);
			this.tabPage1.Controls.Add(this.textRegNo);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.comboSex);
			this.tabPage1.Controls.Add(this.comboEducation);
			this.tabPage1.Controls.Add(this.textName);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.comboDegree);
			this.tabPage1.Controls.Add(this.label9);
			this.tabPage1.Controls.Add(this.comboProfession);
			this.tabPage1.Controls.Add(this.label10);
			this.tabPage1.Controls.Add(this.comboPosition);
			this.tabPage1.Controls.Add(this.label12);
			this.tabPage1.Controls.Add(this.textFamily);
			this.tabPage1.Controls.Add(this.label21);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.ImageIndex = 5;
			this.tabPage1.Location = new System.Drawing.Point(4, 4);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(648, 181);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Багшийн үндсэн мэдээлэл";
			this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(320, 120);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 16);
			this.label2.TabIndex = 43;
			this.label2.Text = "Мэргэжлийн зэрэг:";
			// 
			// comboProfDegree
			// 
			this.comboProfDegree.Items.AddRange(new object[] {
																 "зөвлөх",
																 "тэргүүлэх",
																 "арга зүйч"});
			this.comboProfDegree.Location = new System.Drawing.Point(448, 120);
			this.comboProfDegree.Name = "comboProfDegree";
			this.comboProfDegree.Size = new System.Drawing.Size(161, 21);
			this.comboProfDegree.TabIndex = 42;
			// 
			// textWorkedYear
			// 
			this.textWorkedYear.AcceptsReturn = true;
			this.textWorkedYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textWorkedYear.Location = new System.Drawing.Point(104, 152);
			this.textWorkedYear.MaxLength = 2;
			this.textWorkedYear.Name = "textWorkedYear";
			this.textWorkedYear.Size = new System.Drawing.Size(64, 20);
			this.textWorkedYear.TabIndex = 40;
			this.textWorkedYear.Text = "";
			this.textWorkedYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(320, 32);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 16);
			this.label5.TabIndex = 39;
			this.label5.Text = "Нас:";
			// 
			// textAge
			// 
			this.textAge.AcceptsReturn = true;
			this.textAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textAge.Location = new System.Drawing.Point(448, 32);
			this.textAge.MaxLength = 2;
			this.textAge.Name = "textAge";
			this.textAge.Size = new System.Drawing.Size(72, 20);
			this.textAge.TabIndex = 38;
			this.textAge.Text = "";
			this.textAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// textRegNo
			// 
			this.textRegNo.AcceptsReturn = true;
			this.textRegNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textRegNo.Location = new System.Drawing.Point(104, 32);
			this.textRegNo.MaxLength = 25;
			this.textRegNo.Name = "textRegNo";
			this.textRegNo.Size = new System.Drawing.Size(200, 20);
			this.textRegNo.TabIndex = 36;
			this.textRegNo.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(11, 32);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 16);
			this.label4.TabIndex = 37;
			this.label4.Text = "Регистр:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(320, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 16);
			this.label3.TabIndex = 35;
			this.label3.Text = "Хүйс:";
			// 
			// comboSex
			// 
			this.comboSex.Items.AddRange(new object[] {
														  "эр",
														  "эм"});
			this.comboSex.Location = new System.Drawing.Point(448, 56);
			this.comboSex.Name = "comboSex";
			this.comboSex.Size = new System.Drawing.Size(72, 21);
			this.comboSex.TabIndex = 34;
			// 
			// comboEducation
			// 
			this.comboEducation.Items.AddRange(new object[] {
																"дээд",
																"дипломын"});
			this.comboEducation.Location = new System.Drawing.Point(448, 96);
			this.comboEducation.Name = "comboEducation";
			this.comboEducation.Size = new System.Drawing.Size(161, 21);
			this.comboEducation.TabIndex = 24;
			// 
			// textName
			// 
			this.textName.AcceptsReturn = true;
			this.textName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textName.Location = new System.Drawing.Point(104, 8);
			this.textName.MaxLength = 25;
			this.textName.Name = "textName";
			this.textName.Size = new System.Drawing.Size(200, 20);
			this.textName.TabIndex = 17;
			this.textName.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(11, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 16);
			this.label1.TabIndex = 27;
			this.label1.Text = "Нэр:";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(320, 144);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(96, 16);
			this.label7.TabIndex = 28;
			this.label7.Text = "Эрдмийн зэрэг:";
			// 
			// comboDegree
			// 
			this.comboDegree.Items.AddRange(new object[] {
															 "бакалавр",
															 "магистр",
															 "доктор",
															 ""});
			this.comboDegree.Location = new System.Drawing.Point(448, 144);
			this.comboDegree.Name = "comboDegree";
			this.comboDegree.Size = new System.Drawing.Size(161, 21);
			this.comboDegree.TabIndex = 21;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(11, 120);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(64, 16);
			this.label9.TabIndex = 29;
			this.label9.Text = "Мэргэжил:";
			// 
			// comboProfession
			// 
			this.comboProfession.Items.AddRange(new object[] {
																 "Бага ангийн багш",
																 "Монгол хэл, уран зохиол",
																 "Казах хэл",
																 "Нийгэм судлал",
																 "Түүх-газарзvй",
																 "Түүх",
																 "Газарзүй",
																 "Орос хэл, уран зохиол",
																 "Англи хэл",
																 "Гадаадын бусад хэл",
																 "Математик",
																 "Физик",
																 "Математик-физик",
																 "Физик-математик",
																 "Мэдээлэл зүй",
																 "Хими",
																 "Биологи",
																 "Хими-биологи",
																 "Биеийн тамир",
																 "Дуу хөгжим",
																 "Зураг, шугам зураг",
																 "Зураг хөдөлмөр",
																 "Хөдөлмөрийн багш",
																 "Сурган сэтгэл зүй",
																 "Согог зүйч багш",
																 "Хэл засалч багш"});
			this.comboProfession.Location = new System.Drawing.Point(104, 120);
			this.comboProfession.Name = "comboProfession";
			this.comboProfession.Size = new System.Drawing.Size(200, 21);
			this.comboProfession.TabIndex = 20;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(11, 96);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(88, 16);
			this.label10.TabIndex = 30;
			this.label10.Text = "Албан тушаал:";
			// 
			// comboPosition
			// 
			this.comboPosition.Items.AddRange(new object[] {
															   "багш",
															   "захирал",
															   "хичээлийн эрхлэгч"});
			this.comboPosition.Location = new System.Drawing.Point(104, 96);
			this.comboPosition.Name = "comboPosition";
			this.comboPosition.Size = new System.Drawing.Size(200, 21);
			this.comboPosition.TabIndex = 19;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(320, 8);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(80, 16);
			this.label12.TabIndex = 31;
			this.label12.Text = "Ам бүл:";
			// 
			// textFamily
			// 
			this.textFamily.AcceptsReturn = true;
			this.textFamily.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textFamily.Location = new System.Drawing.Point(448, 8);
			this.textFamily.MaxLength = 2;
			this.textFamily.Name = "textFamily";
			this.textFamily.Size = new System.Drawing.Size(72, 20);
			this.textFamily.TabIndex = 23;
			this.textFamily.Text = "";
			this.textFamily.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(320, 96);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(128, 16);
			this.label21.TabIndex = 32;
			this.label21.Text = "Боловсролын түвшин:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(11, 152);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(96, 16);
			this.label6.TabIndex = 41;
			this.label6.Text = "Ажилласан жил:";
			// 
			// gridTeacher
			// 
			this.gridTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.gridTeacher.CaptionText = "Багш нар";
			this.gridTeacher.DataMember = "";
			this.gridTeacher.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.gridTeacher.Location = new System.Drawing.Point(8, 32);
			this.gridTeacher.Name = "gridTeacher";
			this.gridTeacher.ReadOnly = true;
			this.gridTeacher.Size = new System.Drawing.Size(656, 224);
			this.gridTeacher.TabIndex = 37;
			this.gridTeacher.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																									this.dataGridTableStyle1});
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.DataGrid = this.gridTeacher;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.dataGridTextBoxColumn1,
																												  this.dataGridTextBoxColumn2,
																												  this.dataGridTextBoxColumn3,
																												  this.dataGridTextBoxColumn4,
																												  this.dataGridTextBoxColumn5,
																												  this.dataGridTextBoxColumn6,
																												  this.dataGridTextBoxColumn11,
																												  this.dataGridTextBoxColumn7,
																												  this.dataGridTextBoxColumn8,
																												  this.dataGridTextBoxColumn10,
																												  this.dataGridTextBoxColumn9});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "Teacher";
			// 
			// dataGridTextBoxColumn1
			// 
			this.dataGridTextBoxColumn1.Format = "";
			this.dataGridTextBoxColumn1.FormatInfo = null;
			this.dataGridTextBoxColumn1.HeaderText = "Нэр";
			this.dataGridTextBoxColumn1.MappingName = "c_Name";
			this.dataGridTextBoxColumn1.Width = 150;
			// 
			// dataGridTextBoxColumn2
			// 
			this.dataGridTextBoxColumn2.Format = "";
			this.dataGridTextBoxColumn2.FormatInfo = null;
			this.dataGridTextBoxColumn2.HeaderText = "Нас";
			this.dataGridTextBoxColumn2.MappingName = "c_Age";
			this.dataGridTextBoxColumn2.Width = 30;
			// 
			// dataGridTextBoxColumn3
			// 
			this.dataGridTextBoxColumn3.Format = "";
			this.dataGridTextBoxColumn3.FormatInfo = null;
			this.dataGridTextBoxColumn3.HeaderText = "Хүйс";
			this.dataGridTextBoxColumn3.MappingName = "c_Sex";
			this.dataGridTextBoxColumn3.Width = 30;
			// 
			// dataGridTextBoxColumn4
			// 
			this.dataGridTextBoxColumn4.Format = "";
			this.dataGridTextBoxColumn4.FormatInfo = null;
			this.dataGridTextBoxColumn4.HeaderText = "Регистр№";
			this.dataGridTextBoxColumn4.MappingName = "c_RegNo";
			this.dataGridTextBoxColumn4.Width = 75;
			// 
			// dataGridTextBoxColumn5
			// 
			this.dataGridTextBoxColumn5.Format = "";
			this.dataGridTextBoxColumn5.FormatInfo = null;
			this.dataGridTextBoxColumn5.HeaderText = "Ам бүл";
			this.dataGridTextBoxColumn5.MappingName = "c_FamilyMembers";
			this.dataGridTextBoxColumn5.Width = 50;
			// 
			// dataGridTextBoxColumn6
			// 
			this.dataGridTextBoxColumn6.Format = "";
			this.dataGridTextBoxColumn6.FormatInfo = null;
			this.dataGridTextBoxColumn6.HeaderText = "Мэргэжил";
			this.dataGridTextBoxColumn6.MappingName = "c_Prof";
			this.dataGridTextBoxColumn6.Width = 75;
			// 
			// dataGridTextBoxColumn11
			// 
			this.dataGridTextBoxColumn11.Format = "";
			this.dataGridTextBoxColumn11.FormatInfo = null;
			this.dataGridTextBoxColumn11.HeaderText = "Мэргэжлийн зэрэг";
			this.dataGridTextBoxColumn11.MappingName = "c_ProfDegree";
			this.dataGridTextBoxColumn11.Width = 150;
			// 
			// dataGridTextBoxColumn7
			// 
			this.dataGridTextBoxColumn7.Format = "";
			this.dataGridTextBoxColumn7.FormatInfo = null;
			this.dataGridTextBoxColumn7.HeaderText = "Албан тушаал";
			this.dataGridTextBoxColumn7.MappingName = "c_Position";
			this.dataGridTextBoxColumn7.Width = 75;
			// 
			// dataGridTextBoxColumn8
			// 
			this.dataGridTextBoxColumn8.Format = "";
			this.dataGridTextBoxColumn8.FormatInfo = null;
			this.dataGridTextBoxColumn8.HeaderText = "Эрдмийн зэрэг";
			this.dataGridTextBoxColumn8.MappingName = "c_Degree";
			this.dataGridTextBoxColumn8.Width = 75;
			// 
			// dataGridTextBoxColumn10
			// 
			this.dataGridTextBoxColumn10.Format = "";
			this.dataGridTextBoxColumn10.FormatInfo = null;
			this.dataGridTextBoxColumn10.HeaderText = "Боловсролын түвшин";
			this.dataGridTextBoxColumn10.MappingName = "c_Education";
			this.dataGridTextBoxColumn10.Width = 75;
			// 
			// dataGridTextBoxColumn9
			// 
			this.dataGridTextBoxColumn9.Format = "";
			this.dataGridTextBoxColumn9.FormatInfo = null;
			this.dataGridTextBoxColumn9.HeaderText = "Ажилласан жил";
			this.dataGridTextBoxColumn9.MappingName = "c_WorkedYear";
			this.dataGridTextBoxColumn9.Width = 40;
			// 
			// EBSTeacher
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(672, 469);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.gridTeacher);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "EBSTeacher";
			this.Text = "EBS Багш";
			this.Controls.SetChildIndex(this.panelHead, 0);
			this.Controls.SetChildIndex(this.gridTeacher, 0);
			this.Controls.SetChildIndex(this.tabControl1, 0);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridTeacher)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void tabPage1_Click(object sender, System.EventArgs e) {
		
		}

		private void BindControls() {
			try {
				gridTeacher.DataSource = DB.Teachers;

				textName.DataBindings.Add("Text", DB.Teachers, "c_Name");
				textRegNo.DataBindings.Add("Text", DB.Teachers, "c_RegNo");
				textAge.DataBindings.Add("Text", DB.Teachers, "c_Age");
				comboSex.DataBindings.Add("Text", DB.Teachers, "c_Sex");
				textFamily.DataBindings.Add("Text", DB.Teachers, "c_FamilyMembers");
				comboProfession.DataBindings.Add("Text", DB.Teachers, "c_Prof");
				comboProfDegree.DataBindings.Add("Text", DB.Teachers, "c_ProfDegree");
				comboPosition.DataBindings.Add("Text", DB.Teachers, "c_Position");
				comboDegree.DataBindings.Add("Text", DB.Teachers, "c_Degree");
				comboEducation.DataBindings.Add("Text", DB.Teachers, "c_Education");
				textWorkedYear.DataBindings.Add("Text", DB.Teachers, "c_WorkedYear");
			}
			catch {}
		}

		public override void LoadData() {
			Cursor.Current = Cursors.WaitCursor;

			try {
				DB.LoadTeacher(arcid);
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
				this.BindingContext[DB.Schools, ""].EndCurrentEdit();
				DataRowView row  = (DataRowView)this.BindingContext[DB.Teachers, ""].Current;
				Teacher t = new Teacher();
				t.arcid = arcid;
				if (arcid > 0) {
					t.name = row["c_Name"].ToString();
					try {
						t.age = Convert.ToInt32(row["c_Age"]);
						t.sex = row["c_Sex"].ToString();
						t.regno = row["c_RegNo"].ToString();
						t.family = Convert.ToInt32(row["c_FamilyMembers"]);
						t.prof = row["c_Prof"].ToString();
						t.position = row["c_Position"].ToString();
						t.degree = row["c_Degree"].ToString();
						t.profdegree = row["c_ProfDegree"].ToString();
						t.education = row["c_Education"].ToString();
						t.workedyear = Convert.ToInt32(row["c_WorkedYear"]);
						
					}
					catch {}

					DB.Save(t);
				}
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message, "EBS", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally {
				Cursor.Current = Cursors.Default;
			}
		}

		public override void NewData() {
			try {
				this.BindingContext[DB.Teachers, ""].EndCurrentEdit();
				this.BindingContext[DB.Teachers, ""].AddNew();
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message, "EBS", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}

		public override void DeleteData() {
			if (MessageBox.Show("Устгах уу?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
				Cursor.Current = Cursors.WaitCursor;

				if (this.BindingContext[DB.Teachers, ""].Count > 0) {
					try {
						DataRowView row  = (DataRowView)this.BindingContext[DB.Teachers, ""].Current;
						DB.DeleteTeacher(arcid, row["c_name"].ToString());

						LoadData();
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
