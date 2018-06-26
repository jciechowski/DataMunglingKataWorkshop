using System;

namespace DataMunglingKata
{
    public class TemperatureReducer
    {
        //public string ReadFile()
        //{
        //    return " ";
        //}

        public int ReduceWeatherData(int[] testData1, int[] testData2)
        {
            int minimalDifference = int.MaxValue;
            int indexOfMinimalDifference = 0;

            for (int i = 0; i < testData1.Length; i++)
            {
                var difference = Math.Abs(testData1[i] - testData2[i]);
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
