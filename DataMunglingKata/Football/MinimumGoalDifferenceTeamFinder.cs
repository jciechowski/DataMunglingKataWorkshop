using System;

namespace DataMunglingKata.Football
{
    public class MinimumGoalDifferenceTeamFinder
    {
        private readonly IFileParser _ifIleParser;

        public MinimumGoalDifferenceTeamFinder( IFileParser ifIleParser )
        {
            _ifIleParser = ifIleParser;
        }

        public string FindTeam()
        {

            var teamResults = _ifIleParser.GetTeamData();
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