// ----------------------------------------------------------------------
// @Namespace : UniHdrpShader
// @Class     : PropertyRange
// ----------------------------------------------------------------------
namespace UniHdrpShader
{
    using UniShader.Shared;
    using UnityEngine;

    /// <summary>
    /// Property Range
    /// </summary>
    public class PropertyRange
    {
        #region Base

        /// <summary>Transparent Writing Motion Vec</summary>
        public static FloatRangeDefault TransparentWritingMotionVec = new FloatRangeDefault(float.MinValue, float.MaxValue, 0.0f);

        /// <summary>Transparent Sort Priority</summary>
        public static FloatRangeDefault TransparentSortPriority = new FloatRangeDefault(float.MinValue, float.MaxValue, 0.0f);

        /// <summary>Alpha to Mask Inspector Value</summary>
        public static FloatRangeDefault AlphaToMaskInspectorValue = new FloatRangeDefault(float.MinValue, float.MaxValue, 0.0f);

        /// <summary>ZTest Depth Equal for Opaque</summary>
        public static IntRangeDefault ZTestDepthEqualForOpaque = new IntRangeDefault(int.MinValue, int.MaxValue, 8);

        /// <summary>ZTest Transparent</summary>
        public static IntRangeDefault ZTestTransparent = new IntRangeDefault(int.MinValue, int.MaxValue, 4);

        /// <summary>Stencil Ref</summary>
        public static IntRangeDefault StencilRef = new IntRangeDefault(int.MinValue, int.MaxValue, 0);

        /// <summary>Stencil Ref Depth</summary>
        public static IntRangeDefault StencilRefDepth = new IntRangeDefault(int.MinValue, int.MaxValue, 0);

        #endregion

        #region Lit

        /// <summary>Metallic</summary>
        public static FloatRangeDefault Metallic = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Smoothness</summary>
        public static FloatRangeDefault Smoothness = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        /// <summary>Metallic Remapping Min</summary>
        public static FloatRangeDefault MetallicRemapMin = new FloatRangeDefault(float.MinValue, float.MaxValue, 0.0f);

        /// <summary>Metallic Remapping Max</summary>
        public static FloatRangeDefault MetallicRemapMax = new FloatRangeDefault(float.MinValue, float.MaxValue, 1.0f);

        /// <summary>Smoothness Remapping Min</summary>
        public static FloatRangeDefault SmoothnessRemapMin = new FloatRangeDefault(float.MinValue, float.MaxValue, 0.0f);

        /// <summary>Smoothness Remapping Max</summary>
        //[DefaultValue(1.0f)]
        public static FloatRangeDefault SmoothnessRemapMax = new FloatRangeDefault(float.MinValue, float.MaxValue, 1.0f);

        /// <summary>Ambient Occlusion Remapping Min</summary>
        //[DefaultValue(0.0f)]
        public static FloatRangeDefault AORemapMin = new FloatRangeDefault(float.MinValue, float.MaxValue, 0.0f);

        /// <summary>Ambient Occlusion Remapping Max</summary>
        //[DefaultValue(1.0f)]
        public static FloatRangeDefault AORemapMax = new FloatRangeDefault(float.MinValue, float.MaxValue, 1.0f);

        /// <summary>Normal Scale</summary>
        public static FloatRangeDefault NormalScale = new FloatRangeDefault(0.0f, 8.0f, 1.0f);

        /// <summary>Height Amplitude</summary>
        public static FloatRangeDefault HeightAmplitude = new FloatRangeDefault(0.005f, 0.08f, 0.02f);

        /// <summary>Height Center</summary>
        public static FloatRangeDefault HeightCenter = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        /// <summary>Height Offset</summary>
        public static FloatRangeDefault HeightOffset = new FloatRangeDefault(float.MinValue, float.MaxValue, 0.0f);

        /// <summary>Height Map Min</summary>
        public static FloatRangeDefault HeightMin = new FloatRangeDefault(float.MinValue, float.MaxValue, -1.0f);

        /// <summary>Height Map Max</summary>
        public static FloatRangeDefault HeightMax = new FloatRangeDefault(float.MinValue, float.MaxValue, 1.0f);

        /// <summary>Height Tess Amplitude</summary>
        public static FloatRangeDefault HeightTessAmplitude = new FloatRangeDefault(float.MinValue, float.MaxValue, 2.0f);

        /// <summary>Height Tess Center</summary>
        public static FloatRangeDefault HeightTessCenter = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        /// <summary>Height PoM Amplitude</summary>
        public static FloatRangeDefault HeightPoMAmplitude = new FloatRangeDefault(float.MinValue, float.MaxValue, 2.0f);

        /// <summary>Detail Albedo Scale</summary>
        public static FloatRangeDefault DetailAlbedoScale = new FloatRangeDefault(0.0f, 2.0f, 1.0f);

        /// <summary>Detail Normal Scale</summary>
        public static FloatRangeDefault DetailNormalScale = new FloatRangeDefault(0.0f, 2.0f, 1.0f);

        /// <summary>Detail Smoothness Scale</summary>
        public static FloatRangeDefault DetailSmoothnessScale = new FloatRangeDefault(0.0f, 2.0f, 1.0f);

        /// <summary>Anisotropy</summary>
        public static FloatRangeDefault Anisotropy = new FloatRangeDefault(-1.0f, 1.0f, 0.0f);

        /// <summary>Subsurface Radius</summary>
        public static FloatRangeDefault SubsurfaceMask = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        /// <summary>Thickness</summary>
        public static FloatRangeDefault Thickness = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        /// <summary>Iridescence Thickness</summary>
        public static FloatRangeDefault IridescenceThickness = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        /// <summary>Iridescence Mask</summary>
        public static FloatRangeDefault IridescenceMask = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        /// <summary>Coat Mask</summary>
        public static FloatRangeDefault CoatMask = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        /// <summary>Energy Conserving Specular Color</summary>
        public static FloatRangeDefault EnergyConservingSpecularColor = new FloatRangeDefault(float.MinValue, float.MaxValue, 1.0f);

        /// <summary>Albedo Affect Emissive</summary>
        public static FloatRangeDefault AlbedoAffectEmissive = new FloatRangeDefault(float.MinValue, float.MaxValue, 1.0f);

        /// <summary>Emissive Intensity</summary>
        public static FloatRangeDefault EmissiveIntensity = new FloatRangeDefault(float.MinValue, float.MaxValue, 1.0f);

        /// <summary>Emissive Pre Exposure</summary>
        public static FloatRangeDefault EmissiveExposureWeight = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        /// <summary>Distortion Scale</summary>
        public static FloatRangeDefault DistortionScale = new FloatRangeDefault(0.0f, float.MaxValue, 1.0f);

        /// <summary>Distortion Vector Scale</summary>
        public static FloatRangeDefault DistortionVectorScale = new FloatRangeDefault(0.0f, float.MaxValue, 2.0f);

        /// <summary>Distortion Vector Bias</summary>
        public static FloatRangeDefault DistortionVectorBias = new FloatRangeDefault(float.MinValue, float.MaxValue, -1.0f);

        /// <summary>Distortion Blur Scale</summary>
        public static FloatRangeDefault DistortionBlurScale = new FloatRangeDefault(float.MinValue, float.MaxValue, 1.0f);

        /// <summary>Distortion Blur Remap Min</summary>
        public static FloatRangeDefault DistortionBlurRemapMin = new FloatRangeDefault(float.MinValue, float.MaxValue, 0.0f);

        /// <summary>Distortion Blur Remap Max</summary>
        public static FloatRangeDefault DistortionBlurRemapMax = new FloatRangeDefault(float.MinValue, float.MaxValue, 1.0f);

        /// <summary>Alpha Cutoff</summary>
        public static FloatRangeDefault AlphaCutoff = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        /// <summary>Alpha Cutoff Shadow</summary>
        public static FloatRangeDefault AlphaCutoffShadow = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        /// <summary>Alpha Cutoff Prepass</summary>
        public static FloatRangeDefault AlphaCutoffPrepass = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        /// <summary>Alpha Cutoff Postpass</summary>
        public static FloatRangeDefault AlphaCutoffPostpass = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        /// <summary>Index Of Refraction</summary>
        public static FloatRangeDefault Ior = new FloatRangeDefault(1.0f, 2.5f, 1.5f);

        /// <summary>Transmittance Absorption Distance</summary>
        public static FloatRangeDefault ATDistance = new FloatRangeDefault(float.MinValue, float.MaxValue, 1.0f);

        /// <summary>Scale to apply on world coordinate</summary>
        public static FloatRangeDefault TexWorldScale = new FloatRangeDefault(float.MinValue, float.MaxValue, 1.0f);

        /// <summary>Inverse tiling scale</summary>
        public static FloatRangeDefault InvTilingScale = new FloatRangeDefault(float.MinValue, float.MaxValue, 1.0f);

        /// <summary>displacement lock object scale</summary>
        public static FloatRangeDefault DisplacementLockObjectScale = new FloatRangeDefault(float.MinValue, float.MaxValue, 1.0f);

        /// <summary>displacement lock tiling scale</summary>
        public static FloatRangeDefault DisplacementLockTilingScale = new FloatRangeDefault(float.MinValue, float.MaxValue, 1.0f);

        /// <summary>Specular AA Screen Space Variance</summary>
        public static FloatRangeDefault SpecularAAScreenSpaceVariance = new FloatRangeDefault(0.0f, 1.0f, 0.1f);

        /// <summary>Specular AA Threshold</summary>
        public static FloatRangeDefault SpecularAAThreshold = new FloatRangeDefault(0.0f, 1.0f, 0.2f);

        /// <summary>Min sample for POM</summary>
        public static FloatRangeDefault PPDMinSamples = new FloatRangeDefault(1.0f, 64.0f, 5.0f);

        /// <summary>Max sample for POM</summary>
        public static FloatRangeDefault PPDMaxSamples = new FloatRangeDefault(1.0f, 64.0f, 15.0f);

        /// <summary>Start lod to fade out the POM effect</summary>
        public static FloatRangeDefault PPDLodThreshold = new FloatRangeDefault(0.0f, 16.0f, 5.0f);

        /// <summary>Primitive length for POM</summary>
        public static FloatRangeDefault PPDPrimitiveLength = new FloatRangeDefault(float.MinValue, float.MaxValue, 1.0f);

        /// <summary>Primitive width for POM</summary>
        public static FloatRangeDefault PPDPrimitiveWidth = new FloatRangeDefault(float.MinValue, float.MaxValue, 1.0f);

        /// <summary>Scale to apply on world coordinate</summary>
        public static FloatRangeDefault TexWorldScaleEmissive = new FloatRangeDefault(float.MinValue, float.MaxValue, 1.0f);

        /// <summary>Alpha Cutoff</summary>
        public static FloatRangeDefault Cutoff = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        /// <summary>Diffusion Profile Hash</summary>
        public static FloatRangeDefault DiffusionProfileHash = new FloatRangeDefault(float.MinValue, float.MaxValue, 0.0f);

        #endregion

        #region Eye

        /// <summary>Sclera Normal Map Strength</summary>
        public static FloatRangeDefault Vector1_70564D59 = new FloatRangeDefault(0.0f, 8.0f, 1.0f);

        /// <summary>Iris Normal Map Strength</summary>
        public static FloatRangeDefault Vector1_FC0895C8 = new FloatRangeDefault(0.0f, 8.0f, 0.0f);

        /// <summary>Pupil Radius</summary>
        public static FloatRangeDefault Vector1_DFF948F3 = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Pupil Aperture</summary>
        public static FloatRangeDefault Vector1_FEA38ABB = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        /// <summary>Minimal Pupil Aperture</summary>
        public static FloatRangeDefault Vector1_2D21A623 = new FloatRangeDefault(0.0f, 0.3f, 0.05f);

        /// <summary>Maximal Pupil Aperture</summary>
        public static FloatRangeDefault Vector1_49C490F5 = new FloatRangeDefault(0.6f, 0.95f, 0.8f);

        /// <summary>Sclera Smoothness</summary>
        public static FloatRangeDefault Vector1_F084AE9E = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Cornea Smoothness</summary>
        public static FloatRangeDefault Vector1_8F0D1174 = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Iris Offset</summary>
        public static FloatRangeDefault Vector1_76BF2124 = new FloatRangeDefault(-0.02f, 0.02f, 0.0f);

        /// <summary>Limbal Ring Size Iris</summary>
        public static FloatRangeDefault Vector1_C4ED1456 = new FloatRangeDefault(0.01f, 0.3f, 0.01f);

        /// <summary>Limbal Ring Size Sclera</summary>
        public static FloatRangeDefault Vector1_94E1614A = new FloatRangeDefault(0.01f, 0.2f, 0.01f);

        /// <summary>Limbal Ring Fade</summary>
        public static FloatRangeDefault Vector1_6C2C412D = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Limbal Ring Intensity</summary>
        public static FloatRangeDefault Vector1_A6DA845F = new FloatRangeDefault(0.0f, 5.0f, 0.0f);

        #endregion

        #region Hair

        /// <summary>Alpha Clip Threshold</summary>
        public static FloatRangeDefault AlphaClipThreshold = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Alpha Clip Threshold Depth Prepass</summary>
        public static FloatRangeDefault AlphaClipThresholdDepthPrepass = new FloatRangeDefault(0.0f, 1.0f, 0.9f);

        /// <summary>Alpha Clip Threshold Depth Postpass</summary>
        public static FloatRangeDefault AlphaClipThresholdDepthPostpass = new FloatRangeDefault(0.0f, 1.0f, 0.6f);

        /// <summary>Alpha Clip Threshold Shadows</summary>
        public static FloatRangeDefault AlphaThresholdShadow = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        /// <summary>Smoothness Min</summary>
        public static FloatRangeDefault SmoothnessMin = new FloatRangeDefault(0.0f, 1.0f, 0.3f);

        /// <summary>Smoothness Max</summary>
        public static FloatRangeDefault SmoothnessMax = new FloatRangeDefault(0.0f, 1.0f, 0.7f);

        /// <summary>Specular Multiplier</summary>
        public static FloatRangeDefault Specular = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        /// <summary>Specular Shift</summary>
        public static FloatRangeDefault SpecularShift = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        /// <summary>Secondary Specular Multiplier</summary>
        public static FloatRangeDefault SecondarySpecular = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        /// <summary>Secondary Specular Shift</summary>
        public static FloatRangeDefault SecondarySpecularShift = new FloatRangeDefault(0.0f, 1.0f, 0.9f);

        /// <summary>Transmission Rim</summary>
        public static FloatRangeDefault TransmissionRim = new FloatRangeDefault(0.0f, 1.0f, 0.2f);

        #endregion
    }
}