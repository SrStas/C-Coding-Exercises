using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StereotypicalCoding
{
    class Program
    {
        static void Main(string[] args)
        {

            TwoSum();
            

            Console.WriteLine("Done!");
            Console.ReadKey();
        }

        public static void LinkedList()
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



            var sum = runner.sum(rooList1, rooList2);
        }

        public static void Find()
        {
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
        }

        public static void TwoSum()
        {
            TwoSum runner = new TwoSum();

            //int[] nums = new[] {2, 7, 11, 15};
            //int target = 9;
            int[] nums = new[] { 3, 2, 4 };
            int target = 6;
            var val = runner.sum(nums, target);
        }

        public static void Reverse()
        {
            ReverseInteger run = new ReverseInteger();

            int num = -123;

            run.Reverse(num);
        }
    }
}
