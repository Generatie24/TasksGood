using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Continuation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task<int> t = Task.Run(() =>
            {
                int a = 1;
                int b = 0;
                //throw new Exception();
                return a/ b;
            });
            t.ContinueWith((i) =>
            {
                Console.WriteLine("There was an error");
            }, TaskContinuationOptions.OnlyOnFaulted);
            t.ContinueWith((i) =>
            {
                Console.WriteLine("Task Completed successfuly");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);

            Console.WriteLine( t.Result);
        }
    }
}
