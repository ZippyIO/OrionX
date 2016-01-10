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
    /// <summary>
    /// Class Input.
    /// </summary>
    public class Input
    {
        /// <summary>
        /// The keyboard
        /// </summary>
        public KeyboardInput Keyboard;
        /// <summary>
        /// The game pad
        /// </summary>
        public GamePadInput GamePad;
        /// <summary>
        /// The schema
        /// </summary>
        public KeyboardSchema Schema;

        /// <summary>
        /// Initalizes this instance.
        /// </summary>
        public void Initalize()
        {
            Keyboard = new KeyboardInput();
            GamePad = new GamePadInput();
            Schema = new KeyboardSchema();
        }

        /// <summary>
        /// Loads the specified content.
        /// </summary>
        /// <param name="Content">The content.</param>
        public void Load(ContentManager Content)
        {
            
        }


        /// <summary>
        /// Updates the specified game time.
        /// </summary>
        /// <param name="gameTime">The game time.</param>
        public void Update(GameTime gameTime)
        {
            
        }

        /// <summary>
        /// Draws the specified sb.
        /// </summary>
        /// <param name="sb">The sb.</param>
        public void Draw(SpriteBatch sb)
        {
            
        }
    }
}
