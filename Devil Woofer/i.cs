using System;
using System.IO;
using System.Reflection;

// Token: 0x02000021 RID: 33
internal sealed class i
{
	// Token: 0x06000161 RID: 353 RVA: 0x00012414 File Offset: 0x00010614
	public static string a(string a, int b)
	{
		DateTime t = new DateTime(2022, 6, 29, 7, 12, 16);
		if (DateTime.Now > t)
		{
			throw new Exception();
		}
		return i.b.b.c(a, b);
	}

	// Token: 0x06000162 RID: 354 RVA: 0x0001245C File Offset: 0x0001065C
	public static string b()
	{
		char[] array = "\u0010\u0011\u00125".ToCharArray();
		int num = array.Length;
		while (--num >= 0)
		{
			array[num] ^= 't';
		}
		return new string(array);
	}

	// Token: 0x02000022 RID: 34
	// (Invoke) Token: 0x06000165 RID: 357
	private delegate string a();

	// Token: 0x02000023 RID: 35
	private sealed class b
	{
		// Token: 0x06000169 RID: 361 RVA: 0x000124B0 File Offset: 0x000106B0
		private b()
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(i.b.a());
			if (manifestResourceStream != null)
			{
				this.c = new byte[16];
				manifestResourceStream.Read(this.c, 0, this.c.Length);
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0001251C File Offset: 0x0001071C
		public string c(string a, int b)
		{
			int num = a.Length;
			char[] array = a.ToCharArray();
			while (--num >= 0)
			{
				array[num] = (char)((int)array[num] ^ ((int)this.c[b & 15] | b));
			}
			return new string(array);
		}

		// Token: 0x040000CF RID: 207
		private static readonly i.a a = new i.a(i.b);

		// Token: 0x040000D0 RID: 208
		public static readonly i.b b = new i.b();

		// Token: 0x040000D1 RID: 209
		private byte[] c;
	}
}
