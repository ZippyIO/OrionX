﻿// OrionX Disclaimer
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
        #region Fields Region

        /// <summary>
        /// The WASD key Schema
        /// </summary>
        public SchemaWASD WASD;

        /// <summary>
        /// The arrow key Schema
        /// </summary>
        public SchemaArrow Arrow;

        /// <summary>
        /// List of keyboard Schemas
        /// </summary>
        public SchemaList List;

        #endregion

        #region Constructor Region

        public KeyboardSchema()
        {

        }

        #endregion

        #region Schema Methods

        /// <summary>
        /// WASD Key Schema
        /// </summary>
        /// <param name="keyOne">The key one.</param>
        /// <param name="keyTwo">The key two.</param>
        /// <param name="keyThree">The key three.</param>
        /// <param name="keyFour">The key four.</param>
        public void WASDSchema(Keys keyOne, Keys keyTwo, Keys keyThree, Keys keyFour)
        {
            keyOne = Keys.W;
            keyTwo = Keys.S;
            keyThree = Keys.A;
            keyFour = Keys.D;
        }

        /// <summary>
        /// Arrow Key Schema
        /// </summary>
        /// <param name="keyOne">The key one.</param>
        /// <param name="keyTwo">The key two.</param>
        /// <param name="keyThree">The key three.</param>
        /// <param name="keyFour">The key four.</param>
        public void ArrowSchema(Keys keyOne, Keys keyTwo, Keys keyThree, Keys keyFour)
        {
            keyOne = Keys.Up;
            keyTwo = Keys.Down;
            keyThree = Keys.Left;
            keyFour = Keys.Right;
        }

        #endregion

        #region XNA Methods

        public void Initalize()
        {

        }

        #endregion
    }
}