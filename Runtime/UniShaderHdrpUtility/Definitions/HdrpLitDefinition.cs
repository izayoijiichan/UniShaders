// ----------------------------------------------------------------------
// @Namespace : UniHdrpShader
// @Class     : HdrpLitDefinition
// ----------------------------------------------------------------------
namespace UniHdrpShader
{
    using System;
    using UnityEngine;

    /// <summary>
    /// HDRP/Lit Definition
    /// </summary>
    /// <remarks>
    /// com.unity.render-pipelines.high-definition
    /// Lit.shader
    /// </remarks>
    public class HdrpLitDefinition : HdrpDefinitionBase
    {
        /// <summary>Color</summary>
        public Color BaseColor { get; set; }

        /// <summary>Base Color Map</summary>
        public Texture2D BaseColorMap { get; set; }

        /// <summary>Base Color Map Mip Info</summary>
        public Vector4 BaseColorMapMipInfo { get; set; }

        /// <summary>Metallic</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float Metallic { get; set; }

        /// <summary>Smoothness</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float Smoothness { get; set; }

        /// <summary>Mask Map</summary>
        public Texture2D MaskMap { get; set; }

        /// <summary>Metallic Remapping Min</summary>
        //[DefaultValue(0.0f)]
        public float MetallicRemapMin { get; set; }

        /// <summary>Metallic Remapping Max</summary>
        //[DefaultValue(1.0f)]
        public float MetallicRemapMax { get; set; }

        /// <summary>Smoothness Remapping Min</summary>
        //[DefaultValue(0.0f)]
        public float SmoothnessRemapMin { get; set; }

        /// <summary>Smoothness Remapping Max</summary>
        //[DefaultValue(1.0f)]
        public float SmoothnessRemapMax { get; set; }

        /// <summary>Ambient Occulusion Remapping Min</summary>
        //[DefaultValue(0.0f)]
        public float AORemapMin { get; set; }

        /// <summary>Ambient Occulusion Remapping Max</summary>
        //[DefaultValue(1.0f)]
        public float AORemapMax { get; set; }

        /// <summary>Normal Map</summary>
        public Texture2D NormalMap { get; set; }

        /// <summary>Normal Map Object Space</summary>
        public Texture2D NormalMapOS { get; set; }

        /// <summary>Normal Scale</summary>
        //[Range(0.0f, 8.0f)]
        //[DefaultValue(1.0f)]
        public float NormalScale { get; set; }

        /// <summary>Bent Normal Map</summary>
        public Texture2D BentNormalMap { get; set; }

        /// <summary>Bent Normal Map Object Space</summary>
        public Texture2D BentNormalMapOS { get; set; }

        /// <summary>Height Map</summary>
        public Texture2D HeightMap { get; set; }

        /// <summary>Height Amplitude</summary>
        //[DefaultValue(0.02f)]
        public float HeightAmplitude { get; set; }

        /// <summary>Height Center</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float HeightCenter { get; set; }

        /// <summary>HeightMap Parametrization</summary>
        //[DefaultValue(HeightmapParametrization.MinMax)]
        public HeightmapParametrization HeightMapParametrization { get; set; }

        /// <summary>Height Offset</summary>
        //[DefaultValue(0.0f)]
        public float HeightOffset { get; set; }

        /// <summary>Height Map Min</summary>
        //[DefaultValue(-1.0f)]
        public float HeightMin { get; set; }

        /// <summary>Height Map Max</summary>
        //[DefaultValue(1.0f)]
        public float HeightMax { get; set; }

        /// <summary>Height Tess Amplitude</summary>
        //[DefaultValue(2.0f)]
        public float HeightTessAmplitude { get; set; }

        /// <summary>Height Tess Center</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float HeightTessCenter { get; set; }

        /// <summary>Height PoM Amplitude</summary>
        //[DefaultValue(2.0f)]
        public float HeightPoMAmplitude { get; set; }

        /// <summary>Detail Map</summary>
        public Texture2D DetailMap { get; set; }

        /// <summary>Detail Albedo Scale</summary>
        //[Range(0.0f, 2.0f)]
        //[DefaultValue(1.0f)]
        public float DetailAlbedoScale { get; set; }

        /// <summary>Detail Normal Scale</summary>
        //[Range(0.0f, 2.0f)]
        //[DefaultValue(1.0f)]
        public float DetailNormalScale { get; set; }

        /// <summary>Detail Smoothness Scale</summary>
        //[Range(0.0f, 2.0f)]
        //[DefaultValue(1.0f)]
        public float DetailSmoothnessScale { get; set; }

        /// <summary>Tangent Map</summary>
        public Texture2D TangentMap { get; set; }

        /// <summary>Tangent Map Object Space</summary>
        public Texture2D TangentMapOS { get; set; }

        /// <summary>Anisotropy</summary>
        //[Range(-1.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float Anisotropy { get; set; }

        /// <summary>Anisotropy Map</summary>
        public Texture2D AnisotropyMap { get; set; }

        /// <summary>Subsurface Radius</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float SubsurfaceMask { get; set; }

        /// <summary>Subsurface Radius Map</summary>
        public Texture2D SubsurfaceMaskMap { get; set; }

        /// <summary>Thickness</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float Thickness { get; set; }

        /// <summary>Thickness Map</summary>
        public Texture2D ThicknessMap { get; set; }

        /// <summary>Thickness Remap</summary>
        //[DefaultValue(0, 1, 0, 0)]
        public Vector4 ThicknessRemap { get; set; }

        /// <summary>Iridescence Thickness</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float IridescenceThickness { get; set; }

        /// <summary>Iridescence Thickness Map</summary>
        public Texture2D IridescenceThicknessMap { get; set; }

        /// <summary>Iridescence Thickness Remap</summary>
        //[DefaultValue(0, 1, 0, 0)]
        public Vector4 IridescenceThicknessRemap { get; set; }

        /// <summary>Iridescence Mask</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float IridescenceMask { get; set; }

        /// <summary>Iridescence Mask Map</summary>
        public Texture2D IridescenceMaskMap { get; set; }

        /// <summary>Coat Mask</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float CoatMask { get; set; }

        /// <summary>Coat Mask Map</summary>
        public Texture2D CoatMaskMap { get; set; }

        /// <summary>Energy Conserving Specular Color</summary>
        //[DefaultValue(1.0f)]
        public float EnergyConservingSpecularColor { get; set; }

        /// <summary>Specular Color</summary>
        public Color SpecularColor { get; set; }

        /// <summary>Specular Color Map</summary>
        public Texture2D SpecularColorMap { get; set; }

        /// <summary>Specular Occlusion Mode</summary>
        //[DefaultValue(SpecularOcclusionMode.FromAmbientOcclusion)]
        public SpecularOcclusionMode SpecularOcclusionMode { get; set; }

        ///// <summary>Emissive Color</summary>
        //public Color EmissiveColor { get; set; }

        /// <summary>Emissive Color LDR</summary>
        public Color EmissiveColorLDR { get; set; }

        /// <summary>Emissive Color Map</summary>
        public Texture2D EmissiveColorMap { get; set; }

        /// <summary>Albedo Affect Emissive</summary>
        //[DefaultValue(1.0f)]
        public float AlbedoAffectEmissive { get; set; }

        /// <summary>Emissive Mode</summary>
        //[DefaultValue(0)]
        public int EmissiveIntensityUnit { get; set; }

        /// <summary>Use Emissive Intensity</summary>
        //[DefaultValue(false)]
        public bool UseEmissiveIntensity { get; set; }

        /// <summary>Emissive Intensity</summary>
        //[DefaultValue(1.0f)]
        public float EmissiveIntensity { get; set; }

        /// <summary>Emissive Pre Exposure</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float EmissiveExposureWeight { get; set; }

        /// <summary>Distortion Vector Map</summary>
        public Texture2D DistortionVectorMap { get; set; }

        /// <summary>Enable Distortion</summary>
        //[DefaultValue(false)]
        public bool DistortionEnable { get; set; }

        /// <summary>Distortion Depth Test Enable</summary>
        //[DefaultValue(true)]
        public bool DistortionDepthTest { get; set; }

        /// <summary>Distortion Blend Mode</summary>
        //[DefaultValue(DistortionBlendMode.Add)]
        public DistortionBlendMode DistortionBlendMode { get; set; }

        /// <summary>Distortion Blend Src</summary>
        //[DefaultValue(0)]
        public int DistortionSrcBlend { get; set; }

        /// <summary>Distortion Blend Dst</summary>
        //[DefaultValue(0)]
        public int DistortionDstBlend { get; set; }

        /// <summary>Distortion Blur Blend Src</summary>
        //[DefaultValue(0)]
        public int DistortionBlurSrcBlend { get; set; }

        /// <summary>Distortion Blur Blend Dst</summary>
        //[DefaultValue(0)]
        public int DistortionBlurDstBlend { get; set; }

        /// <summary>Distortion Blur Blend Mode</summary>
        //[DefaultValue(0)]
        public int DistortionBlurBlendMode { get; set; }

        /// <summary>Distortion Scale</summary>
        //[DefaultValue(1.0f)]
        public float DistortionScale { get; set; }

        /// <summary>Distortion Vector Scale</summary>
        //[DefaultValue(2.0f)]
        public float DistortionVectorScale { get; set; }

        /// <summary>Distortion Vector Bias</summary>
        //[DefaultValue(-1.0f)]
        public float DistortionVectorBias { get; set; }

        /// <summary>Distortion Blur Scale</summary>
        //[DefaultValue(1.0f)]
        public float DistortionBlurScale { get; set; }

        /// <summary>Distortion Blur Remap Min</summary>
        //[DefaultValue(0.0f)]
        public float DistortionBlurRemapMin { get; set; }

        /// <summary>Distortion Blur Remap Max</summary>
        //[DefaultValue(1.0f)]
        public float DistortionBlurRemapMax { get; set; }

        /// <summary>Alpha Cutoff</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float AlphaCutoff { get; set; }

        /// <summary>Alpha Cutoff Shadow</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float AlphaCutoffShadow { get; set; }

        /// <summary>Alpha Cutoff Prepass</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float AlphaCutoffPrepass { get; set; }

        /// <summary>Alpha Cutoff Postpass</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float AlphaCutoffPostpass { get; set; }

        /// <summary>Refraction Model</summary>
        //[DefaultValue(RefractionModel.None)]
        public RefractionModel RefractionModel { get; set; }

        /// <summary>Index Of Refraction</summary>
        //[Range(1.0f, 2.5f)]
        //[DefaultValue(1.5f)]
        public float Ior { get; set; }

        /// <summary>Transmittance Color</summary>
        public Color TransmittanceColor { get; set; }

        /// <summary>Transmittance Color Map</summary>
        public Texture2D TransmittanceColorMap { get; set; }

        /// <summary>Transmittance Absorption Distance</summary>
        //[DefaultValue(1.0f)]
        public float ATDistance { get; set; }

        /// <summary>ZTest Mode Distortion</summary>
        //[DefaultValue(4)]
        public int ZTestModeDistortion { get; set; }

        /// <summary>UV Set for base</summary>
        //[DefaultValue(UVBase.UV0)]
        public UVBaseMapping UVBase { get; set; }

        /// <summary>Scale to apply on world coordinate</summary>
        //[DefaultValue(1.0f)]
        public float TexWorldScale { get; set; }

        /// <summary>Inverse tiling scale</summary>
        /// <remarks>2 / (abs(_BaseColorMap_ST.x) + abs(_BaseColorMap_ST.y))</remarks>
        //[DefaultValue(1.0f)]
        public float InvTilingScale { get; set; }

        /// <summary>UV Mapping Mask</summary>
        public Color UVMappingMask { get; set; }

        /// <summary>Normal Map space</summary>
        //[DefaultValue(NormalMapSpace.TangentSpace)]
        public NormalMapSpace NormalMapSpace { get; set; }

        /// <summary>Material ID</summary>
        //[DefaultValue(MaterialId.Standard)]
        public MaterialId MaterialID { get; set; }

        /// <summary>Transmission Enable</summary>
        //[DefaultValue(true)]
        public bool TransmissionEnable { get; set; }

        /// <summary>Displacement Mode</summary>
        //[DefaultValue(DisplacementMode.None)]
        public DisplacementMode DisplacementMode { get; set; }

        /// <summary>displacement lock object scale</summary>
        //[DefaultValue(1.0f)]
        public float DisplacementLockObjectScale { get; set; }

        /// <summary>displacement lock tiling scale</summary>
        //[DefaultValue(1.0f)]
        public float DisplacementLockTilingScale { get; set; }

        /// <summary>Enable Geometric Specular AA</summary>
        //[DefaultValue(false)]
        public bool EnableGeometricSpecularAA { get; set; }

        /// <summary>Specular AA Screen Space Variance</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.1f)]
        public float SpecularAAScreenSpaceVariance { get; set; }

        /// <summary>Specular AA Threshold</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.2f)]
        public float SpecularAAThreshold { get; set; }

        /// <summary>Min sample for POM</summary>
        //[Range(1.0f, 64.0f)]
        //[DefaultValue(5.0f)]
        public float PPDMinSamples { get; set; }

        /// <summary>Max sample for POM</summary>
        //[Range(1.0f, 64.0f)]
        //[DefaultValue(15.0f)]
        public float PPDMaxSamples { get; set; }

        /// <summary>Start lod to fade out the POM effect</summary>
        //[Range(0.0f, 16.0f)]
        //[DefaultValue(5.0f)]
        public float PPDLodThreshold { get; set; }

        /// <summary>Primitive length for POM</summary>
        //[DefaultValue(1)]
        public float PPDPrimitiveLength { get; set; }

        /// <summary>Primitive width for POM</summary>
        //[DefaultValue(1)]
        public float PPDPrimitiveWidth { get; set; }

        /// <summary>Inverse primitive scale for non-planar POM</summary>
        //[DefaultValue(1, 1, 0, 0)]
        public Vector4 InvPrimScale { get; set; }

        /// <summary>UV Set for detail</summary>
        //[DefaultValue(UV.UV0)]
        public UVDetailMapping UVDetail { get; set; }

        /// <summary>UVDetailsMappingMask</summary>
        //[DefaultValue(1, 0, 0, 0)]
        public Vector4 UVDetailsMappingMask { get; set; }

        /// <summary>Link Details with Base</summary>
        //[DefaultValue(true)]
        public bool LinkDetailsWithBase { get; set; }

        /// <summary>Emissive color mode</summary>
        //[DefaultValue(EmissiveColorMode.UseEmissiveMask)]
        public EmissiveColorMode EmissiveColorMode { get; set; }

        /// <summary>UV Set for emissive</summary>
        //[DefaultValue(UV.UV0)]
        public UVEmissiveMapping UVEmissive { get; set; }

        /// <summary>Scale to apply on world coordinate</summary>
        //[DefaultValue(1.0f)]
        public float TexWorldScaleEmissive { get; set; }

        /// <summary>UV Mapping Mask Emissive</summary>
        public Color UVMappingMaskEmissive { get; set; }

        /// <summary>Emission Color</summary>
        public Color EmissionColor { get; set; }

        /// <summary>Albedo</summary>
        public Texture2D MainTex { get; set; }

        /// <summary>Color</summary>
        public Color Color { get; set; }

        /// <summary>Alpha Cutoff</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float Cutoff { get; set; }

        /// <summary>Add Precomputed Velocity</summary>
        //[DefaultValue(false)]
        public bool AddPrecomputedVelocity { get; set; }

        /// <summary>Ray Tracing (Preview)</summary>
        //[DefaultValue(false)]
        public bool RayTracing { get; set; }

        /// <summary></summary>
        /// <remarks>Obsolete, kept for migration purpose</remarks>
        [Obsolete]
        public int DiffusionProfile { get; set; }

        /// <summary>Diffusion Profile Asset</summary>
        //[DefaultValue(0, 0, 0, 0)]
        public Vector4 DiffusionProfileAsset { get; set; }

        /// <summary>Diffusion Profile Hash</summary>
        //[DefaultValue(0)]
        public float DiffusionProfileHash { get; set; }
    }
}