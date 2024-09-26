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

        [BackgroundColor(192, 54, 64, 192)]
		[DefaultValue(false)]
		public bool AbyssLayer3Alt { get; set; }

		[Header("$Mods.UnCalamityModMusic.Configs.MusicConfig.ConditionChangesHeader")]

		[BackgroundColor(192, 54, 64, 192)]
		[DefaultValue(false)]
		public bool PrioritizeInfernumMusic { get; set; }

		[BackgroundColor(192, 54, 64, 192)]
		[DefaultValue(false)]
		public bool OverrideAnahitasLure { get; set; }
	}
}