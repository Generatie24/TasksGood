using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _21_LockOldWay
{
    class BankRekening
    {
        private readonly object saldoLock = new object();
        public double Saldo { get; private set; }

        public BankRekening(double beginSaldo)
        {
            Saldo = beginSaldo;
        }

        public void Opnemen(double bedrag)
        {
            lock (saldoLock)
            {
                if (Saldo >= bedrag)
                {
                    Console.WriteLine($"Saldo voor opname: {Saldo}, Op te nemen: {bedrag}");
                    Saldo -= bedrag;
                    Console.WriteLine($"Saldo na opname: {Saldo}");
                }
                else
                {
                    Console.WriteLine("Onvoldoende saldo voor de opname.");
                }
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                BankRekening rekening = new BankRekening(1000);

                Thread thread1 = new Thread(() => GeldOpnemen(rekening, 700));
                Thread thread2 = new Thread(() => GeldOpnemen(rekening, 700));

                thread1.Start();
                thread2.Start();

                thread1.Join();
                thread2.Join();
            }
            static void GeldOpnemen(BankRekening rekening, double bedrag)
            {
                rekening.Opnemen(bedrag);
            }
        }
    }
}
