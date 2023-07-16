// ----------------------------------------------------------------------
// @Namespace : UniUrpShader
// @Class     : UrpUnlitMaterialProxy
// ----------------------------------------------------------------------
namespace UniUrpShader
{
    using System;
    using UniShader.Shared;
    using UnityEngine;
    using UnityEngine.Rendering;

    /// <summary>
    /// URP Unlit Material Proxy
    /// </summary>
    /// <remarks>
    /// com.unity.render-pipelines.universal
    /// Unlit.shader
    /// </remarks>
    public class UrpUnlitMaterialProxy : UrpMaterialProxyBase
    {
        #region Properties

        /// <summary>Blend Op</summary>
        //[DefaultValue(BlendOp.Add)]
        public BlendOp BlendOp
        {
            get => _Material.GetSafeEnum<BlendOp>(Property.BlendOp, BlendOp.Add);
            set => _Material.SetSafeInt(Property.BlendOp, (int)value);
        }

        #endregion

        #region Obsolete Properties

        /// <summary>Sample GI</summary>
        //[DefaultValue(0.0f)]
        [Obsolete("Obsolete")]
        public float SampleGI
        {
            get => _Material.GetSafeFloat(Property.SampleGI, 0.0f);
            set => _Material.SetSafeFloat(Property.SampleGI, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of UrpUnlitMaterialProxy.
        /// </summary>
        /// <param name="material">The URP unlit material.</param>
        public UrpUnlitMaterialProxy(Material material) : base(material)
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

            if (material.shader.name != ShaderName.URP_Unlit)
            {
                throw new ArgumentException();
            }
        }

        #endregion
    }
}