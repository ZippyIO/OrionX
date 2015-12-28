// OrionX.Content Disclaimer
// ------------------------------------------------------
// OrionX.Content is licenced under GNU GPL 3.0.
// Please read the licence file for more information.
// ------------------------------------------------------
// 
// * User: ZippyBling
// * File: SpriteContent.cs
// * Date: 28/12/2015
// * Time: 5:27 PM
namespace OrionX.Content.Game
{
    public class SpriteContent
    {

        /// <summary>
        /// Contents the location.
        /// </summary>
        /// <param name="location">The location.</param>
        /// <param name="filename">The filename.</param>
        /// <returns></returns>
        public string ContentLocation(string location, string filename)
        {
            var content = location + filename;

            return content;
        }
    }
}