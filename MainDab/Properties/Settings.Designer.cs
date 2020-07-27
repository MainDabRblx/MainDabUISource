using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace ProjectMainDab.Properties
{
	// Token: 0x02000018 RID: 24
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.6.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x0001B724 File Offset: 0x00019924
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x0400019E RID: 414
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
