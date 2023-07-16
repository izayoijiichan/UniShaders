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
        /// Get the parameters from the material.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="material"></param>
        /// <returns></returns>
        public static T GetParametersFromMaterial<T>(Material material) where T : class
        {
            Type type = typeof(T);

            if (type == UrpLitDefinitionType)
            {
                return GetUrpLitParametersFromMaterial(material) as T;
            }
            else if (type == UrpSimpleLitDefinitionType)
            {
                return GetUrpSimpleLitParametersFromMaterial(material) as T;
            }
            else if (type == UrpUnlitDefinitionType)
            {
                return GetUrpUnlitParametersFromMaterial(material) as T;
            }
            else
            {
                throw new NotSupportedException();
            }
        }

        /// <summary>
        /// Get the URP Lit parameters from the material.
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        private static UrpLitDefinition GetUrpLitParametersFromMaterial(Material material)
        {
            var materialProxy = new UrpLitMaterialProxy(material);

            return new UrpLitDefinition
            {
                WorkflowMode = materialProxy.WorkflowMode,

                // Blending state
                Surface = materialProxy.Surface,
                Blend = materialProxy.Blend,
                Cull = materialProxy.Cull,

                SrcBlend = materialProxy.SrcBlend,
                DstBlend = materialProxy.DstBlend,
                ZWrite = materialProxy.ZWrite,

                AlphaClip = materialProxy.AlphaClip,
                Cutoff = materialProxy.Cutoff,

                ReceiveShadows = materialProxy.ReceiveShadows,

                // Base Map
                BaseColor = materialProxy.BaseColor,
                BaseMap = materialProxy.BaseMap,

                // Metallic Gloss Map
                Metallic = materialProxy.Metallic,
                MetallicGlossMap = materialProxy.MetallicGlossMap,

                Smoothness = materialProxy.Smoothness,
                SmoothnessTextureChannel = materialProxy.SmoothnessTextureChannel,

                SpecColor = materialProxy.SpecColor,
                SpecGlossMap = materialProxy.SpecGlossMap,

                SpecularHighlights = materialProxy.SpecularHighlights,
                EnvironmentReflections = materialProxy.EnvironmentReflections,

                // Bump Map (Normal Map)
                BumpMap = materialProxy.BumpMap,
                BumpScale = materialProxy.BumpScale,

                // Parallax Map (Height Map)
                Parallax = materialProxy.Parallax,
                ParallaxMap =   materialProxy.ParallaxMap,

                // Occlusion Map
                OcclusionStrength = materialProxy.OcclusionStrength,
                OcclusionMap = materialProxy.OcclusionMap,

                // Emission Map
                EmissionColor = materialProxy.EmissionColor,
                EmissionMap = materialProxy.EmissionMap,

                // Detail Inputs
                DetailMask = materialProxy.DetailMask,
                DetailAlbedoMapScale = materialProxy.DetailAlbedoMapScale,
                DetailAlbedoMap = materialProxy.DetailAlbedoMap,
                DetailNormalMapScale = materialProxy.DetailNormalMapScale,
                DetailNormalMap = materialProxy.DetailNormalMap,

                // Advanced Options
                ClearCoatMask = materialProxy.ClearCoatMask,
                ClearCoatSmoothness = materialProxy.ClearCoatSmoothness,

                QueueOffset = materialProxy.QueueOffset,

                // Obsolete Properties
                //MainTex = materialProxy.MainTex,
                //Color = materialProxy.Color,

                //GlossMapScale = materialProxy.GlossMapScale,
                //Glossiness = materialProxy.Glossiness,
                //GlossyReflections = materialProxy.GlossyReflections,

                //UnityLightmaps = materialProxy.UnityLightmaps,
                //UnityLightmapsInd = materialProxy.UnityLightmapsInd,
                //UnityShadowMasks = materialProxy.UnityShadowMasks,
            };
        }

        /// <summary>
        /// Get the URP SimpleLit parameters from the material.
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        private static UrpSimpleLitDefinition GetUrpSimpleLitParametersFromMaterial(Material material)
        {
            var materialProxy = new UrpSimpleLitMaterialProxy(material);

            return new UrpSimpleLitDefinition
            {
                // Blending state
                Surface = materialProxy.Surface,
                Blend = materialProxy.Blend,
                Cull = materialProxy.Cull,

                SrcBlend = materialProxy.SrcBlend,
                DstBlend = materialProxy.DstBlend,
                ZWrite = materialProxy.ZWrite,

                AlphaClip = materialProxy.AlphaClip,
                Cutoff = materialProxy.Cutoff,

                BlendModePreserveSpecular = materialProxy.BlendModePreserveSpecular,

                ReceiveShadows = materialProxy.ReceiveShadows,

                // Base Map
                BaseColor = materialProxy.BaseColor,
                BaseMap = materialProxy.BaseMap,

                // Specular Gloss Map
                Smoothness = materialProxy.Smoothness,

                SpecColor = materialProxy.SpecColor,
                SpecGlossMap = materialProxy.SpecGlossMap,

                SmoothnessSource = materialProxy.SmoothnessSource,

                SpecularHighlights = materialProxy.SpecularHighlights,

                // Bump Map (Normal Map)
                BumpMap = materialProxy.BumpMap,
                BumpScale = materialProxy.BumpScale,

                // Emission Map
                EmissionColor = materialProxy.EmissionColor,
                EmissionMap = materialProxy.EmissionMap,

                // Editmode Properties
                QueueOffset = materialProxy.QueueOffset,

                // Obsolete Properties
                //MainTex = materialProxy.MainTex,
                //Color = materialProxy.Color,

                //Shininess = materialProxy.Shininess,
                //GlossinessSource = materialProxy.GlossinessSource,
                //SpecSource = materialProxy.SpecSource,

                //UnityLightmaps = materialProxy.UnityLightmaps,
                //UnityLightmapsInd = materialProxy.UnityLightmapsInd,
                //UnityShadowMasks = materialProxy.UnityShadowMasks,
            };
        }

        /// <summary>
        /// Get the URP Unlit parameters from the material.
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        private static UrpUnlitDefinition GetUrpUnlitParametersFromMaterial(Material material)
        {
            var materialProxy = new UrpUnlitMaterialProxy(material);

            return new UrpUnlitDefinition
            {
                // Blending state
                Surface = materialProxy.Surface,
                Blend = materialProxy.Blend,
                Cull = materialProxy.Cull,

                SrcBlend = materialProxy.SrcBlend,
                DstBlend = materialProxy.DstBlend,
                ZWrite = materialProxy.ZWrite,

                AlphaClip = materialProxy.AlphaClip,
                Cutoff = materialProxy.Cutoff,

                BlendOp = materialProxy.BlendOp,

                // Base Map
                BaseColor = materialProxy.BaseColor,
                BaseMap = materialProxy.BaseMap,

                // Editmode Properties
                QueueOffset = materialProxy.QueueOffset,

                // Obsolete Properties
                //MainTex = materialProxy.MainTex,
                //Color = materialProxy.Color,
                //SampleGI = materialProxy.SampleGI,
            };
        }
    }
}