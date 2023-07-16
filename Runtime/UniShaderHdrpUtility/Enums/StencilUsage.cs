// ----------------------------------------------------------------------
// @Namespace : UniHdrpShader
// @Enum      : StencilUsage
// ----------------------------------------------------------------------
namespace UniHdrpShader
{
    using System;

    /// <summary>Stencil Usage</summary>
    [Flags]
    public enum StencilUsage
    {
        /// <summary></summary>
        Clear = 0,

        // Note: first bit is free and can still be used by both phases.
        // --- Following bits are used before transparent rendering ---

        /// <summary></summary>
        RequiresDeferredLighting = 1 << 1,  // 2
        /// <summary>SSS, Split Lighting</summary>
        SubsurfaceScattering = 1 << 2,  // 4
        /// <summary>SSR or RTR</summary>
        TraceReflectionRay = 1 << 3,  // 8
        /// <summary>Use to tag when an Opaque Decal is render into DBuffer</summary>
        Decals = 1 << 4,  // 16
        /// <summary>Animated object (for motion blur, SSR, SSAO, TAA)</summary>
        ObjectMotionVector = 1 << 5,  // 32

        // --- Stencil is cleared after opaque rendering has finished ---
        // --- Following bits are used exclusively for what happens after opaque ---

        /// <summary>Disable Temporal Antialiasing for certain objects</summary>
        ExcludeFromTAA = 1 << 1, // 2
        /// <summary>Distortion pass - reset after distortion pass, shared with SMAA</summary>
        DistortionVectors = 1 << 2,  // 4
        /// <summary>Subpixel Morphological Antialiasing</summary>
        SMAA = 1 << 2,  // 4

        /// <summary>Reserved for future usage</summary>
        AfterOpaqueReservedBits = 0x38,  // 56

        // --- Following are user bits, we don't touch them inside HDRP and is up to the user to handle them ---

        /// <summary></summary>
        UserBit0 = 1 << 6,
        /// <summary></summary>
        UserBit1 = 1 << 7,

        /// <summary></summary>
        HDRPReservedBits = 255 & ~(UserBit0 | UserBit1),
    }
}
