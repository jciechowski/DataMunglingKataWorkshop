using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Xunit;
using Xunit.Sdk;

namespace DataMunglingKata.UnitTests
{
    public class TemperatureReducerTests
    {
        //[Fact]
        //public void ReadFileIsntEmpty()
        //{
        //    var sut = new Kata04();
        //    var result = sut.ReadFile();

        //    Assert.NotEmpty(result);
        //}
      
        [Theory]
        [InlineData(new [] {1,2,3,4,5}, new [] {2,8,3,0,0}, 2)]
        [InlineData(new [] {1,2,3}, new [] {2,5,8}, 0)]
        public void ShouldReturn_LowestDifference(int[] testData1, int[] testData2, int expected)
        {
            var sut = new TemperatureReducer();
            var result = sut.ReduceWeatherData(testData1, testData2);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("1", new []{1})]
        [InlineData("0", new []{0})]
        [InlineData("1 2", new []{1, 2})]
        [InlineData("12", new []{12})]
        [InlineData("2343 32*", new int[] {2343, 32})]
        public void WeatherDataParse_ShouldConvertToInt(string input, int[] expected)
        {
            var sut = new WeatherDataParser();
            var result = sut.Parse(input);
            
            Assert.Equal(expected, result);
        }
    }
}
