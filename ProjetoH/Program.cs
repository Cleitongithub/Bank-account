using System;
using System.Globalization;
using System.Collections.Generic;
using ProjetoH.Entities;
namespace ProjetoH
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "anna", 500.0, 500.0));

            double sum = 0.0;
            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine("Total Balance : " + sum.ToString("f2"),CultureInfo.InvariantCulture);

            foreach (Account acc in list)
            {
                acc.Withdraw(10.0);
            }
            foreach (Account acc in list)
            {
                Console.WriteLine("Update Balance for account"
                +acc.Number
                    + (": ")
                    + acc.Balance.ToString("f2", CultureInfo.InvariantCulture));
                    
            }
        }
    }
}
