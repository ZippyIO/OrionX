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
        public API.API API;
        public Audio.Audio Audio;
        public Content.Content Content;
        public Data.Data Data;
        public Game.Game Game;
        public Input.Input Input;
        public Library.Library Library;
        public Math.Math Math;
        public Network.Network Network;
        public Physics.Physics Physics;

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
    }
}
