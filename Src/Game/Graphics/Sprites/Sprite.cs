﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game.Graphics.Sprites
{
    public class Sprite : ISprite
    {
        private readonly Texture2D _spriteTexture;

        public Sprite(Texture2D texture)
        {
            _spriteTexture = texture;
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 location,Rectangle part, float size)
        {
            spriteBatch.Draw(_spriteTexture, location, part, Color.White, 0f, Vector2.Zero, size, SpriteEffects.None, 0f);
        }
    }
}
