using Xunit;

namespace DataMunglingKata.UnitTests
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