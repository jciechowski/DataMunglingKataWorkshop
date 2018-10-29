using System.Collections.Generic;

namespace DataMunglingKata.Football.Interfaces
{
    public interface IFileReader
    {
        IEnumerable<string> GetRawFileContent();
    }
}