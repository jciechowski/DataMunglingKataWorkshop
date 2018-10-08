using System;
using System.Linq;

namespace DataMunglingKata.Weather
{
    public class WeatherDataParser
    {
        public int[] Parse(string testData)
        {
            return testData.Split(new []{" ", "*"}, StringSplitOptions.RemoveEmptyEntries)
                .Select(s =>
                {
                    int.TryParse(s, out var r);
                    return r;
                })
                .ToArray();
        }
    }
}