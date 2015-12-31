// OrionX Disclaimer
// ------------------------------------------------------
// OrionX is licenced under GNU GPL 3.0.
// Please read the licence file for more information.
// ------------------------------------------------------
//  
// * User: ZippyBling
// * File: GamePadInput.cs
// * Date: 31/12/2015
// * Time: 6:29 PM

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace OrionX.Input.GamePad
{
    public class GamePadInput
    {
        public static GamePadState[] GamePadState;
        public static GamePadState[] LastGamePadState;

        public static bool ButtonReleased(Buttons button, PlayerIndex index)
        {
            return GamePadState[(int)index].IsButtonUp(button) &&
                LastGamePadState[(int)index].IsButtonDown(button);
        }

        public static bool ButtonPressed(Buttons button, PlayerIndex index)
        {
            return GamePadState[(int)index].IsButtonDown(button) &&
                   LastGamePadState[(int)index].IsButtonUp(button);
        }
    }
}