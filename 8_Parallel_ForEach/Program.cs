using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _8_Parallel_ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array  = { 0,1, 2, 3,4,5,6,7,8,9 };

            //normal foreach
            //foreach (int i in array)
            //{
            //    Console.WriteLine(i);
            //    Thread.Sleep(1000);
            //}

            Parallel.ForEach(array, i =>
            {
                Console.WriteLine(i);
                //Thread.Sleep(1000);
                Task.Delay(1000);
            });
        }
    }
}
