// OrionX.Content Disclaimer
// ------------------------------------------------------
// OrionX.Content is licenced under GNU GPL 3.0.
// Please read the licence file for more information.
// ------------------------------------------------------
// 
// * User: ZippyBling
// * File: FileType.cs
// * Date: 28/12/2015
// * Time: 5:31 PM

using System;

namespace OrionX.Content.Game.File
{
    /// <summary>
    /// Class FileType. This class cannot be inherited.
    /// </summary>
    public sealed class FileType
    {
        /// <summary>
        /// Is the FileType defined allowed
        /// </summary>
        /// <value><c>true</c> if this instance is allowed; otherwise, <c>false</c>.</value>
        public bool IsAllowed { get; set; }


        /// <summary>
        /// The file's type
        /// </summary>
        /// <value>The file types.</value>
        public FileTypes FileTypes { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileType" /> class.
        /// </summary>
        /// <param name="fileType">Type of the file.</param>
        /// <param name="isAllowed">if set to <c>true</c> [is allowed].</param>
        public FileType(FileTypes fileType, bool isAllowed)
        {
            fileType = FileTypes;
            isAllowed = IsAllowed;
        }
    }
}