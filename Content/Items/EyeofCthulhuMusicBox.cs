using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using UnCalamityModMusic.Common;
using UnCalamityModMusic.Common.Configs;

namespace UnCalamityModMusic.Content.Items
{
	public class EyeofCthulhuMusicBox : MusicBoxItem
	{
		public override LocalizedText DisplayName => ModContent.GetInstance<MusicConfig>().EyeofCthulhuAlt ? Language.GetOrRegister("Mods.UnCalamityModMusic.Items.EyeofCthulhuMusicBox.DisplayNameAlt") : Language.GetOrRegister("Mods.UnCalamityModMusic.Items.EyeofCthulhuMusicBox.DisplayName");

		public override LocalizedText Tooltip => ModContent.GetInstance<MusicConfig>().EyeofCthulhuAlt ? Language.GetOrRegister("Mods.UnCalamityModMusic.Items.EyeofCthulhuMusicBox.TooltipAlt") : Language.GetOrRegister("Mods.UnCalamityModMusic.Items.EyeofCthulhuMusicBox.Tooltip");

		public override int MusicBoxTile => ModContent.TileType<Tiles.EyeofCthulhuMusicBox>();

        public override string MusicFilePath => ModContent.GetInstance<MusicConfig>().EyeofCthulhuAlt ? "EyeofCthulhuAlt" : "EyeofCthulhu";

        public override void AddRecipes()
		{
			Recipe.Create(Type, 1)
				.AddIngredient(ItemID.EyeofCthulhuTrophy, 1)
				.AddIngredient(ItemID.MusicBox, 1)
				.AddTile(Recipes.musicBoxCraftingStation)
				.Register();
		}
	}
}
