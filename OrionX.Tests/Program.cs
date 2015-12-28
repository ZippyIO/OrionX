// OrionX Disclaimer
// ------------------------------------------------------
// OrionX is licenced under GNU GPL 3.0.
// Please read the licence file for more information.
// ------------------------------------------------------
// 
// * User: ZippyBling
// * File: Person.cs
// * Date: 28/12/2015
// * Time: 3:48 PM

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrionX.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Jon = new Person("Jon");

            Console.WriteLine(Jon.Name);
            Console.ReadKey();
        }
    }
}
