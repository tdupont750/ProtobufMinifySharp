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
        EmptyClone                  = 512,
        EmptyWriteTo                = 1024,
        EmptyCalculateSize          = 2048,
        EmptyMergeFrom              = 4096
    }
}