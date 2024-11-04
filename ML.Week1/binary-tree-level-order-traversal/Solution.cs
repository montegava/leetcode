using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.common;

namespace Week1.binary_tree_level_order_traversal
{
    public class Solution
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var result = new List<IList<int>>();

            if (root == null)
                return result;

            void dfs(TreeNode n, int lvl)
            {
                if (n == null) 
                    return;
                if (result.Count <= lvl)
                    result.Add(new List<int>());
                var l = result[lvl]; 
                l.Add(n.val);
                dfs(n.left, lvl +1);
                dfs(n.right, lvl + 1);
            }
            dfs(root, 0);

            return result;
        }
    }
}
