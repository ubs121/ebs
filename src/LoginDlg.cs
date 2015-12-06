using System;
using System.Windows.Forms;

namespace EBS {
	public class LoginDlg : Form {
		private Label labelServer;
		private Label labelUser;
		private Label labelPassword;
		private PictureBox pictureKey;
		private Button buttonCancel;
		private Button buttonOk;
		internal System.Windows.Forms.TextBox textUser;
		public System.Windows.Forms.TextBox textPassword;
		public System.Windows.Forms.TextBox textServer;
		internal System.ComponentModel.Container components = null;

		public LoginDlg() {
			InitializeComponent();
		}
		
		/// <summary> Login overrides dispose so it can clean up the
		/// component list.
		/// </summary>
		protected  override void  Dispose(bool disposing) {
			base.Dispose(true);
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
		}
		
			
		#region Windows Form Designer generated code
		private void  InitializeComponent() {
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(LoginDlg));
			this.buttonCancel = new System.Windows.Forms.Button();
			this.labelServer = new System.Windows.Forms.Label();
			this.textServer = new System.Windows.Forms.TextBox();
			this.labelUser = new System.Windows.Forms.Label();
			this.textUser = new System.Windows.Forms.TextBox();
			this.labelPassword = new System.Windows.Forms.Label();
			this.textPassword = new System.Windows.Forms.TextBox();
			this.buttonOk = new System.Windows.Forms.Button();
			this.pictureKey = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonCancel.Location = new System.Drawing.Point(256, 40);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(64, 23);
			this.buttonCancel.TabIndex = 8;
			this.buttonCancel.Text = "Cancel";
			// 
			// labelServer
			// 
			this.labelServer.Location = new System.Drawing.Point(8, 8);
			this.labelServer.Name = "labelServer";
			this.labelServer.Size = new System.Drawing.Size(64, 23);
			this.labelServer.TabIndex = 0;
			this.labelServer.Text = "Сервер:";
			// 
			// textServer
			// 
			this.textServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textServer.Location = new System.Drawing.Point(80, 8);
			this.textServer.Name = "textServer";
			this.textServer.Size = new System.Drawing.Size(168, 20);
			this.textServer.TabIndex = 1;
			this.textServer.Text = "";
			// 
			// labelUser
			// 
			this.labelUser.Location = new System.Drawing.Point(8, 40);
			this.labelUser.Name = "labelUser";
			this.labelUser.Size = new System.Drawing.Size(64, 23);
			this.labelUser.TabIndex = 2;
			this.labelUser.Text = "Хэрэглэгч:";
			// 
			// textUser
			// 
			this.textUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textUser.Location = new System.Drawing.Point(80, 40);
			this.textUser.Name = "textUser";
			this.textUser.Size = new System.Drawing.Size(128, 20);
			this.textUser.TabIndex = 3;
			this.textUser.Text = "";
			// 
			// labelPassword
			// 
			this.labelPassword.Location = new System.Drawing.Point(9, 72);
			this.labelPassword.Name = "labelPassword";
			this.labelPassword.Size = new System.Drawing.Size(63, 23);
			this.labelPassword.TabIndex = 4;
			this.labelPassword.Text = "Нууц үг:";
			// 
			// textPassword
			// 
			this.textPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textPassword.Location = new System.Drawing.Point(80, 72);
			this.textPassword.Name = "textPassword";
			this.textPassword.PasswordChar = '*';
			this.textPassword.Size = new System.Drawing.Size(128, 20);
			this.textPassword.TabIndex = 5;
			this.textPassword.Text = "";
			// 
			// buttonOk
			// 
			this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOk.Location = new System.Drawing.Point(256, 8);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(64, 23);
			this.buttonOk.TabIndex = 7;
			this.buttonOk.Text = "Ok";
			// 
			// pictureKey
			// 
			this.pictureKey.Image = ((System.Drawing.Image)(resources.GetObject("pictureKey.Image")));
			this.pictureKey.Location = new System.Drawing.Point(216, 64);
			this.pictureKey.Name = "pictureKey";
			this.pictureKey.Size = new System.Drawing.Size(32, 32);
			this.pictureKey.TabIndex = 9;
			this.pictureKey.TabStop = false;
			this.pictureKey.Text = "pictureBox1";
			// 
			// LoginDlg
			// 
			this.AcceptButton = this.buttonOk;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(330, 119);
			this.Controls.Add(this.textUser);
			this.Controls.Add(this.textPassword);
			this.Controls.Add(this.textServer);
			this.Controls.Add(this.pictureKey);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.labelPassword);
			this.Controls.Add(this.labelUser);
			this.Controls.Add(this.labelServer);
			this.Controls.Add(this.buttonCancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LoginDlg";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Нэвтрэх";
			this.ResumeLayout(false);

		}
		#endregion

		
	}
}