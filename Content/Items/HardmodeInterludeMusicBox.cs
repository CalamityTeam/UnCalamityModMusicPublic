using Terraria.ModLoader;
using UnCalamityModMusic.Common;

namespace UnCalamityModMusic.Content.Items
{
	[LegacyName("ResurrectionMusicBox")]
	public class HardmodeInterludeMusicBox : MusicBoxItem
	{
		public override int MusicBoxTile => ModContent.TileType<Tiles.HardmodeInterludeMusicBox>();

        public override string MusicFilePath => "HardmodeInterlude";
    }
}
