// ----------------------------------------------------------------------
// @Namespace : UniStandardShader
// @Class     : Utils
// ----------------------------------------------------------------------
namespace UniStandardShader
{
    using System;
    using UnityEngine;

    public static partial class Utils
    {
        /// <summary>
        /// Get the parameters from the material.
        /// </summary>
        /// <param name="material">The standard material.</param>
        /// <returns></returns>
        public static StandardDefinition GetParametersFromMaterial(Material material)
        {
            return new StandardDefinition
            {
                Mode = GetMode(material),
                Color = GetColor(material, Property.Color),
                MainTex = GetTexture(material, Property.MainTex),
                Cutoff = GetFloat(material, Property.Cutoff),
                Glossiness = GetFloat(material, Property.Glossiness),
                GlossMapScale = GetFloat(material, Property.GlossMapScale),
                SmoothnessTextureChannel = GetSmoothnessTextureChannel(material),
                Metallic = GetFloat(material, Property.Metallic),
                MetallicGlossMap = GetTexture(material, Property.MetallicGlossMap),
                SpecularHighlights = GetBool(material, Property.SpecularHighlights),
                GlossyReflections = GetBool(material, Property.GlossyReflections),
                BumpScale = GetFloat(material, Property.BumpScale),
                BumpMap = GetTexture(material, Property.BumpMap),
                Parallax = GetFloat(material, Property.Parallax),
                ParallaxMap = GetTexture(material, Property.ParallaxMap),
                OcclusionStrength = GetFloat(material, Property.OcclusionStrength),
                OcclusionMap = GetTexture(material, Property.OcclusionMap),
                EmissionColor = GetColor(material, Property.EmissionColor),
                EmissionMap = GetTexture(material, Property.EmissionMap),
                DetailMask = GetTexture(material, Property.DetailMask),
                DetailAlbedoMap = GetTexture(material, Property.DetailAlbedoMap),
                DetailNormalMapScale = GetFloat(material, Property.DetailNormalMapScale),
                DetailNormalMap = GetTexture(material, Property.DetailNormalMap),
                UVSec = GetUVSec(material),
            };
        }

        /// <summary>
        /// Get the mode.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="mode"></param>
        public static AlphaMode GetMode(Material material)
        {
            AlphaMode mode;

            int value = material.GetInt(Property.Mode);

            switch (value)
            {
                case 0:
                    mode = AlphaMode.Opaque;
                    break;
                case 1:
                    mode = AlphaMode.Mask;
                    break;
                case 2:
                    mode = AlphaMode.Blend;
                    break;
                default:
                    mode = AlphaMode.Opaque;
                    break;
            }

            return mode;
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
        /// Gets SmoothnessTextureChannel value.
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        private static SmoothnessTextureChannel GetSmoothnessTextureChannel(Material material)
        {
            if (GetInt(material, Property.SmoothnessTextureChannel) == 1)
            {
                return SmoothnessTextureChannel.AlbedoAlpha;
            }
            else
            {
                return SmoothnessTextureChannel.MetallicAlpha;
            }
        }

        /// <summary>
        /// Gets UV value.
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        private static UV GetUVSec(Material material)
        {
            if (GetInt(material, Property.UVSec) == 1)
            {
                return UV.UV1;
            }
            else
            {
                return UV.UV0;
            }
        }
    }
}