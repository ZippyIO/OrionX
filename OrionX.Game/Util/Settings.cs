// OrionX.Game Disclaimer
// ------------------------------------------------------
// OrionX.Game is licensed under GNU GPL 3.0.
// Please read the license file for more information.
// ------------------------------------------------------
// 
// * User: ZippyBling
// * File: Setting.cs
// * Date: 01/01/2016
// * Time: 4:34 PM

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace OrionX.Game.Util
{
    /// <summary>
    /// Class Settings.
    /// </summary>
    public class Settings
    {
        #region Fields



        #endregion

        #region Variables & Properties

        #region Audio Settings

        #region Master Settings

        /// <summary>
        /// The maximum audio level
        /// </summary>
        public float MaxAudioLevel = 100;

        /// <summary>
        /// The minimum audio level
        /// </summary>
        public float MinAudioLevel = 0;

        /// <summary>
        /// The audio level
        /// </summary>
        public float AudioLevel = 100;

        #endregion

        #region Music Settings

        /// <summary>
        /// The maximum music level
        /// </summary>
        public float MaxMusicLevel = 100;

        /// <summary>
        /// The minimum music level
        /// </summary>
        public float MinMusicLevel = 0;

        /// <summary>
        /// The music level
        /// </summary>
        public float MusicLevel = 100;

        #endregion

        #region Gameplay Settings

        /// <summary>
        /// The maximum game audio level
        /// </summary>
        public float MaxGameAudioLevel = 100;

        /// <summary>
        /// The minimum game audio level
        /// </summary>
        public float MinGameAudioLevel = 0;

        /// <summary>
        /// The game audio level
        /// </summary>
        public float GameAudioLevel = 100;

        #endregion

        #endregion

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="Settings"/> class.
        /// </summary>
        public Settings()
        {

        }

        #endregion

        #region XNA Methods

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        public void Initialize()
        {

        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        public void Load(ContentManager Content)
        {

        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        public void Unload()
        {

        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public void Update(GameTime gameTime)
        {

        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        public void Draw(SpriteBatch sb)
        {

        }

        #endregion

        #region Methods



        #endregion
    }
}