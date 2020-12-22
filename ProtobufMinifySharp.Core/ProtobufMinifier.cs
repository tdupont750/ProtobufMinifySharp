using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp;
using ProtobufMinifySharp.Minifiers;

namespace ProtobufMinifySharp
{
    public static class ProtobufMinifier
    {
        public const MinifySettings AllMinifiers = (MinifySettings) 8192 - 1;
        
        private static readonly MinifySettings[] MinifySettingsValues = Enum.GetValues<MinifySettings>();

        public static IReadOnlyList<IProtobufMinifier> GetMinifiers(MinifySettings settings)
        {
            var minifiers = new List<IProtobufMinifier>();
            
            foreach (var value in MinifySettingsValues)
            {
                if ((settings & value) != value)
                    continue;

                var minifier = GetMinifier(value);
                minifiers.Add(minifier);
            }

            return minifiers;
            
            static IProtobufMinifier GetMinifier(MinifySettings settings)
            {
                switch (settings)
                {
                    case MinifySettings.InlineDefaultValues:
                        return InlineDefaultValuesMinifier.Instance;
                    case MinifySettings.InlineHasProperties:
                        return InlineHasPropertiesMinifier.Instance;
                    case MinifySettings.StripPreconditions:
                        return StripPreconditionsMinifier.Instance;
                    case MinifySettings.StripDebuggerAttributes:
                        return StripDebuggerAttributesMinifier.Instance;
                    case MinifySettings.StripFieldNumbers:
                        return StripFieldNumbersMinifier.Instance;
                    case MinifySettings.StripClearMethods:
                        return StripClearMethodsMinifier.Instance;
                    case MinifySettings.StripDescriptors:
                        return StripDescriptorsMinifier.Instance;
                    case MinifySettings.StripToStringOverrides:
                        return StripToStringOverridesMinifier.Instance;
                    case MinifySettings.StripDefaultConstructor:
                        return StripDefaultConstructorMinifier.Instance;
                    case MinifySettings.EmptyClone:
                        return EmptyCloneMinifier.Instance;
                    case MinifySettings.EmptyWriteTo:
                        return EmptyWriteToMinifier.Instance;
                    case MinifySettings.EmptyCalculateSize:
                        return EmptyCalculateSizeMinifier.Instance;
                    case MinifySettings.EmptyMergeFrom:
                        return EmptyMergeFromMinifier.Instance;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
        
        public static string Minify(string text, MinifySettings settings = AllMinifiers)
        {
            var minifiers = GetMinifiers(settings);
            return MinifyInternal(text, minifiers);
        }

        public static string Minify(string text, params IProtobufMinifier[] minifiers)
        {
            return MinifyInternal(text, minifiers);
        }
        
        private static string MinifyInternal(string text, IReadOnlyCollection<IProtobufMinifier> minifiers)
        {
            if (minifiers == null || minifiers.Count == 0)
                throw new ArgumentException("Minifiers required", nameof(minifiers));

            var tree = CSharpSyntaxTree.ParseText(text);
            var root = tree.GetRoot();

            foreach (var minifier in minifiers)
                root = minifier.Minify(root);

            // Reattach the headers...is there really no better way to do this?
            var rootText = root.ToString();
            var rootSubstring = rootText.Substring(0, 10);
            var startIndex = text.IndexOf(rootSubstring);
            var startSubstring = text.Substring(0, startIndex);
            return startSubstring + rootText;
        }
    }
}