using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ProtobufMinifySharp.Minifiers
{
    public class EmptyCloneMinifier : IProtobufMinifier
    {
        public static readonly EmptyCloneMinifier Instance = new();
        
        public SyntaxNode Minify(SyntaxNode root)
        {
            while (true)
            {
                var descendant = root
                    .DescendantNodes()
                    .OfType<ConstructorDeclarationSyntax>()
                    .FirstOrDefault(s => s.ParameterList.Parameters.Count == 1);

                if (descendant == null)
                    break;

                root = root.RemoveNode(descendant, SyntaxRemoveOptions.KeepDirectives);
            }
            
            return ProtobufMinifyHelpers.EmptyWithNotImplemented<MethodDeclarationSyntax>(root,
                s => s.Identifier.Text == "Clone");
        }
    }
}