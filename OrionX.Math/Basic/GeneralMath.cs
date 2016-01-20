// OrionX Disclaimer
// ------------------------------------------------------
// OrionX is licensed under GNU GPL 3.0.
// Please read the license file for more information.
// ------------------------------------------------------
//  
// * User: ZippyBling
// * File: General.cs
// * Date: 12/01/2016
// * Time: 1:38 PM
namespace OrionX.Math.Basic
{
    public class GeneralMath
    {
        /// <summary>
        /// Adds two integers together and returns the value
        /// </summary>
        /// <param name="x">First Integer to Add</param>
        /// <param name="y">Second Integer to Add</param>
        /// <returns>System.Int32.</returns>
        public float Add(float x, float y)
        {
            var final = 0f;
            final = x + y;
            return final;
        }

        /// <summary>
        /// Subtracts and returns a value
        /// </summary>
        /// <param name="x">Integer to subtract</param>
        /// <param name="y">Subtraction value</param>
        /// <returns>System.Int32.</returns>
        public float Subtract(float x, float y)
        {
            var final = 0f;
            final = x - y;
            return final;
        }

        /// <summary>
        /// Divides and returns a value
        /// </summary>
        /// <param name="x">Float to Divide</param>
        /// <param name="y">Division value</param>
        /// <returns>System.Single.</returns>
        public float Divide(float x, float y)
        {
            var final = 0f;
            final = x/y;
            return final;
        }

        /// <summary>
        /// Multiplies two numbers together and returns the value
        /// </summary>
        /// <param name="x">The value to Multiply</param>
        /// <param name="y">Multiply value</param>
        /// <returns>System.Single.</returns>
        public float Multiply(float x, float y)
        {
            var final = 0f;
            final = x*y;
            return final;
        }
    }
}