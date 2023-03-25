using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Proxy
{
    public class ProxyMain
    {
        public static void Main(string[] args)
        {
            ProxyImage proxy = new ProxyImage("beyonddeals.in");
            proxy.ShowImage();

            Console.ReadKey();
        }
    }
}
