using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace ProjectMainDab
{
	internal class Injector
	{
		public Injector()
		{
		}

		public enum DllInjectionResult
		{
			DllNotFound,
			GameProcessNotFound,
			InjectionFailed,
			Success
		}

		public sealed class DllInjector
		{
			private readonly static IntPtr INTPTR_ZERO;

			private static Injector.DllInjector _instance;

			public static Injector.DllInjector GetInstance
			{
				get
				{
					if (Injector.DllInjector._instance == null)
					{
						Injector.DllInjector._instance = new Injector.DllInjector();
					}
					return Injector.DllInjector._instance;
				}
			}

			static DllInjector()
			{
				Injector.DllInjector.INTPTR_ZERO = (IntPtr)0;
			}

			private DllInjector()
			{
			}

			private bool bInject(uint pToBeInjected, string sDllPath)
			{
				unsafe
				{
					bool flag;
					IntPtr intPtr = Injector.DllInjector.OpenProcess(1082, 1, pToBeInjected);
					if (intPtr != Injector.DllInjector.INTPTR_ZERO)
					{
						IntPtr procAddress = Injector.DllInjector.GetProcAddress(Injector.DllInjector.GetModuleHandle("kernel32.dll"), "LoadLibraryA");
						if (procAddress != Injector.DllInjector.INTPTR_ZERO)
						{
							IntPtr intPtr1 = Injector.DllInjector.VirtualAllocEx(intPtr, (IntPtr)0, (IntPtr)sDllPath.Length, 12288, 64);
							if (intPtr1 != Injector.DllInjector.INTPTR_ZERO)
							{
								byte[] bytes = Encoding.ASCII.GetBytes(sDllPath);
								if (Injector.DllInjector.WriteProcessMemory(intPtr, intPtr1, bytes, (uint)bytes.Length, 0) == 0)
								{
									flag = false;
								}
								else if (Injector.DllInjector.CreateRemoteThread(intPtr, (IntPtr)0, Injector.DllInjector.INTPTR_ZERO, procAddress, intPtr1, 0, (IntPtr)0) != Injector.DllInjector.INTPTR_ZERO)
								{
									Injector.DllInjector.CloseHandle(intPtr);
									flag = true;
								}
								else
								{
									flag = false;
								}
							}
							else
							{
								flag = false;
							}
						}
						else
						{
							flag = false;
						}
					}
					else
					{
						flag = false;
					}
					return flag;
				}
			}

			[DllImport("kernel32.dll", CharSet=CharSet.None, ExactSpelling=false, SetLastError=true)]
			private static extern int CloseHandle(IntPtr hObject);

			[DllImport("kernel32.dll", CharSet=CharSet.None, ExactSpelling=false, SetLastError=true)]
			private static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttribute, IntPtr dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

			[DllImport("kernel32.dll", CharSet=CharSet.None, ExactSpelling=false, SetLastError=true)]
			private static extern IntPtr GetModuleHandle(string lpModuleName);

			[DllImport("kernel32.dll", CharSet=CharSet.None, ExactSpelling=false, SetLastError=true)]
			private static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

			public Injector.DllInjectionResult Inject(string sProcName, string sDllPath)
			{
				Injector.DllInjectionResult dllInjectionResult;
				if (File.Exists(sDllPath))
				{
					uint id = 0;
					Process[] processes = Process.GetProcesses();
					int num = 0;
					while (num < (int)processes.Length)
					{
						if (processes[num].ProcessName != sProcName)
						{
							num++;
						}
						else
						{
							id = (uint)processes[num].Id;
							break;
						}
					}
					if (id != 0)
					{
						dllInjectionResult = (this.bInject(id, sDllPath) ? Injector.DllInjectionResult.Success : Injector.DllInjectionResult.InjectionFailed);
					}
					else
					{
						dllInjectionResult = Injector.DllInjectionResult.GameProcessNotFound;
					}
				}
				else
				{
					dllInjectionResult = Injector.DllInjectionResult.DllNotFound;
				}
				return dllInjectionResult;
			}

			[DllImport("kernel32.dll", CharSet=CharSet.None, ExactSpelling=false, SetLastError=true)]
			private static extern IntPtr OpenProcess(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

			[DllImport("kernel32.dll", CharSet=CharSet.None, ExactSpelling=false, SetLastError=true)]
			private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, uint flAllocationType, uint flProtect);

			[DllImport("kernel32.dll", CharSet=CharSet.None, ExactSpelling=false, SetLastError=true)]
			private static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] buffer, uint size, int lpNumberOfBytesWritten);
		}
	}
}