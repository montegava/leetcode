using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Week4.first_missing_positive
{
    public class Solution
    {
        public int FirstMissingPositive(int[] nums)
        {
            //3,4,-1,1

            var min = 0;
            var hash = new HashSet<int>();
            var max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                    hash.Add(nums[i]);

                min = Math.Min(nums[i], min);
                max = Math.Max(nums[i], max);
            }

            for (int i = 1; i <= max; i++)
            {
                if (!hash.Contains(nums[i]))
                    return i;
            }

            return max + 1;
        }
    }
}
