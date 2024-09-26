using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UnCalamityModMusic.Common;

namespace UnCalamityModMusic.Content.Items
{
	[LegacyName("Day4MusicBox")]
	public class ForestDayEveningMusicBox : MusicBoxItem
	{
		public override int MusicBoxTile => ModContent.TileType<Tiles.ForestDayEveningMusicBox>();

        public override string MusicFilePath => "ForestDayEvening";

        public override void MusicBoxRecipe()
		{
			Recipe.Create(Type, 1)
				.AddIngredient(ItemID.Wood, 10)
				.AddIngredient(ItemID.DirtBlock, 10)
				.AddIngredient(ItemID.Mushroom, 3)
				.AddIngredient(ItemID.MusicBox, 1)
				.AddTile(Recipes.musicBoxCraftingStation)
				.Register();
		}
	}
}
