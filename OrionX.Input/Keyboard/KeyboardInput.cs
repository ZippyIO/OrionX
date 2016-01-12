// OrionX Disclaimer
// ------------------------------------------------------
// OrionX is licensed under GNU GPL 3.0.
// Please read the license file for more information.
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
    /// <summary>
    /// Class KeyboardInput.
    /// </summary>
    public class KeyboardInput
    {
        #region Fields Region

        /// <summary>
        /// The current Keyboard State
        /// </summary>
        public static KeyboardState State;

        /// <summary>
        /// The last Keyboard State
        /// </summary>
        public static KeyboardState LastState;

        #endregion

        #region Constructor Region

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyboardInput"/> class.
        /// </summary>
        public KeyboardInput()
        {

        }

        #endregion

        #region Methods Region

        /// <summary>
        /// Checks to see if the key specified has been released.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool KeyReleased(Keys key)
        {
            State = Microsoft.Xna.Framework.Input.Keyboard.GetState();
            return State.IsKeyUp(key) &&
               LastState.IsKeyDown(key);
        }

        /// <summary>
        /// Checks to see if the key specified has been pressed.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool KeyPressed(Keys key)
        {
            State = Microsoft.Xna.Framework.Input.Keyboard.GetState();
            return State.IsKeyDown(key) &&
                   LastState.IsKeyUp(key);
        }

        /// <summary>
        /// Checks to see if the key specified is down.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public static bool KeyDown(Keys key)
        {
            State = Microsoft.Xna.Framework.Input.Keyboard.GetState();
            return State.IsKeyDown(key);
        }

        #endregion
    }
}