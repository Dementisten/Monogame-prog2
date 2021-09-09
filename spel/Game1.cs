using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace spel
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D player;
        Vector2 playerPos = new Vector2(500, 500);

        public Game1()
        {
            
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            _graphics.PreferredBackBufferWidth = 1920;
            _graphics.PreferredBackBufferHeight = 1080;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            player = Content.Load<Texture2D>("spelare");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            if (Keyboard.GetState().IsKeyDown(Keys.Right) && playerPos.X < 1980 - player.Width)
            {
                playerPos.X = playerPos.X + 5;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Left) && playerPos.X > 0)
            {
                playerPos.X = playerPos.X - 5;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Up) && playerPos.Y > 0)
            {
                playerPos.Y = playerPos.Y - 5;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Down) && playerPos.Y < 1080 - player.Height)
            {
                playerPos.Y = playerPos.Y + 5;
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(player, playerPos, Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
