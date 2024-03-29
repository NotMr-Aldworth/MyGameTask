﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MyGameTask
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D labTexture;
        Rectangle labTextureRect;
        Texture2D bigBrainTexture;
        Texture2D brainTexture;
        Rectangle brainTextureRect;
        Rectangle bigBrainTextureRect;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            this.Window.Title = "Jacksons Brain when he misses a day of class VS a regular brain";
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            labTexture = Content.Load<Texture2D>("labrat");
            labTextureRect = new Rectangle(0, 0, 800, 500);

            brainTexture = Content.Load<Texture2D>("brain");
            brainTextureRect = new Rectangle(400, 150, 200, 200);

            bigBrainTexture = Content.Load<Texture2D>("brain");
            bigBrainTextureRect = new Rectangle(200, 200, 100, 100);
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();

            _spriteBatch.Draw(labTexture, labTextureRect, Color.White);
            _spriteBatch.Draw(brainTexture, brainTextureRect, Color.White);
            _spriteBatch.Draw(bigBrainTexture, bigBrainTextureRect, Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
