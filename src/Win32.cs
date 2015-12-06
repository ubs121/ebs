using System;
using System.Runtime.InteropServices;
using System.Drawing;

namespace EBS {
	/// <summary>
	/// Summary description for Win32.
	/// </summary>
	public class Win32 {
        public const int WM_KEYDOWN = 0x0100;

		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		public static extern short GetKeyState(int nVirtKey);
	
		[DllImport("user32.dll", CharSet=CharSet.Auto)]
		public static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
	}
}
