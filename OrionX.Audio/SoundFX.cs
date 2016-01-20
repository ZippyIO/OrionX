// OrionX Disclaimer
// ------------------------------------------------------
// OrionX is licenced under GNU GPL 3.0.
// Please read the licence file for more information.
// ------------------------------------------------------
//  
// * User: ZippyBling
// * File: SoundFX.cs
// * Date: 31/12/2015
// * Time: 10:18 PM

using Microsoft.Xna.Framework.Audio;

namespace OrionX.Audio
{
    public sealed class SoundFX : BaseAudio
    {
        public SoundFX(SoundEffect SFX, SoundEffectInstance SFXInstance, float length, bool isActive)
        {
            SFX = SoundEffect;
            SFXInstance = SoundEffectInstance;
            length = Length;
            isActive = IsActive;
        }
    }
}