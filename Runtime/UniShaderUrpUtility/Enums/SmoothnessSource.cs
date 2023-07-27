// ----------------------------------------------------------------------
// @Namespace : UniUrpShader
// @Enum      : SmoothnessSource
// ----------------------------------------------------------------------
namespace UniUrpShader
{
    /// <summary>Smoothness Source</summary>
    public enum SmoothnessSource
    {
        /// <summary>Use this when smoothness is stored in the alpha channel of the specular map.</summary>
        SpecularAlpha = 0,
        /// <summary>Use this when smoothness is stored in the alpha channel of the base map.</summary>
        BaseAlpha = 1,
    }
}
