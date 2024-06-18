using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using UnCalamityModMusic.Common;

namespace UnCalamityModMusic.Content
{
	public class Loot : GlobalNPC
	{
		public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
		{
			if (npc.type == NPCID.WallofFlesh)
			{
				DropResurrection(1, npcLoot);
			}

			if (npc.type == NPCID.MoonLordCore)
			{
				DropMemory(1, npcLoot);
			}
		}

		public override void OnKill(NPC npc)
		{
			if (npc.type == NPCID.MoonLordCore)
			{
				NPC.SetEventFlagCleared(ref WorldFlags.passedMemory, -1);
			}
		}

		private static void DropResurrection(int stack, NPCLoot npcLoot)
		{
			LeadingConditionRule rule = new(new ResurrectionCondition());

			rule.OnSuccess(ItemDropRule.Common(ModContent.ItemType<Items.HardmodeInterludeMusicBox>(), 1));

			npcLoot.Add(rule);
		}
		private static void DropMemory(int stack, NPCLoot npcLoot)
		{
			LeadingConditionRule rule = new(new MemoryCondition());

			rule.OnSuccess(ItemDropRule.Common(ModContent.ItemType<Items.FalseEpilogueMusicBox>(), 1));

			npcLoot.Add(rule);
		}
	}

	internal class ResurrectionCondition : IItemDropRuleCondition
	{
		public bool CanDrop(DropAttemptInfo info) => !info.IsInSimulation && info.npc.type == NPCID.WallofFlesh && !WorldFlags.passedResurrection;

		public bool CanShowItemDropInUI() => true;

		public string GetConditionDescription() => Language.GetTextValue("Mods.UnCalamityModMusic.Loot.FirstKillCondition");
	}

	internal class MemoryCondition : IItemDropRuleCondition
	{
		public bool CanDrop(DropAttemptInfo info) => !info.IsInSimulation && info.npc.type == NPCID.MoonLordCore && !WorldFlags.passedMemory;

		public bool CanShowItemDropInUI() => true;

		public string GetConditionDescription() => Language.GetTextValue("Mods.UnCalamityModMusic.Loot.FirstKillCondition");
	}
}
