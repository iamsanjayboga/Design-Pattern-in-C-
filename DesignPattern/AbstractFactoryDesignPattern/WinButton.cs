using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryDesignPattern
{
    public class WinButton : IButton
    {
        public void Press()
        {
            Console.WriteLine("Windows Button Clicked");
        }
    }
}
