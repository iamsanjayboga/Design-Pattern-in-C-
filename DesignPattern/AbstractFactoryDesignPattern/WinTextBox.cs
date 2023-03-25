using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryDesignPattern
{
    public class WinTextBox : ITextBox
    {
        public void showText()
        {
            Console.WriteLine("Windows TextBox Showed");
        }
    }
}
