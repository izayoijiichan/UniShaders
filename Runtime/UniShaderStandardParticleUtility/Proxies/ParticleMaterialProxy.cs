// ----------------------------------------------------------------------
// @Namespace : UniParticleShader
// @Class     : ParticleMaterialProxy
// ----------------------------------------------------------------------
namespace UniParticleShader
{
    using System;
    using UniShader.Shared;
    using UnityEngine;

    /// <summary>
    /// Particle Material Proxy
    /// </summary>
    public class ParticleMaterialProxy
    {
        #region Fields

        /// <summary></summary>
        private readonly Material _Material;

        #endregion

        #region Properties

        /// <summary>Render Mode</summary>
        public BlendMode RenderMode
        {
            get => GetBlendMode();
            set => SetBlendMode(value);
        }

        /// <summary>Color Mode</summary>
        public ColorMode ColorMode
        {
            get => GetColorMode();
            set => SetColorMode(value);
        }

        /// <summary>Flip Book Mode</summary>
        public FlipBookMode FlipBookMode
        {
            get => _Material.GetSafeEnum<FlipBookMode>(Property.FlipbookMode, FlipBookMode.Simple);
            set
            {
                _Material.SetSafeInt(Property.FlipbookMode, (int)value);

                _Material.SetSafeKeyword(Keyword.RequireUv2, value == FlipBookMode.Blended);
            }
        }

        /// <summary>Cull Mode</summary>
        public UnityEngine.Rendering.CullMode Cull
        {
            get => _Material.GetSafeEnum<UnityEngine.Rendering.CullMode>(Property.Cull, UnityEngine.Rendering.CullMode.Back);
            set
            {
                _Material.SetSafeInt(Property.Cull, (int)value);

                _Material.SetSafeKeyword(Keyword.TwoSided, value == UnityEngine.Rendering.CullMode.Off);
            }
        }

        /// <summary>Two Sided</summary>
        public bool TwoSided
        {
            get => Cull == UnityEngine.Rendering.CullMode.Off;
            //set
            //{
            //    _Material.SetKeyword(Keyword.TwoSided, value == true);
            //    _Material.SetSafeInt(PropertyName.CullMode, value == true ? (int)UnityEngine.Rendering.CullMode.Off : (int)UnityEngine.Rendering.CullMode.Back);
            //}
        }

        /// <summary>Lighting Enabled</summary>
        /// <remarks>Standard Surface only</remarks>
        public bool LightingEnabled
        {
            get => _Material.GetSafeBool(Property.LightingEnabled, false);
            set => _Material.SetSafeBool(Property.LightingEnabled, value);
        }

        /// <summary>Main Texture</summary>
        public Texture2D MainTex
        {
            get => _Material.GetSafeTexture(Property.MainTex);
            set => _Material.SetSafeTexture(Property.MainTex, value);
        }

        /// <summary>Main Texture Scale Transform</summary>
        public Vector4 MainTexSt
        {
            get => _Material.GetSafeVector4(Property.MainTexSt, new Vector4(1.0f, 1.0f, 0.0f, 0.0f));
            set
            {
                _Material.SetSafeVector(Property.MainTexSt, value);

                _Material.SetSafeTextureScale(Property.MainTex, new Vector2(value.x, value.y));

                _Material.SetSafeTextureOffset(Property.MainTex, new Vector2(value.z, value.w));
            }
        }

        /// <summary>Main Texture Scale</summary>
        public Vector2 MainTexScale
        {
            get => _Material.GetSafeTextureScale(Property.MainTex, Vector2.one);
            set => _Material.SetSafeTextureScale(Property.MainTex, value);
        }

        /// <summary>Main Texture Offset</summary>
        public Vector2 MainTexOffset
        {
            get => _Material.GetSafeTextureOffset(Property.MainTex, Vector2.zero);
            set => _Material.SetSafeTextureOffset(Property.MainTex, value);
        }

        /// <summary>Color</summary>
        public Color Color
        {
            get => _Material.GetSafeColor(Property.Color, Color.white);
            set => _Material.SetSafeColor(Property.Color, value);
        }

        /// <summary>Color Add/Sub/Diff</summary>
        public Color ColorAddSubDiff
        {
            get => _Material.GetSafeColor(Property.ColorAddSubDiff, new Color(0.0f, 0.0f, 0.0f, 0.0f));
            set => _Material.SetSafeColor(Property.ColorAddSubDiff, value);
        }

        /// <summary>Alpha Cutoff</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float Cutoff
        {
            get => _Material.GetSafeFloat(Property.Cutoff, PropertyRange.Cutoff.defaultValue);
            set => _Material.SetSafeFloat(Property.Cutoff, PropertyRange.Cutoff, value);
        }

        /// <summary>Metallic Gloss Map</summary>
        public Texture2D MetallicGlossMap
        {
            get => _Material.GetSafeTexture(Property.MetallicGlossMap);
            set
            {
                _Material.SetSafeKeyword(Keyword.MetallicGlossMap, value != null);

                _Material.SetSafeTexture(Property.MetallicGlossMap, value);
            }
        }

        /// <summary>Metallic</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float Metallic
        {
            get => _Material.GetSafeFloat(Property.Metallic, PropertyRange.Metallic.defaultValue);
            set => _Material.SetSafeFloat(Property.Metallic, PropertyRange.Metallic, value);
        }

        /// <summary>Smoothness</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float Glossiness
        {
            get => _Material.GetSafeFloat(Property.Glossiness, PropertyRange.Glossiness.defaultValue);
            set => _Material.SetSafeFloat(Property.Glossiness, PropertyRange.Glossiness, value);
        }

        /// <summary>Normal Map</summary>
        public Texture2D BumpMap
        {
            get => _Material.GetSafeTexture(Property.BumpMap);
            set
            {
                _Material.SetSafeKeyword(Keyword.NormalMap, value != null);

                _Material.SetSafeTexture(Property.BumpMap, value);
            }
        }

        /// <summary>Normal Map Scale</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float BumpScale
        {
            get => _Material.GetSafeFloat(Property.BumpScale, PropertyRange.BumpScale.defaultValue);
            set => _Material.SetSafeFloat(Property.BumpScale, PropertyRange.BumpScale, value);
        }

        /// <summary>Emission Enabled</summary>
        public bool EmissionEnabled
        {
            get => _Material.GetSafeBool(Property.EmissionEnabled, false);
            set
            {
                _Material.SetSafeBool(Property.EmissionEnabled, value);

                _Material.SetSafeKeyword(Keyword.Emission, value == true);
            }
        }

        /// <summary>Emission Color</summary>
        public Color EmissionColor
        {
            get => _Material.GetSafeColor(Property.EmissionColor, new Color(0, 0f, 0.0f, 0.0f));
            set => _Material.SetSafeColor(Property.EmissionColor, value);
        }

        /// <summary>Emission Map</summary>
        public Texture2D EmissionMap
        {
            get => _Material.GetSafeTexture(Property.EmissionMap);
            set => _Material.SetSafeTexture(Property.EmissionMap, value);
        }

        /// <summary>Grab Texture</summary>
        /// <remarks>obsolete?</remarks>
        public Texture2D GrabTexture
        {
            get => _Material.GetSafeTexture(Property.GrabTexture);
            set => _Material.SetSafeTexture(Property.GrabTexture, value);
        }

        /// <summary>Soft Particles Enabled</summary>
        public bool SoftParticlesEnabled
        {
            get => _Material.GetSafeBool(Property.SoftParticlesEnabled, false);
            set => _Material.SetSafeBool(Property.SoftParticlesEnabled, value);
        }

        /// <summary>Soft Particle Fade Params</summary>
        public Vector4 SoftParticleFadeParams
        {
            get => _Material.GetSafeVector4(Property.SoftParticleFadeParams, Vector4.zero);
            set => _Material.SetSafeVector(Property.SoftParticleFadeParams, value);
        }

        /// <summary>Soft Particles Near Fade Distance</summary>
        public float SoftParticlesNearFadeDistance
        {
            get => _Material.GetSafeFloat(Property.SoftParticlesNearFadeDistance, PropertyRange.SoftParticlesNearFadeDistance.defaultValue);
            set => _Material.SetSafeFloat(Property.SoftParticlesNearFadeDistance, PropertyRange.SoftParticlesNearFadeDistance, value);
        }

        /// <summary>Soft Particles Far Fade Distance</summary>
        public float SoftParticlesFarFadeDistance
        {
            get => _Material.GetSafeFloat(Property.SoftParticlesFarFadeDistance, PropertyRange.SoftParticlesFarFadeDistance.defaultValue);
            set => _Material.SetSafeFloat(Property.SoftParticlesFarFadeDistance, PropertyRange.SoftParticlesFarFadeDistance, value);
        }

        /// <summary>Camera Fading Enabled</summary>
        public bool CameraFadingEnabled
        {
            get => _Material.GetSafeBool(Property.CameraFadingEnabled, false);
            set
            {
                _Material.SetSafeBool(Property.CameraFadingEnabled, value);

                _Material.SetSafeKeyword(Keyword.FadingOn, (value == true) && (ZWrite == false));
            }
        }

        /// <summary>Camera Fade Params</summary>
        public Vector4 CameraFadeParams
        {
            get => _Material.GetSafeVector4(Property.CameraFadeParams, Vector4.zero);
            set => _Material.SetSafeVector(Property.CameraFadeParams, value);
        }

        /// <summary>Camera Near Fade Distance</summary>
        public float CameraNearFadeDistance
        {
            get => _Material.GetSafeFloat(Property.CameraNearFadeDistance, PropertyRange.CameraNearFadeDistance.defaultValue);
            set => _Material.SetSafeFloat(Property.CameraNearFadeDistance, PropertyRange.CameraNearFadeDistance, value);
        }

        /// <summary>Camera Far Fade Distance</summary>
        public float CameraFarFadeDistance
        {
            get => _Material.GetSafeFloat(Property.CameraFarFadeDistance, PropertyRange.CameraFarFadeDistance.defaultValue);
            set => _Material.SetSafeFloat(Property.CameraFarFadeDistance, PropertyRange.CameraFarFadeDistance, value);
        }

        /// <summary>Distortion Enabled</summary>
        public bool DistortionEnabled
        {
            get => _Material.GetSafeBool(Property.DistortionEnabled, false);
            set
            {
                _Material.SetSafeBool(Property.DistortionEnabled, value);

                bool useDistortion = (value == true) && (ZWrite == false);

                _Material.SetSafeKeyword(Keyword.DistortionOn, useDistortion);

                _Material.SetSafeKeyword(Keyword.EffectBump, useDistortion);

                _Material.SetShaderPassEnabled("Always", useDistortion);
            }
        }

        /// <summary>Distortion Blend</summary>
        public float DistortionBlend
        {
            get => _Material.GetSafeFloat(Property.DistortionBlend, PropertyRange.DistortionBlend.defaultValue);
            set => _Material.SetSafeFloat(Property.DistortionBlend, PropertyRange.DistortionBlend, value);
        }

        /// <summary>Distortion Strength Scaled</summary>
        public float DistortionStrengthScaled
        {
            get => _Material.GetSafeFloat(Property.DistortionStrengthScaled, PropertyRange.DistortionStrengthScaled.defaultValue);
            set => _Material.SetSafeFloat(Property.DistortionStrengthScaled, PropertyRange.DistortionStrengthScaled, value);
        }

        /// <summary>Blend Operation</summary>
        public UnityEngine.Rendering.BlendOp BlendOp
        {
            get => _Material.GetSafeEnum<UnityEngine.Rendering.BlendOp>(Property.BlendOp, UnityEngine.Rendering.BlendOp.Add);
            private set => _Material.SetSafeInt(Property.BlendOp, (int)value);
        }

        /// <summary>Src Blend</summary>
        public UnityEngine.Rendering.BlendMode SrcBlend
        {
            get => _Material.GetSafeEnum<UnityEngine.Rendering.BlendMode>(Property.SrcBlend, UnityEngine.Rendering.BlendMode.One);
            private set => _Material.SetSafeInt(Property.SrcBlend, (int)value);
        }

        /// <summary>Dst Blend</summary>
        public UnityEngine.Rendering.BlendMode DstBlend
        {
            get => _Material.GetSafeEnum<UnityEngine.Rendering.BlendMode>(Property.DstBlend, UnityEngine.Rendering.BlendMode.Zero);
            private set => _Material.SetSafeInt(Property.DstBlend, (int)value);
        }

        /// <summary>ZWrite</summary>
        public bool ZWrite
        {
            get => _Material.GetSafeBool(Property.ZWrite, true);
            private set
            {
                _Material.SetSafeBool(Property.ZWrite, value);

                _Material.SetSafeKeyword(Keyword.FadingOn, CameraFadingEnabled && value == false);

                bool useDistortion = DistortionEnabled && value == false;

                _Material.SetSafeKeyword(Keyword.DistortionOn, useDistortion);

                _Material.SetSafeKeyword(Keyword.EffectBump, useDistortion);

                _Material.SetShaderPassEnabled("Always", useDistortion);
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of ParticleMaterialProxy.
        /// </summary>
        /// <param name="material">The particle material.</param>
        public ParticleMaterialProxy(Material material)
        {
            if (material == null)
            {
                throw new ArgumentNullException(nameof(material));
            }

            if (material.shader == null)
            {
                throw new ArgumentException();
            }

            if (material.shader.name == null)
            {
                throw new ArgumentException();
            }

            if ((material.shader.name != ShaderName.Particles_Standard_Surface) &&
                (material.shader.name != ShaderName.Particles_Standard_Unlit))
            {
                throw new ArgumentException();
            }

            _Material = material;
        }

        #endregion

        #region Private Methods (Get)

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private BlendMode GetBlendMode()
        {
            if (_Material.HasProperty(Property.BlendMode))
            {
                return _Material.GetSafeEnum<BlendMode>(Property.BlendMode);
            }

            BlendMode blendMode = BlendMode.Opaque;

            if (_Material.IsKeywordEnabled(Keyword.AlphaTestOn))
            {
                blendMode = BlendMode.Cutout;
            }
            else if (_Material.IsKeywordEnabled(Keyword.AlphaModulateOn))
            {
                blendMode = BlendMode.Modulate;
            }
            else if (_Material.IsKeywordEnabled(Keyword.AlphaPremultiplyOn))
            {
                blendMode = BlendMode.Transparent;
            }
            else if (_Material.IsKeywordEnabled(Keyword.AlphaBlendOn))
            {
                Color colorAddSubDiff = ColorAddSubDiff;

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
        /// <returns></returns>
        private ColorMode GetColorMode()
        {
            if (_Material.HasProperty(Property.ColorMode))
            {
                return _Material.GetSafeEnum<ColorMode>(Property.ColorMode);
            }

            ColorMode colorMode = ColorMode.Multiply;

            if (_Material.IsKeywordEnabled(Keyword.ColorOverlayOn))
            {
                colorMode = ColorMode.Overlay;
            }
            else if (_Material.IsKeywordEnabled(Keyword.ColorColorOn))
            {
                colorMode = ColorMode.Color;
            }
            else if (_Material.IsKeywordEnabled(Keyword.ColorAddSubDiffOn))
            {
                Color colorAddSubDiff = ColorAddSubDiff;

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

        #endregion

        #region Public Methods (Set)

        /// <summary>
        /// 
        /// </summary>
        /// <param name="blendMode"></param>
        private void SetBlendMode(in BlendMode blendMode)
        {
            _Material.SetSafeInt(Property.BlendMode, (int)blendMode);

            switch (blendMode)
            {
                case BlendMode.Opaque:
                    _Material.SetOverrideTag(Tag.RenderType, RenderTypeValue.Opaque);

                    BlendOp = UnityEngine.Rendering.BlendOp.Add;
                    SrcBlend = UnityEngine.Rendering.BlendMode.One;
                    DstBlend = UnityEngine.Rendering.BlendMode.Zero;
                    ZWrite = true;

                    _Material.SetSafeKeyword(Keyword.AlphaTestOn, false);
                    _Material.SetSafeKeyword(Keyword.AlphaBlendOn, false);
                    _Material.SetSafeKeyword(Keyword.AlphaPremultiplyOn, false);
                    _Material.SetSafeKeyword(Keyword.AlphaModulateOn, false);

                    _Material.renderQueue = -1;
                    break;
                case BlendMode.Cutout:
                    _Material.SetOverrideTag(Tag.RenderType, RenderTypeValue.TransparentCutout);

                    BlendOp = UnityEngine.Rendering.BlendOp.Add;
                    SrcBlend = UnityEngine.Rendering.BlendMode.One;
                    DstBlend = UnityEngine.Rendering.BlendMode.Zero;
                    ZWrite = true;

                    _Material.SetSafeKeyword(Keyword.AlphaTestOn, true);
                    _Material.SetSafeKeyword(Keyword.AlphaBlendOn, false);
                    _Material.SetSafeKeyword(Keyword.AlphaPremultiplyOn, false);
                    _Material.SetSafeKeyword(Keyword.AlphaModulateOn, false);

                    _Material.renderQueue = (int)UnityEngine.Rendering.RenderQueue.AlphaTest;
                    break;
                case BlendMode.Fade:
                    _Material.SetOverrideTag(Tag.RenderType, RenderTypeValue.Transparent);

                    BlendOp = UnityEngine.Rendering.BlendOp.Add;
                    SrcBlend = UnityEngine.Rendering.BlendMode.SrcAlpha;
                    DstBlend = UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha;
                    ZWrite = false;

                    _Material.SetSafeKeyword(Keyword.AlphaTestOn, false);
                    _Material.SetSafeKeyword(Keyword.AlphaBlendOn, true);
                    _Material.SetSafeKeyword(Keyword.AlphaPremultiplyOn, false);
                    _Material.SetSafeKeyword(Keyword.AlphaModulateOn, false);

                    _Material.renderQueue = (int)UnityEngine.Rendering.RenderQueue.Transparent;
                    break;
                case BlendMode.Transparent:
                    _Material.SetOverrideTag(Tag.RenderType, RenderTypeValue.Transparent);

                    BlendOp = UnityEngine.Rendering.BlendOp.Add;
                    SrcBlend = UnityEngine.Rendering.BlendMode.One;
                    DstBlend = UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha;
                    ZWrite = false;

                    _Material.SetSafeKeyword(Keyword.AlphaTestOn, false);
                    _Material.SetSafeKeyword(Keyword.AlphaBlendOn, false);
                    _Material.SetSafeKeyword(Keyword.AlphaPremultiplyOn, true);
                    _Material.SetSafeKeyword(Keyword.AlphaModulateOn, false);

                    _Material.renderQueue = (int)UnityEngine.Rendering.RenderQueue.Transparent;
                    break;
                case BlendMode.Additive:
                    _Material.SetOverrideTag(Tag.RenderType, RenderTypeValue.Transparent);

                    BlendOp = UnityEngine.Rendering.BlendOp.Add;
                    SrcBlend = UnityEngine.Rendering.BlendMode.SrcAlpha;
                    DstBlend = UnityEngine.Rendering.BlendMode.One;
                    ZWrite = false;

                    _Material.SetSafeKeyword(Keyword.AlphaTestOn, false);
                    _Material.SetSafeKeyword(Keyword.AlphaBlendOn, true);
                    _Material.SetSafeKeyword(Keyword.AlphaPremultiplyOn, false);
                    _Material.SetSafeKeyword(Keyword.AlphaModulateOn, false);

                    _Material.renderQueue = (int)UnityEngine.Rendering.RenderQueue.Transparent;
                    break;
                case BlendMode.Subtractive:
                    _Material.SetOverrideTag(Tag.RenderType, RenderTypeValue.Transparent);

                    BlendOp = UnityEngine.Rendering.BlendOp.ReverseSubtract;
                    SrcBlend = UnityEngine.Rendering.BlendMode.SrcAlpha;
                    DstBlend = UnityEngine.Rendering.BlendMode.One;
                    ZWrite = false;

                    _Material.SetSafeKeyword(Keyword.AlphaTestOn, false);
                    _Material.SetSafeKeyword(Keyword.AlphaBlendOn, true);
                    _Material.SetSafeKeyword(Keyword.AlphaPremultiplyOn, false);
                    _Material.SetSafeKeyword(Keyword.AlphaModulateOn, false);

                    _Material.renderQueue = (int)UnityEngine.Rendering.RenderQueue.Transparent;
                    break;
                case BlendMode.Modulate:
                    _Material.SetOverrideTag(Tag.RenderType, RenderTypeValue.Transparent);

                    BlendOp = UnityEngine.Rendering.BlendOp.Add;
                    SrcBlend = UnityEngine.Rendering.BlendMode.DstColor;
                    DstBlend = UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha;
                    ZWrite = false;

                    _Material.SetSafeKeyword(Keyword.AlphaTestOn, false);
                    _Material.SetSafeKeyword(Keyword.AlphaBlendOn, false);
                    _Material.SetSafeKeyword(Keyword.AlphaPremultiplyOn, false);
                    _Material.SetSafeKeyword(Keyword.AlphaModulateOn, true);

                    _Material.renderQueue = (int)UnityEngine.Rendering.RenderQueue.Transparent;
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="colorMode"></param>
        private void SetColorMode(in ColorMode colorMode)
        {
            _Material.SetSafeInt(Property.ColorMode, (int)colorMode);

            switch (colorMode)
            {
                case ColorMode.Multiply:
                    _Material.SetSafeKeyword(Keyword.ColorOverlayOn, false);
                    _Material.SetSafeKeyword(Keyword.ColorColorOn, false);
                    _Material.SetSafeKeyword(Keyword.ColorAddSubDiffOn, false);
                    break;
                case ColorMode.Overlay:
                    _Material.SetSafeKeyword(Keyword.ColorOverlayOn, true);
                    _Material.SetSafeKeyword(Keyword.ColorColorOn, false);
                    _Material.SetSafeKeyword(Keyword.ColorAddSubDiffOn, false);
                    break;
                case ColorMode.Color:
                    _Material.SetSafeKeyword(Keyword.ColorOverlayOn, false);
                    _Material.SetSafeKeyword(Keyword.ColorColorOn, true);
                    _Material.SetSafeKeyword(Keyword.ColorAddSubDiffOn, false);
                    break;
                case ColorMode.Additive:
                case ColorMode.Subtractive:
                case ColorMode.Difference:
                    _Material.SetSafeKeyword(Keyword.ColorOverlayOn, false);
                    _Material.SetSafeKeyword(Keyword.ColorColorOn, false);
                    _Material.SetSafeKeyword(Keyword.ColorAddSubDiffOn, true);
                    break;
            }
        }

        #endregion
    }
}