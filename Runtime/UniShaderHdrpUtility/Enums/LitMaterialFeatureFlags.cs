// ----------------------------------------------------------------------
// @Namespace : UniHdrpShader
// @Enum      : LitMaterialFeatureFlags
// ----------------------------------------------------------------------
namespace UniHdrpShader
{
    using System;

    /// <summary>Lit Material Feature Flags</summary>
    /// <remarks>UnityEngine.Rendering.HighDefinition.Lit+MaterialFeatureFlags</remarks>
    [Flags]
    public enum LitMaterialFeatureFlags
    {
        /// <summary></summary>
        Standard = 1,
        /// <summary></summary>
        SpecularColor = 2,
        /// <summary></summary>
        SubsurfaceScattering = 4,
        /// <summary></summary>
        Transmission = 8,
        /// <summary></summary>
        Anisotropy = 16,
        /// <summary></summary>
        Iridescence = 32,
        /// <summary></summary>
        ClearCoat = 64,
    }
}
