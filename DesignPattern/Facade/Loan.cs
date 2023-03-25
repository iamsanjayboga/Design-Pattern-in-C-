using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Facade
{
    public class Loan
    {
        public bool HasDebt(Customer c)
        {
            Console.WriteLine("Checking... loan");
            return true;
        }
    }
}
