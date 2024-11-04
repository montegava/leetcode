
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.common;

namespace Week1.construct_binary_tree_from_preorder_and_inorder_traversal
{
    public class Solution
    {
        private Dictionary<int,int> hash = new Dictionary<int, int>();
        private int preoderIndex = 0;

        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            for (int i = 0; i < inorder.Length; i++)
            {
                hash[inorder[i]] = i;
            }

            return Build(preorder, 0, preorder.Length - 1);
        }

        private TreeNode Build(int[] preorder, int pleft, int pright)
        {
            if (pleft > pright)
            {
                return null;
            }

            var rval = preorder[preoderIndex];
            var n = new TreeNode(rval);
            var rootIndex = hash[rval];
            preoderIndex++;

            n.left = Build(preorder, pleft, rootIndex-1);
            n.right = Build(preorder, rootIndex+1, pright);

            return n;
        }

 
    }
}
