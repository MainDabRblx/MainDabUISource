using System;
using System.IO;
using System.Runtime.InteropServices;

namespace MainDab.Classes.ShadowCheatsAPI
{
    class Pipes
    {
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, SetLastError = true)]
		[return: global::System.Runtime.InteropServices.MarshalAs(global::System.Runtime.InteropServices.UnmanagedType.Bool)]
		private static extern bool WaitNamedPipe(string Name, int Timeout);

		// Token: 0x0600000E RID: 14 RVA: 0x00002774 File Offset: 0x00000974
		public static bool DoesNamedPipeExist(string Name)
		{
			bool result;
			try
			{
				int timeout = 0;
				if (!global::MainDab.Classes.ShadowCheatsAPI.Pipes.WaitNamedPipe(global::System.IO.Path.GetFullPath(string.Format("\\\\.\\pipe\\{0}", Name)), timeout))
				{
					int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
					if (lastWin32Error == 0)
					{
						return false;
					}
					if (lastWin32Error == 2)
					{
						return false;
					}
				}
				result = true;
			}
			catch (global::System.Exception ex)
			{
				global::System.Console.WriteLine("[{0}] [Shadow] -> Unexpected Error: {1}", global::System.DateTime.Now.ToLongTimeString(), ex.Message);
				result = false;
			}
			return result;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000027E8 File Offset: 0x000009E8
		public Pipes()
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000027F0 File Offset: 0x000009F0
		// Note: this type is marked as 'beforefieldinit'.
		static Pipes()
		{
		}

		// Token: 0x04000001 RID: 1
		public static string ShadowCheats = "qa6uPWYHm1LeUFsLosFF";
	}
}
