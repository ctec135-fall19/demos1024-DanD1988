using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // arrays
            // declaration 
            int[] a1 = new int[5];

            // initialization and traversal - one end to otther

            for(int i = 0; i < a1.Length; i++)
            {
                a1[i] = (i * 10) + 1;

            }
            // new isn't required
            // doing multiple things at same time
            int[] a2 = { 1, 2, 3, 4, 5 };

            // traversal 
            foreach(int element in a1)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            // Lists
            // Declaration 
            // T is the paramateration of type of obj
            // in container
            List<int> l = new List<int>();

            // initialization

            l.Add(1);
            l.Add(2);
            l.Add(3);

            // element access
            l[1] = 22;

            // some other methods 
            l.Insert(2, 99); // 2 is index , 99 is value
            l.Remove(1);
            l.Sort(); // sorts in order

            // traversal 
            for(int i=0; i < l.Count; i++)
            {
                Console.WriteLine(l[i]);
            }
            Console.WriteLine();

            foreach(int element in l)
            {
                Console.WriteLine(element);
            }
        }
    }
}
