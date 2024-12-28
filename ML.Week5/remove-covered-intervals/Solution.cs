using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Week5.remove_covered_intervals
{
    public class Solution
    {
        public int RemoveCoveredIntervals(int[][] intervals)
        {
            //[[1, 4],[3, 6],[2, 8]]

            // 1. sort by start array
            // [1] [2] [3]

            Array.Sort(intervals, (i1, i2) =>
            {
                if (i1[0] == i2[0])
                    return i1[1] - i2[1];
                return i1[0] - i2[0];
            });

            var result = intervals.Length;

            for (int i = 0; i < intervals.Length; i++)
            {
                var inter = intervals[i];

                var end = intervals[i][1];
                var j = i + 1;
                while ( j < intervals.Length && intervals[j][1] <= end )
                {
                    result--;
                    i = j;
                    j++;
                }
                
            }

            return result;
        }
    }
}
