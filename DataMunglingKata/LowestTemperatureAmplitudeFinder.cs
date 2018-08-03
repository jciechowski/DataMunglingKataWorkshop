using System.Collections.Generic;

namespace DataMunglingKata
{
    public class LowestTemperatureAmplitudeFinder
    {
        public int GetIndexOfLowestAmplitude()
        {
            var fileReader = new FileReader();
            var weatherDataParser = new WeatherDataParser();
            var temperatureReducer = new TemperatureReducer();

            var maxTemperatureColumn = new List<int>();
            var minTemperatureColumn = new List<int>();

            var file = fileReader.ReadFile();

            foreach (var line in file)
            {
                var parsedData = weatherDataParser.Parse(line);

                maxTemperatureColumn.Add(parsedData[1]);
                minTemperatureColumn.Add(parsedData[2]);
            }

            return temperatureReducer.ReduceWeatherData(maxTemperatureColumn.ToArray(),
                       minTemperatureColumn.ToArray()) + 1;
        }
    }
}