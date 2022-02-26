// ----------------------------------------------------------------------
// @Namespace : UniUrpShader
// @Class     : Keyword
// ----------------------------------------------------------------------
namespace UniUrpShader
{
    /// <summary>
    /// Keyword
    /// </summary>
    public class Keyword
    {
        #region Material Keywords

        /// <summary>Normal Map</summary>
        public const string NormalMap = "_NORMALMAP";

        /// <summary>Parallax Map</summary>
        public const string ParallaxMap = "_PARALLAXMAP";

        /// <summary>Reveive Shadows Off</summary>
        public const string ReveiveShadowsOff = "_RECEIVE_SHADOWS_OFF";

        /// <summary>Detail Mulx 2</summary>
        public const string DetailMulx2 = "_DETAIL_MULX2";

        /// <summary>Detail Scaled</summary>
        public const string DetailScaled = "_DETAIL_SCALED";

        /// <summary>Surface Type Transparent</summary>
        public const string SurfaceTypeTransparent = "_SURFACE_TYPE_TRANSPARENT";

        /// <summary>Alpha Test On</summary>
        public const string AlphaTestOn = "_ALPHATEST_ON";

        /// <summary>Alpha Pre Multiply On</summary>
        public const string AlphaPreMultiplyOn = "_ALPHAPREMULTIPLY_ON";

        /// <summary>Emission</summary>
        public const string Emission = "_EMISSION";

        /// <summary>Metallic Spec Gloss Map</summary>
        public const string MetallicSpecGlossMap = "_METALLICSPECGLOSSMAP";

        /// <summary>Smoothness Texture Albedo Channel A</summary>
        public const string SmoothnessTextureAlbedoChannelA = "_SMOOTHNESS_TEXTURE_ALBEDO_CHANNEL_A";

        /// <summary>Occlusion Map</summary>
        public const string OcclusionMap = "_OCCLUSIONMAP";

        /// <summary>Specular Highlights Off</summary>
        public const string SpecularHighlightsOff = "_SPECULARHIGHLIGHTS_OFF";

        /// <summary>Environment Reflections Off</summary>
        public const string EnvironmentReflectionsOff = "_ENVIRONMENTREFLECTIONS_OFF";

        /// <summary>Specular Setup</summary>
        public const string SpecularSetup = "_SPECULAR_SETUP";

        #endregion

        #region Universal Pipeline keywords

        /// <summary>Main Light Shadows</summary>
        public const string MainLightShadows = "_MAIN_LIGHT_SHADOWS";

        /// <summary>Main Light Shadows Cascade</summary>
        public const string MainLightShadowsCascade = "_MAIN_LIGHT_SHADOWS_CASCADE";

        /// <summary>Main Light Shadows Screen</summary>
        public const string MainLightShadowsScreen = "_MAIN_LIGHT_SHADOWS_SCREEN";

        /// <summary>Additional Lights Vertex</summary>
        public const string AdditionalLightsVertex = "_ADDITIONAL_LIGHTS_VERTEX";

        /// <summary>Additional Lights</summary>
        public const string AdditionalLights = "_ADDITIONAL_LIGHTS";

        /// <summary>Additional Light Shadows</summary>
        public const string AdditionalLightShadows = "_ADDITIONAL_LIGHT_SHADOWS";

        /// <summary>Reflection Probe Blending</summary>
        public const string ReflectionProbeBlending = "_REFLECTION_PROBE_BLENDING";

        /// <summary>Reflection Probe Box Projection</summary>
        public const string ReflectionProbeBoxProjection = "_REFLECTION_PROBE_BOX_PROJECTION";

        /// <summary>Shadows Soft</summary>
        public const string ShadowsSoft = "_SHADOWS_SOFT";

        /// <summary>Screen Space Occlusion</summary>
        public const string ScreenSpaceOcclusion = "_SCREEN_SPACE_OCCLUSION";

        /// <summary>Dbuffer Mrt 1</summary>
        public const string DbufferMrt1 = "_DBUFFER_MRT1";

        /// <summary>Dbuffer Mrt 2</summary>
        public const string DbufferMrt2 = "_DBUFFER_MRT2";

        /// <summary>Dbuffer Mrt 3</summary>
        public const string DbufferMrt3 = "_DBUFFER_MRT3";

        /// <summary>Light Layers</summary>
        public const string LightLayers = "_LIGHT_LAYERS";

        /// <summary>Light Cookies</summary>
        public const string LightCookies = "_LIGHT_COOKIES";

        /// <summary>Clustered Rendering</summary>
        public const string ClusteredRendering = "_CLUSTERED_RENDERING";

        #endregion

        #region Unity defined keywords

        /// <summary>Lightmap Shadow Mixing</summary>
        public const string LightmapShadowMixing = "LIGHTMAP_SHADOW_MIXING";

        /// <summary>Shadows Shadow Mask</summary>
        public const string ShadowsShadowMask = "SHADOWS_SHADOWMASK";

        /// <summary>Dir Light Map Combined</summary>
        public const string DirLightMapCombined = "DIRLIGHTMAP_COMBINED";

        /// <summary>Lightmap On</summary>
        public const string LightmapOn = "LIGHTMAP_ON";

        /// <summary>Dynamic Light Map On</summary>
        public const string DynamicLightMapOn = "DYNAMICLIGHTMAP_ON";

        /// <summary>Debug Display</summary>
        public const string DebugDisplay = "DEBUG_DISPLAY";

        #endregion

        #region GPU Instancing

        /// <summary>Dots Instancing On</summary>
        public const string DotsInstancingOn = "DOTS_INSTANCING_ON";

        #endregion

        #region

        /// <summary>Editor Visualization</summary>
        public const string EditorVisualization = "EDITOR_VISUALIZATION";

        /// <summary>Fog Exp</summary>
        public const string FogExp = "FOG_EXP";

        /// <summary>Fog Exp 2</summary>
        public const string FogExp2 = "FOG_EXP2";

        /// <summary>Fog Linear</summary>
        public const string FogLinear = "FOG_LINEAR";

        /// <summary>Instancing On</summary>
        public const string InstancingOn = "INSTANCING_ON";

        /// <summary>Stereo Cubemap Render On</summary>
        public const string StereoCubemapRenderOn = "STEREO_CUBEMAP_RENDER_ON";

        /// <summary>Stereo Instancing On</summary>
        public const string StereoInstancingOn = "STEREO_INSTANCING_ON";

        /// <summary>Stereo Multi View On</summary>
        public const string StereoMultiViewOn = "STEREO_MULTIVIEW_ON";

        /// <summary>Unity Single Pass Stereo</summary>
        public const string UnitySinglePassStereo = "UNITY_SINGLE_PASS_STEREO";

        /// <summary>Casting Punctual Light Shadow</summary>
        public const string CastingPunctualLightShadow = "CASTING_PUNCTUAL_LIGHT_SHADOW";

        /// <summary>GBuffer Normals Oct</summary>
        public const string GBufferNormalsOct = "GBUFFER_NORMALS_OCT";

        /// <summary>Render Pass Enabled</summary>
        public const string RenderPassEnabled = "RENDER_PASS_ENABLED";

        #endregion
    }
}