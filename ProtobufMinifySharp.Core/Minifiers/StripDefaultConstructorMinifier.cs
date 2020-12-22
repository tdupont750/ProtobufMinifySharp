using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ProtobufMinifySharp.Minifiers
{
    public class StripDefaultConstructorMinifier : IProtobufMinifier
    {
        public static readonly StripDefaultConstructorMinifier Instance = new();

        public SyntaxNode Minify(SyntaxNode root)
        {
            while (true)
            {
                var descendant = root
                    .DescendantNodes()
                    .OfType<MethodDeclarationSyntax>()
                    .FirstOrDefault(s => s.Identifier.Text == "OnConstruction");

                if (descendant == null)
                    break;

                root = root.RemoveNode(descendant, SyntaxRemoveOptions.KeepDirectives);
            }

            while (true)
            {
                var descendant = root
                    .DescendantNodes()
                    .OfType<ConstructorDeclarationSyntax>()
                    .FirstOrDefault(s => 
                        s.ParameterList.Parameters.Count == 0
                        && s.Modifiers.ToString() != "static");

                if (descendant == null)
                    break;

                root = root.RemoveNode(descendant, SyntaxRemoveOptions.KeepDirectives);
            }

            return root;
        }
    }
}