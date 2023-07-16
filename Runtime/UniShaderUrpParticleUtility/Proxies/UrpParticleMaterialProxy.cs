// ----------------------------------------------------------------------
// @Namespace : UniUrpParticleShader
// @Class     : UrpParticleMaterialProxy
// ----------------------------------------------------------------------
namespace UniUrpParticleShader
{
    using System;
    using UniShader.Shared;
    using UnityEngine;

    /// <summary>
    /// URP Particle Material Proxy
    /// </summary>
    public class UrpParticleMaterialProxy
    {
        #region Fields

        /// <summary></summary>
        private readonly Material _Material;

        #endregion

        #region Properties

        /// <summary>Surface Type</summary>
        //[DefaultValue(SurfaceType.Opaque)]
        public SurfaceType Surface
        {
            get => _Material.GetSafeEnum<SurfaceType>(Property.Surface, SurfaceType.Opaque);
            set => SetSurfaceType(value);
        }

        /// <summary>Blend Mode</summary>
        //[DefaultValue(BlendMode.Alpha)]
        public BlendMode Blend
        {
            get => _Material.GetSafeEnum<BlendMode>(Property.Blend, BlendMode.Alpha);
            set => SetBlendMode(value);
        }

        /// <summary>Blend Mode Preserve Specular</summary>
        public bool BlendModePreserveSpecular
        {
            get => _Material.GetSafeBool(Property.BlendModePreserveSpecular, false);
            set => _Material.SetSafeBool(Property.BlendModePreserveSpecular, value);
        }

        /// <summary>Color Mode</summary>
        public ColorMode ColorMode
        {
            get => _Material.GetSafeEnum<ColorMode>(Property.ColorMode, ColorMode.Multiply);
            set => SetColorMode(value);
        }

        /// <summary>Cull Mode</summary>
        //[DefaultValue(CullMode.Back)]
        public UnityEngine.Rendering.CullMode Cull
        {
            get => _Material.GetSafeEnum<UnityEngine.Rendering.CullMode>(Property.Cull, UnityEngine.Rendering.CullMode.Back);
            set => _Material.SetSafeInt(Property.Cull, (int)value);
        }

        /// <summary>Alpha Clip</summary>
        //[DefaultValue(false)]
        public bool AlphaClip
        {
            get => _Material.GetSafeBool(Property.AlphaClip, false);
            set => SetAlphaClip(value);
        }

        /// <summary>Alpha Cutoff</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float Cutoff
        {
            get => _Material.GetSafeFloat(Property.Cutoff, PropertyRange.Cutoff.defaultValue);
            set => _Material.SetSafeFloat(Property.Cutoff, PropertyRange.Cutoff, value);
        }

        /// <summary>Alpha to Mask</summary>
        public bool AlphaToMask
        {
            get => _Material.GetSafeBool(Property.AlphaToMask, false);
            set => _Material.SetSafeBool(Property.AlphaToMask, value);
        }

        ///// <summary>Lighting Enabled</summary>
        //public bool LightingEnabled
        //{
        //    get => _Material.GetSafeBool(Property.LightingEnabled, false);
        //    set => _Material.SetSafeBool(Property.LightingEnabled, value);
        //}

        /// <summary>Receive Shadows</summary>
        /// <remarks>Lit only</remarks>
        //[DefaultValue(true)]
        public bool ReceiveShadows
        {
            get => _Material.GetSafeBool(Property.ReceiveShadows, false);
            set
            {
                _Material.SetSafeBool(Property.ReceiveShadows, value);

                _Material.SetSafeKeyword(Keyword.ReveiveShadowsOff, value == false);
            }
        }

        /// <summary>Base Color</summary>
        public Color BaseColor
        {
            get => _Material.GetSafeColor(Property.BaseColor, Color.white);
            set => _Material.SetSafeColor(Property.BaseColor, value);
        }

        /// <summary>Base Color Add/Sub/Diff</summary>
        public Color BaseColorAddSubDiff
        {
            get => _Material.GetSafeColor(Property.BaseColorAddSubDiff, new Color(0.0f, 0.0f, 0.0f, 0.0f));
            set => _Material.SetSafeColor(Property.BaseColorAddSubDiff, value);
        }

        /// <summary>Base Map</summary>
        public Texture2D BaseMap
        {
            get => _Material.GetSafeTexture(Property.BaseMap);
            set => _Material.SetSafeTexture(Property.BaseMap, value);
        }

        /// <summary>Base Map Scale</summary>
        public Vector2 BaseMapScale
        {
            get => _Material.GetSafeTextureScale(Property.BaseMap, Vector2.one);
            set => _Material.SetSafeTextureScale(Property.BaseMap, value);
        }

        /// <summary>Base Map Offset</summary>
        public Vector2 BaseMapOffset
        {
            get => _Material.GetSafeTextureOffset(Property.BaseMap, Vector2.zero);
            set => _Material.SetSafeTextureOffset(Property.BaseMap, value);
        }

        /// <summary>MetallicGlossMap</summary>
        /// <remarks>Lit only</remarks>
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
        /// <remarks>Lit only</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float Metallic
        {
            get => _Material.GetSafeFloat(Property.Metallic, PropertyRange.Metallic.defaultValue);
            set => _Material.SetSafeFloat(Property.Metallic, PropertyRange.Metallic, value);
        }

        /// <summary>Smoothness</summary>
        /// <remarks>Lit only</remarks>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float Smoothness
        {
            get => _Material.GetSafeFloat(Property.Smoothness, PropertyRange.Smoothness.defaultValue);
            set => _Material.SetSafeFloat(Property.Smoothness, PropertyRange.Smoothness, value);
        }

        /// <summary>Bump Scale</summary>
        /// <remarks>Lit only</remarks>
        //[DefaultValue(1.0f)]
        public float BumpScale
        {
            get => _Material.GetSafeFloat(Property.BumpScale, PropertyRange.BumpScale.defaultValue);
            set => _Material.SetSafeFloat(Property.BumpScale, PropertyRange.BumpScale, value);
        }

        /// <summary>Bump Map (Normal Map)</summary>
        public Texture2D BumpMap
        {
            get => _Material.GetSafeTexture(Property.BumpMap);
            set
            {
                _Material.SetSafeKeyword(Keyword.NormalMap, value != null);

                _Material.SetSafeTexture(Property.BumpMap, value);
            }
        }

        ///// <summary>Emission Enabled</summary>
        //public bool EmissionEnabled
        //{
        //    get => _Material.GetSafeBool(Property.EmissionEnabled, false);
        //    set
        //    {
        //        _Material.SetSafeBool(Property.EmissionEnabled, value);

        //        _Material.SetKeyword(Keyword.Emission, value == true);
        //    }
        //}

        /// <summary>Emission Color</summary>
        public Color EmissionColor
        {
            get => _Material.GetSafeColor(Property.EmissionColor, new Color(0.0f, 0.0f, 0.0f));
            set
            {
                _Material.SetSafeColor(Property.EmissionColor, value);

                _Material.SetKeyword(Keyword.Emission, (EmissionMap != null) || (value != Color.black));
            }
        }

        /// <summary>Emission Map</summary>
        public Texture2D EmissionMap
        {
            get => _Material.GetSafeTexture(Property.EmissionMap);
            set
            {
                _Material.SetSafeTexture(Property.EmissionMap, value);

                _Material.SetKeyword(Keyword.Emission, (value != null) || (EmissionColor != Color.black));
            }
        }

        /// <summary>Flipbook Blending</summary>
        public bool FlipbookBlending
        {
            get => _Material.GetSafeBool(Property.FlipbookBlending, false);
            set
            {
                _Material.SetSafeBool(Property.FlipbookBlending, value);

                _Material.SetSafeKeyword(Keyword.FlipBookBlendingOn, value == true);
            }
        }

        /// <summary>Soft Particles Enabled</summary>
        public bool SoftParticlesEnabled
        {
            get => _Material.GetSafeBool(Property.SoftParticlesEnabled, false);
            set
            {
                _Material.SetSafeBool(Property.SoftParticlesEnabled, value);

                _Material.SetSafeKeyword(Keyword.SoftParticlesOn, (value == true) && (ZWrite == false));
            }
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

                // @notice
                _Material.SetShaderPassEnabled("Always", useDistortion);
            }
        }

        /// <summary>Distortion Blend</summary>
        public float DistortionBlend
        {
            get => _Material.GetSafeFloat(Property.DistortionBlend, PropertyRange.DistortionBlend.defaultValue);
            set => _Material.SetSafeFloat(Property.DistortionBlend, PropertyRange.DistortionBlend, value);
        }

        /// <summary>Distortion Strength</summary>
        public float DistortionStrength
        {
            get => _Material.GetSafeFloat(Property.DistortionStrength, PropertyRange.DistortionStrength.defaultValue);
            set => _Material.SetSafeFloat(Property.DistortionStrength, PropertyRange.DistortionStrength, value);
        }

        /// <summary>Distortion Strength Scaled</summary>
        public float DistortionStrengthScaled
        {
            get => _Material.GetSafeFloat(Property.DistortionStrengthScaled, PropertyRange.DistortionStrengthScaled.defaultValue);
            set => _Material.SetSafeFloat(Property.DistortionStrengthScaled, PropertyRange.DistortionStrengthScaled, value);
        }

        /// <summary>Queue Offset</summary>
        //[Range(-50, 50)]
        //[DefaultValue(0)]
        public int QueueOffset
        {
            get => _Material.GetSafeInt(Property.QueueOffset, PropertyRange.QueueOffset.defaultValue);
            set => _Material.SetSafeInt(Property.QueueOffset, PropertyRange.QueueOffset, value);
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

                _Material.SetSafeKeyword(Keyword.SoftParticlesOn, SoftParticlesEnabled && value == false);

                _Material.SetSafeKeyword(Keyword.FadingOn, CameraFadingEnabled && value == false);

                bool useDistortion = DistortionEnabled && value == false;

                _Material.SetSafeKeyword(Keyword.DistortionOn, useDistortion);

                _Material.SetShaderPassEnabled("Always", useDistortion);
            }
        }

        /// <summary>Blend Mode</summary>
        //[DefaultValue(BlendMode.Alpha)]
        [Obsolete("Obsolete")]
        public BlendMode Mode
        {
            get => _Material.GetSafeEnum<BlendMode>(Property.Mode, BlendMode.Alpha);
            set => SetBlendMode(value);
        }

        /// <summary>Flip Book Mode</summary>
        [Obsolete("Obsolete")]
        public FlipBookMode FlipBookMode
        {
            get => _Material.GetSafeEnum<FlipBookMode>(Property.FlipbookMode, FlipBookMode.Simple);
            set
            {
                _Material.SetSafeInt(Property.FlipbookMode, (int)value);

                //_Material.SetKeyword(Keyword.RequireUv2, value == FlipBookMode.Blended);
            }
        }

        /// <summary>Color</summary>
        [Obsolete("Obsolete")]
        public Color Color
        {
            get => _Material.GetSafeColor(Property.Color, Color.white);
            set => _Material.SetSafeColor(Property.Color, value);
        }

        /// <summary>Glossiness</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        [Obsolete("Obsolete")]
        public float Glossiness
        {
            get => _Material.GetSafeFloat(Property.Glossiness, PropertyRange.Glossiness.defaultValue);
            set => _Material.SetSafeFloat(Property.Glossiness, PropertyRange.Glossiness, value);
        }

        ///// <summary>Main Texture</summary>
        //public Texture2D MainTex
        //{
        //    get => _Material.GetSafeTexture(Property.MainTex);
        //    set => _Material.SetSafeTexture(Property.MainTex, value);
        //}

        ///// <summary>Main Texture Scale Transform</summary>
        //public Vector4 MainTexSt
        //{
        //    get => _Material.GetSafeVector4(Property.MainTexSt, new Vector4(1.0f, 1.0f, 0.0f, 0.0f));
        //    set
        //    {
        //        _Material.SetSafeVector(Property.MainTexSt, value);

        //        _Material.SetSafeTextureScale(Property.MainTex, new Vector2(value.x, value.y));

        //        _Material.SetSafeTextureOffset(Property.MainTex, new Vector2(value.z, value.w));
        //    }
        //}

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of UrpParticleMaterialProxy.
        /// </summary>
        /// <param name="material">The URP particle material.</param>
        public UrpParticleMaterialProxy(Material material)
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

            if ((material.shader.name != ShaderName.URP_Particles_Lit) &&
                (material.shader.name != ShaderName.URP_Particles_Unlit))
            {
                throw new ArgumentException();
            }

            _Material = material;
        }

        #endregion

        #region Public Methods (Set)

        /// <summary>
        /// Sets the surface type.
        /// </summary>
        /// <param name="surfaceType"></param>
        public void SetSurfaceType(SurfaceType surfaceType)
        {
            _Material.SetSafeInt(Property.Surface, (int)surfaceType);

            SetRenderKeyword(surfaceType, Blend, AlphaClip);
        }

        /// <summary>
        /// Sets the blend mode.
        /// </summary>
        /// <param name="blendMode"></param>
        public void SetBlendMode(BlendMode blendMode)
        {
            _Material.SetSafeInt(Property.Blend, (int)blendMode);

            SetRenderKeyword(Surface, blendMode, AlphaClip);
        }

        /// <summary>
        /// Sets the alpha clip.
        /// </summary>
        /// <param name="alphaClip"></param>
        public void SetAlphaClip(bool alphaClip)
        {
            _Material.SetSafeBool(Property.AlphaClip, alphaClip);

            SetRenderKeyword(Surface, Blend, alphaClip);
        }

        /// <summary>
        /// Sets the render keywords.
        /// </summary>
        /// <param name="surfaceType"></param>
        /// <param name="blendMode"></param>
        /// <param name="isAlphaClip"></param>
        public void SetRenderKeyword(SurfaceType surfaceType, BlendMode blendMode, bool isAlphaClip)
        {
            _Material.SetSafeKeyword(Keyword.SurfaceTypeTransparent, surfaceType == SurfaceType.Transparent);

            switch (surfaceType)
            {
                case SurfaceType.Opaque:
                    if (isAlphaClip)
                    {
                        _Material.SetOverrideTag(Tag.RenderType, RenderTypeValue.TransparentCutout);
                    }
                    else
                    {
                        _Material.SetOverrideTag(Tag.RenderType, RenderTypeValue.Opaque);
                    }

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

                case SurfaceType.Transparent:
                    switch (blendMode)
                    {
                        case BlendMode.Alpha:
                            _Material.SetOverrideTag(Tag.RenderType, RenderTypeValue.Transparent);

                            BlendOp = UnityEngine.Rendering.BlendOp.Add;
                            SrcBlend = UnityEngine.Rendering.BlendMode.SrcAlpha;
                            DstBlend = UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha;
                            ZWrite = false;

                            _Material.SetSafeKeyword(Keyword.AlphaTestOn, true);
                            _Material.SetSafeKeyword(Keyword.AlphaBlendOn, false);
                            _Material.SetSafeKeyword(Keyword.AlphaPremultiplyOn, false);
                            _Material.SetSafeKeyword(Keyword.AlphaModulateOn, false);

                            _Material.renderQueue = (int)UnityEngine.Rendering.RenderQueue.Transparent;
                            break;
                        case BlendMode.Premultiply:
                            _Material.SetOverrideTag(Tag.RenderType, RenderTypeValue.Transparent);

                            BlendOp = UnityEngine.Rendering.BlendOp.Multiply;
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
                        case BlendMode.Multiply:
                            _Material.SetOverrideTag(Tag.RenderType, RenderTypeValue.Transparent);

                            BlendOp = UnityEngine.Rendering.BlendOp.Multiply;
                            SrcBlend = UnityEngine.Rendering.BlendMode.DstColor;
                            DstBlend = UnityEngine.Rendering.BlendMode.Zero;
                            ZWrite = false;

                            _Material.SetSafeKeyword(Keyword.AlphaTestOn, false);
                            _Material.SetSafeKeyword(Keyword.AlphaBlendOn, false);
                            _Material.SetSafeKeyword(Keyword.AlphaPremultiplyOn, false);
                            _Material.SetSafeKeyword(Keyword.AlphaModulateOn, true);

                            _Material.renderQueue = (int)UnityEngine.Rendering.RenderQueue.Transparent;
                            break;
                    }
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="colorMode"></param>
        private void SetColorMode(ColorMode colorMode)
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