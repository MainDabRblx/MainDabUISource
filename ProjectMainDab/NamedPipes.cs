using System;
using System.IO;
using System.IO.Pipes;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ProjectMainDab
{
	internal class NamedPipes
	{
		public static string luapipename;

		static NamedPipes()
		{
			NamedPipes.luapipename = "MainDabSEX";
		}

		public NamedPipes()
		{
		}

		public static void LuaPipe(string script)
		{
			if (!NamedPipes.NamedPipeExist(NamedPipes.luapipename))
			{
				MessageBox.Show("Please inject first! Click the inject button first, then you can execute.", "roblox isn't started u mad bro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				(new Thread(() => {
					try
					{
						using (NamedPipeClientStream namedPipeClientStream = new NamedPipeClientStream(".", NamedPipes.luapipename, PipeDirection.Out))
						{
							namedPipeClientStream.Connect();
							using (StreamWriter streamWriter = new StreamWriter(namedPipeClientStream, Encoding.Default, 999999))
							{
								streamWriter.Write(script);
								streamWriter.Dispose();
							}
							namedPipeClientStream.Dispose();
						}
					}
					catch (IOException oException)
					{
						MessageBox.Show("Error occured connecting to the pipe.", "Connection Failed!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
					catch (Exception exception)
					{
						MessageBox.Show(exception.Message.ToString());
					}
				})).Start();
			}
		}

		public static bool NamedPipeExist(string pipeName)
		{
			bool flag;
			try
			{
				if (!NamedPipes.WaitNamedPipe(string.Concat("\\\\.\\pipe\\", pipeName), 0))
				{
					int lastWin32Error = Marshal.GetLastWin32Error();
					if (lastWin32Error == 0)
					{
						flag = false;
						return flag;
					}
					else if (lastWin32Error == 2)
					{
						flag = false;
						return flag;
					}
				}
				flag = true;
			}
			catch (Exception exception)
			{
				flag = false;
			}
			return flag;
		}

		[DllImport("kernel32.dll", CharSet=CharSet.Auto, ExactSpelling=false, SetLastError=true)]
		private static extern bool WaitNamedPipe(string name, int timeout);
	}
}