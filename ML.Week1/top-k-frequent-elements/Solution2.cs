namespace Week1.top_k_frequent_elements;

public class Solution2
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        // [1,2,2,3,1,1]

        //val, cou 
        var pq = new PriorityQueue<int, int>();
        var s = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            var val = nums[i];
            s[val] = s.GetValueOrDefault(val) + 1;
        }

        foreach (var p in s)
        {
            pq.Enqueue(p.Key, p.Value);

            if (pq.Count > k)
            {
                pq.Dequeue();

            }


        }


        var result = new int[k];
        for (var index = k - 1; index >= 0; index--)
        {
            result[index] = pq.Dequeue();
        }


        return result;


    }


}