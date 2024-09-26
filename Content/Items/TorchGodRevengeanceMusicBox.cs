using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using UnCalamityModMusic.Common;

namespace UnCalamityModMusic.Content.Items
{
	public class TorchGodRevengeanceMusicBox : MusicBoxItem
	{
		public override int MusicBoxTile => ModContent.TileType<Tiles.TorchGodRevengeanceMusicBox>();

        public override string MusicFilePath => "TorchGodRevengeance";

        public override void MusicBoxRecipe()
		{
            var calamityMod = ModLoader.TryGetMod("CalamityMod", out Mod calamity);

            if (calamityMod)
            {
                try
                {
                    Recipe.Create(Type, 1)
                        .AddIngredient(ItemID.StoneBlock, 10)
                        .AddIngredient(calamity, "GloomTorch", 10)
                        .AddIngredient(calamity, "RefractivePrismTorch", 10)
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
