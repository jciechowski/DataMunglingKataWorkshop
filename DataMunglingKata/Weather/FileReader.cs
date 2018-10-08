using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DataMunglingKata.Weather
{
    public class FileReader
    {
        public IEnumerable<string> ReadFile()
        {
            var file = File.ReadAllLines("weather/weather.dat");

            return file.Skip(2).SkipLast(1).Select(line => line.TrimStart().Substring(0, 12));
        }
    }
}