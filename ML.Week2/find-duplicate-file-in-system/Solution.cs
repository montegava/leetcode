using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Week2.find_duplicate_file_in_system;

public class Solution2
{
    public IList<IList<string>> FindDuplicate(string[] paths)
    {

        var result = new List<IList<string>>();

        var dic = new Dictionary<string, List<string>>();

       
        for (int i = 0; i < paths.Length; i++)
        {
            var p = paths[i];

            var fi = p.Split(' ');
            var dir = fi[0];
            for (int j = 1; j < fi.Length; j++)
            {
                //1.txt(abcd)
                var f = fi[j].Split('(');

                var filePath = dir + "/" + f[0];
                var content = f[1].Substring(0, f[1].Length - 1);

                if (!dic.ContainsKey(content))
                {
                    dic[content] = new List<string>();
                }

                dic[content].Add(filePath);
            }
        }

        foreach (var d in dic)
        {
            if (d.Value.Count > 1)
              result.Add(d.Value);
        }


        return result;
    }
}

