using ML.Common.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Microsoft
{
    public class Solution113
    {
        public IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {
            var res = new List<IList<int>>();

            if (root == null)
                return res;


            void dfs(TreeNode n, List<int> path, int sum)
            {
                if (n == null)
                    return;

                path.Add(n.val);
                sum += n.val;

                if (n.left == null && n.right == null && sum == targetSum)
                {
                    res.Add(new List<int>(path));
                }
                else
                {
                    dfs(n.left, path, sum);
                    dfs(n.right, path, sum);
                }

                path.RemoveAt(path.Count - 1);
            }

            dfs(root, new List<int>(), 0);

            return res;
        }
    }
}
