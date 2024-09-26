using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UnCalamityModMusic.Common;

namespace UnCalamityModMusic.Content.Items
{
	[LegacyName("CrimsonUgMusicBox")]
	public class CrimsonUndergroundMusicBox : MusicBoxItem
	{
		public override int MusicBoxTile => ModContent.TileType<Tiles.CrimsonUndergroundMusicBox>();

        public override string MusicFilePath => "CrimsonUnderground";

        public override void MusicBoxRecipe()
		{
			Recipe.Create(Type, 1)
				.AddIngredient(ItemID.CrimstoneBlock, 10)
				.AddIngredient(ItemID.Vertebrae, 10)
				.AddIngredient(ItemID.CrimsonHeart, 1)
				.AddIngredient(ItemID.MusicBox, 1)
				.AddTile(Recipes.musicBoxCraftingStation)
				.Register();
		}
	}
}
