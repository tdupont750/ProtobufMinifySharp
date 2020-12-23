using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ProtobufMinifySharp.Minifiers
{
    public class InlineDefaultValuesMinifier : IProtobufMinifier
    {
        public static readonly InlineDefaultValuesMinifier Instance = new();
        
        public SyntaxNode Minify(SyntaxNode root)
        {
            while (true)
            {
                // ReSharper disable once PossibleNullReferenceException
                var declaration = root
                    .DescendantNodes()
                    .OfType<FieldDeclarationSyntax>()
                    .FirstOrDefault(s => s.Declaration.Variables.Count == 1
                                         && s.Declaration.Variables.Single().Identifier.Text.EndsWith("DefaultValue")
                                         && s.Modifiers.ToString() == "private readonly static");

                if (declaration == null)
                    return root;

                var name = declaration.Declaration.Variables.Single().Identifier.Text;

                var value = declaration
                    .DescendantNodes()
                    .OfType<LiteralExpressionSyntax>()
                    .FirstOrDefault() ?? (SyntaxNode) declaration
                    .DescendantNodes()
                    .OfType<MemberAccessExpressionSyntax>()
                    .First();

                // ReSharper disable once PossibleNullReferenceException
                var identifier = declaration
                    .FirstAncestorOrSelf<ClassDeclarationSyntax>()
                    .DescendantNodes()
                    .OfType<IdentifierNameSyntax>()
                    .FirstOrDefault(s => s.Identifier.Text == name);

                root = identifier == null
                    ? root.RemoveNode(declaration, SyntaxRemoveOptions.KeepDirectives)
                    : root.ReplaceNode(identifier, value);
            }
        }
    }
}