using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using UnCalamityModMusic.Common;
using UnCalamityModMusic.Common.Configs;

namespace UnCalamityModMusic.Content.Items
{
	public class RainMusicBox : MusicBoxItem
	{
		public override LocalizedText DisplayName => ModContent.GetInstance<MusicConfig>().RainAlt ? Language.GetOrRegister("Mods.UnCalamityModMusic.Items.RainMusicBox.DisplayNameAlt") : Language.GetOrRegister("Mods.UnCalamityModMusic.Items.RainMusicBox.DisplayName");

		public override LocalizedText Tooltip => ModContent.GetInstance<MusicConfig>().RainAlt ? Language.GetOrRegister("Mods.UnCalamityModMusic.Items.RainMusicBox.TooltipAlt") : Language.GetOrRegister("Mods.UnCalamityModMusic.Items.RainMusicBox.Tooltip");

		public override int MusicBoxTile => ModContent.TileType<Tiles.RainMusicBox>();

        public override string MusicFilePath => ModContent.GetInstance<MusicConfig>().RainAlt ? "RainAlt" : "Rain";

        public override void AddRecipes()
		{
			Recipe.Create(Type, 1)
				.AddIngredient(ItemID.Glowstick, 10)
				.AddIngredient(ItemID.RainCloud, 10)
				.AddIngredient(ItemID.WaterBucket, 3)
				.AddIngredient(ItemID.MusicBox, 1)
				.AddTile(Recipes.musicBoxCraftingStation)
				.Register();
		}
	}
}
