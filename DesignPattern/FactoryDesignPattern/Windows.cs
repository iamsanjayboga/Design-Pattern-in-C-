using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryDesignPattern
{
    public class Windows : OS
    {
        public void Spec()
        {
            Console.WriteLine("Mostly Used OS");
        }
    }
}
