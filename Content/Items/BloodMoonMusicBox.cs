using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using UnCalamityModMusic.Common;

namespace UnCalamityModMusic.Content.Items
{
	[LegacyName("BloodMoon1MusicBox")]
	public class BloodMoonMusicBox : MusicBoxItem
	{
		public override int MusicBoxTile => ModContent.TileType<Tiles.BloodMoonMusicBox>();

        public override string MusicFilePath => "BloodMoon";

        public override void MusicBoxRecipe()
		{
			var calamityMod = ModLoader.TryGetMod("CalamityMod", out Mod calamity);
			
			if (calamityMod)
			{
				try
				{
					Recipe.Create(Type, 1)
						.AddRecipeGroup("VCMM:EvilPowderGroup", 10)
						.AddIngredient(calamity, "BloodOrb", 10)
						.AddIngredient(ItemID.FallenStar, 3)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(Recipes.musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}
			}
			else
			{
				Recipe.Create(Type, 1)
					.AddRecipeGroup("VCMM:EvilPowderGroup", 10)
					.AddIngredient(ItemID.FallenStar, 3)
                    .AddIngredient(ItemID.BloodMoonStarter, 1)
                    .AddIngredient(ItemID.MusicBox, 1)
					.AddTile(Recipes.musicBoxCraftingStation)
					.Register();
			}
		}
	}
}
