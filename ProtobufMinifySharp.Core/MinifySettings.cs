using System;

namespace ProtobufMinifySharp
{
    [Flags]
    public enum MinifySettings
    {
        InlineDefaultValues         = 1,
        InlineHasProperties         = 2,
        StripPreconditions          = 4,
        StripDebuggerAttributes     = 8,
        StripFieldNumbers           = 16,
        StripClearMethods           = 32,
        StripDescriptors            = 64,
        StripToStringOverrides      = 128,
        StripDefaultConstructor     = 256,
        StripParserProperty         = 512,
        EmptyClone                  = 1024,
        EmptyWriteTo                = 2048,
        EmptyCalculateSize          = 4096,
        EmptyMergeFrom              = 8192
    }
}