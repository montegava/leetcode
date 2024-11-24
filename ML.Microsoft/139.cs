using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML.Microsoft
{
    public class Solution139
    {
        public bool WordBreak(string s, IList<string> wordDict)
        {
            // "leetcode", wordDict = ["leet","code"]
            var dic = new Dictionary<string, string>();
            foreach (var w in wordDict)
                dic[w] = w;
            // leet   code
            var check = "";

            bool dfs(string input)
            {
                if (string.IsNullOrEmpty(input))
                    return false;

                var sub = "" + input[0];
                var i = 0;

                while (!dic.ContainsKey(sub) && input.Length >  i)
                {
                    sub += input[i];
                    i++;
                }

                if (i > input.Length - 1)
                {
                    return false;
                }
                else if (i == input.Length - 1)
                {
                    return true;
                }
                else
                {
                    var s1 = input.Substring(sub.Length);
                    return dfs(s1);
                }
            }

            return dfs(s);
        }
    }
}
