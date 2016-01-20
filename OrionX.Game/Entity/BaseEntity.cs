// OrionX Disclaimer
// ------------------------------------------------------
// OrionX is licensed under GNU GPL 3.0.
// Please read the license file for more information.
// ------------------------------------------------------
//  
// * User: ZippyBling
// * File: BaseEntity.cs
// * Date: 07/01/2016
// * Time: 1:57 PM

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using OrionX.Game.Entity.Enumeration;

namespace OrionX.Game.Entity
{
    /// <summary>
    /// Class BaseEntity.
    /// </summary>
    public sealed class BaseEntity
    {
        #region Fields

        /// <summary>
        /// Gets or sets the Entity Type.
        /// </summary>
        /// <value>The type.</value>
        public EntityType Type { get; set; }
        /// <summary>
        /// Gets or sets the current Moving direction.
        /// </summary>
        /// <value>The movement.</value>
        public MoveType Movement { get; set; }
        /// <summary>
        /// Gets or sets the current Facing direction.
        /// </summary>
        /// <value>The facing.</value>
        public Facing Facing { get; set; }

        #endregion

        #region Variables & Properties

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>The current position.</value>
        public Vector2 Position { get; set; }
        /// <summary>
        /// Gets or sets the previous position.
        /// </summary>
        /// <value>The previous position.</value>
        public Vector2 PrevPosition { get; set; }
        /// <summary>
        /// Gets or sets the texture.
        /// </summary>
        /// <value>The texture.</value>
        public Texture2D Texture { get; set; }
        /// <summary>
        /// Gets or sets the width of the Texture.
        /// </summary>
        /// <value>The width.</value>
        public float Width { get; set; }
        /// <summary>
        /// Gets or sets the height of the Texture.
        /// </summary>
        /// <value>The height.</value>
        public float Height { get; set; }
        /// <summary>
        /// Gets or sets the scale of the Texture.
        /// </summary>
        /// <value>The scale.</value>
        public float Scale { get; set; }
        /// <summary>
        /// Gets or sets the name of the content file.
        /// </summary>
        /// <value>The name of the content.</value>
        public string ContentName { get; set; }
        /// <summary>
        /// Gets or sets the name of the Entity.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseEntity" /> class.
        /// </summary>
        public BaseEntity()
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