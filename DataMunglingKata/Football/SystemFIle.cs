using System.IO;

namespace DataMunglingKata.Football
{
    public class SystemFile
    {
        public bool Exists( string filePath )
        {
            return File.Exists( filePath );
        }
    }
}