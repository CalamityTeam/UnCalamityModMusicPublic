using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using UnCalamityModMusic.Common;

namespace UnCalamityModMusic.Content.Items
{
	[LegacyName("Workshop5MusicBox")]
	public class WorkshopTier5MusicBox : MusicBoxItem
	{
		public override int MusicBoxTile => ModContent.TileType<Tiles.WorkshopTier5MusicBox>();

        public override string MusicFilePath => "WorkshopTier5";

        public override void MusicBoxRecipe()
		{
			var calamityMod = ModLoader.TryGetMod("CalamityMod", out Mod calamity);
			
			if (calamityMod)
			{
				try
				{
					Recipe.Create(Type, 1)
						.AddIngredient(calamity, "BarofLife", 3)
						.AddIngredient(calamity, "GalacticaSingularity", 3)
						.AddIngredient(ItemID.LunarBar, 3)
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
					.AddIngredient(ItemID.FragmentSolar, 3)
					.AddIngredient(ItemID.FragmentVortex, 3)
					.AddIngredient(ItemID.FragmentStardust, 3)
					.AddIngredient(ItemID.FragmentNebula, 3)
					.AddIngredient(ItemID.LunarBar, 3)
					.AddIngredient(ItemID.MusicBox, 1)
					.AddTile(Recipes.musicBoxCraftingStation)
					.Register();
			}
		}
	}
}
