// ----------------------------------------------------------------------
// @Namespace : UniParticleShader
// @Class     : Utils
// ----------------------------------------------------------------------
namespace UniParticleShader
{
    using UnityEngine;
    using UnityEngine.Rendering;

    public static partial class Utils
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        public static ParticleDefinition GetParametersFromMaterial(Material material)
        {
            return new ParticleDefinition
            {
                RenderMode = GetBlendMode(material),
                ColorMode = GetColorMode(material),
                FlipBookMode = GetFlipBookMode(material),
                CullMode = GetCullMode(material),
                SoftParticlesEnabled = GetInt(material, Property.SoftParticlesEnabled) == 1,
                SoftParticleFadeParams = GetVector(material, Property.SoftParticleFadeParams),
                CameraFadingEnabled = GetInt(material, Property.CameraFadingEnabled) == 1,
                CameraFadeParams = GetVector(material, Property.CameraFadeParams),
                DistortionEnabled = GetInt(material, Property.DistortionEnabled) == 1,
                GrabTexture = GetTexture(material, Property.GrabTexture),
                DistortionStrengthScaled = GetFloat(material, Property.DistortionStrengthScaled),
                DistortionBlend = GetFloat(material, Property.DistortionBlend),
                ColorAddSubDiff = GetColor(material, Property.ColorAddSubDiff),
                MainTex = GetTexture(material, Property.MainTex),
                MainTexSt = GetVector(material, Property.MainTexSt),
                Color = GetColor(material, Property.Color),
                Cutoff = GetFloat(material, Property.Cutoff),
                MetallicGlossMap = GetTexture(material, Property.MetallicGlossMap),
                Metallic = GetFloat(material, Property.Metallic),
                Glossiness = GetFloat(material, Property.Glossiness),
                BumpMap = GetTexture(material, Property.BumpMap),
                BumpScale = material.GetFloat(Property.BumpScale),
                LightingEnabled = (material.shader.name.Contains("Unlit") == false),
                EmissionEnabled = material.IsKeywordEnabled(Keyword.Emission),
                EmissionColor = GetColor(material, Property.EmissionColor),
                EmissionMap = GetTexture(material, Property.EmissionMap),
            };
        }

        /// <summary>
        /// 
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
        /// 
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
        /// 
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
        /// 
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
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        private static Vector4 GetVector(Material material, string propertyName)
        {
            if (material.HasProperty(propertyName))
            {
                return material.GetVector(propertyName);
            }
            else
            {
                return Vector4.zero;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        private static BlendMode GetBlendMode(Material material)
        {
            BlendMode blendMode = BlendMode.Opaque;

            if (material.IsKeywordEnabled(Keyword.AlphaTestOn))
            {
                blendMode = BlendMode.Cutout;
            }
            else if (material.IsKeywordEnabled(Keyword.AlphaModulateOn))
            {
                blendMode = BlendMode.Modulate;
            }
            else if (material.IsKeywordEnabled(Keyword.AlphaPremultiplyOn))
            {
                blendMode = BlendMode.Transparent;
            }
            else if (material.IsKeywordEnabled(Keyword.AlphaBlendOn))
            {
                Color colorAddSubDiff = GetColor(material, Property.ColorAddSubDiff);

                if (colorAddSubDiff == new Color(1.0f, 0.0f, 0.0f, 0.0f))
                {
                    blendMode = BlendMode.Additive;
                }
                else if (colorAddSubDiff == new Color(-1.0f, 0.0f, 0.0f, 0.0f))
                {
                    blendMode = BlendMode.Subtractive;
                }
                else
                {
                    blendMode = BlendMode.Fade;
                }
            }

            return blendMode;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        private static ColorMode GetColorMode(Material material)
        {
            ColorMode colorMode = ColorMode.Multiply;

            if (material.IsKeywordEnabled(Keyword.ColorOverlayOn))
            {
                colorMode = ColorMode.Overlay;
            }
            else if (material.IsKeywordEnabled(Keyword.ColorColorOn))
            {
                colorMode = ColorMode.Color;
            }
            else if (material.IsKeywordEnabled(Keyword.ColorAddSubDiffOn))
            {
                Color colorAddSubDiff = GetColor(material, Property.ColorAddSubDiff);

                if (colorAddSubDiff == new Color(1.0f, 0.0f, 0.0f, 0.0f))
                {
                    colorMode = ColorMode.Additive;
                }
                else if (colorAddSubDiff == new Color(-1.0f, 0.0f, 0.0f, 0.0f))
                {
                    colorMode = ColorMode.Subtractive;
                }
                else if (colorAddSubDiff == new Color(-1.0f, 1.0f, 0.0f, 0.0f))
                {
                    colorMode = ColorMode.Difference;
                }
                else
                {
                    colorMode = ColorMode.Additive;
                }
            }

            return colorMode;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        private static FlipBookMode GetFlipBookMode(Material material)
        {
            if (GetInt(material, Property.FlipbookMode) == 1)
            {
                return FlipBookMode.Blended;
            }
            else
            {
                return FlipBookMode.Simple;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        private static CullMode GetCullMode(Material material)
        {
            if (material.IsKeywordEnabled(Keyword.TwoSided))
            {
                return CullMode.Off;
            }
            else
            {
                return CullMode.Back;
            }
        }
    }
}