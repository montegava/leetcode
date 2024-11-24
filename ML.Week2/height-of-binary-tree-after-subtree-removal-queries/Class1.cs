using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ML.Common.common;
using Week1.common;

namespace Week2.height_of_binary_tree_after_subtree_removal_queries
{
    public class Solution
    {
        public int[] TreeQueries(TreeNode root, int[] queries)
        {

            var dic = new Dictionary<int, List<int>>();// lvl + depth
            var levels = new Dictionary<int, int>();  // item + lvl
            var depth = new Dictionary<int, int>(); // item + nested depth
            
            var maxLvl = 0;

            int dfs(TreeNode n, int lvl)
            {

                if (n == null)
                {
                    maxLvl = Math.Max(maxLvl, lvl - 1);
                    return lvl - 1;
                }

                levels[n.val] = lvl;


                var l = dfs(n.left, lvl + 1);
                var r = dfs(n.right, lvl + 1);


                dic[lvl] = dic.GetValueOrDefault(lvl, new List<int>());
                dic[lvl].Add(n.val);

                depth[n.val] = Math.Max(l, r) - lvl;

                return Math.Max(l, r);
            }


        
            
            var res = new int[queries.Length];

            var max = dfs(root, 0);

            var rem = new Dictionary<int, int>();// item depth after remove

            for (int lvl = 0; lvl <= max; lvl++)
            {
                var nodes = dic[lvl];
                if (nodes.Count == 1)
                {
                    rem[nodes[0]] = lvl - 1;
                }
                else
                {
                    var mx = 0;
                    for (int j = 0; j < nodes.Count; j++)
                    {
                  
                            mx = Math.Max(mx, depth[nodes[j]]);
                    }
                }
            }


            for (int i = 0; i < queries.Length; i++)
            {
                var lvl = levels[queries[i]];
                var nodes = dic[lvl];
                var mx = 0;
                if (nodes.Count == 1)
                {
                    res[i] = lvl - 1;
                    continue;
                }


                for (int j = 0; j < nodes.Count; j++)
                {
                    if (nodes[j] != queries[i])
                        mx = Math.Max(mx, depth[nodes[j]]);
                }



                res[i] =lvl+ mx;
 
            }

            return res.ToArray();
        }
    }
}
