using Terraria.ModLoader.Config;
using System.ComponentModel;

namespace UnCalamityModMusic.Common.Configs
{
	[BackgroundColor(49, 32, 36, 216)]
	public class MusicConfig : ModConfig
	{
		public override ConfigScope Mode => ConfigScope.ClientSide;

		[Header("$Mods.UnCalamityModMusic.Configs.MusicConfig.MusicTogglesHeader")]

        [BackgroundColor(192, 54, 64, 192)]
        [DefaultValue(true)]
        public bool WorkshopThemes { get; set; }

        [BackgroundColor(192, 54, 64, 192)]
        [DefaultValue(true)]
        public bool HardmodeInterlude { get; set; }

        [Header("$Mods.UnCalamityModMusic.Configs.MusicConfig.AlternateMusicHeader")]

        [BackgroundColor(192, 54, 64, 192)]
		[DefaultValue(false)]
		public bool DeepAbyssAlt { get; set; }

		[ReloadRequired]
		[BackgroundColor(192, 54, 64, 192)]
		[DefaultValue(false)]
		public bool CrimsonAlt { get; set; }

		[ReloadRequired]
		[BackgroundColor(192, 54, 64, 192)]
		[DefaultValue(false)]
		public bool RainAlt { get; set; }

		[ReloadRequired]
		[BackgroundColor(192, 54, 64, 192)]
		[DefaultValue(false)]
		public bool BloodMoonAlt { get; set; }

		[ReloadRequired]
		[BackgroundColor(192, 54, 64, 192)]
		[DefaultValue(false)]
		public bool KingSlimeAlt { get; set; }

		[ReloadRequired]
		[BackgroundColor(192, 54, 64, 192)]
		[DefaultValue(false)]
		public bool EyeofCthulhuAlt { get; set; }

		[ReloadRequired]
		[BackgroundColor(192, 54, 64, 192)]
		[DefaultValue(false)]
		public bool DestroyerAlt { get; set; }

		[Header("$Mods.UnCalamityModMusic.Configs.MusicConfig.ConditionChangesHeader")]

		[BackgroundColor(192, 54, 64, 192)]
		[DefaultValue(false)]
		public bool PrioritizeInfernumMusic { get; set; }

		[BackgroundColor(192, 54, 64, 192)]
		[DefaultValue(false)]
		public bool OverrideAnahitasLure { get; set; }
	}
}