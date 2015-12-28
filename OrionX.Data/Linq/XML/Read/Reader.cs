// OrionX.Data Disclaimer
// ------------------------------------------------------
// OrionX.Data is licenced under GNU GPL 3.0.
// Please read the licence file for more information.
// ------------------------------------------------------
// 
// * User: ZippyBling
// * File: XMLReader.cs
// * Date: 28/12/2015
// * Time: 4:12 PM

using System.Linq;
using System.Xml.Linq;

namespace OrionX.Data.Linq.XML.Read
{
    public class Reader
    {
        //TODO: More XML helper methods
        /// <summary>
        /// loads an XML file and reads the elements specified
        /// </summary>
        /// <param name="tag">XML Tag.</param>
        /// <param name="location">File Location.</param>
        /// <returns>Returns the value in the XML Tag</returns>
        public string Read(string tag, string location)
        {
            var xml = from c in XElement.Load(location).Elements(tag)
                      select c;

            foreach (var customer in xml)
            {
                tag = customer.Value.ToString();
            }

            return tag;
        }
    }
}