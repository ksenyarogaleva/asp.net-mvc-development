using System;

namespace CountdownClock
{
    /// <summary>
    /// Represents the subscribers to the event.
    /// </summary>
    internal class Subscriber
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Subscriber"/> class.
        /// </summary>
        /// <param name="name">Name of subscriber.</param>
        public Subscriber(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        /// <summary>
        /// Registers a callback.
        /// </summary>
        /// <param name="c">Instance of the class <c>CountdownClock</c>.</param>
        public void Subscribe(CountdownClock c)
        {
            c.TimeEnded += this.PrintMessage;
        }

        /// <summary>
        /// Unregisters the callback.
        /// </summary>
        /// <param name="c">Instance of the class <c>CountdownClock</c>.</param>
        public void UnSubscribe(CountdownClock c)
        {
            c.TimeEnded -= this.PrintMessage;
        }

        /// <summary>
        /// Prints message for the subscriber after the event happening.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Contains information about the event.</param>
        public void PrintMessage(object sender, CountdownEventArgs e)
        {
            Console.WriteLine($"{this.Name}, countdown ended.");
            Console.WriteLine(e.Message);
        }
    }
}
