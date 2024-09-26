using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using UnCalamityModMusic.Common;

namespace UnCalamityModMusic.Content.Items
{
	[LegacyName("Workshop6MusicBox")]
	public class WorkshopTier6MusicBox : MusicBoxItem
	{
		public override int MusicBoxTile => ModContent.TileType<Tiles.WorkshopTier6MusicBox>();

        public override string MusicFilePath => "WorkshopTier6";

        public override void MusicBoxRecipe()
		{
			var calamityMod = ModLoader.TryGetMod("CalamityMod", out Mod calamity);
			
			if (calamityMod)
			{
				try
				{
					Recipe.Create(Type, 1)
						.AddIngredient(calamity, "ExoPrism", 3)
						.AddIngredient(calamity, "AscendantSpiritEssence", 3)
						.AddIngredient(calamity, "AuricBar", 3)
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
