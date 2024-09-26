using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UnCalamityModMusic.Common;

namespace UnCalamityModMusic.Content.Items
{
	[LegacyName("Day1MusicBox")]
	public class ForestDayDawnMusicBox : MusicBoxItem
	{
		public override int MusicBoxTile => ModContent.TileType<Tiles.ForestDayDawnMusicBox>();

        public override string MusicFilePath => "ForestDayDawn";

        public override void MusicBoxRecipe()
		{
			Recipe.Create(Type, 1)
				.AddIngredient(ItemID.Wood, 10)
				.AddIngredient(ItemID.DirtBlock, 10)
				.AddIngredient(ItemID.Daybloom, 3)
				.AddIngredient(ItemID.MusicBox, 1)
				.AddTile(Recipes.musicBoxCraftingStation)
				.Register();
		}
	}
}
