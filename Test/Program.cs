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
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;



public class FoodOutletDto
{
    public string Name { get; set; }
    public float AverageRating { get; set; }
}

public class Datum
{
    [JsonProperty("city")]
    public string City { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("estimated_cost")]
    public int EstimatedCost { get; set; }

    [JsonProperty("user_rating")]
    public UserRating UserRating { get; set; }

    [JsonProperty("id")]
    public int Id { get; set; }
}

public class Root
{
    [JsonProperty("page")]
    public int Page { get; set; }

    [JsonProperty("per_page")]
    public int PerPage { get; set; }

    [JsonProperty("total")]
    public int Total { get; set; }

    [JsonProperty("total_pages")]
    public int TotalPages { get; set; }

    [JsonProperty("data")]
    public List<Datum> Data { get; set; }
}

public class UserRating
{
    [JsonProperty("average_rating")]
    public float AverageRating { get; set; }
}


class Result
{

    /*
     * Complete the 'getTopRatedFoodOutlets' function below.
     *
     * URL for cut and paste
     * https://jsonmock.hackerrank.com/api/food_outlets?city=<city>&page=<pageNumber>
     *
     * The function is expected to return an array of strings.
     * 
     * The function accepts only city argument (String).
     */

    private static string UrlPattern = "https://jsonmock.hackerrank.com/api/food_outlets?city={0}&page={1}";

    private static string BuildUrl(string city, int page) => string.Format(UrlPattern, city, page);

    public static List<string> GetTopRatedFoodOutletsAsync(string city)
    {
        var result = new List<string>();
        var maxRating = 0f;
        var currentPage = 1;
        var totalPages = 1f;


        var vovels   =      new HashSet<char>() { 'A', 'a', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u' };
        var stack = new Stack<char>();

        stack.Pop
        

        // TODO: the best practise to use httpclientfactory
        using (var httpClient = new HttpClient())
        {
            while (currentPage <=totalPages)
            {
                // TODO: retry policy + check error codes
                var response = await httpClient.GetStringAsync(BuildUrl(city, currentPage));
                var dto = JsonConvert.DeserializeObject<Root>(response);
                totalPages = dto.TotalPages;

                if (dto.Data != null && dto.Data.Any())
                {
                    foreach (var outlet in dto.Data)
                    {
                        var name = outlet.Name;
                        var rating = outlet.UserRating.AverageRating;

                        if (rating > maxRating)
                        {
                            maxRating = rating;
                            result.Clear();
                            result.Add(name);
                        }
                        else if (rating == maxRating)
                        {
                            result.Add(name);
                        }
                    }
                }

                currentPage++;
            }
        }

      

        return result;

    }

}

class Solution
{
    public static async Task Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string city = Console.ReadLine().Trim();

        List<string> result = Result.GetTopRatedFoodOutletsAsync(city);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}