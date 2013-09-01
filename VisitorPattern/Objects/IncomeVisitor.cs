using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorPattern.Objects
{
    public class IncomeVisitor : IVisitor
    {
        public double Amount;
        public void Visit(BankAccount bankAccount)
        {
            Amount += bankAccount.Amount * bankAccount.MonthlyInterest;
        }

        public void Visit(RealEstate realEstate)
        {
            Amount += realEstate.MonthlyRent;
        }

        public void Visit(Loan loan)
        {
            Amount -= loan.MonthlyPayment;
        }
    }
}
