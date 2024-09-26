using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UnCalamityModMusic.Common;

namespace UnCalamityModMusic.Content.Items
{
	[LegacyName("Day3MusicBox")]
	public class ForestDayAfternoonMusicBox : MusicBoxItem
	{
		public override int MusicBoxTile => ModContent.TileType<Tiles.ForestDayAfternoonMusicBox>();

        public override string MusicFilePath => "ForestDayAfternoon";

        public override void MusicBoxRecipe()
		{
			Recipe.Create(Type, 1)
				.AddIngredient(ItemID.Wood, 10)
				.AddIngredient(ItemID.DirtBlock, 10)
				.AddIngredient(ItemID.Sunflower, 3)
				.AddIngredient(ItemID.MusicBox, 1)
				.AddTile(Recipes.musicBoxCraftingStation)
				.Register();
		}
	}
}
