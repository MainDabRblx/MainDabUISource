using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace ProjectMainDab
{
	internal class Functions
	{
		public static string exploitdllname;

		public static OpenFileDialog openfiledialog;

		static Functions()
		{
			Functions.exploitdllname = "MainDab.dll";
			Functions.openfiledialog = new OpenFileDialog()
			{
				Filter = "Script File|*.txt;*.lua|All files (*.*)|*.*",
				FilterIndex = 1,
				RestoreDirectory = true,
				Title = "Open File"
			};
		}

		public Functions()
		{
		}

		public static void Inject()
		{
			(new Thread(() => {
				if (NamedPipes.NamedPipeExist(NamedPipes.luapipename))
				{
					MessageBox.Show("Already injected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else if (!NamedPipes.NamedPipeExist(NamedPipes.luapipename))
				{
					switch (Injector.DllInjector.GetInstance.Inject("RobloxPlayerBeta", string.Concat(AppDomain.CurrentDomain.BaseDirectory, Functions.exploitdllname)))
					{
						case Injector.DllInjectionResult.DllNotFound:
						{
							MessageBox.Show("MainDab.dll was not found! Please restart the application!");
							break;
						}
						case Injector.DllInjectionResult.GameProcessNotFound:
						{
							MessageBox.Show("Couldn't find RobloxPlayerBeta.exe!", "Roblox isn't started!");
							break;
						}
						case Injector.DllInjectionResult.InjectionFailed:
						{
							MessageBox.Show("Injection Failed!", "Failed for whatever reason (try kill roblox or restart ur pc)", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							break;
						}
					}
				}
			})).Start();
		}

		public static void PopulateListBox(ListBox lsb, string Folder, string FileType)
		{
			FileInfo[] files = (new DirectoryInfo(Folder)).GetFiles(FileType);
			for (int i = 0; i < (int)files.Length; i++)
			{
				FileInfo fileInfo = files[i];
				lsb.Items.Add(fileInfo.Name);
			}
		}

		public static void PopulateListBox1(ListBox lsb, string Folder, string FileType)
		{
			FileInfo[] files = (new DirectoryInfo(Folder)).GetFiles(FileType);
			for (int i = 0; i < (int)files.Length; i++)
			{
				FileInfo fileInfo = files[i];
				lsb.Items.Add(fileInfo.Name);
			}
		}
	}
}