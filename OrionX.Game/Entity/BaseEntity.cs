﻿// OrionX Disclaimer
// ------------------------------------------------------
// OrionX is licensed under GNU GPL 3.0.
// Please read the license file for more information.
// ------------------------------------------------------
//  
// * User: ZippyBling
// * File: BaseEntity.cs
// * Date: 07/01/2016
// * Time: 1:57 PM

using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace OrionX.Game.Entity
{
    /// <summary>
    /// Class BaseEntity.
    /// </summary>
    public abstract class BaseEntity
    {
        #region Fields



        #endregion

        #region Variables & Properties



        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseEntity"/> class.
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