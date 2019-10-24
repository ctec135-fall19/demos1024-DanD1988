using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_and_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //stacks 
            // declartion
            Stack<Student> stackOfStudents = new Stack<Student>();

            // push objects on to the stack 

            // creates a new student container
            stackOfStudents.Push(new Student("Danny"));
            stackOfStudents.Push(new Student("Jack"));
            stackOfStudents.Push(new Student("Jill"));

            // traversal 
            foreach (Student s in stackOfStudents)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine(stackOfStudents.Count); // counts items in container
            Console.WriteLine();

            // pops 
            // similar  to hw prob 2 what to do 
            int size = stackOfStudents.Count;
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(stackOfStudents.Pop().Name);
            }
            Console.WriteLine(stackOfStudents.Count); // counts items in container
            Console.WriteLine();

            // queue
            Queue<Student> studentQueue = new Queue<Student>();

            // put items into the queue aka students

            studentQueue.Enqueue(new Student("Danny"));
            studentQueue.Enqueue(new Student("Jack"));
            studentQueue.Enqueue(new Student("Jill"));

            // traversal 
            foreach (Student s in studentQueue)
            {
                Console.WriteLine(s.Name);
            }
            Console.WriteLine(studentQueue.Count);
            Console.WriteLine();

            size = studentQueue.Count;
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine(studentQueue.Dequeue().Name);
            }
            Console.WriteLine(studentQueue.Count);
            Console.WriteLine();
            // count goes back down to 0
        }
    }
}
