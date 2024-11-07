using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Microsoft
{
    public class Solution
    {
        public double MyPow(double x, int n)
        {
            if (n < 0)
                return 1 / MyPow(x, -1 * n);

            if (n == 0)
                return 1;

            if (n == 1)
                return x;

            if (n == 2)
                return x * x;


            if (n % 2 == 0)
            {
                return MyPow(x * x, n / 2);
            }
            else
            {
                return x * MyPow(x * x, n / 2);
            }
        }
    }
}
