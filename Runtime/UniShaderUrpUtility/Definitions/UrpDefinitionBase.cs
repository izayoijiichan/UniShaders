// ----------------------------------------------------------------------
// @Namespace : UniUrpShader
// @Class     : UrpDefinitionBase
// ----------------------------------------------------------------------
namespace UniUrpShader
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Basic URP Definition
    /// </summary>
    public class UrpDefinitionBase
    {
        #region Properties

        /// <summary>Workflow Mode</summary>
        public WorkflowMode WorkflowMode { get; set; }

        /// <summary>Base Map</summary>
        public Texture2D BaseMap { get; set; }

        /// <summary>Base Color</summary>
        public Color BaseColor { get; set; }

        /// <summary>Alpha Cutoff</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float Cutoff { get; set; }

        /// <summary>Smoothness</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float Smoothness { get; set; }

        /// <summary>Smoothness Texture Channel</summary>
        public SmoothnessTextureChannel SmoothnessTextureChannel { get; set; }

        /// <summary>Metallic</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float Metallic { get; set; }

        /// <summary>Metallic Gloss Map</summary>
        public Texture2D MetallicGlossMap { get; set; }

        /// <summary>Specular Color</summary>
        public Color SpecColor { get; set; }

        /// <summary>Specular Gloss Map</summary>
        public Texture2D SpecGlossMap { get; set; }

        /// <summary>Specular Highlights</summary>
        //[DefaultValue(true)]
        public bool SpecularHighlights { get; set; }

        /// <summary>Environment Reflections</summary>
        //[DefaultValue(true)]
        public bool EnvironmentReflections { get; set; }

        /// <summary>Bump Scale</summary>
        //[DefaultValue(1.0f)]
        public float BumpScale { get; set; }

        /// <summary>Bump Map (Normal Map)</summary>
        public Texture2D BumpMap { get; set; }

        /// <summary>Parallax Scale</summary>
        //[Range(0.005f, 0.08f)]
        //[DefaultValue(0.005f)]
        public float Parallax { get; set; }

        /// <summary>Parallax Map (Height Map)</summary>
        public Texture2D ParallaxMap { get; set; }

        /// <summary>Occlusion Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float OcclusionStrength { get; set; }

        /// <summary>Occlusion Map</summary>
        public Texture2D OcclusionMap { get; set; }

        /// <summary>Emission Color</summary>
        public Color EmissionColor { get; set; }

        /// <summary>Emission Map</summary>
        public Texture2D EmissionMap { get; set; }

        /// <summary>Detail Mask</summary>
        public Texture2D DetailMask { get; set; }

        /// <summary>Detail Albedo Map Scale</summary>
        //[Range(0.0f, 2.0f)]
        //[DefaultValue(1.0f)]
        public float DetailAlbedoMapScale { get; set; }

        /// <summary>Detail Albedo Map</summary>
        public Texture2D DetailAlbedoMap { get; set; }

        /// <summary>Detail Normal Map Scale</summary>
        //[Range(0.0f, 2.0f)]
        //[DefaultValue(1.0f)]
        public float DetailNormalMapScale { get; set; }

        /// <summary>Detail Normal Map</summary>
        public Texture2D DetailNormalMap { get; set; }

        /// <summary>Clear Coat Mask</summary>
        //[DefaultValue(false)]
        public bool ClearCoatMask { get; set; }

        /// <summary>Clear Coat Smoothness</summary>
        //[DefaultValue(false)]
        public bool ClearCoatSmoothness { get; set; }

        /// <summary>Surface Type</summary>
        //[DefaultValue(SurfaceType.Opaque)]
        public SurfaceType Surface { get; set; }

        /// <summary>Blend Mode</summary>
        //[DefaultValue(BlendMode.Alpha)]
        public BlendMode Blend { get; set; }

        /// <summary>Cull Mode</summary>
        //[DefaultValue(CullMode.Back)]
        public CullMode Cull { get; set; }

        /// <summary>Alpha Clip</summary>
        //[DefaultValue(false)]
        public bool AlphaClip { get; set; }

        /// <summary>Src Blend</summary>
        //[DefaultValue(1.0f)]
        public float SrcBlend { get; set; }

        /// <summary>Dst Blend</summary>
        //[DefaultValue(0.0f)]
        public float DstBlend { get; set; }

        /// <summary>ZWrite</summary>
        //[DefaultValue(true)]
        public bool ZWrite { get; set; }

        /// <summary>Receive Shadows</summary>
        //[DefaultValue(true)]
        public bool ReceiveShadows { get; set; }

        /// <summary>Queue Offset</summary>
        //[Range(-50, 50)]
        //[DefaultValue(0)]
        public int QueueOffset { get; set; }

        #endregion

        #region Obsolete Properties

        /// <summary>Main Tex</summary>
        [Obsolete("Obsolete")]
        public Texture2D MainTex { get; set; }

        /// <summary>Color</summary>
        [Obsolete("Obsolete")]
        public Color Color { get; set; }

        /// <summary>Gloss Map Scale</summary>
        //[DefaultValue(0.0f)]
        [Obsolete("Obsolete")]
        public float GlossMapScale { get; set; }

        /// <summary>Glossiness</summary>
        //[DefaultValue(0.0f)]
        [Obsolete("Obsolete")]
        public float Glossiness { get; set; }

        /// <summary>Glossy Reflections</summary>
        //[DefaultValue(0.0f)]
        [Obsolete("Obsolete")]
        public float GlossyReflections { get; set; }

        /// <summary>unity_Lightmaps</summary>
        [Obsolete("Obsolete")]
        public Texture2DArray UnityLightmaps { get; set; }

        /// <summary>unity_LightmapsInd</summary>
        [Obsolete("Obsolete")]
        public Texture2DArray UnityLightmapsInd { get; set; }

        /// <summary>unity_ShadowMasks</summary>
        [Obsolete("Obsolete")]
        public Texture2DArray UnityShadowMasks { get; set; }

        #endregion
    }
}