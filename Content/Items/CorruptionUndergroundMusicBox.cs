using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UnCalamityModMusic.Common;

namespace UnCalamityModMusic.Content.Items
{
	[LegacyName("CorruptionUgMusicBox")]
	public class CorruptionUndergroundMusicBox : MusicBoxItem
	{
		public override int MusicBoxTile => ModContent.TileType<Tiles.CorruptionUndergroundMusicBox>();

		public override void AddRecipes()
		{
			Recipe.Create(Type, 1)
				.AddIngredient(ItemID.EbonstoneBlock, 10)
				.AddIngredient(ItemID.RottenChunk, 10)
				.AddIngredient(ItemID.ShadowOrb, 1)
				.AddIngredient(ItemID.MusicBox, 1)
				.AddTile(Recipes.musicBoxCraftingStation)
				.Register();
		}
	}
}
