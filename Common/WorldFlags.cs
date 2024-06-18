using Microsoft.Xna.Framework;
using System;
using System.IO;
using System.Threading;
using Terraria;
using Terraria.GameContent.Events;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace UnCalamityModMusic.Common
{
	public class WorldFlags : ModSystem
	{
		public static bool passedResurrection = false;
		public static bool passedMemory = false;
		public static bool musicPlaying = false;

		public static int resMusicSlot = 0;
		public static int memoryMusicSlot = 0;

		public static readonly TimeSpan resTiming = new TimeSpan(0, 0, 3, 21);
		public static DateTime? resStarted = null;
		public static Thread isMusicTiming = null;

		public static Thread musicTiming => new Thread((ThreadStart)delegate
		{
			DateTime? dateTime = null;
			while (musicPlaying)
			{
				if (!Main.instance.IsActive && !dateTime.HasValue)
				{
					dateTime = DateTime.Now;
				}
				else if (Main.instance.IsActive && dateTime.HasValue)
				{
					if (musicPlaying)
					{
						resStarted += DateTime.Now - dateTime.Value;
						break;
					}
					dateTime = null;
				}
			}
			dateTime = null;
			isMusicTiming = null;
		});

		public override void OnWorldLoad()
		{
			if (Main.hardMode)
			{
				passedResurrection = true;
			}
			else
			{
				passedResurrection = false;
			}
			if (NPC.downedMoonlord)
			{
				passedMemory = true;
			}
			else
			{
				passedMemory = false;
			}
			resMusicSlot = MusicPathing.GetMusicSlot("HardmodeInterlude");
			memoryMusicSlot = MusicPathing.GetMusicSlot("FalseEpilogue");
		}

		public override void OnWorldUnload()
		{
			passedResurrection = false;
			passedMemory = false;
			resStarted = null;
			musicPlaying = false;
		}

		public override void LoadWorldData(TagCompound tag)
		{
			passedResurrection = tag.ContainsKey("passedResurrection");
			passedMemory = tag.ContainsKey("passedMemory");
		}

		public override void SaveWorldData(TagCompound tag)
		{
			if (passedResurrection)
			{
				tag["passedResurrection"] = true;
			}
			if (passedMemory)
			{
				tag["passedMemory"] = true;
			}
		}

		public override void NetSend(BinaryWriter writer)
		{
			var flags = new BitsByte();
			flags[0] = passedResurrection;
			flags[1] = passedMemory;
			writer.Write(flags);
		}

		public override void NetReceive(BinaryReader reader)
		{
			BitsByte flags = reader.ReadByte();
			passedResurrection = flags[0];
			passedMemory = flags[1];
		}

		public override void UpdateUI(GameTime gameTime)
		{
			Player player = Main.player[Main.myPlayer];

			if (isMusicTiming == null)
			{
				if (!passedResurrection && Main.hardMode)
				{
					passedResurrection = true;
					musicPlaying = true;
					resStarted = DateTime.Now;
					isMusicTiming = musicTiming;
					isMusicTiming.Start();
				}
			}

			if (resStarted.HasValue)
			{
				if (Main.musicVolume == 0)
				{
					resStarted = null;
					musicPlaying = false;
					return;
				}
			}

			if (CreditsRollEvent.IsEventOngoing && !player.hasCreditsSceneMusicBox)
			{
				Main.musicBox2 = memoryMusicSlot;
				return;
			}

			if (resStarted.HasValue && !PlayerFlags.bossRushActive && Main.netMode != NetmodeID.MultiplayerClient)
			{
				DateTime now = DateTime.Now;
				DateTime? date = resStarted;
				if (now - date < resTiming)
				{
					Main.musicBox2 = resMusicSlot;
					return;
				}
			}
		}
	}
}