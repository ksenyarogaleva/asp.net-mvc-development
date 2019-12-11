using System;

namespace CountdownClock
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            CountdownClock c = new CountdownClock();
            Subscriber s1 = new Subscriber("Ksenya Rogaleva");
            Subscriber s2 = new Subscriber("Zykov Timophey");
            s1.Subscribe(c);
            s2.Subscribe(c);
            Console.WriteLine("Enter waiting time in seconds:");
            var time = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the message:");
            var msg = Console.ReadLine();
            c.SimulateCountdownClock(time, msg);
            s1.UnSubscribe(c);
            c.SimulateCountdownClock(time, msg);

            Console.ReadKey();
        }
    }
}
