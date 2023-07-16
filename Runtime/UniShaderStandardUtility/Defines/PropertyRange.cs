// ----------------------------------------------------------------------
// @Namespace : UniStandardShader
// @Class     : PropertyRange
// ----------------------------------------------------------------------
namespace UniStandardShader
{
    using UniShader.Shared;

    /// <summary>
    /// Property Range
    /// </summary>
    public class PropertyRange
    {
        /// <summary>Alpha Cutoff</summary>
        public static FloatRangeDefault Cutoff = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        /// <summary>Smoothness</summary>
        public static FloatRangeDefault Glossiness = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        /// <summary>Smoothness Scale</summary>
        public static FloatRangeDefault GlossMapScale = new FloatRangeDefault(0.0f, 8.0f, 1.0f);

        /// <summary>Metallic</summary>
        public static FloatRangeDefault Metallic = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Normal Map Scale</summary>
        public static FloatRangeDefault BumpScale = new FloatRangeDefault(0.0f, 8.0f, 1.0f);

        /// <summary>Height Scale</summary>
        public static FloatRangeDefault Parallax = new FloatRangeDefault(0.005f, 0.08f, 0.02f);

        /// <summary>Occlusion Strength</summary>
        public static FloatRangeDefault OcclusionStrength = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        /// <summary>Detail Normal Map Scale</summary>
        public static FloatRangeDefault DetailNormalMapScale = new FloatRangeDefault(0.0f, 2.0f, 1.0f);
    }
}