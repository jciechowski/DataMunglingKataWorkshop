using System.Collections.Generic;
using DataMunglingKata.Football;
using DataMunglingKata.Football.Model;
using Xunit;

namespace DataMunglingKata.UnitTests.Football
{
    public class FileParserTests
    {
        [Fact]
        public void ShouldParseDataInExpectedFormat()
        {
            var sut = new FileParser();

            var result = sut.ParseRawContent(
                new[]
                {
                    @"       Team            P     W    L   D    F      A     Pts",
                    @"1. Arsenal         38    26   9   3    79  -  36    87",
                    @"2. Liverpool       38    24   8   6    67  -  30    80",
                    @"3. Manchester_U    38    24   5   9    87  -  45    77",
                    @"-------------------------------------------------------",
                    @"18. Ipswich         38     9   9  20    41  -  64    36"
                }
            );
            var expected = new List<TeamData>
            {
                new TeamData("Arsenal", 79, 36),
                new TeamData("Liverpool", 67, 30),
                new TeamData("Manchester_U", 87, 45),
                new TeamData("Ipswich", 41, 64)
            };

            Assert.Equal(expected, result);
        }
    }
}