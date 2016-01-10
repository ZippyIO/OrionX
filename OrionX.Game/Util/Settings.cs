// OrionX.Game Disclaimer
// ------------------------------------------------------
// OrionX.Game is licenced under GNU GPL 3.0.
// Please read the licence file for more information.
// ------------------------------------------------------
// 
// * User: ZippyBling
// * File: Setting.cs
// * Date: 01/01/2016
// * Time: 4:34 PM
namespace OrionX.Game.Util
{
    /// <summary>
    /// Class Settings.
    /// </summary>
    public class Settings
    {
        #region Audio Settings

        #region Master Settings

        /// <summary>
        /// The maximum audio level
        /// </summary>
        public float MaxAudioLevel = 100;

        /// <summary>
        /// The minimum audio level
        /// </summary>
        public float MinAudioLevel = 0;

        /// <summary>
        /// The audio level
        /// </summary>
        public float AudioLevel = 100;

        #endregion

        #region Music Settings

        /// <summary>
        /// The maximum music level
        /// </summary>
        public float MaxMusicLevel = 100;

        /// <summary>
        /// The minimum music level
        /// </summary>
        public float MinMusicLevel = 0;

        /// <summary>
        /// The music level
        /// </summary>
        public float MusicLevel = 100;

        #endregion

        #region Gameplay Settings

        /// <summary>
        /// The maximum game audio level
        /// </summary>
        public float MaxGameAudioLevel = 100;

        /// <summary>
        /// The minimum game audio level
        /// </summary>
        public float MinGameAudioLevel = 0;

        /// <summary>
        /// The game audio level
        /// </summary>
        public float GameAudioLevel = 100;

        #endregion

        #endregion
    }
}