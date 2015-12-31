// OrionX Disclaimer
// ------------------------------------------------------
// OrionX is licenced under GNU GPL 3.0.
// Please read the licence file for more information.
// ------------------------------------------------------
//  
// * User: ZippyBling
// * File: KeyboardInput.cs
// * Date: 31/12/2015
// * Time: 6:03 PM

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace OrionX.Input.Keyboard
{
    public class KeyboardInput
    {
        public static KeyboardState State;
        public static KeyboardState LastState;


        public static bool KeyReleased(Keys key)
        {
            State = Microsoft.Xna.Framework.Input.Keyboard.GetState();
            return State.IsKeyUp(key) &&
               LastState.IsKeyDown(key);
        }

        public static bool KeyPressed(Keys key)
        {
            State = Microsoft.Xna.Framework.Input.Keyboard.GetState();
            return State.IsKeyDown(key) &&
                   LastState.IsKeyUp(key);
        }

        public static bool KeyDown(Keys key)
        {
            State = Microsoft.Xna.Framework.Input.Keyboard.GetState();
            return State.IsKeyDown(key);
        }
    }
}