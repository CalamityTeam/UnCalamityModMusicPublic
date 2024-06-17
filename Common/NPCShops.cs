using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnCalamityModMusic.Common
{
    public class NPCShops : GlobalNPC
    {
        public override void ModifyShop(NPCShop shop)
        {
            var calamityMod = ModLoader.TryGetMod("CalamityMod", out Mod calamity);

            if (calamityMod && shop.NpcType == calamity.Find<ModNPC>("FAP").Type)
            {
                shop.Add(ModContent.ItemType<Content.Items.HardmodeInterludeMusicBox>(), Condition.Hardmode);
                shop.Add(ModContent.ItemType<Content.Items.FalseEpilogueMusicBox>(), Condition.DownedMoonLord);
            }

            if (!calamityMod && shop.NpcType == NPCID.Princess)
            {
                shop.Add(ModContent.ItemType<Content.Items.HardmodeInterludeMusicBox>(), Condition.Hardmode);
                shop.Add(ModContent.ItemType<Content.Items.FalseEpilogueMusicBox>(), Condition.DownedMoonLord);
            }
        }
    }
}
