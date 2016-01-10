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
    /// <summary>
    /// Class FrameRate.
    /// </summary>
    public class FrameRate
    {
        #region Variables and Properties

        /// <summary>
        /// Gets the total frames.
        /// </summary>
        /// <value>The total frames.</value>
        public long TotalFrames { get; private set; }

        /// <summary>
        /// Gets the total seconds.
        /// </summary>
        /// <value>The total seconds.</value>
        public float TotalSeconds { get; private set; }

        /// <summary>
        /// Gets the average frames per second.
        /// </summary>
        /// <value>The average frames per second.</value>
        public float AverageFramesPerSecond { get; private set; }

        /// <summary>
        /// Gets the current frames per second.
        /// </summary>
        /// <value>The current frames per second.</value>
        public float CurrentFramesPerSecond { get; private set; }

        /// <summary>
        /// The maximum samples
        /// </summary>
        public const int MAXIMUM_SAMPLES = 100;

        /// <summary>
        /// The _sample buffer
        /// </summary>
        private Queue<float> _sampleBuffer = new Queue<float>();

        #endregion

        #region Constructor Region

        /// <summary>
        /// Initializes a new instance of the <see cref="FrameRate" /> class.
        /// </summary>
        public FrameRate()
        {

        }

        #endregion

        #region Method Region

        /// <summary>
        /// Updates the specified delta time.
        /// </summary>
        /// <param name="deltaTime">The delta time.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
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
