﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _5_WaitAll
{
    internal class Program
    {
        static void Main(string[] args)
        {

          

            Task[] tasks = new Task[3];
            tasks[0] = Task.Run(() =>
            {
                //Thread.Sleep(1000);
                Console.WriteLine( "Task 1");
                return 1;
            });

            tasks[1] = Task.Run(() =>
            {
                //Thread.Sleep(1000);
                Console.WriteLine("Task 2");
                return 2;
            });

            tasks[2] = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Task 3");
                return 3;
            });
            Task.WaitAll(tasks);
        }
    }
}
