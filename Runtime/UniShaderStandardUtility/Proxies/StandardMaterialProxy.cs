// ----------------------------------------------------------------------
// @Namespace : UniStandardShader
// @Class     : StandardMaterialProxy
// ----------------------------------------------------------------------
namespace UniStandardShader
{
    using System;
    using UniShader.Shared;
    using UnityEngine;
    using UnityEngine.Rendering;

    /// <summary>
    /// Standard Material Proxy
    /// </summary>
    public class StandardMaterialProxy
    {
        #region Fields

        /// <summary></summary>
        private readonly Material _Material;

        #endregion

        #region Properties

        /// <summary>Alpha Blend Mode</summary>
        public AlphaBlendMode Mode
        {
            get => _Material.GetSafeEnum<AlphaBlendMode>(Property.Mode, AlphaBlendMode.Opaque);
            set => SetMode(value);
        }

        /// <summary>Color</summary>
        public Color Color
        {
            get => _Material.GetSafeColor(Property.Color, Color.white);
            set => _Material.SetSafeColor(Property.Color, value);
        }

        /// <summary>Main Texture</summary>
        public Texture2D MainTex
        {
            get => _Material.GetSafeTexture(Property.MainTex);
            set => _Material.SetSafeTexture(Property.MainTex, value);
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

        /// <summary>Alpha Cutoff</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float Cutoff
        {
            get => _Material.GetSafeFloat(Property.Cutoff, PropertyRange.Cutoff.defaultValue);
            set => _Material.SetSafeFloat(Property.Cutoff, PropertyRange.Cutoff, value);
        }

        /// <summary>Smoothness</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float Glossiness
        {
            get => _Material.GetSafeFloat(Property.Glossiness, PropertyRange.Glossiness.defaultValue);
            set => _Material.SetSafeFloat(Property.Glossiness, PropertyRange.Glossiness, value);
        }

        /// <summary>Smoothness Scale</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float GlossMapScale
        {
            get => _Material.GetSafeFloat(Property.GlossMapScale, PropertyRange.GlossMapScale.defaultValue);
            set => _Material.SetSafeFloat(Property.GlossMapScale, PropertyRange.GlossMapScale, value);
        }

        /// <summary>Smoothness texture channel</summary>
        public SmoothnessTextureChannel SmoothnessTextureChannel
        {
            get => _Material.GetSafeEnum<SmoothnessTextureChannel>(Property.SmoothnessTextureChannel, SmoothnessTextureChannel.SpecularMetallicAlpha);
            set => _Material.SetSafeInt(Property.SmoothnessTextureChannel, (int)value);
        }

        /// <summary>Metallic</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float Metallic
        {
            get => _Material.GetSafeFloat(Property.Metallic, PropertyRange.Metallic.defaultValue);
            set => _Material.SetSafeFloat(Property.Metallic, PropertyRange.Metallic, value);
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

        /// <summary>Specular Highlights</summary>
        public bool SpecularHighlights
        {
            get => _Material.GetSafeBool(Property.SpecularHighlights, true);
            set => _Material.SetSafeBool(Property.SpecularHighlights, value);
        }

        /// <summary>Glossy Reflections</summary>
        public bool GlossyReflections
        {
            get => _Material.GetSafeBool(Property.GlossyReflections, true);
            set => _Material.SetSafeBool(Property.GlossyReflections, value);
        }

        /// <summary>Normal Map Scale</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float BumpScale
        {
            get => _Material.GetSafeFloat(Property.BumpScale, PropertyRange.BumpScale.defaultValue);
            set => _Material.SetSafeFloat(Property.BumpScale, PropertyRange.BumpScale, value);
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

        /// <summary>Height Scale</summary>
        //[Range(0.005f, 0.08f)]
        //[DefaultValue(0.02f)]
        public float Parallax
        {
            get => _Material.GetSafeFloat(Property.Parallax, PropertyRange.Parallax.defaultValue);
            set => _Material.SetSafeFloat(Property.Parallax, PropertyRange.Parallax, value);
        }

        /// <summary>Height Map</summary>
        public Texture2D ParallaxMap
        {
            get => _Material.GetSafeTexture(Property.ParallaxMap);
            set
            {
                _Material.SetSafeKeyword(Keyword.ParallaxMap, value != null);
                _Material.SetSafeTexture(Property.ParallaxMap, value);
            }
        }

        /// <summary>Occlusion Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float OcclusionStrength
        {
            get => _Material.GetSafeFloat(Property.OcclusionStrength, PropertyRange.OcclusionStrength.defaultValue);
            set => _Material.SetSafeFloat(Property.OcclusionStrength, PropertyRange.OcclusionStrength, value);
        }

        /// <summary>Occlusion Map</summary>
        public Texture2D OcclusionMap
        {
            get => _Material.GetSafeTexture(Property.OcclusionMap);
            set => _Material.SetSafeTexture(Property.OcclusionMap, value);
        }

        /// <summary>Emission Color</summary>
        public Color EmissionColor
        {
            get => _Material.GetSafeColor(Property.EmissionColor, new Color(0.0f, 0.0f, 0.0f));
            set => _Material.SetSafeColor(Property.EmissionColor, value);
        }

        /// <summary>Emission Map</summary>
        public Texture2D EmissionMap
        {
            get => _Material.GetSafeTexture(Property.EmissionMap);
            set
            {
                _Material.SetSafeKeyword(Keyword.Emission, value != null);
                _Material.SetSafeTexture(Property.EmissionMap, value);
            }
        }

        /// <summary>Detail Mask</summary>
        public Texture2D DetailMask
        {
            get => _Material.GetSafeTexture(Property.DetailMask);
            set
            {
                //_Material.SetKeyword(Keyword.DetailMulx2, value != null);
                _Material.SetSafeTexture(Property.DetailMask, value);
            }
        }

        /// <summary>Detail Albedo Map x2</summary>
        public Texture2D DetailAlbedoMap
        {
            get => _Material.GetSafeTexture(Property.DetailAlbedoMap);
            set
            {
                //_Material.SetKeyword(Keyword.DetailMulx2, value != null);
                _Material.SetSafeTexture(Property.DetailAlbedoMap, value);
            }
        }

        /// <summary>Detail Albedo Map Scale</summary>
        public Vector2 DetailAlbedoMapScale
        {
            get => _Material.GetSafeTextureScale(Property.DetailAlbedoMap, Vector2.one);
            set => _Material.SetSafeTextureScale(Property.DetailAlbedoMap, value);
        }

        /// <summary>Detail Albedo Map Offset</summary>
        public Vector2 DetailAlbedoMapOffset
        {
            get => _Material.GetSafeTextureOffset(Property.DetailAlbedoMap, Vector2.zero);
            set => _Material.SetSafeTextureOffset(Property.DetailAlbedoMap, value);
        }

        /// <summary>Detail Normal Map Scale</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float DetailNormalMapScale
        {
            get => _Material.GetSafeFloat(Property.DetailNormalMapScale, PropertyRange.DetailNormalMapScale.defaultValue);
            set => _Material.SetSafeFloat(Property.DetailNormalMapScale, PropertyRange.DetailNormalMapScale, value);
        }

        /// <summary>Detail Normal Map</summary>
        public Texture2D DetailNormalMap
        {
            get => _Material.GetSafeTexture(Property.DetailNormalMap);
            set
            {
                //_Material.SetKeyword(Keyword.DetailMulx2, value != null);
                _Material.SetSafeTexture(Property.DetailNormalMap, value);
            }
        }

        /// <summary>UV Set for secondary textures</summary>
        public UV UVSec
        {
            get => _Material.GetSafeEnum<UV>(Property.UVSec, UV.UV0);
            set => _Material.SetSafeInt(Property.UVSec, (int)value);
        }

        /// <summary>Src Blend</summary>
        public BlendMode SrcBlend
        {
            get => _Material.GetSafeEnum<BlendMode>(Property.SrcBlend, BlendMode.One);
            private set => _Material.SetSafeInt(Property.SrcBlend, (int)value);
        }

        /// <summary>Dst Blend</summary>
        public BlendMode DstBlend
        {
            get => _Material.GetSafeEnum<BlendMode>(Property.DstBlend, BlendMode.Zero);
            private set => _Material.SetSafeInt(Property.DstBlend, (int)value);
        }

        /// <summary>ZWrite</summary>
        public bool ZWrite
        {
            get => _Material.GetSafeBool(Property.ZWrite, true);
            private set => _Material.SetSafeBool(Property.ZWrite, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of StandardMaterialProxy.
        /// </summary>
        /// <param name="material">The standard material.</param>
        public StandardMaterialProxy(Material material)
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

            if (material.shader.name != ShaderName.Standard)
            {
                throw new ArgumentException();
            }

            _Material = material;
        }

        #endregion

        #region Public Methods (Set)

        /// <summary>
        /// Sets the Keyword.
        /// </summary>
        /// <param name="keyword"></param>
        /// <param name="required"></param>
        public void SetKeyword(in string keyword, in bool required)
        {
            if (required)
            {
                _Material.EnableKeyword(keyword);
            }
            else
            {
                _Material.DisableKeyword(keyword);
            }
        }

        /// <summary>
        /// Sets the mode.
        /// </summary>
        /// <param name="mode"></param>
        public void SetMode(in AlphaBlendMode mode)
        {
            _Material.SetSafeInt(Property.Mode, (int)mode);

            switch (mode)
            {
                case AlphaBlendMode.Opaque:
                    _Material.SetOverrideTag(Tag.RenderType, RenderTypeValue.Opaque);

                    SrcBlend = BlendMode.One;
                    DstBlend = BlendMode.Zero;
                    ZWrite = true;

                    _Material.SetSafeKeyword(Keyword.AlphaTestOn, false);
                    _Material.SetSafeKeyword(Keyword.AlphaBlendOn, false);
                    _Material.SetSafeKeyword(Keyword.AlphaPreMultiplyOn, false);

                    _Material.renderQueue = -1;
                    break;

                case AlphaBlendMode.Cutout:
                    _Material.SetOverrideTag(Tag.RenderType, RenderTypeValue.TransparentCutout);

                    SrcBlend = BlendMode.One;
                    DstBlend = BlendMode.Zero;
                    ZWrite = true;

                    _Material.SetSafeKeyword(Keyword.AlphaTestOn, true);
                    _Material.SetSafeKeyword(Keyword.AlphaBlendOn, false);
                    _Material.SetSafeKeyword(Keyword.AlphaPreMultiplyOn, false);

                    _Material.renderQueue = 2450;
                    break;

                case AlphaBlendMode.Fade:
                    _Material.SetOverrideTag(Tag.RenderType, RenderTypeValue.Transparent);

                    SrcBlend = BlendMode.SrcAlpha;
                    DstBlend = BlendMode.OneMinusSrcAlpha;
                    ZWrite = false;

                    _Material.SetSafeKeyword(Keyword.AlphaTestOn, false);
                    _Material.SetSafeKeyword(Keyword.AlphaBlendOn, true);
                    _Material.SetSafeKeyword(Keyword.AlphaPreMultiplyOn, false);

                    _Material.renderQueue = 3000;
                    break;

                case AlphaBlendMode.Transparent:
                    _Material.SetOverrideTag(Tag.RenderType, RenderTypeValue.Transparent);

                    SrcBlend = BlendMode.One;
                    DstBlend = BlendMode.OneMinusSrcAlpha;
                    ZWrite = false;

                    _Material.SetSafeKeyword(Keyword.AlphaTestOn, false);
                    _Material.SetSafeKeyword(Keyword.AlphaBlendOn, false);
                    _Material.SetSafeKeyword(Keyword.AlphaPreMultiplyOn, true);

                    _Material.renderQueue = 3000;
                    break;
            }
        }

        #endregion
    }
}