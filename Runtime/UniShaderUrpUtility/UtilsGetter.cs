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
            return new UrpLitDefinition
            {
                WorkflowMode = GetEnum<WorkflowMode>(material, Property.WorkflowMode, WorkflowMode.Metallic),

                // Blending state
                Surface = GetEnum<SurfaceType>(material, Property.Surface, SurfaceType.Opaque),
                Blend = GetEnum<BlendMode>(material, Property.Blend, BlendMode.Alpha),
                Cull = GetEnum<CullMode>(material, Property.Cull, CullMode.Back),

                SrcBlend = GetFloat(material, Property.SrcBlend),
                DstBlend = GetFloat(material, Property.DstBlend),
                ZWrite = GetBool(material, Property.ZWrite),

                AlphaClip = GetBool(material, Property.AlphaClip),
                Cutoff = GetFloat(material, Property.Cutoff),

                ReceiveShadows = GetBool(material, Property.ReceiveShadows),

                // Base Map
                BaseColor = GetColor(material, Property.BaseColor),
                BaseMap = GetTexture(material, Property.BaseMap),

                // Metallic Gloss Map
                Metallic = GetFloat(material, Property.Metallic),
                MetallicGlossMap = GetTexture(material, Property.MetallicGlossMap),

                Smoothness = GetFloat(material, Property.Smoothness),
                SmoothnessTextureChannel = GetEnum<SmoothnessTextureChannel>(material, Property.SmoothnessTextureChannel),

                SpecColor = GetColor(material, Property.SpecColor),
                SpecGlossMap = GetTexture(material, Property.SpecGlossMap),

                SpecularHighlights = GetBool(material, Property.SpecularHighlights),
                EnvironmentReflections = GetBool(material, Property.EnvironmentReflections),

                // Bump Map (Normal Map)
                BumpMap = GetTexture(material, Property.BumpMap),
                BumpScale = GetFloat(material, Property.BumpScale),

                // Parallax Map (Height Map)
                Parallax = GetFloat(material, Property.Parallax),
                ParallaxMap = GetTexture(material, Property.ParallaxMap),

                // Occlusion Map
                OcclusionStrength = GetFloat(material, Property.OcclusionStrength),
                OcclusionMap = GetTexture(material, Property.OcclusionMap),

                // Emission Map
                EmissionColor = GetColor(material, Property.EmissionColor),
                EmissionMap = GetTexture(material, Property.EmissionMap),

                // Detail Inputs
                DetailMask = GetTexture(material, Property.DetailMask),
                DetailAlbedoMapScale = GetFloat(material, Property.DetailAlbedoMapScale),
                DetailAlbedoMap = GetTexture(material, Property.DetailAlbedoMap),
                DetailNormalMapScale = GetFloat(material, Property.DetailNormalMapScale),
                DetailNormalMap = GetTexture(material, Property.DetailNormalMap),

                // Advanced Options
                ClearCoatMask = GetBool(material, Property.ClearCoatMask),
                ClearCoatSmoothness = GetBool(material, Property.ClearCoatSmoothness),

                QueueOffset = GetInt(material, Property.QueueOffset),

                // Obsolete Properties
                //MainTex = GetTexture(material, Property.MainTex),
                //Color = GetColor(material, Property.Color),

                //GlossMapScale = GetFloat(material, Property.GlossMapScale),
                //Glossiness = GetFloat(material, Property.Glossiness),
                //GlossyReflections = GetFloat(material, Property.GlossyReflections),

                //UnityLightmaps = GetTexture2DArray(material, Property.UnityLightmaps),
                //UnityLightmapsInd = GetTexture2DArray(material, Property.UnityLightmapsInd),
                //UnityShadowMasks = GetTexture2DArray(material, Property.UnityShadowMasks),
            };
        }

        /// <summary>
        /// Get the URP SimpleLit parameters from the material.
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        private static UrpSimpleLitDefinition GetUrpSimpleLitParametersFromMaterial(Material material)
        {
            return new UrpSimpleLitDefinition
            {
                // Blending state
                Surface = GetEnum<SurfaceType>(material, Property.Surface, SurfaceType.Opaque),
                Blend = GetEnum<BlendMode>(material, Property.Blend, BlendMode.Alpha),
                Cull = GetEnum<CullMode>(material, Property.Cull, CullMode.Back),

                SrcBlend = GetFloat(material, Property.SrcBlend),
                DstBlend = GetFloat(material, Property.DstBlend),
                ZWrite = GetBool(material, Property.ZWrite),

                AlphaClip = GetBool(material, Property.AlphaClip),
                Cutoff = GetFloat(material, Property.Cutoff),

                BlendModePreserveSpecular = GetFloat(material, Property.BlendModePreserveSpecular),

                ReceiveShadows = GetBool(material, Property.ReceiveShadows),

                // Base Map
                BaseColor = GetColor(material, Property.BaseColor),
                BaseMap = GetTexture(material, Property.BaseMap),

                // Specular Gloss Map
                Smoothness = GetFloat(material, Property.Smoothness),

                SpecColor = GetColor(material, Property.SpecColor),
                SpecGlossMap = GetTexture(material, Property.SpecGlossMap),

                SmoothnessSource = GetFloat(material, Property.SmoothnessSource),

                SpecularHighlights = GetBool(material, Property.SpecularHighlights),

                // Bump Map (Normal Map)
                BumpMap = GetTexture(material, Property.BumpMap),
                BumpScale = GetFloat(material, Property.BumpScale),

                // Emission Map
                EmissionColor = GetColor(material, Property.EmissionColor),
                EmissionMap = GetTexture(material, Property.EmissionMap),

                // Editmode Properties
                QueueOffset = GetInt(material, Property.QueueOffset),

                // Obsolete Properties
                //MainTex = GetTexture(material, Property.MainTex),
                //Color = GetColor(material, Property.Color),

                //Shininess = GetFloat(material, Property.Shininess),
                //GlossinessSource = GetFloat(material, Property.GlossinessSource),
                //SpecSource = GetFloat(material, Property.SpecSource),

                //UnityLightmaps = GetTexture2DArray(material, Property.UnityLightmaps),
                //UnityLightmapsInd = GetTexture2DArray(material, Property.UnityLightmapsInd),
                //UnityShadowMasks = GetTexture2DArray(material, Property.UnityShadowMasks),
            };
        }

        /// <summary>
        /// Get the URP Unlit parameters from the material.
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        private static UrpUnlitDefinition GetUrpUnlitParametersFromMaterial(Material material)
        {
            return new UrpUnlitDefinition
            {
                // Blending state
                Surface = GetEnum<SurfaceType>(material, Property.Surface, SurfaceType.Opaque),
                Blend = GetEnum<BlendMode>(material, Property.Blend, BlendMode.Alpha),
                Cull = GetEnum<CullMode>(material, Property.Cull, CullMode.Back),

                SrcBlend = GetFloat(material, Property.SrcBlend),
                DstBlend = GetFloat(material, Property.DstBlend),
                ZWrite = GetBool(material, Property.ZWrite),

                AlphaClip = GetBool(material, Property.AlphaClip),
                Cutoff = GetFloat(material, Property.Cutoff),

                BlendOp = GetFloat(material, Property.BlendOp),

                // Base Map
                BaseColor = GetColor(material, Property.BaseColor),
                BaseMap = GetTexture(material, Property.BaseMap),

                // Editmode Properties
                QueueOffset = GetInt(material, Property.QueueOffset),

                // Obsolete Properties
                //MainTex = GetTexture(material, Property.MainTex),
                //Color = GetColor(material, Property.Color),
                //SampleGI = GetFloat(material, Property.SampleGI),
            };
        }

        /// <summary>
        /// Gets bool value.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        private static bool GetBool(Material material, string propertyName)
        {
            if (material.HasProperty(propertyName))
            {
                return material.GetInt(propertyName) == 1;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Gets color value.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        private static Color GetColor(Material material, string propertyName)
        {
            if (material.HasProperty(propertyName))
            {
                return material.GetColor(propertyName);
            }
            else
            {
                return default;
            }
        }

        /// <summary>
        /// Gets enum value.
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        private static TEnum GetEnum<TEnum>(Material material, string propertyName, TEnum? defaultValue = null) where TEnum : struct
        {
            int propertyValue = GetInt(material, propertyName);

            if (Enum.TryParse(propertyValue.ToString(), out TEnum result))
            {
                return result;
            }
            else if (defaultValue.HasValue)
            {
                return defaultValue.Value;
            }
            else
            {
                return default;
            }
        }

        /// <summary>
        /// Gets float value.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        private static float GetFloat(Material material, string propertyName)
        {
            if (material.HasProperty(propertyName))
            {
                return material.GetFloat(propertyName);
            }
            else
            {
                return 0.0f;
            }
        }

        /// <summary>
        /// Gets int value.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        private static int GetInt(Material material, string propertyName)
        {
            if (material.HasProperty(propertyName))
            {
                return material.GetInt(propertyName);
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Gets the Texture.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        private static Texture2D GetTexture(Material material, string propertyName)
        {
            if (material.HasProperty(propertyName))
            {
                return (Texture2D)material.GetTexture(propertyName);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Gets the Vector4.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        private static Vector4 GetVector4(Material material, string propertyName)
        {
            if (material.HasProperty(propertyName))
            {
                return material.GetVector(propertyName);
            }
            else
            {
                return default;
            }
        }
    }
}