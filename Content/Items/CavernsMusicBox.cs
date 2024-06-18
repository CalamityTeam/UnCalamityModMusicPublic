using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UnCalamityModMusic.Common;

namespace UnCalamityModMusic.Content.Items
{
	[LegacyName("Underground2MusicBox")]
	public class CavernsMusicBox : MusicBoxItem
	{
		public override int MusicBoxTile => ModContent.TileType<Tiles.CavernsMusicBox>();

		public override void AddRecipes()
		{
			Recipe.Create(Type, 1)
				.AddIngredient(ItemID.StoneBlock, 10)
				.AddIngredient(ItemID.SiltBlock, 10)
				.AddRecipeGroup("VCMM:GoldOreGroup", 10)
				.AddIngredient(ItemID.MusicBox, 1)
				.AddTile(Recipes.musicBoxCraftingStation)
				.Register();
		}
	}
}
