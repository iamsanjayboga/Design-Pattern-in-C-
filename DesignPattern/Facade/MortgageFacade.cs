using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Facade
{
    public class MortgageFacade
    {
        Bank bank = new Bank();
        Credit credit = new Credit();
        Loan loan = new Loan();

        public bool isEligible(Customer c, int amount)
        {
            Console.WriteLine(c.name + "applies for loan amount..." + amount);

            bool eligible = true;

            if (!bank.HasSufficientFunds(c, amount))
            {
                eligible = false;
            }
            else if (!credit.HasBadScore(c))
            {
                eligible = false;
            }
            else if (!loan.HasDebt(c))
            {
                eligible = false;
            }

            return eligible;
        }
    }
}
