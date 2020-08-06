// ----------------------------------------------------------------------
// @Namespace : UniStandardShader
// @Class     : Keyword
// ----------------------------------------------------------------------
namespace UniStandardShader
{
    /// <summary>
    /// Keyword
    /// </summary>
    public class Keyword
    {
        /// <summary>Cut out</summary>
        public const string AlphaTestOn = "_ALPHATEST_ON";

        /// <summary>Fade</summary>
        public const string AlphaBlendOn = "_ALPHABLEND_ON";

        /// <summary>Transparent</summary>
        public const string AlphaPreMultiplyOn = "_ALPHAPREMULTIPLY_ON";

        /// <summary>Normal Map</summary>
        public const string NormalMap = "_NORMALMAP";

        /// <summary>Height Map</summary>
        public const string ParallaxMap = "_PARALLAXMAP";

        /// <summary>Emission Color or Emission Map</summary>
        public const string Emission = "_EMISSION";

        /// <summary>Secondary Detail Map (Albedo & Normal)</summary>
        public const string DetailMulx2 = "_DETAIL_MULX2";

        /// <summary>Metallic Workflow Metallic/Smoothness Map</summary>
        public const string MetallicGlossMap = "_METALLICGLOSSMAP";

        /// <summary>Specular Workflow Specular/Smoothness Map</summary>
        public const string SpecGlossMap = "_SPECGLOSSMAP";
    }
}