using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactoryDesignPattern
{
    public class GUIAbstractFactory
    {
        /*
         * The Abstract Factory design pattern provides an interface 
         * for creating families of related or dependent objects without 
         * specifying their concrete classes.
         */
        public static IFactory CreateFactory(string os)
        {
            if(os == "windows")
            {
                return new WinFactory();
            }
            else if(os == "mac")
            {
                return new MacFactory();
            }
            else
            { 
                //default
                return new WinFactory();
            }
        }
    }

    public class AbstractFactoryMain
    {
        /*                  WINFACTORY                                   IFACTORY                        
               |---------->ConcretFractory------------->(Interface) AbstractFactory
               |                  |                                           |   
        client |                  |                                           |
               |                  V                                           V
               |---------->ConcretProduct-------------->(Interface) AbstractProduct
                           WINBUTTON & WINTEXT                       IBUTTON & ITEXTBOX                      
         */
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Operating System");
            string os = Console.ReadLine();

            IFactory fact = GUIAbstractFactory.CreateFactory(os); 
            //FACTORY DESIGN PATTERN --> CREATING OBJECT BASED ON SOMELOGICS
            //FACT IS AN OBJECT OF THAT OS WHICH USER PASSED
            // Ex: OS = Windows the Fact = WinFactory()

            //ONCE WE GET THE TYPE OF OS
            //MAY BE WINDOWS OR MAC ONCE WE GET OBJECT WE WILL CALL CREATEBUTTON OF THAT SAME CLASS
            IButton button = fact.CreateButton();
            //ABOVE LINE RETURNS object of OSBUTTON() -->MAC OR WIN

            button.Press(); //THEN CALLING INTERFACE IMPLEMENTED METHOD

            ITextBox text = fact.CreateTextBox();
            text.showText();


            Console.ReadLine();

        }
    }
}
