// OrionX Disclaimer
// ------------------------------------------------------
// OrionX is licenced under GNU GPL 3.0.
// Please read the licence file for more information.
// ------------------------------------------------------
// 
// * User: ZippyBling
// * File: Math.cs
// * Date: 28/12/2015
// * Time: 4:08 PM

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OrionX.Math.Time;

namespace OrionX.Math
{
    /// <summary>
    /// Class Math.
    /// </summary>
    public class Math
    {
        #region Fields Region

        /// <summary>
        /// DeltaTime
        /// </summary>
        public DeltaTime Time;

        #endregion

        #region Methods

        /// <summary>
        /// Initalizes this instance.
        /// </summary>
        public void Initalize()
        {
            Time = new DeltaTime();
        }

        #endregion
    }
}
