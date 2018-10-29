using System;
using System.Collections.Generic;
using DataMunglingKata.Football.Interfaces;
using DataMunglingKata.Football.Model;

namespace DataMunglingKata.Football
{
    public class FileParser : IFileParser
    {
        public IEnumerable<TeamData> ParseRawContent( IEnumerable<string> rawContent )
        {
            throw new NotImplementedException();
        }
    }
}