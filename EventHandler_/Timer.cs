using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler_
{
    class MyArgs : EventArgs
    {
        public uint Hour { get; set; }
        public uint Minutes { get; set; }
        public MyArgs(uint hour, uint minutes)
        {
            Hour = hour;
            Minutes = minutes;
        }
        
    }

    class Timer
    {
        
        private uint hour = 0;
        private uint minutes = 0;
        public uint Hour { 
            get => hour; 
            set
            {
                if (hour >= 24)
                {
                    hour = 0;
                }
                this.hour = value;
            }
        }
        public uint Minutes {
            get => minutes; 
            set
            {
                if (minutes >= 59)
                {
                    hour++;
                    minutes = 0;
                    
                }
                this.minutes = value;
            }
        }
        public event EventHandler<MyArgs> TimerOver;
        public void Tick()
        {
            Minutes += 1;
            Console.WriteLine("Timer is Diling-giling");
        }
        public override string ToString()
        {
            return $"Hour : {Hour}\n" +
                $"Minutes : {Minutes}"; 
        }
    }
    class Human
    {
        public void Handler(object sender, EventArgs args)
        {
            Timer timer = (Timer)sender;
            Console.WriteLine($"Hour : {timer.Hour}\nMinutes : {timer.Minutes}");
        }
    }
}
