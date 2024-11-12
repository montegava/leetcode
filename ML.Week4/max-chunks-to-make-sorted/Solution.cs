using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Week4.max_chunks_to_make_sorted
{
    public class Solution
    {
        public int MaxChunksToSorted(int[] arr)
        {
            var result = 0;
            var max = int.MinValue;
            //1,0,2,3,4
            //1,1,2,3,4
            for (int i = 0; i < arr.Length; i++)
            {
                
                max = Math.Max(max, arr[i]);

                if (max == i)
                    result++;
            }

            return result;



        }
    }
}
