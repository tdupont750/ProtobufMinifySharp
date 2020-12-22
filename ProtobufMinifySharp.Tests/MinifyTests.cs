using System.IO;
using System.Linq;
using ProtobufMinifySharp.Sample;
using Xunit;

namespace ProtobufMinifySharp.Tests
{
    public class MinifyTests
    {
        [Fact]
        public void ParseFromDataFile()
        {
            var sampleRootDir = TestHelpers.GetSampleRootDir();
            var dataPath = Path.Combine(sampleRootDir, "AddressBook.data");
            
            var data = File.ReadAllBytes(dataPath);
            var addressBook1 = AddressBook.Parser.ParseFrom(data);

            var addressBook2 = SampleHelpers.CreateAddressBook();
            Assert.Equal(addressBook1, addressBook2);
        }

        [Fact]
        public void CompareLengths()
        {
            var sampleRootDir = TestHelpers.GetSampleRootDir();
            var addressBookPath = SampleHelpers.GetAddressBookPath(sampleRootDir);
            var addressBookLength = new FileInfo(addressBookPath).Length;

            var minifiedFiles = Directory
                .GetFiles(sampleRootDir, "AddressBook.*.cs")
                .Select(f => new
                {
                    Path = f,
                    new FileInfo(f).Length
                })
                .OrderBy(f => f.Length)
                .ToArray();

            foreach (var file in minifiedFiles)
                Assert.True(file.Length < addressBookLength, $"{file.Path} is larger than source");

            var smallestFileName = Path.GetFileName(minifiedFiles.First().Path);
            Assert.Equal("AddressBook.All.cs", smallestFileName);
        }
    }
}