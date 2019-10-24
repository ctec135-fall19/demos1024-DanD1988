using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaration
            Dictionary<string, Student> studentDictionary = new
                Dictionary<string, Student>();

            // Initialize 
            // two different ways to add items to dictionary
            studentDictionary.Add("Danny", new Student("Danny1"));
            studentDictionary["Jill"] = new Student("Jill2");
            studentDictionary["Jack"] = new Student("Jack3");

            // Traversal 
            // for keys
            foreach(string key in studentDictionary.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine();

            // for values 

            foreach(Student s in studentDictionary.Values)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine();
            
        }
    }
}
