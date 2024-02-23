using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Continuation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task<int> task = Task.Run(() =>
            {
                return 2;
            }).ContinueWith(t =>
                {
                    return t.Result + 1;
                });
            Console.WriteLine( "First with lambda " + task.Result);

            //-----------------------------------------

            Task<int> task2 = Task.Run(GiveIntBack).ContinueWith(t =>
            {
                return t.Result + Give2Back();
            });

            Console.WriteLine( "traditional way " + task2.Result);   
        }

        private static int Give2Back()
        {
            return 2;   
        }

        private static int GiveIntBack() 
        {
            string someString = "C# is cool programming language";
            return someString.Length;
        }
    }
}
