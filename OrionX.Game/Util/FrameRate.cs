// OrionX.Game Disclaimer
// ------------------------------------------------------
// OrionX.Game is licenced under GNU GPL 3.0.
// Please read the licence file for more information.
// ------------------------------------------------------
// 
// * User: ZippyBling
// * File: FrameRate.cs
// * Date: 28/12/2015
// * Time: 4:17 PM

using System.Collections.Generic;
using System.Linq;

namespace OrionX.Game.Util
{
    public class FrameRate
    {
        #region Variables and Properties

        public long TotalFrames { get; private set; }
        public float TotalSeconds { get; private set; }
        public float AverageFramesPerSecond { get; private set; }
        public float CurrentFramesPerSecond { get; private set; }

        public const int MAXIMUM_SAMPLES = 100;

        private Queue<float> _sampleBuffer = new Queue<float>();

        #endregion

        #region Constructor Region

        public FrameRate()
        {

        }

        #endregion

        #region Method Region

        public bool Update(float deltaTime)
        {
            CurrentFramesPerSecond = 1.0f / deltaTime;

            _sampleBuffer.Enqueue(CurrentFramesPerSecond);

            if (_sampleBuffer.Count > MAXIMUM_SAMPLES)
            {
                _sampleBuffer.Dequeue();
                AverageFramesPerSecond = _sampleBuffer.Average(i => i);
            }
            else
            {
                AverageFramesPerSecond = CurrentFramesPerSecond;
            }

            TotalFrames++;
            TotalSeconds += deltaTime;
            return true;
        }

        #endregion
    }
}
}