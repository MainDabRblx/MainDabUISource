using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainDab.Classes.RevenantAPI
{
    class RevenantAPI
    {
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public bool isArchAttached()
		{
			return RevenantAPI.namedPipeExist(this.pipeName);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002070 File Offset: 0x00000270
		public static bool isRobloxOn()
		{
			return global::System.Diagnostics.Process.GetProcessesByName("RobloxPlayerBeta").Length >= 1;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002094 File Offset: 0x00000294
		public void Execute(string Script)
		{
			bool flag = RevenantAPI.namedPipeExist(this.pipeName);
			bool flag2 = flag;
			if (flag2)
			{
				using (global::System.IO.Pipes.NamedPipeClientStream namedPipeClientStream = new global::System.IO.Pipes.NamedPipeClientStream(".", this.pipeName, global::System.IO.Pipes.PipeDirection.Out))
				{
					namedPipeClientStream.Connect();
					using (global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(namedPipeClientStream, global::System.Text.Encoding.Default, 0xF423F))
					{
						streamWriter.Write(Script);
						streamWriter.Dispose();
					}
					namedPipeClientStream.Dispose();
				}
			}
			else
			{
				bool flag3 = global::System.IO.File.Exists("Arch.dll");
				if (flag3)
				{
					global::System.Windows.Forms.MessageBox.Show("Please attach!", "Error!", global::System.Windows.Forms.MessageBoxButtons.OK, global::System.Windows.Forms.MessageBoxIcon.Hand);
				}
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002158 File Offset: 0x00000358
		public void KillRoblox()
		{
			global::System.Diagnostics.Process[] processesByName = global::System.Diagnostics.Process.GetProcessesByName("RobloxPlayerBeta");
			for (int i = 0; i < processesByName.Length; i++)
			{
				processesByName[i].Kill();
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002190 File Offset: 0x00000390
		public void Attach()
		{
			string address = "https://github.com/xChonkster/ArchDependencies/blob/main/DLL/Version?raw=true";
			string address2 = "https://github.com/xChonkster/ArchDependencies/blob/main/DLL/DownloadURL?raw=true";
			global::System.Net.WebClient webClient = new global::System.Net.WebClient();
			bool flag = !global::System.IO.File.Exists("bin\\deployedversion.txt");
			if (flag)
			{
				global::System.IO.File.Create(global::System.Environment.CurrentDirectory + "\\bin\\deployedversion.txt").Close();
				global::System.IO.File.WriteAllText(global::System.Environment.CurrentDirectory + "\\bin\\deployedversion.txt", webClient.DownloadString(address));
			}
			else
			{
				string contents;
				bool flag2 = (contents = webClient.DownloadString(address)) != global::System.IO.File.ReadAllText(global::System.Environment.CurrentDirectory + "\\bin\\deployedversion.txt");
				if (flag2)
				{
					global::System.IO.File.WriteAllText(global::System.Environment.CurrentDirectory + "\\bin\\deployedversion.txt", contents);
					global::System.IO.File.Delete(global::System.Environment.CurrentDirectory + "\\Arch.dll");
					string address3 = webClient.DownloadString(address2);
					string fileName = global::System.Environment.CurrentDirectory + "\\Arch.dll";
					webClient.Proxy = null;
					webClient.DownloadFile(address3, fileName);
				}
			}
			bool flag3 = !global::System.IO.File.Exists(global::System.Environment.CurrentDirectory + "\\Arch.dll");
			if (flag3)
			{
				global::System.Windows.Forms.MessageBox.Show("The DLL will start downloading, UI may freeze.", "Notice!", global::System.Windows.Forms.MessageBoxButtons.OK, global::System.Windows.Forms.MessageBoxIcon.Asterisk);
				string address4 = webClient.DownloadString(address2);
				string fileName2 = global::System.Environment.CurrentDirectory + "\\Arch.dll";
				webClient.Proxy = null;
				webClient.DownloadFile(address4, fileName2);
			}
			bool flag4 = isRobloxOn();
			if (flag4)
			{
				bool flag5 = !this.isArchAttached();
				if (flag5)
				{
					bool flag6 = global::System.IO.File.Exists("PuppyMilkV3.exe");
					if (flag6)
					{
						global::System.Diagnostics.Process.Start(new global::System.Diagnostics.ProcessStartInfo("PuppyMilkV3.exe")
						{
							Arguments = this.DLLPath,
							CreateNoWindow = true
						});
					}
					else
					{
						string address5 = "https://cdn.discordapp.com/attachments/752711054076805220/828547790803697685/PuppyMilkV3.exe";
						string fileName3 = global::System.Environment.CurrentDirectory + "\\PuppyMilkV3.exe";
						webClient.DownloadFile(address5, fileName3);
						this.Attach();
					}
				}
				else
				{
					global::System.Windows.Forms.MessageBox.Show("Arch is already attached!", "Error!", global::System.Windows.Forms.MessageBoxButtons.OK, global::System.Windows.Forms.MessageBoxIcon.Hand);
				}
			}
			else
			{
				global::System.Windows.Forms.MessageBox.Show("Roblox was not Found.", "Error!", global::System.Windows.Forms.MessageBoxButtons.OK, global::System.Windows.Forms.MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002398 File Offset: 0x00000598
		private static bool namedPipeExist(string pipeName)
		{
			bool result;
			try
			{
				bool flag = WaitNamedPipe(global::System.IO.Path.GetFullPath(string.Format("\\\\.\\pipe\\{0}", pipeName)), 0);
				bool flag2 = flag;
				if (flag2)
				{
					int lastWin32Error = global::System.Runtime.InteropServices.Marshal.GetLastWin32Error();
					bool flag3 = lastWin32Error == 0;
					bool flag4 = flag3;
					if (flag4)
					{
						result = false;
						return result;
					}
					bool flag5 = lastWin32Error == 2;
					bool flag6 = flag5;
					if (flag6)
					{
						result = false;
						return result;
					}
				}
				result = true;
			}
			catch (global::System.Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000007 RID: 7
		[global::System.Runtime.InteropServices.DllImport("kernel32.dll", CharSet = global::System.Runtime.InteropServices.CharSet.Auto, SetLastError = true)]
		private static extern bool WaitNamedPipe(string name, int timeout);


		// Token: 0x04000001 RID: 1
		private string DLLPath = "\"" + global::System.Environment.CurrentDirectory + "\\Arch.dll\"";

		// Token: 0x04000002 RID: 2
		private string pipeName = "Arch";

		// Token: 0x04000003 RID: 3
		private global::System.Net.WebClient wc = new global::System.Net.WebClient();
	}
}
