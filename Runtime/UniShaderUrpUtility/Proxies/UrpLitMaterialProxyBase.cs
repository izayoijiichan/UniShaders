// ----------------------------------------------------------------------
// @Namespace : UniUrpShader
// @Class     : UrpLitMaterialProxyBase
// ----------------------------------------------------------------------
namespace UniUrpShader
{
    using System;
    using UniShader.Shared;
    using UnityEngine;

    /// <summary>
    /// Basic URP Lit Material Proxy
    /// </summary>
    public abstract class UrpLitMaterialProxyBase : UrpMaterialProxyBase
    {
        #region Properties

        /// <summary>Smoothness</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float Smoothness
        {
            get => _Material.GetSafeFloat(Property.Smoothness, PropertyRange.Smoothness.defaultValue);
            set => _Material.SetSafeFloat(Property.Smoothness, PropertyRange.Smoothness, value);
        }

        /// <summary>Specular Color</summary>
        public Color SpecColor
        {
            get => _Material.GetSafeColor(Property.SpecColor, new Color(0.5f, 0.5f, 0.5f, 0.5f));
            set => _Material.SetSafeColor(Property.SpecColor, value);
        }

        /// <summary>Specular Gloss Map</summary>
        public Texture2D SpecGlossMap
        {
            get => _Material.GetSafeTexture(Property.SpecGlossMap);
            set
            {
                _Material.SetSafeKeyword(Keyword.MetallicSpecGlossMap, value != null);

                _Material.SetSafeTexture(Property.SpecGlossMap, value);
            }
        }

        /// <summary>Specular Highlights</summary>
        //[DefaultValue(true)]
        public bool SpecularHighlights
        {
            get => _Material.GetSafeBool(Property.SpecularHighlights, true);
            set
            {
                _Material.SetSafeBool(Property.SpecularHighlights, value);

                _Material.SetSafeKeyword(Keyword.SpecularHighlightsOff, value == false);
            }
        }

        /// <summary>Bump Scale</summary>
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

        /// <summary>Receive Shadows</summary>
        //[DefaultValue(true)]
        public bool ReceiveShadows
        {
            get => _Material.GetSafeBool(Property.ReceiveShadows, true);
            set
            {
                _Material.SetSafeBool(Property.ReceiveShadows, value);

                _Material.SetSafeKeyword(Keyword.ReveiveShadowsOff, value == false);
            }
        }

        #endregion

        #region Obsolete Properties

        /// <summary>unity_Lightmaps</summary>
        [Obsolete("Obsolete")]
        public Texture2DArray UnityLightmaps
        {
            get => default;
            set => throw new NotSupportedException();
        }

        /// <summary>unity_LightmapsInd</summary>
        [Obsolete("Obsolete")]
        public Texture2DArray UnityLightmapsInd
        {
            get => default;
            set => throw new NotSupportedException();
        }

        /// <summary>unity_ShadowMasks</summary>
        [Obsolete("Obsolete")]
        public Texture2DArray UnityShadowMasks
        {
            get => default;
            set => throw new NotSupportedException();
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of UrpLitMaterialProxyBase.
        /// </summary>
        /// <param name="material">The URP lit material.</param>
        public UrpLitMaterialProxyBase(Material material) : base(material)
        {
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Sets the keyword.
        /// </summary>
        /// <param name="keyword"></param>
        /// <param name="required"></param>
        public void SetKeyword(string keyword, bool required)
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

        #endregion
    }
}