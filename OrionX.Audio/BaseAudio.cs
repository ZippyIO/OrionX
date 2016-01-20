// OrionX Disclaimer
// ------------------------------------------------------
// OrionX is licenced under GNU GPL 3.0.
// Please read the licence file for more information.
// ------------------------------------------------------
//  
// * User: ZippyBling
// * File: BaseAudio.cs
// * Date: 31/12/2015
// * Time: 10:16 PM

using Microsoft.Xna.Framework.Audio;

namespace OrionX.Audio
{
    public abstract class BaseAudio
    {
        public SoundEffect SoundEffect { get; set; }
        public SoundEffectInstance SoundEffectInstance { get; set; }
        public float Length { get; set; }
        public bool IsActive { get; set; }
    }
}