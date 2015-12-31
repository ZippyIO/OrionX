// OrionX Disclaimer
// ------------------------------------------------------
// OrionX is licenced under GNU GPL 3.0.
// Please read the licence file for more information.
// ------------------------------------------------------
//  
// * User: ZippyBling
// * File: Schema.cs
// * Date: 31/12/2015
// * Time: 6:34 PM

using Microsoft.Xna.Framework.Input;
using OrionX.Input.Enumeration;

namespace OrionX.Input.Keyboard
{
    public class KeyboardSchema
    {
        public SchemaWASD WASD;
        public SchemaArrow Arrow;
        public SchemaList List;

        public void WASDSchema(Keys keyOne, Keys keyTwo, Keys keyThree, Keys keyFour)
        {
            keyOne = Keys.W;
            keyTwo = Keys.S;
            keyThree = Keys.A;
            keyFour = Keys.D;
        }

        public void ArrowSchema(Keys keyOne, Keys keyTwo, Keys keyThree, Keys keyFour)
        {
            keyOne = Keys.Up;
            keyTwo = Keys.Down;
            keyThree = Keys.Left;
            keyFour = Keys.Right;
        }

        public void Initalize()
        {

        }
    }
}