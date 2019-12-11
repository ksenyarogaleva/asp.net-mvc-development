using System;

namespace CountdownClock
{
    /// <summary>
    /// Class that contains information about the event.
    /// </summary>
    public class CountdownEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CountdownEventArgs"/> class.
        /// </summary>
        /// <param name="time">Waiting time in seconds.</param>
        /// <param name="msg">Message that will be printed to subscribers after the event happen.</param>
        public CountdownEventArgs(int time, string msg)
        {
            this.Time = time;
            this.Message = msg;
        }

        public int Time { get; }

        public string Message { get; }
    }
}
