using System;
using System.Collections.Generic;
using System.IO;

namespace DataMunglingKata.Football
{
    public class FileParser : IFileParser
    {
        private readonly ISystemFile _systemFile;
        private readonly string _filePath;

        public FileParser( ISystemFile systemFile, string filePath )
        {
            if ( string.IsNullOrEmpty( filePath ) )
            {
                throw new ArgumentException();
            }

            _systemFile = systemFile;
            _filePath = filePath;
        }

        public IEnumerable<(string teamName, int goalsFor, int goalsAgainst)> GetTeamData()
        {
            if ( !_systemFile.Exists( _filePath ) )
            {
                throw new FileNotFoundException();
            }

            var teamData = new List<(string teamName, int goalsFor, int goalsAgainst)>() { ("test", 1 ,1) };

            return teamData;
        }
    }
}