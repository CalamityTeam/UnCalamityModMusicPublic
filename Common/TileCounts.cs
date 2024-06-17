using System;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnCalamityModMusic.Common
{
	public class TileCounts : ModSystem
	{
		public static int graniteTileCount;
		public static int marbleTileCount;

		public static int workbenchTileCount;
		public static int furnaceTileCount;
		public static int ironAnvilTileCount;
		public static int hellForgeTileCount;
		public static int mythrilAnvilTileCount;
		public static int adamantiteForgeTileCount;

		public static int cosmicAnvilTileCount;
		public static int draedonsForgeTileCount;

        public static int labTileCount;

        public static int storageHeartTileCount;
		public static int craftingUnitTileCount;

        public override void TileCountsAvailable(ReadOnlySpan<int> tileCounts)
        {
            var calamityMod = ModLoader.TryGetMod("CalamityMod", out Mod calamity);
            var calamityVanities = ModLoader.TryGetMod("CalValEX", out Mod calval);
            var magicStorage = ModLoader.TryGetMod("MagicStorage", out Mod storage);

            graniteTileCount = tileCounts[TileID.Granite];
            marbleTileCount = tileCounts[TileID.Marble];

            workbenchTileCount = tileCounts[TileID.WorkBenches];
            furnaceTileCount = tileCounts[TileID.Furnaces];
            ironAnvilTileCount = tileCounts[TileID.Anvils];
            hellForgeTileCount = tileCounts[TileID.Hellforge];
            mythrilAnvilTileCount = tileCounts[TileID.MythrilAnvil];
            adamantiteForgeTileCount = tileCounts[TileID.AdamantiteForge];

            if (calamityMod)
            {
                workbenchTileCount += tileCounts[calamity.Find<ModTile>("AbyssWorkBench").Type] +
                    tileCounts[calamity.Find<ModTile>("AcidwoodWorkBenchTile").Type] +
                    tileCounts[calamity.Find<ModTile>("AncientWorkBench").Type] +
                    tileCounts[calamity.Find<ModTile>("AshenWorkBench").Type] +
                    tileCounts[calamity.Find<ModTile>("BotanicWorkBench").Type] +
                    tileCounts[calamity.Find<ModTile>("CosmiliteWorkBench").Type] +
                    tileCounts[calamity.Find<ModTile>("EutrophicWorkBench").Type] +
                    tileCounts[calamity.Find<ModTile>("ExoWorkbenchTile").Type] +
                    tileCounts[calamity.Find<ModTile>("MonolithWorkBench").Type] +
                    tileCounts[calamity.Find<ModTile>("OtherworldlyWorkBench").Type] +
                    tileCounts[calamity.Find<ModTile>("PlaguedPlateWorkbench").Type] +
                    tileCounts[calamity.Find<ModTile>("ProfanedWorkbench").Type] +
                    tileCounts[calamity.Find<ModTile>("SacrilegiousWorkBenchTile").Type] +
                    tileCounts[calamity.Find<ModTile>("SilvaWorkBench").Type] +
                    tileCounts[calamity.Find<ModTile>("StatigelWorkbench").Type] +
                    tileCounts[calamity.Find<ModTile>("StratusWorkbench").Type] +
                    tileCounts[calamity.Find<ModTile>("VoidWorkbench").Type] +
                    tileCounts[calamity.Find<ModTile>("WulfrumWorkbench").Type];

                cosmicAnvilTileCount = tileCounts[calamity.Find<ModTile>("CosmicAnvil").Type];
				draedonsForgeTileCount = tileCounts[calamity.Find<ModTile>("DraedonsForge").Type];

                labTileCount = tileCounts[calamity.Find<ModTile>("LaboratoryPanels").Type] +
                    tileCounts[calamity.Find<ModTile>("LaboratoryPlating").Type] +
                    tileCounts[calamity.Find<ModTile>("HazardChevronPanels").Type];
            }

            if (calamityVanities)
            {
                workbenchTileCount += tileCounts[calval.Find<ModTile>("OldAstralWorkbench").Type] + 
                    tileCounts[calval.Find<ModTile>("PhantowaxWorkbench").Type] + 
                    tileCounts[calval.Find<ModTile>("BloodstoneWorkbench").Type] + 
                    tileCounts[calval.Find<ModTile>("AuricWorkbench").Type];
            }

            if (magicStorage)
            {
                storageHeartTileCount = tileCounts[storage.Find<ModTile>("StorageHeart").Type];
                craftingUnitTileCount = tileCounts[storage.Find<ModTile>("CraftingAccess").Type];
            }
        }
    }
}