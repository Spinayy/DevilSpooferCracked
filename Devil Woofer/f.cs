using System;
using System.Windows.Forms;
using Lean.Forms;

// Token: 0x0200001E RID: 30
internal static class f
{
	// Token: 0x06000156 RID: 342 RVA: 0x00011F60 File Offset: 0x00010160
	[STAThread]
	private static void Main()
	{
		DateTime d = new DateTime(2022, 6, 28, 19, 43, 39);
		if ((d - DateTime.Now).TotalDays < 0.0)
		{
			throw new Exception();
		}
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run(new Login());
	}
}
