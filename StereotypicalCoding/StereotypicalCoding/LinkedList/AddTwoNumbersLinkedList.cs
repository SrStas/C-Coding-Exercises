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
        public ListNode sum(ListNode l1, ListNode l2)
        {
            ListNode rootListNode = new ListNode(0);
            ListNode currentListNodeSum = rootListNode;

            ListNode currentListNodeL1 = l1;
            ListNode currentListNodeL2 = l2;

            while (!(currentListNodeL1 == null && currentListNodeL2 == null))
            {
                if (currentListNodeSum == null)
                {
                    currentListNodeSum = new ListNode(0);
                }

                int firsVal = currentListNodeL1 == null ? 0 : currentListNodeL1.val;
                int secondVal = currentListNodeL2 == null ? 0 : currentListNodeL2.val;
                int sum = firsVal + secondVal  + (currentListNodeSum == null? 0: currentListNodeSum.val);
                int cry = sum / 10;
                sum = sum % 10;
                currentListNodeL2 = currentListNodeL2 == null ? null : currentListNodeL2.next;
                currentListNodeL1 = currentListNodeL1 == null ? null : currentListNodeL1.next;
                currentListNodeSum.val = sum;
                if (cry>0)
                {
                    
                    currentListNodeSum.next = new ListNode(cry);
                }

                if (currentListNodeL1 != null || currentListNodeL2 !=null)
                {
                    currentListNodeSum.next = new ListNode(cry);
                }
                currentListNodeSum = currentListNodeSum.next;

            }
            
            return rootListNode;

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
