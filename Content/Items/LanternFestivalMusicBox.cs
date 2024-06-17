using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UnCalamityModMusic.Common;

namespace UnCalamityModMusic.Content.Items
{
	public class LanternFestivalMusicBox : MusicBoxItem
	{
		public override int MusicBoxTile => ModContent.TileType<Tiles.LanternFestivalMusicBox>();

        public override string MusicFilePath => "LanternFestival";

        public override void AddRecipes()
		{
			Recipe.Create(Type, 1)
				.AddRecipeGroup(RecipeGroupID.Wood, 10)
				.AddIngredient(ItemID.ReleaseLantern, 10)
				.AddIngredient(ItemID.FallenStar, 3)
				.AddIngredient(ItemID.MusicBox, 1)
				.AddTile(Recipes.musicBoxCraftingStation)
				.Register();
		}
	}
}
