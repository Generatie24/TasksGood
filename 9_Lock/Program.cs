using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _9_Lock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            object _lock = new object();

            Task task = Task.Run(() =>
            {

                for (int i = 0; i < 1000000; i++)
                {
                    lock (_lock) 
                    {
                        // n++
                        // ++n
                        n = n +1;
                    }
                }
            });


            for (int i = 0; i < 1000000; i++)
            {
                lock (_lock)
                {
                    // n--
                    n = n -1;
                }
            }

            Task.WaitAll(task);
            Console.WriteLine($"The end result is: {n}");
        }
    }
}
