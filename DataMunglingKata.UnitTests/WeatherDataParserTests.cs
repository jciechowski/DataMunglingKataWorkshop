using Xunit;

namespace DataMunglingKata.UnitTests
{
    public class WeatherDataParserTests
    {
        [Theory]
        [InlineData("1", new[] {1})]
        [InlineData("0", new[] {0})]
        [InlineData("1 2", new[] {1, 2})]
        [InlineData("12", new[] {12})]
        [InlineData("2343 32*", new[] {2343, 32})]
        [InlineData("1 2 3", new[] {1, 2, 3})]
        public void WeatherDataParse_ShouldConvertToInt(string input, int[] expected)
        {
            var sut = new WeatherDataParser();

            var result = sut.Parse(input);

            Assert.Equal(expected, result);
        }
    }
}