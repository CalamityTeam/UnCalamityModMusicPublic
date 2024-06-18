using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UnCalamityModMusic.Common;

namespace UnCalamityModMusic.Content.Items
{
	[LegacyName("Workshop1MusicBox")]
	public class WorkshopTier1MusicBox : MusicBoxItem
	{
		public override int MusicBoxTile => ModContent.TileType<Tiles.WorkshopTier1MusicBox>();

		public override void AddRecipes()
		{
			Recipe.Create(Type, 1)
				.AddRecipeGroup(RecipeGroupID.Wood, 10)
				.AddIngredient(ItemID.Torch, 10)
				.AddRecipeGroup(RecipeGroupID.IronBar, 3)
				.AddIngredient(ItemID.MusicBox, 1)
				.AddTile(Recipes.musicBoxCraftingStation)
				.Register();
		}
	}
}
