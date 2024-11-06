using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.common;

namespace ML.Week3.maximum_width_of_binary_tree
{
    public class Solution
    {
        public int WidthOfBinaryTree(TreeNode root)
        {
            if (root == null)
                return 0;

          

    

            var max  = 1;
            var q = new Queue<(TreeNode node, int index)>();

            q.Enqueue((root, 0));
            while (q.Count > 0)
            {
                var first = 0;
                var cnt = q.Count;
                var last = 0;

                for (int i = 0; i < cnt; i++)
                {
                   var n = q.Dequeue();
                   var index = n.index;

                   if (i == 0)
                       first = n.index;

                   if (i == cnt - 1)
                       last = n.index;

                    if (n.node.left is not null)
                        q.Enqueue((n.node.left, 2 * index));

                    if (n.node.right is not null)
                        q.Enqueue((n.node.right, 2 * index + 1));
                }

                max = Math.Max(max, last - first + 1);
            }

            return max;
        }
    }
}
