using Banking.Models;
using System;
using System.Collections.Generic;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("123-4567890-12");
            Console.WriteLine($"Accountnumber: {account.AccountNumber}");
            Console.WriteLine($"Balance: {account.Balance}");
            account.Deposit(200M);
            Console.WriteLine($"Balance after deposit of 200€: {account.Balance}");
            account.Withdraw(100M);
            Console.WriteLine($"Balance after withdraw of 100€: {account.Balance}");
            IEnumerable<Transaction> transactions = account.GetTransactions(null, null);
            foreach (Transaction t in transactions)
            {
                Console.WriteLine($"Transactions: {t.DateOfTrans.ToShortDateString()} - {t.Amount}");
            }
            Console.ReadKey();
        }
    }
}
