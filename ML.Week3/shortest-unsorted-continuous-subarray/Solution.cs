using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Week3.shortest_unsorted_continuous_subarray
{
    public class Solution
    {
        public int FindUnsortedSubarray(int[] nums)
        {
            // 3,1,2
            // 2,6,4,8,1,9,15
            // s
            //         e
            // sort
            // 

            var desc = true;
            var ask = true;
            for (int i = 1; i < nums.Length; i++)
            {
                desc = desc && nums[i] < nums[i - 1];
                ask = ask && nums[i] > nums[i - 1];
            }

            if (ask)
                return 0;

            if (desc)
                return nums.Length;

            // 1,3,2,4,5

            var s = 0;
            var e = 1;
            var max = nums.Length;
            var sorted = true;
            while (s <= e && s < nums.Length && e < nums.Length)
            {
                if (nums[s] > nums[e])
                {
                    max = Math.Min(max, e - s - 1);
                    s++;
                    e = s + 1;
                }
                else
                {
                    sorted = sorted &&  nums[e] > nums[e - 1];
                    e++;

                    if (e == nums.Length && !sorted) 
                      max = Math.Min(max, e - s - 2);

                }
            }

            

            return max;
        }
    }
}
