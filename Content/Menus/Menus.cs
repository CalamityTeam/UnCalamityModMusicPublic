using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using UnCalamityModMusic.Common;

namespace UnCalamityModMusic.Content.Menus
{
	public class ResurrectionMenu : ModMenu
	{
		public override int Music => MusicPathing.GetMusicSlot("HardmodeInterlude");

		public override string DisplayName => Language.GetTextValue("Mods.UnCalamityModMusic.Menus.ResurrectionMenu");

		public class Ember
		{
			public int Time;

			public int LifeTime;

			public int IdentityIndex;

			public float Scale;

			public float Depth;

			public Color DrawColor;

			public Vector2 Velocity;

			public Vector2 Center;

			public Ember(int lifetime, int identity, float depth, Color color, Vector2 startingPosition, Vector2 startingVelocity)
			{
				LifeTime = lifetime;
				IdentityIndex = identity;
				Depth = depth;
				DrawColor = color;
				Center = startingPosition;
				Velocity = startingVelocity;
			}
		}

		public static List<Ember> Embers { get; internal set; } = new List<Ember>();

		public override Asset<Texture2D> Logo => ModContent.Request<Texture2D>("UnCalamityModMusic/Content/Menus/Logo", AssetRequestMode.AsyncLoad);

		public override Asset<Texture2D> SunTexture => ModContent.Request<Texture2D>("UnCalamityModMusic/Content/Menus/Blank", AssetRequestMode.AsyncLoad);

		public override Asset<Texture2D> MoonTexture => ModContent.Request<Texture2D>("UnCalamityModMusic/Content/Menus/Blank", AssetRequestMode.AsyncLoad);

		public override ModSurfaceBackgroundStyle MenuBackgroundStyle => ModContent.GetInstance<BlankBackground>();

		public override bool PreDrawLogo(SpriteBatch spriteBatch, ref Vector2 logoDrawCenter, ref float logoRotation, ref float logoScale, ref Color drawColor)
		{
			Texture2D texture = ModContent.Request<Texture2D>("UnCalamityModMusic/Content/Menus/ResurrectionBackground", AssetRequestMode.AsyncLoad).Value;
			Vector2 drawOffset = Vector2.Zero;

			float scaleX = (float)Main.screenWidth / (float)texture.Width;
			float scaleY = (float)Main.screenHeight / (float)texture.Height;
			float scale = scaleX;
			if (scaleX != scaleY)
			{
				if (scaleY > scaleX)
				{
					scale = scaleY;
					drawOffset.X -= (texture.Width * scale - Main.screenWidth) * 0.5f;
				}
				else
				{
					drawOffset.Y -= (texture.Height * scale - Main.screenHeight) * 0.5f;
				}
			}

			spriteBatch.Draw
			(
				texture, 
				drawOffset, 
				null, 
				Color.White, 
				0f, 
				Vector2.Zero, 
				scale, 
				0, 
				0f
			);

			Vector2 startingPosition = default(Vector2);
			for (int k = 0; k < 5; k++)
			{
				if (Main.rand.NextBool(4))
				{
					int lifetime = Main.rand.Next(200, 300);
					float depth = Main.rand.NextFloat(1.8f, 5f);
					startingPosition = new(Main.screenWidth * Main.rand.NextFloat(-0.1f, 1.1f), Main.screenHeight * 1.05f);
					Vector2 startingVelocity = -Vector2.UnitY.RotatedBy(Main.rand.NextFloat(-0.9f, 0.9f)) * 4f;
					Color EmberColor = selectEmberColor();
					Embers.Add(new Ember(lifetime, Embers.Count, depth, EmberColor, startingPosition, startingVelocity));
				}
			}
			for (int j = 0; j < Embers.Count; j++)
			{
				Embers[j].Scale = Utils.GetLerpValue(Embers[j].LifeTime, Embers[j].LifeTime / 3, Embers[j].Time, clamped: true);
				Embers[j].Scale *= MathHelper.Lerp(0.6f, 0.9f, Embers[j].IdentityIndex % 6f / 6f);
				if (Embers[j].IdentityIndex % 13 == 12)
				{
					Embers[j].Scale *= 2f;
				}
				float flySpeed = MathHelper.Lerp(3.2f, 14f, Embers[j].IdentityIndex % 21f / 21f);
				Vector2 idealVelocity = -Vector2.UnitY.RotatedBy(MathHelper.Lerp(-0.44f, 0.44f, (float)Math.Sin((double)(Embers[j].Time / 16f + Embers[j].IdentityIndex)) * 0.5f + 0.5f));
				idealVelocity = (idealVelocity + Vector2.UnitX).SafeNormalize(Vector2.UnitY) * flySpeed;
				float movementInterpolant = MathHelper.Lerp(0.01f, 0.08f, Utils.GetLerpValue(45f, 145f, Embers[j].Time, clamped: true));
				Embers[j].Velocity = Vector2.Lerp(Embers[j].Velocity, idealVelocity, movementInterpolant);
				Embers[j].Time++;
				Ember Ember = Embers[j];
				Ember.Center += Embers[j].Velocity;
			}

			Embers.RemoveAll((Ember Ember) => Ember.Time >= Ember.LifeTime);
			Texture2D EmberTexture = ModContent.Request<Texture2D>("UnCalamityModMusic/Content/Menus/Particle", AssetRequestMode.AsyncLoad).Value;
			for (int i = 0; i < Embers.Count; i++)
			{
				Vector2 drawPosition = Embers[i].Center;
				spriteBatch.Draw
				(
					EmberTexture, 
					drawPosition, 
					null, 
					Embers[i].DrawColor, 
					0f, 
					EmberTexture.Size() * 0.5f, 
					Embers[i].Scale, 
					0, 
					0f
				);
			}

			Main.time = 27000;
			Main.dayTime = true;
			drawColor = Color.White;
			Vector2 drawPos = default(Vector2);
			drawPos = new(Main.screenWidth / 2f, 100f);
			spriteBatch.End();
			spriteBatch.Begin(0, BlendState.NonPremultiplied, SamplerState.LinearClamp, DepthStencilState.None, Main.Rasterizer, null, Main.UIScaleMatrix);
			spriteBatch.Draw(Logo.Value, drawPos, null, drawColor, logoRotation, Logo.Value.Size() * 0.5f, logoScale, 0, 0f);
			spriteBatch.End();
			spriteBatch.Begin(0, BlendState.AlphaBlend, SamplerState.LinearClamp, DepthStencilState.None, Main.Rasterizer, null, Main.UIScaleMatrix);
			return false;

			static Color selectEmberColor()
			{
				if (Main.rand.NextBool(3))
				{
					return Color.Lerp(Color.DarkBlue, Color.LightCyan, Main.rand.NextFloat());
				}
				return Color.Lerp(Color.Turquoise, Color.LimeGreen, Main.rand.NextFloat(0.9f));
			}
		}
	}

	public class MemoryMenu : ModMenu
	{
		public override int Music => MusicPathing.GetMusicSlot("FalseEpilogue");

		public override string DisplayName => Language.GetTextValue("Mods.UnCalamityModMusic.Menus.MemoryMenu");

		public class Ember
		{
			public int Time;

			public int LifeTime;

			public int IdentityIndex;

			public float Scale;

			public float Depth;

			public Color DrawColor;

			public Vector2 Velocity;

			public Vector2 Center;

			public Ember(int lifetime, int identity, float depth, Color color, Vector2 startingPosition, Vector2 startingVelocity)
			{
				LifeTime = lifetime;
				IdentityIndex = identity;
				Depth = depth;
				DrawColor = color;
				Center = startingPosition;
				Velocity = startingVelocity;
			}
		}

		public static List<Ember> Embers { get; internal set; } = new List<Ember>();

		public override Asset<Texture2D> Logo => ModContent.Request<Texture2D>("UnCalamityModMusic/Content/Menus/Logo", AssetRequestMode.AsyncLoad);

		public override Asset<Texture2D> SunTexture => ModContent.Request<Texture2D>("UnCalamityModMusic/Content/Menus/Blank", AssetRequestMode.AsyncLoad);

		public override Asset<Texture2D> MoonTexture => ModContent.Request<Texture2D>("UnCalamityModMusic/Content/Menus/Blank", AssetRequestMode.AsyncLoad);

		public override ModSurfaceBackgroundStyle MenuBackgroundStyle => ModContent.GetInstance<BlankBackground>();

		public override bool PreDrawLogo(SpriteBatch spriteBatch, ref Vector2 logoDrawCenter, ref float logoRotation, ref float logoScale, ref Color drawColor)
		{
			Texture2D texture = ModContent.Request<Texture2D>("UnCalamityModMusic/Content/Menus/MemoryBackground", AssetRequestMode.AsyncLoad).Value;
			Vector2 drawOffset = Vector2.Zero;

			float scaleX = (float)Main.screenWidth / (float)texture.Width;
			float scaleY = (float)Main.screenHeight / (float)texture.Height;
			float scale = scaleX;
			if (scaleX != scaleY)
			{
				if (scaleY > scaleX)
				{
					scale = scaleY;
					drawOffset.X -= (texture.Width * scale - Main.screenWidth) * 0.5f;
				}
				else
				{
					drawOffset.Y -= (texture.Height * scale - Main.screenHeight) * 0.5f;
				}
			}

			spriteBatch.Draw
			(
				texture,
				drawOffset,
				null,
				Color.White,
				0f,
				Vector2.Zero,
				scale,
				0,
				0f
			);

			Vector2 startingPosition = default(Vector2);
			for (int k = 0; k < 5; k++)
			{
				if (Main.rand.NextBool(4))
				{
					int lifetime = Main.rand.Next(200, 300);
					float depth = Main.rand.NextFloat(1.8f, 5f);
					startingPosition = new(Main.screenWidth * Main.rand.NextFloat(-0.1f, 1.1f), Main.screenHeight * 1.05f);
					Vector2 startingVelocity = -Vector2.UnitY.RotatedBy(Main.rand.NextFloat(-0.9f, 0.9f)) * 4f;
					Color EmberColor = selectEmberColor();
					Embers.Add(new Ember(lifetime, Embers.Count, depth, EmberColor, startingPosition, startingVelocity));
				}
			}
			for (int j = 0; j < Embers.Count; j++)
			{
				Embers[j].Scale = Utils.GetLerpValue(Embers[j].LifeTime, Embers[j].LifeTime / 3, Embers[j].Time, clamped: true);
				Embers[j].Scale *= MathHelper.Lerp(0.6f, 0.9f, Embers[j].IdentityIndex % 6f / 6f);
				if (Embers[j].IdentityIndex % 13 == 12)
				{
					Embers[j].Scale *= 2f;
				}
				float flySpeed = MathHelper.Lerp(3.2f, 14f, Embers[j].IdentityIndex % 21f / 21f);
				Vector2 idealVelocity = -Vector2.UnitY.RotatedBy(MathHelper.Lerp(-0.44f, 0.44f, (float)Math.Sin((double)(Embers[j].Time / 16f + Embers[j].IdentityIndex)) * 0.5f + 0.5f));
				idealVelocity = (idealVelocity + Vector2.UnitX).SafeNormalize(Vector2.UnitY) * flySpeed;
				float movementInterpolant = MathHelper.Lerp(0.01f, 0.08f, Utils.GetLerpValue(45f, 145f, Embers[j].Time, clamped: true));
				Embers[j].Velocity = Vector2.Lerp(Embers[j].Velocity, idealVelocity, movementInterpolant);
				Embers[j].Time++;
				Ember Ember = Embers[j];
				Ember.Center += Embers[j].Velocity;
			}

			Embers.RemoveAll((Ember Ember) => Ember.Time >= Ember.LifeTime);
			Texture2D EmberTexture = ModContent.Request<Texture2D>("UnCalamityModMusic/Content/Menus/Particle", AssetRequestMode.AsyncLoad).Value;
			for (int i = 0; i < Embers.Count; i++)
			{
				Vector2 drawPosition = Embers[i].Center;
				spriteBatch.Draw
				(
					EmberTexture,
					drawPosition,
					null,
					Embers[i].DrawColor,
					0f,
					EmberTexture.Size() * 0.5f,
					Embers[i].Scale,
					0,
					0f
				);
			}

			Main.time = 27000;
			Main.dayTime = true;
			drawColor = Color.White;
			Vector2 drawPos = default(Vector2);
			drawPos = new(Main.screenWidth / 2f, 100f);
			spriteBatch.End();
			spriteBatch.Begin(0, BlendState.NonPremultiplied, SamplerState.LinearClamp, DepthStencilState.None, Main.Rasterizer, null, Main.UIScaleMatrix);
			spriteBatch.Draw(Logo.Value, drawPos, null, drawColor, logoRotation, Logo.Value.Size() * 0.5f, logoScale, 0, 0f);
			spriteBatch.End();
			spriteBatch.Begin(0, BlendState.AlphaBlend, SamplerState.LinearClamp, DepthStencilState.None, Main.Rasterizer, null, Main.UIScaleMatrix);
			return false;

			static Color selectEmberColor()
			{
				if (Main.rand.NextBool(3))
				{
					return Color.Lerp(Color.DarkRed, Color.LightGray, Main.rand.NextFloat());
				}
				return Color.Lerp(Color.MediumVioletRed, Color.Orange, Main.rand.NextFloat(0.9f));
			}
		}
	}

	internal class BlankBackground : ModSurfaceBackgroundStyle
	{
		public override void ModifyFarFades(float[] fades, float transitionSpeed)
		{
			for (int i = 0; i < fades.Length; i++)
			{
				if (i == Slot)
				{
					fades[i] += transitionSpeed;
					if (fades[i] > 1f)
					{
						fades[i] = 1f;
					}
				}
				else
				{
					fades[i] -= transitionSpeed;
					if (fades[i] < 0f)
					{
						fades[i] = 0f;
					}
				}
			}
		}

		public override int ChooseCloseTexture(ref float scale, ref double parallax, ref float a, ref float b)
		{
			return BackgroundTextureLoader.GetBackgroundSlot("UnCalamityModMusic/Content/Menus/Blank");
		}

		public override int ChooseFarTexture()
		{
			return BackgroundTextureLoader.GetBackgroundSlot("UnCalamityModMusic/Content/Menus/Blank");
		}

		public override int ChooseMiddleTexture()
		{
			return BackgroundTextureLoader.GetBackgroundSlot("UnCalamityModMusic/Content/Menus/Blank");
		}

		public override bool PreDrawCloseBackground(SpriteBatch spriteBatch)
		{
			return false;
		}
	}
}
