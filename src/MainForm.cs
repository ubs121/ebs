using System;
using System.Reflection;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace EBS {
	/// <summary>
	/// Summary description for Roamer.
	/// </summary>
	public class MainForm : Form {
		private ToolBarButton toolOption;
		private ImageList images;
		private MainMenu mainMenu;
		private MenuItem cmdExit;
		private MenuItem menuWindow;
		private MenuItem cmdCascade;
		private MenuItem cmdHTile;
		private MenuItem cmdVTile;
		private MenuItem cmdArrange;
		private MenuItem cmdOption;
		private MenuItem cmdHelp;
		private MenuItem cmdAbout;
		private ToolBar toolBar;
		private ToolBarButton toolConnect;
		private ToolBarButton toolSep1;
		private MenuItem cmdConnect;
		private MenuItem menuItem2;
		private System.Data.SqlClient.SqlConnection con;
		private MenuItem menuDatabase;
		private ToolBarButton toolSep2;
		private MenuItem menuEBS;
		private MenuItem cmdEBS01;
		private MenuItem cmdEBS02;
		private MenuItem cmdEBS03;
		private MenuItem cmdEBS05;
		private MenuItem cmdEBS06;
		private MenuItem cmdEBS07;
		private MenuItem cmdEBS07A;
		private MenuItem cmdEBS08;
		private MenuItem cmdEBS09;
		private MenuItem cmdEBS10;
		private MenuItem cmdEBS11;
		private MenuItem cmdEBS13;
		private MenuItem cmdEBS14;
		private MenuItem cmdEBS15;
		private ToolBarButton toolNew;
		private ToolBarButton toolSave;
		private ToolBarButton toolRefresh;
		private MenuItem cmdEBS12;
		private ToolBarButton toolRemove;
		private MenuItem menuReport;
		private MenuItem cmdMap;
		private MenuItem cmdChart;
		private MenuItem cmdEBSTeacher;
		private MenuItem cmdReport;
		private MenuItem cmdEBSMB;
		private MenuItem menuItem4;
		private MenuItem cmdPrint;
		private MenuItem cmdPrintPreview;
		private ToolBarButton toolPrint;
		private ToolBarButton toolPreview;
		private ToolBarButton toolBarButton1;
		private MenuItem cmdNew;
		private MenuItem cmdSave;
		private MenuItem cmdRefresh;
		private MenuItem menuItem6;
		private MenuItem cmdRemove;
		private System.Windows.Forms.MenuItem cmdEBSIND;
		
		private System.ComponentModel.IContainer components;

		public MainForm() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			this.Show();
			this.Update();


			CheckConnection();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if (components != null) {
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
			this.mainMenu = new System.Windows.Forms.MainMenu();
			this.menuDatabase = new System.Windows.Forms.MenuItem();
			this.cmdConnect = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.cmdNew = new System.Windows.Forms.MenuItem();
			this.cmdSave = new System.Windows.Forms.MenuItem();
			this.cmdRemove = new System.Windows.Forms.MenuItem();
			this.cmdRefresh = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.cmdPrint = new System.Windows.Forms.MenuItem();
			this.cmdPrintPreview = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.cmdExit = new System.Windows.Forms.MenuItem();
			this.menuEBS = new System.Windows.Forms.MenuItem();
			this.cmdEBS01 = new System.Windows.Forms.MenuItem();
			this.cmdEBS02 = new System.Windows.Forms.MenuItem();
			this.cmdEBS03 = new System.Windows.Forms.MenuItem();
			this.cmdEBS05 = new System.Windows.Forms.MenuItem();
			this.cmdEBS06 = new System.Windows.Forms.MenuItem();
			this.cmdEBS07 = new System.Windows.Forms.MenuItem();
			this.cmdEBS07A = new System.Windows.Forms.MenuItem();
			this.cmdEBS08 = new System.Windows.Forms.MenuItem();
			this.cmdEBS09 = new System.Windows.Forms.MenuItem();
			this.cmdEBS10 = new System.Windows.Forms.MenuItem();
			this.cmdEBS11 = new System.Windows.Forms.MenuItem();
			this.cmdEBS12 = new System.Windows.Forms.MenuItem();
			this.cmdEBS13 = new System.Windows.Forms.MenuItem();
			this.cmdEBS14 = new System.Windows.Forms.MenuItem();
			this.cmdEBS15 = new System.Windows.Forms.MenuItem();
			this.cmdEBSTeacher = new System.Windows.Forms.MenuItem();
			this.cmdEBSMB = new System.Windows.Forms.MenuItem();
			this.cmdEBSIND = new System.Windows.Forms.MenuItem();
			this.menuReport = new System.Windows.Forms.MenuItem();
			this.cmdReport = new System.Windows.Forms.MenuItem();
			this.cmdChart = new System.Windows.Forms.MenuItem();
			this.cmdMap = new System.Windows.Forms.MenuItem();
			this.cmdOption = new System.Windows.Forms.MenuItem();
			this.menuWindow = new System.Windows.Forms.MenuItem();
			this.cmdCascade = new System.Windows.Forms.MenuItem();
			this.cmdHTile = new System.Windows.Forms.MenuItem();
			this.cmdVTile = new System.Windows.Forms.MenuItem();
			this.cmdArrange = new System.Windows.Forms.MenuItem();
			this.cmdHelp = new System.Windows.Forms.MenuItem();
			this.cmdAbout = new System.Windows.Forms.MenuItem();
			this.toolBar = new System.Windows.Forms.ToolBar();
			this.toolConnect = new System.Windows.Forms.ToolBarButton();
			this.toolSep1 = new System.Windows.Forms.ToolBarButton();
			this.toolNew = new System.Windows.Forms.ToolBarButton();
			this.toolSave = new System.Windows.Forms.ToolBarButton();
			this.toolRemove = new System.Windows.Forms.ToolBarButton();
			this.toolRefresh = new System.Windows.Forms.ToolBarButton();
			this.toolBarButton1 = new System.Windows.Forms.ToolBarButton();
			this.toolPrint = new System.Windows.Forms.ToolBarButton();
			this.toolPreview = new System.Windows.Forms.ToolBarButton();
			this.toolSep2 = new System.Windows.Forms.ToolBarButton();
			this.toolOption = new System.Windows.Forms.ToolBarButton();
			this.images = new System.Windows.Forms.ImageList(this.components);
			this.con = new System.Data.SqlClient.SqlConnection();
			this.SuspendLayout();
			// 
			// mainMenu
			// 
			this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.menuDatabase,
																					 this.menuEBS,
																					 this.menuReport,
																					 this.cmdOption,
																					 this.menuWindow,
																					 this.cmdHelp});
			// 
			// menuDatabase
			// 
			this.menuDatabase.Index = 0;
			this.menuDatabase.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.cmdConnect,
																						 this.menuItem4,
																						 this.cmdNew,
																						 this.cmdSave,
																						 this.cmdRemove,
																						 this.cmdRefresh,
																						 this.menuItem6,
																						 this.cmdPrint,
																						 this.cmdPrintPreview,
																						 this.menuItem2,
																						 this.cmdExit});
			this.menuDatabase.Text = "&Файл";
			// 
			// cmdConnect
			// 
			this.cmdConnect.Index = 0;
			this.cmdConnect.Shortcut = System.Windows.Forms.Shortcut.CtrlL;
			this.cmdConnect.Text = "&Холбох";
			this.cmdConnect.Click += new System.EventHandler(this.Connect);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 1;
			this.menuItem4.Text = "-";
			// 
			// cmdNew
			// 
			this.cmdNew.Index = 2;
			this.cmdNew.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
			this.cmdNew.Text = "Шинэ";
			this.cmdNew.Click += new System.EventHandler(this.SendCommand);
			// 
			// cmdSave
			// 
			this.cmdSave.Index = 3;
			this.cmdSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
			this.cmdSave.Text = "Хадгалах";
			this.cmdSave.Click += new System.EventHandler(this.SendCommand);
			// 
			// cmdRemove
			// 
			this.cmdRemove.Index = 4;
			this.cmdRemove.Shortcut = System.Windows.Forms.Shortcut.ShiftDel;
			this.cmdRemove.Text = "Устгах";
			this.cmdRemove.Click += new System.EventHandler(this.SendCommand);
			// 
			// cmdRefresh
			// 
			this.cmdRefresh.Index = 5;
			this.cmdRefresh.Shortcut = System.Windows.Forms.Shortcut.F5;
			this.cmdRefresh.Text = "Сэргээж харах";
			this.cmdRefresh.Click += new System.EventHandler(this.SendCommand);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 6;
			this.menuItem6.Text = "-";
			// 
			// cmdPrint
			// 
			this.cmdPrint.Index = 7;
			this.cmdPrint.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
			this.cmdPrint.Text = "Х&эвлэх";
			this.cmdPrint.Click += new System.EventHandler(this.SendCommand);
			// 
			// cmdPrintPreview
			// 
			this.cmdPrintPreview.Index = 8;
			this.cmdPrintPreview.Text = "Хэвлэхийн &өмнө харах";
			this.cmdPrintPreview.Click += new System.EventHandler(this.SendCommand);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 9;
			this.menuItem2.Text = "-";
			// 
			// cmdExit
			// 
			this.cmdExit.Index = 10;
			this.cmdExit.Text = "&Гарах";
			this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
			// 
			// menuEBS
			// 
			this.menuEBS.Index = 1;
			this.menuEBS.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.cmdEBS01,
																					this.cmdEBS02,
																					this.cmdEBS03,
																					this.cmdEBS05,
																					this.cmdEBS06,
																					this.cmdEBS07,
																					this.cmdEBS07A,
																					this.cmdEBS08,
																					this.cmdEBS09,
																					this.cmdEBS10,
																					this.cmdEBS11,
																					this.cmdEBS12,
																					this.cmdEBS13,
																					this.cmdEBS14,
																					this.cmdEBS15,
																					this.cmdEBSTeacher,
																					this.cmdEBSMB,
																					this.cmdEBSIND});
			this.menuEBS.Text = "&ЕБС Маягтууд";
			this.menuEBS.Click += new System.EventHandler(this.ShowMDIChild);
			// 
			// cmdEBS01
			// 
			this.cmdEBS01.Index = 0;
			this.cmdEBS01.RadioCheck = true;
			this.cmdEBS01.Shortcut = System.Windows.Forms.Shortcut.CtrlF1;
			this.cmdEBS01.Text = "EBS01";
			this.cmdEBS01.Click += new System.EventHandler(this.ShowMDIChild);
			// 
			// cmdEBS02
			// 
			this.cmdEBS02.Index = 1;
			this.cmdEBS02.RadioCheck = true;
			this.cmdEBS02.Shortcut = System.Windows.Forms.Shortcut.CtrlF2;
			this.cmdEBS02.Text = "EBS02";
			this.cmdEBS02.Click += new System.EventHandler(this.ShowMDIChild);
			// 
			// cmdEBS03
			// 
			this.cmdEBS03.Index = 2;
			this.cmdEBS03.RadioCheck = true;
			this.cmdEBS03.Shortcut = System.Windows.Forms.Shortcut.CtrlF3;
			this.cmdEBS03.Text = "EBS03";
			this.cmdEBS03.Click += new System.EventHandler(this.ShowMDIChild);
			// 
			// cmdEBS05
			// 
			this.cmdEBS05.Index = 3;
			this.cmdEBS05.RadioCheck = true;
			this.cmdEBS05.Shortcut = System.Windows.Forms.Shortcut.CtrlF5;
			this.cmdEBS05.Text = "EBS05";
			this.cmdEBS05.Click += new System.EventHandler(this.ShowMDIChild);
			// 
			// cmdEBS06
			// 
			this.cmdEBS06.Index = 4;
			this.cmdEBS06.RadioCheck = true;
			this.cmdEBS06.Shortcut = System.Windows.Forms.Shortcut.CtrlF6;
			this.cmdEBS06.Text = "EBS06";
			this.cmdEBS06.Click += new System.EventHandler(this.ShowMDIChild);
			// 
			// cmdEBS07
			// 
			this.cmdEBS07.Index = 5;
			this.cmdEBS07.RadioCheck = true;
			this.cmdEBS07.Shortcut = System.Windows.Forms.Shortcut.CtrlF7;
			this.cmdEBS07.Text = "EBS07";
			this.cmdEBS07.Click += new System.EventHandler(this.ShowMDIChild);
			// 
			// cmdEBS07A
			// 
			this.cmdEBS07A.Index = 6;
			this.cmdEBS07A.RadioCheck = true;
			this.cmdEBS07A.Text = "EBS07A";
			this.cmdEBS07A.Click += new System.EventHandler(this.ShowMDIChild);
			// 
			// cmdEBS08
			// 
			this.cmdEBS08.Index = 7;
			this.cmdEBS08.RadioCheck = true;
			this.cmdEBS08.Shortcut = System.Windows.Forms.Shortcut.CtrlF8;
			this.cmdEBS08.Text = "EBS08";
			this.cmdEBS08.Click += new System.EventHandler(this.ShowMDIChild);
			// 
			// cmdEBS09
			// 
			this.cmdEBS09.Index = 8;
			this.cmdEBS09.RadioCheck = true;
			this.cmdEBS09.Shortcut = System.Windows.Forms.Shortcut.CtrlF9;
			this.cmdEBS09.Text = "EBS09";
			this.cmdEBS09.Click += new System.EventHandler(this.ShowMDIChild);
			// 
			// cmdEBS10
			// 
			this.cmdEBS10.Index = 9;
			this.cmdEBS10.RadioCheck = true;
			this.cmdEBS10.Shortcut = System.Windows.Forms.Shortcut.CtrlF10;
			this.cmdEBS10.Text = "EBS10";
			this.cmdEBS10.Click += new System.EventHandler(this.ShowMDIChild);
			// 
			// cmdEBS11
			// 
			this.cmdEBS11.Index = 10;
			this.cmdEBS11.RadioCheck = true;
			this.cmdEBS11.Shortcut = System.Windows.Forms.Shortcut.CtrlF11;
			this.cmdEBS11.Text = "EBS11";
			this.cmdEBS11.Click += new System.EventHandler(this.ShowMDIChild);
			// 
			// cmdEBS12
			// 
			this.cmdEBS12.Index = 11;
			this.cmdEBS12.Shortcut = System.Windows.Forms.Shortcut.CtrlF12;
			this.cmdEBS12.Text = "EBS12";
			this.cmdEBS12.Click += new System.EventHandler(this.ShowMDIChild);
			// 
			// cmdEBS13
			// 
			this.cmdEBS13.Index = 12;
			this.cmdEBS13.RadioCheck = true;
			this.cmdEBS13.Text = "EBS13";
			this.cmdEBS13.Click += new System.EventHandler(this.ShowMDIChild);
			// 
			// cmdEBS14
			// 
			this.cmdEBS14.Index = 13;
			this.cmdEBS14.RadioCheck = true;
			this.cmdEBS14.Text = "EBS14";
			this.cmdEBS14.Click += new System.EventHandler(this.ShowMDIChild);
			// 
			// cmdEBS15
			// 
			this.cmdEBS15.Index = 14;
			this.cmdEBS15.RadioCheck = true;
			this.cmdEBS15.Text = "EBS15";
			this.cmdEBS15.Click += new System.EventHandler(this.ShowMDIChild);
			// 
			// cmdEBSTeacher
			// 
			this.cmdEBSTeacher.Index = 15;
			this.cmdEBSTeacher.Text = "EBS Багш";
			this.cmdEBSTeacher.Click += new System.EventHandler(this.ShowMDIChild);
			// 
			// cmdEBSMB
			// 
			this.cmdEBSMB.Index = 16;
			this.cmdEBSMB.Text = "EBS Материаллаг бааз";
			this.cmdEBSMB.Click += new System.EventHandler(this.ShowMDIChild);
			// 
			// cmdEBSIND
			// 
			this.cmdEBSIND.Index = 17;
			this.cmdEBSIND.Text = "EBS Үзүүлэлтүүд";
			this.cmdEBSIND.Click += new System.EventHandler(this.ShowMDIChild);
			// 
			// menuReport
			// 
			this.menuReport.Index = 2;
			this.menuReport.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.cmdReport,
																					   this.cmdChart,
																					   this.cmdMap});
			this.menuReport.Text = "&Тайлан";
			// 
			// cmdReport
			// 
			this.cmdReport.Index = 0;
			this.cmdReport.Text = "&Тайлангууд";
			this.cmdReport.Click += new System.EventHandler(this.ShowMDIChild);
			// 
			// cmdChart
			// 
			this.cmdChart.Index = 1;
			this.cmdChart.Text = "График диаграмм";
			this.cmdChart.Click += new System.EventHandler(this.ShowMDIChild);
			// 
			// cmdMap
			// 
			this.cmdMap.Index = 2;
			this.cmdMap.Text = "Газарзүйн байршлаар";
			this.cmdMap.Click += new System.EventHandler(this.ShowMDIChild);
			// 
			// cmdOption
			// 
			this.cmdOption.Index = 3;
			this.cmdOption.Text = "Т&охиргоо";
			this.cmdOption.Click += new System.EventHandler(this.ShowOption);
			// 
			// menuWindow
			// 
			this.menuWindow.Index = 4;
			this.menuWindow.MdiList = true;
			this.menuWindow.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.cmdCascade,
																					   this.cmdHTile,
																					   this.cmdVTile,
																					   this.cmdArrange});
			this.menuWindow.Text = "&Цонх";
			// 
			// cmdCascade
			// 
			this.cmdCascade.Index = 0;
			this.cmdCascade.Text = "&Жагсаах";
			this.cmdCascade.Click += new System.EventHandler(this.cmdCascade_Click);
			// 
			// cmdHTile
			// 
			this.cmdHTile.Index = 1;
			this.cmdHTile.Text = "&Хэвтээ зэрэгцүүлэх";
			this.cmdHTile.Click += new System.EventHandler(this.cmdHTile_Click);
			// 
			// cmdVTile
			// 
			this.cmdVTile.Index = 2;
			this.cmdVTile.Text = "&Босоо зэрэгцүүлэх";
			this.cmdVTile.Click += new System.EventHandler(this.cmdVTile_Click);
			// 
			// cmdArrange
			// 
			this.cmdArrange.Index = 3;
			this.cmdArrange.Text = "&Цэглэх";
			this.cmdArrange.Click += new System.EventHandler(this.cmdArrange_Click);
			// 
			// cmdHelp
			// 
			this.cmdHelp.Index = 5;
			this.cmdHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.cmdAbout});
			this.cmdHelp.Text = "&Тусламж";
			// 
			// cmdAbout
			// 
			this.cmdAbout.Index = 0;
			this.cmdAbout.Text = "&Тухай";
			this.cmdAbout.Click += new System.EventHandler(this.cmdAbout_Click);
			// 
			// toolBar
			// 
			this.toolBar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
			this.toolBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
																					   this.toolConnect,
																					   this.toolSep1,
																					   this.toolNew,
																					   this.toolSave,
																					   this.toolRemove,
																					   this.toolRefresh,
																					   this.toolBarButton1,
																					   this.toolPrint,
																					   this.toolPreview,
																					   this.toolSep2,
																					   this.toolOption});
			this.toolBar.ButtonSize = new System.Drawing.Size(32, 32);
			this.toolBar.DropDownArrows = true;
			this.toolBar.ImageList = this.images;
			this.toolBar.Location = new System.Drawing.Point(0, 0);
			this.toolBar.Name = "toolBar";
			this.toolBar.ShowToolTips = true;
			this.toolBar.Size = new System.Drawing.Size(640, 44);
			this.toolBar.TabIndex = 1;
			this.toolBar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar_ButtonClick);
			// 
			// toolConnect
			// 
			this.toolConnect.ImageIndex = 0;
			this.toolConnect.ToolTipText = "Сервер рүү холбох";
			// 
			// toolSep1
			// 
			this.toolSep1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolNew
			// 
			this.toolNew.ImageIndex = 15;
			this.toolNew.ToolTipText = "Шинэ баримт";
			// 
			// toolSave
			// 
			this.toolSave.ImageIndex = 14;
			this.toolSave.ToolTipText = "Хадгалах";
			// 
			// toolRemove
			// 
			this.toolRemove.ImageIndex = 17;
			this.toolRemove.ToolTipText = "Устгах";
			// 
			// toolRefresh
			// 
			this.toolRefresh.ImageIndex = 6;
			this.toolRefresh.ToolTipText = "Сэргээж харах";
			// 
			// toolBarButton1
			// 
			this.toolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolPrint
			// 
			this.toolPrint.ImageIndex = 16;
			this.toolPrint.ToolTipText = "Хэвлэх";
			// 
			// toolPreview
			// 
			this.toolPreview.ImageIndex = 18;
			this.toolPreview.ToolTipText = "Хэвлэхийн өмнө харах";
			// 
			// toolSep2
			// 
			this.toolSep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
			// 
			// toolOption
			// 
			this.toolOption.ImageIndex = 13;
			this.toolOption.ToolTipText = "Тохиргоо";
			// 
			// images
			// 
			this.images.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.images.ImageSize = new System.Drawing.Size(32, 32);
			this.images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images.ImageStream")));
			this.images.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// con
			// 
			this.con.ConnectionString = "workstation id=UUGAN;application name=Roamer;packet size=4096;user id=sa;data sou" +
				"rce=billgsm;persist security info=False;initial catalog=Mobicom";
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(640, 401);
			this.Controls.Add(this.toolBar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.Menu = this.mainMenu;
			this.Name = "MainForm";
			this.Text = "EBS";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.EBS_Closing);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.Run(new MainForm());
		}

		private void cmdExit_Click(object sender, System.EventArgs e) {
			AppSetting.SaveSetting();
			Application.Exit();
		}

		private void EBS_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
			if (MessageBox.Show("Програмаас гарах уу?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				cmdExit_Click(sender, e);
			else
				e.Cancel = true;
		}

		private void cmdCascade_Click(object sender, System.EventArgs e) {
			LayoutMdi(MdiLayout.Cascade);
		}

		private void cmdHTile_Click(object sender, System.EventArgs e) {
			LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void cmdVTile_Click(object sender, System.EventArgs e) {
			LayoutMdi(MdiLayout.TileVertical);
		}

		private void cmdArrange_Click(object sender, System.EventArgs e) {
			LayoutMdi(MdiLayout.ArrangeIcons);
		}

		private void SendKey(int key) {
			if (ActiveControl != null) {
				Win32.SendMessage(ActiveControl.Handle, Win32.WM_KEYDOWN, key, 1);
			}
		}
		private void SendCommand(object source, EventArgs e) {
			SendKey((int) ((MenuItem) source).Shortcut);
		}

		private void toolBar_ButtonClick(object sender, ToolBarButtonClickEventArgs e) {
			if (e.Button == toolConnect)
				Connect(sender, e);
			else if (e.Button == toolNew)
				SendKey((int)(Keys.ControlKey | Keys.N)); // Ctrl + N
			else if (e.Button == toolSave)
				SendKey((int)(Keys.ControlKey | Keys.S)); // Ctrl + S
			else if (e.Button == toolRemove)
				SendKey((int)(Keys.ShiftKey | Keys.Delete));				// Delete
			else if (e.Button == toolRefresh)
				SendKey((int)(Keys.F5));				// Refresh
			else if (e.Button == toolOption)
				ShowOption(sender, e);				// Option
			else if (e.Button == toolPrint)
				SendKey((int)(Keys.ControlKey | Keys.P));				// Print
		}

		private void ShowMDIChild(object sender, System.EventArgs e) {
			Type t = null;
			if (sender.Equals(cmdEBS01))
				t = typeof(EBS01);
			else if (sender.Equals(cmdEBS02))
				t = typeof(EBS02);
			else if (sender.Equals(cmdEBS03))
				t = typeof(EBS03);
			else if (sender.Equals(cmdEBS05))
				t = typeof(EBS05);
			else if (sender.Equals(cmdEBS06))
				t = typeof(EBS06);
			else if (sender.Equals(cmdEBS07))
				t = typeof(EBS07);
			else if (sender.Equals(cmdEBS07A))
				t = typeof(EBS07A);
			else if (sender.Equals(cmdEBS08))
				t = typeof(EBS08);
			else if (sender.Equals(cmdEBS09))
				t = typeof(EBS09);
			else if (sender.Equals(cmdEBS10))
				t = typeof(EBS10);
			else if (sender.Equals(cmdEBS11))
				t = typeof(EBS11);
			else if (sender.Equals(cmdEBS12))
				t = typeof(EBS12);
			else if (sender.Equals(cmdEBS13))
				t = typeof(EBS13);
			else if (sender.Equals(cmdEBS14))
				t = typeof(EBS14);
			else if (sender.Equals(cmdEBS15))
				t = typeof(EBS15);
			else if (sender.Equals(cmdEBSTeacher))
				t = typeof(EBSTeacher);
			else if (sender.Equals(cmdEBSMB))
				t = typeof(EBSMB);
			else if (sender.Equals(cmdEBSIND))
				t = typeof(EBSIND);
			else if (sender.Equals(cmdMap))
				t = typeof(MapReport);
			else if (sender.Equals(cmdChart))
				t = typeof(ChartReport);

			if (t != null) {
				foreach (Form child in this.MdiChildren) { // check previuosly created
					if (t.IsInstanceOfType(child)) {
						child.Select();
						child.Update();
						return;
					}
				}
				// create new instance
				Form form = (Form)t.InvokeMember(null, BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.CreateInstance, null, null, null);
				form.MdiParent = this;
				form.WindowState = FormWindowState.Maximized;
				form.Show();
				form.Update();
			}
		}

		private void ShowOption(object sender, System.EventArgs e) {
			OptionDlg dlg = new OptionDlg();
			dlg.textReportDir.Text = AppSetting.Get("ReportDir");
			dlg.textLogFile.Text = AppSetting.Get("LogFile");

			if (dlg.ShowDialog() == DialogResult.OK) {
				AppSetting.Set("ReportDir", dlg.textTAPDir.Text);
				AppSetting.Set("LogFile", dlg.textLogFile.Text);
			}
		}

		private void CheckConnection() {
			// try default connection
			this.Text = "Сервер рүү холбож байна...";
			Cursor.Current = Cursors.WaitCursor;
			
			if (!DB.Login()) Connect(null, null);
			
			this.Text = "EBS";
			Cursor.Current = Cursors.Default;
		}

		private void Connect(object sender, System.EventArgs e) {
			bool logged = false;

			LoginDlg dlg = new LoginDlg();
			DialogResult result;
			int counter = 3;
			dlg.textServer.Text = AppSetting.Get("DataServer");
			dlg.textUser.Text = AppSetting.Get("DataUser");
			dlg.textPassword.Text = AppSetting.DecryptPassword(AppSetting.Get("DataPassword"));
			
			do {
				if ((result = dlg.ShowDialog()) == DialogResult.OK) {
					this.Text = "Сервер рүү холбож байна...";
					Cursor.Current = Cursors.WaitCursor;
					try {
						con.ConnectionString = string.Format("application name=EBS;persist security info=true;packet size=4096;data source={0};initial catalog={1};user id={2};password={3};", dlg.textServer.Text, "ebs", dlg.textUser.Text, dlg.textPassword.Text);;
						con.Open();
						if (con.State == ConnectionState.Open) {
							AppSetting.Set("DataServer", dlg.textServer.Text);
							AppSetting.Set("DataUser", dlg.textUser.Text);
							AppSetting.Set("DataPassword", AppSetting.EncryptPassword(dlg.textPassword.Text));

							DB.strCon = con.ConnectionString;

							logged = true;
						}
						else {
							counter--;
						}
					}
					catch {
						logged = false;
					}
					finally {
						Cursor.Current = Cursors.Default;
						this.Text = "EBS";
						con.Close();
					}
				}
			}
			while (!logged && (result != DialogResult.Cancel) && counter > 0);
		}

		private void cmdAbout_Click(object sender, System.EventArgs e) {
			AboutDlg dlg = new AboutDlg();
			dlg.ShowDialog();
		}

		
		public static int ArcYear(long arcid) {
			int ret = 0;
			try {
				string str = arcid.ToString();
				ret = Convert.ToInt32(str.Substring(0, 4));
			}
			catch {}

			return ret;
		}

		public static int ArcRegion(long arcid) {
			int ret = 0;
			try {
				string str = arcid.ToString();
				if (str.Length >= 6) {
					ret = Convert.ToInt32(str.Substring(4, 2));
				}
			}
			catch {}

			return ret;
		}

		public static int ArcSchool(long arcid) {
			int ret = 0;
			try {
				string str = arcid.ToString();
				if (str.Length >= 8) {
					ret = Convert.ToInt32(str.Substring(6, 2));
				}
			}
			catch {}

			return ret;
		}


	}
}
