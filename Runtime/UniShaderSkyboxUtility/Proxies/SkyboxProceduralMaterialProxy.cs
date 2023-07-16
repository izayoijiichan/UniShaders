// ----------------------------------------------------------------------
// @Namespace : UniSkyboxShader
// @Class     : SkyboxProceduralMaterialProxy
// ----------------------------------------------------------------------
namespace UniSkyboxShader
{
    using System;
    using UniShader.Shared;
    using UnityEngine;

    /// <summary>
    /// Procedural Skybox Material Proxy
    /// </summary>
    public class SkyboxProceduralMaterialProxy
    {
        #region Fields

        /// <summary></summary>
        private readonly Material _Material;

        #endregion

        #region Properties

        /// <summary>Sun</summary>
        public SunDisk SunDisk
        {
            get => _Material.GetSafeEnum<SunDisk>(Property.SunDisk, SunDisk.HighQuality);
            set => SetSunDisk(value);
        }

        /// <summary>Sun Size</summary>
        //[Range(0.0f, 1.0f)]
        public float SunSize
        {
            get => _Material.GetSafeFloat(Property.SunSize, PropertyRange.SunSize.defaultValue);
            set => _Material.SetSafeFloat(Property.SunSize, PropertyRange.SunSize, value);
        }

        /// <summary>Sun Size Convergence</summary>
        //[Range(1f, 10f)]
        public int SunSizeConvergence
        {
            get => _Material.GetSafeInt(Property.SunSizeConvergence, PropertyRange.SunSizeConvergence.defaultValue);
            set => _Material.SetSafeInt(Property.SunSizeConvergence, PropertyRange.SunSizeConvergence, value);
        }

        /// <summary>Atmosphere Thickness</summary>
        //[Range(0.0f, 5.0f)]
        public float AtmosphereThickness
        {
            get => _Material.GetSafeFloat(Property.AtmosphereThickness, PropertyRange.AtmosphereThickness.defaultValue);
            set => _Material.SetSafeFloat(Property.AtmosphereThickness, PropertyRange.AtmosphereThickness, value);
        }

        /// <summary>Sky Tint Color</summary>
        public Color SkyTint
        {
            get => _Material.GetSafeColor(Property.SkyTint, new Color(0.5f, 0.5f, 0.5f, 1.0f));
            set => _Material.SetSafeColor(Property.SkyTint, value);
        }

        /// <summary>Ground Color</summary>
        public Color GroundColor
        {
            get => _Material.GetSafeColor(Property.GroundColor, new Color(0.369f, 0.349f, 0.341f, 1.0f));
            set => _Material.SetSafeColor(Property.GroundColor, value);
        }

        /// <summary>Exposure</summary>
        //[Range(0.0f, 8.0f)]
        public float Exposure
        {
            get => _Material.GetSafeFloat(Property.Exposure, 1.3f);
            set => _Material.SetSafeFloat(Property.Exposure, PropertyRange.Exposure, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of SkyboxProceduralMaterialProxy.
        /// </summary>
        /// <param name="material">The skybox procedural material.</param>
        public SkyboxProceduralMaterialProxy(Material material)
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

            if (material.shader.name != ShaderName.Skybox_Procedural)
            {
                throw new ArgumentException();
            }

            _Material = material;
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sunDisk"></param>
        private void SetSunDisk(SunDisk sunDisk)
        {
            _Material.SetSafeInt(Property.SunDisk, (int)sunDisk);

            switch (sunDisk)
            {
                case SunDisk.None:
                    _Material.SetSafeKeyword(Keyword.SundiskNone, true);
                    _Material.SetSafeKeyword(Keyword.SundiskSimple, false);
                    _Material.SetSafeKeyword(Keyword.SundiskHighQuality, false);
                    break;
                case SunDisk.Simple:
                    _Material.SetSafeKeyword(Keyword.SundiskNone, false);
                    _Material.SetSafeKeyword(Keyword.SundiskSimple, true);
                    _Material.SetSafeKeyword(Keyword.SundiskHighQuality, false);
                    break;
                case SunDisk.HighQuality:
                    _Material.SetSafeKeyword(Keyword.SundiskNone, false);
                    _Material.SetSafeKeyword(Keyword.SundiskSimple, false);
                    _Material.SetSafeKeyword(Keyword.SundiskHighQuality, true);
                    break;
                default:
                    _Material.SetSafeKeyword(Keyword.SundiskNone, true);
                    _Material.SetSafeKeyword(Keyword.SundiskSimple, false);
                    _Material.SetSafeKeyword(Keyword.SundiskHighQuality, false);
                    break;
            }
        }

        #endregion
    }
}