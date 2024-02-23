using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _10_DeadLock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object lockA = new object();
            object lockB = new object();

            Task task = Task.Run(() =>
            {
                lock (lockA)
                {
                    Thread.Sleep(1000);
                    lock (lockB)
                    {
                        Console.WriteLine("Locked A and B");
                    }
                }
            });

            lock (lockB)
            {
                //Thread.Sleep(1000);
                lock(lockA)
                {
                    Console.WriteLine("Locked B and A");
                }
            }
            task.Wait();


        }
    }
}
