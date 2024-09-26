using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UnCalamityModMusic.Common;

namespace UnCalamityModMusic.Content.Items
{
	public class SlimeRainMusicBox : MusicBoxItem
	{
		public override int MusicBoxTile => ModContent.TileType<Tiles.SlimeRainMusicBox>();

        public override string MusicFilePath => "SlimeRain";

        public override void MusicBoxRecipe()
		{
			Recipe.Create(Type, 1)
				.AddIngredient(ItemID.Gel, 10)
				.AddIngredient(ItemID.PinkGel, 10)
				.AddIngredient(ItemID.GoldCrown, 1)
				.AddIngredient(ItemID.MusicBox, 1)
				.AddTile(Recipes.musicBoxCraftingStation)
				.Register();
			
			Recipe.Create(Type, 1)
				.AddIngredient(ItemID.Gel, 10)
				.AddIngredient(ItemID.PinkGel, 10)
				.AddIngredient(ItemID.PlatinumCrown, 1)
				.AddIngredient(ItemID.MusicBox, 1)
				.AddTile(Recipes.musicBoxCraftingStation)
				.Register();
		}
	}
}
