using System;
using System.IO;
using DataMunglingKata.Football;
using DataMunglingKata.Football.Interfaces;
using Xunit;
using Moq;

namespace DataMunglingKata.UnitTests.Football
{
    public class FileReaderTests
    {
        [Fact]
        public void ThrowWhenEmptyFilePathPassed()
        {
            Assert.Throws<ArgumentException>( () => new FileReader(new Mock<ISystemFile>().Object, string.Empty) );
        }

        [Fact]
        public void ShouldReturnCorrectDataWhenFileExists()
        {
            var systemFileMock = new Mock<ISystemFile>();
            const string dummyFilePath = "dummyFilePath";
            systemFileMock.Setup( m => m.Exists( dummyFilePath ) ).Returns( true );

            systemFileMock.Setup( m => m.ReadAll( dummyFilePath ) ).Returns( new string[] {"dummy"} );
            var sut = new FileReader(systemFileMock.Object, dummyFilePath );

            var result = sut.GetRawFileContent();

            Assert.NotEmpty( result );
        }

        [Fact]
        public void ShouldThrowWhenFileDoesNotExist()
        {
            var sut = new FileReader(new Mock<ISystemFile>().Object, "dummyFilePath" );

            Assert.Throws<FileNotFoundException>(() => sut.GetRawFileContent());
        }
        
    }
}