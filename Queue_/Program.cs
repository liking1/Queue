using System;

namespace Queue_
{
    
    class Program
    {
        static void Main(string[] args)
        {
            QueueClass<int> queue = new QueueClass<int>();
            queue.Add(2, 5);
            queue.Add(5, 2);
            queue.Add(7, 1);
            
            Console.WriteLine($"{queue.Top()}");
            Console.WriteLine();
            Console.WriteLine();
            //queue.Extract();
            foreach (var item in queue)
            {
                Console.WriteLine($"{item}");
            }

        }
    }
}
