using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Facade
{
    public class FacadeMain
    {
        /*
         * The Facade design pattern provides a unified interface to a set of interfaces in a subsystem. 
         * This pattern defines a higher-level interface that makes the subsystem easier to use.
         * 
         * it hides the complexities of the systen and provides a simple interface to the client 
         * from where rhe client can access the system ---> JDBC
         * 
         * In programming, we must have connected to a database to fetch some data. 
         * We simply call the method dataSource.getConnection() 
         * to get the connection but internally a lot of things happen such as loading 
         * the driver, creating connection or fetching connection from pool, update stats 
         * and then return the connection reference to caller method. 
         * It is another example of Facade pattern in the programming world.
         * 
         *                               |----------------->CREDIT       
         * MAIN ------------------> MORTGAGEFACADE -------->LOAN         
         *                               |----------------->BANK       
         */
        public static void Main(string[] args)
        {
            MortgageFacade mf = new MortgageFacade();

            Customer c = new Customer("Sanjay");

            bool mortgage = mf.isEligible(c, 5000);

            Console.WriteLine("Mortgage Status : " + mortgage);
            Console.ReadKey();

        }
    }
}
