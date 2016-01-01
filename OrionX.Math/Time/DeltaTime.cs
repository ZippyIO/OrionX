// OrionX Disclaimer
// ------------------------------------------------------
// OrionX is licenced under GNU GPL 3.0.
// Please read the licence file for more information.
// ------------------------------------------------------
//  
// * User: ZippyBling
// * File: DeltaTime.cs
// * Date: 31/12/2015
// * Time: 7:45 PM

using Microsoft.Xna.Framework;

namespace OrionX.Math.Time
{
    public class DeltaTime
    {
        /// <summary>
        /// Syncs frame based operations with time to avoid speed differences with framerates
        /// </summary>
        /// <param name="gameTime">The game time.</param>
        /// <returns></returns>
        public float Delta(GameTime gameTime)
        {
            var delta = (float)gameTime.ElapsedGameTime.TotalSeconds;
            return delta;
        }
    }
}