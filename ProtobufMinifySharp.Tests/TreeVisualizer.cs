using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using ProtobufMinifySharp.Sample;
using Xunit;
using Xunit.Abstractions;

namespace ProtobufMinifySharp.Tests
{
    public class TreeVisualizer
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public TreeVisualizer(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void PrintAddressBook()
        {
            var sampleRootDir = TestHelpers.GetSampleRootDir();
            var addressBookPath = SampleHelpers.GetAddressBookPath(sampleRootDir);
            var text = File.ReadAllText(addressBookPath);
            
            var tree = CSharpSyntaxTree.ParseText(text).GetRoot();
            PrintTree(new[] {tree});
        }
        
        private void PrintTree(IEnumerable<SyntaxNode> nodes, int indent = 0)
        {
            var space = string.Empty.PadLeft(indent * 2, '_');

            foreach (var node in nodes)
            {
                _testOutputHelper.WriteLine($"{space}({node.GetType().Name}) {node.ToString().Split('\n').First()}");
                PrintTree(node.ChildNodes(), indent + 1);
            }
        }
    }
}