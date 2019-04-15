using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using mountains_of_yendor.XLib;
//using mountains_of_yendor.Lib;
using mountains_of_yendor.TileEngine;
using mountains_of_yendor.GameScreens;

namespace mountains_of_yendor
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class GameRoot : Game
    {
        GraphicsDeviceManager graphics;
        public SpriteBatch SpriteBatch;


        const int screenWidth = 1024;
        const int screenHeight = 768;

        public readonly Rectangle ScreenRectangle;

        GameStateManager stateManager;

        public TitleScreen TitleScreen;
        public StartMenuScreen StartMenuScreen;

        Engine engine = new Engine(24, 24);
        Tileset tileset;
        TileMap map;



        public GameRoot()
        {
            graphics = new GraphicsDeviceManager(this);

            graphics.PreferredBackBufferWidth = screenWidth;
            graphics.PreferredBackBufferHeight = screenHeight;


            ScreenRectangle = new Rectangle(
                0,
                0,
                screenWidth,
                screenHeight);

            Content.RootDirectory = "Content";

            Components.Add(new InputHandler(this));

            stateManager = new GameStateManager(this);
            Components.Add(stateManager);

            TitleScreen = new TitleScreen(this, stateManager);
            StartMenuScreen = new StartMenuScreen(this, stateManager);

            stateManager.ChangeState(TitleScreen);
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            SpriteBatch = new SpriteBatch(GraphicsDevice);

            Texture2D tilesetTexture = Content.Load<Texture2D>("level");
            tileset = new Tileset(tilesetTexture, 27, 27, 24, 24);

            MapLayer layer = new MapLayer(5, 5);

            int[,] level = { { 1, 4, 2, 4, 5 },{5,3,56,8,3},{2,7,35,2,24 },{ 72,72,72,72,73},{8,88,2,16,6 } };


            for (int y = 0; y < layer.Height; y++)
            {
                for(int x = 0; x < layer.Width; x++)
                {
                    Tile tile = new Tile(level[x,y], 0);
                    layer.SetTile(x, y, tile);
                }
            }

            map = new TileMap(tileset, layer);

            base.LoadContent();

        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            SpriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend, SamplerState.PointClamp, null, null, null, Matrix.Identity);

            map.Draw(SpriteBatch);

            base.Draw(gameTime);

            SpriteBatch.End();
        }
    }
}
