// OrionX.Game Disclaimer
// ------------------------------------------------------
// OrionX.Game is licensed under GNU GPL 3.0.
// Please read the licence file for more information.
// ------------------------------------------------------
// 
// * User: ZippyBling
// * File: Input.cs
// * Date: 28/03/2016
// * Time: 7:09 PM

using Microsoft.Xna.Framework.Graphics;

namespace OrionX.Game.UI
{
    /// <summary>
    /// List of Input States
    /// </summary>
    public enum InputState
    {
        active,
        normal,
        disabled
    }

    public sealed class Input : BaseUI
    {
        #region Fields

        /// <summary>
        /// The active Input texture
        /// </summary>
        private Texture2D activeTexture;

        /// <summary>
        /// The disabled Input texture
        /// </summary>
        private Texture2D disabledTexture;

        /// <summary>
        /// The Inputs current state
        /// </summary>
        private InputState state;

        /// <summary>
        /// Checks if the Input is currently active
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
        public InputState State
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
            State = InputState.active;
            IsActive = true;
        }

        /// <summary>
        /// Determines whether this instance is normal.
        /// </summary>
        public void IsNormal()
        {
            state = InputState.normal;
            IsActive = false;
        }

        #endregion
    }
}