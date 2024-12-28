using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ML.Week5.search_a_2d_matrix_ii
{
    public class Solution
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            if (matrix == null || matrix.Length == 0 || matrix[0].Length == 0)
                return false;

            bool dfs(int top, int left, int down, int right)
            {
                if (top > down || left > right)
                    return false;

                if (target < matrix[top][left] || target > matrix[down][right])
                    return false;


                var midCol = left +  (right - left) / 2;

                var midRow = top;

                while (midRow <= down &&   matrix[midRow][midCol] <= target)
                {
                    if (matrix[midRow][midCol] == target)
                        return true;
                    midRow++;
                }

                return dfs(midRow, left, down, midCol - 1) || dfs(top, midCol + 1, midRow - 1, right);

            }

            return dfs(0, 0, matrix.Length - 1, matrix[0].Length - 1);
        }
    }
}
