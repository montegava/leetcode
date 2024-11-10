using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.common;

namespace ML.Microsoft
{
    public class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            // 
            var res = new Queue<ListNode>();

            var c = 0;
            var node = head;
       

            // 1 2 3 4 5 6 7    
            // 3
            //       4 {5} 6 7    

            while (node != null)
            {
                res.Enqueue(node);
                if (res.Count > n  + 1)
                    res.Dequeue();
            }
            var prev =res.Count  == n+1 ?  res.Dequeue() : null;
            var todelete = res.Dequeue();
            var next = todelete.next;

            if (prev == null)
                return next;

            if (next == null)
            {
                prev.next = null;
                return head;
            }

            prev.next = next;
            return head;
        }
    }
}
