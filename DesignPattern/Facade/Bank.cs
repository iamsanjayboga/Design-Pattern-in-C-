using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Facade
{
    public class Bank
    {
        public bool HasSufficientFunds(Customer c, int amount)
        {
            Console.WriteLine("Checking... Bank");
            return amount > 100 ? true : false;
        }

    }
}
