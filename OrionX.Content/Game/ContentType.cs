// OrionX.Content Disclaimer
// ------------------------------------------------------
// OrionX.Content is licensed under GNU GPL 3.0.
// Please read the license file for more information.
// ------------------------------------------------------
// 
// * User: ZippyBling
// * File: ContentType.cs
// * Date: 28/12/2015
// * Time: 5:29 PM

using OrionX.Content.Game.File;

namespace OrionX.Content.Game
{
    /// <summary>
    /// Class ContentType.
    /// </summary>
    public class ContentType
    {

        #region Base File Types

        /// <summary>
        /// XNB FileType
        /// </summary>
        FileType XNB = new FileType(FileTypes.XNB, true);

        #endregion

        #region Image File Types

        /// <summary>
        /// PNG FileType
        /// </summary>
        FileType PNG = new FileType(FileTypes.PNG, true);

        /// <summary>
        /// JPG FileType
        /// </summary>
        FileType JPG = new FileType(FileTypes.JPG, true);

        /// <summary>
        /// JPEG FileType
        /// </summary>
        FileType JPEG = new FileType(FileTypes.JPEG, false);

        /// <summary>
        /// GIF FileType
        /// </summary>
        FileType GIF = new FileType(FileTypes.GIF, false);

        /// <summary>
        /// BMP FileType
        /// </summary>
        FileType BMP = new FileType(FileTypes.BMP, true);

        /// <summary>
        /// DDS FileType
        /// </summary>
        FileType DDS = new FileType(FileTypes.DDS, true);

        /// <summary>
        /// DIB FileType
        /// </summary>
        FileType DIB = new FileType(FileTypes.DIB, true);

        /// <summary>
        /// HDR FileType
        /// </summary>
        FileType HDR = new FileType(FileTypes.HDR, true);

        /// <summary>
        /// PFM FileType
        /// </summary>
        FileType PFM = new FileType(FileTypes.PFM, true);

        /// <summary>
        /// PPM FileType
        /// </summary>
        FileType PPM = new FileType(FileTypes.PPM, true);

        /// <summary>
        /// TGA FileType
        /// </summary>
        FileType TGA = new FileType(FileTypes.TGA, true);

        #endregion

        #region Font File Types

        /// <summary>
        /// SpriteFont FileType
        /// </summary>
        FileType SpriteFont = new FileType(FileTypes.SPRITEFONT, true);

        #endregion

        #region 3D File Types

        /// <summary>
        /// X FileType
        /// </summary>
        FileType X = new FileType(FileTypes.X, true);

        /// <summary>
        /// FBX FileType
        /// </summary>
        FileType FBX = new FileType(FileTypes.FBX, true);

        /// <summary>
        /// OBJ FileType
        /// </summary>
        FileType OBJ = new FileType(FileTypes.OBJ, true);

        #endregion

        #region Audio File Types

        /// <summary>
        /// XAP FileType
        /// </summary>
        FileType XAP = new FileType(FileTypes.XAP, true);

        /// <summary>
        /// WMA FileType
        /// </summary>
        FileType WMA = new FileType(FileTypes.WMA, true);

        /// <summary>
        /// MP3 FileType
        /// </summary>
        FileType MP3 = new FileType(FileTypes.MP3, true);

        /// <summary>
        /// WAV FileType
        /// </summary>
        FileType WAV = new FileType(FileTypes.WAV, true);

        #endregion

        #region Effect File Types

        /// <summary>
        /// FX FileType
        /// </summary>
        FileType FX = new FileType(FileTypes.FX, true);

        #endregion

        #region Constructor Region

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentType" /> class.
        /// </summary>
        public ContentType()
        {

        }

        #endregion
    }
}