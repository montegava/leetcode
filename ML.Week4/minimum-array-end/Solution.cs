using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ML.Week4.minimum_array_end
{
    public class Solution
    {
        public long MinEnd(int n, int x)
        {
            // x  = 10010111   === 151
            // ni = 1xx1x111   
            // n0 = 10010111 = 000 === 151
            long result = x;

            for (int i = 1; i < n; i++)
            {
                result = (result + 1) | x; // === 152 = 10011000    152 OR x = next min
            }

            return result;
        }
    }
}
