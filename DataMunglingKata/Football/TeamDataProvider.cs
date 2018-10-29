using System.Collections.Generic;
using DataMunglingKata.Football.Interfaces;
using DataMunglingKata.Football.Model;

namespace DataMunglingKata.Football
{
    public class TeamDataProvider : ITeamDataProvider
    {
        private readonly IFileReader _fileReader;
        private readonly IFileParser _fileParser;

        public TeamDataProvider( IFileReader fileReader, IFileParser fileParser )
        {
            _fileReader = fileReader;
            _fileParser = fileParser;
        }

        public IEnumerable<TeamData> GetTeamData()
        {
            var rawContent = _fileReader.GetRawFileContent();
            var parsedData = _fileParser.ParseRawContent( rawContent );

            return parsedData;
        }
    }
}