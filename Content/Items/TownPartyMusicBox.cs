using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UnCalamityModMusic.Common;

namespace UnCalamityModMusic.Content.Items
{
	public class TownPartyMusicBox : MusicBoxItem
	{
		public override int MusicBoxTile => ModContent.TileType<Tiles.TownPartyMusicBox>();

        public override string MusicFilePath => "TownParty";

        public override void MusicBoxRecipe()
		{
            //Canonically, a party requires at least 10 balloons
            Recipe.Create(Type, 1)
                .AddRecipeGroup("VCMM:SillyTiedBalloonGroup", 10)
                .AddIngredient(ItemID.SilverCoin, 10)
                .AddIngredient(ItemID.Sunflower, 3)
                .AddIngredient(ItemID.MusicBox, 1)
				.AddTile(Recipes.musicBoxCraftingStation)
				.Register();
		}
	}
}
