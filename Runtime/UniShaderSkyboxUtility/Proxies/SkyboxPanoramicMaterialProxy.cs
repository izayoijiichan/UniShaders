// ----------------------------------------------------------------------
// @Namespace : UniSkyboxShader
// @Class     : SkyboxPanoramicMaterialProxy
// ----------------------------------------------------------------------
namespace UniSkyboxShader
{
    using System;
    using UniShader.Shared;
    using UnityEngine;

    /// <summary>
    /// Panoramic Skybox Material Proxy
    /// </summary>
    public class SkyboxPanoramicMaterialProxy
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

        /// <summary>Spherical (HDR)</summary>
        public Texture2D MainTex
        {
            get => _Material.GetSafeTexture(Property.MainTex);
            set => _Material.SetSafeTexture(Property.MainTex, value);
        }

        /// <summary>Mapping</summary>
        public Mapping Mapping
        {
            get => _Material.GetSafeEnum<Mapping>(Property.Mapping, Mapping.LatitudeLongitudeLayout);
            set
            {
                _Material.SetSafeInt(Property.Mapping, (int)value);

                _Material.SetSafeKeyword(Keyword.Mapping6FramesLayout, value == Mapping.SixFramesLayout);
            }
        }

        /// <summary>Image Type</summary>
        public ImageType ImageType
        {
            get => _Material.GetSafeEnum<ImageType>(Property.ImageType, ImageType.Degrees360);
            set => _Material.SetSafeInt(Property.ImageType, (int)value);
        }

        /// <summary>Mirror on Back</summary>
        public bool MirrorOnBack
        {
            get => _Material.GetSafeBool(Property.MirrorOnBack, false);
            set => _Material.SetSafeBool(Property.MirrorOnBack, value);
        }

        /// <summary>3D Layout</summary>
        public Layout Layout
        {
            get => _Material.GetSafeEnum<Layout>(Property.Layout, Layout.None);
            set => _Material.SetSafeInt(Property.Layout, (int)value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of SkyboxPanoramicMaterialProxy.
        /// </summary>
        /// <param name="material">The skybox panoramic material.</param>
        public SkyboxPanoramicMaterialProxy(Material material)
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

            if (material.shader.name != ShaderName.Skybox_Panoramic)
            {
                throw new ArgumentException();
            }

            _Material = material;
        }

        #endregion
    }
}