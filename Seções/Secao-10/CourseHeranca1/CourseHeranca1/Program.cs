using CourseHeranca1.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace CourseHeranca1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*AULA HERANÇA 
            BussinesAccount account = new BussinesAccount(8010, "Naruto Uzumaki", 105.20, 1000.0);

            Console.WriteLine(account.Balance);

          //account.Balance = 200.00;*/


            /*AULA UPCASTING DOWNCASTING
            Account acc = new Account(1001, "Alex", 0.0);
            BussinesAccount bacc = new BussinesAccount(1002, "Maria", 0.0, 500.0);

            //UPCASTING = Conversão da Sub-Classe p/ Super-Classe
            Account acc1 = bacc;
            Account acc2 =  new BussinesAccount(1003,"Bob", 0.0, 200.0);
            Account acc3 = new SavvingsAccount (1004, "ANA", 0.0, 0.01);

            //DOWNCASTING = Conversão da Super-Classe p/ Sub-Classe
            BussinesAccount acc4 = (BussinesAccount)acc2;
            acc4.Loan(100.0);
            //BussinesAccount acc5 = (BussinesAccount)acc3;
            if(acc3 is BussinesAccount)
            {
                //BussinesAccount acc5 = (BussinesAccount)acc3;
                BussinesAccount acc5 = acc3 as BussinesAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavvingsAccount)
            {
                //SavvingsAccount acc5 = (SavvingsAccount)acc3;
                SavvingsAccount acc5 = acc3 as SavvingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
            */

            //Account acc1 = new Account(1001, "Alex", 500.0);
            //Account acc2 = new SavvingsAccount(1002, "Ana", 500.0, 0.01);

            //acc1.Withdraw(10.0);
            //acc2.Withdraw(10.0);

            //Console.WriteLine(acc1.Balance);
            //Console.WriteLine(acc2.Balance);

            List<Account> list = new List<Account>();

            list.Add(new SavvingsAccount(1001, "Alex", 500.00, 0.01));
            list.Add(new BussinesAccount(1002, "Maria", 500.00, 400.00));
            list.Add(new SavvingsAccount(1003, "Bob", 500.00, 0.01));
            list.Add(new BussinesAccount(1004, "Anna", 500.00, 500.00));


            double sum = 0.0;

            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach(Account acc in list)
            {
                acc.Withdraw(10.0);
            }

            foreach(Account acc in list)
            {
                Console.WriteLine("Updated balance for account "
                    + acc.Number
                    + ": "
                    + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
