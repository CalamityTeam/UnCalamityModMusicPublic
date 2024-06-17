using System.Collections.Generic;
using System.Reflection;
using Terraria;
using Terraria.ModLoader;

namespace UnCalamityModMusic.Common
{
    public class MusicBoxConnecting : ModSystem
    {
        private static void ConnectMusicBox(string musicKey, int musicBoxItem)
        {
            int musicPath = MusicPathing.GetMusicSlot(musicKey);

            if (musicPath > 0)
            {
                FieldInfo info = typeof(MusicLoader).GetField("musicToItem", BindingFlags.NonPublic | BindingFlags.Static);
                var musicToItem = (Dictionary<int, int>)info.GetValue(null);

                musicToItem[musicPath] = musicBoxItem;
            }
        }

        public override void PostSetupContent()
        {
            if (!Main.dedServ)
            {
                ConnectMusicBox("TownNight_Noiseless", ModContent.ItemType<Content.Items.TownNightMusicBox>());
            }
        }
    }
}
