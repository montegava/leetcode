using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Result
{

    /*
     * Complete the 'maximumProfit' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts INTEGER_ARRAY price as parameter.
     */

    public static long maximumProfit(List<int> prices)
    {
        var dp = new long[prices.Count][];
        for (int i = 0; i < dp.Length; i++)
        {
            dp[i] = new long[2];
            dp[i][0] = -1;
            dp[i][1] = -1;
        }

        long MaxProfitUtil(int index, int buy, List<int> prices, long[][] dp)
        {
            if (index >= prices.Count) return 0;

            if (dp[index][buy] != -1) return dp[index][buy];

            if (buy == 1)
            {
                return dp[index][buy] = Math.Max(-prices[index] + MaxProfitUtil(index + 1, 0, prices, dp),
                    0 + MaxProfitUtil(index + 1, 1, prices, dp));
            }

            return dp[index][buy] = Math.Max(prices[index] + MaxProfitUtil(index + 2, 1, prices, dp),
                0 + MaxProfitUtil(index + 1, 0, prices, dp));
        }

        return MaxProfitUtil(0, 1, prices, dp);
    }

}

class Solution
{
    public static async Task Main(string[] args)
    {
            return;
    }
}
