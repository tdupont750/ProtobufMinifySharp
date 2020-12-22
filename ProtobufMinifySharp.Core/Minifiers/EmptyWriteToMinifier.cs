using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ProtobufMinifySharp.Minifiers
{
    public class EmptyWriteToMinifier : IProtobufMinifier
    {
        public static readonly EmptyWriteToMinifier Instance = new();

        public SyntaxNode Minify(SyntaxNode root)
        {
            return ProtobufMinifyHelpers.EmptyWithNotImplemented<MethodDeclarationSyntax>(root,
                s => s.Identifier.Text == "WriteTo"
                     || s.Identifier.Text == "InternalWriteTo");
        }
    }
}