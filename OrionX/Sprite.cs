// OrionX Disclaimer
// ------------------------------------------------------
// OrionX is licenced under GNU GPL 3.0.
// Please read the licence file for more information.
// ------------------------------------------------------
// 
// * User: ZippyBling
// * File: Sprite.cs
// * Date: 28/12/2015
// * Time: 3:53 PM

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace OrionX
{
    /// <summary>
    /// Class Sprite.
    /// </summary>
    public abstract class Sprite : Movement
    {
        /// <summary>
        /// Gets or sets the texture.
        /// </summary>
        /// <value>The texture.</value>
        public Texture2D Texture { get; set; }

        /// <summary>
        /// Gets or sets the sprite location.
        /// </summary>
        /// <value>The sprite location.</value>
        public Rectangle SpriteLocation { get; set; }

        /// <summary>
        /// Gets or sets the content location.
        /// </summary>
        /// <value>The content location.</value>
        public string ContentLocation { get; set; }
    }
}