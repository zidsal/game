using Game.Entities;
using Game.Interface;
using Game.Interface.Screens;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game : Microsoft.Xna.Framework.Game
    {
        readonly GraphicsDeviceManager _graphics;
        SpriteBatch _spriteBatch;
        private ScreenManager _screenmanager;

        public Game()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            
        }

        protected override void Initialize()
        {
            CreateGameSettings();
            _screenmanager = ScreenManager.Instance(Content);

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
        }

        protected override void UnloadContent()
        {
            Content.Unload();
        }

        protected override void Update(GameTime gameTime)
        {
            _screenmanager.GetScreen().Update(gameTime);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            _screenmanager.GetScreen().Draw(_spriteBatch);
            _spriteBatch.End();

            base.Draw(gameTime);
        }

        private void CreateGameSettings()
        {
            _graphics.PreferredBackBufferWidth = (int)GameData.ScreenSize.X;
            _graphics.PreferredBackBufferHeight = (int)GameData.ScreenSize.Y;
            IsMouseVisible = true;
        }
    }
}