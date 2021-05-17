using System;

namespace Bankkonto
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount("test", 3123, false);
            ba.Deposit(3214);
            ba.Withdraw(330);
            Console.WriteLine(ba.CheckBalance());
        }
    }
}
