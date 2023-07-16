// ----------------------------------------------------------------------
// @Namespace : UniSkyboxShader
// @Class     : Skybox6SidedMaterialProxy
// ----------------------------------------------------------------------
namespace UniSkyboxShader
{
    using System;
    using UniShader.Shared;
    using UnityEngine;

    /// <summary>
    /// 6 Sided Skybox Material Proxy
    /// </summary>
    public class Skybox6SidedMaterialProxy
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

        /// <summary>Front [+Z] (HDR)</summary>
        public Texture2D FrontTex
        {
            get => _Material.GetSafeTexture(Property.FrontTex);
            set => _Material.SetSafeTexture(Property.FrontTex, value);
        }

        /// <summary>Back [-Z] (HDR)</summary>
        public Texture2D BackTex
        {
            get => _Material.GetSafeTexture(Property.BackTex);
            set => _Material.SetSafeTexture(Property.BackTex, value);
        }

        /// <summary>Left [+X] (HDR)</summary>
        public Texture2D LeftTex
        {
            get => _Material.GetSafeTexture(Property.LeftTex);
            set => _Material.SetSafeTexture(Property.LeftTex, value);
        }

        /// <summary>Right [-X] (HDR)</summary>
        public Texture2D RightTex
        {
            get => _Material.GetSafeTexture(Property.RightTex);
            set => _Material.SetSafeTexture(Property.RightTex, value);
        }

        /// <summary>Up [+Y] (HDR)</summary>
        public Texture2D UpTex
        {
            get => _Material.GetSafeTexture(Property.UpTex);
            set => _Material.SetSafeTexture(Property.UpTex, value);
        }

        /// <summary>Down [-Y] (HDR)</summary>
        public Texture2D DownTex
        {
            get => _Material.GetSafeTexture(Property.DownTex);
            set => _Material.SetSafeTexture(Property.DownTex, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of Skybox6SidedMaterialProxy.
        /// </summary>
        /// <param name="material">The skybox 6 sided material.</param>
        public Skybox6SidedMaterialProxy(Material material)
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

            if (material.shader.name != ShaderName.Skybox_6_Sided)
            {
                throw new ArgumentException();
            }

            _Material = material;
        }

        #endregion
    }
}