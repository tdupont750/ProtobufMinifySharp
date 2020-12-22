using Microsoft.CodeAnalysis;

namespace ProtobufMinifySharp
{
    public interface IProtobufMinifier
    {
        SyntaxNode Minify(SyntaxNode root);
    }
}