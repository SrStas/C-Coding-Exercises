using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StereotypicalCoding
{
    class Program
    {
        public class LinkedListWithInit<T> : LinkedList<T>
        {
            public void Add(T item)
            {
                ((ICollection<T>)this).Add(item);
            }
        }

        
        static void Main(string[] args)
        {
            AddTwoNumbersLinkedList runner = new AddTwoNumbersLinkedList();
            LinkedList<int> list1 = new LinkedListWithInit<int> { 2, 4, 3 };
            LinkedList<int> list2 = new LinkedListWithInit<int> { 5, 6, 4 };

            var sum =runner.sum(list1, list2);
            //ValidParentheses runner = new ValidParentheses();
            //string inString = "([()[]({{}})[{}]])";
            //if (!(inString.Length % 2 == 0))
            //{
            //    //return false;
            //}
            //var result = runner.run(inString);
            //if (result.Length != 0)
            //    Console.WriteLine("false");
            //else
            //    Console.WriteLine("true");

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
