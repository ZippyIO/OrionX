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

    public sealed class FileType
    {

        /// <summary>
        /// Is the FileType defined allowed
        /// </summary>
        public bool IsAllowed { get; set; }


        /// <summary>
        /// The file's type
        /// </summary>
        public FileTypes FileTypes { get; set; }

        public FileType(FileTypes fileType, bool isAllowed)
        {
            fileType = FileTypes;
            isAllowed = IsAllowed;
        }
    }
}