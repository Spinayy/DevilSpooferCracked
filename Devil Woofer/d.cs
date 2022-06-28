using System;
using System.Linq;
using Microsoft.Win32;

// Token: 0x02000007 RID: 7
internal class d
{
	// Token: 0x0600002E RID: 46 RVA: 0x00002D84 File Offset: 0x00000F84
	public static string a(int a)
	{
		return new string(Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789", a).Select(new Func<string, char>(global::d.<>c.<>9.a)).ToArray<char>());
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00002DCC File Offset: 0x00000FCC
	public void b()
	{
		this.a = global::d.a(20);
		for (int i = 0; i < this.c.Length; i++)
		{
			this.c(i);
		}
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00002E04 File Offset: 0x00001004
	private void c(int a)
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(this.c[a], true);
		if (registryKey != null)
		{
			int num = 0;
			while (num < this.d.GetLength(1) && !(this.d[a, num] == "nop"))
			{
				registryKey.SetValue(this.d[a, num], this.a);
				this.a = global::d.a(20);
				num++;
			}
			registryKey.Close();
		}
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00002E8C File Offset: 0x0000108C
	public string[] d()
	{
		return this.c;
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00002EA4 File Offset: 0x000010A4
	public string[,] e()
	{
		return this.d;
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00002EBC File Offset: 0x000010BC
	public d()
	{
		string[,] array = new string[7, 7];
		array[0, 0] = "SystemProductName";
		array[0, 1] = "Identifier";
		array[0, 2] = "Previous Update Revision";
		array[0, 3] = "ProcessorNameString";
		array[0, 4] = "VendorIdentifier";
		array[0, 5] = "Platform Specific Field1";
		array[0, 6] = "Component Information";
		array[1, 0] = "SerialNumber";
		array[1, 1] = "Identifier";
		array[1, 2] = "SystemManufacturer";
		array[1, 3] = "nop";
		array[1, 4] = "nop";
		array[1, 5] = "nop";
		array[1, 6] = "nop";
		array[2, 0] = "ComputerHardwareId";
		array[2, 1] = "ComputerHardwareIds";
		array[2, 2] = "BIOSVendor";
		array[2, 3] = "ProductId";
		array[2, 4] = "ProcessorNameString";
		array[2, 5] = "BIOSReleaseDate";
		array[2, 6] = "nop";
		array[3, 0] = "ProductId";
		array[3, 1] = "InstallDate";
		array[3, 2] = "InstallTime";
		array[3, 3] = "nop";
		array[3, 4] = "nop";
		array[3, 5] = "nop";
		array[3, 6] = "nop";
		array[4, 0] = "SusClientId";
		array[4, 1] = "nop";
		array[4, 2] = "nop";
		array[4, 3] = "nop";
		array[4, 4] = "nop";
		array[4, 5] = "nop";
		array[4, 6] = "nop";
		array[5, 0] = "NetCfgInstanceId";
		array[5, 1] = "NetLuidIndex";
		array[5, 2] = "nop";
		array[5, 3] = "nop";
		array[5, 4] = "nop";
		array[5, 5] = "nop";
		array[5, 6] = "nop";
		array[6, 0] = "NetworkAddress";
		array[6, 1] = "NetCfgInstanceId";
		array[6, 2] = "NetworkInterfaceInstallTimestamp";
		array[6, 3] = "nop";
		array[6, 4] = "nop";
		array[6, 5] = "nop";
		array[6, 6] = "nop";
		this.d = array;
		base..ctor();
	}

	// Token: 0x0400000C RID: 12
	private string a;

	// Token: 0x0400000D RID: 13
	private static Random b = new Random();

	// Token: 0x0400000E RID: 14
	private string[] c = new string[]
	{
		"Hardware\\Description\\System\\CentralProcessor\\0",
		"HARDWARE\\DEVICEMAP\\Scsi\\Scsi Port 0\\Scsi Bus 0\\Target Id 0\\Logical Unit Id 0",
		"SYSTEM\\CurrentControlSet\\Control\\SystemInformation",
		"SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion",
		"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\WindowsUpdate",
		"SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0001",
		"SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0012"
	};

	// Token: 0x0400000F RID: 15
	private string[,] d;
}
