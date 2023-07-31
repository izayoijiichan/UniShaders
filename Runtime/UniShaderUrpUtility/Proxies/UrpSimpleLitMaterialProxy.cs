// ----------------------------------------------------------------------
// @Namespace : UniUrpShader
// @Class     : UrpSimpleLitMaterialProxy
// ----------------------------------------------------------------------
namespace UniUrpShader
{
    using System;
    using UniShader.Shared;
    using UnityEngine;

    /// <summary>
    /// URP Simple Lit Material Proxy
    /// </summary>
    /// <remarks>
    /// com.unity.render-pipelines.universal
    /// SimpleLit.shader
    /// </remarks>
    public class UrpSimpleLitMaterialProxy : UrpLitMaterialProxyBase
    {
        #region Properties

        /// <summary>Smoothness Source</summary>
        //[DefaultValue(SmoothnessSource.SpecularAlpha)]
        public SmoothnessSource SmoothnessSource
        {
            get => _Material.GetSafeEnum<SmoothnessSource>(Property.SmoothnessSource, SmoothnessSource.SpecularAlpha);
            set => _Material.SetSafeInt(Property.SmoothnessSource, (int)value);
        }

        /// <summary>Blend Mode Preserve Specular</summary>
        //[DefaultValue(true)]
        public bool BlendModePreserveSpecular
        {
            get => _Material.GetSafeBool(Property.BlendModePreserveSpecular, true);
            set => _Material.SetSafeBool(Property.BlendModePreserveSpecular, value);
        }

        #endregion

        #region Obsolete Properties

        /// <summary>Shininess</summary>
        //[DefaultValue(0.0f)]
        [Obsolete("Obsolete")]
        public float Shininess
        {
            get => _Material.GetSafeFloat(Property.Shininess, 0.0f);
            set => _Material.SetSafeFloat(Property.Shininess, value);
        }

        /// <summary>Glossiness Source</summary>
        //[DefaultValue(0.0f)]
        [Obsolete("Obsolete")]
        public float GlossinessSource
        {
            get => _Material.GetSafeFloat(Property.GlossinessSource, 0.0f);
            set => _Material.SetSafeFloat(Property.GlossinessSource, value);
        }

        /// <summary>Spec Source</summary>
        //[DefaultValue(0.0f)]
        [Obsolete("Obsolete")]
        public float SpecSource
        {
            get => _Material.GetSafeFloat(Property.SpecSource, 0.0f);
            set => _Material.SetSafeFloat(Property.SpecSource, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of UrpSimpleLitMaterialProxy.
        /// </summary>
        /// <param name="material">The URP simple lit material.</param>
        public UrpSimpleLitMaterialProxy(Material material) : base(material)
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

            if (material.shader.name != ShaderName.URP_SimpleLit)
            {
                throw new ArgumentException();
            }
        }

        #endregion
    }
}