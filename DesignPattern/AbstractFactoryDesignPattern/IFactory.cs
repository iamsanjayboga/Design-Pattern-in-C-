using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryDesignPattern
{
    public interface IFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
    }
}
