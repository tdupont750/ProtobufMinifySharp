using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ProtobufMinifySharp.Minifiers
{
    public class StripDescriptorsMinifier : IProtobufMinifier
    {
        public static readonly StripDescriptorsMinifier Instance = new();

        public SyntaxNode Minify(SyntaxNode root)
        {
            while (true)
            {
                var descendant = root
                    .DescendantNodes()
                    .OfType<ClassDeclarationSyntax>()
                    .FirstOrDefault(s => s.Identifier.Text.EndsWith("Reflection")
                                         && s.Modifiers.ToString() == "public static partial");

                if (descendant == null)
                    break;

                root = root.RemoveNode(descendant, SyntaxRemoveOptions.KeepNoTrivia);
            }

            while (true)
            {
                var descendant = root
                    .DescendantNodes()
                    .OfType<PropertyDeclarationSyntax>()
                    .FirstOrDefault(s => s.Identifier.Text == "Descriptor" 
                                         && s.Modifiers.ToString() == "public static");

                if (descendant == null)
                    break;

                root = root.RemoveNode(descendant, SyntaxRemoveOptions.KeepDirectives);
            }

            return ProtobufMinifyHelpers.EmptyWithNotImplemented<PropertyDeclarationSyntax>(root,
                s => s.Identifier.Text == "Descriptor");
        }
    }
}