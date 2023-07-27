// ----------------------------------------------------------------------
// @Namespace : UniUrpShader
// @Class     : UrpMaterialProxyBase
// ----------------------------------------------------------------------
namespace UniUrpShader
{
    using System;
    using UniShader.Shared;
    using UnityEngine;
    using UnityEngine.Rendering;

    /// <summary>
    /// Basic URP Material Proxy
    /// </summary>
    public abstract class UrpMaterialProxyBase
    {
        #region Fields

        /// <summary></summary>
        protected readonly Material _Material;

        #endregion

        #region Properties

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

        /// <summary>Base Color</summary>
        public Color BaseColor
        {
            get => _Material.GetSafeColor(Property.BaseColor, Color.white);
            set => _Material.SetSafeColor(Property.BaseColor, value);
        }

        /// <summary>Alpha Cutoff</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float Cutoff
        {
            get => _Material.GetSafeFloat(Property.Cutoff, PropertyRange.Cutoff.defaultValue);
            set => _Material.SetSafeFloat(Property.Cutoff, PropertyRange.Cutoff, value);
        }

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

        /// <summary>Cull Mode</summary>
        //[DefaultValue(CullMode.Back)]
        public CullMode Cull
        {
            get => _Material.GetSafeEnum<CullMode>(Property.Cull, CullMode.Back);
            set => _Material.SetSafeInt(Property.Cull, (int)value);
        }

        /// <summary>Alpha Clip</summary>
        //[DefaultValue(false)]
        public bool AlphaClip
        {
            get => _Material.GetSafeBool(Property.AlphaClip, false);
            set => SetAlphaClip(value);
        }

        /// <summary>SrcBlend</summary>
        public UnityEngine.Rendering.BlendMode SrcBlend
        {
            get => _Material.GetSafeEnum<UnityEngine.Rendering.BlendMode>(Property.SrcBlend, UnityEngine.Rendering.BlendMode.One);
            private set => _Material.SetSafeInt(Property.SrcBlend, (int)value);
        }

        /// <summary>DstBlend</summary>
        public UnityEngine.Rendering.BlendMode DstBlend
        {
            get => _Material.GetSafeEnum<UnityEngine.Rendering.BlendMode>(Property.DstBlend, UnityEngine.Rendering.BlendMode.Zero);
            private set => _Material.SetSafeInt(Property.DstBlend, (int)value);
        }

        /// <summary>Src Blend Alpha</summary>
        //[DefaultValue(1.0f)]
        public UnityEngine.Rendering.BlendMode SrcBlendAlpha
        {
            get => _Material.GetSafeEnum<UnityEngine.Rendering.BlendMode>(Property.SrcBlendAlpha, UnityEngine.Rendering.BlendMode.One);
            private set => _Material.SetSafeInt(Property.SrcBlendAlpha, (int)value);
        }

        /// <summary>Dst Blend Alpha</summary>
        //[DefaultValue(0.0f)]
        public UnityEngine.Rendering.BlendMode DstBlendAlpha
        {
            get => _Material.GetSafeEnum<UnityEngine.Rendering.BlendMode>(Property.DstBlendAlpha, UnityEngine.Rendering.BlendMode.Zero);
            private set => _Material.SetSafeInt(Property.DstBlendAlpha, (int)value);
        }

        /// <summary>ZWrite</summary>
        public bool ZWrite
        {
            get => _Material.GetSafeBool(Property.ZWrite, true);
            private set
            {
                _Material.SetSafeBool(Property.ZWrite, value);

                _Material.SetShaderPassEnabled("DepthOnly", value);
            }
        }

        /// <summary>Alpha to Mask</summary>
        //[DefaultValue(false)]
        public bool AlphaToMask
        {
            get => _Material.GetSafeBool(Property.AlphaToMask, false);
            private set => _Material.SetSafeBool(Property.AlphaToMask, value);
        }

        /// <summary>Queue Offset</summary>
        //[Range(-50, 50)]
        //[DefaultValue(0)]
        public int QueueOffset
        {
            get => _Material.GetSafeInt(Property.QueueOffset, PropertyRange.QueueOffset.defaultValue);
            set => _Material.SetSafeInt(Property.QueueOffset, PropertyRange.QueueOffset, value);
        }

        #endregion

        #region Obsolete Properties

        /// <summary>Main Tex</summary>
        [Obsolete("Obsolete")]
        public Texture2D MainTex
        {
            get => _Material.GetSafeTexture(Property.MainTex);
            set => _Material.SetSafeTexture(Property.MainTex, value);
        }

        /// <summary>Color</summary>
        [Obsolete("Obsolete")]
        public Color Color
        {
            get => _Material.GetSafeColor(Property.Color, Color.white);
            set => _Material.SetSafeColor(Property.Color, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of UrpMaterialProxyBase.
        /// </summary>
        /// <param name="material">The URP material.</param>
        public UrpMaterialProxyBase(Material material)
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
        private void SetBlendMode(BlendMode blendMode)
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
        private void SetRenderKeyword(SurfaceType surfaceType, BlendMode blendMode, bool isAlphaClip)
        {
            _Material.SetSafeKeyword(Keyword.SurfaceTypeTransparent, surfaceType == SurfaceType.Transparent);

            switch (surfaceType)
            {
                case SurfaceType.Opaque:
                    SrcBlend = UnityEngine.Rendering.BlendMode.One;
                    DstBlend = UnityEngine.Rendering.BlendMode.Zero;
                    SrcBlendAlpha = UnityEngine.Rendering.BlendMode.One;
                    DstBlendAlpha = UnityEngine.Rendering.BlendMode.Zero;
                    ZWrite = true;

                    //_Material.SetSafeKeyword(Keyword.AlphaTestOn, false);
                    //_Material.SetSafeKeyword(Keyword.AlphaBlendOn, false);
                    //_Material.SetSafeKeyword(Keyword.AlphaPremultiplyOn, false);
                    //_Material.SetSafeKeyword(Keyword.AlphaModulateOn, false);

                    if (isAlphaClip)
                    {
                        AlphaToMask = true;

                        _Material.SetOverrideTag(Tag.RenderType, RenderTypeValue.TransparentCutout);

                        _Material.renderQueue = (int)RenderQueue.AlphaTest;
                    }
                    else
                    {
                        AlphaToMask = false;

                        _Material.SetOverrideTag(Tag.RenderType, RenderTypeValue.Opaque);

                        _Material.renderQueue = (int)RenderQueue.Geometry;
                    }

                    break;

                case SurfaceType.Transparent:
                    switch (blendMode)
                    {
                        case BlendMode.Alpha:
                            _Material.SetOverrideTag(Tag.RenderType, RenderTypeValue.Transparent);

                            SrcBlend = UnityEngine.Rendering.BlendMode.SrcAlpha;
                            DstBlend = UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha;
                            SrcBlendAlpha = UnityEngine.Rendering.BlendMode.One;
                            DstBlendAlpha = UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha;
                            ZWrite = false;
                            AlphaToMask = false;

                            //_Material.SetSafeKeyword(Keyword.AlphaTestOn, true);
                            //_Material.SetSafeKeyword(Keyword.AlphaBlendOn, false);
                            //_Material.SetSafeKeyword(Keyword.AlphaPremultiplyOn, false);
                            //_Material.SetSafeKeyword(Keyword.AlphaModulateOn, false);

                            _Material.renderQueue = (int)UnityEngine.Rendering.RenderQueue.Transparent;
                            break;
                        case BlendMode.Premultiply:
                            _Material.SetOverrideTag(Tag.RenderType, RenderTypeValue.Transparent);

                            SrcBlend = UnityEngine.Rendering.BlendMode.One;
                            DstBlend = UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha;
                            SrcBlendAlpha = UnityEngine.Rendering.BlendMode.One;
                            DstBlendAlpha = UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha;
                            ZWrite = false;
                            AlphaToMask = false;

                            //_Material.SetSafeKeyword(Keyword.AlphaTestOn, false);
                            //_Material.SetSafeKeyword(Keyword.AlphaBlendOn, false);
                            //_Material.SetSafeKeyword(Keyword.AlphaPremultiplyOn, true);
                            //_Material.SetSafeKeyword(Keyword.AlphaModulateOn, false);

                            _Material.renderQueue = (int)UnityEngine.Rendering.RenderQueue.Transparent;
                            break;
                        case BlendMode.Additive:
                            _Material.SetOverrideTag(Tag.RenderType, RenderTypeValue.Transparent);

                            SrcBlend = UnityEngine.Rendering.BlendMode.SrcAlpha;
                            DstBlend = UnityEngine.Rendering.BlendMode.One;
                            SrcBlendAlpha = UnityEngine.Rendering.BlendMode.One;
                            DstBlendAlpha = UnityEngine.Rendering.BlendMode.One;
                            ZWrite = false;
                            AlphaToMask = false;

                            //_Material.SetSafeKeyword(Keyword.AlphaTestOn, false);
                            //_Material.SetSafeKeyword(Keyword.AlphaBlendOn, true);
                            //_Material.SetSafeKeyword(Keyword.AlphaPremultiplyOn, false);
                            //_Material.SetSafeKeyword(Keyword.AlphaModulateOn, false);

                            _Material.renderQueue = (int)RenderQueue.Transparent;
                            break;
                        case BlendMode.Multiply:
                            _Material.SetOverrideTag(Tag.RenderType, RenderTypeValue.Transparent);

                            SrcBlend = UnityEngine.Rendering.BlendMode.DstColor;
                            DstBlend = UnityEngine.Rendering.BlendMode.Zero;
                            SrcBlendAlpha = UnityEngine.Rendering.BlendMode.Zero;
                            DstBlendAlpha = UnityEngine.Rendering.BlendMode.One;
                            ZWrite = false;
                            AlphaToMask = false;

                            //_Material.SetSafeKeyword(Keyword.AlphaTestOn, false);
                            //_Material.SetSafeKeyword(Keyword.AlphaBlendOn, false);
                            //_Material.SetSafeKeyword(Keyword.AlphaPremultiplyOn, false);
                            //_Material.SetSafeKeyword(Keyword.AlphaModulateOn, true);

                            _Material.renderQueue = (int)RenderQueue.Transparent;
                            break;
                    }
                    break;
            }

            _Material.SetSafeKeyword(Keyword.AlphaTestOn, isAlphaClip);

            //_Material.SetSafeKeyword(Keyword.AlphaBlendOn, (surfaceType == SurfaceType.Transparent) && (blendMode == BlendMode.Additive));

            _Material.SetSafeKeyword(Keyword.AlphaPreMultiplyOn, (surfaceType == SurfaceType.Transparent) && (blendMode == BlendMode.Premultiply));

            _Material.SetSafeKeyword(Keyword.AlphaModulateOn, (surfaceType == SurfaceType.Transparent) && (blendMode == BlendMode.Multiply));
        }

        #endregion
    }
}