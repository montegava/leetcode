using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.common;

namespace Week2.cousins_in_binary_tree_ii
{
    public class Solution
    {
        public TreeNode ReplaceValueInTree(TreeNode root)
        {
            var sums = new Dictionary<int, int>();// sum of levels .. lvl, sum

            var seen = new HashSet<TreeNode>();

            void dfsSum(TreeNode n, int lvl)
            {
                if (n == null)
                    return;

                sums[lvl] = sums.GetValueOrDefault(lvl, 0) + n.val;

                dfsSum(n.left, lvl + 1);
                dfsSum(n.right, lvl + 1);
            }


            dfsSum(root, 0);

            void dfs(TreeNode n, TreeNode parent, int lvl)
            {
                if (n == null)
                    return;

                if (lvl <= 1)
                {
                    n.val = 0;
                }
                else {
                    if (!seen.Contains(parent))
                    {
                        var s = sums[lvl] - (parent.left?.val ?? 0) - (parent.right?.val ?? 0);

                        if (parent.left != null)
                            parent.left.val = s;
                        if (parent.right != null)
                            parent.right.val = s;
                        seen.Add(parent);
                    }
                }
                var has = new Dictionary<int,int>();
          
                

                dfs(n.left, n, lvl + 1);
                dfs(n.right, n,  lvl + 1);
            }

            dfs(root, null, 0);

            return root;
        }
    }
}
