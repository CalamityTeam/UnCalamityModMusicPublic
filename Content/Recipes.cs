using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace UnCalamityModMusic.Content
{
	public class Recipes : ModSystem
	{
		public static int musicBoxCraftingStation = TileID.HeavyWorkBench;

		public static RecipeGroup CopperOreGroup;
		public static RecipeGroup GoldOreGroup;
		public static RecipeGroup CobaltOreGroup;
		public static RecipeGroup CopperBarGroup;
		public static RecipeGroup GoldBarGroup;
		public static RecipeGroup MythrilBarGroup;
		public static RecipeGroup AdamantiteBarGroup;
		public static RecipeGroup EvilPowderGroup;
		public static RecipeGroup TombstoneGroup;

		public override void Unload()
		{
			CopperOreGroup = null;
			GoldOreGroup = null;
			CobaltOreGroup = null;
			CopperBarGroup = null;
			GoldBarGroup = null;
			MythrilBarGroup = null;
			AdamantiteBarGroup = null;
			EvilPowderGroup = null;
			TombstoneGroup = null;
		}

		public override void AddRecipeGroups()
		{
			CopperOreGroup = new RecipeGroup
			(
				() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.CopperOre)}",
				ItemID.CopperOre, ItemID.TinOre
			);
			RecipeGroup.RegisterGroup("VCMM:CopperOreGroup", CopperOreGroup);

			GoldOreGroup = new RecipeGroup
			(
				() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.GoldOre)}",
				ItemID.GoldOre, ItemID.PlatinumOre
			);
			RecipeGroup.RegisterGroup("VCMM:GoldOreGroup", GoldOreGroup);

			CobaltOreGroup = new RecipeGroup
			(
				() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.CobaltOre)}",
				ItemID.CobaltOre, ItemID.PalladiumOre
			);
			RecipeGroup.RegisterGroup("VCMM:CobaltOreGroup", CobaltOreGroup);

			CopperBarGroup = new RecipeGroup
			(
				() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.CopperBar)}",
				ItemID.CopperBar, ItemID.TinBar
			);
			RecipeGroup.RegisterGroup("VCMM:CopperBarGroup", CopperBarGroup);

			GoldBarGroup = new RecipeGroup
			(
				() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.GoldBar)}",
				ItemID.GoldBar, ItemID.PlatinumBar
			);
			RecipeGroup.RegisterGroup("VCMM:GoldBarGroup", GoldBarGroup);

			MythrilBarGroup = new RecipeGroup
			(
				() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.MythrilBar)}",
				ItemID.MythrilBar, ItemID.OrichalcumBar
			);
			RecipeGroup.RegisterGroup("VCMM:MythrilBarGroup", MythrilBarGroup);

			AdamantiteBarGroup = new RecipeGroup
			(
				() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.AdamantiteBar)}",
				ItemID.AdamantiteBar, ItemID.TitaniumBar
			);
			RecipeGroup.RegisterGroup("VCMM:AdamantiteBarGroup", AdamantiteBarGroup);

			EvilPowderGroup = new RecipeGroup
			(
				() => $"{Language.GetTextValue("LegacyMisc.37")} {Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.EvilPowder")}",
				ItemID.VilePowder, ItemID.ViciousPowder
			);
			RecipeGroup.RegisterGroup("VCMM:EvilPowderGroup", EvilPowderGroup);

			TombstoneGroup = new RecipeGroup
			(
				() => $"{Language.GetTextValue("LegacyMisc.37")} {Lang.GetItemNameValue(ItemID.Tombstone)}",
				ItemID.Tombstone, ItemID.GraveMarker, ItemID.CrossGraveMarker, ItemID.Headstone, ItemID.Gravestone, ItemID.Obelisk, ItemID.RichGravestone1, ItemID.RichGravestone2, ItemID.RichGravestone3, ItemID.RichGravestone4, ItemID.RichGravestone5
			);
			RecipeGroup.RegisterGroup("VCMM:TombstoneGroup", TombstoneGroup);
		}

		public override void AddRecipes()
		{
			var calamityMod = ModLoader.TryGetMod("CalamityMod", out Mod calamity);
			var calamityModMusic = ModLoader.TryGetMod("CalamityModMusic", out Mod cmusic);
			var otherCalamityModMusic = ModLoader.TryGetMod("OtherCalamityModMusic", out Mod othermusic);
			var calamityVanities = ModLoader.TryGetMod("CalValEX", out Mod calval);
			var catalystMod = ModLoader.TryGetMod("CatalystMod", out Mod catalyst);

			//Empty Music Box
			Recipe.Create(ItemID.MusicBox, 1)
				.AddRecipeGroup(RecipeGroupID.Wood, 6)
				.AddRecipeGroup("VCMM:CopperBarGroup", 5)
				.AddRecipeGroup(RecipeGroupID.IronBar, 2)
				.AddIngredient(ItemID.LifeCrystal, 1)
				.AddTile(musicBoxCraftingStation)
				.Register();

			#region Calamity Music Boxes
			if (calamityMod)
			{
				//Exo Mech Selection
				try
				{
					Recipe.Create(calamity.Find<ModItem>("DraedonExoSelectMusicBox").Type, 1)
						.AddIngredient(calamity, "MysteriousCircuitry", 10)
						.AddIngredient(calamity, "EndothermicEnergy", 10)
						.AddIngredient(calamity, "AuricBar", 3)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Codebreaker
				try
				{
					Recipe.Create(calamity.Find<ModItem>("DraedonTalkMusicBox").Type, 1)
						.AddIngredient(calamity, "MysteriousCircuitry", 10)
						.AddIngredient(calamity, "ExoPrismPanel", 10)
						.AddIngredient(calamity, "AuricBar", 3)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}
			}

			if (calamityModMusic)
			{
				//Existing Recipes Removal
				Recipe[] mainRecipe = Main.recipe;
				foreach (Recipe recipeFinder in mainRecipe)
				{
					if (recipeFinder.HasResult(cmusic.Find<ModItem>("AcidRainTier1MusicBox")))
					{
						recipeFinder.DisableRecipe();
					}
					if (recipeFinder.HasResult(cmusic.Find<ModItem>("AdultEidolonWyrmMusicBox")))
					{
						recipeFinder.DisableRecipe();
					}
					if (recipeFinder.HasResult(cmusic.Find<ModItem>("CalamitasDefeatMusicBox")))
					{
						recipeFinder.DisableRecipe();
					}
					if (recipeFinder.HasResult(cmusic.Find<ModItem>("CalamityTitleMusicBox")))
					{
						recipeFinder.DisableRecipe();
					}
					if (recipeFinder.HasResult(cmusic.Find<ModItem>("YharonLegacyMusicBox")))
					{
						recipeFinder.DisableRecipe();
					}
				}
			}

			if (calamityModMusic && calamityMod)
			{
				//Abyss Layer 1
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("AbyssLayer1MusicBox").Type, 1)
						.AddIngredient(calamity, "SulphurousShale", 10)
						.AddIngredient(calamity, "SulphurousSandstone", 10)
						.AddIngredient(calamity, "AbyssTreasureChest", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Abyss Layer 2
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("AbyssLayer2MusicBox").Type, 1)
						.AddIngredient(calamity, "AbyssGravel", 10)
						.AddIngredient(calamity, "PlantyMush", 10)
						.AddIngredient(calamity, "StrangeOrb", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Abyss Layer 3
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("AbyssLayer3MusicBox").Type, 1)
						.AddIngredient(calamity, "PyreMantle", 10)
						.AddIngredient(calamity, "DepthCells", 10)
						.AddIngredient(calamity, "ChaoticOre", 10)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Abyss Layer 4
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("AbyssLayer4MusicBox").Type, 1)
						.AddIngredient(calamity, "Voidstone", 10)
						.AddIngredient(calamity, "Lumenite", 10)
						.AddIngredient(calamity, "ReaperTooth", 3)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Acid Rain Tier 1
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("AcidRainTier1MusicBox").Type, 1)
						.AddIngredient(calamity, "Acidwood", 10)
						.AddIngredient(calamity, "SulfuricScale", 10)
						.AddIngredient(calamity, "SulphurousSand", 10)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Acid Rain Tier 3
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("AcidRainTier3MusicBox").Type, 1)
						.AddIngredient(calamity, "Acidwood", 10)
						.AddIngredient(calamity, "CorrodedFossil", 10)
						.AddIngredient(calamity, "MaulerTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("AcidRainTier3MusicBox").Type, 1)
						.AddIngredient(calamity, "Acidwood", 10)
						.AddIngredient(calamity, "CorrodedFossil", 10)
						.AddIngredient(calamity, "NuclearTerrorTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Adult Eidolon Wyrm
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("AdultEidolonWyrmMusicBox").Type, 1)
						.AddIngredient(calamity, "HalibutCannon", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Anahita
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("AnahitaMusicBox").Type, 1)
						.AddIngredient(calamity, "AnahitaTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Anahita's Lure
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("AnahitasLureMusicBox").Type, 1)
						.AddIngredient(calamity, "AnahitaTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Aquatic Scourge
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("AquaticScourgeMusicBox").Type, 1)
						.AddIngredient(calamity, "AquaticScourgeTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Astral Infection
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("AstralInfectionMusicBox").Type, 1)
						.AddIngredient(calamity, "AstralMonolith", 10)
						.AddIngredient(calamity, "Stardust", 10)
						.AddIngredient(ItemID.FallenStar, 10)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Underground Astral Infection
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("AstralInfectionUndergroundMusicBox").Type, 1)
						.AddIngredient(calamity, "AstralStone", 10)
						.AddIngredient(calamity, "Stardust", 10)
						.AddIngredient(calamity, "AstralClay", 10)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Astrum Aureus
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("AstrumAureusMusicBox").Type, 1)
						.AddIngredient(calamity, "AstrageldonTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Astrum Deus
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("AstrumDeusMusicBox").Type, 1)
						.AddIngredient(calamity, "AstrumDeusTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Bio Lab
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("BioLabMusicBox").Type, 1)
						.AddIngredient(calamity, "MysteriousCircuitry", 10)
						.AddIngredient(calamity, "DubiousPlating", 10)
						.AddIngredient(calamity, "Chaosplate", 10)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("BioLabMusicBox").Type, 1)
						.AddIngredient(calamity, "MysteriousCircuitry", 10)
						.AddIngredient(calamity, "DubiousPlating", 10)
						.AddIngredient(calamity, "Cinderplate", 10)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("BioLabMusicBox").Type, 1)
						.AddIngredient(calamity, "MysteriousCircuitry", 10)
						.AddIngredient(calamity, "DubiousPlating", 10)
						.AddIngredient(calamity, "Elumplate", 10)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("BioLabMusicBox").Type, 1)
						.AddIngredient(calamity, "MysteriousCircuitry", 10)
						.AddIngredient(calamity, "DubiousPlating", 10)
						.AddIngredient(calamity, "Navyplate", 10)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("BioLabMusicBox").Type, 1)
						.AddIngredient(calamity, "MysteriousCircuitry", 10)
						.AddIngredient(calamity, "DubiousPlating", 10)
						.AddIngredient(calamity, "PlagueContainmentCells", 10)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("BioLabMusicBox").Type, 1)
						.AddIngredient(calamity, "MysteriousCircuitry", 10)
						.AddIngredient(calamity, "DubiousPlating", 10)
						.AddIngredient(calamity, "Onyxplate", 10)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Boss Rush Tier 1
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("BossRushTier1MusicBox").Type, 1)
						.AddIngredient(ItemID.WallofFleshTrophy, 1)
						.AddIngredient(calamity, "ShadowspecBar", 3)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Boss Rush Tier 2
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("BossRushTier2MusicBox").Type, 1)
						.AddIngredient(ItemID.PlanteraTrophy, 1)
						.AddIngredient(calamity, "ShadowspecBar", 3)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Boss Rush Tier 3
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("BossRushTier3MusicBox").Type, 1)
						.AddIngredient(ItemID.MoonLordTrophy, 1)
						.AddIngredient(calamity, "ShadowspecBar", 3)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Boss Rush Tier 4
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("BossRushTier4MusicBox").Type, 1)
						.AddIngredient(calamity, "DevourerofGodsTrophy", 1)
						.AddIngredient(calamity, "ShadowspecBar", 3)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Boss Rush Tier 5
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("BossRushTier5MusicBox").Type, 1)
						.AddIngredient(calamity, "Rock", 1)
						.AddIngredient(calamity, "ShadowspecBar", 3)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Brimstone Crags
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("BrimstoneCragsMusicBox").Type, 1)
						.AddIngredient(calamity, "ScorchedBone", 10)
						.AddIngredient(calamity, "BrimstoneSlab", 10)
						.AddIngredient(calamity, "ScorchedRemains", 10)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Brimstone Elemental
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("BrimstoneElementalMusicBox").Type, 1)
						.AddIngredient(calamity, "BrimstoneElementalTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Calamitas Clone
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("CalamitasCloneMusicBox").Type, 1)
						.AddIngredient(calamity, "CalamitasTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("CalamitasCloneMusicBox").Type, 1)
						.AddIngredient(calamity, "CataclysmTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("CalamitasCloneMusicBox").Type, 1)
						.AddIngredient(calamity, "CatastropheTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Calamitas Defeat
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("CalamitasDefeatMusicBox").Type, 1)
						.AddIngredient(calamity, "SupremeCalamitasTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("CalamitasDefeatMusicBox").Type, 1)
						.AddIngredient(calamity, "SupremeCataclysmTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("CalamitasDefeatMusicBox").Type, 1)
						.AddIngredient(calamity, "SupremeCatastropheTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Calamitas Phase 1
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("CalamitasPhase1MusicBox").Type, 1)
						.AddIngredient(calamity, "SupremeCalamitasTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("CalamitasPhase1MusicBox").Type, 1)
						.AddIngredient(calamity, "SupremeCataclysmTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("CalamitasPhase1MusicBox").Type, 1)
						.AddIngredient(calamity, "SupremeCatastropheTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Calamitas Phase 2
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("CalamitasPhase2MusicBox").Type, 1)
						.AddIngredient(calamity, "SupremeCalamitasTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("CalamitasPhase2MusicBox").Type, 1)
						.AddIngredient(calamity, "SupremeCataclysmTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("CalamitasPhase2MusicBox").Type, 1)
						.AddIngredient(calamity, "SupremeCatastropheTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Calamitas Phase 3
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("CalamitasPhase3MusicBox").Type, 1)
						.AddIngredient(calamity, "SupremeCalamitasTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("CalamitasPhase3MusicBox").Type, 1)
						.AddIngredient(calamity, "SupremeCataclysmTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("CalamitasPhase3MusicBox").Type, 1)
						.AddIngredient(calamity, "SupremeCatastropheTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Calamity Title
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("CalamityTitleMusicBox").Type, 1)
						.AddIngredient(calamity, "EssenceofHavoc", 10)
						.AddIngredient(calamity, "BrimstoneSlag", 10)
						.AddIngredient(calamity, "CalamityDust", 10)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Ceaseless Void
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("CeaselessVoidMusicBox").Type, 1)
						.AddIngredient(calamity, "CeaselessVoidTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Crabulon
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("CrabulonMusicBox").Type, 1)
						.AddIngredient(calamity, "CrabulonTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Cryogen
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("CryogenMusicBox").Type, 1)
						.AddIngredient(calamity, "CryogenTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Desert Scourge
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("DesertScourgeMusicBox").Type, 1)
						.AddIngredient(calamity, "DesertScourgeTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Devourer of Gods Phase 1
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("DevourerofGodsPhase1MusicBox").Type, 1)
						.AddIngredient(calamity, "DevourerofGodsTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Devourer of Gods Phase 2
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("DevourerofGodsPhase2MusicBox").Type, 1)
						.AddIngredient(calamity, "DevourerofGodsTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Dragonfolly
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("DragonfollyMusicBox").Type, 1)
						.AddIngredient(calamity, "BumblebirbTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Exo Mechs
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("ExoMechsMusicBox").Type, 1)
						.AddIngredient(calamity, "ArtemisTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("ExoMechsMusicBox").Type, 1)
						.AddIngredient(calamity, "ApolloTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("ExoMechsMusicBox").Type, 1)
						.AddIngredient(calamity, "ThanatosTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("ExoMechsMusicBox").Type, 1)
						.AddIngredient(calamity, "AresTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Hive Mind
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("HiveMindMusicBox").Type, 1)
						.AddIngredient(calamity, "HiveMindTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Leviathan
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("LeviathanMusicBox").Type, 1)
						.AddIngredient(calamity, "LeviathanTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Old Duke
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("OldDukeMusicBox").Type, 1)
						.AddIngredient(calamity, "OldDukeTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Perforators
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("PerforatorsMusicBox").Type, 1)
						.AddIngredient(calamity, "PerforatorTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Plaguebringer Goliath
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("PlaguebringerGoliathMusicBox").Type, 1)
						.AddIngredient(calamity, "PlaguebringerGoliathTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Polterghast
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("PolterghastMusicBox").Type, 1)
						.AddIngredient(calamity, "PolterghastTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Profaned Guardians
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("ProfanedGuardiansMusicBox").Type, 1)
						.AddIngredient(calamity, "ProfanedGuardianTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Providence
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("ProvidenceMusicBox").Type, 1)
						.AddIngredient(calamity, "ProvidenceTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Ravager
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("RavagerMusicBox").Type, 1)
						.AddIngredient(calamity, "RavagerTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Signus
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("SignusMusicBox").Type, 1)
						.AddIngredient(calamity, "SignusTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Slime God
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("SlimeGodMusicBox").Type, 1)
						.AddIngredient(calamity, "SlimeGodTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Storm Weaver
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("StormWeaverMusicBox").Type, 1)
						.AddIngredient(calamity, "WeaverTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Sulphurous Sea Day
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("SulphurousSeaDayMusicBox").Type, 1)
						.AddIngredient(calamity, "Acidwood", 10)
						.AddIngredient(calamity, "SulphurousSand", 10)
						.AddIngredient(ItemID.Seashell, 3)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Sulphurous Sea Night
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("SulphurousSeaNightMusicBox").Type, 1)
						.AddIngredient(calamity, "Acidwood", 10)
						.AddIngredient(calamity, "SulphurousSand", 10)
						.AddIngredient(ItemID.Starfish, 3)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Sunken Sea
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("SunkenSeaMusicBox").Type, 1)
						.AddIngredient(calamity, "Navystone", 10)
						.AddIngredient(calamity, "SeaPrism", 10)
						.AddIngredient(ItemID.WhitePearl, 3)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Yharon Legacy
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("YharonLegacyMusicBox").Type, 1)
						.AddIngredient(calamity, "ForgottenDragonEgg", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Yharon Phase 1
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("YharonPhase1MusicBox").Type, 1)
						.AddIngredient(calamity, "YharonTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Yharon Phase 2
				try
				{
					Recipe.Create(cmusic.Find<ModItem>("YharonPhase2MusicBox").Type, 1)
						.AddIngredient(calamity, "YharonTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}
			}
			#endregion

			#region Calamity Addon Music Boxes
			/*if (otherCalamityModMusic)
			{
				//Planetoids
				try
				{
					Recipe.Create(othermusic.Find<ModItem>("PlanetoidsMusicBox").Type, 1)
						.AddIngredient(ItemID.Cloud, 10)
						.AddIngredient(ItemID.DirtBlock, 10)
						.AddIngredient(calamity, "Cinderplate", 10)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}
			}*/

			if (calamityVanities)
			{
				//Astral Blight
				try
				{
					Recipe.Create(calval.Find<ModItem>("AstralMusicBox").Type, 1)
						.AddIngredient(calval, "AstralTreeWood", 10)
						.AddIngredient(calval, "AstralDirt", 10)
						.AddIngredient(calval, "BlightolemurItem", 3)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}
			}

			if (catalystMod)
			{
				//Astrageldon Phase 1
				try
				{
					Recipe.Create(catalyst.Find<ModItem>("AstrageldonPhase1MusicBox").Type, 1)
						.AddIngredient(catalyst, "AstrageldonTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Astrageldon Phase 2
				try
				{
					Recipe.Create(catalyst.Find<ModItem>("AstrageldonPhase2MusicBox").Type, 1)
						.AddIngredient(catalyst, "AstrageldonTrophy", 1)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}

				//Astrageldon Title
				try
				{
					Recipe.Create(catalyst.Find<ModItem>("AstrageldonTitleMusicBox").Type, 1)
						.AddIngredient(calamity, "AstralOre", 10)
						.AddIngredient(catalyst, "AstraJelly", 10)
						.AddIngredient(catalyst, "MetanovaBar", 3)
						.AddIngredient(ItemID.MusicBox, 1)
						.AddTile(musicBoxCraftingStation)
						.Register();
				}
				catch
				{
					UnCalamityModMusic.Instance.Logger.Debug(Language.GetTextValue("Mods.UnCalamityModMusic.Recipes.NameMismatchError"));
				}
			}
			#endregion
		}
	}
}