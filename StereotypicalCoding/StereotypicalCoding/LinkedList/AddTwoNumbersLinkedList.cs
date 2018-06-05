using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace StereotypicalCoding
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
        }
    }
    class AddTwoNumbersLinkedList
    {
        public LinkedList<int> sum(LinkedList<int> inList1, LinkedList<int> inList2)
        {
            LinkedList<int> sumList = new LinkedList<int>();

            int length = inList1.Count > inList2.Count ? inList1.Count : inList2.Count;
            int tmpCarry = 0;
            for (int i = 0; i < length; i++)
            {
                int tmpSum = inList1.First.Value + inList2.First.Value + tmpCarry;
                tmpCarry = 0;
                if (tmpSum >= 10)
                {
                    tmpSum = tmpSum - 10;
                    tmpCarry = 1;

                }

                sumList.AddLast(tmpSum);
                inList1.RemoveFirst();
                inList2.RemoveFirst();
            }


            return sumList;

        }


        //Definition for singly-linked list.
        //public class ListNode {
        //    public int val;
        //    public ListNode next;
        //    public ListNode(int x) { val = x; }


        //public class Solution
        //{
        //    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        //    {
        //        ListNode tempListNode;
        //        int tmpSum = l1.val + l2.val;
                
        //        if (tmpSum >= 10)
        //        {
        //            tmpSum = tmpSum - 10;
        //            tempListNode = new ListNode(tmpSum);
        //            tempListNode.next = new ListNode(1);

        //        }
        //        else
        //        {
        //            tempListNode = new ListNode(tmpSum);
        //            tempListNode.next = new ListNode(0);
        //        }
                
        //    }
        //}
    }
}
