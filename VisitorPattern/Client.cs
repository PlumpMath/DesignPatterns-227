using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VisitorPattern.Objects;

namespace VisitorPattern
{
    class Client
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Assets.Add(new BankAccount { Amount = 1000, MonthlyInterest = 0.01 });
            person.Assets.Add(new BankAccount { Amount = 2000, MonthlyInterest = 0.02 });
            person.Assets.Add(new RealEstate { EstimatedValue = 79000, MonthlyRent = 500 });
            person.Assets.Add(new Loan { Owed = 40000, MonthlyPayment = 40 });

            //calculate networth
            //int netWorth = 0;
            //foreach (var bankAccount in person.BankAccounts)
            //{
            //    netWorth += bankAccount.Amount;
            //}

            //foreach (var realEstate in person.RealEstates)
            //{
            //    netWorth += realEstate.EstimatedValue;
            //}

            //foreach (var loan in person.Loans)
            //{
            //    netWorth -= loan.Owed;
            //}

            var netWorthVisitor = new NetWorthVisitor();
            person.Accept(netWorthVisitor);

            var monthlyIncomeVisitor = new IncomeVisitor();
            person.Accept(monthlyIncomeVisitor);

            Console.WriteLine(netWorthVisitor.Total);
            Console.WriteLine(monthlyIncomeVisitor.Amount);
            Console.ReadLine();

        }
    }
}
