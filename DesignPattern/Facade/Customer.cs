using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Facade
{
    public class Customer
    {
        public string name { get; set; }

        public Customer(string name)
        {
            this.name = name;
        }

    }
}
