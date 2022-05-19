// ----------------------------------------------------------------------
// @Namespace : UniUrpShader
// @Class     : Property
// ----------------------------------------------------------------------
using System;

namespace UniUrpShader
{
    /// <summary>
    /// Property
    /// </summary>
    public class Property
    {
        #region Base

        /// <summary>Base Map</summary>
        public const string BaseMap = "_BaseMap";

        /// <summary>Base Color</summary>
        public const string BaseColor = "_BaseColor";

        /// <summary>Alpha Cutoff</summary>
        public const string Cutoff = "_Cutoff";

        /// <summary>Surface Type</summary>
        public const string Surface = "_Surface";

        /// <summary>Blend Mode</summary>
        public const string Blend = "_Blend";

        /// <summary>Cull Mode</summary>
        public const string Cull = "_Cull";

        /// <summary>Alpha Clip</summary>
        public const string AlphaClip = "_AlphaClip";

        /// <summary>Src Blend</summary>
        public const string SrcBlend = "_SrcBlend";

        /// <summary>Dst Blend</summary>
        public const string DstBlend = "_DstBlend";

        /// <summary>ZWrite</summary>
        public const string ZWrite = "_ZWrite";

        /// <summary>Queue Offset</summary>
        public const string QueueOffset = "_QueueOffset";

        #endregion

        #region Lit Base

        /// <summary>Smoothness</summary>
        public const string Smoothness = "_Smoothness";

        /// <summary>Specular Color</summary>
        public const string SpecColor = "_SpecColor";

        /// <summary>Specular Gloss Map</summary>
        public const string SpecGlossMap = "_SpecGlossMap";

        /// <summary>Specular Highlights</summary>
        public const string SpecularHighlights = "_SpecularHighlights";

        /// <summary>Bump Scale</summary>
        public const string BumpScale = "_BumpScale";

        /// <summary>Bump Map</summary>
        public const string BumpMap = "_BumpMap";

        /// <summary>Emission Color</summary>
        public const string EmissionColor = "_EmissionColor";

        /// <summary>Emission Map</summary>
        public const string EmissionMap = "_EmissionMap";

        /// <summary>Receive Shadows</summary>
        public const string ReceiveShadows = "_ReceiveShadows";

        #endregion

        #region Lit

        /// <summary>_Workflow Mode</summary>
        public const string WorkflowMode = "_WorkflowMode";

        /// <summary>Smoothness Texture Channel</summary>
        public const string SmoothnessTextureChannel = "_SmoothnessTextureChannel";

        /// <summary>Metallic</summary>
        public const string Metallic = "_Metallic";

        /// <summary>Metallic Gloss Map</summary>
        public const string MetallicGlossMap = "_MetallicGlossMap";

        /// <summary>Environment Reflections</summary>
        public const string EnvironmentReflections = "_EnvironmentReflections";

        /// <summary>Parallax Scale</summary>
        public const string Parallax = "_Parallax";

        /// <summary>Parallax Map</summary>
        public const string ParallaxMap = "_ParallaxMap";

        /// <summary>Occlusion Strength</summary>
        public const string OcclusionStrength = "_OcclusionStrength";

        /// <summary>Occlusion Map</summary>
        public const string OcclusionMap = "_OcclusionMap";

        /// <summary>Detail Mask</summary>
        public const string DetailMask = "_DetailMask";

        /// <summary>Detail Albedo Map Scale</summary>
        public const string DetailAlbedoMapScale = "_DetailAlbedoMapScale";

        /// <summary>Detail Albedo Map</summary>
        public const string DetailAlbedoMap = "_DetailAlbedoMap";

        /// <summary>Detail Normal Map Scale</summary>
        public const string DetailNormalMapScale = "_DetailNormalMapScale";

        /// <summary>Detail Normal Map</summary>
        public const string DetailNormalMap = "_DetailNormalMap";

        /// <summary>Clear Coat Mask</summary>
        public const string ClearCoatMask = "_ClearCoatMask";

        /// <summary>Clear Coat Smoothness</summary>
        public const string ClearCoatSmoothness = "_ClearCoatSmoothness";

        #endregion

        #region Simple Lit

        /// <summary>Smoothness Source</summary>
        public const string SmoothnessSource = "_SmoothnessSource";

        /// <summary>Blend Mode Preserve Specular</summary>
        public const string BlendModePreserveSpecular = "_BlendModePreserveSpecular";

        #endregion

        #region Unlit

        /// <summary>Blend Op</summary>
        public const string BlendOp = "_BlendOp";

        #endregion

        #region Obsolete Properties

        /// <summary>Main Tex</summary>
        [Obsolete("Obsolete")]
        public const string MainTex = "_MainTex";

        /// <summary>Color</summary>
        [Obsolete("Obsolete")]
        public const string Color = "_Color";

        /// <summary>Unity Lightmaps</summary>
        [Obsolete("Obsolete")]
        public const string UnityLightmaps = "unity_Lightmaps";

        /// <summary>Unity Lightmaps Ind</summary>
        [Obsolete("Obsolete")]
        public const string UnityLightmapsInd = "unity_LightmapsInd";

        /// <summary>Unity Shadow Masks</summary>
        [Obsolete("Obsolete")]
        public const string UnityShadowMasks = "unity_ShadowMasks";

        #endregion

        #region Lit

        /// <summary>Gloss Map Scale</summary>
        [Obsolete("Obsolete")]
        public const string GlossMapScale = "_GlossMapScale";

        /// <summary>Glossiness</summary>
        [Obsolete("Obsolete")]
        public const string Glossiness = "_Glossiness";

        /// <summary>Glossy Reflections</summary>
        [Obsolete("Obsolete")]
        public const string GlossyReflections = "GlossyReflections";

        #endregion

        #region Simple Lit

        /// <summary>Shininess</summary>
        [Obsolete("Obsolete")]
        public const string Shininess = "_Shininess";

        /// <summary>Glossiness Source</summary>
        [Obsolete("Obsolete")]
        public const string GlossinessSource = "_GlossinessSource";

        /// <summary>Spec Source</summary>
        [Obsolete("Obsolete")]
        public const string SpecSource = "_SpecSource";

        #endregion

        #region Unlit

        /// <summary>Sample GI</summary>
        public const string SampleGI = "_SampleGI";

        #endregion
    }
}