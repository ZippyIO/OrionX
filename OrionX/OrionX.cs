// OrionX Disclaimer
// ------------------------------------------------------
// OrionX is licensed under GNU GPL 3.0.
// Please read the license file for more information.
// ------------------------------------------------------
// 
// * User: ZippyBling
// * File: OrionX.cs
// * Date: 28/12/2015
// * Time: 3:04 PM

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace OrionX
{
    /// <summary>
    /// Class OrionX.
    /// </summary>
    public class OrionX
    {
        #region Fields

        /// <summary>
        /// API Class
        /// </summary>
        public API.API API;

        /// <summary>
        /// Audio Class
        /// </summary>
        public Audio.Audio Audio;

        /// <summary>
        /// Content Class
        /// </summary>
        public Content.Content Content;

        /// <summary>
        /// Data Class
        /// </summary>
        public Data.Data Data;

        /// <summary>
        /// Game Class
        /// </summary>
        public Game.Game Game;

        /// <summary>
        /// Input Class
        /// </summary>
        public Input.Input Input;

        /// <summary>
        /// Library Class
        /// </summary>
        public Library.Library Library;

        /// <summary>
        /// Maths Class
        /// </summary>
        public Math.Math Math;

        /// <summary>
        /// Network Class
        /// </summary>
        public Network.Network Network;

        /// <summary>
        /// Physics Class
        /// </summary>
        public Physics.Physics Physics;

        #endregion

        #region Variables & Properties



        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="OrionX"/> class.
        /// </summary>
        public OrionX()
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
            API = new API.API();
            Audio = new Audio.Audio();
            Content = new Content.Content();
            Data = new Data.Data();
            Game = new Game.Game();
            Input = new Input.Input();
            Library = new Library.Library();
            Math = new Math.Math();
            Network = new Network.Network();
            Physics = new Physics.Physics();

            API.Initialize();
            Audio.Initialize();
            Content.Initialize();
            Data.Initialize();
            Game.Initialize();
            Input.Initialize();
            Library.Initialize();
            Math.Initialize();
            Network.Initialize();
            Physics.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        public void Load(ContentManager Content)
        {
            API.Load(Content);
            Audio.Load(Content);
            this.Content.Load(Content);
            Data.Load(Content);
            Game.Load(Content);
            Input.Load(Content);
            Library.Load(Content);
            Math.Load(Content);
            Network.Load(Content);
            Physics.Load(Content);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        public void Unload()
        {
            API.Unload();
            Audio.Unload();
            Content.Unload();
            Data.Unload();
            Game.Unload();
            Input.Unload();
            Library.Unload();
            Math.Unload();
            Network.Unload();
            Physics.Unload();
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public void Update(GameTime gameTime)
        {
            API.Update(gameTime);
            Audio.Update(gameTime);
            Content.Update(gameTime);
            Data.Update(gameTime);
            Game.Update(gameTime);
            Input.Update(gameTime);
            Library.Update(gameTime);
            Math.Update(gameTime);
            Network.Update(gameTime);
            Physics.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        public void Draw(SpriteBatch sb)
        {
            API.Draw(sb);
            Audio.Draw(sb);
            Content.Draw(sb);
            Data.Draw(sb);
            Game.Draw(sb);
            Input.Draw(sb);
            Library.Draw(sb);
            Math.Draw(sb);
            Network.Draw(sb);
            Physics.Draw(sb);
        }

        #endregion

        #region Methods



        #endregion
    }
}
