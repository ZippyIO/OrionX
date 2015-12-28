// OrionX Disclaimer
// ------------------------------------------------------
// OrionX is licenced under GNU GPL 3.0.
// Please read the licence file for more information.
// ------------------------------------------------------
// 
// * User: ZippyBling
// * File: Movement.cs
// * Date: 28/12/2015
// * Time: 3:51 PM

using Microsoft.Xna.Framework;

namespace OrionX
{
    public abstract class Movement
    {
        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        /// <value>
        /// The position.
        /// </value>
        public Vector2 Position { get; set; }

        /// <summary>
        /// Gets or sets the previous position.
        /// </summary>
        /// <value>
        /// The previous position.
        /// </value>
        public Vector2 PrevPosition
        {
            get { return Position; }
            set { value = Position; }
        }

        /// <summary>
        /// Gets or sets the velocity.
        /// </summary>
        /// <value>
        /// The velocity.
        /// </value>
        public float Velocity { get; set; }

        /// <summary>
        /// Gets or sets the rotation.
        /// </summary>
        /// <value>
        /// The rotation.
        /// </value>
        public float Rotation { get; set; }
    }
}