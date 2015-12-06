using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;

namespace EBS {
	/// <summary>
	/// Application Configuration
	/// </summary>
	public class AppSetting {
		public static Hashtable settings = new Hashtable();
		public static bool settingLoaded;
		public static string settingFile = System.Environment.CurrentDirectory + "\\ebs.ini";

		public AppSetting() {
			settingLoaded = false;
		}

		public static void LoadSetting() {
			StreamReader reader = null;

			try {
				Regex rgx = new Regex(@"\[\s*(?<param>\w+)\s*=\s*""(?<value>[^""]+)""\s*\]");
				reader = new StreamReader(new FileStream(settingFile, FileMode.OpenOrCreate, FileAccess.Read));

				string data = reader.ReadToEnd();
				MatchCollection matches = rgx.Matches(data);

				settings.Clear();

				foreach (Match m in matches) {
					settings[m.Groups["param"].Value] = m.Groups["value"].Value;
				}
				settingLoaded = true;
			}
			catch {
			}
			finally {
				reader.Close();
			}
		}

        public static string Get(string key) {
			if (!settingLoaded) LoadSetting();

			string val = string.Empty;
			try {
				val = Convert.ToString(settings[key]);
			}
			catch {
			}
			return val;
		}

		public static string Get(string key, string defaultValue) {
			if (!settingLoaded) LoadSetting();

			string val = defaultValue;
			if (settings[key] != null) {
				try {
					val = Convert.ToString(settings[key]);
				}
				catch {
				}
			}
			return val;
		}

		public static int Get(string key, int defaultValue) {
			if (!settingLoaded) LoadSetting();

			int val = defaultValue;
			if (settings[key] != null) {
				try {
					val = Convert.ToInt32(settings[key]);
				}
				catch {
				}
			}
			return val;
		}

		public static double Get(string key, double defaultValue) {
			if (!settingLoaded) LoadSetting();

			double val = defaultValue;
			if (settings[key] != null) {
				try {
					val = Convert.ToDouble(settings[key]);
				}
				catch {
				}
			}
			return val;
		}

		public static bool Get(string key, bool defaultValue) {
			if (!settingLoaded) LoadSetting();

			bool val = defaultValue;
			if (settings[key] != null) {
				try {
					val = Convert.ToBoolean(settings[key]);
				}
				catch {
				}
			}
			return val;
		}

		public static void Set(string key, object val) {
			settings[key] = val;
		}

		public static void SaveSetting() {
			StreamWriter writer = null;
			try {
				writer = new StreamWriter(new FileStream(settingFile, FileMode.Create, FileAccess.Write));

				foreach (object param in settings.Keys) {
					writer.WriteLine("[{0}=\"{1}\"]", param, settings[param]);
				}
			}
			catch {
			}
			finally {
				writer.Close();
			}
		}

		public static string DoDecrypt(string input) {
			if (input == null) return "";

			int step = 5, i;
			string round = "";
			char c;
			string key = "abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ";

			for (int t=0; t<input.Length; t++) {
				c = input[t];
				if ((i=key.IndexOf(c)) != -1) {
					if (i - step < 0)
						i = key.Length - i;
					else
						i -= step;
					round += key[i];
				}
				else {
					round += c;
				}
			}

			return round;
		}
		
		public static string DecryptPassword(string pwd) {
			string round1, round2, round3;
			round1 = DoDecrypt(pwd);
			round2 = DoDecrypt(round1);
			round3 = DoDecrypt(round2);
			return round3;
		}

		public static string DoEncrypt(string input) {
			int step = 5, i;
			string round = "";
			char c;
			string key = "abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ";

			for (int t=0; t<input.Length; t++) {
				c = input[t];
				if ((i=key.IndexOf(c)) != -1) {
					if (i + step >= key.Length)
						i = key.Length - i;
					else
						i += step;
					round += key[i];
				}
				else {
					round += c;
				}
			}

			return round;
		}

		public static string EncryptPassword(string pwd) {
			string round1, round2, round3;
			round1 = DoEncrypt(pwd);
			round2 = DoEncrypt(round1);
			round3 = DoEncrypt(round2);
			return round3;
		}
		
	}
}
