using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Facade
{
    public class Credit
    {
        public bool HasBadScore(Customer c)
        {
            Console.WriteLine("Checking... Score");
            return true;
        }
    }
}
