// ----------------------------------------------------------------------
// @Namespace : UniUrpShader
// @Class     : UrpMaterialProxyBase
// ----------------------------------------------------------------------
namespace UniUrpShader
{
    using System;
    using UniShader.Shared;
    using UnityEngine;

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
            set => _Material.SetSafeBool(Property.AlphaClip, value);
        }

        /// <summary>SrcBlend</summary>
        public UnityEngine.Rendering.BlendMode SrcBlend
        {
            get => _Material.GetSafeEnum<UnityEngine.Rendering.BlendMode>(Property.SrcBlend, UnityEngine.Rendering.BlendMode.One);
            set => _Material.SetSafeInt(Property.SrcBlend, (int)value);
        }

        /// <summary>DstBlend</summary>
        public UnityEngine.Rendering.BlendMode DstBlend
        {
            get => _Material.GetSafeEnum<UnityEngine.Rendering.BlendMode>(Property.DstBlend, UnityEngine.Rendering.BlendMode.Zero);
            set => _Material.SetSafeInt(Property.DstBlend, (int)value);
        }

        /// <summary>ZWrite</summary>
        public bool ZWrite
        {
            get => _Material.GetSafeBool(Property.ZWrite, true);
            set => _Material.SetSafeBool(Property.ZWrite, value);
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
        /// <param name="blendMode"></param>
        public void SetSurfaceType(SurfaceType surfaceType, BlendMode? blendMode = null)
        {
            _Material.SetSafeInt(Property.Surface, (int)surfaceType);

            if (blendMode.HasValue)
            {
                _Material.SetInt(Property.Blend, (int)blendMode);

                SetRenderKeyword(surfaceType, blendMode.Value);
            }
            else
            {
                SetRenderKeyword(surfaceType, Blend);
            }
        }

        /// <summary>
        /// Sets the blend mode.
        /// </summary>
        /// <param name="blendMode"></param>
        private void SetBlendMode(BlendMode blendMode)
        {
            _Material.SetSafeInt(Property.Blend, (int)blendMode);

            SetRenderKeyword(Surface, blendMode);
        }

        /// <summary>
        /// Sets the render keywords.
        /// </summary>
        /// <param name="surfaceType"></param>
        /// <param name="blendMode"></param>
        private void SetRenderKeyword(SurfaceType surfaceType, BlendMode blendMode)
        {
            _Material.SetSafeKeyword(Keyword.SurfaceTypeTransparent, surfaceType == SurfaceType.Transparent);

            switch (surfaceType)
            {
                case SurfaceType.Opaque:
                    _Material.SetSafeInt(Property.SrcBlend, (int)UnityEngine.Rendering.BlendMode.One);
                    _Material.SetSafeInt(Property.DstBlend, (int)UnityEngine.Rendering.BlendMode.Zero);
                    //_Material.SetSafeInt(Property.AlphaSrcBlend, (int)UnityEngine.Rendering.BlendMode.One);
                    //_Material.SetSafeInt(Property.AlphaDstBlend, (int)UnityEngine.Rendering.BlendMode.Zero);
                    _Material.SetSafeInt(Property.ZWrite, 1);
                    //_Material.SetSafeInt(Property.TransparentZWrite, 0);
                    //_Material.SetKeyword(Keyword.AlphaTestOn, false);
                    //_Material.SetKeyword(Keyword.AlphaBlendOn, false);
                    _Material.renderQueue = 2225;  // @notice
                    break;

                case SurfaceType.Transparent:
                    switch (blendMode)
                    {
                        case BlendMode.Alpha:
                            _Material.SetSafeInt(Property.SrcBlend, (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
                            _Material.SetSafeInt(Property.DstBlend, (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
                            //_Material.SetSafeInt(Property.AlphaSrcBlend, (int)UnityEngine.Rendering.BlendMode.One);
                            //_Material.SetSafeInt(Property.AlphaDstBlend, (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
                            _Material.SetSafeInt(Property.ZWrite, 0);
                            //_Material.SetSafeInt(Property.TransparentZWrite, 0);
                            //_Material.SetKeyword(Keyword.AlphaTestOn, true);
                            //_Material.SetKeyword(Keyword.AlphaBlendOn, false);
                            //_Material.SetKeyword(Keyword.AlphaPremultiplyOn, false);
                            _Material.renderQueue = (int)UnityEngine.Rendering.RenderQueue.Transparent;
                            break;
                        case BlendMode.Additive:
                            _Material.SetSafeInt(Property.SrcBlend, (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
                            _Material.SetSafeInt(Property.DstBlend, (int)UnityEngine.Rendering.BlendMode.One);
                            //_Material.SetSafeInt(Property.AlphaSrcBlend, (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
                            //_Material.SetSafeInt(Property.AlphaDstBlend, (int)UnityEngine.Rendering.BlendMode.One);
                            _Material.SetSafeInt(Property.ZWrite, 0);
                            //_Material.SetSafeInt(Property.TransparentZWrite, 0);
                            //_Material.SetKeyword(Keyword.AlphaTestOn, false);
                            //_Material.SetKeyword(Keyword.AlphaBlendOn, true);
                            //_Material.SetKeyword(Keyword.AlphaPremultiplyOn, false);
                            _Material.renderQueue = (int)UnityEngine.Rendering.RenderQueue.Transparent;
                            break;
                        case BlendMode.Premultiply:
                            _Material.SetSafeInt(Property.SrcBlend, (int)UnityEngine.Rendering.BlendMode.One);
                            _Material.SetSafeInt(Property.DstBlend, (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
                            //_Material.SetSafeInt(Property.AlphaSrcBlend, (int)UnityEngine.Rendering.BlendMode.One);
                            //_Material.SetSafeInt(Property.AlphaDstBlend, (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
                            _Material.SetSafeInt(Property.ZWrite, 0);
                            //_Material.SetSafeInt(Property.TransparentZWrite, 0);
                            //_Material.SetKeyword(Keyword.AlphaTestOn, false);  // @notice true?
                            //_Material.SetKeyword(Keyword.AlphaBlendOn, false);
                            //_Material.SetKeyword(Keyword.AlphaPremultiplyOn, true);
                            _Material.renderQueue = (int)UnityEngine.Rendering.RenderQueue.Transparent;
                            break;
                    }
                    break;
            }

            _Material.SetSafeKeyword(Keyword.AlphaTestOn, (surfaceType == SurfaceType.Transparent) && (blendMode == BlendMode.Alpha));

            _Material.SetSafeKeyword(Keyword.AlphaPreMultiplyOn, (surfaceType == SurfaceType.Transparent) && (blendMode == BlendMode.Premultiply));
        }

        #endregion
    }
}