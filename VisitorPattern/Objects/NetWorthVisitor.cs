using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorPattern.Objects
{
    public class NetWorthVisitor : IVisitor
    {
        public int Total { get; set; }

        public void Visit(BankAccount bankAccount)
        {
            Total += bankAccount.Amount;
        }

        public void Visit(RealEstate realEstate)
        {
            Total += realEstate.EstimatedValue;
        }

        public void Visit(Loan loan)
        {
            Total -= loan.Owed;
        }
    }
}
