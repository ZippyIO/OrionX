// OrionX Disclaimer
// ------------------------------------------------------
// OrionX is licenced under GNU GPL 3.0.
// Please read the licence file for more information.
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

namespace OrionX
{
    public class OrionX
    {
        #region Fields Region

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

        #region Methods Region

        /// <summary>
        /// Initalizes this instance.
        /// </summary>
        public void Initalize()
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

            Math.Initalize();
        }

        #endregion
    }
}
