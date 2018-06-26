using System;
using System.Linq;

namespace DataMunglingKata.UnitTests
{
    public class WeatherDataParser
    {
        public int[] Parse(string testData)
        {
            return testData.Split(new string[]{" ", "*"}, StringSplitOptions.RemoveEmptyEntries)
                .Select(s =>
                {
                    Int32.TryParse(s, out int r);
                    return r;
                })
                .ToArray();
        }
    }
}