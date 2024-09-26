using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UnCalamityModMusic.Common;

namespace UnCalamityModMusic.Content.Items
{
	[LegacyName("Workshop3MusicBox")]
	public class WorkshopTier3MusicBox : MusicBoxItem
	{
		public override int MusicBoxTile => ModContent.TileType<Tiles.WorkshopTier3MusicBox>();

        public override string MusicFilePath => "WorkshopTier3";

        public override void MusicBoxRecipe()
		{
			Recipe.Create(Type, 1)
				.AddRecipeGroup("VCMM:MythrilBarGroup", 3)
				.AddRecipeGroup("VCMM:AdamantiteBarGroup", 3)
				.AddIngredient(ItemID.MusicBox, 1)
				.AddTile(Recipes.musicBoxCraftingStation)
				.Register();
		}
	}
}
