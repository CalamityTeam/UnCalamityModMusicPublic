using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;
using UnCalamityModMusic.Common;

namespace UnCalamityModMusic.Content.Items
{
	public class TownNightMusicBox : MusicBoxItem
	{
		public override int MusicBoxTile => ModContent.TileType<Tiles.TownNightMusicBox>();

		public override void AddRecipes()
		{
			Recipe.Create(Type, 1)
				.AddRecipeGroup(RecipeGroupID.Wood, 10)
				.AddIngredient(ItemID.SilverCoin, 10)
				.AddIngredient(ItemID.FallenStar, 3)
				.AddIngredient(ItemID.MusicBox, 1)
				.AddTile(Recipes.musicBoxCraftingStation)
				.Register();
		}

		public class TownNightNoiselessRecording : GlobalItem
		{
			public override void UpdateAccessory(Item item, Player player, bool hideVisual)
			{
				if (item.type == ItemID.MusicBox && Main.curMusic == MusicPathing.GetMusicSlot("TownNight_Noiseless"))
				{
					if (Main.rand.NextBool(150))
					{
						SoundEngine.PlaySound(SoundID.Item166);
						item.SetDefaults(ModContent.ItemType<TownNightMusicBox>());
					}
				}
			}
		}
	}
}
