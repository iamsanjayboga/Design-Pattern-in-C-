using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PrototypeDesignPattern
{
    public class Program
    {
        /*
        Prototype allows us to hide the complexity of making new instances 
        from the client. The concept is to copy an existing object rather 
        than creating a new instance from scratch, something that may 
        include costly operations. 
        
        The existing object acts as a prototype and contains the state of the object. 
        The newly copied object may change same properties only if required. 
        
        This approach saves costly resources and time, 
        especially when object creation is a heavy process.

                               (Interface IEmployee)                        
        Client -------------------> Prototype
                                        ^
                                  ______|______            
                                  |            |
                         Concrete Proto 1   Concrete Proto 2
                         (Typist)           (Developer)
         */
        public static void Main(string[] args)
        {
            Developer dev = new Developer();
            dev.Name = "Sanjay";
            dev.Role = "Software Developer";
            dev.PreferredLanguage = "C#";

            Developer devcopy = (Developer)dev.Clone();
            devcopy.Name = "Urjitha"; //Not mention Role and PreferredLanguage, it will copy above

            Console.WriteLine(dev.GetDetails());
            Console.WriteLine(devcopy.GetDetails());

            Typist type = new Typist();
            type.Name = "Sravan";
            type.Role = "Typist";
            type.WordsPerMinute = 120;

            Typist typecopy = (Typist)type.Clone();
            typecopy.Name = "Suresh";
            typecopy.WordsPerMinute = 110; //Not mention Role, it will copy above

            Console.WriteLine(type.GetDetails());
            Console.WriteLine(typecopy.GetDetails());

            Console.ReadLine();


        }
    }
}
