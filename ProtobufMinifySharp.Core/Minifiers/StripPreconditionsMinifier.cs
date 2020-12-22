using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace ProtobufMinifySharp.Minifiers
{
    public class StripPreconditionsMinifier : IProtobufMinifier
    {
        public static readonly StripPreconditionsMinifier Instance = new();

        public SyntaxNode Minify(SyntaxNode root)
        {
            while (true)
            {
                var descendant = root
                    .DescendantNodes()
                    .OfType<InvocationExpressionSyntax>()
                    .FirstOrDefault(s => s.Expression.ToString() == "pb::ProtoPreconditions.CheckNotNull");

                if (descendant == null)
                    return root;

                var expression = descendant.ArgumentList.Arguments[0].Expression;
                root = root.ReplaceNode(descendant, expression);
            }
        }
    }
}