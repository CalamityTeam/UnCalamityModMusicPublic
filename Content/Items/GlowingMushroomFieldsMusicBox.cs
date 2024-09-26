using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UnCalamityModMusic.Common;

namespace UnCalamityModMusic.Content.Items
{
	public class GlowingMushroomFieldsMusicBox : MusicBoxItem
	{
		public override int MusicBoxTile => ModContent.TileType<Tiles.GlowingMushroomFieldsMusicBox>();

        public override string MusicFilePath => "GlowingMushroomFields";

        public override void MusicBoxRecipe()
		{
			Recipe.Create(Type, 1)
				.AddIngredient(ItemID.GlowingMushroom, 10)
				.AddIngredient(ItemID.MudBlock, 10)
				.AddIngredient(ItemID.MushroomGrassSeeds, 3)
				.AddIngredient(ItemID.MusicBox, 1)
				.AddTile(Recipes.musicBoxCraftingStation)
				.Register();
		}
	}
}
