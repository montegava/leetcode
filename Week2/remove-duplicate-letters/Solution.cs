using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.remove_duplicate_letters
{
    public class Solution
    {
        public string RemoveDuplicateLetters(string s)
        {
            var seen = new HashSet<char>();
            var result = new Stack<char>();
            var latest = new Dictionary<char, int>();

            for (var i = 0; i < s.Length; i++)
                latest[s[i]] = i;

            for (var i = 0; i < s.Length; i++)
            {
                var c = s[i];
                if (!seen.Contains(c))
                {
                    while (result.Count > 0 && c < result.Peek() && latest[result.Peek()] > i)
                    {
                        seen.Remove(result.Pop());
              
                    }

                    result.Push(c);
                    seen.Add(c);
                }
            }

            var r = "";

            while (result.Count > 0)
            {
                r = result.Pop() + r;
            }

            return r;
        }
    }
}
