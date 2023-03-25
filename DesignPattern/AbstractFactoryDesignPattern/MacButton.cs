using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryDesignPattern
{
    public class MacButton : IButton
    {
        public void Press()
        {
            Console.WriteLine("Mac Button Clicked");
        }
    }
}
