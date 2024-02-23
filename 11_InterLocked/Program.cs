using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _11_InterLocked
{
    // Interlocked is used for protection on nonatomic operations
    // so with use of Interlocked our operation becomes Atomic operation
    //ADD and SUB are nonatomic operations
    // example 
    // n = n + 1;  non atomic operation ex. while n is read by first thread the second thread might increment or decrement it

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    //n++;
                    Interlocked.Increment(ref n);
                }
            });

            for (int i = 0; i < 1000000; i++)
            {
                //n--;
                Interlocked.Decrement(ref n);
            }

            Console.WriteLine($"The End Result is {n}");
        }
    }
}
