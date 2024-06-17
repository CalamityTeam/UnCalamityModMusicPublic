using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UnCalamityModMusic.Common;

namespace UnCalamityModMusic.Content.Items
{
	public class UnderworldMusicBox : MusicBoxItem
	{
		public override int MusicBoxTile => ModContent.TileType<Tiles.UnderworldMusicBox>();

        public override string MusicFilePath => "Underworld";

        public override void AddRecipes()
		{
			Recipe.Create(Type, 1)
				.AddIngredient(ItemID.AshWood, 10)
				.AddIngredient(ItemID.ObsidianBrick, 10)
				.AddIngredient(ItemID.Fireblossom, 3)
				.AddIngredient(ItemID.MusicBox, 1)
				.AddTile(Recipes.musicBoxCraftingStation)
				.Register();
		}
	}
}
