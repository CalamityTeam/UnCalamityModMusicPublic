using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UnCalamityModMusic.Common;

namespace UnCalamityModMusic.Content.Items
{
	public class EaterofWorldsMusicBox : MusicBoxItem
	{
		public override int MusicBoxTile => ModContent.TileType<Tiles.EaterofWorldsMusicBox>();

        public override string MusicFilePath => "EaterofWorlds";

        public override void AddRecipes()
		{
			Recipe.Create(Type, 1)
				.AddIngredient(ItemID.EaterofWorldsTrophy, 1)
				.AddIngredient(ItemID.MusicBox, 1)
				.AddTile(Recipes.musicBoxCraftingStation)
				.Register();
		}
	}
}
