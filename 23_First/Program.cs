using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _23_First
{
    class Switcher
    {

        public void Write0()
        {
            while (true)
            {
                Console.Write("0");
            }
        }

        public void Write1()
        {
            while (true)
            {
                Console.Write("1");
            }
        }

        public void Switch()
        {
            Thread thread = new Thread(Write0);
            thread.Start();
            Write1();
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Switcher switcher = new Switcher();
            switcher.Switch();
        }
    }
}
