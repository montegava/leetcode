namespace ML.Week5.search_a_2d_matrix_ii;

public class Solution1
{
    public int LengthOfLongestSubstringTwoDistinct(string s)
    {
        var res = 0;

        if (string.IsNullOrEmpty(s))
            return 0;

        var start = 0;
        var end = 0;
        // e e c c b e b a
        //     s
        //         e            

        var dic = new Dictionary<char, int>(); // char + right most position
        while (start <= end && end < s.Length)
        {
            dic[s[end]] = end;
            start++;

            if (dic.Count == 3)
            {
                // e1 c3 b4
                // to delete e + move to 1+1 = 2
                var toDeleteIndex = dic.Values.Min();
                dic.Remove(s[toDeleteIndex]);
                start = toDeleteIndex + 1;
            }

            res = Math.Min(res, end - start);
        }

        return res;
    }



  public   static int MaxProfit(int[] prices)
    {
        // 3 4 5 3 5 2
        //         _ 

        int maxPriceSoFar = 0;
        int maxProfit = 0;

        // Traverse prices from the end to the beginning
        for (int i = prices.Length - 1; i >= 0; i--)
        {
            // Update the maximum price encountered so far
            if (prices[i] > maxPriceSoFar)
            {
                maxPriceSoFar = prices[i];
            }

            // Calculate the potential profit
            maxProfit += Math.Max(0, maxPriceSoFar - prices[i]);
        }

        return maxProfit;
    }
}