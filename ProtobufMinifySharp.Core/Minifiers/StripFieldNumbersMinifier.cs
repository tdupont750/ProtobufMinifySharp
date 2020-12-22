using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ProtobufMinifySharp.Minifiers
{
    public class StripFieldNumbersMinifier : IProtobufMinifier
    {
        public static readonly StripFieldNumbersMinifier Instance = new();

        public SyntaxNode Minify(SyntaxNode root)
        {
            while (true)
            {
                var descendant = root
                    .DescendantNodes()
                    .OfType<FieldDeclarationSyntax>()
                    .FirstOrDefault(s =>
                    {
                        var str = s.ToString();
                        return str.Contains("const int ")
                               && str.Contains("Number = ");
                    });

                if (descendant == null)
                    return root;

                root = root.RemoveNode(descendant, SyntaxRemoveOptions.KeepDirectives);
            }
        }
    }
}