// OrionX.Game Disclaimer
// ------------------------------------------------------
// OrionX.Game is licensed under GNU GPL 3.0.
// Please read the licence file for more information.
// ------------------------------------------------------
// 
// * User: ZippyBling
// * File: BaseUI.cs
// * Date: 28/03/2016
// * Time: 6:54 PM

using System.Text.RegularExpressions;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace OrionX.Game.UI
{
    //TODO: Documentation
    /// <summary>
    /// Class BaseUI.
    /// </summary>
    public abstract class BaseUI
    {
        #region Fields

        /// <summary>
        /// The UI Components Texture
        /// </summary>
        private Texture2D texture;

        /// <summary>
        /// The UI Components Position
        /// </summary>
        private Vector2 position;

        /// <summary>
        /// The UI Components Width
        /// </summary>
        private float width;

        /// <summary>
        /// The UI Components Height
        /// </summary>
        private float height;

        /// <summary>
        /// The texture width
        /// </summary>
        private float textureWidth;

        /// <summary>
        /// The texture height
        /// </summary>
        private float textureHeight;

        #endregion

        #region Variables & Properties

        /// <summary>
        /// Gets or sets the UI Texture.
        /// </summary>
        /// <value>The texture.</value>
        public Texture2D Texture
        {
            get { return texture; }
            set { texture = value; }
        }

        /// <summary>
        /// Gets or sets the UI Position.
        /// </summary>
        /// <value>The position.</value>
        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }

        /// <summary>
        /// Gets or sets the UI Width.
        /// </summary>
        /// <value>The width.</value>
        public float Width
        {
            get { return width; }
            set { width = value; }
        }

        /// <summary>
        /// Gets or sets the UI Height.
        /// </summary>
        /// <value>The height.</value>
        public float Height
        {
            get { return height; }
            set { height = value; }
        }

        /// <summary>
        /// Gets or sets the width of the texture.
        /// </summary>
        /// <value>The width of the texture.</value>
        public float TextureWidth
        {
            get { return textureWidth; }
            set { textureWidth = value; }
        }


        /// <summary>
        /// Gets or sets the height of the texture.
        /// </summary>
        /// <value>The height of the texture.</value>
        public float TextureHeight
        {
            get { return textureHeight; }
            set { textureHeight = value; }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseUI" /> class.
        /// </summary>
        public BaseUI()
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
        /// <param name="Content">The content.</param>
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
        /// <param name="sb">The sb.</param>
        public void Draw(SpriteBatch sb)
        {

        }

        #endregion

        #region Methods



        #endregion
    }
}