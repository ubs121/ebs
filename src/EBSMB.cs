using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace EBS {
	/// <summary>
	/// Summary description for EBSMB.
	/// </summary>
	public class EBSMB : EBSForm {
		private TabPage tabPage1;
		private TabPage tabPage2;
		private TabPage tabPage3;
		private ImageList images;
		internal TextBox textBuildYear;
		internal Label label4;
		private Label label11;
		private Label label10;
		private CheckBox checkRepairReq;
		private Label label9;
		private Label label8;
		private CheckBox checkNECapable;
		private CheckBox checkAvailable;
		private CheckBox checkUsableInWinter;
		private ComboBox comboHeatingType;
		private Label label7;
		private ComboBox comboQuality;
		private Label label5;
		private Label label12;
		private Label label13;
		private TextBox textRepairCost;
		private TextBox textHeatingCapacity;
		private TextBox textCost;
		private TextBox textCardinality;
		private TextBox textRoomCount;
		private GroupBox groupUrgats;
		private Label label31;
		private Label label30;
		private Label label29;
		private Label label28;
		private Label label27;
		private Label label26;
		private Label label25;
		private Label label24;
		private Label label23;
		private GroupBox groupAnimal;
		private Label label22;
		private Label label21;
		private Label label20;
		private Label label19;
		private Label label18;
		private Label label17;
		private Label label16;
		private Label label15;
		private TextBox textAnimal;
		private TextBox textBird;
		private TextBox textPig;
		private TextBox textCamel;
		private TextBox textHorse;
		private TextBox textCow;
		private TextBox textGoat;
		private TextBox textSheep;
		private TextBox textHarvest;
		private TextBox textSeed;
		private TextBox textVegetable;
		private TextBox textFruit;
		private TextBox textField;
		private Label label6;
		private DataGridTableStyle dataGridTableStyle1;
		private DataGridTextBoxColumn dataGridTextBoxColumn1;
		private DataGridTextBoxColumn dataGridTextBoxColumn2;
		private DataGridTextBoxColumn dataGridTextBoxColumn3;
		private DataGridTextBoxColumn dataGridTextBoxColumn4;
		private DataGridTextBoxColumn dataGridTextBoxColumn5;
		private DataGridTableStyle dataGridTableStyle2;
		private DataGridTextBoxColumn dataGridTextBoxColumn7;
		private TabControl tabMaterial;
		private ComboBox comboDesc;
		private DataGrid gridBuilding;
		private CheckBox checkUsingByDesc;
		private DataGrid gridEquipment;
		internal TextBox textBuilding;
		internal Label label1;
		private Label label2;
		private Label label3;
		private Label label14;
		private Label label32;
		private Label label33;
		private TextBox textEquipment;
		private ComboBox comboEqType;
		private TextBox textEqCount;
		private TextBox textEqAvailable;
		private TextBox textEqCost;
		private System.ComponentModel.IContainer components;

		public EBSMB() {
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(EBSMB));
			this.tabMaterial = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.textBuilding = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comboDesc = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBuildYear = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textCost = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.textRepairCost = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.checkRepairReq = new System.Windows.Forms.CheckBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textHeatingCapacity = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.checkNECapable = new System.Windows.Forms.CheckBox();
			this.checkAvailable = new System.Windows.Forms.CheckBox();
			this.checkUsingByDesc = new System.Windows.Forms.CheckBox();
			this.checkUsableInWinter = new System.Windows.Forms.CheckBox();
			this.comboHeatingType = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.comboQuality = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textRoomCount = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.textCardinality = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.gridBuilding = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle2 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.groupUrgats = new System.Windows.Forms.GroupBox();
			this.label31 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.textHarvest = new System.Windows.Forms.TextBox();
			this.label26 = new System.Windows.Forms.Label();
			this.textSeed = new System.Windows.Forms.TextBox();
			this.label25 = new System.Windows.Forms.Label();
			this.textVegetable = new System.Windows.Forms.TextBox();
			this.label24 = new System.Windows.Forms.Label();
			this.textFruit = new System.Windows.Forms.TextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.textField = new System.Windows.Forms.TextBox();
			this.groupAnimal = new System.Windows.Forms.GroupBox();
			this.textAnimal = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.textBird = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.textPig = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.textCamel = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.textHorse = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.textCow = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.textGoat = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.textSheep = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.textEqCost = new System.Windows.Forms.TextBox();
			this.label33 = new System.Windows.Forms.Label();
			this.textEqAvailable = new System.Windows.Forms.TextBox();
			this.label32 = new System.Windows.Forms.Label();
			this.textEqCount = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.comboEqType = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textEquipment = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.gridEquipment = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.images = new System.Windows.Forms.ImageList(this.components);
			this.tabMaterial.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridBuilding)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.groupUrgats.SuspendLayout();
			this.groupAnimal.SuspendLayout();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridEquipment)).BeginInit();
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
			// tabMaterial
			// 
			this.tabMaterial.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.tabMaterial.Controls.Add(this.tabPage1);
			this.tabMaterial.Controls.Add(this.tabPage2);
			this.tabMaterial.Controls.Add(this.tabPage3);
			this.tabMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabMaterial.ImageList = this.images;
			this.tabMaterial.Location = new System.Drawing.Point(0, 24);
			this.tabMaterial.Name = "tabMaterial";
			this.tabMaterial.SelectedIndex = 0;
			this.tabMaterial.Size = new System.Drawing.Size(664, 445);
			this.tabMaterial.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.textBuilding);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.comboDesc);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.textBuildYear);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.textCost);
			this.tabPage1.Controls.Add(this.label11);
			this.tabPage1.Controls.Add(this.textRepairCost);
			this.tabPage1.Controls.Add(this.label10);
			this.tabPage1.Controls.Add(this.checkRepairReq);
			this.tabPage1.Controls.Add(this.label9);
			this.tabPage1.Controls.Add(this.textHeatingCapacity);
			this.tabPage1.Controls.Add(this.label8);
			this.tabPage1.Controls.Add(this.checkNECapable);
			this.tabPage1.Controls.Add(this.checkAvailable);
			this.tabPage1.Controls.Add(this.checkUsingByDesc);
			this.tabPage1.Controls.Add(this.checkUsableInWinter);
			this.tabPage1.Controls.Add(this.comboHeatingType);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.comboQuality);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.textRoomCount);
			this.tabPage1.Controls.Add(this.label12);
			this.tabPage1.Controls.Add(this.textCardinality);
			this.tabPage1.Controls.Add(this.label13);
			this.tabPage1.Controls.Add(this.gridBuilding);
			this.tabPage1.ImageIndex = 1;
			this.tabPage1.Location = new System.Drawing.Point(4, 4);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(656, 418);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Барилга байгууламжууд";
			// 
			// textBuilding
			// 
			this.textBuilding.AcceptsReturn = true;
			this.textBuilding.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBuilding.Location = new System.Drawing.Point(368, 8);
			this.textBuilding.Name = "textBuilding";
			this.textBuilding.Size = new System.Drawing.Size(144, 20);
			this.textBuilding.TabIndex = 46;
			this.textBuilding.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(240, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 16);
			this.label1.TabIndex = 47;
			this.label1.Text = "Байгууламж:";
			// 
			// comboDesc
			// 
			this.comboDesc.Items.AddRange(new object[] {
														   "хичээлийн байр",
														   "дотуур байр"});
			this.comboDesc.Location = new System.Drawing.Point(368, 40);
			this.comboDesc.Name = "comboDesc";
			this.comboDesc.Size = new System.Drawing.Size(147, 21);
			this.comboDesc.TabIndex = 44;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(240, 40);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(120, 16);
			this.label6.TabIndex = 45;
			this.label6.Text = "Барилгын зориулалт:";
			// 
			// textBuildYear
			// 
			this.textBuildYear.AcceptsReturn = true;
			this.textBuildYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBuildYear.Location = new System.Drawing.Point(368, 104);
			this.textBuildYear.Name = "textBuildYear";
			this.textBuildYear.Size = new System.Drawing.Size(104, 20);
			this.textBuildYear.TabIndex = 22;
			this.textBuildYear.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(240, 104);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(128, 16);
			this.label4.TabIndex = 23;
			this.label4.Text = "Ашиглалтад орсон он:";
			// 
			// textCost
			// 
			this.textCost.AcceptsReturn = true;
			this.textCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textCost.Location = new System.Drawing.Point(368, 128);
			this.textCost.MaxLength = 10;
			this.textCost.Name = "textCost";
			this.textCost.Size = new System.Drawing.Size(104, 20);
			this.textCost.TabIndex = 24;
			this.textCost.Text = "";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(240, 128);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 16);
			this.label11.TabIndex = 25;
			this.label11.Text = "Өөрийн өртөг:";
			// 
			// textRepairCost
			// 
			this.textRepairCost.AcceptsReturn = true;
			this.textRepairCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textRepairCost.Location = new System.Drawing.Point(368, 352);
			this.textRepairCost.MaxLength = 10;
			this.textRepairCost.Name = "textRepairCost";
			this.textRepairCost.Size = new System.Drawing.Size(104, 20);
			this.textRepairCost.TabIndex = 26;
			this.textRepairCost.Text = "";
			this.textRepairCost.Visible = false;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(264, 352);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(88, 16);
			this.label10.TabIndex = 27;
			this.label10.Text = "Засварын үнэ:";
			this.label10.Visible = false;
			// 
			// checkRepairReq
			// 
			this.checkRepairReq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkRepairReq.Location = new System.Drawing.Point(240, 328);
			this.checkRepairReq.Name = "checkRepairReq";
			this.checkRepairReq.Size = new System.Drawing.Size(152, 16);
			this.checkRepairReq.TabIndex = 28;
			this.checkRepairReq.Text = "Засвар шаардлагатай:";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(480, 232);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(48, 16);
			this.label9.TabIndex = 29;
			this.label9.Text = "(м.куб)";
			// 
			// textHeatingCapacity
			// 
			this.textHeatingCapacity.AcceptsReturn = true;
			this.textHeatingCapacity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textHeatingCapacity.Location = new System.Drawing.Point(368, 232);
			this.textHeatingCapacity.MaxLength = 5;
			this.textHeatingCapacity.Name = "textHeatingCapacity";
			this.textHeatingCapacity.Size = new System.Drawing.Size(104, 20);
			this.textHeatingCapacity.TabIndex = 30;
			this.textHeatingCapacity.Text = "";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(240, 232);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(120, 16);
			this.label8.TabIndex = 31;
			this.label8.Text = "Халаалтын эзлэхүүн:";
			// 
			// checkNECapable
			// 
			this.checkNECapable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkNECapable.Location = new System.Drawing.Point(240, 264);
			this.checkNECapable.Name = "checkNECapable";
			this.checkNECapable.Size = new System.Drawing.Size(168, 16);
			this.checkNECapable.TabIndex = 32;
			this.checkNECapable.Text = "Ердийн халаалт боломжтой";
			// 
			// checkAvailable
			// 
			this.checkAvailable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkAvailable.Location = new System.Drawing.Point(240, 72);
			this.checkAvailable.Name = "checkAvailable";
			this.checkAvailable.Size = new System.Drawing.Size(136, 16);
			this.checkAvailable.TabIndex = 33;
			this.checkAvailable.Text = "Ашиглаж байгаа эсэх";
			// 
			// checkUsingByDesc
			// 
			this.checkUsingByDesc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkUsingByDesc.Location = new System.Drawing.Point(376, 72);
			this.checkUsingByDesc.Name = "checkUsingByDesc";
			this.checkUsingByDesc.Size = new System.Drawing.Size(216, 16);
			this.checkUsingByDesc.TabIndex = 34;
			this.checkUsingByDesc.Text = "Зориулалтаар ашиглаж байгаа эсэх";
			// 
			// checkUsableInWinter
			// 
			this.checkUsableInWinter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.checkUsableInWinter.Location = new System.Drawing.Point(432, 264);
			this.checkUsableInWinter.Name = "checkUsableInWinter";
			this.checkUsableInWinter.Size = new System.Drawing.Size(160, 16);
			this.checkUsableInWinter.TabIndex = 35;
			this.checkUsableInWinter.Text = "Өвөл ашиглах боломжтой";
			// 
			// comboHeatingType
			// 
			this.comboHeatingType.Items.AddRange(new object[] {
																  "төвлөрсөн",
																  "ердийн"});
			this.comboHeatingType.Location = new System.Drawing.Point(368, 200);
			this.comboHeatingType.Name = "comboHeatingType";
			this.comboHeatingType.Size = new System.Drawing.Size(147, 21);
			this.comboHeatingType.TabIndex = 36;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(240, 200);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(112, 16);
			this.label7.TabIndex = 37;
			this.label7.Text = "Халаалтын хэлбэр:";
			// 
			// comboQuality
			// 
			this.comboQuality.Items.AddRange(new object[] {
															  "сайн",
															  "дунд",
															  "муу"});
			this.comboQuality.Location = new System.Drawing.Point(368, 296);
			this.comboQuality.Name = "comboQuality";
			this.comboQuality.Size = new System.Drawing.Size(128, 21);
			this.comboQuality.TabIndex = 38;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(240, 296);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 16);
			this.label5.TabIndex = 39;
			this.label5.Text = "Барилгын чанар:";
			// 
			// textRoomCount
			// 
			this.textRoomCount.AcceptsReturn = true;
			this.textRoomCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textRoomCount.Location = new System.Drawing.Point(368, 176);
			this.textRoomCount.MaxLength = 4;
			this.textRoomCount.Name = "textRoomCount";
			this.textRoomCount.Size = new System.Drawing.Size(104, 20);
			this.textRoomCount.TabIndex = 40;
			this.textRoomCount.Text = "";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(240, 176);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(108, 16);
			this.label12.TabIndex = 41;
			this.label12.Text = "Өрөөний тоо:";
			// 
			// textCardinality
			// 
			this.textCardinality.AcceptsReturn = true;
			this.textCardinality.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textCardinality.Location = new System.Drawing.Point(368, 152);
			this.textCardinality.MaxLength = 4;
			this.textCardinality.Name = "textCardinality";
			this.textCardinality.Size = new System.Drawing.Size(104, 20);
			this.textCardinality.TabIndex = 42;
			this.textCardinality.Text = "";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(240, 152);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(100, 16);
			this.label13.TabIndex = 43;
			this.label13.Text = "Хүчин чадал:";
			// 
			// gridBuilding
			// 
			this.gridBuilding.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.gridBuilding.CaptionText = "Байгууламж";
			this.gridBuilding.DataMember = "";
			this.gridBuilding.Dock = System.Windows.Forms.DockStyle.Left;
			this.gridBuilding.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.gridBuilding.Location = new System.Drawing.Point(0, 0);
			this.gridBuilding.Name = "gridBuilding";
			this.gridBuilding.ReadOnly = true;
			this.gridBuilding.Size = new System.Drawing.Size(224, 418);
			this.gridBuilding.TabIndex = 0;
			this.gridBuilding.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																									 this.dataGridTableStyle2});
			this.gridBuilding.Navigate += new System.Windows.Forms.NavigateEventHandler(this.gridBuilding_Navigate);
			// 
			// dataGridTableStyle2
			// 
			this.dataGridTableStyle2.DataGrid = this.gridBuilding;
			this.dataGridTableStyle2.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.dataGridTextBoxColumn7});
			this.dataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle2.MappingName = "Building";
			this.dataGridTableStyle2.ReadOnly = true;
			// 
			// dataGridTextBoxColumn7
			// 
			this.dataGridTextBoxColumn7.Format = "";
			this.dataGridTextBoxColumn7.FormatInfo = null;
			this.dataGridTextBoxColumn7.HeaderText = "Байгууламжийн нэр";
			this.dataGridTextBoxColumn7.MappingName = "c_Building";
			this.dataGridTextBoxColumn7.Width = 120;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.groupUrgats);
			this.tabPage2.Controls.Add(this.groupAnimal);
			this.tabPage2.ImageIndex = 2;
			this.tabPage2.Location = new System.Drawing.Point(4, 4);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(608, 418);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Туслах аж ахуй";
			// 
			// groupUrgats
			// 
			this.groupUrgats.Controls.Add(this.label31);
			this.groupUrgats.Controls.Add(this.label30);
			this.groupUrgats.Controls.Add(this.label29);
			this.groupUrgats.Controls.Add(this.label28);
			this.groupUrgats.Controls.Add(this.label27);
			this.groupUrgats.Controls.Add(this.textHarvest);
			this.groupUrgats.Controls.Add(this.label26);
			this.groupUrgats.Controls.Add(this.textSeed);
			this.groupUrgats.Controls.Add(this.label25);
			this.groupUrgats.Controls.Add(this.textVegetable);
			this.groupUrgats.Controls.Add(this.label24);
			this.groupUrgats.Controls.Add(this.textFruit);
			this.groupUrgats.Controls.Add(this.label23);
			this.groupUrgats.Controls.Add(this.textField);
			this.groupUrgats.Location = new System.Drawing.Point(248, 8);
			this.groupUrgats.Name = "groupUrgats";
			this.groupUrgats.Size = new System.Drawing.Size(296, 368);
			this.groupUrgats.TabIndex = 2;
			this.groupUrgats.TabStop = false;
			this.groupUrgats.Text = " Тариа ногоо ";
			// 
			// label31
			// 
			this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label31.Location = new System.Drawing.Point(256, 24);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(24, 16);
			this.label31.TabIndex = 0;
			this.label31.Text = "(тн)";
			// 
			// label30
			// 
			this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label30.Location = new System.Drawing.Point(256, 104);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(24, 16);
			this.label30.TabIndex = 1;
			this.label30.Text = "(тн)";
			// 
			// label29
			// 
			this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label29.Location = new System.Drawing.Point(256, 80);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(24, 16);
			this.label29.TabIndex = 2;
			this.label29.Text = "(тн)";
			// 
			// label28
			// 
			this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label28.Location = new System.Drawing.Point(256, 56);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(24, 16);
			this.label28.TabIndex = 3;
			this.label28.Text = "(тн)";
			// 
			// label27
			// 
			this.label27.Location = new System.Drawing.Point(16, 24);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(92, 16);
			this.label27.TabIndex = 4;
			this.label27.Text = "Ургац:";
			// 
			// textHarvest
			// 
			this.textHarvest.AcceptsReturn = true;
			this.textHarvest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.textHarvest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textHarvest.Location = new System.Drawing.Point(128, 24);
			this.textHarvest.MaxLength = 4;
			this.textHarvest.Name = "textHarvest";
			this.textHarvest.Size = new System.Drawing.Size(116, 20);
			this.textHarvest.TabIndex = 5;
			this.textHarvest.Text = "";
			// 
			// label26
			// 
			this.label26.Location = new System.Drawing.Point(16, 56);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(92, 16);
			this.label26.TabIndex = 6;
			this.label26.Text = "Үр, тариа:";
			// 
			// textSeed
			// 
			this.textSeed.AcceptsReturn = true;
			this.textSeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.textSeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textSeed.Location = new System.Drawing.Point(128, 56);
			this.textSeed.MaxLength = 4;
			this.textSeed.Name = "textSeed";
			this.textSeed.Size = new System.Drawing.Size(116, 20);
			this.textSeed.TabIndex = 7;
			this.textSeed.Text = "";
			// 
			// label25
			// 
			this.label25.Location = new System.Drawing.Point(16, 80);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(92, 16);
			this.label25.TabIndex = 8;
			this.label25.Text = "Хүнсний ногоо:";
			// 
			// textVegetable
			// 
			this.textVegetable.AcceptsReturn = true;
			this.textVegetable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.textVegetable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textVegetable.Location = new System.Drawing.Point(128, 80);
			this.textVegetable.MaxLength = 4;
			this.textVegetable.Name = "textVegetable";
			this.textVegetable.Size = new System.Drawing.Size(116, 20);
			this.textVegetable.TabIndex = 9;
			this.textVegetable.Text = "";
			// 
			// label24
			// 
			this.label24.Location = new System.Drawing.Point(16, 104);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(96, 16);
			this.label24.TabIndex = 10;
			this.label24.Text = "Жимс, жимсгэнэ:";
			// 
			// textFruit
			// 
			this.textFruit.AcceptsReturn = true;
			this.textFruit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.textFruit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textFruit.Location = new System.Drawing.Point(128, 104);
			this.textFruit.MaxLength = 4;
			this.textFruit.Name = "textFruit";
			this.textFruit.Size = new System.Drawing.Size(116, 20);
			this.textFruit.TabIndex = 11;
			this.textFruit.Text = "";
			// 
			// label23
			// 
			this.label23.Location = new System.Drawing.Point(16, 136);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(144, 16);
			this.label23.TabIndex = 12;
			this.label23.Text = "Тариалангийн талбай (га):";
			// 
			// textField
			// 
			this.textField.AcceptsReturn = true;
			this.textField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.textField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textField.Location = new System.Drawing.Point(16, 152);
			this.textField.MaxLength = 3;
			this.textField.Name = "textField";
			this.textField.Size = new System.Drawing.Size(148, 20);
			this.textField.TabIndex = 13;
			this.textField.Text = "";
			// 
			// groupAnimal
			// 
			this.groupAnimal.Controls.Add(this.textAnimal);
			this.groupAnimal.Controls.Add(this.label22);
			this.groupAnimal.Controls.Add(this.textBird);
			this.groupAnimal.Controls.Add(this.label21);
			this.groupAnimal.Controls.Add(this.textPig);
			this.groupAnimal.Controls.Add(this.label20);
			this.groupAnimal.Controls.Add(this.textCamel);
			this.groupAnimal.Controls.Add(this.label19);
			this.groupAnimal.Controls.Add(this.textHorse);
			this.groupAnimal.Controls.Add(this.label18);
			this.groupAnimal.Controls.Add(this.textCow);
			this.groupAnimal.Controls.Add(this.label17);
			this.groupAnimal.Controls.Add(this.textGoat);
			this.groupAnimal.Controls.Add(this.label16);
			this.groupAnimal.Controls.Add(this.textSheep);
			this.groupAnimal.Controls.Add(this.label15);
			this.groupAnimal.Location = new System.Drawing.Point(16, 8);
			this.groupAnimal.Name = "groupAnimal";
			this.groupAnimal.Size = new System.Drawing.Size(213, 368);
			this.groupAnimal.TabIndex = 3;
			this.groupAnimal.TabStop = false;
			this.groupAnimal.Text = " Мал, амьтан ";
			// 
			// textAnimal
			// 
			this.textAnimal.AcceptsReturn = true;
			this.textAnimal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.textAnimal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textAnimal.Location = new System.Drawing.Point(80, 24);
			this.textAnimal.MaxLength = 4;
			this.textAnimal.Name = "textAnimal";
			this.textAnimal.Size = new System.Drawing.Size(113, 20);
			this.textAnimal.TabIndex = 0;
			this.textAnimal.Text = "";
			this.textAnimal.TextChanged += new System.EventHandler(this.textAnimal_TextChanged);
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(16, 24);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(52, 16);
			this.label22.TabIndex = 1;
			this.label22.Text = "Амьтан:";
			// 
			// textBird
			// 
			this.textBird.AcceptsReturn = true;
			this.textBird.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.textBird.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBird.Location = new System.Drawing.Point(80, 200);
			this.textBird.MaxLength = 4;
			this.textBird.Name = "textBird";
			this.textBird.Size = new System.Drawing.Size(113, 20);
			this.textBird.TabIndex = 2;
			this.textBird.Text = "";
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(16, 200);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(52, 16);
			this.label21.TabIndex = 3;
			this.label21.Text = "Шувуу:";
			// 
			// textPig
			// 
			this.textPig.AcceptsReturn = true;
			this.textPig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.textPig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textPig.Location = new System.Drawing.Point(80, 176);
			this.textPig.MaxLength = 4;
			this.textPig.Name = "textPig";
			this.textPig.Size = new System.Drawing.Size(113, 20);
			this.textPig.TabIndex = 4;
			this.textPig.Text = "";
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(16, 176);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(52, 16);
			this.label20.TabIndex = 5;
			this.label20.Text = "Гахай:";
			// 
			// textCamel
			// 
			this.textCamel.AcceptsReturn = true;
			this.textCamel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.textCamel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textCamel.Location = new System.Drawing.Point(80, 152);
			this.textCamel.MaxLength = 4;
			this.textCamel.Name = "textCamel";
			this.textCamel.Size = new System.Drawing.Size(113, 20);
			this.textCamel.TabIndex = 6;
			this.textCamel.Text = "";
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(16, 152);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(52, 16);
			this.label19.TabIndex = 7;
			this.label19.Text = "Тэмээ:";
			// 
			// textHorse
			// 
			this.textHorse.AcceptsReturn = true;
			this.textHorse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.textHorse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textHorse.Location = new System.Drawing.Point(80, 128);
			this.textHorse.MaxLength = 4;
			this.textHorse.Name = "textHorse";
			this.textHorse.Size = new System.Drawing.Size(113, 20);
			this.textHorse.TabIndex = 8;
			this.textHorse.Text = "";
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(16, 128);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(52, 16);
			this.label18.TabIndex = 9;
			this.label18.Text = "Адуу:";
			// 
			// textCow
			// 
			this.textCow.AcceptsReturn = true;
			this.textCow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.textCow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textCow.Location = new System.Drawing.Point(80, 104);
			this.textCow.MaxLength = 4;
			this.textCow.Name = "textCow";
			this.textCow.Size = new System.Drawing.Size(113, 20);
			this.textCow.TabIndex = 10;
			this.textCow.Text = "";
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(16, 104);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(52, 16);
			this.label17.TabIndex = 11;
			this.label17.Text = "Үхэр:";
			// 
			// textGoat
			// 
			this.textGoat.AcceptsReturn = true;
			this.textGoat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.textGoat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textGoat.Location = new System.Drawing.Point(80, 80);
			this.textGoat.MaxLength = 4;
			this.textGoat.Name = "textGoat";
			this.textGoat.Size = new System.Drawing.Size(113, 20);
			this.textGoat.TabIndex = 12;
			this.textGoat.Text = "";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(16, 80);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(52, 16);
			this.label16.TabIndex = 13;
			this.label16.Text = "Ямаа:";
			// 
			// textSheep
			// 
			this.textSheep.AcceptsReturn = true;
			this.textSheep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.textSheep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textSheep.Location = new System.Drawing.Point(80, 56);
			this.textSheep.MaxLength = 4;
			this.textSheep.Name = "textSheep";
			this.textSheep.Size = new System.Drawing.Size(113, 20);
			this.textSheep.TabIndex = 14;
			this.textSheep.Text = "";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(16, 56);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(52, 16);
			this.label15.TabIndex = 15;
			this.label15.Text = "Хонь:";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.textEqCost);
			this.tabPage3.Controls.Add(this.label33);
			this.tabPage3.Controls.Add(this.textEqAvailable);
			this.tabPage3.Controls.Add(this.label32);
			this.tabPage3.Controls.Add(this.textEqCount);
			this.tabPage3.Controls.Add(this.label14);
			this.tabPage3.Controls.Add(this.comboEqType);
			this.tabPage3.Controls.Add(this.label3);
			this.tabPage3.Controls.Add(this.textEquipment);
			this.tabPage3.Controls.Add(this.label2);
			this.tabPage3.Controls.Add(this.gridEquipment);
			this.tabPage3.ImageIndex = 0;
			this.tabPage3.Location = new System.Drawing.Point(4, 4);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(608, 418);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Тоног төхөөрөмж";
			// 
			// textEqCost
			// 
			this.textEqCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textEqCost.Location = new System.Drawing.Point(304, 64);
			this.textEqCost.Name = "textEqCost";
			this.textEqCost.Size = new System.Drawing.Size(104, 20);
			this.textEqCost.TabIndex = 10;
			this.textEqCost.Text = "";
			// 
			// label33
			// 
			this.label33.Location = new System.Drawing.Point(216, 64);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(80, 16);
			this.label33.TabIndex = 9;
			this.label33.Text = "Нийт үнэ:";
			// 
			// textEqAvailable
			// 
			this.textEqAvailable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textEqAvailable.Location = new System.Drawing.Point(120, 88);
			this.textEqAvailable.Name = "textEqAvailable";
			this.textEqAvailable.Size = new System.Drawing.Size(88, 20);
			this.textEqAvailable.TabIndex = 8;
			this.textEqAvailable.Text = "";
			// 
			// label32
			// 
			this.label32.Location = new System.Drawing.Point(8, 88);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(112, 16);
			this.label32.TabIndex = 7;
			this.label32.Text = "Ашиглаж байгаа нь:";
			// 
			// textEqCount
			// 
			this.textEqCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textEqCount.Location = new System.Drawing.Point(120, 64);
			this.textEqCount.Name = "textEqCount";
			this.textEqCount.Size = new System.Drawing.Size(88, 20);
			this.textEqCount.TabIndex = 6;
			this.textEqCount.Text = "";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(8, 64);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(104, 16);
			this.label14.TabIndex = 5;
			this.label14.Text = "Тоо ширхэг:";
			// 
			// comboEqType
			// 
			this.comboEqType.Items.AddRange(new object[] {
															 "хичээлийн хэрэгсэл",
															 "эд хогшил",
															 "компьютер",
															 "машин техник",
															 "бусад"});
			this.comboEqType.Location = new System.Drawing.Point(120, 32);
			this.comboEqType.Name = "comboEqType";
			this.comboEqType.Size = new System.Drawing.Size(176, 21);
			this.comboEqType.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "Төрөл, ангилал:";
			// 
			// textEquipment
			// 
			this.textEquipment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textEquipment.Location = new System.Drawing.Point(120, 8);
			this.textEquipment.Name = "textEquipment";
			this.textEquipment.Size = new System.Drawing.Size(288, 20);
			this.textEquipment.TabIndex = 2;
			this.textEquipment.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "Тоног, төхөөрөмж:";
			// 
			// gridEquipment
			// 
			this.gridEquipment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.gridEquipment.CaptionText = "Тоног төхөөрөмжийн жагсаалт";
			this.gridEquipment.DataMember = "";
			this.gridEquipment.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.gridEquipment.Location = new System.Drawing.Point(8, 120);
			this.gridEquipment.Name = "gridEquipment";
			this.gridEquipment.ReadOnly = true;
			this.gridEquipment.Size = new System.Drawing.Size(592, 288);
			this.gridEquipment.TabIndex = 0;
			this.gridEquipment.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
																									  this.dataGridTableStyle1});
			this.gridEquipment.Navigate += new System.Windows.Forms.NavigateEventHandler(this.gridEquipment_Navigate);
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.DataGrid = this.gridEquipment;
			this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
																												  this.dataGridTextBoxColumn1,
																												  this.dataGridTextBoxColumn2,
																												  this.dataGridTextBoxColumn3,
																												  this.dataGridTextBoxColumn4,
																												  this.dataGridTextBoxColumn5});
			this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridTableStyle1.MappingName = "Equipment";
			// 
			// dataGridTextBoxColumn1
			// 
			this.dataGridTextBoxColumn1.Format = "";
			this.dataGridTextBoxColumn1.FormatInfo = null;
			this.dataGridTextBoxColumn1.HeaderText = "Тоног төхөөрөмж";
			this.dataGridTextBoxColumn1.MappingName = "c_Equipment";
			this.dataGridTextBoxColumn1.Width = 200;
			// 
			// dataGridTextBoxColumn2
			// 
			this.dataGridTextBoxColumn2.Format = "";
			this.dataGridTextBoxColumn2.FormatInfo = null;
			this.dataGridTextBoxColumn2.HeaderText = "Төрөл";
			this.dataGridTextBoxColumn2.MappingName = "c_Type";
			this.dataGridTextBoxColumn2.Width = 75;
			// 
			// dataGridTextBoxColumn3
			// 
			this.dataGridTextBoxColumn3.Format = "";
			this.dataGridTextBoxColumn3.FormatInfo = null;
			this.dataGridTextBoxColumn3.HeaderText = "Тоо ширхэг";
			this.dataGridTextBoxColumn3.MappingName = "c_Count";
			this.dataGridTextBoxColumn3.Width = 50;
			// 
			// dataGridTextBoxColumn4
			// 
			this.dataGridTextBoxColumn4.Format = "";
			this.dataGridTextBoxColumn4.FormatInfo = null;
			this.dataGridTextBoxColumn4.HeaderText = "Ашиглаж байгаа";
			this.dataGridTextBoxColumn4.MappingName = "c_AvailableCount";
			this.dataGridTextBoxColumn4.Width = 50;
			// 
			// dataGridTextBoxColumn5
			// 
			this.dataGridTextBoxColumn5.Format = "";
			this.dataGridTextBoxColumn5.FormatInfo = null;
			this.dataGridTextBoxColumn5.HeaderText = "Нийт үнэ";
			this.dataGridTextBoxColumn5.MappingName = "c_Cost";
			this.dataGridTextBoxColumn5.Width = 75;
			// 
			// images
			// 
			this.images.ImageSize = new System.Drawing.Size(16, 16);
			this.images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images.ImageStream")));
			this.images.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// EBSMB
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(664, 469);
			this.Controls.Add(this.tabMaterial);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "EBSMB";
			this.Text = "EBS Материаллаг бааз";
			this.Controls.SetChildIndex(this.panelHead, 0);
			this.Controls.SetChildIndex(this.tabMaterial, 0);
			this.tabMaterial.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridBuilding)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.groupUrgats.ResumeLayout(false);
			this.groupAnimal.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridEquipment)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void BindControls() {
			try {
				gridBuilding.DataSource = DB.Buildings;
				gridEquipment.DataSource = DB.Equipments;

				textBuilding.DataBindings.Add("Text", DB.Buildings, "c_Building");
				comboDesc.DataBindings.Add("Text", DB.Buildings, "c_Desc");
				checkAvailable.DataBindings.Add("Checked", DB.Buildings, "c_Available");
				checkUsingByDesc.DataBindings.Add("Checked", DB.Buildings, "c_UsingByDesc");
				textBuildYear.DataBindings.Add("Text", DB.Buildings, "c_BuildYear");
				textCost.DataBindings.Add("Text", DB.Buildings, "c_Cost");
				textCardinality.DataBindings.Add("Text", DB.Buildings, "c_Cardinality");
				textRoomCount.DataBindings.Add("Text", DB.Buildings, "c_RoomCount");
				comboHeatingType.DataBindings.Add("Text", DB.Buildings, "c_HeatingType");
				textHeatingCapacity.DataBindings.Add("Text", DB.Buildings, "c_HeatingCapacity");
				checkNECapable.DataBindings.Add("Checked", DB.Buildings, "c_NECapable");
				checkUsableInWinter.DataBindings.Add("Checked", DB.Buildings, "c_UsableInWinter");
				comboQuality.DataBindings.Add("Text", DB.Buildings, "c_Quality");
				checkRepairReq.DataBindings.Add("Checked", DB.Buildings, "c_RepairNeed");
				textRepairCost.DataBindings.Add("Text", DB.Buildings, "c_RepairCost");

				textEquipment.DataBindings.Add("Text", DB.Equipments, "c_Equipment");
				comboEqType.DataBindings.Add("Text", DB.Equipments, "c_Type");
				textEqCount.DataBindings.Add("Text", DB.Equipments, "c_Count");
				textEqAvailable.DataBindings.Add("Text", DB.Equipments, "c_AvailableCount");
				textEqCost.DataBindings.Add("Text", DB.Equipments, "c_Cost");

				textAnimal.DataBindings.Add("Text", DB.Husbandry, "c_Animals");
				textSheep.DataBindings.Add("Text", DB.Husbandry, "c_Sheep");
				textGoat.DataBindings.Add("Text", DB.Husbandry, "c_Goat");
				textCow.DataBindings.Add("Text", DB.Husbandry, "c_Cow");
				textHorse.DataBindings.Add("Text", DB.Husbandry, "c_Horse");
				textCamel.DataBindings.Add("Text", DB.Husbandry, "c_Camel");
				textPig.DataBindings.Add("Text", DB.Husbandry, "c_Pig");
				textBird.DataBindings.Add("Text", DB.Husbandry, "c_Bird");
				textHarvest.DataBindings.Add("Text", DB.Husbandry, "c_Harvest");
				textSeed.DataBindings.Add("Text", DB.Husbandry, "c_Seed");
				textVegetable.DataBindings.Add("Text", DB.Husbandry, "c_Vegetable");
				textFruit.DataBindings.Add("Text", DB.Husbandry, "c_Fruit");
				textField.DataBindings.Add("Text", DB.Husbandry, "c_Field");
			}
			catch {}
		}

		public override void LoadData() {
			Cursor.Current = Cursors.WaitCursor;

			try {
				DB.LoadBuilding(arcid);
				DB.LoadEquipment(arcid);
				DB.LoadHusbandry(arcid);
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
				if (tabMaterial.SelectedIndex == 0) {
					this.BindingContext[DB.Buildings, ""].EndCurrentEdit();
					DataRowView row  = (DataRowView)this.BindingContext[DB.Buildings, ""].Current;
					Building b = new Building();
					b.arcid = arcid;

					if (b.arcid > 0) {
						try {
							b.building = row["c_building"].ToString();
							b.desc = row["c_desc"].ToString();
							b.buildyear = Convert.ToInt32(row["c_buildyear"]);
							b.cardinality = Convert.ToInt32(row["c_cardinality"]);
							b.roomcount = Convert.ToInt32(row["c_roomcount"]);
							b.quality = row["c_quality"].ToString();
							b.cost = Convert.ToSingle(row["c_cost"]);
							b.available = Convert.ToBoolean(row["c_available"]);
							b.usingbydesc = Convert.ToBoolean(row["c_usingbydesc"]);
							b.heatingtype = row["c_heatingtype"].ToString();
							b.heatingcapacity = Convert.ToSingle(row["c_heatingcapacity"]);
							b.necapable = Convert.ToBoolean(row["c_necapable"]);
							b.usableinwinter = Convert.ToBoolean(row["c_usableinwinter"]);
							b.repairneed = Convert.ToBoolean(row["c_repairneed"]);
							b.repaircost = Convert.ToSingle(row["c_repaircost"]);
						}
						catch {}

						DB.Save(b);
					}
				
				}
				else if (tabMaterial.SelectedIndex == 1) {
					this.BindingContext[DB.Husbandry, ""].EndCurrentEdit();
					DataRowView row  = (DataRowView)this.BindingContext[DB.Husbandry, ""].Current;
					Husbandry h = new Husbandry();
					h.arcid = arcid;

					if (h.arcid > 0) {
						try {
							h.animals = Convert.ToInt32(row["c_animals"]);
							h.harvest = Convert.ToInt32(row["c_harvest"]);
							h.field = Convert.ToSingle(row["c_field"]);
							h.sheep = Convert.ToInt32(row["c_sheep"]);
							h.goat = Convert.ToInt32(row["c_goat"]);
							h.cow = Convert.ToInt32(row["c_cow"]);
							h.camel = Convert.ToInt32(row["c_camel"]);
							h.pig = Convert.ToInt32(row["c_pig"]);
							h.bird = Convert.ToInt32(row["c_bird"]);
							h.seed = Convert.ToInt32(row["c_seed"]);
							h.vegetable = Convert.ToInt32(row["c_vegetable"]);
							h.fruit = Convert.ToInt32(row["c_fruit"]);
						}
						catch {}

						DB.Save(h);
					}
				}
				else if (tabMaterial.SelectedIndex == 2) {
					this.BindingContext[DB.Equipments, ""].EndCurrentEdit();
					DataRowView row  = (DataRowView)this.BindingContext[DB.Equipments, ""].Current;
					Equipment e = new Equipment();
					e.arcid = arcid;

					if (e.arcid > 0) {
						try {
							e.equipment = row["c_equipment"].ToString();
							e.type = row["c_type"].ToString();
							e.count = Convert.ToInt32(row["c_count"]);
							e.acount = Convert.ToInt32(row["c_availablecount"]);
							e.cost = Convert.ToSingle(row["c_cost"]);
						}
						catch {}

						DB.Save(e);
					}
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
			if (tabMaterial.SelectedIndex == 0) {
				try {
					this.BindingContext[DB.Buildings, ""].EndCurrentEdit();
					this.BindingContext[DB.Buildings, ""].AddNew();
				}
				catch (Exception ex) {
					MessageBox.Show(ex.Message, "EBS", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else if (tabMaterial.SelectedIndex == 1) {
			}
			else if (tabMaterial.SelectedIndex == 2) {
				try {
					this.BindingContext[DB.Equipments, ""].EndCurrentEdit();
					this.BindingContext[DB.Equipments, ""].AddNew();
				}
				catch (Exception ex) {
					MessageBox.Show(ex.Message, "EBS", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void gridBuilding_Navigate(object sender, NavigateEventArgs ne) {
		
		}

		private void gridEquipment_Navigate(object sender, NavigateEventArgs ne) {
		
		}

		private void textAnimal_TextChanged(object sender, System.EventArgs e) {
		
		}
	}
}
