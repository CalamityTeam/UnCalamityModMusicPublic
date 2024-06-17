using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using UnCalamityModMusic.Common;
using UnCalamityModMusic.Common.Configs;

namespace UnCalamityModMusic.Content.Items
{
	public class KingSlimeMusicBox : MusicBoxItem
	{
		public override LocalizedText DisplayName => ModContent.GetInstance<MusicConfig>().KingSlimeAlt ? Language.GetOrRegister("Mods.UnCalamityModMusic.Items.KingSlimeMusicBox.DisplayNameAlt") : Language.GetOrRegister("Mods.UnCalamityModMusic.Items.KingSlimeMusicBox.DisplayName");

		public override LocalizedText Tooltip => ModContent.GetInstance<MusicConfig>().KingSlimeAlt ? Language.GetOrRegister("Mods.UnCalamityModMusic.Items.KingSlimeMusicBox.TooltipAlt") : Language.GetOrRegister("Mods.UnCalamityModMusic.Items.KingSlimeMusicBox.Tooltip");

		public override int MusicBoxTile => ModContent.TileType<Tiles.KingSlimeMusicBox>();

        public override string MusicFilePath => ModContent.GetInstance<MusicConfig>().KingSlimeAlt ? "KingSlimeAlt" : "KingSlime";

        public override void AddRecipes()
		{
			Recipe.Create(Type, 1)
				.AddIngredient(ItemID.KingSlimeTrophy, 1)
				.AddIngredient(ItemID.MusicBox, 1)
				.AddTile(Recipes.musicBoxCraftingStation)
				.Register();
		}
	}
}
