using System.Diagnostics;

namespace DataMunglingKata.Football.Model
{
    public struct TeamData
    {
        public int GoalsFor { get; }
        public int GoalsAgainst { get; }
        public string TeamName { get; }

        public TeamData( string teamName, int goalsFor, int goalsAgainst )
        {
            GoalsFor = goalsFor;
            GoalsAgainst = goalsAgainst;
            TeamName = teamName;
        }

        public void Deconstruct( out string teamName, out int goalsFor, out int goalsAgainst )
        {
            goalsFor = GoalsFor;
            goalsAgainst = GoalsAgainst;
            teamName = TeamName;
        }

        public override string ToString()
        {
            return $"{TeamName}, {GoalsFor}:{GoalsAgainst}";
        }
    }
}