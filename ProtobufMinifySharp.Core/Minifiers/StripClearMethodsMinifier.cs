using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ProtobufMinifySharp.Minifiers
{
    public class StripClearMethodsMinifier : IProtobufMinifier
    {
        public static readonly StripClearMethodsMinifier Instance = new();

        public SyntaxNode Minify(SyntaxNode root)
        {
            while (true)
            {
                var descendant = root
                    .DescendantNodes()
                    .OfType<MethodDeclarationSyntax>()
                    .FirstOrDefault(s => s.Identifier.Text.StartsWith("Clear"));

                if (descendant == null)
                    return root;

                root = root.RemoveNode(descendant, SyntaxRemoveOptions.KeepDirectives);
            }
        }
    }
}