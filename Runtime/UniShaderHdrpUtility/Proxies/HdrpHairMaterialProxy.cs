// ----------------------------------------------------------------------
// @Namespace : UniHdrpShader
// @Class     : HdrpHairMaterialProxy
// ----------------------------------------------------------------------
namespace UniHdrpShader
{
    using System;
    using UniShader.Shared;
    using UnityEngine;

    /// <summary>
    /// HDRP Hair Material Proxy
    /// </summary>
    /// <remarks>
    /// com.unity.render-pipelines.high-definition
    /// Hair.shadergraph
    /// </remarks>
    public class HdrpHairMaterialProxy : HdrpMaterialProxyBase
    {
        #region Properties

        /// <summary>Base Color Map</summary>
        public Texture2D BaseColorMap
        {
            get => _Material.GetSafeTexture(Property.BaseColorMap);
            set => _Material.SetSafeTexture(Property.BaseColorMap, value);
        }

        /// <summary>Base Color</summary>
        //[DefaultValue(0.5f, 0.5f, 0.5f, 1.0f)]
        public Color BaseColor
        {
            get => _Material.GetSafeColor(Property.BaseColor, new Color(0.5f, 0.5f, 0.5f, 1.0f));
            set => _Material.SetSafeColor(Property.BaseColor, value);
        }

        /// <summary>Alpha Clipping</summary>
        //[DefaultValue(true)]
        public bool Alpha
        {
            get => _Material.GetSafeBool(Property.Alpha, true);
            set => _Material.SetSafeBool(Property.Alpha, value);
        }

        /// <summary>Alpha Clip Threshold</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float AlphaClipThreshold
        {
            get => _Material.GetSafeFloat(Property.AlphaClipThreshold, PropertyRange.AlphaClipThreshold.defaultValue);
            set => _Material.SetSafeFloat(Property.AlphaClipThreshold, PropertyRange.AlphaClipThreshold, value);
        }

        /// <summary>Alpha Clip Threshold Depth Prepass</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.9f)]
        public float AlphaClipThresholdDepthPrepass
        {
            get => _Material.GetSafeFloat(Property.AlphaClipThresholdDepthPrepass, PropertyRange.AlphaClipThresholdDepthPrepass.defaultValue);
            set => _Material.SetSafeFloat(Property.AlphaClipThresholdDepthPrepass, PropertyRange.AlphaClipThresholdDepthPrepass, value);
        }

        /// <summary>Alpha Clip Threshold Depth Postpass</summary>
        //[Range(0.0f, 1.0f)]
        public float AlphaClipThresholdDepthPostpass
        {
            get => _Material.GetSafeFloat(Property.AlphaClipThresholdDepthPostpass, PropertyRange.AlphaClipThresholdDepthPostpass.defaultValue);
            set => _Material.SetSafeFloat(Property.AlphaClipThresholdDepthPostpass, PropertyRange.AlphaClipThresholdDepthPostpass, value);
        }

        /// <summary>Alpha Clip Threshold Shadows</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float AlphaThresholdShadow
        {
            get => _Material.GetSafeFloat(Property.AlphaThresholdShadow, PropertyRange.AlphaThresholdShadow.defaultValue);
            set => _Material.SetSafeFloat(Property.AlphaThresholdShadow, PropertyRange.AlphaThresholdShadow, value);
        }

        /// <summary>Base UV Scale Transform</summary>
        //[DefaultValue(1.0f, 1.0f, 0.0f, 0.0f)]
        public Vector4 UVBaseST
        {
            get => _Material.GetSafeVector4(Property.UVBaseST, new Vector4(1.0f, 1.0f, 0.0f, 0.0f));
            set => _Material.SetSafeVector(Property.UVBaseST, value);
        }

        /// <summary>Normal Map</summary>
        public Texture2D NormalMap
        {
            get => _Material.GetSafeTexture(Property.NormalMap);
            set => _Material.SetSafeTexture(Property.NormalMap, value);
        }

        /// <summary>Normal Strength</summary>
        //[Range(0.0f, 8.0f)]
        //[DefaultValue(1.0f)]
        public float NormalScale
        {
            get => _Material.GetSafeFloat(Property.NormalScale, PropertyRange.NormalScale.defaultValue);
            set => _Material.SetSafeFloat(Property.NormalScale, PropertyRange.NormalScale, value);
        }

        /// <summary>AO Map</summary>
        public Texture2D MaskMap
        {
            get => _Material.GetSafeTexture(Property.MaskMap);
            set => _Material.SetSafeTexture(Property.MaskMap, value);
        }

        /// <summary>AO Use Lightmap UV</summary>
        //[DefaultValue(false)]
        public bool LightmapUV
        {
            get => _Material.GetSafeBool(Property.LightmapUV, true);
            set => _Material.SetSafeBool(Property.LightmapUV, value);
        }

        /// <summary>Smoothness Mask</summary>
        public Texture2D SmoothnessMask
        {
            get => _Material.GetSafeTexture(Property.SmoothnessMask);
            set => _Material.SetSafeTexture(Property.SmoothnessMask, value);
        }

        /// <summary>Smoothness UV Scale Transform</summary>
        //[DefaultValue(20.0f, 5.0f, 0.0f, 0.0f)]
        public Vector4 UVSmoothnessST
        {
            get => _Material.GetSafeVector4(Property.UVSmoothnessST, new Vector4(20.0f, 5.0f, 0.0f, 0.0f));
            set => _Material.SetSafeVector(Property.UVSmoothnessST, value);
        }

        /// <summary>Smoothness Min</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.3f)]
        public float SmoothnessMin
        {
            get => _Material.GetSafeFloat(Property.SmoothnessMin, PropertyRange.SmoothnessMin.defaultValue);
            set => _Material.SetSafeFloat(Property.SmoothnessMin, PropertyRange.SmoothnessMin, value);
        }

        /// <summary>Smoothness Max</summary>
        //[Range(0.0f, 1.0f)]
        public float SmoothnessMax
        {
            get => _Material.GetSafeFloat(Property.SmoothnessMax, PropertyRange.SmoothnessMax.defaultValue);
            set => _Material.SetSafeFloat(Property.SmoothnessMax, PropertyRange.SmoothnessMax, value);
        }

        /// <summary>Specular Color</summary>
        //[DefaultValue(0.6039215922355652f, 0.3137255012989044f, 0.0f, 1.0f)]
        public Color SpecularColor
        {
            get => _Material.GetSafeColor(Property.SpecularColor, new Color(0.6039215922355652f, 0.3137255012989044f, 0.0f, 1.0f));
            set => _Material.SetSafeColor(Property.SpecularColor, value);
        }

        /// <summary>Specular Multiplier</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float Specular
        {
            get => _Material.GetSafeFloat(Property.Specular, PropertyRange.Specular.defaultValue);
            set => _Material.SetSafeFloat(Property.Specular, PropertyRange.Specular, value);
        }

        /// <summary>Specular Shift</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float SpecularShift
        {
            get => _Material.GetSafeFloat(Property.SpecularShift, PropertyRange.SpecularShift.defaultValue);
            set => _Material.SetSafeFloat(Property.SpecularShift, PropertyRange.SpecularShift, value);
        }

        /// <summary>Secondary Specular Multiplier</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float SecondarySpecular
        {
            get => _Material.GetSafeFloat(Property.SecondarySpecular, PropertyRange.SecondarySpecular.defaultValue);
            set => _Material.SetSafeFloat(Property.SecondarySpecular, PropertyRange.SecondarySpecular, value);
        }

        /// <summary>Secondary Specular Shift</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.9f)]
        public float SecondarySpecularShift
        {
            get => _Material.GetSafeFloat(Property.SecondarySpecularShift, PropertyRange.SecondarySpecularShift.defaultValue);
            set => _Material.SetSafeFloat(Property.SecondarySpecularShift, PropertyRange.SecondarySpecularShift, value);
        }

        /// <summary>Transmission Color</summary>
        //[DefaultValue(1.0f, 0.8666666746139526f, 0.6274510025978088f, 1.0f)]
        public Color TransmissionColor
        {
            get => _Material.GetSafeColor(Property.TransmissionColor, new Color(1.0f, 0.8666666746139526f, 0.6274510025978088f, 1.0f));
            set => _Material.SetSafeColor(Property.TransmissionColor, value);
        }

        /// <summary>Transmission Rim</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.2f)]
        public float TransmissionRim
        {
            get => _Material.GetSafeFloat(Property.TransmissionRim, PropertyRange.TransmissionRim.defaultValue);
            set => _Material.SetSafeFloat(Property.TransmissionRim, PropertyRange.TransmissionRim, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of HdrpHairMaterialProxy.
        /// </summary>
        /// <param name="material">The HDRP hair material.</param>
        public HdrpHairMaterialProxy(Material material) : base(material)
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

            if (material.shader.name != ShaderName.HDRP_Hair)
            {
                throw new ArgumentException();
            }
        }

        #endregion
    }
}