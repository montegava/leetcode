using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Week4.minimum_height_trees
{
    public class Solution
    {
        public IList<int> FindMinHeightTrees(int n, int[][] edges)
        {
            if (edges == null || n == 1)
                return new List<int>(){0};

            var dic = new Dictionary<int, List<int>>();

            foreach (var edge in edges)
            {
                dic[edge[0]] = dic.GetValueOrDefault(edge[0], new List<int>());
                dic[edge[0]].Add(edge[1]);
                dic[edge[1]] = dic.GetValueOrDefault(edge[1], new List<int>());
                dic[edge[1]].Add(edge[0]);
            }

            while (dic.Count > 2)
            {
                var rem = new List<int>();
                foreach (var d in dic)
                {
                    if (d.Value.Count == 1)
                    {
                        rem.Add(d.Key);
                    }              
                }

                foreach (var r in rem)
                {
                    var k1 = r;
                    var k2 = dic[k1][0];
                    dic.Remove(k1);
                    dic[k2].Remove(k1);
                }
            }

 

            return dic.Keys.ToList();
        }
    }
}
