using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UnCalamityModMusic.Common;

namespace UnCalamityModMusic.Content.Items
{
	[LegacyName("Day2MusicBox")]
	public class ForestDayMorningMusicBox : MusicBoxItem
	{
		public override int MusicBoxTile => ModContent.TileType<Tiles.ForestDayMorningMusicBox>();

        public override string MusicFilePath => "ForestDayMorning";

        public override void AddRecipes()
		{
			Recipe.Create(Type, 1)
				.AddIngredient(ItemID.Wood, 10)
				.AddIngredient(ItemID.DirtBlock, 10)
				.AddIngredient(ItemID.YellowMarigold, 3)
				.AddIngredient(ItemID.MusicBox, 1)
				.AddTile(Recipes.musicBoxCraftingStation)
				.Register();
		}
	}
}
