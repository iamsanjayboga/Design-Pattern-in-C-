using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    public class Context_SortedList
    {
        private List<string> list = new List<string>();
        private ISortStrategy sortstrategy;

        public void SetSortingAlgo(ISortStrategy sortstrategy)
        {
            this.sortstrategy = sortstrategy;
        }

        public void Add_To_List(string name)
        {
            list.Add(name);
        }

        public void Sort()
        {
            //here in above private variable i..e sortstrategy
            //we have passed quicksort object
            //which means indirectly we are calling quicksort
            //class with sort method in it.
            sortstrategy.Sort(list);


            foreach (string name in list)

            {
                Console.WriteLine(" " + name);
            }
            Console.WriteLine();

        }
    }
}
