using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ML.Common.common;

namespace ML.Week4.populating_next_right_pointers_in_each_node
{
    public class Solution
    {
        public Node Connect(Node root)
        {
            if (root == null)
                return null;

            var s = new LinkedList<Node>();
      

            

            s.AddLast(root);

            while (s.Count > 0)
            {
                var c = s.Count;
                for (int i = 0; i < c; i++)
                {
                    var n = s.First;
                    if (n.Value.left != null)
                        s.AddLast(n.Value.left);
                    if (n.Value.right != null)
                        s.AddLast(n.Value.right);
                    s.RemoveFirst();
                }

                if (s.Count > 0)
                {
                    Node next = null;

                    var cur = s.Last;
                    while (cur?.Value != null)
                    {
                        cur.Value.next = next;
                        next = cur.Value;
                        cur = cur.Previous;
                    }
                }
            }


            return root;
        }
    }
}
