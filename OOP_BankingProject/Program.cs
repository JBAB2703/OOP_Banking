using System;

namespace OOP_BankingProject {

    class Program {

        static void Main(string[] args) {

            Savings sav1 = new Savings();
            sav1.Number = "SAV001";
            sav1.Name = "My savings account";
            sav1.ChangeRate(0.02);


            MoneyMarket MM = new MoneyMarket();
            MM.Number = "MM1001";
            MM.Name = "MoneyMarket 1";
            MM.Deposit(100);
            MM.MMIntRate = 0.10;
            MM.PayInterest(12);

            Checking check1 = new Checking();
            check1.Number = "CHECK001";
            check1.Name = "My checking account";
            check1.Deposit(100);
            check1.Pay(100, 20);


            Account[] accounts = new Account[] { sav1, MM, check1 }; //Example of Polymorphism

            foreach(Account acct in accounts) { // Example of Polymorphism
                Console.WriteLine(acct.Print());
            }


            /*
            Savings sav = new Savings();
            sav.Number = "1002";
            sav.Name = "Savings 1";
            sav.IntRate = 0.05;

            sav.Deposit(200);
            sav.Withdraw(100);
            decimal interestToBePaid = sav.CalcInterest(12);
            sav.PayInterest(interestToBePaid);
            decimal savbal = sav.GetBalance();
            Console.WriteLine($"Savings balance is {savbal}");

  
            
            Account acct = new Account();
            acct.Number = "1001";
            acct.Name = "TestAccount";

            acct.Deposit(20);
            acct.Withdraw(10);

            acct.GetBalance();
            decimal balance = acct.GetBalance();
            Console.WriteLine($"Account balance is {balance} (should be 10)");

            acct.Deposit(-10);
            balance = acct.GetBalance();
            Console.WriteLine($"Account balance is {balance} (should be 10)");

            acct.Withdraw(-10);
            balance = acct.GetBalance();
            Console.WriteLine($"Account balance is {balance} (should be 10)");

            acct.Withdraw(20);
            balance = acct.GetBalance();
            Console.WriteLine($"Account balance is {balance} (should be 10)");
               */
        }
    }
}
