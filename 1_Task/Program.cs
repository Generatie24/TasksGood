using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // new way of calling method
            Task t = Task.Run(() =>
            {
                for (int i = 0; i < 50; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine();    
            });
            t.Wait(); // wait to exute task

            // traditional way of calling mathod
            Task t1 = Task.Run(ThreadMethod);
            t1.Wait();
        }

        private static void ThreadMethod()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.Write("*");
            }
        }
    }
}
