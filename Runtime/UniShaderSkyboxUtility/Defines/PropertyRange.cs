// ----------------------------------------------------------------------
// @Namespace : UniSkyboxShader
// @Class     : PropertyRange
// ----------------------------------------------------------------------
namespace UniSkyboxShader
{
    using UniShader.Shared;

    /// <summary>
    /// Property Range
    /// </summary>
    public class PropertyRange
    {
        /// <summary>Exposure</summary>
        public static FloatRangeDefault Exposure = new FloatRangeDefault(0.0f, 8.0f, 1.0f);

        /// <summary>Rotation</summary>
        public static IntRangeDefault Rotation = new IntRangeDefault(0, 360, 0);

        /// <summary>Sun Size</summary>
        public static FloatRangeDefault SunSize = new FloatRangeDefault(0.0f, 1.0f, 0.04f);

        /// <summary>Sun Size Convergence</summary>
        public static IntRangeDefault SunSizeConvergence = new IntRangeDefault(1, 10, 5);

        /// <summary>Atmosphere Thickness</summary>
        public static FloatRangeDefault AtmosphereThickness = new FloatRangeDefault(0.0f, 5.0f, 1.0f);
    }
}