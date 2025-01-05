using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Week5.least_number_of_unique_integers_after_k_removals
{
    public class Solution
    {
        public int FindLeastNumOfUniqueInts(int[] arr, int k)
        {
            // [4,3,1,1,3,3,2]
            // 4 - 1
            // 3 - 3
            // 1 - 2
            // 2 - 1

            // sort by count ... 2,4,1,3
            var dic = new Dictionary<int, int>();
            for (var i = 0; i < arr.Length; i++)
            {
                dic[arr[i]] = dic.GetValueOrDefault(arr[i], 0) + 1;
            }


            var ad = dic.ToArray();

            Array.Sort(ad, (x1, x2) => x1.Value - x2.Value);

            var result = ad.Length;

            var position = 0;
            while (k > 0 && position < ad.Length)
            {
                var count = ad[position].Value;
                if (count > k)
                    break;
                k -= count;
                position++;
                result--;
            }

            return result;
        }
    }
}
