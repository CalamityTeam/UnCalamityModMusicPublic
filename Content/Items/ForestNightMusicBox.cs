using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UnCalamityModMusic.Common;

namespace UnCalamityModMusic.Content.Items
{
	[LegacyName("NightMusicBox")]
	public class ForestNightMusicBox : MusicBoxItem
	{
		public override int MusicBoxTile => ModContent.TileType<Tiles.ForestNightMusicBox>();

        public override string MusicFilePath => "ForestNight";

        public override void MusicBoxRecipe()
		{
			Recipe.Create(Type, 1)
				.AddIngredient(ItemID.Wood, 10)
				.AddIngredient(ItemID.DirtBlock, 10)
				.AddIngredient(ItemID.FallenStar, 3)
				.AddIngredient(ItemID.MusicBox, 1)
				.AddTile(Recipes.musicBoxCraftingStation)
				.Register();
		}
	}
}
