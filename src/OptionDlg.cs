using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace EBS {
	/// <summary>
	/// Summary description for OptionDlg.
	/// </summary>
	public class OptionDlg : Form {
		private Button buttonOk;
		private Button buttonCancel;
		private TabPage pageLocation;
		private TabControl tabOption;
		private Button buttonBrowseMoveDir;
		private Label label3;
		private SaveFileDialog dlgSaveFile;
		public TextBox textLogFile;
		private Label label2;
		private Button buttonBrowseHome;
		private Label label1;
		private FolderBrowserDialog dlgBrowse;
		public TextBox textTAPDir;
		public TextBox textReportDir;
		private TabPage pageReport;
		public TextBox textContactPerson;
		private Label label19;
		public System.Windows.Forms.TextBox textContactEmail;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TabPage pageExplorer;
		public System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label5;
		
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public OptionDlg() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(OptionDlg));
			this.tabOption = new System.Windows.Forms.TabControl();
			this.pageLocation = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.textLogFile = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonBrowseHome = new System.Windows.Forms.Button();
			this.textTAPDir = new System.Windows.Forms.TextBox();
			this.buttonBrowseMoveDir = new System.Windows.Forms.Button();
			this.textReportDir = new System.Windows.Forms.TextBox();
			this.pageReport = new System.Windows.Forms.TabPage();
			this.textContactEmail = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textContactPerson = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.pageExplorer = new System.Windows.Forms.TabPage();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
			this.dlgBrowse = new System.Windows.Forms.FolderBrowserDialog();
			this.tabOption.SuspendLayout();
			this.pageLocation.SuspendLayout();
			this.pageReport.SuspendLayout();
			this.pageExplorer.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabOption
			// 
			this.tabOption.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tabOption.Controls.Add(this.pageLocation);
			this.tabOption.Controls.Add(this.pageReport);
			this.tabOption.Controls.Add(this.pageExplorer);
			this.tabOption.Location = new System.Drawing.Point(0, 0);
			this.tabOption.Name = "tabOption";
			this.tabOption.SelectedIndex = 0;
			this.tabOption.Size = new System.Drawing.Size(376, 324);
			this.tabOption.TabIndex = 0;
			// 
			// pageLocation
			// 
			this.pageLocation.BackColor = System.Drawing.Color.Gainsboro;
			this.pageLocation.Controls.Add(this.label1);
			this.pageLocation.Controls.Add(this.textLogFile);
			this.pageLocation.Controls.Add(this.label2);
			this.pageLocation.Controls.Add(this.label3);
			this.pageLocation.Controls.Add(this.buttonBrowseHome);
			this.pageLocation.Controls.Add(this.textTAPDir);
			this.pageLocation.Controls.Add(this.buttonBrowseMoveDir);
			this.pageLocation.Controls.Add(this.textReportDir);
			this.pageLocation.Location = new System.Drawing.Point(4, 22);
			this.pageLocation.Name = "pageLocation";
			this.pageLocation.Size = new System.Drawing.Size(368, 298);
			this.pageLocation.TabIndex = 1;
			this.pageLocation.Text = "File Locations";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 8;
			this.label1.Text = "Report Folder:";
			// 
			// textLogFile
			// 
			this.textLogFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textLogFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textLogFile.Location = new System.Drawing.Point(80, 128);
			this.textLogFile.Name = "textLogFile";
			this.textLogFile.Size = new System.Drawing.Size(216, 20);
			this.textLogFile.TabIndex = 7;
			this.textLogFile.Text = "udfpro.log";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 128);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 16);
			this.label2.TabIndex = 6;
			this.label2.Text = "Log File:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 16);
			this.label3.TabIndex = 0;
			this.label3.Text = "TAP Folder:";
			// 
			// buttonBrowseHome
			// 
			this.buttonBrowseHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonBrowseHome.Location = new System.Drawing.Point(304, 24);
			this.buttonBrowseHome.Name = "buttonBrowseHome";
			this.buttonBrowseHome.Size = new System.Drawing.Size(32, 21);
			this.buttonBrowseHome.TabIndex = 2;
			this.buttonBrowseHome.Text = "...";
			this.buttonBrowseHome.Click += new System.EventHandler(this.buttonBrowseHome_Click);
			// 
			// textTAPDir
			// 
			this.textTAPDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textTAPDir.Location = new System.Drawing.Point(8, 24);
			this.textTAPDir.Name = "textTAPDir";
			this.textTAPDir.Size = new System.Drawing.Size(288, 20);
			this.textTAPDir.TabIndex = 1;
			this.textTAPDir.Text = "";
			// 
			// buttonBrowseMoveDir
			// 
			this.buttonBrowseMoveDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonBrowseMoveDir.Location = new System.Drawing.Point(304, 88);
			this.buttonBrowseMoveDir.Name = "buttonBrowseMoveDir";
			this.buttonBrowseMoveDir.Size = new System.Drawing.Size(32, 21);
			this.buttonBrowseMoveDir.TabIndex = 5;
			this.buttonBrowseMoveDir.Text = "...";
			this.buttonBrowseMoveDir.Visible = false;
			// 
			// textReportDir
			// 
			this.textReportDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textReportDir.Location = new System.Drawing.Point(8, 88);
			this.textReportDir.Name = "textReportDir";
			this.textReportDir.Size = new System.Drawing.Size(288, 20);
			this.textReportDir.TabIndex = 4;
			this.textReportDir.Text = "";
			// 
			// pageReport
			// 
			this.pageReport.BackColor = System.Drawing.Color.Gainsboro;
			this.pageReport.Controls.Add(this.textContactEmail);
			this.pageReport.Controls.Add(this.label4);
			this.pageReport.Controls.Add(this.textContactPerson);
			this.pageReport.Controls.Add(this.label19);
			this.pageReport.Location = new System.Drawing.Point(4, 22);
			this.pageReport.Name = "pageReport";
			this.pageReport.Size = new System.Drawing.Size(368, 298);
			this.pageReport.TabIndex = 2;
			this.pageReport.Text = "Report";
			// 
			// textContactEmail
			// 
			this.textContactEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textContactEmail.Location = new System.Drawing.Point(136, 48);
			this.textContactEmail.Name = "textContactEmail";
			this.textContactEmail.Size = new System.Drawing.Size(208, 20);
			this.textContactEmail.TabIndex = 7;
			this.textContactEmail.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 16);
			this.label4.TabIndex = 6;
			this.label4.Text = "E-mail:";
			// 
			// textContactPerson
			// 
			this.textContactPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textContactPerson.Location = new System.Drawing.Point(136, 16);
			this.textContactPerson.Name = "textContactPerson";
			this.textContactPerson.Size = new System.Drawing.Size(208, 20);
			this.textContactPerson.TabIndex = 5;
			this.textContactPerson.Text = "";
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(16, 16);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(112, 16);
			this.label19.TabIndex = 4;
			this.label19.Text = "Contact Person:";
			// 
			// pageExplorer
			// 
			this.pageExplorer.BackColor = System.Drawing.Color.Gainsboro;
			this.pageExplorer.Controls.Add(this.textBox2);
			this.pageExplorer.Controls.Add(this.label5);
			this.pageExplorer.Location = new System.Drawing.Point(4, 22);
			this.pageExplorer.Name = "pageExplorer";
			this.pageExplorer.Size = new System.Drawing.Size(368, 298);
			this.pageExplorer.TabIndex = 4;
			this.pageExplorer.Text = "TAP Explorer";
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Location = new System.Drawing.Point(128, 16);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(208, 20);
			this.textBox2.TabIndex = 21;
			this.textBox2.Text = "";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(112, 16);
			this.label5.TabIndex = 20;
			this.label5.Text = "TAP Format:";
			// 
			// buttonOk
			// 
			this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOk.Location = new System.Drawing.Point(184, 334);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.TabIndex = 1;
			this.buttonOk.Text = "&Ok";
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCancel.Location = new System.Drawing.Point(272, 334);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.TabIndex = 2;
			this.buttonCancel.Text = "&Cancel";
			// 
			// dlgSaveFile
			// 
			this.dlgSaveFile.FileName = "udf.txt";
			this.dlgSaveFile.Filter = "All Files (*.*) | *.*";
			this.dlgSaveFile.Title = "Ãàðàëòûí ôàéë";
			// 
			// OptionDlg
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.Gainsboro;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(378, 363);
			this.ControlBox = false;
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.tabOption);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "OptionDlg";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Тохиргоо";
			this.tabOption.ResumeLayout(false);
			this.pageLocation.ResumeLayout(false);
			this.pageReport.ResumeLayout(false);
			this.pageExplorer.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		

		private void buttonBrowseHome_Click(object sender, System.EventArgs e) {
			/*
			FolderBrowserDialog dlgFolderBrowser = new FolderBrowserDialog();
			dlgFolderBrowser.Description = "Select Folder";
			dlgFolderBrowser.ShowNewFolderButton = false;
			dlgFolderBrowser.RootFolder = System.Environment.SpecialFolder.Personal;
			
			DialogResult result = dlgFolderBrowser.ShowDialog();
			if (result == DialogResult.OK) {
				textHome.Text = dlgFolderBrowser.SelectedPath;
			}
			*/
		}
	}
}
