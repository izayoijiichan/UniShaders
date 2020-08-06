// ----------------------------------------------------------------------
// @Namespace : UniStandardShader
// @Class     : StandardDefinition
// ----------------------------------------------------------------------
namespace UniStandardShader
{
    using UnityEngine;

    /// <summary>
    /// Standard Definition
    /// </summary>
    public class StandardDefinition
    {
        /// <summary>Color</summary>
        public Color Color { get; set; }

        /// <summary>Albedo</summary>
        public Texture2D MainTex { get; set; }

        /// <summary>Alpha Cutoff</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float Cutoff { get; set; }

        /// <summary>Smoothness</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float Glossiness { get; set; }

        /// <summary>Smoothness Scale</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float GlossMapScale { get; set; }

        /// <summary>Smoothness texture channel</summary>
        public SmoothnessTextureChannel SmoothnessTextureChannel { get; set; }

        /// <summary>Metallic</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float Metallic { get; set; }

        /// <summary>MetallicGlossMap</summary>
        public Texture2D MetallicGlossMap { get; set; }

        /// <summary>Specular Highlights</summary>
        public bool SpecularHighlights { get; set; }

        /// <summary>Glossy Reflections</summary>
        public bool GlossyReflections { get; set; }

        /// <summary>Normal Map Scale</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float BumpScale { get; set; }

        /// <summary>Normal Map</summary>
        public Texture2D BumpMap { get; set; }

        /// <summary>Height Scale</summary>
        //[Range(0.005f, 0.08f)]
        //[DefaultValue(0.02f)]
        public float Parallax { get; set; }

        /// <summary>Height Map</summary>
        public Texture2D ParallaxMap { get; set; }

        /// <summary>Occlusion Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float OcclusionStrength { get; set; }

        /// <summary>Occlusio nMap</summary>
        public Texture2D OcclusionMap { get; set; }

        /// <summary>Emission Color</summary>
        public Color EmissionColor { get; set; }

        /// <summary>Emission Map</summary>
        public Texture2D EmissionMap { get; set; }

        /// <summary>Detail Mask</summary>
        public Texture2D DetailMask { get; set; }

        /// <summary>Detail Albedo Map x2</summary>
        public Texture2D DetailAlbedoMap { get; set; }

        /// <summary>Detail Normal Map Scale</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float DetailNormalMapScale { get; set; }

        /// <summary>Detail Normal Map</summary>
        public Texture2D DetailNormalMap { get; set; }

        /// <summary>UV Set for secondary textures</summary>
        public UV UVSec { get; set; }

        /// <summary>Mode</summary>
        public AlphaMode Mode { get; set; }

        ///// <summary>SrcBlend</summary>
        //public float SrcBlend { get; set; }

        ///// <summary>DstBlend</summary>
        //public float DstBlend { get; set; }

        ///// <summary>ZWrite</summary>
        //public bool ZWrite { get; set; }
    }
}