using System.Collections.Generic;
using DataMunglingKata.Football;
using Moq;
using Xunit;

namespace DataMunglingKata.UnitTests.Football
{
    public class MinimumGoalDifferenceTeamFinderTests
    {
        [Fact]
        public void GivenOneTeamCalculateCorrectData()
        {
            var fileReaderStub = new Mock<IFileParser>();
            fileReaderStub.Setup( m => m.GetTeamData() ).Returns(
                new List<(string teamName, int goalsFor, int goalsAgainst)>
                {
                    ( "Aston_Villa", 1, 0 )
                }
            );

            var sut = new MinimumGoalDifferenceTeamFinder(fileReaderStub.Object);
            var result = sut.FindTeam();

            Assert.Equal( "Aston_Villa", result );
        }

        [Fact]
        public void GivenMoreTeamsCalculateCorrectData()
        {
            var fileReaderStub = new Mock<IFileParser>();
            fileReaderStub.Setup( m => m.GetTeamData() ).Returns(
                new List<(string teamName, int goalsFor, int goalsAgainst)>
                {
                    ( "Aston_Villa", 1, 0 ),
                    ( "Liverpool", 1, 1 )
                }
            );

            var sut = new MinimumGoalDifferenceTeamFinder(fileReaderStub.Object);
            var result = sut.FindTeam();

            Assert.Equal( "Liverpool", result );
        }
    }
}