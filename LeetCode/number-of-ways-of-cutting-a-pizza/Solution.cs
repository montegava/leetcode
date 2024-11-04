using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.number_of_ways_of_cutting_a_pizza
{
    public class Solution
    {
        public int Ways(string[] pizza, int k)
        {
            //"A..","AA.","..."
            var m = new int[pizza.Length, pizza[0].Length];

            for (int r = 0; r < pizza.Length; r++)
            {
                for (int c = 0; c < pizza[r].Length; c++)
                {
                    m[r, c] = pizza[r][c] == '.' ? 0 : 1;
                }    
            }

            return 1;
        }

        private void horizontal(int row)
        {

        }

        private void vertical(int col)
        {

        }
    }
}
