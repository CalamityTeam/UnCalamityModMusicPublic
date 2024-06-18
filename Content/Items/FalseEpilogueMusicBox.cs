using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using UnCalamityModMusic.Common;

namespace UnCalamityModMusic.Content.Items
{
	[LegacyName("MemoryMusicBox")]
	public class FalseEpilogueMusicBox : MusicBoxItem
	{
		public override int MusicBoxTile => ModContent.TileType<Tiles.FalseEpilogueMusicBox>();

		public override void AddRecipes()
		{
			var calamityMod = ModLoader.TryGetMod("CalamityMod", out Mod calamity);
			
			if (calamityMod)
			{
				try
				{
					Recipe.Create(Type, 1)
						.AddIngredient(calamity, "ExodiumClusterOre", 10)
						.AddIngredient(calamity, "Phantoplasm", 10)
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
					.AddIngredient(ItemID.FragmentStardust, 10)
					.AddIngredient(ItemID.Ectoplasm, 10)
					.AddIngredient(ItemID.LunarBar, 3)
					.AddIngredient(ItemID.MusicBox, 1)
					.AddTile(Recipes.musicBoxCraftingStation)
					.Register();
			}
		}
	}
}
