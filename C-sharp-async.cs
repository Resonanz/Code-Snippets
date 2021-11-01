// Very simple example of starting 4 async threads
// Code runs in VS2022 as a Windows console app

using System;
using System.Threading.Tasks;

namespace Threading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var delay1 = new AsyncDelayClass();
            var delay2 = new AsyncDelayClass();
            var delay3 = new AsyncDelayClass();
            var delay4 = new AsyncDelayClass();

            Console.WriteLine("Starting all async delays...");

            delay1.DelayAsync(1000);
            delay2.DelayAsync(2000);
            delay3.DelayAsync(3000);
            delay4.DelayAsync(4000);
            
            Console.WriteLine("All async delays started...");

            Console.ReadKey();
        }
    }
    public class AsyncDelayClass
    {
        public async void DelayAsync(int ms)
        {
            await Task.Delay(ms);
            Console.WriteLine($"Finished delaying {ms} ms.");
        }
    }
}

// OUTPUT
// Starting all async delays...
// All async delays started...
// Finished delaying 1000 ms.
// Finished delaying 2000 ms.
// Finished delaying 3000 ms.
// Finished delaying 4000 ms.
