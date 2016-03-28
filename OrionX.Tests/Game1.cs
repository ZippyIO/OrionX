using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using OrionX.Audio.Sound;
using OrionX.Game.Entity;
using OrionX.Game.UI;
using OrionX.Input.GamePad;
using OrionX.Input.Keyboard;

namespace OrionX.Tests
{
    #region Game Class
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        #region Fields

        /// <summary>
        /// The graphics  
        /// </summary>
        GraphicsDeviceManager graphics;
        /// <summary>
        /// The sprite batch
        /// </summary>
        SpriteBatch spriteBatch;
        /// <summary>
        /// The engine
        /// </summary>
        OrionX Engine;

        #endregion

        #region Variables & Properties

        /// <summary>
        /// The time
        /// </summary>
        public float time;
        /// <summary>
        /// The test
        /// </summary>
        public int test = 1;

        #endregion

        #region AllocConsole

        /// <summary>
        /// Allocs the console.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        [DllImport("kernel32")]

        static extern bool AllocConsole();

        #endregion

        BaseEntity TestEntity;

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="Game1"/> class.
        /// </summary>
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        //    AllocConsole();
            IsMouseVisible = true;
        }

        #endregion

        #region XNA Methods

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            Engine = new OrionX();
            Engine.Initialize();

            TestEntity = new BaseEntity();
            
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            Engine.Load(Content);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            Engine.Unload();
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            Engine.Update(gameTime);

            if (KeyboardInput.KeyDown(Keys.Space))
            {
                TestEntity.Position += new Vector2(5, 5);

                var test = TestEntity.Position.X/2;

                Debug.WriteLine(test.ToString());
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            Engine.Draw(spriteBatch);

            base.Draw(gameTime);
        }

        #endregion
    }
    #endregion

    #region Program Class
    /// <summary>
    /// The Program Class
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var game = new Game1())
                game.Run();
        }
    }
    #endregion
}