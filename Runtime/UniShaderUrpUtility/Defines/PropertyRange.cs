// ----------------------------------------------------------------------
// @Namespace : UniUrpShader
// @Class     : PropertyRange
// ----------------------------------------------------------------------
namespace UniUrpShader
{
    using System;
    using UniShader.Shared;

    /// <summary>
    /// Property Range
    /// </summary>
    public class PropertyRange
    {
        #region Base

        /// <summary>Alpha Cutoff</summary>
        public static FloatRangeDefault Cutoff = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        /// <summary>Queue Offset</summary>
        public static IntRangeDefault QueueOffset = new IntRangeDefault(-50, 50, 0);

        #endregion

        #region Lit Base

        /// <summary>Smoothness</summary>
        public static FloatRangeDefault Smoothness = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        /// <summary>Normal Map Scale</summary>
        public static FloatRangeDefault BumpScale = new FloatRangeDefault(0.0f, 8.0f, 1.0f);

        #endregion

        #region Lit

        /// <summary>Metallic</summary>
        public static FloatRangeDefault Metallic = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Height Scale</summary>
        public static FloatRangeDefault Parallax = new FloatRangeDefault(0.005f, 0.08f, 0.005f);

        /// <summary>Occlusion Strength</summary>
        public static FloatRangeDefault OcclusionStrength = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        /// <summary>Detail Albedo Map Scale</summary>
        public static FloatRangeDefault DetailAlbedoMapScale = new FloatRangeDefault(0.0f, 2.0f, 1.0f);

        /// <summary>Detail Normal Map Scale</summary>
        public static FloatRangeDefault DetailNormalMapScale = new FloatRangeDefault(0.0f, 2.0f, 1.0f);

        /// <summary>Glossiness Scale</summary>
        [Obsolete("Obsolete")]
        public static FloatRangeDefault GlossMapScale = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        /// <summary>Glossiness</summary>
        [Obsolete("Obsolete")]
        public static FloatRangeDefault Glossiness = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        #endregion
    }
}