using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.random_pick_index
{
    public class Solution
    {
        private Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();
        private Random r = new Random();

        public Solution(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                var item = dic.GetValueOrDefault(nums[i]) ?? new List<int>();
                item.Add(i);
                dic[nums[i]] = item;
            }
        }

        public int Pick(int target)
        {
            var list = dic[target];

            var index = r.Next(0, list.Count);

            return list[index];
        }
    }


    public class Solution33
    {
        public int MinMeetingRooms(int[][] intervals)
        {

            Array.Sort(intervals, (a, b) => a[0] > b[0] ? 1 : -1);

            var pq = new PriorityQueue<int, int>();
            for (int i = 0; i < intervals.Length; i++)
            {
                var n = intervals[i];

                if (pq.Count > 0 && pq.Peek() < n[0])
                {
                    pq.Dequeue();
                }

                pq.Enqueue(n[1], n[1]);
            }

            return pq.Count;


        }
    }

    public class Solution444
    {
        public int NumIslands(char[][] grid)
        {
            var rows = grid.GetLength(0);
            var cols = grid.GetLength(1);

            var count = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        count++;
                        dfs(i, j);
                    }
                }
            }


            void dfs(int i, int j)
            {
                if (grid[i][j] == '1')
                {
                    grid[i][j] = '0';
                    if (i > 0)
                    {
                        //check top
                        dfs(i - 1, j);
                    }
                    if (j > 0)
                    {
                        //check left
                        dfs(i, j - 1);
                    }
                    if (j + 1 < cols)
                    {
                        //check right
                        dfs(i, j + 1);
                    }
                    if (i + 1 < rows)
                    {
                        //check bottom
                        dfs(i + 1, j);
                    }
                }

            }

            return count;
        }
    }
}
