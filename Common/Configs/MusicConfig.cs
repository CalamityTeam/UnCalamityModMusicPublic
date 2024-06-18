using Terraria.ModLoader.Config;
using System.ComponentModel;

namespace UnCalamityModMusic.Common.Configs
{
	[BackgroundColor(49, 32, 36, 216)]
	public class MusicConfig : ModConfig
	{
		public override ConfigScope Mode => ConfigScope.ClientSide;

		[Header("$Mods.UnCalamityModMusic.Configs.MusicConfig.MusicChangesHeader")]

		[BackgroundColor(192, 54, 64, 192)]
		[DefaultValue(true)]
		public bool WorkshopThemes { get; set; }

		[BackgroundColor(192, 54, 64, 192)]
		[DefaultValue(false)]
		public bool DeepAbyssAltTheme { get; set; }

		[ReloadRequired]
		[BackgroundColor(192, 54, 64, 192)]
		[DefaultValue(false)]
		public bool CrimsonAltTheme { get; set; }

		[ReloadRequired]
		[BackgroundColor(192, 54, 64, 192)]
		[DefaultValue(false)]
		public bool RainAltTheme { get; set; }

		[ReloadRequired]
		[BackgroundColor(192, 54, 64, 192)]
		[DefaultValue(false)]
		public bool BloodMoonAltTheme { get; set; }

		[ReloadRequired]
		[BackgroundColor(192, 54, 64, 192)]
		[DefaultValue(false)]
		public bool KingSlimeAltTheme { get; set; }

		[ReloadRequired]
		[BackgroundColor(192, 54, 64, 192)]
		[DefaultValue(false)]
		public bool EyeofCthulhuAltTheme { get; set; }

		[ReloadRequired]
		[BackgroundColor(192, 54, 64, 192)]
		[DefaultValue(false)]
		public bool DestroyerAltTheme { get; set; }

		[Header("$Mods.UnCalamityModMusic.Configs.MusicConfig.ConditionChangesHeader")]

		[BackgroundColor(192, 54, 64, 192)]
		[DefaultValue(false)]
		public bool PrioritizeInfernumMusic { get; set; }

		[BackgroundColor(192, 54, 64, 192)]
		[DefaultValue(false)]
		public bool OverrideAnahitasLureTheme { get; set; }
	}
}