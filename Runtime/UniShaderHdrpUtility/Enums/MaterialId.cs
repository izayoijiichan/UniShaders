// ----------------------------------------------------------------------
// @Namespace : UniHdrpShader
// @Enum      : MaterialId
// ----------------------------------------------------------------------
namespace UniHdrpShader
{
    /// <summary>Material ID</summary>
    public enum MaterialId
    {
        /// <summary>SubsurfaceScattering</summary>
        LitSSS = 0,
        /// <summary>Standard</summary>
        LitStandard = 1,
        /// <summary>Anisotropy</summary>
        LitAniso = 2,
        /// <summary>Iridescence</summary>
        LitIridescence = 3,
        /// <summary>SpecularColor</summary>
        LitSpecular = 4,
        /// <summary>Translucent</summary>
        LitTranslucent = 5,
    }
}
