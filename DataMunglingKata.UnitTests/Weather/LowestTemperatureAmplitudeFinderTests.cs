using DataMunglingKata.Weather;
using Xunit;

namespace DataMunglingKata.UnitTests.Weather
{
    public class LowestTemperatureAmplitudeFinderTests
    {
        [Fact]
        public void ShouldGiveLowestAmplitude()
        {
            var sut = new LowestTemperatureAmplitudeFinder();

            var result = sut.GetIndexOfLowestAmplitude();

            Assert.Equal(14, result);
        }
    }
}