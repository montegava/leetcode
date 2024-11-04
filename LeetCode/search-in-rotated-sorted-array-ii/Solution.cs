using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.search_in_rotated_sorted_array_ii
{
    public class Solution
    {
        public bool Search(int[] nums, int target)
        {
            var start = 0;
            var end = nums.Length - 1;

            while (start <= end)
            {
                var mid = (end - start) / 2;
                if (nums[mid] == target)
                    return true;
                // case 1: we can not undestand which part is sortered
                if (nums[start] == nums[mid])
                {
                    start++;
                    continue;
                }

                // case 2: sortered is left
                if (nums[start] < nums[mid])
                {
                    if (nums[start] <= target && nums[mid] >= target)
                        end = mid - 1;
                    else
                        start = mid + 1;

                    continue;
                }

                // case 2: sortered is right
                if (nums[start] > nums[mid])
                {
                    if (nums[start] >= target && nums[mid] <= target)
                        start = mid + 1;
                    else
                        end = mid - 1;
                    continue;
                }

            }


            return false;
        }



    }


    public class Solution234
    {
        public int[] SortByBits(int[] arr)
        {

            var bits = new (int count, int val)[arr.Length];
            for (var i = 0; i < arr.Length; i++)
            {
                var bit = Convert.ToString(arr[i], 2);
                var count = 0;
                for (var j = 0; j < bit.Length; j++)
                {
                    if (bit[j] == '1')
                        count++;
                }
                bits[i] = (count, arr[i]);
            }

            Array.Sort(bits, (x, y) =>
            {
                //if (x.count == x.count)
                //{
                //    return x.val - y.val;
                //}
                var res = x.count- y.count;

                if (res == 0)
                {
                    res = x.val - y.val;
                }

                return res;
            });

            var res = new int[arr.Length];
            for (var i = 0; i < arr.Length; i++)
            {
                 res[i] = bits[i].val;
            }


            return res;

        }
    }

 
}
