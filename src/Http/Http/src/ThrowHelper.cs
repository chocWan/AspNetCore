using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Microsoft.AspNetCore.Http
{
    internal static class ThrowHelper
    {
        public static void ThrowInvalidOperationException_NoReadingAllowed() => throw CreateInvalidOperationException_NoReadingAllowed();
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static Exception CreateInvalidOperationException_NoReadingAllowed() => new InvalidOperationException("Reading is not allowed after reader was completed.");

        public static void ThrowInvalidCastException_NoArrayFromMemory() => throw CreateInvalidCastException_NoArrayFromMemory();
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static Exception CreateInvalidCastException_NoArrayFromMemory() => new InvalidCastException("Could not get byte[] from Memory.");

        public static void ThrowInvalidOperationException_NoDataRead() => throw CreateInvalidOperationException_NoDataRead();
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static Exception CreateInvalidOperationException_NoDataRead() => new InvalidOperationException("No data has been read into the StreamPipeReader.");
    }
}
