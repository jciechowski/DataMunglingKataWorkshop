namespace DataMunglingKata.Football.Interfaces
{
    public interface ISystemFile
    {
        bool Exists( string filePath );
        string[] ReadAll( string filePath );
    }
}