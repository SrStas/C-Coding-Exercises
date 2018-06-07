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

            ListNode rooList1;
            ListNode rooList2;

            //ListNode list1 = new ListNode(2);
            ////    .next = new ListNode(4).next = new ListNode(3);
            //ListNode list2 = new ListNode(5);
            ////.next = new ListNode(6).next = new ListNode(4);

            //rooList1 = list1;
            //    list1.next = new ListNode(4);
            //list1 = list1.next;
            //list1.next = new ListNode(3);

            //rooList2 = list2;
            //list2.next = new ListNode(6);
            //list2 = list2.next;
            //list2.next = new ListNode(4);

            ListNode list1 = new ListNode(9);
            //    .next = new ListNode(4).next = new ListNode(3);
            ListNode list2 = new ListNode(0);
            //.next = new ListNode(6).next = new ListNode(4);

            rooList1 = list1;
            list1.next = new ListNode(1);
            list1 = list1.next;
            list1.next = new ListNode(6);

            rooList2 = list2;
            


            var sum =runner.sum(rooList1, rooList2);
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
