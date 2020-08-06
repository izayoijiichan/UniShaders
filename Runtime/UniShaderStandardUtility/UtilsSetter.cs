// ----------------------------------------------------------------------
// @Namespace : UniStandardShader
// @Class     : Utils
// ----------------------------------------------------------------------
namespace UniStandardShader
{
    using UnityEngine;

    public static partial class Utils
    {
        /// <summary>
        /// Set the parameter value to the material.
        /// </summary>
        /// <param name="material">The standard material.</param>
        /// <param name="parameters"></param>
        public static void SetParametersToMaterial(Material material, StandardDefinition parameters)
        {
            SetMode(material, parameters.Mode);

            SetColor(material, Property.Color, parameters.Color);
            SetTexture(material, Property.MainTex, parameters.MainTex);
            SetFloat(material, Property.Cutoff, parameters.Cutoff);

            SetKeyword(material, Keyword.MetallicGlossMap, (parameters.MetallicGlossMap != null));
            
            SetFloat(material, Property.Glossiness, parameters.Glossiness);
            SetFloat(material, Property.GlossMapScale, parameters.GlossMapScale);
            SetInt(material, Property.SmoothnessTextureChannel, (int)parameters.SmoothnessTextureChannel);
            SetFloat(material, Property.Metallic, parameters.Metallic);
            SetTexture(material, Property.MetallicGlossMap, parameters.MetallicGlossMap);
            SetBool(material, Property.SpecularHighlights, parameters.SpecularHighlights);
            SetBool(material, Property.GlossyReflections, parameters.GlossyReflections);

            SetKeyword(material, Keyword.NormalMap, (parameters.BumpMap != null));

            SetFloat(material, Property.BumpScale, parameters.BumpScale);
            SetTexture(material, Property.BumpMap, parameters.BumpMap);

            SetKeyword(material, Keyword.ParallaxMap, (parameters.ParallaxMap != null));

            SetFloat(material, Property.Parallax, parameters.Parallax);
            SetTexture(material, Property.ParallaxMap, parameters.ParallaxMap);

            SetFloat(material, Property.OcclusionStrength, parameters.OcclusionStrength);
            SetTexture(material, Property.OcclusionMap, parameters.OcclusionMap);

            SetKeyword(material, Keyword.Emission, (parameters.EmissionMap != null));

            SetColor(material, Property.EmissionColor, parameters.EmissionColor);
            SetTexture(material, Property.EmissionMap, parameters.EmissionMap);

            // @notice
            SetKeyword(material, Keyword.DetailMulx2, (parameters.DetailMask != null) || (parameters.DetailAlbedoMap != null) || (parameters.DetailNormalMap != null));

            SetTexture(material, Property.DetailMask, parameters.DetailMask);
            SetTexture(material, Property.DetailAlbedoMap, parameters.DetailAlbedoMap);
            SetFloat(material, Property.DetailNormalMapScale, parameters.DetailNormalMapScale);
            SetTexture(material, Property.DetailNormalMap, parameters.DetailNormalMap);
            SetInt(material, Property.UVSec, (int)parameters.UVSec);
        }

        /// <summary>
        /// Sets the mode.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="mode"></param>
        public static void SetMode(Material material, AlphaMode mode)
        {
            material.SetInt(Property.Mode, (int)mode);

            switch (mode)
            {
                case AlphaMode.Opaque:
                    material.SetOverrideTag(Tag.RenderType, RenderTypeValue.Opaque);
                    material.SetInt(Property.SrcBlend, (int)UnityEngine.Rendering.BlendMode.One);
                    material.SetInt(Property.DstBlend, (int)UnityEngine.Rendering.BlendMode.Zero);
                    material.SetInt(Property.ZWrite, 1);
                    material.DisableKeyword(Keyword.AlphaTestOn);
                    material.DisableKeyword(Keyword.AlphaBlendOn);
                    material.DisableKeyword(Keyword.AlphaPreMultiplyOn);
                    material.renderQueue = -1;
                    break;

                case AlphaMode.Blend:
                    material.SetOverrideTag(Tag.RenderType, RenderTypeValue.Transparent);
                    material.SetInt(Property.SrcBlend, (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
                    material.SetInt(Property.DstBlend, (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
                    material.SetInt(Property.ZWrite, 0);
                    material.DisableKeyword(Keyword.AlphaTestOn);
                    material.EnableKeyword(Keyword.AlphaBlendOn);
                    material.DisableKeyword(Keyword.AlphaPreMultiplyOn);
                    material.renderQueue = 3000;
                    break;

                case AlphaMode.Mask:
                    material.SetOverrideTag(Tag.RenderType, RenderTypeValue.TransparentCutout);
                    material.SetInt(Property.SrcBlend, (int)UnityEngine.Rendering.BlendMode.One);
                    material.SetInt(Property.DstBlend, (int)UnityEngine.Rendering.BlendMode.Zero);
                    material.SetInt(Property.ZWrite, 1);
                    material.EnableKeyword(Keyword.AlphaTestOn);
                    material.DisableKeyword(Keyword.AlphaBlendOn);
                    material.DisableKeyword(Keyword.AlphaPreMultiplyOn);
                    material.renderQueue = 2450;
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