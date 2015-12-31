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
        public float Delta(GameTime gameTime)
        {
            var delta = (float)gameTime.ElapsedGameTime.TotalSeconds;
            return delta;
        }
    }
}