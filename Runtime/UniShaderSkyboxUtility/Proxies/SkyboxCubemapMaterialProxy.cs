// ----------------------------------------------------------------------
// @Namespace : UniSkyboxShader
// @Class     : SkyboxCubemapMaterialProxy
// ----------------------------------------------------------------------
namespace UniSkyboxShader
{
    using System;
    using UniShader.Shared;
    using UnityEngine;

    /// <summary>
    /// Cubemap Skybox Material Proxy
    /// </summary>
    public class SkyboxCubemapMaterialProxy
    {
        #region Fields

        /// <summary></summary>
        private readonly Material _Material;

        #endregion

        #region Properties

        /// <summary>Tint Color</summary>
        public Color Tint
        {
            get => _Material.GetSafeColor(Property.Tint, new Color(0.5f, 0.5f, 0.5f, 0.5f));
            set => _Material.SetSafeColor(Property.Tint, value);
        }

        /// <summary>Exposure</summary>
        //[Range(0.0f, 8.0f)]
        public float Exposure
        {
            get => _Material.GetSafeFloat(Property.Exposure, PropertyRange.Exposure.defaultValue);
            set => _Material.SetSafeFloat(Property.Exposure, PropertyRange.Exposure, value);
        }

        /// <summary>Rotation</summary>
        //[Range(0f, 360f)]
        public int Rotation
        {
            get => _Material.GetSafeInt(Property.Rotation, PropertyRange.Rotation.defaultValue);
            set => _Material.SetSafeInt(Property.Rotation, PropertyRange.Rotation, value);
        }

        /// <summary>Cubemap (HDR)</summary>
        public Cubemap Tex
        {
            get
            {
                if (_Material.HasProperty(Property.Tex))
                {
                    Texture texture = _Material.GetTexture(Property.Tex);

                    if (texture is Cubemap cubemap)
                    {
                        return cubemap;
                    }
                }

                return null;
            }
            set
            {
                if (_Material.HasProperty(Property.Tex))
                {
                    _Material.SetTexture(Property.Tex, value);
                }
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of SkyboxCubemapMaterialProxy.
        /// </summary>
        /// <param name="material">The skybox cubemap material.</param>
        public SkyboxCubemapMaterialProxy(Material material)
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

            if (material.shader.name != ShaderName.Skybox_Cubemap)
            {
                throw new ArgumentException();
            }

            _Material = material;
        }

        #endregion
    }
}