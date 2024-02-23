using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _7_Parallel_For 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //    Thread.Sleep(1000);
            //}

            // parallel loop

            Parallel.For(0, 9, (i) =>
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            });
           
        }
    }
}
