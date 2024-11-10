using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Week4.duplicate_zeros
{
    public class Solution
    {
        public int IntegerReplacement(int n)
        {
            //Input: n = 8
            //Output: 3
            //Explanation: 8-> 4-> 2-> 1
            var dic = new Dictionary<long, int>();
 
            int dfs(int r, int c)
            {
                var res = 0;

                if (dic.ContainsKey(r))
                    return dic[r];

                if (r == 1)
                    res = c;
                else if (r % 2 == 0)
                    res = dfs(r / 2, c + 1);
                else
                    res = Math.Min(dfs(r - 1, c + 1), dfs(r + 1, c + 1));

                dic[r] = res;
                return res;
            }

            return dfs(n,0);
        }
    }
}
