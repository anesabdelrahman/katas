﻿using System;

namespace Katas.Miscellaneous
{
    public class LinkedList
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public class Solution
        {
            public ListNode MiddleNode(ListNode head)
            {
                Console.WriteLine(head.val);
                return null;
            }
        }
    }
}
