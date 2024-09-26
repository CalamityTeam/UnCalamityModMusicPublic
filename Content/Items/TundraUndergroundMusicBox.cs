using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UnCalamityModMusic.Common;

namespace UnCalamityModMusic.Content.Items
{
	public class TundraUndergroundMusicBox : MusicBoxItem
	{
		public override int MusicBoxTile => ModContent.TileType<Tiles.TundraUndergroundMusicBox>();

        public override string MusicFilePath => "TundraUnderground";

        public override void MusicBoxRecipe()
		{
			Recipe.Create(Type, 1)
				.AddIngredient(ItemID.IceBlock, 10)
				.AddIngredient(ItemID.SlushBlock, 10)
				.AddIngredient(ItemID.FlinxFur, 3)
				.AddIngredient(ItemID.MusicBox, 1)
				.AddTile(Recipes.musicBoxCraftingStation)
				.Register();
		}
	}
}
