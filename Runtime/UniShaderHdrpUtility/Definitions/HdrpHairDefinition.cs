// ----------------------------------------------------------------------
// @Namespace : UniHdrpShader
// @Class     : HdrpHairDefinition
// ----------------------------------------------------------------------
namespace UniHdrpShader
{
    using UnityEngine;

    /// <summary>
    /// HDRP/Hair Definition
    /// </summary>
    /// <remarks>
    /// com.unity.render-pipelines.high-definition
    /// Hair.shadergraph
    /// </remarks>
    public class HdrpHairDefinition : HdrpDefinitionBase
    {
        /// <summary>Base Color Map</summary>
        public Texture2D BaseColorMap { get; set; }

        /// <summary>Base Color</summary>
        //[DefaultValue(0.5f, 0.5f, 0.5f, 1.0f)]
        public Color BaseColor { get; set; }

        /// <summary>Alpha Clipping</summary>
        //[DefaultValue(true)]
        public bool Alpha { get; set; }

        /// <summary>Alpha Clip Threshold</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float AlphaClipThreshold { get; set; }

        /// <summary>Alpha Clip Threshold Depth Prepass</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.9f)]
        public float AlphaClipThresholdDepthPrepass { get; set; }

        /// <summary>Alpha Clip Threshold Depth Postpass</summary>
        //[Range(0.0f, 1.0f)]
        public float AlphaClipThresholdDepthPostpass { get; set; }

        /// <summary>Alpha Clip Threshold Shadows</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float AlphaThresholdShadow { get; set; }

        /// <summary>Base UV Scale Transform</summary>
        //[DefaultValue(1.0f, 1.0f, 0.0f, 0.0f)]
        public Vector4 UVBaseST { get; set; }

        /// <summary>Normal Map</summary>
        public Texture2D NormalMap { get; set; }

        /// <summary>Normal Strength</summary>
        //[Range(0.0f, 8.0f)]
        //[DefaultValue(1.0f)]
        public float NormalScale { get; set; }

        /// <summary>AO Map</summary>
        public Texture2D MaskMap { get; set; }

        /// <summary>AO Use Lightmap UV</summary>
        //[DefaultValue(false)]
        public bool LightmapUV { get; set; }

        /// <summary>Smoothness Mask</summary>
        public Texture2D SmoothnessMask { get; set; }

        /// <summary>Smoothness UV Scale Transform</summary>
        //[DefaultValue(20.0f, 5.0f, 0.0f, 0.0f)]
        public Vector4 UVSmoothnessST { get; set; }

        /// <summary>Smoothness Min</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.3f)]
        public float SmoothnessMin { get; set; }

        /// <summary>Smoothness Max</summary>
        //[Range(0.0f, 1.0f)]
        public float SmoothnessMax { get; set; }

        /// <summary>Specular Color</summary>
        //[DefaultValue(0.6039215922355652f, 0.3137255012989044f, 0.0f, 1.0f)]
        public Color SpecularColor { get; set; }

        /// <summary>Specular Multiplier</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float Specular { get; set; }

        /// <summary>Specular Shift</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float SpecularShift { get; set; }

        /// <summary>Secondary Specular Multiplier</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float SecondarySpecular { get; set; }

        /// <summary>Secondary Specular Shift</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.9f)]
        public float SecondarySpecularShift { get; set; }

        /// <summary>Transmission Color</summary>
        //[DefaultValue(1.0f, 0.8666666746139526f, 0.6274510025978088f, 1.0f)]
        public Color TransmissionColor { get; set; }

        /// <summary>Transmission Rim</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.2f)]
        public float TransmissionRim { get; set; }
    }
}