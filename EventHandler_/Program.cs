using System;

namespace EventHandler_
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer() { Hour = 10, Minutes = 4};
            timer.Tick();
            Console.WriteLine(timer);
        }
    }
}
