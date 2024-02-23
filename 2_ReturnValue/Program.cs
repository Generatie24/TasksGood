using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2_ReturnValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task<int> t = Task.Run(() =>
            {
                return 25;
            });
            Console.WriteLine(t.Result);

            Task<int> t1 = Task.Run(GiveIntBack);
            Console.WriteLine(t1.Result);

            Task<string> t2 = Task.Run(GiveStringBack);
            Console.WriteLine(t2.Result);
            Console.ReadLine();
        }

        private static int GiveIntBack()
        {
            string someString = "C# is cool programming language";
            return someString.Length;
        }

        private  static string GiveStringBack() 
        {
            string someString  = "C# is cool programming language";
            return someString.Substring(0, 10);
        }
    }
}
