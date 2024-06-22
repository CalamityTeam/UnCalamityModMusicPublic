using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UnCalamityModMusic.Common;

namespace UnCalamityModMusic.Content.Items
{
	public class KingSlimeMusicBox : MusicBoxItem
	{
		public override int MusicBoxTile => ModContent.TileType<Tiles.KingSlimeMusicBox>();

		public override void AddRecipes()
		{
			Recipe.Create(Type, 1)
				.AddIngredient(ItemID.KingSlimeTrophy, 1)
				.AddIngredient(ItemID.MusicBox, 1)
				.AddTile(Recipes.musicBoxCraftingStation)
				.Register();
		}
	}
}
