using System;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ProtobufMinifySharp.Minifiers
{
    public class StripParserPropertyMinifier : IProtobufMinifier
    {
        public static readonly StripParserPropertyMinifier Instance = new();
        
        public SyntaxNode Minify(SyntaxNode root)
        {
            while (true)
            {
                var descendant = root
                    .DescendantNodes()
                    .OfType<PropertyDeclarationSyntax>()
                    .FirstOrDefault(s => s.Identifier.Text == "Parser"
                                         && s.Modifiers.ToString() == "public static");

                if (descendant == null)
                    break;

                root = root.RemoveNode(descendant, SyntaxRemoveOptions.KeepDirectives);
            }
            
            while (true)
            {
                var descendant = root
                    .DescendantNodes()
                    .OfType<FieldDeclarationSyntax>()
                    .FirstOrDefault(s => s.Declaration.Variables.Count == 1
                                         && s.Declaration.Variables.Single().Identifier.Text.EndsWith("_parser")
                                         && s.Modifiers.ToString() == "private static readonly");

                if (descendant == null)
                    break;
                
                var str = descendant.ToFullString()
                    .Replace("private ", "public ")
                    .Replace(" _parser ", " Parser ");
                
                var field = CSharpSyntaxTree
                    .ParseText(str)
                    .GetRoot()
                    .DescendantNodes()
                    .OfType<FieldDeclarationSyntax>()
                    .First();
                
                root = root.ReplaceNode(descendant, field);
            }
            
            return root;
        }
    }
}