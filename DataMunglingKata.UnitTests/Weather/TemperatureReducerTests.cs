using DataMunglingKata.Weather;
using Xunit;

namespace DataMunglingKata.UnitTests.Weather
{
    public class TemperatureReducerTests
    {
        [Theory]
        [InlineData(new[] {1, 2, 3, 4, 5}, new[] {2, 8, 3, 0, 0}, 2)]
        [InlineData(new[] {1, 2, 3}, new[] {2, 5, 8}, 0)]
        public void ShouldReturn_LowestDifference(int[] maxTempColumn, int[] minColumnData, int expected)
        {
            var sut = new TemperatureReducer();
            var result = sut.ReduceWeatherData(maxTempColumn, minColumnData);

            Assert.Equal(expected, result);
        }
    }
}