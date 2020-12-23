using System;
using System.IO;
using CodedOutputStream = Google.Protobuf.CodedOutputStream;

namespace ProtobufMinifySharp.Sample
{
    public static class Program
    {
        public static void Main()
        {
            var (inputPath, rootDir) = GetPaths();
            var input = File.ReadAllText(inputPath);

            WriteMinifiedFiles(input, rootDir);
            WriteDataFile(rootDir);
        }

        private static void WriteMinifiedFiles(string input, string rootDir)
        {
            var settings = Enum.GetValues<MinifySettings>();
            foreach (var setting in settings)
            {
                var output = ProtobufMinifier.Minify(input, setting);
                var outputPath = Path.Combine(rootDir, SampleHelpers.Generated, $"{SampleHelpers.AddressBook}.{setting}.cs");
                File.WriteAllText(outputPath, output);
            }

            var all = ProtobufMinifier.Minify(input);
            var allPath = Path.Combine(rootDir, SampleHelpers.Generated, $"{SampleHelpers.AddressBook}.All.cs");
            File.WriteAllText(allPath, all);
        }

        private static void WriteDataFile(string rootDir)
        {
            var addressBook = SampleHelpers.CreateAddressBook();
            
            var dataPath = Path.Combine(rootDir, SampleHelpers.Generated, $"{SampleHelpers.AddressBook}.data");
            using var fileStream = new FileStream(dataPath, FileMode.Create, FileAccess.Write);
            using var outputStream = new CodedOutputStream(fileStream);
            addressBook.WriteTo(outputStream);
        }

        private static (string, string) GetPaths()
        {
            var dir = SampleHelpers.GetAncestorDir($"{SampleHelpers.AddressBook}.proto");
            var protoCsPath = SampleHelpers.GetAddressBookPath(dir);
            return (protoCsPath, dir);
        }
    }
}