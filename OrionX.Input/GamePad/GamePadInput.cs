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
        #region Fields Region

        /// <summary>
        /// The current GamePad State
        /// </summary>
        public static GamePadState[] GamePadState;

        /// <summary>
        /// The last game pad State
        /// </summary>
        public static GamePadState[] LastGamePadState;

        #endregion

        #region Constructor Region

        public GamePadInput()
        {

        }

        #endregion

        #region Methods Region

        /// <summary>
        /// Checks to see if the Button specified has been released.
        /// </summary>
        /// <param name="button">The button.</param>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        public static bool ButtonReleased(Buttons button, PlayerIndex index)
        {
            return GamePadState[(int)index].IsButtonUp(button) &&
                LastGamePadState[(int)index].IsButtonDown(button);
        }

        /// <summary>
        /// Checks to see if the Button specified has been pressed.
        /// </summary>
        /// <param name="button">The button.</param>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        public static bool ButtonPressed(Buttons button, PlayerIndex index)
        {
            return GamePadState[(int)index].IsButtonDown(button) &&
                   LastGamePadState[(int)index].IsButtonUp(button);
        }

        #endregion
    }
}