// OrionX Disclaimer
// ------------------------------------------------------
// OrionX is licenced under GNU GPL 3.0.
// Please read the licence file for more information.
// ------------------------------------------------------
// 
// * User: ZippyBling
// * File: Input.cs
// * Date: 28/12/2015
// * Time: 4:04 PM

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using OrionX.Input.GamePad;
using OrionX.Input.Keyboard;

namespace OrionX.Input
{
    public class Input
    {
        public KeyboardInput Keyboard;
        public GamePadInput GamePad;
        public KeyboardSchema Schema;

        public void Initalize()
        {
            Keyboard = new KeyboardInput();
            GamePad = new GamePadInput();
            Schema = new KeyboardSchema();
        }

        public void Load(ContentManager Content)
        {
            
        }


        public void Update(GameTime gameTime)
        {
            
        }

        public void Draw(SpriteBatch sb)
        {
            
        }
    }
}
