using System;
using DataMunglingKata.Football.Interfaces;

namespace DataMunglingKata.Football
{
    public class MinimumGoalDifferenceTeamFinder
    {
        private readonly ITeamDataProvider _teamDataProvider;

        public MinimumGoalDifferenceTeamFinder( ITeamDataProvider teamDataProvider )
        {
            _teamDataProvider = teamDataProvider;
        }

        public string FindTeam()
        {

            var teamResults = _teamDataProvider.GetTeamData();
            var teamName = "";
            var minGoalsDifference = 100;

            foreach ( var (name, goalsFor, goalsAgainst) in teamResults )
            {
                var currentDifference = Math.Abs( goalsFor - goalsAgainst );
                if (  currentDifference < minGoalsDifference )
                {
                    teamName = name;
                    minGoalsDifference = currentDifference;
                }

            }
            return teamName;
        }
    }
}