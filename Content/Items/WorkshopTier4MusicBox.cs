using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using UnCalamityModMusic.Common;

namespace UnCalamityModMusic.Content.Items
{
	[LegacyName("Workshop4MusicBox")]
	public class WorkshopTier4MusicBox : MusicBoxItem
	{
		public override int MusicBoxTile => ModContent.TileType<Tiles.WorkshopTier4MusicBox>();

        public override string MusicFilePath => "WorkshopTier4";

        public override void MusicBoxRecipe()
		{
			var calamityMod = ModLoader.TryGetMod("CalamityMod", out Mod calamity);
			
			if (calamityMod)
			{
				try
				{
					Recipe.Create(Type, 1)
						.AddIngredient(calamity, "LivingShard", 3)
						.AddIngredient(calamity, "DraedonBar", 3)
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
					.AddIngredient(ItemID.TempleKey, 1)
					.AddIngredient(ItemID.ChlorophyteBar, 3)
					.AddIngredient(ItemID.MusicBox, 1)
					.AddTile(Recipes.musicBoxCraftingStation)
					.Register();
			}
		}
	}
}
