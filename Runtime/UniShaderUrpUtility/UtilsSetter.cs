// ----------------------------------------------------------------------
// @Namespace : UniUrpShader
// @Class     : Utils
// ----------------------------------------------------------------------
namespace UniUrpShader
{
    using System;
    using UnityEngine;

    public static partial class Utils
    {
        /// <summary>
        /// Set the parameter value to the material.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="material"></param>
        /// <param name="parameters"></param>
        public static void SetParametersToMaterial<T>(Material material, T parameters)
        {
            Type type = typeof(T);

            if (type == UrpLitDefinitionType)
            {
                SetUrpLitParametersToMaterial(material, parameters as UrpLitDefinition);
            }
            else if (type == UrpSimpleLitDefinitionType)
            {
                SetUrpSimpleLitParametersToMaterial(material, parameters as UrpSimpleLitDefinition);
            }
            else if (type == UrpUnlitDefinitionType)
            {
                SetUrpUnlitParametersToMaterial(material, parameters as UrpUnlitDefinition);
            }
            else
            {
                throw new NotSupportedException();
            }
        }

        /// <summary>
        /// Set the URP Lit parameter value to the material.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="parameters"></param>
        private static void SetUrpLitParametersToMaterial(Material material, UrpLitDefinition parameters)
        {
            var materialProxy = new UrpLitMaterialProxy(material)
            {
                Surface = parameters.Surface,
                Blend = parameters.Blend,
                //SrcBlend = parameters.SrcBlend,
                //DstBlend = parameters.DstBlend,
                //SrcBlendAlpha = parameters.SrcBlendAlpha,
                //DstBlendAlpha = parameters.DstBlendAlpha,
                //ZWrite = parameters.ZWrite,
                //AlphaToMask = parameters.AlphaToMask,

                Cull = parameters.Cull,
                AlphaClip = parameters.AlphaClip,
                Cutoff = parameters.Cutoff,

                // Base Map
                BaseColor = parameters.BaseColor,
                BaseMap = parameters.BaseMap,
                BaseMapScale = parameters.BaseMapScale,
                BaseMapOffset = parameters.BaseMapOffset,

                // Editmode Properties
                QueueOffset = parameters.QueueOffset,

                // Obsolete Properties
                //MainTex = parameters.MainTex,
                //Color = parameters.Color,

                WorkflowMode = parameters.WorkflowMode,

                // Blending state
                ReceiveShadows = parameters.ReceiveShadows,

                // Metallic Gloss Map
                Metallic = parameters.Metallic,
                MetallicGlossMap = parameters.MetallicGlossMap,

                Smoothness = parameters.Smoothness,
                SmoothnessTextureChannel = parameters.SmoothnessTextureChannel,

                // Supecular Gloss Map
                SpecColor = parameters.SpecColor,
                SpecGlossMap = parameters.SpecGlossMap,
                SpecularHighlights = parameters.SpecularHighlights,

                EnvironmentReflections = parameters.EnvironmentReflections,

                // Bump Map (Normal Map)
                BumpMap = parameters.BumpMap,
                BumpScale = parameters.BumpScale,

                // Parallax Map (Height Map)
                ParallaxMap = parameters.ParallaxMap,
                Parallax = parameters.Parallax,

                // Occlusion Map
                OcclusionStrength = parameters.OcclusionStrength,
                OcclusionMap = parameters.OcclusionMap,

                // Emission Map
                EmissionColor = parameters.EmissionColor,
                EmissionMap = parameters.EmissionMap,

                // Detail Inputs
                DetailMask = parameters.DetailMask,

                DetailAlbedoMap = parameters.DetailAlbedoMap,
                DetailAlbedoMapScale = parameters.DetailAlbedoMapScale,
                DetailAlbedoMapScale2 = parameters.DetailAlbedoMapScale2,
                DetailAlbedoMapOffset = parameters.DetailAlbedoMapOffset,

                DetailNormalMapScale = parameters.DetailNormalMapScale,
                DetailNormalMap = parameters.DetailNormalMap,

                // Advanced Options
                ClearCoatMask = parameters.ClearCoatMask,
                ClearCoatSmoothness = parameters.ClearCoatSmoothness,

                // Obsolete Properties
                //GlossMapScale = parameters.GlossMapScale,
                //Glossiness = parameters.Glossiness,
                //GlossyReflections = parameters.GlossyReflections,

                //UnityLightmaps = parameters.UnityLightmaps,
                //UnityLightmapsInd = parameters.UnityLightmapsInd,
                //UnityShadowMasks = parameters.UnityShadowMasks,
            };

            // TODO
            materialProxy.SetKeyword(Keyword.DetailMulx2, (parameters.DetailAlbedoMap != null) || (parameters.DetailNormalMap != null));
            materialProxy.SetKeyword(Keyword.DetailScaled, (parameters.DetailAlbedoMapScale != 1.0f) || (parameters.DetailNormalMapScale != 1.0f));
        }

        /// <summary>
        /// Set the URP Simple Lit parameter value to the material.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="parameters"></param>
        private static void SetUrpSimpleLitParametersToMaterial(Material material, UrpSimpleLitDefinition parameters)
        {
            new UrpSimpleLitMaterialProxy(material)
            {
                Surface = parameters.Surface,
                Blend = parameters.Blend,
                //SrcBlend = parameters.SrcBlend,
                //DstBlend = parameters.DstBlend,
                //SrcBlendAlpha = parameters.SrcBlendAlpha,
                //DstBlendAlpha = parameters.DstBlendAlpha,
                //ZWrite = parameters.ZWrite,
                //AlphaToMask = parameters.AlphaToMask,

                Cull = parameters.Cull,
                AlphaClip = parameters.AlphaClip,
                Cutoff = parameters.Cutoff,

                // Base Map
                BaseColor = parameters.BaseColor,
                BaseMap = parameters.BaseMap,
                BaseMapScale = parameters.BaseMapScale,
                BaseMapOffset = parameters.BaseMapOffset,

                // Editmode Properties
                QueueOffset = parameters.QueueOffset,

                // Obsolete Properties
                //MainTex = parameters.MainTex,
                //Color = parameters.Color,

                // Blending state
                BlendModePreserveSpecular = parameters.BlendModePreserveSpecular,
                ReceiveShadows = parameters.ReceiveShadows,

                // Supecular Gloss Map
                Smoothness = parameters.Smoothness,
                SpecColor = parameters.SpecColor,
                SpecGlossMap = parameters.SpecGlossMap,
                SmoothnessSource = parameters.SmoothnessSource,
                SpecularHighlights = parameters.SpecularHighlights,

                // Bump Map (Normal Map)
                BumpMap = parameters.BumpMap,
                BumpScale = parameters.BumpScale,

                // Emission Map
                EmissionColor = parameters.EmissionColor,
                EmissionMap = parameters.EmissionMap,

                // Obsolete Properties
                //Shininess = parameters.Shininess,
                //GlossinessSource = parameters.GlossinessSource,
                //SpecSource = parameters.SpecSource,

                //UnityLightmaps = parameters.UnityLightmaps,
                //UnityLightmapsInd = parameters.UnityLightmapsInd,
                //UnityShadowMasks = parameters.UnityShadowMasks,
            };
        }

        /// <summary>
        /// Set the URP Unlit parameter value to the material.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="parameters"></param>
        private static void SetUrpUnlitParametersToMaterial(Material material, UrpUnlitDefinition parameters)
        {
            new UrpUnlitMaterialProxy(material)
            {
                Surface = parameters.Surface,
                Blend = parameters.Blend,
                //SrcBlend = parameters.SrcBlend,
                //DstBlend = parameters.DstBlend,
                //SrcBlendAlpha = parameters.SrcBlendAlpha,
                //DstBlendAlpha = parameters.DstBlendAlpha,
                //ZWrite = parameters.ZWrite,
                //AlphaToMask = parameters.AlphaToMask,

                Cull = parameters.Cull,
                AlphaClip = parameters.AlphaClip,
                Cutoff = parameters.Cutoff,

                // Base Map
                BaseColor = parameters.BaseColor,
                BaseMap = parameters.BaseMap,
                BaseMapScale = parameters.BaseMapScale,
                BaseMapOffset = parameters.BaseMapOffset,

                // Editmode Properties
                QueueOffset = parameters.QueueOffset,

                // Obsolete Properties
                //MainTex = parameters.MainTex,
                //Color = parameters.Color,

                BlendOp = parameters.BlendOp,

                // Obsolete Properties
                //SampleGI = parameters.SampleGI,
            };
        }
    }
}