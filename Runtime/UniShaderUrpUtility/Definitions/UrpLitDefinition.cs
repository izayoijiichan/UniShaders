// ----------------------------------------------------------------------
// @Namespace : UniUrpShader
// @Class     : UrpLitDefinition
// ----------------------------------------------------------------------
namespace UniUrpShader
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Universal Render Pipeline/Lit Definition
    /// </summary>
    /// <remarks>
    /// com.unity.render-pipelines.universal
    /// Lit.shader
    /// </remarks>
    public class UrpLitDefinition : UrpLitDefinitionBase
    {
        #region Properties

        /// <summary>Workflow Mode</summary>
        public WorkflowMode WorkflowMode { get; set; }

        /// <summary>Smoothness Texture Channel</summary>
        public SmoothnessTextureChannel SmoothnessTextureChannel { get; set; }

        /// <summary>Metallic</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float Metallic { get; set; }

        /// <summary>Metallic Gloss Map</summary>
        public Texture2D MetallicGlossMap { get; set; }

        /// <summary>Environment Reflections</summary>
        //[DefaultValue(true)]
        public bool EnvironmentReflections { get; set; }

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

        #endregion

        #region Obsolete Properties

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

        #endregion
    }
}