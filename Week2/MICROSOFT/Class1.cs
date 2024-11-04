using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.MICROSOFT
{
    public class Solution
    {
        public void SetZeroes(int[][] matrix)
        {
            // [0, 1, 2, 0],
            // [3, 4, 5, 2],
            // [1, 3, 1, 5]

            // 0,0  0,4
            var n = matrix.Length;
            var m = matrix[0].Length;
            var isCol = false;
            print();

            for (var i = 0; i < n; i++)
            {
                isCol = isCol || matrix[i][0] == 0;
                for (var j = 0; j < m; j++)
                {
                    if (matrix[i][j] == 0)
                    {

                        matrix[i][0] = 0;
                        matrix[0][j] = j != 0 ? 0 : matrix[0][j];
                    }
                }
            }

            print("afte oooo");

            for (var i = 1; i < n; i++)
                for (var j = 1; j < m; j++)
                    matrix[i][j] = matrix[i][0] == 0 || matrix[0][j] == 0 ? 0 : matrix[i][j];

            if (matrix[0][0] == 0)
                for (var j = 0; j < m; j++)
                    matrix[0][j] = 0;

            print("before iscol");

            if (isCol)

                for (int i = 0; i < n; i++)
                    matrix[i][0] = 0;

            print("final");


            void print(string s1 = null)
            {
                if (!string.IsNullOrEmpty(s1))
                    Console.WriteLine(s1);
                var s = new StringBuilder();
                for (var i = 0; i < n; i++)
                    for (var j = 0; j < m; j++)
                    {
                        var d = matrix[i][j];
                        var d1 = d.ToString();
                        if (d == int.MaxValue) d1 = "x";
                        if (d == int.MinValue) d1 = "-x";
                        s.Append(d1).Append("\t");

                        if (j == m - 1)
                        {
                            Console.WriteLine(s.ToString());
                            s.Clear();
                        }


                    }

                Console.WriteLine();
            }

        }
    }
}
