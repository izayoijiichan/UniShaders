// ----------------------------------------------------------------------
// @Namespace : UniHdrpShader
// @Enum      : CullMode
// ----------------------------------------------------------------------
namespace UniHdrpShader
{
    /// <summary>Cull Mode</summary>
    public enum CullMode
    {
        /// <summary></summary>
        Off = 0,
        /// <summary></summary>
        Front = 1,
        /// <summary></summary>
        Back = 2,
    }
    
    /// <summary>Opaque Cull Mode</summary>
    public enum OpaqueCullMode
    {
        /// <summary></summary>
        Front = 1,
        /// <summary></summary>
        Back = 2,
    }

    /// <summary>Transparent Cull Mode</summary>
    public enum TransparentCullMode
    {
        /// <summary></summary>
        Front = 1,
        /// <summary></summary>
        Back = 2,
    }
}
