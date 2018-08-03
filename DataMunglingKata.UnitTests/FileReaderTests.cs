using System.Linq;
using Xunit;

namespace DataMunglingKata.UnitTests
{
    public class FileReaderTests
    {
        public FileReaderTests()
        {
            _sut = new FileReader();
        }

        private readonly FileReader _sut;

        [Theory]
        [InlineData(8, "9  86    32*")]
        [InlineData(25, "26  97*   64")]
        public void ShouldReadLineWithAsterisk(int index, string expected)
        {
            var result = _sut.ReadFile().ToArray()[index];

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ReadFileIsntEmpty()
        {
            var result = _sut.ReadFile();

            Assert.NotEmpty(result);
        }

        [Fact]
        public void ShouldRemoveHeadersAndLastLine()
        {
            var result = _sut.ReadFile();

            Assert.Equal(30, result.Count());
        }

        [Fact]
        public void ShouldRemoveLastLine()
        {
            var result = _sut.ReadFile().Last();

            Assert.Equal("30  90    45", result);
        }
    }
}