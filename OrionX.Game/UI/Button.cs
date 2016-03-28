// OrionX.Game Disclaimer
// ------------------------------------------------------
// OrionX.Game is licensed under GNU GPL 3.0.
// Please read the licence file for more information.
// ------------------------------------------------------
// 
// * User: ZippyBling
// * File: Button.cs
// * Date: 28/03/2016
// * Time: 6:53 PM

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace OrionX.Game.UI
{
    /// <summary>
    /// List of Button States
    /// </summary>
    public enum ButtonState
    {
        active,
        normal,
        disabled
    }

    /// <summary>
    /// Button UI Class. This class cannot be inherited.
    /// </summary>
    public sealed class Button : BaseUI
    {
        #region Fields

        /// <summary>
        /// The active Button texture
        /// </summary>
        private Texture2D activeTexture;

        /// <summary>
        /// The disabled Button texture
        /// </summary>
        private Texture2D disabledTexture;

        /// <summary>
        /// The Buttons current state
        /// </summary>
        private ButtonState state;

        /// <summary>
        /// Checks if the button is currently active
        /// </summary>
        private bool isActive;

        #endregion

        #region Variables & Properties

        /// <summary>
        /// Gets or sets the active texture.
        /// </summary>
        /// <value>The active texture.</value>
        public Texture2D ActiveTexture
        {
            get { return activeTexture; }
            set { activeTexture = value; }
        }



        /// <summary>
        /// Gets or sets the disabled texture.
        /// </summary>
        /// <value>The disabled texture.</value>
        public Texture2D DisabledTexture
        {
            get { return disabledTexture; }
            set { disabledTexture = value; }
        }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>The state.</value>
        public ButtonState State
        {
            get { return state; }
            set { state = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is active.
        /// </summary>
        /// <value><c>true</c> if this instance is active; otherwise, <c>false</c>.</value>
        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Determines whether this instance is pressed.
        /// </summary>
        public void IsPressed()
        {
            State = ButtonState.active;
            IsActive = true;
        }

        /// <summary>
        /// Determines whether this instance is normal.
        /// </summary>
        public void IsNormal()
        {
            state = ButtonState.normal;
            IsActive = false;
        }

        #endregion
    }
}