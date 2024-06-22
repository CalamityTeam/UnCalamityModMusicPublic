using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UnCalamityModMusic.Common;

namespace UnCalamityModMusic.Content.Items
{
	public class RainMusicBox : MusicBoxItem
	{
		public override int MusicBoxTile => ModContent.TileType<Tiles.RainMusicBox>();

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
