using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Week3.longest_increasing_subsequence
{
    public class Solution
    {
        public int LengthOfLIS(int[] nums)
        {
            // 10, 9, 2, 5, 3, 7, 101, 18
            //        s     e

            if (nums == null || nums.Length == 0)
                return 0;

            if (nums.Length == 1)
                return 1;

            var s = 0;
            var e = 1;
            var max = 1;
            var m = nums[s];

            while (s<e && e < nums.Length)
            {
                if (nums[e] < m)
                {
                    max = Math.Max(e - s, max);
                    s = e;
                    m = nums[s];
                    e++;
                }
                else
                {
                    m = Math.Max(m, nums[e]); // 5
                    e++;
                }


            }

            return max;

        }
    }
}
