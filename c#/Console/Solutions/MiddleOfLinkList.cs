using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{    
    public static class MiddleOfLinkList
    {
        public static ListNode Solution(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while(fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            return slow;
        }
    }
}

 
