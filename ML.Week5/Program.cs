// See https://aka.ms/new-console-template for more information

using ML.Week5.search_a_2d_matrix_ii;using Solution = ML.Week5.remove_covered_intervals.Solution;


//Solution1.MaxProfit(new[] { 3, 4, 5, 3, 5, 2 });

//DateTime specificDateTime = new DateTime(2024, 11, 27, 10, 0, 0); // Example: 27 Nov 2024, 10:00 AM

//DateTimeOffset specificDateTimeWithOffset = new DateTimeOffset(specificDateTime, TimeSpan.FromHours(-8));


//var dif = specificDateTime - specificDateTimeWithOffset;


//var dic = new Dictionary<int, int>();




////var r = new Solution().SearchMatrix(new int[][]{ [1, 4, 7, 11, 15], [2, 5, 8, 12, 19], [3, 6, 9, 16, 22], [10, 13, 14, 17, 24], [18, 21, 23, 26, 30] }, 5);
//var r = new Solution().SearchMatrix(new int[][]{ [1, 4, 7, 11, 15], [2, 5, 8, 12, 19], [3, 6, 9, 16, 22], [10, 13, 14, 17, 24], [18, 21, 23, 26, 30] }, 20);

new Solution().RemoveCoveredIntervals(new int[][] { [1, 4], [3, 6], [2, 8] });

Console.WriteLine("Hello, World!");