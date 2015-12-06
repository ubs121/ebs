using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace Map {
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form {
		private int x, y;
		private Graphics g;
		private Bitmap map;
		private Bitmap mapCopy;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textFilename;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1() {
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			g = this.CreateGraphics();

			map = new Bitmap(@"C:\EBS\resource\mgl.bmp");
			mapCopy = new Bitmap(map.Width, map.Height);
			

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
			this.button1 = new System.Windows.Forms.Button();
			this.textFilename = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(616, 0);
			this.button1.Name = "button1";
			this.button1.TabIndex = 0;
			this.button1.Text = "Save as";
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// textFilename
			// 
			this.textFilename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textFilename.Location = new System.Drawing.Point(464, 0);
			this.textFilename.Name = "textFilename";
			this.textFilename.Size = new System.Drawing.Size(144, 20);
			this.textFilename.TabIndex = 1;
			this.textFilename.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(696, 477);
			this.Controls.Add(this.textFilename);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.Run(new Form1());
		}


		private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e) {
			e.Graphics.DrawImage(map, 0, 0);
		}

		private void Form1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e) {
			x = e.X;
			y = e.Y;
			Color c = map.GetPixel(x, y);
			this.Text = "(" + x + ":" + y + ") Color:" + c;
			
		}

		private void button1_Click_1(object sender, System.EventArgs e) {
			StreamWriter writer = null;
			try {
				map = new Bitmap(textFilename.Text);
				writer = new StreamWriter(new FileStream(textFilename.Text + ".txt", FileMode.Create, FileAccess.Write));
				for (int i=0; i<map.Width; i++) {
					for (int j=0; j<map.Height; j++) {
						Color c = map.GetPixel(i, j);
						if (c.R < 10 &&  c.G < 10 && c.B < 10) {
							//mapCopy.SetPixel(i, j, Color.Black);
							writer.WriteLine(i + "\t" + j);
						}
					}
				}

				//mapCopy.Save(textFilename.Text);
			}
			catch (Exception ex) {
				MessageBox.Show(ex.ToString());
			}
			finally {
				writer.Close();
			}

			/*
			for (int i=0; i<map.Width; i++) {
				for (int j=0; j<map.Height; j++) {
					Color c = map.GetPixel(i, j);
					if (c.R < 10 &&  c.G < 10 && c.B < 10) {
						//mapCopy.SetPixel(i, j, Color.Black);
						writer.WriteLine(i + "\t" + j);
					}
				}
			}

			writer.Close();
		
			//mapCopy.Save(@"C:\EBS\resource\MGl_copy.bmp");
			*/
		}

		private void SavePolygon(StreamWriter stream, int i, int j) {
			if (i < 0 || j < 0 || i > map.Width || j > map.Height) return;

			Color c = map.GetPixel(i, j);
			if (c.R == 0 && c.G == 0 && c.B == 0) {
				stream.WriteLine(i + "\t" + j);

				
				SavePolygon(stream, i - 1, j - 1);
				SavePolygon(stream, i, j - 1);
				SavePolygon(stream, i + 1, j - 1);
				SavePolygon(stream, i + 1, j);
				SavePolygon(stream, i + 1, j + 1);
				SavePolygon(stream, i, j + 1);
				SavePolygon(stream, i - 1, j + 1);
				SavePolygon(stream, i - 1, j);
			}
		}

		private void SavePolygon(Bitmap bmp, int i, int j) {
			if (i < 0 || j < 0 || i > map.Width || j > map.Height) return;

			Color c = map.GetPixel(i, j);
			if (c.R == 0 && c.G == 0 && c.B == 0) {
				bmp.SetPixel(i, j, Color.Blue);

				
				SavePolygon(bmp, i - 1, j - 1);
				SavePolygon(bmp, i, j - 1);
				SavePolygon(bmp, i + 1, j - 1);
				SavePolygon(bmp, i + 1, j);
				SavePolygon(bmp, i + 1, j + 1);
				SavePolygon(bmp, i, j + 1);
				SavePolygon(bmp, i - 1, j + 1);
				SavePolygon(bmp, i - 1, j);
			}
		}


	}
}
