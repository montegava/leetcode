using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Microsoft
{
    public class Solution198
    {
        public int Rob(int[] nums)
        {
            var dic = new Dictionary<int, int>();

            int dfs(int i)
            {
                if (dic.ContainsKey(i))
                    return dic[i];

                if (i >= nums.Length)
                    return 0;

                return Math.Max(dfs(i + 1), dfs(i + 2) + nums[i]);
            }

            return dfs(0);
        }
    }
}
