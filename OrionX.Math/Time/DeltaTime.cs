// OrionX Disclaimer
// ------------------------------------------------------
// OrionX is licensed under GNU GPL 3.0.
// Please read the license file for more information.
// ------------------------------------------------------
//  
// * User: ZippyBling
// * File: DeltaTime.cs
// * Date: 31/12/2015
// * Time: 7:45 PM

using Microsoft.Xna.Framework;

namespace OrionX.Math.Time
{
    /// <summary>
    /// Class DeltaTime.
    /// </summary>
    public class DeltaTime
    {
        /// <summary>
        /// Syncs frame based operations with time to avoid speed differences with frame rates
        /// </summary>
        /// <param name="gameTime">The game time.</param>
        /// <returns>System.Single.</returns>
        public float Delta(GameTime gameTime)
        {
            var delta = (float)gameTime.ElapsedGameTime.TotalSeconds;
            return delta;
            // time = Engine.Math.Time.Delta(gameTime);
        }
    }
}