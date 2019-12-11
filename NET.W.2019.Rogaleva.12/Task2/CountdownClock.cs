using System;
using System.Threading;

namespace CountdownClock
{
    /// <summary>
    /// Class that notificates all event subscribers.
    /// </summary>
    internal class CountdownClock
    {
        /// <summary>
        /// Delegate for the event.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Contains information about the event.</param>
        public delegate void CountdownEventHandler(object sender, CountdownEventArgs e);

        /// <summary>
        /// Event.
        /// </summary>
        public event CountdownEventHandler TimeEnded = (sender, e) => { };

        /// <summary>
        /// Gets the information about the message and sends this information to the class <c>CountdowmEventArgs</c>.
        /// </summary>
        /// <param name="sec">Waiting time in seconds.</param>
        /// <param name="msg">Message that will be printed to subscribers after the event happen.</param>
        public void SimulateCountdownClock(int sec, string msg)
        {
            if (sec <= 0)
            {
                throw new ArgumentException("Waiting time should be above zero!");
            }
            else
            {
                Thread.Sleep(sec * 1000);
                var e = new CountdownEventArgs(sec, msg);
                this.OnTimeEnded(this, e);
            }
        }

        /// <summary>
        /// Notificates the subscribers with the event happening.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Contains information about the event.</param>
        protected virtual void OnTimeEnded(object sender, CountdownEventArgs e)
        {
            _ = e ?? throw new ArgumentNullException(nameof(e));
            this.TimeEnded?.Invoke(sender, e);
        }
    }
}
