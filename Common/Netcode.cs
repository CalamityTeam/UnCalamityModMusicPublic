using System.IO;
using System;
using Terraria.ModLoader;

namespace UnCalamityModMusic.Common
{
    public class Netcode
    {
        public enum VanillaCalamityModMusicMessageType : byte
        {
            MusicEventSyncRequest,
            MusicEventSyncResponse
        }

        public static void HandlePacket(Mod mod, BinaryReader reader, int whoAmI)
        {
            try
            {
                VanillaCalamityModMusicMessageType msgType = (VanillaCalamityModMusicMessageType)reader.ReadByte();
                switch (msgType)
                {
                    case VanillaCalamityModMusicMessageType.MusicEventSyncRequest:
                    {
                        MusicEvents.FulfillSyncRequest(whoAmI);
                        break;
                    }

                    case VanillaCalamityModMusicMessageType.MusicEventSyncResponse:
                    {
                        MusicEvents.ReceiveSyncResponse(reader);
                        break;
                    }

                    default:
                    {
                        UnCalamityModMusic.Instance.Logger.Error($"Failed to parse VCMM packet: No VCMM packet exists with ID {msgType}.");
                        throw new Exception("Failed to parse VCMM packet: Invalid VCMM packet ID.");
                    }
                }
            }
            catch (Exception e)
            {
                if (e is EndOfStreamException eose)
                {
                    UnCalamityModMusic.Instance.Logger.Error("Failed to parse VCMM packet: Packet was too short, missing data, or otherwise corrupt.", eose);
                }
                else if (e is ObjectDisposedException ode)
                {
                    UnCalamityModMusic.Instance.Logger.Error("Failed to parse VCMM packet: Packet reader disposed or destroyed.", ode);
                }
                else if (e is IOException ioe)
                {
                    UnCalamityModMusic.Instance.Logger.Error("Failed to parse VCMM packet: An unknown I/O error occurred.", ioe);
                }
                else
                {
                    throw;
                }
            }
        }
    }
}
