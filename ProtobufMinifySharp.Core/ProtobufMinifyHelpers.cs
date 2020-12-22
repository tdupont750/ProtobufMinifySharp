using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ProtobufMinifySharp
{
    internal static class ProtobufMinifyHelpers
    {
        internal static SyntaxNode EmptyWithNotImplemented<T>(SyntaxNode root, Func<T, bool> predicate)
            where T : SyntaxNode
        {
            var notImplemented = CSharpSyntaxTree
                .ParseText($"{{ throw new System.NotImplementedException(); }}{Environment.NewLine}")
                .GetRoot()
                .DescendantNodes()
                .OfType<BlockSyntax>()
                .First();

            while (true)
            {
                var descendant = root
                    .DescendantNodes()
                    .OfType<T>()
                    .FirstOrDefault(s => predicate(s) && !s.DescendantNodes().OfType<ThrowStatementSyntax>().Any());

                if (descendant == null)
                    return root;

                var block = descendant
                    .DescendantNodes()
                    .OfType<BlockSyntax>()
                    .First();

                root = root.ReplaceNode(block, notImplemented);
            }
        }
    }
}