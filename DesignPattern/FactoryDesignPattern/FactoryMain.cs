using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryDesignPattern
{
    public class FactoryMain
    {
        /*
        Factory pattern is one of the most used design patterns.
        This type of design pattern comes under creational pattern 
        as this pattern provides one of the best ways to create an object.

        In Factory pattern, 
        we create object without exposing the creation logic to the client 
        and refer to newly created object using a common interface. 
                 
         */
        public static void Main(string[] args)
        {
            OperatingSystemFactory osf = new OperatingSystemFactory();
            OS obj = osf.getInstance("Close");
            obj.Spec();

            Console.ReadLine();
        }
    }
}
