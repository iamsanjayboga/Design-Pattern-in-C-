using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryDesignPattern
{
    class OperatingSystemFactory
    {
        public OS getInstance(string s)
        {
            if (s.Equals("Open"))
            {
                return new Android();
            }
            else if (s.Equals("Close"))
            {
                return new IOS();
            }
            else
            {
                return new Windows();
            }
        }
    }
}
