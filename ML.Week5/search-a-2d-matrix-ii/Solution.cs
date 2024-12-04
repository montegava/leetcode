using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Week5.search_a_2d_matrix_ii
{
    public class Solution
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            var cols = matrix.Length;
            var rows = matrix[0].Length;


            var fromi = 0;
            var toi = cols - 1;

            var fromj = 0;
            var toj = rows - 1;


            var midi = (toi - fromi) / 2;
            var midj = (toj - fromj) / 2;
            
          

            bool dfs(int i, int j)
            {
                if (i >= cols || j >= rows || i < 0 || j < 0 || i >j )
                    return false;

                if (matrix[i][j] == target)
                    return true;

                if (matrix[i][j] > target)
                {
                    fromi = fromi;
                    toi = i;
                    fromj = fromj;
                    toj = j;
                    midi = toi - fromi > 1 ? (toi - fromi) / 2 + i : i - 1;
                    midj = toj - fromj > 1 ? (toj - fromj) / 2 + j : j - 1;

                    return dfs(midi, midj);
                }

                fromi = i;
                toi = toi;
                fromj = j;
                toj = toj;
                midi = toi - fromi > 1 ? (toi - fromi) / 2  + i : i + 1;
                midj = toj - fromj > 1 ? (toj - fromj) / 2 + j : j + 1;
                return dfs(midi, midj);
            }

            return dfs(midj,midj);
        }
    }
}
