// ----------------------------------------------------------------------
// @Namespace : UniHdrpShader
// @Enum      : SpecularOcclusionMode
// ----------------------------------------------------------------------
namespace UniHdrpShader
{
    /// <summary>Specular Occlusion Mode</summary>
    public enum SpecularOcclusionMode
    {
        /// <summary></summary>
        Off = 0,
        /// <summary>From Ambient Occlusion</summary>
        FromAmbientOcclusion = 1,
        /// <summary>From Bent Normals</summary>
        FromBentNormals = 2,
    }
}
