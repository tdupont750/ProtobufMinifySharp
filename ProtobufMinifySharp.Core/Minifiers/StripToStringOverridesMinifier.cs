using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ProtobufMinifySharp.Minifiers
{
    public class StripToStringOverridesMinifier : IProtobufMinifier
    {
        public static readonly StripToStringOverridesMinifier Instance = new();
        
        public SyntaxNode Minify(SyntaxNode root)
        {
            while (true)
            {
                var descendant = root
                    .DescendantNodes()
                    .OfType<MethodDeclarationSyntax>()
                    .FirstOrDefault(s => s.Identifier.Text == "ToString");

                if (descendant == null)
                    return root;

                root = root.RemoveNode(descendant, SyntaxRemoveOptions.KeepDirectives);
            }
        }
    }
}