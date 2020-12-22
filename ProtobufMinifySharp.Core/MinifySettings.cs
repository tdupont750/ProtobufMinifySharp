using System;

namespace ProtobufMinifySharp
{
    [Flags]
    public enum MinifySettings
    {
        StripPreconditions = 1,
        StripDebuggerAttributes = 2,
        StripFieldNumbers = 4,
        StripClearMethods = 8,
        InlineDefaultValues = 16,
        StripDescriptors = 32,
        StripToStringOverrides = 64,
        StripDefaultConstructor = 128,
        EmptyClone = 256,
        EmptyWriteTo = 512,
        EmptyCalculateSize = 1024,
        EmptyMergeFrom = 2048
    }
}