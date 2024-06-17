using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using UnCalamityModMusic.Common;

namespace UnCalamityModMusic.Content.Items
{
	[LegacyName("AbyssLowAltMusicBox")]
	public class AbyssLayer3AltMusicBox : MusicBoxItem
	{
		public override int MusicBoxTile => ModContent.TileType<Tiles.AbyssLayer3AltMusicBox>();

        public override string MusicFilePath => "AbyssLayer3Alt";

        public override void AddRecipes()
		{
			var calamityMod = ModLoader.TryGetMod("CalamityMod", out Mod calamity);

			if (calamityMod)
			{
				try
				{
					Recipe.Create(Type, 1)
						.AddIngredient(calamity, "PyreMantleMolten", 10)
						.AddIngredient(calamity, "DepthCells", 10)
						.AddIngredient(calamity, "ChaoticOre", 10)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(Recipes.musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}
			}
		}
	}
}