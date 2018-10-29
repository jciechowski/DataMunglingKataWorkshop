using System.IO;
using DataMunglingKata.Football.Interfaces;

namespace DataMunglingKata.Football
{
    public class SystemFile : ISystemFile
    {
        public bool Exists( string filePath )
        {
            return File.Exists( filePath );
        }

        public string[] ReadAll( string filePath )
        {
            return File.ReadAllLines( filePath );
        }
    }
}