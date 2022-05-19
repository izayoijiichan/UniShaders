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
        /// Set the keyword value to the material.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="parameters"></param>
        private static void SetBasicUrpKeywordsToMaterial(Material material, UrpDefinitionBase parameters)
        {
            // Material Keywords

            SetKeyword(material, Keyword.SurfaceTypeTransparent, (parameters.Surface == SurfaceType.Transparent));

            SetKeyword(material, Keyword.AlphaTestOn, (parameters.Blend == BlendMode.Alpha));
            SetKeyword(material, Keyword.AlphaPreMultiplyOn, (parameters.Blend == BlendMode.Premultiply));

            // Universal Pipeline keywords
            //SetKeyword(material, Keyword.MainLightShadows, false);
            //SetKeyword(material, Keyword.MainLightShadows, false);
            //SetKeyword(material, Keyword.MainLightShadowsCascade, false);
            //SetKeyword(material, Keyword.MainLightShadowsScreen, false);
            //SetKeyword(material, Keyword.AdditionalLightsVertex, false);
            //SetKeyword(material, Keyword.AdditionalLights, false);
            //SetKeyword(material, Keyword.AdditionalLightShadows, false);
            //SetKeyword(material, Keyword.ReflectionProbeBlending, false);
            //SetKeyword(material, Keyword.ReflectionProbeBoxProjection, false);
            //SetKeyword(material, Keyword.ShadowsSoft, false);
            //SetKeyword(material, Keyword.ScreenSpaceOcclusion, false);
            //SetKeyword(material, Keyword.DbufferMrt1, false);
            //SetKeyword(material, Keyword.DbufferMrt2, false);
            //SetKeyword(material, Keyword.DbufferMrt3, false);
            //SetKeyword(material, Keyword.LightLayers, false);
            //SetKeyword(material, Keyword.LightCookies, false);
            //SetKeyword(material, Keyword.ClusteredRendering, false);

            // Unity defined keywords
            //SetKeyword(material, Keyword.LightmapShadowMixing, false);
            //SetKeyword(material, Keyword.ShadowsShadowMask, (parameters.UnityShadowMasks != null));
            //SetKeyword(material, Keyword.DirLightMapCombined, false);
            //SetKeyword(material, Keyword.LightmapOn, (parameters.UnityLightmaps != null));
            //SetKeyword(material, Keyword.DynamicLightMapOn, false);
            //SetKeyword(material, Keyword.DebugDisplay, false);

            // GPU Instancing
            //SetKeyword(material, Keyword.DotsInstancingOn, false);

            //SetKeyword(material, Keyword.EditorVisualization, false);
            //SetKeyword(material, Keyword.FogExp, false);
            //SetKeyword(material, Keyword.FogExp2, false);
            //SetKeyword(material, Keyword.FogLinear, false);
            //SetKeyword(material, Keyword.InstancingOn, false);
            //SetKeyword(material, Keyword.StereoCubemapRenderOn, false);
            //SetKeyword(material, Keyword.StereoInstancingOn, false);
            //SetKeyword(material, Keyword.StereoMultiViewOn, false);
            //SetKeyword(material, Keyword.UnitySinglePassStereo, false);
            //SetKeyword(material, Keyword.CastingPunctualLightShadow, false);
            //SetKeyword(material, Keyword.GBufferNormalsOct, false);
            //SetKeyword(material, Keyword.RenderPassEnabled, false);
        }

        /// <summary>
        /// Set the parameter value to the material.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="parameters"></param>
        private static void SetBasicUrpParametersToMaterial(Material material, UrpDefinitionBase parameters)
        {
            // Blending state
            SetSurfaceType(material, parameters.Surface, parameters.Blend);

            //SetInt(material, Property.Surface, (int)parameters.Surface);
            //SetInt(material, Property.Blend, (int)parameters.Blend);
            //SetFloat(material, Property.SrcBlend, parameters.SrcBlend);
            //SetFloat(material, Property.DstBlend, parameters.DstBlend);
            //SetBool(material, Property.ZWrite, parameters.ZWrite);

            SetInt(material, Property.Cull, (int)parameters.Cull);

            SetBool(material, Property.AlphaClip, parameters.AlphaClip);
            SetFloat(material, Property.Cutoff, parameters.Cutoff);

            // Base Map
            SetColor(material, Property.BaseColor, parameters.BaseColor);
            SetTexture(material, Property.BaseMap, parameters.BaseMap);

            // Editmode Properties
            SetInt(material, Property.QueueOffset, parameters.QueueOffset);

            // Obsolete Properties
            //SetTexture(material, Property.MainTex, parameters.MainTex);
            //SetColor(material, Property.Color, parameters.Color);
        }

        /// <summary>
        /// Set the URP Lit parameter value to the material.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="parameters"></param>
        private static void SetUrpLitParametersToMaterial(Material material, UrpLitDefinition parameters)
        {
            // Material Keywords
            SetBasicUrpKeywordsToMaterial(material, parameters);

            // TODO
            //SetKeyword(material, Keyword.SpecularSetup, false);

            SetKeyword(material, Keyword.NormalMap, (parameters.BumpMap != null));
            SetKeyword(material, Keyword.ParallaxMap, (parameters.ParallaxMap != null));

            SetKeyword(material, Keyword.ReveiveShadowsOff, (parameters.ReceiveShadows == false));

            // TODO
            SetKeyword(material, Keyword.DetailMulx2, (parameters.DetailAlbedoMap != null));
            SetKeyword(material, Keyword.DetailScaled, (parameters.DetailAlbedoMapScale != 1.0f));

            SetKeyword(material, Keyword.Emission, (parameters.EmissionMap != null));

            SetKeyword(material, Keyword.MetallicSpecGlossMap, (parameters.SpecGlossMap != null));
            SetKeyword(material, Keyword.SmoothnessTextureAlbedoChannelA, (parameters.SmoothnessTextureChannel == SmoothnessTextureChannel.AlbedoAlpha));

            SetKeyword(material, Keyword.OcclusionMap, (parameters.OcclusionMap != null));

            SetKeyword(material, Keyword.SpecularHighlightsOff, (parameters.SpecularHighlights == false));
            SetKeyword(material, Keyword.EnvironmentReflectionsOff, (parameters.EnvironmentReflections == false));

            SetBasicUrpParametersToMaterial(material, parameters);

            SetInt(material, Property.WorkflowMode, (int)parameters.WorkflowMode);

            // Blending state
            SetBool(material, Property.ReceiveShadows, parameters.ReceiveShadows);

            // Base Map
            SetColor(material, Property.BaseColor, parameters.BaseColor);
            SetTexture(material, Property.BaseMap, parameters.BaseMap);

            // Metallic Gloss Map
            SetFloat(material, Property.Metallic, parameters.Metallic);
            SetTexture(material, Property.MetallicGlossMap, parameters.MetallicGlossMap);

            SetFloat(material, Property.Smoothness, parameters.Smoothness);
            SetInt(material, Property.SmoothnessTextureChannel, (int)parameters.SmoothnessTextureChannel);

            SetColor(material, Property.SpecColor, parameters.SpecColor);
            SetTexture(material, Property.SpecGlossMap, parameters.SpecGlossMap);

            SetBool(material, Property.SpecularHighlights, parameters.SpecularHighlights);
            SetBool(material, Property.EnvironmentReflections, parameters.EnvironmentReflections);

            // Bump Map (Normal Map)
            SetTexture(material, Property.BumpMap, parameters.BumpMap);
            SetFloat(material, Property.BumpScale, parameters.BumpScale);

            // Parallax Map (Height Map)
            SetTexture(material, Property.ParallaxMap, parameters.ParallaxMap);
            SetFloat(material, Property.Parallax, parameters.Parallax);

            // Occlusion Map
            SetFloat(material, Property.OcclusionStrength, parameters.OcclusionStrength);
            SetTexture(material, Property.OcclusionMap, parameters.OcclusionMap);

            // Emission Map
            SetColor(material, Property.EmissionColor, parameters.EmissionColor);
            SetTexture(material, Property.EmissionMap, parameters.EmissionMap);

            // Detail Inputs
            SetTexture(material, Property.DetailMask, parameters.DetailMask);

            SetFloat(material, Property.DetailAlbedoMapScale, parameters.DetailAlbedoMapScale);
            SetTexture(material, Property.DetailAlbedoMap, parameters.DetailAlbedoMap);

            SetFloat(material, Property.DetailNormalMapScale, parameters.DetailNormalMapScale);
            SetTexture(material, Property.DetailNormalMap, parameters.DetailNormalMap);

            // Advanced Options
            SetBool(material, Property.ClearCoatMask, parameters.ClearCoatMask);
            SetBool(material, Property.ClearCoatSmoothness, parameters.ClearCoatSmoothness);

            // Obsolete Properties
            //SetFloat(material, Property.GlossMapScale, parameters.GlossMapScale);
            //SetFloat(material, Property.Glossiness, parameters.Glossiness);
            //SetFloat(material, Property.GlossyReflections, parameters.GlossyReflections);

            //SetTexture2DArray(material, Property.UnityLightmaps, parameters.UnityLightmaps);
            //SetTexture2DArray(material, Property.UnityLightmapsInd, parameters.UnityLightmapsInd);
            //SetTexture2DArray(material, Property.UnityShadowMasks, parameters.UnityShadowMasks);
        }

        /// <summary>
        /// Set the URP Simple Lit parameter value to the material.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="parameters"></param>
        private static void SetUrpSimpleLitParametersToMaterial(Material material, UrpSimpleLitDefinition parameters)
        {
            // Material Keywords
            SetBasicUrpKeywordsToMaterial(material, parameters);

            SetKeyword(material, Keyword.NormalMap, (parameters.BumpMap != null));

            SetKeyword(material, Keyword.ReveiveShadowsOff, (parameters.ReceiveShadows == false));

            SetKeyword(material, Keyword.Emission, (parameters.EmissionMap != null));

            SetKeyword(material, Keyword.SpecularHighlightsOff, (parameters.SpecularHighlights == false));

            SetBasicUrpParametersToMaterial(material, parameters);

            // Blending state
            SetFloat(material, Property.BlendModePreserveSpecular, parameters.BlendModePreserveSpecular);
            SetBool(material, Property.ReceiveShadows, parameters.ReceiveShadows);

            // Specular Gloss Map
            SetFloat(material, Property.Smoothness, parameters.Smoothness);

            SetColor(material, Property.SpecColor, parameters.SpecColor);
            SetTexture(material, Property.SpecGlossMap, parameters.SpecGlossMap);

            SetFloat(material, Property.SmoothnessSource, parameters.SmoothnessSource);

            SetBool(material, Property.SpecularHighlights, parameters.SpecularHighlights);

            // Bump Map (Normal Map)
            SetTexture(material, Property.BumpMap, parameters.BumpMap);
            SetFloat(material, Property.BumpScale, parameters.BumpScale);

            // Emission Map
            SetColor(material, Property.EmissionColor, parameters.EmissionColor);
            SetTexture(material, Property.EmissionMap, parameters.EmissionMap);

            // Obsolete Properties
            //SetFloat(material, Property.Shininess, parameters.Shininess);
            //SetFloat(material, Property.GlossinessSource, parameters.GlossinessSource);
            //SetFloat(material, Property.SpecSource, parameters.SpecSource);

            //SetTexture2DArray(material, Property.UnityLightmaps, parameters.UnityLightmaps);
            //SetTexture2DArray(material, Property.UnityLightmapsInd, parameters.UnityLightmapsInd);
            //SetTexture2DArray(material, Property.UnityShadowMasks, parameters.UnityShadowMasks);
        }

        /// <summary>
        /// Set the URP Unlit parameter value to the material.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="parameters"></param>
        private static void SetUrpUnlitParametersToMaterial(Material material, UrpUnlitDefinition parameters)
        {
            // Material Keywords
            SetBasicUrpKeywordsToMaterial(material, parameters);

            SetBasicUrpParametersToMaterial(material, parameters);

            // Blending state
            SetFloat(material, Property.BlendOp, parameters.BlendOp);

            // Obsolete Properties
            //SetFloat(material, Property.SampleGI, parameters.SampleGI);
        }

        /// <summary>
        /// Sets the surface type.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="surfaceType"></param>
        /// <param name="blendMode"></param>
        public static void SetSurfaceType(Material material, SurfaceType surfaceType, BlendMode? blendMode = null)
        {
            material.SetInt(Property.Surface, (int)surfaceType);

            if (blendMode.HasValue)
            {
                material.SetInt(Property.Blend, (int)blendMode);
            }

            switch (surfaceType)
            {
                case SurfaceType.Opaque:
                    material.SetInt(Property.SrcBlend, (int)UnityEngine.Rendering.BlendMode.One);
                    material.SetInt(Property.DstBlend, (int)UnityEngine.Rendering.BlendMode.Zero);
                    //material.SetInt(Property.AlphaSrcBlend, (int)UnityEngine.Rendering.BlendMode.One);
                    //material.SetInt(Property.AlphaDstBlend, (int)UnityEngine.Rendering.BlendMode.Zero);
                    material.SetInt(Property.ZWrite, 1);
                    //material.SetInt(Property.TransparentZWrite, 0);
                    //SetKeyword(material, Keyword.AlphaTestOn, false);
                    //SetKeyword(material, Keyword.AlphaBlendOn, false);
                    material.renderQueue = 2225;  // @notice
                    break;

                case SurfaceType.Transparent:
                    switch (blendMode)
                    {
                        case BlendMode.Alpha:
                            material.SetInt(Property.SrcBlend, (int)UnityEngine.Rendering.BlendMode.One);
                            material.SetInt(Property.DstBlend, (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
                            //material.SetInt(Property.AlphaSrcBlend, (int)UnityEngine.Rendering.BlendMode.One);
                            //material.SetInt(Property.AlphaDstBlend, (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
                            material.SetInt(Property.ZWrite, 0);
                            //material.SetInt(Property.TransparentZWrite, 0);
                            //SetKeyword(material, Keyword.AlphaTestOn, true);
                            //SetKeyword(material, Keyword.AlphaBlendOn, false);
                            //SetKeyword(material, Keyword.AlphaPremultiplyOn, false);
                            material.renderQueue = (int)UnityEngine.Rendering.RenderQueue.Transparent;
                            break;
                        case BlendMode.Additive:
                            material.SetInt(Property.SrcBlend, (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
                            material.SetInt(Property.DstBlend, (int)UnityEngine.Rendering.BlendMode.One);
                            //material.SetInt(Property.AlphaSrcBlend, (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
                            //material.SetInt(Property.AlphaDstBlend, (int)UnityEngine.Rendering.BlendMode.One);
                            material.SetInt(Property.ZWrite, 0);
                            //material.SetInt(Property.TransparentZWrite, 0);
                            //SetKeyword(material, Keyword.AlphaTestOn, false);
                            //SetKeyword(material, Keyword.AlphaBlendOn, true);
                            //SetKeyword(material, Keyword.AlphaPremultiplyOn, false);
                            material.renderQueue = (int)UnityEngine.Rendering.RenderQueue.Transparent;
                            break;
                        case BlendMode.Premultiply:
                            material.SetInt(Property.SrcBlend, (int)UnityEngine.Rendering.BlendMode.One);
                            material.SetInt(Property.DstBlend, (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
                            //material.SetInt(Property.AlphaSrcBlend, (int)UnityEngine.Rendering.BlendMode.One);
                            //material.SetInt(Property.AlphaDstBlend, (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
                            material.SetInt(Property.ZWrite, 0);
                            //material.SetInt(Property.TransparentZWrite, 0);
                            //SetKeyword(material, Keyword.AlphaTestOn, false);  // @notice true?
                            //SetKeyword(material, Keyword.AlphaBlendOn, false);
                            //SetKeyword(material, Keyword.AlphaPremultiplyOn, true);
                            material.renderQueue = (int)UnityEngine.Rendering.RenderQueue.Transparent;
                            break;
                    }
                    break;
            }
        }

        /// <summary>
        /// Sets bool value.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <param name="val"></param>
        private static void SetBool(Material material, string propertyName, bool val)
        {
            if (material.HasProperty(propertyName))
            {
                material.SetInt(propertyName, (val == true) ? 1 : 0);
            }
        }

        /// <summary>
        /// Sets int value.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <param name="val"></param>
        private static void SetInt(Material material, string propertyName, int val)
        {
            if (material.HasProperty(propertyName))
            {
                material.SetInt(propertyName, val);
            }
        }

        /// <summary>
        /// Sets float value.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <param name="val"></param>
        private static void SetFloat(Material material, string propertyName, float val)
        {
            if (material.HasProperty(propertyName))
            {
                material.SetFloat(propertyName, val);
            }
        }

        /// <summary>
        /// Sets color value.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <param name="color"></param>
        private static void SetColor(Material material, string propertyName, Color color)
        {
            if (material.HasProperty(propertyName))
            {
                material.SetColor(propertyName, color);
            }
        }

        /// <summary>
        /// Sets the Texture.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <param name="texture"></param>
        private static void SetTexture(Material material, string propertyName, Texture2D texture)
        {
            if (material.HasProperty(propertyName))
            {
                material.SetTexture(propertyName, texture);
            }
        }

        /// <summary>
        /// Sets the Vector.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <param name="vector"></param>
        private static void SetVector(Material material, string propertyName, Vector4 vector)
        {
            if (material.HasProperty(propertyName))
            {
                material.SetVector(propertyName, vector);
            }
        }

        /// <summary>
        /// Sets the keyword.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="keyword"></param>
        /// <param name="required"></param>
        private static void SetKeyword(Material material, string keyword, bool required)
        {
            if (required)
            {
                material.EnableKeyword(keyword);
            }
            else
            {
                material.DisableKeyword(keyword);
            }
        }
    }
}