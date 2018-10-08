using System;
using System.IO;
using DataMunglingKata.Football;
using Xunit;
using Moq;

namespace DataMunglingKata.UnitTests.Football
{
    public class FileParserTests
    {
        [Fact]
        public void ThrowWhenEmptyFilePathPassed()
        {
            Assert.Throws<ArgumentException>( () => new FileParser(new Mock<ISystemFile>().Object, string.Empty) );
        }

        [Fact]
        public void ShouldReturnCorrectDataWhenFileExists()
        {
            var systemFileMock = new Mock<ISystemFile>();
            const string dummyFilePath = "dummyFilePath";
            systemFileMock.Setup( m => m.Exists( dummyFilePath ) ).Returns( true );
            
            var sut = new FileParser(systemFileMock.Object, dummyFilePath );

            var result = sut.GetTeamData();

            Assert.NotEmpty( result );
        }

        [Fact]
        public void ShouldThrowWhenFileDoesNotExist()
        {
            var sut = new FileParser(new Mock<ISystemFile>().Object, "dummyFilePath" );

            Assert.Throws<FileNotFoundException>(() => sut.GetTeamData());
        }

        [Fact]
        public void ShouldParseData()
        {
            var sut = new FileParser(new Mock<ISystemFile>().Object, "dummyFilePath" );

        }
    }
}