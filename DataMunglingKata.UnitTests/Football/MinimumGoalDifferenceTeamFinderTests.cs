using System.Collections.Generic;
using DataMunglingKata.Football;
using DataMunglingKata.Football.Interfaces;
using DataMunglingKata.Football.Model;
using Moq;
using Xunit;

namespace DataMunglingKata.UnitTests.Football
{
    public class MinimumGoalDifferenceTeamFinderTests
    {
        [Fact]
        public void GivenOneTeamCalculateCorrectData()
        {
            var teamDataProvider = new Mock<ITeamDataProvider>();
            teamDataProvider.Setup( m => m.GetTeamData() ).Returns(
                new List<TeamData>
                {
                    new TeamData( "Aston_Villa", 1, 0 )
                }
            );

            var sut = new MinimumGoalDifferenceTeamFinder( teamDataProvider.Object );
            var result = sut.FindTeam();

            Assert.Equal( "Aston_Villa", result );
        }

        [Fact]
        public void GivenMoreTeamsCalculateCorrectData()
        {
           
            var sut = new MinimumGoalDifferenceTeamFinder( new TeamDataProviderStub());
            var result = sut.FindTeam();

            Assert.Equal( "Liverpool", result );
        }
    }

    public class TeamDataProviderStub : ITeamDataProvider
    {
        public IEnumerable<TeamData> GetTeamData()
        {
            return new List<TeamData>
            {
                new TeamData( "Aston_Villa", 1, 0 ),
                new TeamData( "Liverpool", 1, 1 )
            };
        }
    }
}