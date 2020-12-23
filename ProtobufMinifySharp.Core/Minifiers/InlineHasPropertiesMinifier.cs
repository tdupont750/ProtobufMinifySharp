using System;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ProtobufMinifySharp.Minifiers
{
    public class InlineHasPropertiesMinifier : IProtobufMinifier
    {
        public static readonly InlineHasPropertiesMinifier Instance = new();
        
        public SyntaxNode Minify(SyntaxNode root)
        {
            while (true)
            {
                // ReSharper disable once PossibleNullReferenceException
                var declaration = root
                    .DescendantNodes()
                    .OfType<PropertyDeclarationSyntax>()
                    .FirstOrDefault(s => s.Identifier.Text.StartsWith("Has") 
                                         && s.Type.ToString() == "bool"
                                         && s.DescendantNodes().OfType<AccessorDeclarationSyntax>().Count() == 1);

                if (declaration == null)
                    return root;

                var value = declaration
                    .DescendantNodes()
                    .OfType<BinaryExpressionSyntax>()
                    .First();

                // ReSharper disable once PossibleNullReferenceException
                var identifier = declaration
                    .FirstAncestorOrSelf<ClassDeclarationSyntax>()
                    .DescendantNodes()
                    .OfType<IdentifierNameSyntax>()
                    .FirstOrDefault(s => s.Identifier.Text == declaration.Identifier.Text);

                if (identifier == null)
                {
                    root = root.RemoveNode(declaration, SyntaxRemoveOptions.KeepDirectives);
                    continue;
                }

                if (identifier.Parent is MemberAccessExpressionSyntax access)
                {
                    var memberName = value.DescendantNodes().OfType<IdentifierNameSyntax>().First().Identifier.Text;
                    var accessName = access.ToString().Replace(identifier.Identifier.Text, memberName);
                    var str = value.ToString().Replace(memberName, accessName);
                        
                    var newValue = CSharpSyntaxTree
                        .ParseText(str)
                        .GetRoot()
                        .DescendantNodes()
                        .OfType<BinaryExpressionSyntax>()
                        .First();
                    
                    root = root.ReplaceNode(identifier.Parent, newValue);
                    continue;
                }

                root = root.ReplaceNode(identifier, value);
            }
        }
    }
}