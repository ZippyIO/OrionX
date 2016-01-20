// OrionX Disclaimer
// ------------------------------------------------------
// OrionX is licenced under GNU GPL 3.0.
// Please read the licence file for more information.
// ------------------------------------------------------
// 
// * User: ZippyBling
// * File: Person.cs
// * Date: 28/12/2015
// * Time: 3:41 PM
namespace OrionX
{
    /// <summary>
    /// Class Person. This class cannot be inherited.
    /// </summary>
    public sealed class Person
    {
        // Test class
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public Person(string name)
        {
            Name = name;
        }
    }
}