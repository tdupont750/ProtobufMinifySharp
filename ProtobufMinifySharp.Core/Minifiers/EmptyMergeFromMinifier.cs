using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ProtobufMinifySharp.Minifiers
{
    public class EmptyMergeFromMinifier : IProtobufMinifier
    {
        public static readonly EmptyMergeFromMinifier Instance = new();

        public SyntaxNode Minify(SyntaxNode root)
        {
            return ProtobufMinifyHelpers.EmptyWithNotImplemented<MethodDeclarationSyntax>(root,
                s => s.Identifier.Text == "MergeFrom"
                     && s.ParameterList.ToString().EndsWith("other)"));
        }
    }
}