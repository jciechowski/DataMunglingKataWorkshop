using System;
using System.Collections.Generic;
using System.Linq;
using DataMunglingKata.Football.Interfaces;
using DataMunglingKata.Football.Model;

namespace DataMunglingKata.Football
{
    public class FileParser : IFileParser
    {
        public IEnumerable<TeamData> ParseRawContent(IEnumerable<string> rawContent)
        {
            //"1. Arsenal         38    26   9   3    79  -  36    87"
            //var regexp = new Regex(@"\s*\d+\.\s+(?<team>\w+)\s+\d+\s+\d+\s+\d+\s+\d+\s+(?<for>\d+)\s+-\s+(?<against>\d+)\s+\d+\s*");

            //foreach (var line in rawContent)
            //{
            //    var match = regexp.Match(line);
            //    if (match.Success)
            //    {
            //        yield return new TeamData(
            //            match.Groups["team"].Value,
            //            int.Parse(match.Groups["for"].Value),
            //            int.Parse(match.Groups["against"].Value)
            //        );
            //    }
            //}

            return rawContent.Skip(1)
                .Select(r => r.Split(' ', StringSplitOptions.RemoveEmptyEntries))
                .Where(r => !r[0].StartsWith('-'))
                .Select(r => new TeamData(r[1], int.Parse(r[6]), int.Parse(r[8])));
        }
    }
}