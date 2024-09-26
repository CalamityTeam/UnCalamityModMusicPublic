using Terraria.Localization;
using Terraria.ModLoader;

namespace UnCalamityModMusic.Common.ModCompatibility
{
    public class MusicDisplayCompatibility : ModSystem
    {
        public override void PostSetupContent()
        {
            MusicDisplaySetup();
        }

        public void MusicDisplaySetup()
        {
            var musicDisplay = ModLoader.TryGetMod("MusicDisplay", out Mod display);

            if (!musicDisplay)
            {
                return;
            }

            void AddMusic(string songKey, string authorKey, string songType)
            {
                short slot = (short)MusicLoader.GetMusicSlot(Mod, $"Assets/Music/{songType}/{songKey}");
                display.Call("AddMusic", slot, Language.GetTextValue("Mods.UnCalamityModMusic.ModSupport.MusicDisplay.SongNames." + songKey), Language.GetTextValue("Mods.UnCalamityModMusic.ModSupport.MusicDisplay.Authors." + authorKey), Mod.DisplayName);
            }

            AddMusic("AbyssLayer3Alt", "HeartPlusUp", "Alternates");
            AddMusic("Space", "HeartPlusUp", "Biomes");
            AddMusic("Underworld", "HeartPlusUp", "Biomes");
            //AddMusic("Aether", "HeartPlusUp", "Biomes");
            //AddMusic("Graveyard", "HeartPlusUp", "Biomes");
            AddMusic("Meteorite", "HeartPlusUp", "Biomes");
            AddMusic("WorkshopTier6", "HeartPlusUp", "Biomes");
            AddMusic("WorkshopTier5", "HeartPlusUp", "Biomes");
            AddMusic("WorkshopTier4", "HeartPlusUp", "Biomes");
            AddMusic("WorkshopTier3", "HeartPlusUp", "Biomes");
            AddMusic("WorkshopTier2", "HeartPlusUp", "Biomes");
            AddMusic("WorkshopTier1", "HeartPlusUp", "Biomes");
            AddMusic("TownNight", "HeartPlusUp", "Biomes");
            AddMusic("TownNight_Noiseless", "HeartPlusUp", "Biomes");
            AddMusic("TownDay", "HeartPlusUp", "Biomes");
            //AddMusic("JungleTemple", "Universe", "Biomes");
            AddMusic("Dungeon", "HeartPlusUp", "Biomes");
            AddMusic("GlowingMushroomFields", "HeartPlusUp", "Biomes");
            AddMusic("Corruption", "HeartPlusUp", "Biomes");
            AddMusic("CorruptionUnderground", "HeartPlusUp", "Biomes");
            AddMusic("Crimson", "SkippyZii", "Biomes");
            AddMusic("CrimsonUnderground", "SkippyZii", "Biomes");
            AddMusic("Geodes", "HeartPlusUp", "Biomes");
            AddMusic("Tundra", "HeartPlusUp", "Biomes");
            AddMusic("TundraUnderground", "HeartPlusUp", "Biomes");
            //AddMusic("JungleNight", "HeartPlusUp", "Biomes");
            //AddMusic("JungleDay", "HeartPlusUp", "Biomes");
            //AddMusic("JungleUndergroundHardmode", "HeartPlusUp", "Biomes");
            //AddMusic("JungleUnderground", "HeartPlusUp", "Biomes");
            //AddMusic("Hallow", "HeartPlusUp", "Biomes");
            //AddMusic("HallowUnderground", "HeartPlusUp", "Biomes");
            //AddMusic("DesertUnderground", "HeartPlusUp", "Biomes");
            //AddMusic("UndergroundHardmode", "HeartPlusUp", "Biomes");
            AddMusic("Caverns", "HeartPlusUp", "Biomes");
            AddMusic("Underground", "HeartPlusUp", "Biomes");
            AddMusic("OceanNight", "HeartPlusUp", "Biomes");
            AddMusic("OceanDay", "HeartPlusUp", "Biomes");
            AddMusic("Desert", "HeartPlusUp", "Biomes");
            AddMusic("ForestNight", "HeartPlusUp", "Biomes");
            AddMusic("ForestDayEvening", "HeartPlusUp", "Biomes");
            AddMusic("ForestDayAfternoon", "HeartPlusUp", "Biomes");
            AddMusic("ForestDayMorning", "HeartPlusUp", "Biomes");
            AddMusic("ForestDayDawn", "HeartPlusUp", "Biomes");
            AddMusic("MoonLord", "psykomatic", "Bosses");
            //AddMusic("LunaticCultist", "HeartPlusUp", "Bosses");
            //AddMusic("EmpressofLight", "HeartPlusUp", "Bosses");
            //AddMusic("DukeFishron", "Universe", "Bosses");
            //AddMusic("Golem", "Universe", "Bosses");
            //AddMusic("Plantera", "HeartPlusUp", "Bosses");
            //AddMusic("MechanicalTrio", "HeartPlusUp", "Bosses");
            //AddMusic("SkeletronPrime", "HeartPlusUp", "Bosses");
            //AddMusic("Twins", "HeartPlusUp", "Bosses");
            //AddMusic("Destroyer", "HeartPlusUp", "Bosses");
            //AddMusic("QueenSlime", "HeartPlusUp", "Bosses");
            AddMusic("WallofFlesh", "HeartPlusUp", "Bosses");
            AddMusic("Skeletron", "HeartPlusUp", "Bosses");
            //AddMusic("QueenBee", "HeartPlusUp", "Bosses");
            AddMusic("BrainofCthulhu", "HeartPlusUpFeature2", "Bosses");
            AddMusic("EaterofWorlds", "HeartPlusUp", "Bosses");
            AddMusic("EyeofCthulhu", "HeartPlusUpFeature1", "Bosses");
            AddMusic("KingSlime", "HeartPlusUp", "Bosses");
            //AddMusic("FrostMoon", "HeartPlusUp", "Events");
            //AddMusic("PumpkinMoon", "HeartPlusUp", "Events");
            AddMusic("TorchGod", "HeartPlusUp", "Events");
            AddMusic("TorchGodRevengeance", "HeartPlusUp", "Events");
            //AddMusic("LunarTowersSolar", "HeartPlusUp", "Events");
            //AddMusic("LunarTowersNebula", "HeartPlusUp", "Events");
            //AddMusic("LunarTowersVortex", "HeartPlusUp", "Events");
            //AddMusic("LunarTowersStardust", "HeartPlusUp", "Events");
            //AddMusic("MartianMadness", "HeartPlusUp", "Events");
            //AddMusic("PirateInvasion", "HeartPlusUp", "Events");
            //AddMusic("FrostLegion", "HeartPlusUp", "Events");
            //AddMusic("GoblinArmy", "HeartPlusUp", "Events");
            //AddMusic("SolarEclipse", "HeartPlusUp", "Events");
            AddMusic("BloodMoon", "Thriplerex", "Events");
            AddMusic("BloodMoonDeath", "Thriplerex", "Events");
            AddMusic("SlimeRain", "HeartPlusUp", "Events");
            //AddMusic("Blizzard", "Universe", "Events");
            //AddMusic("Sandstorm", "Universe", "Events");
            AddMusic("OceanRain", "HeartPlusUp", "Events");
            //AddMusic("Thunderstorm", "Universe", "Events");
            AddMusic("TownRain", "HeartPlusUp", "Events");
            AddMusic("Rain", "HeartPlusUp", "Events");
            AddMusic("TownParty", "HeartPlusUp", "Events");
            //AddMusic("WindyDay", "HeartPlusUp", "Events");
            AddMusic("LanternFestival", "HeartPlusUp", "Events");
            AddMusic("HardmodeInterlude", "Salvati", "Misc");
            AddMusic("FalseEpilogue", "HeartPlusUp", "Misc");
            //AddMusic("DragonsLull", "HeartPlusUp", "Misc");
            AddMusic("RainLegacy", "HeartPlusUp", "Misc");
            //AddMusic("ImpendingDoom", "HeartPlusUp", "Misc");
            //AddMusic("CultistRitual", "HeartPlusUp", "Misc");
            //AddMusic("ImminentDestruction", "HeartPlusUp", "Misc");
        }
    }
}
