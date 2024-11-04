using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.top_k_frequent_elements
{
    public class Solution
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            // [1,1,1,2,2,3]
            var s = new Dictionary<int, int>();
            int i;
            for (i = 0; i < nums.Length; i++)
            {
                var val = nums[i];
                s[val] = s.GetValueOrDefault(val) + 1;
            }

            // [3] = 1  
            // [1] = 3
            // [2] = 2 
            var sorted = s.OrderByDescending(x => x.Value);

            var result = new int[k];
            i = 0;
            foreach (var pair in sorted)
            {
                result[i] = pair.Key;
                i++;
                if (i >= k)
                {
                    break;
                }
            }


            return result;


        }


    }
}
