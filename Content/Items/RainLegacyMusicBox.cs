using System;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using UnCalamityModMusic.Common;

namespace UnCalamityModMusic.Content.Items
{
	[LegacyName("GreySkyMusicBox")]
	public class RainLegacyMusicBox : MusicBoxItem
	{
		public override int MusicBoxTile => ModContent.TileType<Tiles.RainLegacyMusicBox>();

        public override string MusicFilePath => "RainLegacy";

        public override void AddRecipes()
		{
            Recipe.Create(Type, 1)
                .AddIngredient(ModContent.ItemType<RainMusicBox>(), 1)
                .AddIngredient(ModContent.ItemType<MoonLordMusicBox>(), 1)
                .AddTile(Recipes.musicBoxCraftingStationVanilla)
                .Register();
        }
    }
}
