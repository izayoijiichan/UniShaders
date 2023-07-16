// ----------------------------------------------------------------------
// @Namespace : UniHdrpShader
// @Class     : Property
// ----------------------------------------------------------------------
namespace UniHdrpShader
{
    /// <summary>
    /// Property
    /// </summary>
    public class Property
    {
        #region HDRP Common (Eye, Hair, Lit)

        /// <summary>Emission Color</summary>
        public const string EmissionColor = "_EmissionColor";

        /// <summary>Render Queue Type</summary>
        public const string RenderQueueType = "_RenderQueueType";

        /// <summary>Depth Offset Enable</summary>
        public const string DepthOffsetEnable = "_DepthOffsetEnable";

        /// <summary>Transparent Writing Motion Vec</summary>
        public const string TransparentWritingMotionVec = "_TransparentWritingMotionVec";

        /// <summary>Alpha Cutoff Enable</summary>
        public const string AlphaCutoffEnable = "_AlphaCutoffEnable";

        /// <summary>Transparent Sort Priority</summary>
        public const string TransparentSortPriority = "_TransparentSortPriority";

        /// <summary>Use Shadow Threshold</summary>
        public const string UseShadowThreshold = "_UseShadowThreshold";

        /// <summary>Double Sided Enable</summary>
        public const string DoubleSidedEnable = "_DoubleSidedEnable";

        /// <summary>Double Sided Normal Mode</summary>
        public const string DoubleSidedNormalMode = "_DoubleSidedNormalMode";

        /// <summary>Double Sided Constants</summary>
        public const string DoubleSidedConstants = "_DoubleSidedConstants";

        /// <summary>Transparent Depth Prepass Enable</summary>
        public const string TransparentDepthPrepassEnable = "_TransparentDepthPrepassEnable";

        /// <summary>Transparent Depth Postpass Enable</summary>
        public const string TransparentDepthPostpassEnable = "_TransparentDepthPostpassEnable";

        /// <summary>Surface Type</summary>
        public const string SurfaceType = "_SurfaceType";

        /// <summary>Blend Mode</summary>
        public const string BlendMode = "_BlendMode";

        /// <summary>Src Blend</summary>
        public const string SrcBlend = "_SrcBlend";

        /// <summary>Dst Blend</summary>
        public const string DstBlend = "_DstBlend";

        /// <summary>Alpha Src Blend</summary>
        public const string AlphaSrcBlend = "_AlphaSrcBlend";

        /// <summary>Alpha Dst Blend</summary>
        public const string AlphaDstBlend = "_AlphaDstBlend";

        /// <summary>Alpha to Mask</summary>
        public const string AlphaToMask = "_AlphaToMask";

        /// <summary>Alpha to Mask Inspector Value</summary>
        public const string AlphaToMaskInspectorValue = "_AlphaToMaskInspectorValue";

        /// <summary>ZWrite</summary>
        public const string ZWrite = "_ZWrite";

        /// <summary>Transparent ZWrite</summary>
        public const string TransparentZWrite = "_TransparentZWrite";

        /// <summary>Cull Mode</summary>
        public const string CullMode = "_CullMode";

        /// <summary>Cull Mode Forward</summary>
        public const string CullModeForward = "_CullModeForward";

        /// <summary>Transparent Cull Mode</summary>
        public const string TransparentCullMode = "_TransparentCullMode";

        /// <summary>Opaque Cull Mode</summary>
        public const string OpaqueCullMode = "_OpaqueCullMode";

        /// <summary>ZTest Depth Equal for Opaque</summary>
        public const string ZTestDepthEqualForOpaque = "_ZTestDepthEqualForOpaque";

        /// <summary>ZTest Transparent</summary>
        public const string ZTestTransparent = "_ZTestTransparent";

        /// <summary>Transparent Backface Enable</summary>
        public const string TransparentBackfaceEnable = "_TransparentBackfaceEnable";

        /// <summary>Require Split Lighting</summary>
        public const string RequireSplitLighting = "_RequireSplitLighting";

        /// <summary>Receives SSR</summary>
        public const string ReceivesSSR = "_ReceivesSSR";

        /// <summary>Receives SSR Transparent</summary>
        public const string ReceivesSSRTransparent = "_ReceivesSSRTransparent";

        /// <summary>Enable Fog on Transparent</summary>
        public const string EnableFogOnTransparent = "_EnableFogOnTransparent";

        /// <summary>Enable Blend Mode Preserve Specular Lighting</summary>
        public const string EnableBlendModePreserveSpecularLighting = "_EnableBlendModePreserveSpecularLighting";

        /// <summary>Support Decals</summary>
        public const string SupportDecals = "_SupportDecals";

        /// <summary>Stencil Ref</summary>
        public const string StencilRef = "StencilRef";

        /// <summary>Stencil Ref Depth</summary>
        public const string StencilRefDepth = "_StencilRefDepth";

        /// <summary>Stencil Ref Distortion Vec</summary>
        public const string StencilRefDistortionVec = "_StencilRefDistortionVec";

        /// <summary>Stencil Ref GBuffer</summary>
        public const string StencilRefGBuffer = "_StencilRefGBuffer";

        /// <summary>Stencil Ref MV</summary>
        public const string StencilRefMV = "_StencilRefMV";

        /// <summary>Stencil Write Mask</summary>
        public const string StencilWriteMask = "_StencilWriteMask";

        /// <summary>Stencil Write Mask Depth</summary>
        public const string StencilWriteMaskDepth = "_StencilWriteMaskDepth";

        /// <summary>StencilWriteMaskDistortionVec</summary>
        public const string StencilWriteMaskDistortionVec = "_StencilWriteMaskDistortionVec";

        /// <summary>Stencil Write Mask GBuffer</summary>
        public const string StencilWriteMaskGBuffer = "_StencilWriteMaskGBuffer";

        /// <summary>Stencil Write Mask MV</summary>
        public const string StencilWriteMaskMV = "_StencilWriteMaskMV";

        /// <summary>ZTest GBuffer</summary>
        public const string ZTestGBuffer = "_ZTestGBuffer";

        /// <summary>Unity Lightmaps</summary>
        public const string UnityLightmaps = "unity_Lightmaps";

        /// <summary>Unity Lightmaps Ind</summary>
        public const string UnityLightmapsInd = "unity_LightmapsInd";

        /// <summary>Unity Shadow Masks</summary>
        public const string UnityShadowMasks = "unity_ShadowMasks";

        #endregion

        #region Lit

        /// <summary>Base Color</summary>
        public const string BaseColor = "_BaseColor";

        /// <summary>Base Color Map</summary>
        public const string BaseColorMap = "_BaseColorMap";

        /// <summary>Base Color Map MipInfo</summary>
        public const string BaseColorMapMipInfo = "_BaseColorMap_MipInfo";

        /// <summary>Metallic</summary>
        public const string Metallic = "_Metallic";

        /// <summary>Smoothness</summary>
        public const string Smoothness = "_Smoothness";

        /// <summary>Mask Map</summary>
        public const string MaskMap = "_MaskMap";

        /// <summary>Metallic Remap Min</summary>
        public const string MetallicRemapMin = "_MetallicRemapMin";

        /// <summary>Metallic Remap Max</summary>
        public const string MetallicRemapMax = "_MetallicRemapMax";

        /// <summary>Smoothness Remap Min</summary>
        public const string SmoothnessRemapMin = "_SmoothnessRemapMin";

        /// <summary>Smoothness Remap Max</summary>
        public const string SmoothnessRemapMax = "_SmoothnessRemapMax";

        /// <summary>AO Remap Min</summary>
        public const string AORemapMin = "_AORemapMin";

        /// <summary>AO Remap Max</summary>
        public const string AORemapMax = "_AORemapMax";

        /// <summary>Normal Map</summary>
        public const string NormalMap = "_NormalMap";

        /// <summary>Normal Map OS</summary>
        public const string NormalMapOS = "_NormalMapOS";

        /// <summary>Normal Scale</summary>
        public const string NormalScale = "_NormalScale";

        /// <summary>Bent Normal Map</summary>
        public const string BentNormalMap = "_BentNormalMap";

        /// <summary>Bent Normal Map OS</summary>
        public const string BentNormalMapOS = "_BentNormalMapOS";

        /// <summary>Height Map</summary>
        public const string HeightMap = "_HeightMap";

        /// <summary>Height Amplitude</summary>
        public const string HeightAmplitude = "_HeightAmplitude";

        /// <summary>Height Center</summary>
        public const string HeightCenter = "_HeightCenter";

        /// <summary>Height Map Parametrization</summary>
        public const string HeightMapParametrization = "_HeightMapParametrization";

        /// <summary>Height Offset</summary>
        public const string HeightOffset = "_HeightOffset";

        /// <summary>Height Map Min</summary>
        public const string HeightMin = "_HeightMin";

        /// <summary>Height Map Max</summary>
        public const string HeightMax = "_HeightMax";

        /// <summary>Height Tess Amplitude</summary>
        public const string HeightTessAmplitude = "_HeightTessAmplitude";

        /// <summary>Height Tess Center</summary>
        public const string HeightTessCenter = "_HeightTessCenter";

        /// <summary>Height PoM Amplitude</summary>
        public const string HeightPoMAmplitude = "_HeightPoMAmplitude";

        /// <summary>Detail Map</summary>
        public const string DetailMap = "_DetailMap";

        /// <summary>Detail Albedo Scale</summary>
        public const string DetailAlbedoScale = "_DetailAlbedoScale";

        /// <summary>Detail Normal Scale</summary>
        public const string DetailNormalScale = "_DetailNormalScale";

        /// <summary>Detail Smoothness Scale</summary>
        public const string DetailSmoothnessScale = "_DetailSmoothnessScale";

        /// <summary>Tangent Map</summary>
        public const string TangentMap = "_TangentMap";

        /// <summary>Tangent Map OS</summary>
        public const string TangentMapOS = "_TangentMapOS";

        /// <summary>Anisotropy</summary>
        public const string Anisotropy = "_Anisotropy";

        /// <summary>Anisotropy Map</summary>
        public const string AnisotropyMap = "_AnisotropyMap";

        /// <summary>Subsurface Mask</summary>
        public const string SubsurfaceMask = "_SubsurfaceMask";

        /// <summary>Subsurface Mask Map</summary>
        public const string SubsurfaceMaskMap = "_SubsurfaceMaskMap";

        /// <summary>Thickness</summary>
        public const string Thickness = "_Thickness";

        /// <summary>Thickness Map</summary>
        public const string ThicknessMap = "_ThicknessMap";

        /// <summary>Thickness Remap</summary>
        public const string ThicknessRemap = "_ThicknessRemap";

        /// <summary>Iridescence Thickness</summary>
        public const string IridescenceThickness = "_IridescenceThickness";

        /// <summary>Iridescence Thickness Map</summary>
        public const string IridescenceThicknessMap = "_IridescenceThicknessMap";

        /// <summary>Iridescence Thickness Remap</summary>
        public const string IridescenceThicknessRemap = "_IridescenceThicknessRemap";

        /// <summary>Iridescence Mask</summary>
        public const string IridescenceMask = "_IridescenceMask";

        /// <summary>Iridescence Mask Map</summary>
        public const string IridescenceMaskMap = "_IridescenceMaskMap";

        /// <summary>Coat Mask</summary>
        public const string CoatMask = "_CoatMask";

        /// <summary>Coat Mask Map</summary>
        public const string CoatMaskMap = "_CoatMaskMap";

        /// <summary>Energy Conserving Specular Color</summary>
        public const string EnergyConservingSpecularColor = "_EnergyConservingSpecularColor";

        /// <summary>Specular Color</summary>
        public const string SpecularColor = "_SpecularColor";

        /// <summary>Specular Color Map</summary>
        public const string SpecularColorMap = "_SpecularColorMap";

        /// <summary>Specular Occlusion Mode</summary>
        public const string SpecularOcclusionMode = "_SpecularOcclusionMode";

        /// <summary>Emissive Color</summary>
        public const string EmissiveColor = "_EmissiveColor";

        /// <summary>Emissive Color LDR</summary>
        public const string EmissiveColorLDR = "_EmissiveColorLDR";

        /// <summary>Emissive Color Map</summary>
        public const string EmissiveColorMap = "_EmissiveColorMap";

        /// <summary>Albedo Affect Emissive</summary>
        public const string AlbedoAffectEmissive = "_AlbedoAffectEmissive";

        /// <summary>Emissive Intensity Unit</summary>
        public const string EmissiveIntensityUnit = "_EmissiveIntensityUnit";

        /// <summary>Use Emissive Intensity</summary>
        public const string UseEmissiveIntensity = "_UseEmissiveIntensity";

        /// <summary>Emissive Intensity</summary>
        public const string EmissiveIntensity = "_EmissiveIntensity";

        /// <summary>Emissive Exposure Weight</summary>
        public const string EmissiveExposureWeight = "_EmissiveExposureWeight";

        /// <summary>Distortion Vector Map</summary>
        public const string DistortionVectorMap = "_DistortionVectorMap";

        /// <summary>Distortion Enable</summary>
        public const string DistortionEnable = "_DistortionEnable";

        /// <summary>Distortion Depth Test</summary>
        public const string DistortionDepthTest = "_DistortionDepthTest";

        /// <summary>Distortion Blend Mode</summary>
        public const string DistortionBlendMode = "_DistortionBlendMode";

        /// <summary>Distortio Src Blend</summary>
        public const string DistortionSrcBlend = "_DistortionSrcBlend";

        /// <summary>Distortion Dst Blend</summary>
        public const string DistortionDstBlend = "_DistortionDstBlend";

        /// <summary>Distortion Blur Src Blend</summary>
        public const string DistortionBlurSrcBlend = "_DistortionBlurSrcBlend";

        /// <summary>Distortion Blur Dst Blend</summary>
        public const string DistortionBlurDstBlend = "_DistortionBlurDstBlend";

        /// <summary>DistortionBlurBlendOp</summary>
        public const string DistortionBlurBlendOp = "_DistortionBlurBlendOp";

        /// <summary>Distortion Scale</summary>
        public const string DistortionScale = "_DistortionScale";

        /// <summary>Distortion Vector Scale</summary>
        public const string DistortionVectorScale = "_DistortionVectorScale";

        /// <summary>Distortion Vector Bias</summary>
        public const string DistortionVectorBias = "_DistortionVectorBias";

        /// <summary>Distortion Blur Scale</summary>
        public const string DistortionBlurScale = "_DistortionBlurScale";

        /// <summary>Distortion Blur Remap Min</summary>
        public const string DistortionBlurRemapMin = "_DistortionBlurRemapMin";

        /// <summary>Distortion Blur Remap Max</summary>
        public const string DistortionBlurRemapMax = "_DistortionBlurRemapMax";

        /// <summary>Alpha Cutoff</summary>
        public const string AlphaCutoff = "_AlphaCutoff";

        /// <summary>Alpha Cutoff Shadow</summary>
        public const string AlphaCutoffShadow = "_AlphaCutoffShadow";

        /// <summary>Alpha Cutoff Prepass</summary>
        public const string AlphaCutoffPrepass = "_AlphaCutoffPrepass";

        /// <summary>Alpha Cutoff Postpass</summary>
        public const string AlphaCutoffPostpass = "_AlphaCutoffPostpass";

        /// <summary>Refraction Model</summary>
        public const string RefractionModel = "_RefractionModel";

        /// <summary>Ior</summary>
        public const string Ior = "_Ior";

        /// <summary>Transmittance Color</summary>
        public const string TransmittanceColor = "_TransmittanceColor";

        /// <summary>Transmittance Color Map</summary>
        public const string TransmittanceColorMap = "_TransmittanceColorMap";

        /// <summary>AT Distance</summary>
        public const string ATDistance = "_ATDistance";

        /// <summary>ZTest Mode Distortion</summary>
        public const string ZTestModeDistortion = "_ZTestModeDistortion";

        /// <summary>UV Base</summary>
        public const string UVBase = "_UVBase";

        /// <summary>Tex World Scale</summary>
        public const string TexWorldScale = "_TexWorldScale";

        /// <summary>Inv Tiling Scale</summary>
        public const string InvTilingScale = "_InvTilingScale";

        /// <summary>UV Mapping Mask</summary>
        public const string UVMappingMask = "_UVMappingMask";

        /// <summary>Normal Map Space</summary>
        public const string NormalMapSpace = "_NormalMapSpace";

        /// <summary>Material ID</summary>
        public const string MaterialID = "_MaterialID";

        /// <summary>Transmission Enable</summary>
        public const string TransmissionEnable = "_TransmissionEnable";

        /// <summary>Displacement Mode</summary>
        public const string DisplacementMode = "_DisplacementMode";

        /// <summary>Displacement Lock Object Scale</summary>
        public const string DisplacementLockObjectScale = "_DisplacementLockObjectScale";

        /// <summary>Displacement Lock Tiling Scale</summary>
        public const string DisplacementLockTilingScale = "_DisplacementLockTilingScale";

        /// <summary>Enable Geometric Specular AA</summary>
        public const string EnableGeometricSpecularAA = "_EnableGeometricSpecularAA";

        /// <summary>Specular AA Screen Space Variance</summary>
        public const string SpecularAAScreenSpaceVariance = "_SpecularAAScreenSpaceVariance";

        /// <summary>Specular AA Threshold</summary>
        public const string SpecularAAThreshold = "_SpecularAAThreshold";

        /// <summary>PPD Min Samples</summary>
        public const string PPDMinSamples = "_PPDMinSamples";

        /// <summary>PPD Max Samples</summary>
        public const string PPDMaxSamples = "_PPDMaxSamples";

        /// <summary>PPD Lod Threshold</summary>
        public const string PPDLodThreshold = "_PPDLodThreshold";

        /// <summary>PPDPrimitiveLength</summary>
        public const string PPDPrimitiveLength = "_PPDPrimitiveLength";

        /// <summary>PPD Primitive Width</summary>
        public const string PPDPrimitiveWidth = "_PPDPrimitiveWidth";

        /// <summary>Inv Prim Scale</summary>
        public const string InvPrimScale = "_InvPrimScale";

        /// <summary>UV Detail</summary>
        public const string UVDetail = "_UVDetail";

        /// <summary>UV Details Mapping Mask</summary>
        public const string UVDetailsMappingMask = "_UVDetailsMappingMask";

        /// <summary>Link Details with Base</summary>
        public const string LinkDetailsWithBase = "_LinkDetailsWithBase";

        /// <summary>Emissive Color Mode</summary>
        public const string EmissiveColorMode = "_EmissiveColorMode";

        /// <summary>UV Emissive</summary>
        public const string UVEmissive = "_UVEmissive";

        /// <summary>Tex World Scale Emissive</summary>
        public const string TexWorldScaleEmissive = "_TexWorldScaleEmissive";

        /// <summary>UV Mapping Mask Emissive</summary>
        public const string UVMappingMaskEmissive = "_UVMappingMaskEmissive";

        /// <summary>Main Tex</summary>
        public const string MainTex = "_MainTex";

        /// <summary>Color</summary>
        public const string Color = "_Color";

        /// <summary>Cutoff</summary>
        public const string Cutoff = "_Cutoff";

        /// <summary>Add Precomputed Velocity</summary>
        public const string AddPrecomputedVelocity = "_AddPrecomputedVelocity";

        /// <summary>Ray Tracing</summary>
        public const string RayTracing = "_RayTracing";

        /// <summary>Diffusion Profile</summary>
        public const string DiffusionProfile = "_DiffusionProfile";

        /// <summary>Diffusion Profile Asset</summary>
        public const string DiffusionProfileAsset = "_DiffusionProfileAsset";

        /// <summary>Diffusion Profile Hash</summary>
        public const string DiffusionProfileHash = "_DiffusionProfileHash";

        #endregion

        #region Eye

        /// <summary>Sclera Texture</summary>
        public const string Texture2D_5F873FC1 = "Texture2D_5F873FC1";

        /// <summary>Sclera Normal</summary>
        public const string Texture2D_B9F5688C = "Texture2D_B9F5688C";

        /// <summary>Sclera Normal Strength</summary>
        public const string Vector1_70564D59 = "Vector1_70564D59";

        /// <summary>Iris Texture</summary>
        public const string Texture2D_D8BF6575 = "Texture2D_D8BF6575";

        /// <summary>IrisNormal</summary>
        public const string Texture2D_4DB28C10 = "Texture2D_4DB28C10";

        /// <summary>Iris Normal Strength</summary>
        public const string Vector1_FC0895C8 = "Vector1_FC0895C8";

        /// <summary>Iris Clamp Color</summary>
        //[Obsolete]
        public const string Color_83777D09 = "Color_83777D09";

        /// <summary>Pupil Radius</summary>
        public const string Vector1_DFF948F3 = "Vector1_DFF948F3";

        /// <summary>Pupil DebugMode</summary>
        public const string Boolean_8D34052F = "Boolean_8D34052F";

        /// <summary>Pupil Aperture</summary>
        public const string Vector1_FEA38ABB = "Vector1_FEA38ABB";

        /// <summary>Minimal Pupil Aperture</summary>
        public const string Vector1_2D21A623 = "Vector1_2D21A623";

        /// <summary>Maximal Pupil Aperture</summary>
        public const string Vector1_49C490F5 = "Vector1_49C490F5";

        /// <summary>Sclera Smoothness</summary>
        public const string Vector1_F084AE9E = "Vector1_F084AE9E";

        /// <summary>Cornea Smoothness</summary>
        public const string Vector1_8F0D1174 = "Vector1_8F0D1174";

        /// <summary>Iris Offset</summary>
        public const string Vector1_76BF2124 = "Vector1_76BF2124";

        /// <summary>Limbal Ring Size Iris</summary>
        public const string Vector1_C4ED1456 = "Vector1_C4ED1456";

        /// <summary>Limbal Ring Size Sclera</summary>
        public const string Vector1_94E1614A = "Vector1_94E1614A";

        /// <summary>Limbal Ring Fade</summary>
        public const string Vector1_6C2C412D = "Vector1_6C2C412D";

        /// <summary>Limbal Ring Intensity</summary>
        public const string Vector1_A6DA845F = "Vector1_A6DA845F";

        /// <summary>Iris Diffusion Profile</summary>
        public const string DiffusionProfile_bfbe0deb8ec4428a9cfcdb968651903c = "DiffusionProfile_bfbe0deb8ec4428a9cfcdb968651903c";

        /// <summary></summary>
        public const string DiffusionProfile_bfbe0deb8ec4428a9cfcdb968651903c_Asset = "DiffusionProfile_bfbe0deb8ec4428a9cfcdb968651903c_Asset";

        /// <summary>Sclera Diffusion Profile</summary>
        public const string DiffusionProfile_261f48f1fbc94ccbafc421414859c159 = "DiffusionProfile_261f48f1fbc94ccbafc421414859c159";

        /// <summary></summary>
        public const string DiffusionProfile_261f48f1fbc94ccbafc421414859c159_Asset = "DiffusionProfile_261f48f1fbc94ccbafc421414859c159_Asset";

        #endregion

        #region Hair

        ///// <summary>Base Color Map</summary>
        //public const string BaseColorMap = "_BaseColorMap";

        ///// <summary>Base Color</summary>
        //public const string BaseColor = "_BaseColor";

        /// <summary>Alpha Clipping</summary>
        public const string Alpha = "_Alpha";

        /// <summary>Alpha Clip Threshold</summary>
        public const string AlphaClipThreshold = "_AlphaClipThreshold";

        /// <summary>Alpha Clip Threshold Depth Prepass</summary>
        public const string AlphaClipThresholdDepthPrepass = "_AlphaClipThresholdDepthPrepass";

        /// <summary>Alpha Clip Threshold Depth Postpass</summary>
        public const string AlphaClipThresholdDepthPostpass = "_AlphaClipThresholdDepthPostpass";

        /// <summary>Alpha Clip Threshold Shadows</summary>
        public const string AlphaThresholdShadow = "_AlphaThresholdShadow";

        /// <summary>Base UV Scale Transform</summary>
        public const string UVBaseST = "_uvBaseST";

        ///// <summary>Normal Map</summary>
        //public const string NormalMap = "_NormalMap";

        ///// <summary>Normal Strength</summary>
        //public const string NormalScale = "_NormalScale";

        ///// <summary>AO Map</summary>
        //public const string MaskMap = "_MaskMap";

        /// <summary>AO Use Lightmap UV</summary>
        public const string LightmapUV = "_LightmapUV";

        /// <summary>Smoothness Mask</summary>
        public const string SmoothnessMask = "_SmoothnessMask";

        /// <summary>Smoothness UV Scale Transform</summary>
        public const string UVSmoothnessST = "_uvSmoothnessST";

        /// <summary>Smoothness Min</summary>
        public const string SmoothnessMin = "_SmoothnessMin";

        /// <summary>Smoothness Max</summary>
        public const string SmoothnessMax = "_SmoothnessMax";

        ///// <summary>Specular Color</summary>
        //public const string SpecularColor = "_SpecularColor";

        /// <summary>Specular Multiplier</summary>
        public const string Specular = "_Specular";

        /// <summary>Specular Shift</summary>
        public const string SpecularShift = "_SpecularShift";

        /// <summary>Secondary Specular Multiplier</summary>
        public const string SecondarySpecular = "_SecondarySpecular";

        /// <summary>Secondary Specular Shift</summary>
        public const string SecondarySpecularShift = "_SecondarySpecularShift";

        /// <summary>Transmission Color</summary>
        public const string TransmissionColor = "_TransmissionColor";

        /// <summary>Transmission Rim</summary>
        public const string TransmissionRim = "_TransmissionRim";

        #endregion
    }
}