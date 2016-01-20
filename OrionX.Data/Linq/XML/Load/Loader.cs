// OrionX.Data Disclaimer
// ------------------------------------------------------
// OrionX.Data is licensed under GNU GPL 3.0.
// Please read the license file for more information.
// ------------------------------------------------------
// 
// * User: ZippyBling
// * File: XMLLoader.cs
// * Date: 28/12/2015
// * Time: 5:18 PM

using System.Xml;
using System.Xml.Linq;
using OrionX.Data.Linq.XML.Read;

namespace OrionX.Data.Linq.XML.Load
{
    /// <summary>
    /// Class Loader.
    /// </summary>
    public class Loader
    {
        /// <summary>
        /// Loads the specified location.
        /// </summary>
        /// <param name="location">The location.</param>
        /// <param name="filename">The filename.</param>
        public void Load(string location, string filename)
        {
            XDocument doc = XDocument.Load(location + filename);
        }

        /// <summary>
        /// Loads the reader.
        /// </summary>
        /// <param name="location">The location.</param>
        /// <param name="filename">The filename.</param>
        public void LoadReader(string location, string filename)
        {
            XmlReader reader = XmlReader.Create(location + filename);
            XDocument doc = XDocument.Load(reader);
        }
    }
}