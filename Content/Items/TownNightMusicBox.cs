using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UnCalamityModMusic.Common;

namespace UnCalamityModMusic.Content.Items
{
	public class TownNightMusicBox : MusicBoxItem
	{
		public override int MusicBoxTile => ModContent.TileType<Tiles.TownNightMusicBox>();

        public override string MusicFilePath => "TownNight";

        public override void MusicBoxRecipe()
		{
			Recipe.Create(Type, 1)
				.AddRecipeGroup(RecipeGroupID.Wood, 10)
				.AddIngredient(ItemID.SilverCoin, 10)
				.AddIngredient(ItemID.FallenStar, 3)
				.AddIngredient(ItemID.MusicBox, 1)
				.AddTile(Recipes.musicBoxCraftingStation)
				.Register();
		}
	}
}
