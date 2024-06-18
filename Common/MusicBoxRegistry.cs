using Terraria;
using Terraria.ModLoader;
using UnCalamityModMusic.Common.Configs;

namespace UnCalamityModMusic.Common
{
    public class MusicBoxRegistry : ModSystem
    {
        private static void AddMusicBox(string musicKey, int musicBoxItem, int musicBoxTile)
        {
            int musicPath = MusicPathing.GetMusicSlot(musicKey);

            if (musicPath > 0)
            {
                MusicLoader.AddMusicBox(UnCalamityModMusic.Instance, musicPath, musicBoxItem, musicBoxTile);
            }
        }

        public override void PostSetupContent()
        {
            if (!Main.dedServ)
            {
                //Alternates
                if (ModContent.GetInstance<MusicConfig>().DestroyerAltTheme)
                {
                    //AddMusicBox("DestroyerAlt", ModContent.ItemType<Content.Items.DestroyerMusicBox>(), ModContent.TileType<Content.Tiles.DestroyerMusicBox>());
                }
                else
                {
                    //AddMusicBox("Destroyer", ModContent.ItemType<Content.Items.DestroyerMusicBox>(), ModContent.TileType<Content.Tiles.DestroyerMusicBox>());
                }

                if (ModContent.GetInstance<MusicConfig>().EyeofCthulhuAltTheme)
                {
                    AddMusicBox("EyeofCthulhuAlt", ModContent.ItemType<Content.Items.EyeofCthulhuMusicBox>(), ModContent.TileType<Content.Tiles.EyeofCthulhuMusicBox>());
                }
                else
                {
                    AddMusicBox("EyeofCthulhu", ModContent.ItemType<Content.Items.EyeofCthulhuMusicBox>(), ModContent.TileType<Content.Tiles.EyeofCthulhuMusicBox>());
                }

                if (ModContent.GetInstance<MusicConfig>().KingSlimeAltTheme)
                {
                    AddMusicBox("KingSlimeAlt", ModContent.ItemType<Content.Items.KingSlimeMusicBox>(), ModContent.TileType<Content.Tiles.KingSlimeMusicBox>());
                }
                else
                {
                    AddMusicBox("KingSlime", ModContent.ItemType<Content.Items.KingSlimeMusicBox>(), ModContent.TileType<Content.Tiles.KingSlimeMusicBox>());
                }

                if (ModContent.GetInstance<MusicConfig>().BloodMoonAltTheme)
                {
                    AddMusicBox("BloodMoonAlt", ModContent.ItemType<Content.Items.BloodMoonMusicBox>(), ModContent.TileType<Content.Tiles.BloodMoonMusicBox>());
                }
                else
                {
                    AddMusicBox("BloodMoon", ModContent.ItemType<Content.Items.BloodMoonMusicBox>(), ModContent.TileType<Content.Tiles.BloodMoonMusicBox>());
                }

                AddMusicBox("AbyssLayer3Alt", ModContent.ItemType<Content.Items.AbyssLayer3AltMusicBox>(), ModContent.TileType<Content.Tiles.AbyssLayer3AltMusicBox>());

                if (ModContent.GetInstance<MusicConfig>().CrimsonAltTheme)
                {
                    AddMusicBox("CrimsonAlt", ModContent.ItemType<Content.Items.CrimsonMusicBox>(), ModContent.TileType<Content.Tiles.CrimsonMusicBox>());
                }
                else
                {
                    AddMusicBox("Crimson", ModContent.ItemType<Content.Items.CrimsonMusicBox>(), ModContent.TileType<Content.Tiles.CrimsonMusicBox>());
                }

                if (ModContent.GetInstance<MusicConfig>().RainAltTheme)
                {
                    AddMusicBox("RainAlt", ModContent.ItemType<Content.Items.RainMusicBox>(), ModContent.TileType<Content.Tiles.RainMusicBox>());
                }
                else
                {
                    AddMusicBox("Rain", ModContent.ItemType<Content.Items.RainMusicBox>(), ModContent.TileType<Content.Tiles.RainMusicBox>());
                }

                //Biomes
                AddMusicBox("Space", ModContent.ItemType<Content.Items.SpaceMusicBox>(), ModContent.TileType<Content.Tiles.SpaceMusicBox>());
                AddMusicBox("Underworld", ModContent.ItemType<Content.Items.UnderworldMusicBox>(), ModContent.TileType<Content.Tiles.UnderworldMusicBox>());
                //AddMusicBox("Aether", ModContent.ItemType<Content.Items.AetherMusicBox>(), ModContent.TileType<Content.Tiles.AetherMusicBox>());
                //AddMusicBox("Graveyard", ModContent.ItemType<Content.Items.GraveyardMusicBox>(), ModContent.TileType<Content.Tiles.GraveyardMusicBox>());
                AddMusicBox("Meteorite", ModContent.ItemType<Content.Items.MeteoriteMusicBox>(), ModContent.TileType<Content.Tiles.MeteoriteMusicBox>());
                AddMusicBox("WorkshopTier6", ModContent.ItemType<Content.Items.WorkshopTier6MusicBox>(), ModContent.TileType<Content.Tiles.WorkshopTier6MusicBox>());
                AddMusicBox("WorkshopTier5", ModContent.ItemType<Content.Items.WorkshopTier5MusicBox>(), ModContent.TileType<Content.Tiles.WorkshopTier5MusicBox>());
                AddMusicBox("WorkshopTier4", ModContent.ItemType<Content.Items.WorkshopTier4MusicBox>(), ModContent.TileType<Content.Tiles.WorkshopTier4MusicBox>());
                AddMusicBox("WorkshopTier3", ModContent.ItemType<Content.Items.WorkshopTier3MusicBox>(), ModContent.TileType<Content.Tiles.WorkshopTier3MusicBox>());
                AddMusicBox("WorkshopTier2", ModContent.ItemType<Content.Items.WorkshopTier2MusicBox>(), ModContent.TileType<Content.Tiles.WorkshopTier2MusicBox>());
                AddMusicBox("WorkshopTier1", ModContent.ItemType<Content.Items.WorkshopTier1MusicBox>(), ModContent.TileType<Content.Tiles.WorkshopTier1MusicBox>());
                AddMusicBox("TownNight", ModContent.ItemType<Content.Items.TownNightMusicBox>(), ModContent.TileType<Content.Tiles.TownNightMusicBox>());
                AddMusicBox("TownDay", ModContent.ItemType<Content.Items.TownDayMusicBox>(), ModContent.TileType<Content.Tiles.TownDayMusicBox>());
                //AddMusicBox("JungleTemple", ModContent.ItemType<Content.Items.JungleTempleMusicBox>(), ModContent.TileType<Content.Tiles.JungleTempleMusicBox>());
                AddMusicBox("Dungeon", ModContent.ItemType<Content.Items.DungeonMusicBox>(), ModContent.TileType<Content.Tiles.DungeonMusicBox>());
                AddMusicBox("GlowingMushroomFields", ModContent.ItemType<Content.Items.GlowingMushroomFieldsMusicBox>(), ModContent.TileType<Content.Tiles.GlowingMushroomFieldsMusicBox>());
                AddMusicBox("Corruption", ModContent.ItemType<Content.Items.CorruptionMusicBox>(), ModContent.TileType<Content.Tiles.CorruptionMusicBox>());
                AddMusicBox("CorruptionUnderground", ModContent.ItemType<Content.Items.CorruptionUndergroundMusicBox>(), ModContent.TileType<Content.Tiles.CorruptionUndergroundMusicBox>());
                AddMusicBox("CrimsonUnderground", ModContent.ItemType<Content.Items.CrimsonUndergroundMusicBox>(), ModContent.TileType<Content.Tiles.CrimsonUndergroundMusicBox>());
                AddMusicBox("Geodes", ModContent.ItemType<Content.Items.GeodesMusicBox>(), ModContent.TileType<Content.Tiles.GeodesMusicBox>());
                AddMusicBox("Tundra", ModContent.ItemType<Content.Items.TundraMusicBox>(), ModContent.TileType<Content.Tiles.TundraMusicBox>());
                AddMusicBox("TundraUnderground", ModContent.ItemType<Content.Items.TundraUndergroundMusicBox>(), ModContent.TileType<Content.Tiles.TundraUndergroundMusicBox>());
                //AddMusicBox("JungleNight", ModContent.ItemType<Content.Items.JungleNightMusicBox>(), ModContent.TileType<Content.Tiles.JungleNightMusicBox>());
                //AddMusicBox("JungleDay", ModContent.ItemType<Content.Items.JungleDayMusicBox>(), ModContent.TileType<Content.Tiles.JungleDayMusicBox>());
                //AddMusicBox("JungleUndergroundHardmode", ModContent.ItemType<Content.Items.JungleUndergroundHardmodeMusicBox>(), ModContent.TileType<Content.Tiles.JungleUndergroundHardmodeMusicBox>());
                //AddMusicBox("JungleUnderground", ModContent.ItemType<Content.Items.JungleUndergroundMusicBox>(), ModContent.TileType<Content.Tiles.JungleUndergroundMusicBox>());
                //AddMusicBox("Hallow", ModContent.ItemType<Content.Items.HallowMusicBox>(), ModContent.TileType<Content.Tiles.HallowMusicBox>());
                //AddMusicBox("HallowUnderground", ModContent.ItemType<Content.Items.HallowUndergroundMusicBox>(), ModContent.TileType<Content.Tiles.HallowUndergroundMusicBox>());
                //AddMusicBox("DesertUnderground", ModContent.ItemType<Content.Items.DesertUndergroundMusicBox>(), ModContent.TileType<Content.Tiles.DesertUndergroundMusicBox>());
                //AddMusicBox("UndergroundHardmode", ModContent.ItemType<Content.Items.UndergroundHardmodeMusicBox>(), ModContent.TileType<Content.Tiles.UndergroundHardmodeMusicBox>());
                AddMusicBox("Caverns", ModContent.ItemType<Content.Items.CavernsMusicBox>(), ModContent.TileType<Content.Tiles.CavernsMusicBox>());
                AddMusicBox("Underground", ModContent.ItemType<Content.Items.UndergroundMusicBox>(), ModContent.TileType<Content.Tiles.UndergroundMusicBox>());
                AddMusicBox("OceanNight", ModContent.ItemType<Content.Items.OceanNightMusicBox>(), ModContent.TileType<Content.Tiles.OceanNightMusicBox>());
                AddMusicBox("OceanDay", ModContent.ItemType<Content.Items.OceanDayMusicBox>(), ModContent.TileType<Content.Tiles.OceanDayMusicBox>());
                AddMusicBox("Desert", ModContent.ItemType<Content.Items.DesertMusicBox>(), ModContent.TileType<Content.Tiles.DesertMusicBox>());
                AddMusicBox("ForestNight", ModContent.ItemType<Content.Items.ForestNightMusicBox>(), ModContent.TileType<Content.Tiles.ForestNightMusicBox>());
                AddMusicBox("ForestDayEvening", ModContent.ItemType<Content.Items.ForestDayEveningMusicBox>(), ModContent.TileType<Content.Tiles.ForestDayEveningMusicBox>());
                AddMusicBox("ForestDayAfternoon", ModContent.ItemType<Content.Items.ForestDayAfternoonMusicBox>(), ModContent.TileType<Content.Tiles.ForestDayAfternoonMusicBox>());
                AddMusicBox("ForestDayMorning", ModContent.ItemType<Content.Items.ForestDayMorningMusicBox>(), ModContent.TileType<Content.Tiles.ForestDayMorningMusicBox>());
                AddMusicBox("ForestDayDawn", ModContent.ItemType<Content.Items.ForestDayDawnMusicBox>(), ModContent.TileType<Content.Tiles.ForestDayDawnMusicBox>());

                //Bosses
                AddMusicBox("MoonLord", ModContent.ItemType<Content.Items.MoonLordMusicBox>(), ModContent.TileType<Content.Tiles.MoonLordMusicBox>());
                //AddMusicBox("LunaticCultist", ModContent.ItemType<Content.Items.LunaticCultistMusicBox>(), ModContent.TileType<Content.Tiles.LunaticCultistMusicBox>());
                //AddMusicBox("EmpressofLight", ModContent.ItemType<Content.Items.EmpressofLightMusicBox>(), ModContent.TileType<Content.Tiles.EmpressofLightMusicBox>());
                //AddMusicBox("DukeFishron", ModContent.ItemType<Content.Items.DukeFishronMusicBox>(), ModContent.TileType<Content.Tiles.DukeFishronMusicBox>());
                //AddMusicBox("Golem", ModContent.ItemType<Content.Items.GolemMusicBox>(), ModContent.TileType<Content.Tiles.GolemMusicBox>());
                //AddMusicBox("Plantera", ModContent.ItemType<Content.Items.PlanteraMusicBox>(), ModContent.TileType<Content.Tiles.PlanteraMusicBox>());
                //AddMusicBox("MechanicalTrio", ModContent.ItemType<Content.Items.MechanicalTrioMusicBox>(), ModContent.TileType<Content.Tiles.MechanicalTrioMusicBox>());
                //AddMusicBox("SkeletronPrime", ModContent.ItemType<Content.Items.SkeletronPrimeMusicBox>(), ModContent.TileType<Content.Tiles.SkeletronPrimeMusicBox>());
                //AddMusicBox("Twins", ModContent.ItemType<Content.Items.TwinsMusicBox>(), ModContent.TileType<Content.Tiles.TwinsMusicBox>());
                //AddMusicBox("QueenSlime", ModContent.ItemType<Content.Items.QueenSlimeMusicBox>(), ModContent.TileType<Content.Tiles.QueenSlimeMusicBox>());
                AddMusicBox("WallofFlesh", ModContent.ItemType<Content.Items.WallofFleshMusicBox>(), ModContent.TileType<Content.Tiles.WallofFleshMusicBox>());
                AddMusicBox("Skeletron", ModContent.ItemType<Content.Items.SkeletronMusicBox>(), ModContent.TileType<Content.Tiles.SkeletronMusicBox>());
                //AddMusicBox("QueenBee", ModContent.ItemType<Content.Items.QueenBeeMusicBox>(), ModContent.TileType<Content.Tiles.QueenBeeMusicBox>());
                AddMusicBox("BrainofCthulhu", ModContent.ItemType<Content.Items.BrainofCthulhuMusicBox>(), ModContent.TileType<Content.Tiles.BrainofCthulhuMusicBox>());
                AddMusicBox("EaterofWorlds", ModContent.ItemType<Content.Items.EaterofWorldsMusicBox>(), ModContent.TileType<Content.Tiles.EaterofWorldsMusicBox>());

                //Events
                //AddMusicBox("FrostMoon", ModContent.ItemType<Content.Items.FrostMoonMusicBox>(), ModContent.TileType<Content.Tiles.FrostMoonMusicBox>());
                //AddMusicBox("PumpkinMoon", ModContent.ItemType<Content.Items.PumpkinMoonMusicBox>(), ModContent.TileType<Content.Tiles.PumpkinMoonMusicBox>());
                //AddMusicBox("TorchGod", ModContent.ItemType<Content.Items.TorchGodMusicBox>(), ModContent.TileType<Content.Tiles.TorchGodMusicBox>());
                //AddMusicBox("LunarTowersSolar", ModContent.ItemType<Content.Items.LunarTowersSolarMusicBox>(), ModContent.TileType<Content.Tiles.LunarTowersSolarMusicBox>());
                //AddMusicBox("LunarTowersNebula", ModContent.ItemType<Content.Items.LunarTowersNebulaMusicBox>(), ModContent.TileType<Content.Tiles.LunarTowersNebulaMusicBox>());
                //AddMusicBox("LunarTowersVortex", ModContent.ItemType<Content.Items.LunarTowersVortexMusicBox>(), ModContent.TileType<Content.Tiles.LunarTowersVortexMusicBox>());
                //AddMusicBox("LunarTowersStardust", ModContent.ItemType<Content.Items.LunarTowersStardustMusicBox>(), ModContent.TileType<Content.Tiles.LunarTowersStardustMusicBox>());
                //AddMusicBox("MartianMadness", ModContent.ItemType<Content.Items.MartianMadnessMusicBox>(), ModContent.TileType<Content.Tiles.MartianMadnessMusicBox>());
                //AddMusicBox("PirateInvasion", ModContent.ItemType<Content.Items.PirateInvasionMusicBox>(), ModContent.TileType<Content.Tiles.PirateInvasionMusicBox>());
                //AddMusicBox("GoblinArmy", ModContent.ItemType<Content.Items.GoblinArmyMusicBox>(), ModContent.TileType<Content.Tiles.GoblinArmyMusicBox>());
                //AddMusicBox("SolarEclipse", ModContent.ItemType<Content.Items.SolarEclipseMusicBox>(), ModContent.TileType<Content.Tiles.SolarEclipseMusicBox>());
                AddMusicBox("BloodMoonDeath", ModContent.ItemType<Content.Items.BloodMoonDeathMusicBox>(), ModContent.TileType<Content.Tiles.BloodMoonDeathMusicBox>());
                AddMusicBox("SlimeRain", ModContent.ItemType<Content.Items.SlimeRainMusicBox>(), ModContent.TileType<Content.Tiles.SlimeRainMusicBox>());
                //AddMusicBox("Blizzard", ModContent.ItemType<Content.Items.BlizzardMusicBox>(), ModContent.TileType<Content.Tiles.BlizzardMusicBox>());
                //AddMusicBox("Sandstorm", ModContent.ItemType<Content.Items.SandstormMusicBox>(), ModContent.TileType<Content.Tiles.SandstormMusicBox>());
                //AddMusicBox("Thunderstorm", ModContent.ItemType<Content.Items.ThunderstormMusicBox>(), ModContent.TileType<Content.Tiles.ThunderstormMusicBox>());
                //AddMusicBox("WindyDay", ModContent.ItemType<Content.Items.WindyDayMusicBox>(), ModContent.TileType<Content.Tiles.WindyDayMusicBox>());
                AddMusicBox("LanternFestival", ModContent.ItemType<Content.Items.LanternFestivalMusicBox>(), ModContent.TileType<Content.Tiles.LanternFestivalMusicBox>());

                //Misc
                AddMusicBox("HardmodeInterlude", ModContent.ItemType<Content.Items.HardmodeInterludeMusicBox>(), ModContent.TileType<Content.Tiles.HardmodeInterludeMusicBox>());
                AddMusicBox("FalseEpilogue", ModContent.ItemType<Content.Items.FalseEpilogueMusicBox>(), ModContent.TileType<Content.Tiles.FalseEpilogueMusicBox>());
                //AddMusicBox("DragonsLull", ModContent.ItemType<Content.Items.DragonsLullMusicBox>(), ModContent.TileType<Content.Tiles.DragonsLullMusicFaux>());
                AddMusicBox("RainLegacy", ModContent.ItemType<Content.Items.RainLegacyMusicBox>(), ModContent.TileType<Content.Tiles.RainLegacyMusicBox>());
                //AddMusicBox("ImpendingDoom", ModContent.ItemType<Content.Items.ImpendingDoomMusicBox>(), ModContent.TileType<Content.Tiles.ImpendingDoomMusicBox>());
                //AddMusicBox("CultistRitual", ModContent.ItemType<Content.Items.CultistRitualMusicBox>(), ModContent.TileType<Content.Tiles.CultistRitualMusicBox>());
                //AddMusicBox("ImminentDestruction", ModContent.ItemType<Content.Items.ImminentDestructionMusicBox>(), ModContent.TileType<Content.Tiles.ImminentDestructionMusicBox>());
            }
        }
    }
}
