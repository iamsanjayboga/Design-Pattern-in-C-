using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryDesignPattern
{
    public class MacTextBox : ITextBox
    {
        public void showText()
        {
            Console.WriteLine("Mac TextBox Showed");
        }
    }
}
