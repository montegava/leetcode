using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Microsoft
{
    public class Solution443
    {
        public int Compress(char[] chars)
        {

            //"a","a","a","b","b","c","c","c"

            if (chars == null || chars.Length == 0)
                return 0;

            var len = 1;
            var group = chars[0];
            var start = 1;
            var end = chars.Length;
            while (start < end)
            {
                var c = chars[start];
                if (group == c)
                {

                    start++;
                    len++;
                }
                else
                {
                    group = c;

                    if (len == 1)
                        continue;

                    chars[start + 1] = Convert.ToChar(len);
                    // a3

                    for (int j = 0; j < len-2; j++)
                    {
                        chars[start + 2 + j] = chars[start + j + len];
                    }

                    start++;
                    end = end - start;
                }
            }

            return 1;
        }
    }
}
