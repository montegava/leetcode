using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.restore_ip_addresses
{
    public class Solution
    {
        public IList<string> RestoreIpAddresses(string s)
        {
            // 25525511135
            var res = new List<string>();
            if (s == null || s.Length < 4 || s.Length > 3 * 4)
                return res;

            for (var a = 1; a <= s.Length - 3; a++)
                for (var b = a + 1; b <= s.Length - 2; b++)
                    for (var c = b + 1; c <= s.Length - 1; c++)
                    {
                        //1010.23

                        if (a == 1 && b == 2 && c == 4)
                        {
                            var ddd = 1;
                        }


                        if (valid(c, s.Length - c) && valid(b, c - b) && valid(a, b - a) && valid(0, a))
                            res.Add(build(a, b, c));
                    }

            string build(params int[] dots)
            {
                var sb = new StringBuilder();
                // 25525511135
                // 3 6 8
                // 255 255 11 135

                var prev = 0;
                foreach (var dot in dots)
                {
                    sb.Append(s.Substring(prev, dot - prev)).Append(".");
                    prev = dot;
                }

                sb.Append(s.Substring(prev, s.Length - prev));

                return sb.ToString();
            }


            bool valid(int start, int len)
            {
                if (start + len > s.Length)
                {
                    return false;
                }

                if (s[start] == '0')
                {
                    return len == 1;
                }

                if (len == 2 || len == 1)
                {
                    return true;
                }

                if (len == 3)
                {
                    return int.Parse(s.Substring(start, len)) <= 255;
                }

                return false;
            }


            dfs(0, new List<int>());


            void dfs(int start, List<int> dots)
            {
                if (dots.Count == 3)
                {
                    if (valid(start, s.Length - start))
                    {
                        res.Add(build(dots.ToArray()));
                        return;
                    }
                }

                for (int i = 1; i <= 3; i++)
                {
                    dots.Add(start);

                    if (valid(start, i))
                    {
                        dfs(start + i, dots);
                    }

                    dots.Remove(dots.Last());
                }


            }







            return res;
        }
    }
}
