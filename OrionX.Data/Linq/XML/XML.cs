// OrionX.Data Disclaimer
// ------------------------------------------------------
// OrionX.Data is licenced under GNU GPL 3.0.
// Please read the licence file for more information.
// ------------------------------------------------------
// 
// * User: ZippyBling
// * File: XML.cs
// * Date: 28/12/2015
// * Time: 5:17 PM

using OrionX.Data.Linq.XML.Load;
using OrionX.Data.Linq.XML.Read;

namespace OrionX.Data.Linq.XML
{
    public class XML
    {
        #region Fields & Variables

        /// <summary>
        /// XML Reader
        /// </summary>
        public Reader Reader;

        /// <summary>
        /// XML Loader
        /// </summary>
        public Loader Loader;

        #endregion

        #region Methods

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public void Initialize()
        {
            Reader = new Reader();
            Loader = new Loader();
        }

        #endregion
    }
}