// ----------------------------------------------------------------------
// @Namespace : UniHdrpShader
// @Enum      : UV
// ----------------------------------------------------------------------
namespace UniHdrpShader
{
    /// <summary>UV Set for base</summary>
    public enum UVBaseMapping
    {
        /// <summary></summary>
        UV0 = 0,
        /// <summary></summary>
        UV1 = 1,
        /// <summary></summary>
        UV2 = 2,
        /// <summary></summary>
        UV3 = 3,
        /// <summary></summary>
        Planar = 4,
        /// <summary></summary>
        Triplanar = 5,
    }

    /// <summary>UV Set for detail</summary>
    public enum UVDetailMapping
    {
        /// <summary></summary>
        UV0 = 0,
        /// <summary></summary>
        UV1 = 1,
        /// <summary></summary>
        UV2 = 2,
        /// <summary></summary>
        UV3 = 3,
    }

    /// <summary>UV Set for emissive</summary>
    public enum UVEmissiveMapping
    {
        /// <summary></summary>
        UV0 = 0,
        /// <summary></summary>
        UV1 = 1,
        /// <summary></summary>
        UV2 = 2,
        /// <summary></summary>
        UV3 = 3,
        /// <summary></summary>
        Planar = 4,
        /// <summary></summary>
        Triplanar = 5,
        /// <summary>Same as Base</summary>
        SameAsBase = 6,
    }
}
