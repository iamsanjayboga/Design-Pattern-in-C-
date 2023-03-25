using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    public class QuickSort : ISortStrategy
    {
        public void Sort(List<string> list)
        {
            list.Sort(); //actuall quick sort algo logic
            Console.WriteLine("Quick Sort");
        }
    }

    public class ShellSort : ISortStrategy
    {
        public void Sort(List<string> list)
        {
            //list.Sort();
            Console.WriteLine("Shell Sort");
        }
    }

    public class HeapSort : ISortStrategy
    {
        public void Sort(List<string> list)
        {
            //list.Sort();
            Console.WriteLine("Heap Sort");
        }
    }


    public class StrategyMain
    {

        /*
         * The Strategy design pattern defines a family of algorithms, 
         * encapsulate each one, and make them interchangeable. 
         * This pattern lets the algorithm vary independently from clients that use it.
         * 
         * Context --------------> Interface Strategy(ISortStrategy)
         *                                      |
         *                                      |
         *                                    ------
         *                             Concrete Strategy A, B, C(Context_SortedList)   
         *                             
         * Strategy design pattern is one of the behavioral design pattern. 
         * Strategy pattern is used when we have multiple algorithm for a 
         * specific task and client decides the actual implementation to be used at runtime.
         */
        public static void Main(string[] args)
        {
            Context_SortedList studentRecords = new Context_SortedList();

            studentRecords.Add_To_List("Sanjay");
            studentRecords.Add_To_List("Urjitha");
            studentRecords.Add_To_List("Mamatha");
            studentRecords.Add_To_List("Srinivas");
            studentRecords.Add_To_List("Sravan");

            studentRecords.SetSortingAlgo(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortingAlgo(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortingAlgo(new HeapSort());
            studentRecords.Sort();
            // Wait for user
            Console.ReadKey();
        }
    }
}
