// ----------------------------------------------------------------------
// @Namespace : UniUrpParticleShader
// @Enum      : BlendMode
// ----------------------------------------------------------------------
namespace UniUrpParticleShader
{
    /// <summary></summary>
    public enum BlendMode
    {
        /// <summary></summary>
        /// <remarks>Old school alpha-blending mode, fresnel does not affect amount of transparency</remarks>
        Alpha = 0,
        /// <summary></summary>
        /// <remarks>Physically plausible transparency mode, implemented as alpha pre-multiply</remarks>
        Premultiply = 1,
        /// <summary></summary>
        Additive = 2,
        /// <summary></summary>
        Multiply = 3,
    }
}