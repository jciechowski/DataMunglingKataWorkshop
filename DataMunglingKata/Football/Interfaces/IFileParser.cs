using System.Collections.Generic;
using DataMunglingKata.Football.Model;

namespace DataMunglingKata.Football.Interfaces
{
    public interface IFileParser
    {
        IEnumerable<TeamData> ParseRawContent( IEnumerable<string> rawContent );
    }
}