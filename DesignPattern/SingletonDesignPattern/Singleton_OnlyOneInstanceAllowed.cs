using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.SingletonDesignPattern
{
    //*
    //Allows to create only object and use same in entire program
    //
    //
    //*//
    public class Abc
    {
        public static Abc obj = new Abc();

        private Abc()
        {
            Console.WriteLine("Instance Created");
        }

        public static Abc getInstance()
        {
            return obj;
        }
    }

    public class Def
    {
        public static Def obj_d;

        private Def()
        {
            Console.WriteLine("Instance Created");
        }

        public static Def getInstance()
        {
            if(obj_d == null)
            {
                obj_d = new Def();
            }
            return obj_d;
        }
    }

    public class Singleton_OnlyOneInstanceAllowed
    {
        public static void Main(string[] args)
        {
            //We need to be careful with multi-thread - in this below which is not happening
            //there is a possibility of allowing instances in a multi-threaded scenario.
            //if we dont call below method still Abc class will be loaded as create a memory in heap

            Abc obj = Abc.getInstance();


            //Early and Lazy Instantiation in Singleton pattern
            //in this case when below instace is called then only obj will be create and loaded - save time and memory
            Def obj1 = Def.getInstance();

            Console.ReadLine();
        }
    }
}
