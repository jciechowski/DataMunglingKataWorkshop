using System;

namespace DataMunglingKata
{
    public class TemperatureReducer
    {
        public int ReduceWeatherData(int[] maxTempColumn, int[] minTempColumn)
        {
            var minimalDifference = int.MaxValue;
            var indexOfMinimalDifference = 0;

            for (var i = 0; i < maxTempColumn.Length; i++)
            {
                var difference = Math.Abs(maxTempColumn[i] - minTempColumn[i]);
                if (difference < minimalDifference)
                {
                    minimalDifference = difference;
                    indexOfMinimalDifference = i;
                }
            }
             
            return indexOfMinimalDifference;
        }
    }
}
