// OrionX.Audio Disclaimer
// ------------------------------------------------------
// OrionX.Audio is licenced under GNU GPL 3.0.
// Please read the licence file for more information.
// ------------------------------------------------------
// 
// * User: ZippyBling
// * File: BaseAudio.cs
// * Date: 01/01/2016
// * Time: 2:48 PM

using Microsoft.Xna.Framework.Audio;

namespace OrionX.Audio.Sound
{
    public abstract class BaseAudio
    {
        #region Fields & Variables Region

        /// <summary>
        /// Gets or sets the sound effect.
        /// </summary>
        /// <value>
        /// The sound effect.
        /// </value>
        public SoundEffect SoundEffect { get; set; }

        /// <summary>
        /// Gets or sets the sound effect instance.
        /// </summary>
        /// <value>
        /// The sound effect instance.
        /// </value>
        public SoundEffectInstance SoundEffectInstance { get; set; }

        /// <summary>
        /// Gets or sets the length of the audio file.
        /// </summary>
        /// <value>
        /// The length.
        /// </value>
        public float Length { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is active.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is active; otherwise, <c>false</c>.
        /// </value>
        public bool IsActive { get; set; }

        #endregion
    }
}