using Terraria.ModLoader;
using UnCalamityModMusic.Common;

namespace UnCalamityModMusic.Content.Items
{
	[LegacyName("MemoryMusicBox")]
	public class FalseEpilogueMusicBox : MusicBoxItem
	{
		public override int MusicBoxTile => ModContent.TileType<Tiles.FalseEpilogueMusicBox>();

        public override string MusicFilePath => "FalseEpilogue";
    }
}
