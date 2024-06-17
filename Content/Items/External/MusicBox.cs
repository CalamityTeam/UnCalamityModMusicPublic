using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using UnCalamityModMusic.Common.Configs;

namespace UnCalamityModMusic.Content.Items.External
{
	public class MusicBox : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			//Make all music boxes stack to 9999 instead of 1
			if (item.Name.Contains("Music Box"))
			{
				item.maxStack = 9999;
			}

			if (item.type == ItemID.MusicBox)
			{
				if (ModContent.GetInstance<OtherConfig>().MusicBoxResprite)
				{
					item.useStyle = ItemUseStyleID.Swing;
					item.useTurn = true;
					item.useAnimation = 15;
					item.useTime = 10;
					item.autoReuse = true;
					item.consumable = true;
					item.createTile = ModContent.TileType<Tiles.External.MusicBox>();
				}
				//item.value = Item.buyPrice(1, 0, 0, 0);
			}
		}
	}
}
