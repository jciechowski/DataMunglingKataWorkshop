using System.Collections.Generic;

namespace DataMunglingKata.Football
{
    public interface IFileParser
    {
        IEnumerable<(string teamName, int goalsFor, int goalsAgainst)> GetTeamData();
    }
}