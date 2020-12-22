using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ProtobufMinifySharp.Minifiers
{
    public class StripDebuggerAttributesMinifier : IProtobufMinifier
    {
        public static readonly StripDebuggerAttributesMinifier Instance = new();
        
        public SyntaxNode Minify(SyntaxNode root)
        {
            while (true)
            {
                var descendant = root
                    .DescendantNodes()
                    .OfType<AttributeListSyntax>()
                    .FirstOrDefault(s => s.ToString() == "[global::System.Diagnostics.DebuggerNonUserCodeAttribute]");

                if (descendant == null)
                    return root;

                root = root.RemoveNode(descendant, SyntaxRemoveOptions.KeepDirectives);
            }
        }
    }
}