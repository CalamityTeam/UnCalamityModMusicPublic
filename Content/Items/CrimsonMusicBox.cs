using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using UnCalamityModMusic.Common;
using UnCalamityModMusic.Common.Configs;

namespace UnCalamityModMusic.Content.Items
{
	public class CrimsonMusicBox : MusicBoxItem
	{
		public override LocalizedText DisplayName => ModContent.GetInstance<MusicConfig>().CrimsonAlt ? Language.GetOrRegister("Mods.UnCalamityModMusic.Items.CrimsonMusicBox.DisplayNameAlt") : Language.GetOrRegister("Mods.UnCalamityModMusic.Items.CrimsonMusicBox.DisplayName");

		public override LocalizedText Tooltip => ModContent.GetInstance<MusicConfig>().CrimsonAlt ? Language.GetOrRegister("Mods.UnCalamityModMusic.Items.CrimsonMusicBox.TooltipAlt") : Language.GetOrRegister("Mods.UnCalamityModMusic.Items.CrimsonMusicBox.Tooltip");

		public override int MusicBoxTile => ModContent.TileType<Tiles.CrimsonMusicBox>();

        public override string MusicFilePath => ModContent.GetInstance<MusicConfig>().CrimsonAlt ? "CrimsonAlt" : "Crimson";

        public override void AddRecipes()
		{
			Recipe.Create(Type, 1)
				.AddIngredient(ItemID.Shadewood, 10)
				.AddIngredient(ItemID.Vertebrae, 10)
				.AddIngredient(ItemID.ViciousMushroom, 3)
				.AddIngredient(ItemID.MusicBox, 1)
				.AddTile(Recipes.musicBoxCraftingStation)
				.Register();
		}
	}
}
