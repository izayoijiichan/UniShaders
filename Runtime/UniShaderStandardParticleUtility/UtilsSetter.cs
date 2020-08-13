// ----------------------------------------------------------------------
// @Namespace : UniParticleShader
// @Class     : Utils
// ----------------------------------------------------------------------
namespace UniParticleShader
{
    using UnityEngine;

    public static partial class Utils
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <param name="parameters"></param>
        public static void SetParametersToMaterial(Material material, ParticleDefinition parameters)
        {
            material.SetInt(Property.BlendMode, (int)parameters.RenderMode);

            //SetColorMode(material, parameters.ColorMode);

            SetInt(material, Property.FlipbookMode, (int)parameters.FlipBookMode);
            SetInt(material, Property.CullMode, (int)parameters.CullMode);

            SetKeyword(material, Keyword.RequireUv2, parameters.FlipBookMode == FlipBookMode.Blended);
            SetKeyword(material, Keyword.TwoSided, parameters.CullMode == UnityEngine.Rendering.CullMode.Off);
            SetKeyword(material, Keyword.FadingOn, parameters.CameraFadingEnabled);
            SetKeyword(material, Keyword.DistortionOn, parameters.DistortionEnabled);
            SetKeyword(material, Keyword.EffectBump, parameters.DistortionEnabled);
            SetKeyword(material, Keyword.NormalMap, (parameters.BumpMap != null));
            SetKeyword(material, Keyword.MetallicGlossMap, (parameters.MetallicGlossMap != null));
            SetKeyword(material, Keyword.Emission, parameters.EmissionEnabled);

            SetBool(material, Property.SoftParticlesEnabled, parameters.SoftParticlesEnabled);
            SetVector(material, Property.SoftParticleFadeParams, parameters.SoftParticleFadeParams);
            //SetFloat(material, Property.SoftParticleNearFadeDistance, parameters.SoftParticleFadeParams.x);
            //SetFloat(material, Property.SoftParticleFarFadeDistance, parameters.SoftParticleFadeParams.y);

            SetBool(material, Property.CameraFadingEnabled, parameters.CameraFadingEnabled);
            SetVector(material, Property.CameraFadeParams, parameters.CameraFadeParams);
            //SetFloat(material, Property.CameraNearFadeDistance, parameters.CameraFadeParams.x);
            //SetFloat(material, Property.CameraFarFadeDistance, parameters.CameraFadeParams.y);

            SetBool(material, Property.DistortionEnabled, parameters.DistortionEnabled);
            SetTexture(material, Property.GrabTexture, parameters.GrabTexture);
            SetFloat(material, Property.DistortionStrengthScaled, parameters.DistortionStrengthScaled);
            SetFloat(material, Property.DistortionBlend, parameters.DistortionBlend);
            SetColor(material, Property.ColorAddSubDiff, parameters.ColorAddSubDiff);

            SetTexture(material, Property.MainTex, parameters.MainTex);
            SetVector(material, Property.MainTexSt, parameters.MainTexSt);
            //material.SetTextureScale(Property.MainTex, new Vector2(parameters.MainTexSt[0], parameters.MainTexSt[1]));
            //material.SetTextureOffset(Property.MainTex, new Vector2(parameters.MainTexSt[2], parameters.MainTexSt[3]));
            SetColor(material, Property.Color, parameters.Color);
            SetFloat(material, Property.Cutoff, parameters.Cutoff);

            SetTexture(material, Property.MetallicGlossMap, parameters.MetallicGlossMap);
            SetFloat(material, Property.Metallic, parameters.Metallic);
            SetFloat(material, Property.Glossiness, parameters.Glossiness);

            SetTexture(material, Property.BumpMap, parameters.BumpMap);
            SetFloat(material, Property.BumpScale, parameters.BumpScale);

            SetBool(material, Property.LightingEnabled, parameters.LightingEnabled);
            SetBool(material, Property.EmissionEnabled, parameters.EmissionEnabled);
            SetColor(material, Property.EmissionColor, parameters.EmissionColor);
            SetTexture(material, Property.EmissionMap, parameters.EmissionMap);

            material.SetShaderPassEnabled("Always", parameters.DistortionEnabled);

            //material.mainTexture = parameters.MainTex;
            //material.color = parameters.Color;
            //material.mainTextureScale = new Vector2(parameters.MainTexSt[0], parameters.MainTexSt[1]);
            //material.mainTextureOffset = new Vector2(parameters.MainTexSt[2], parameters.MainTexSt[3]);

            SetBlendMode(material, parameters.RenderMode);
            SetColorMode(material, parameters.ColorMode);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <param name="blendMode"></param>
        public static void SetBlendMode(Material material, BlendMode blendMode)
        {
            //material.SetInt(Property.BlendMode, (int)blendMode);

            switch (blendMode)
            {
                case BlendMode.Opaque:
                    material.SetOverrideTag(Tag.RenderType, RenderTypeValue.Opaque);
                    material.SetInt(Property.BlendOp, (int)UnityEngine.Rendering.BlendOp.Add);
                    material.SetInt(Property.SrcBlend, (int)UnityEngine.Rendering.BlendMode.One);
                    material.SetInt(Property.DstBlend, (int)UnityEngine.Rendering.BlendMode.Zero);
                    material.SetInt(Property.ZWrite, 1);
                    SetKeyword(material, Keyword.AlphaTestOn, false);
                    SetKeyword(material, Keyword.AlphaBlendOn, false);
                    SetKeyword(material, Keyword.AlphaPremultiplyOn, false);
                    SetKeyword(material, Keyword.AlphaModulateOn, false);
                    material.renderQueue = -1;
                    break;
                case BlendMode.Cutout:
                    material.SetOverrideTag(Tag.RenderType, RenderTypeValue.TransparentCutout);
                    material.SetInt(Property.BlendOp, (int)UnityEngine.Rendering.BlendOp.Add);
                    material.SetInt(Property.SrcBlend, (int)UnityEngine.Rendering.BlendMode.One);
                    material.SetInt(Property.DstBlend, (int)UnityEngine.Rendering.BlendMode.Zero);
                    material.SetInt(Property.ZWrite, 1);
                    SetKeyword(material, Keyword.AlphaTestOn, true);
                    SetKeyword(material, Keyword.AlphaBlendOn, false);
                    SetKeyword(material, Keyword.AlphaPremultiplyOn, false);
                    SetKeyword(material, Keyword.AlphaModulateOn, false);
                    material.renderQueue = (int)UnityEngine.Rendering.RenderQueue.AlphaTest;
                    break;
                case BlendMode.Fade:
                    material.SetOverrideTag(Tag.RenderType, RenderTypeValue.Transparent);
                    material.SetInt(Property.BlendOp, (int)UnityEngine.Rendering.BlendOp.Add);
                    material.SetInt(Property.SrcBlend, (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
                    material.SetInt(Property.DstBlend, (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
                    material.SetInt(Property.ZWrite, 0);
                    SetKeyword(material, Keyword.AlphaTestOn, false);
                    SetKeyword(material, Keyword.AlphaBlendOn, true);
                    SetKeyword(material, Keyword.AlphaPremultiplyOn, false);
                    SetKeyword(material, Keyword.AlphaModulateOn, false);
                    material.renderQueue = (int)UnityEngine.Rendering.RenderQueue.Transparent;
                    break;
                case BlendMode.Transparent:
                    material.SetOverrideTag(Tag.RenderType, RenderTypeValue.Transparent);
                    material.SetInt(Property.BlendOp, (int)UnityEngine.Rendering.BlendOp.Add);
                    material.SetInt(Property.SrcBlend, (int)UnityEngine.Rendering.BlendMode.One);
                    material.SetInt(Property.DstBlend, (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
                    material.SetInt(Property.ZWrite, 0);
                    SetKeyword(material, Keyword.AlphaTestOn, false);
                    SetKeyword(material, Keyword.AlphaBlendOn, false);
                    SetKeyword(material, Keyword.AlphaPremultiplyOn, true);
                    SetKeyword(material, Keyword.AlphaModulateOn, false);
                    material.renderQueue = (int)UnityEngine.Rendering.RenderQueue.Transparent;
                    break;
                case BlendMode.Additive:
                    material.SetOverrideTag(Tag.RenderType, RenderTypeValue.Transparent);
                    material.SetInt(Property.BlendOp, (int)UnityEngine.Rendering.BlendOp.Add);
                    material.SetInt(Property.SrcBlend, (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
                    material.SetInt(Property.DstBlend, (int)UnityEngine.Rendering.BlendMode.One);
                    material.SetInt(Property.ZWrite, 0);
                    SetKeyword(material, Keyword.AlphaTestOn, false);
                    SetKeyword(material, Keyword.AlphaBlendOn, true);
                    SetKeyword(material, Keyword.AlphaPremultiplyOn, false);
                    SetKeyword(material, Keyword.AlphaModulateOn, false);
                    material.renderQueue = (int)UnityEngine.Rendering.RenderQueue.Transparent;
                    break;
                case BlendMode.Subtractive:
                    material.SetOverrideTag(Tag.RenderType, RenderTypeValue.Transparent);
                    material.SetInt(Property.BlendOp, (int)UnityEngine.Rendering.BlendOp.ReverseSubtract);
                    material.SetInt(Property.SrcBlend, (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
                    material.SetInt(Property.DstBlend, (int)UnityEngine.Rendering.BlendMode.One);
                    material.SetInt(Property.ZWrite, 0);
                    SetKeyword(material, Keyword.AlphaTestOn, false);
                    SetKeyword(material, Keyword.AlphaBlendOn, true);
                    SetKeyword(material, Keyword.AlphaPremultiplyOn, false);
                    SetKeyword(material, Keyword.AlphaModulateOn, false);
                    material.renderQueue = (int)UnityEngine.Rendering.RenderQueue.Transparent;
                    break;
                case BlendMode.Modulate:
                    material.SetOverrideTag(Tag.RenderType, RenderTypeValue.Transparent);
                    material.SetInt(Property.BlendOp, (int)UnityEngine.Rendering.BlendOp.Add);
                    material.SetInt(Property.SrcBlend, (int)UnityEngine.Rendering.BlendMode.DstColor);
                    material.SetInt(Property.DstBlend, (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
                    material.SetInt(Property.ZWrite, 0);
                    SetKeyword(material, Keyword.AlphaTestOn, false);
                    SetKeyword(material, Keyword.AlphaBlendOn, false);
                    SetKeyword(material, Keyword.AlphaPremultiplyOn, false);
                    SetKeyword(material, Keyword.AlphaModulateOn, true);
                    material.renderQueue = (int)UnityEngine.Rendering.RenderQueue.Transparent;
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <param name="colorMode"></param>
        public static void SetColorMode(Material material, ColorMode colorMode)
        {
            switch (colorMode)
            {
                case ColorMode.Multiply:
                    SetKeyword(material, Keyword.ColorOverlayOn, false);
                    SetKeyword(material, Keyword.ColorColorOn, false);
                    SetKeyword(material, Keyword.ColorAddSubDiffOn, false);
                    break;
                case ColorMode.Overlay:
                    SetKeyword(material, Keyword.ColorOverlayOn, true);
                    SetKeyword(material, Keyword.ColorColorOn, false);
                    SetKeyword(material, Keyword.ColorAddSubDiffOn, false);
                    break;
                case ColorMode.Color:
                    SetKeyword(material, Keyword.ColorOverlayOn, false);
                    SetKeyword(material, Keyword.ColorColorOn, true);
                    SetKeyword(material, Keyword.ColorAddSubDiffOn, false);
                    break;
                case ColorMode.Additive:
                case ColorMode.Subtractive:
                case ColorMode.Difference:
                    SetKeyword(material, Keyword.ColorOverlayOn, false);
                    SetKeyword(material, Keyword.ColorColorOn, false);
                    SetKeyword(material, Keyword.ColorAddSubDiffOn, true);
                    break;
            }
        }

        /// <summary>
        /// 
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
        /// 
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
        /// 
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
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <param name="val"></param>
        private static void SetVector(Material material, string propertyName, Vector4 val)
        {
            if (material.HasProperty(propertyName))
            {
                material.SetVector(propertyName, val);
            }
        }

        /// <summary>
        /// 
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
        /// 
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
        /// 
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