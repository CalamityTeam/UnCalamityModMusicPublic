using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UnCalamityModMusic.Common;

namespace UnCalamityModMusic.Content.Items
{
	public class DungeonMusicBox : MusicBoxItem
	{
		public override int MusicBoxTile => ModContent.TileType<Tiles.DungeonMusicBox>();

        public override string MusicFilePath => "Dungeon";

        public override void MusicBoxRecipe()
		{
			Recipe.Create(Type, 1)
				.AddIngredient(ItemID.BlueBrick, 10)
				.AddIngredient(ItemID.Bone, 10)
				.AddIngredient(ItemID.GoldenKey, 1)
				.AddIngredient(ItemID.MusicBox, 1)
				.AddTile(Recipes.musicBoxCraftingStation)
				.Register();
			
			Recipe.Create(Type, 1)
				.AddIngredient(ItemID.GreenBrick, 10)
				.AddIngredient(ItemID.Bone, 10)
				.AddIngredient(ItemID.GoldenKey, 1)
				.AddIngredient(ItemID.MusicBox, 1)
				.AddTile(Recipes.musicBoxCraftingStation)
				.Register();
			
			Recipe.Create(Type, 1)
				.AddIngredient(ItemID.PinkBrick, 10)
				.AddIngredient(ItemID.Bone, 10)
				.AddIngredient(ItemID.GoldenKey, 1)
				.AddIngredient(ItemID.MusicBox, 1)
				.AddTile(Recipes.musicBoxCraftingStation)
				.Register();
		}
	}
}
