// ----------------------------------------------------------------------
// @Namespace : UniStandardShader
// @Enum      : AlphaBlendMode
// ----------------------------------------------------------------------
namespace UniStandardShader
{
    /// <summary>Alpha Blend Mode</summary>
    public enum AlphaBlendMode
    {
        /// <summary></summary>
        Opaque = 0,
        /// <summary></summary>
        Cutout = 1,
        /// <summary>Old school alpha-blending mode, fresnel does not affect amount of transparency</summary>
        Fade = 2,
        /// <summary>Physically plausible transparency mode, implemented as alpha pre-multiply</summary>
        Transparent = 3,
    }
}
