using System;

namespace BankingApp_202101
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Datorium Digital Bank***");
            var account1 = new BankAccount();
            account1.Number = "DDB123456789";
            account1.Owner = "Linus Torvalds";
            account1.Balance = 4000000;
            Console.WriteLine($"Account {account1.Number} belongs to {account1.Owner} and has a balance of {account1.Balance}");

            var account2 = new BankAccount();
            account2.Number = "DDB123456790";
            account2.Owner = "Anna Kurnikova";
            account2.Balance = 10000000;
            Console.WriteLine($"Account {account2.Number} belongs to {account2.Owner} and has a balance of {account2.Balance}");

        }
    }

    public class BankAccount
    {
        public string Number { get; set; }
        public string Owner { get; set; }
        public decimal Balance { get; set; }

    }
}