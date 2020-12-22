using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ProtobufMinifySharp.Minifiers
{
    public class EmptyCalculateSizeMinifier : IProtobufMinifier
    {
        public static readonly EmptyCalculateSizeMinifier Instance = new();

        public SyntaxNode Minify(SyntaxNode root)
        {
            return ProtobufMinifyHelpers.EmptyWithNotImplemented<MethodDeclarationSyntax>(root,
                s => s.Identifier.Text == "CalculateSize");
        }
    }
}