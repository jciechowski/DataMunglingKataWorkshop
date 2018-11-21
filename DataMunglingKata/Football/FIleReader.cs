using System;
using System.Collections.Generic;
using System.IO;
using DataMunglingKata.Football.Interfaces;

namespace DataMunglingKata.Football
{
    public class FileReader : IFileReader
    {
        private readonly string _filePath;
        private readonly ISystemFile _systemFile;

        public FileReader(ISystemFile systemFile, string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentException();
            }

            _systemFile = systemFile;
            _filePath = filePath;
        }

        public IEnumerable<string> GetRawFileContent()
        {
            if (!_systemFile.Exists(_filePath))
            {
                throw new FileNotFoundException();
            }

            return _systemFile.ReadAll(_filePath);
        }
    }
}