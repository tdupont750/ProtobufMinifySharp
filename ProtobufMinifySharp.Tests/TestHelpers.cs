using System.IO;
using ProtobufMinifySharp.Sample;

namespace ProtobufMinifySharp.Tests
{
    public static class TestHelpers
    {
        public static string GetSampleRootDir()
        {
            var rootDir = SampleHelpers.GetAncestorDir("ProtobufMinifySharp.Tests.csproj");
            return Path.Combine(rootDir, "..", "ProtobufMinifySharp.Sample");
        }
    }
}