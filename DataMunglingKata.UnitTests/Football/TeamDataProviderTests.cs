using System.Collections.Generic;
using DataMunglingKata.Football;
using DataMunglingKata.Football.Interfaces;
using DataMunglingKata.Football.Model;
using Moq;
using Xunit;

namespace DataMunglingKata.UnitTests.Football
{
    public class TeamDataProviderTests
    {
        [Fact]
        public void ShouldReturnParsedData()
        {
            var fileReaderStub = new Mock<IFileReader>();

            var subject = new TeamDataProvider( fileReaderStub.Object, new FileParserStub() );

            var result = subject.GetTeamData();

            Assert.NotEmpty( result );
        }
    }

    public class FileParserStub : IFileParser
    {
        public IEnumerable<TeamData> ParseRawContent( IEnumerable<string> rawContent )
        {
            return new List<TeamData>
            {
                new TeamData("Lechia Gdansk", 1, 0),
                new TeamData("Arka Gdynia", 0, 1)
            };
        }
    }
}