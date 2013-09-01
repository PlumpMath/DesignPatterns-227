using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorPattern.Objects
{
    public interface IVisitor
    {
        void Visit(BankAccount bankAccount);
        void Visit(RealEstate realEstate);
        void Visit(Loan loan);
    }
}
