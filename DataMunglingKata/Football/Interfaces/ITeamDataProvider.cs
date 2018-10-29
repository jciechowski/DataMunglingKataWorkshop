using System.Collections.Generic;
using DataMunglingKata.Football.Model;

namespace DataMunglingKata.Football.Interfaces
{
    public interface ITeamDataProvider
    {
        IEnumerable<TeamData> GetTeamData();
    }
}
