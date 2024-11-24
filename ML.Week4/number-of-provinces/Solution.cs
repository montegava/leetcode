using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Week4.number_of_provinces
{
    public class Solution
    {
        public int FindCircleNum(int[][] isConnected)
        {
            var res = 0;
            
            var rows = isConnected.Length;
            
            var cols = isConnected[0].Length;

            var seen = new HashSet<int>();

            for (int i = 0; i < rows; i++)
            {
                if (seen.Contains(i))
                    continue;

                res++;
                
                dfs(i);
            }


            void dfs(int i)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (isConnected[i][j] == 1 && !seen.Contains(j))
                    {
                        seen.Add(j);
                        dfs(j);
                    }
                }
            }

            return res;
        }
    }
}
