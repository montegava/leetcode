using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.common;

namespace Week1.construct_binary_tree_from_preorder_and_inorder_traversal
{
    public class BstIterator
    {
        private List<int> sorted = new List<int>();
        private int index = 0;
        public BstIterator(TreeNode root)
        {
            void dfs(TreeNode n)
            {
                if (n == null)
                {
                    return;
                }
                dfs(n.left);
                sorted.Add(n.val);
                dfs(n.right);
            }

            dfs(root);
        }

        public int Next()
        {
            var result  =  sorted[index];
            Console.Write(result + ", ");
            index++;
            return result;
        }

        public bool HasNext()
        {
            var result = index  <  sorted.Count;
            Console.Write(result + ", ");
            return result;
        }
    }
}
