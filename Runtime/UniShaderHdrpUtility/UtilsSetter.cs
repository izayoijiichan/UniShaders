// ----------------------------------------------------------------------
// @Namespace : UniHdrpShader
// @Class     : Utils
// ----------------------------------------------------------------------
namespace UniHdrpShader
{
    using System;
    using UnityEngine;

    public static partial class Utils
    {
        /// <summary>
        /// Set the parameter value to the material.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="material"></param>
        /// <param name="parameters"></param>
        public static void SetParametersToMaterial<T>(Material material, in T parameters)
        {
            Type type = typeof(T);

            if (type == HdrpEyeDefinitionType)
            {
                SetHdrpEyeParametersToMaterial(material, parameters as HdrpEyeDefinition);
            }
            else if (type == HdrpHairDefinitionType)
            {
                SetHdrpHairParametersToMaterial(material, parameters as HdrpHairDefinition);
            }
            else if (type == HdrpLitDefinitionType)
            {
                SetHdrpLitParametersToMaterial(material, parameters as HdrpLitDefinition);
            }
            else
            {
                throw new NotSupportedException();
            }
        }

        /// <summary>
        /// Set the parameter value to the material.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="parameters"></param>
        private static void SetHdrpEyeParametersToMaterial(Material material, in HdrpEyeDefinition parameters)
        {
            new HdrpEyeMaterialProxy(material)
            {
                // Surface Options
                SurfaceType = parameters.SurfaceType,
                BlendMode = parameters.BlendMode,

                RenderQueueType = parameters.RenderQueueType,

                EnableBlendModePreserveSpecularLighting = parameters.EnableBlendModePreserveSpecularLighting,

                CullMode = parameters.CullMode,
                CullModeForward = parameters.CullModeForward,
                OpaqueCullMode = parameters.OpaqueCullMode,

                //SrcBlend = parameters.SrcBlend,
                //DstBlend = parameters.DstBlend,
                //ZWrite = parameters.ZWrite,

                // Transparent
                TransparentCullMode = parameters.TransparentCullMode,
                EnableFogOnTransparent = parameters.EnableFogOnTransparent,
                TransparentSortPriority = parameters.TransparentSortPriority,
                TransparentBackfaceEnable = parameters.TransparentBackfaceEnable,
                TransparentDepthPrepassEnable = parameters.TransparentDepthPrepassEnable,
                TransparentDepthPostpassEnable = parameters.TransparentDepthPostpassEnable,
                TransparentWritingMotionVec = parameters.TransparentWritingMotionVec,
                //TransparentZWrite = parameters.TransparentZWrite,

                ZTestDepthEqualForOpaque = parameters.ZTestDepthEqualForOpaque,
                ZTestTransparent = parameters.ZTestTransparent,

                // Alpha Clipping
                AlphaCutoffEnable = parameters.AlphaCutoffEnable,
                UseShadowThreshold = parameters.UseShadowThreshold,
                AlphaToMask = parameters.AlphaToMask,
                AlphaToMaskInspectorValue = parameters.AlphaToMaskInspectorValue,

                //AlphaSrcBlend = parameters.AlphaSrcBlend,
                //AlphaDstBlend = parameters.AlphaDstBlend,

                // Double Sided
                DoubleSidedEnable = parameters.DoubleSidedEnable,
                DoubleSidedNormalMode = parameters.DoubleSidedNormalMode,
                DoubleSidedConstants = parameters.DoubleSidedConstants,

                SupportDecals = parameters.SupportDecals,
                ReceivesSSR = parameters.ReceivesSSR,
                ReceivesSSRTransparent = parameters.ReceivesSSRTransparent,

                EmissiveColor = parameters.EmissiveColor,

                DepthOffsetEnable = parameters.DepthOffsetEnable,

                RequireSplitLighting = parameters.RequireSplitLighting,

                // Stencil
                StencilRef = parameters.StencilRef,
                StencilRefDepth = parameters.StencilRefDepth,
                StencilRefDistortionVec = parameters.StencilRefDistortionVec,
                StencilRefGBuffer = parameters.StencilRefGBuffer,
                StencilRefMV = parameters.StencilRefMV,
                StencilWriteMask = parameters.StencilWriteMask,
                StencilWriteMaskDepth = parameters.StencilWriteMaskDepth,
                StencilWriteMaskDistortionVec = parameters.StencilWriteMaskDistortionVec,
                StencilWriteMaskGBuffer = parameters.StencilWriteMaskGBuffer,
                StencilWriteMaskMV = parameters.StencilWriteMaskMV,

                ZTestGBuffer = parameters.ZTestGBuffer,

                // Exposed Properties

                // Sclera
                Texture2D_5F873FC1 = parameters.Texture2D_5F873FC1,
                Texture2D_B9F5688C = parameters.Texture2D_B9F5688C,
                Vector1_70564D59 = parameters.Vector1_70564D59,

                // Iris
                Texture2D_D8BF6575 = parameters.Texture2D_D8BF6575,
                Texture2D_4DB28C10 = parameters.Texture2D_4DB28C10,
                Vector1_FC0895C8 = parameters.Vector1_FC0895C8,
                Color_83777D09 = parameters.Color_83777D09,

                // Pupil
                Vector1_DFF948F3 = parameters.Vector1_DFF948F3,
                Boolean_8D34052F = parameters.Boolean_8D34052F,
                Vector1_FEA38ABB = parameters.Vector1_FEA38ABB,
                Vector1_2D21A623 = parameters.Vector1_2D21A623,
                Vector1_49C490F5 = parameters.Vector1_49C490F5,

                Vector1_F084AE9E = parameters.Vector1_F084AE9E,
                Vector1_8F0D1174 = parameters.Vector1_8F0D1174,
                Vector1_76BF2124 = parameters.Vector1_76BF2124,

                // Limbal Ring
                Vector1_C4ED1456 = parameters.Vector1_C4ED1456,
                Vector1_94E1614A = parameters.Vector1_94E1614A,
                Vector1_6C2C412D = parameters.Vector1_6C2C412D,
                Vector1_A6DA845F = parameters.Vector1_A6DA845F,

                // Iris Diffusion Profile
                DiffusionProfile_bfbe0deb8ec4428a9cfcdb968651903c = parameters.DiffusionProfile_bfbe0deb8ec4428a9cfcdb968651903c,
                DiffusionProfile_bfbe0deb8ec4428a9cfcdb968651903c_Asset = parameters.DiffusionProfile_bfbe0deb8ec4428a9cfcdb968651903c_Asset,

                // Sclera Diffusion Profile
                DiffusionProfile_261f48f1fbc94ccbafc421414859c159 = parameters.DiffusionProfile_261f48f1fbc94ccbafc421414859c159,
                DiffusionProfile_261f48f1fbc94ccbafc421414859c159_Asset = parameters.DiffusionProfile_261f48f1fbc94ccbafc421414859c159_Asset,
            };
        }

        /// <summary>
        /// Set the parameter value to the material.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="parameters"></param>
        private static void SetHdrpHairParametersToMaterial(Material material, in HdrpHairDefinition parameters)
        {
            new HdrpHairMaterialProxy(material)
            {
                // Surface Options
                SurfaceType = parameters.SurfaceType,
                BlendMode = parameters.BlendMode,

                RenderQueueType = parameters.RenderQueueType,

                EnableBlendModePreserveSpecularLighting = parameters.EnableBlendModePreserveSpecularLighting,

                CullMode = parameters.CullMode,
                CullModeForward = parameters.CullModeForward,
                OpaqueCullMode = parameters.OpaqueCullMode,

                //SrcBlend = parameters.SrcBlend,
                //DstBlend = parameters.DstBlend,
                //ZWrite = parameters.ZWrite,

                // Transparent
                TransparentCullMode = parameters.TransparentCullMode,
                EnableFogOnTransparent = parameters.EnableFogOnTransparent,
                TransparentSortPriority = parameters.TransparentSortPriority,
                TransparentBackfaceEnable = parameters.TransparentBackfaceEnable,
                TransparentDepthPrepassEnable = parameters.TransparentDepthPrepassEnable,
                TransparentDepthPostpassEnable = parameters.TransparentDepthPostpassEnable,
                TransparentWritingMotionVec = parameters.TransparentWritingMotionVec,
                //TransparentZWrite = parameters.TransparentZWrite,

                ZTestDepthEqualForOpaque = parameters.ZTestDepthEqualForOpaque,
                ZTestTransparent = parameters.ZTestTransparent,

                // Alpha Clipping
                AlphaCutoffEnable = parameters.AlphaCutoffEnable,
                UseShadowThreshold = parameters.UseShadowThreshold,
                AlphaToMask = parameters.AlphaToMask,
                AlphaToMaskInspectorValue = parameters.AlphaToMaskInspectorValue,

                //AlphaSrcBlend = parameters.AlphaSrcBlend,
                //AlphaDstBlend = parameters.AlphaDstBlend,

                // Double Sided
                DoubleSidedEnable = parameters.DoubleSidedEnable,
                DoubleSidedNormalMode = parameters.DoubleSidedNormalMode,
                DoubleSidedConstants = parameters.DoubleSidedConstants,

                SupportDecals = parameters.SupportDecals,
                ReceivesSSR = parameters.ReceivesSSR,
                ReceivesSSRTransparent = parameters.ReceivesSSRTransparent,

                EmissiveColor = parameters.EmissiveColor,

                DepthOffsetEnable = parameters.DepthOffsetEnable,

                RequireSplitLighting = parameters.RequireSplitLighting,

                // Stencil
                StencilRef = parameters.StencilRef,
                StencilRefDepth = parameters.StencilRefDepth,
                StencilRefDistortionVec = parameters.StencilRefDistortionVec,
                StencilRefGBuffer = parameters.StencilRefGBuffer,
                StencilRefMV = parameters.StencilRefMV,
                StencilWriteMask = parameters.StencilWriteMask,
                StencilWriteMaskDepth = parameters.StencilWriteMaskDepth,
                StencilWriteMaskDistortionVec = parameters.StencilWriteMaskDistortionVec,
                StencilWriteMaskGBuffer = parameters.StencilWriteMaskGBuffer,
                StencilWriteMaskMV = parameters.StencilWriteMaskMV,

                ZTestGBuffer = parameters.ZTestGBuffer,

                // Exposed Properties

                // Base
                BaseColor = parameters.BaseColor,
                BaseColorMap = parameters.BaseColorMap,

                // Alpha
                Alpha = parameters.Alpha,
                AlphaClipThreshold = parameters.AlphaClipThreshold,
                AlphaClipThresholdDepthPrepass = parameters.AlphaClipThresholdDepthPrepass,
                AlphaClipThresholdDepthPostpass = parameters.AlphaClipThresholdDepthPostpass,
                AlphaThresholdShadow = parameters.AlphaThresholdShadow,

                // Base UV
                UVBaseST = parameters.UVBaseST,

                // Normal
                NormalMap = parameters.NormalMap,
                NormalScale = parameters.NormalScale,

                // Ambient Occulusion
                MaskMap = parameters.MaskMap,
                LightmapUV = parameters.LightmapUV,

                // Smoothness
                SmoothnessMask = parameters.SmoothnessMask,
                UVSmoothnessST = parameters.UVSmoothnessST,
                SmoothnessMin = parameters.SmoothnessMin,
                SmoothnessMax = parameters.SmoothnessMax,

                // Specular
                SpecularColor = parameters.SpecularColor,
                Specular = parameters.Specular,
                SpecularShift = parameters.SpecularShift,
                SecondarySpecular = parameters.SecondarySpecular,
                SecondarySpecularShift = parameters.SecondarySpecularShift,

                // Transmission
                TransmissionColor = parameters.TransmissionColor,
                TransmissionRim = parameters.TransmissionRim,
            };
        }

        /// <summary>
        /// Set the parameter value to the material.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="parameters"></param>
        private static void SetHdrpLitParametersToMaterial(Material material, in HdrpLitDefinition parameters)
        {
            new HdrpLitMaterialProxy(material)
            {
                // Blending state

                // Surface Options
                SurfaceType = parameters.SurfaceType,
                BlendMode = parameters.BlendMode,
                RenderQueueType = parameters.RenderQueueType,

                //SrcBlend = parameters.SrcBlend,
                //DstBlend = parameters.DstBlend,
                //AlphaSrcBlend = parameters.AlphaSrcBlend,
                //AlphaDstBlend = parameters.AlphaDstBlend,

                AlphaToMask = parameters.AlphaToMask,
                AlphaToMaskInspectorValue = parameters.AlphaToMaskInspectorValue,

                //ZWrite = parameters.ZWrite,
                //TransparentZWrite = parameters.TransparentZWrite,

                CullMode = parameters.CullMode,
                CullModeForward = parameters.CullModeForward,
                TransparentCullMode = parameters.TransparentCullMode,
                OpaqueCullMode = parameters.OpaqueCullMode,

                ZTestDepthEqualForOpaque = parameters.ZTestDepthEqualForOpaque,
                ZTestModeDistortion = parameters.ZTestModeDistortion,
                ZTestTransparent = parameters.ZTestTransparent,

                EnableFogOnTransparent = parameters.EnableFogOnTransparent,
                EnableBlendModePreserveSpecularLighting = parameters.EnableBlendModePreserveSpecularLighting,

                // Double Sided
                DoubleSidedEnable = parameters.DoubleSidedEnable,
                DoubleSidedNormalMode = parameters.DoubleSidedNormalMode,
                DoubleSidedConstants = parameters.DoubleSidedConstants,

                MainTex = parameters.MainTex,
                Color = parameters.Color,
                Cutoff = parameters.Cutoff,

                // Base Map
                BaseColor = parameters.BaseColor,
                BaseColorMap = parameters.BaseColorMap,
                BaseColorMapMipInfo = parameters.BaseColorMapMipInfo,

                // Metallic Gloss Map
                Metallic = parameters.Metallic,
                Smoothness = parameters.Smoothness,
                MetallicRemapMin = parameters.MetallicRemapMin,
                MetallicRemapMax = parameters.MetallicRemapMax,
                SmoothnessRemapMin = parameters.SmoothnessRemapMin,
                SmoothnessRemapMax = parameters.SmoothnessRemapMax,

                // Ambient Occulusion
                MaskMap = parameters.MaskMap,
                AORemapMin = parameters.AORemapMin,
                AORemapMax = parameters.AORemapMax,

                // Normal Map
                NormalMap = parameters.NormalMap,
                NormalMapOS = parameters.NormalMapOS,
                NormalScale = parameters.NormalScale,

                // Bent Normal Map
                BentNormalMap = parameters.BentNormalMap,
                BentNormalMapOS = parameters.BentNormalMapOS,

                // Height Map
                HeightMap = parameters.HeightMap,
                HeightAmplitude = parameters.HeightAmplitude,
                HeightCenter = parameters.HeightCenter,

                HeightMapParametrization = parameters.HeightMapParametrization,

                HeightOffset = parameters.HeightOffset,
                HeightMin = parameters.HeightMin,
                HeightMax = parameters.HeightMax,
                HeightTessAmplitude = parameters.HeightTessAmplitude,
                HeightTessCenter = parameters.HeightTessCenter,

                HeightPoMAmplitude = parameters.HeightPoMAmplitude,

                // Detail Map
                DetailMap = parameters.DetailMap,
                DetailAlbedoScale = parameters.DetailAlbedoScale,
                DetailNormalScale = parameters.DetailNormalScale,
                DetailSmoothnessScale = parameters.DetailSmoothnessScale,

                // Tangent Map
                TangentMap = parameters.TangentMap,
                TangentMapOS = parameters.TangentMapOS,

                // Anisotropy Map
                Anisotropy = parameters.Anisotropy,
                AnisotropyMap = parameters.AnisotropyMap,

                // Subsurface Mask Map
                SubsurfaceMask = parameters.SubsurfaceMask,
                SubsurfaceMaskMap = parameters.SubsurfaceMaskMap,

                // Thickness Map
                Thickness = parameters.Thickness,
                ThicknessMap = parameters.ThicknessMap,
                ThicknessRemap = parameters.ThicknessRemap,

                // Iridescence Thickness Map
                IridescenceThickness = parameters.IridescenceThickness,
                IridescenceThicknessMap = parameters.IridescenceThicknessMap,
                IridescenceThicknessRemap = parameters.IridescenceThicknessRemap,

                // Iridescence Mask Map
                IridescenceMask = parameters.IridescenceMask,
                IridescenceMaskMap = parameters.IridescenceMaskMap,

                // Coat Mask Map
                CoatMask = parameters.CoatMask,
                CoatMaskMap = parameters.CoatMaskMap,

                // Specular Color Map
                EnergyConservingSpecularColor = parameters.EnergyConservingSpecularColor,
                SpecularColor = parameters.SpecularColor,
                SpecularColorMap = parameters.SpecularColorMap,
                SpecularOcclusionMode = parameters.SpecularOcclusionMode,

                // Specular AA
                EnableGeometricSpecularAA = parameters.EnableGeometricSpecularAA,
                SpecularAAScreenSpaceVariance = parameters.SpecularAAScreenSpaceVariance,
                SpecularAAThreshold = parameters.SpecularAAThreshold,

                PPDMinSamples = parameters.PPDMinSamples,
                PPDMaxSamples = parameters.PPDMaxSamples,
                PPDLodThreshold = parameters.PPDLodThreshold,
                PPDPrimitiveLength = parameters.PPDPrimitiveLength,
                PPDPrimitiveWidth = parameters.PPDPrimitiveWidth,
                InvPrimScale = parameters.InvPrimScale,

                UVDetail = parameters.UVDetail,
                UVDetailsMappingMask = parameters.UVDetailsMappingMask,
                LinkDetailsWithBase = parameters.LinkDetailsWithBase,

                // Emissive Color Map

                EmissiveColorMode = parameters.EmissiveColorMode,
                EmissiveColor = parameters.EmissiveColor,
                EmissionColor = parameters.EmissionColor,
                EmissiveColorLDR = parameters.EmissiveColorLDR,
                EmissiveColorMap = parameters.EmissiveColorMap,

                UVEmissive = parameters.UVEmissive,
                TexWorldScaleEmissive = parameters.TexWorldScaleEmissive,
                UVMappingMaskEmissive = parameters.UVMappingMaskEmissive,

                AlbedoAffectEmissive = parameters.AlbedoAffectEmissive,
                EmissiveIntensityUnit = parameters.EmissiveIntensityUnit,
                UseEmissiveIntensity = parameters.UseEmissiveIntensity,
                EmissiveIntensity = parameters.EmissiveIntensity,
                EmissiveExposureWeight = parameters.EmissiveExposureWeight,

                // Distortion Vector Map
                DistortionVectorMap = parameters.DistortionVectorMap,
                DistortionEnable = parameters.DistortionEnable,
                DistortionDepthTest = parameters.DistortionDepthTest,
                DistortionBlendMode = parameters.DistortionBlendMode,
                //DistortionSrcBlend = parameters.DistortionSrcBlend,
                //DistortionDstBlend = parameters.DistortionDstBlend,
                //DistortionBlurSrcBlend = parameters.DistortionBlurSrcBlend,
                //DistortionBlurDstBlend = parameters.DistortionBlurDstBlend,
                //DistortionBlurBlendOp = parameters.DistortionBlurBlendOp,
                DistortionScale = parameters.DistortionScale,
                DistortionVectorScale = parameters.DistortionVectorScale,
                DistortionVectorBias = parameters.DistortionVectorBias,
                DistortionBlurScale = parameters.DistortionBlurScale,
                DistortionBlurRemapMin = parameters.DistortionBlurRemapMin,
                DistortionBlurRemapMax = parameters.DistortionBlurRemapMax,

                UseShadowThreshold = parameters.UseShadowThreshold,

                // Alpha Clipping
                AlphaCutoffEnable = parameters.AlphaCutoffEnable,
                AlphaCutoff = parameters.AlphaCutoff,
                AlphaCutoffShadow = parameters.AlphaCutoffShadow,
                AlphaCutoffPrepass = parameters.AlphaCutoffPrepass,
                AlphaCutoffPostpass = parameters.AlphaCutoffPostpass,

                // Transparent
                TransparentSortPriority = parameters.TransparentSortPriority,
                TransparentBackfaceEnable = parameters.TransparentBackfaceEnable,
                TransparentDepthPrepassEnable = parameters.TransparentDepthPrepassEnable,
                TransparentDepthPostpassEnable = parameters.TransparentDepthPostpassEnable,
                TransparentWritingMotionVec = parameters.TransparentWritingMotionVec,

                // Transparency
                RefractionModel = parameters.RefractionModel,
                Ior = parameters.Ior,
                TransmittanceColor = parameters.TransmittanceColor,
                TransmittanceColorMap = parameters.TransmittanceColorMap,
                ATDistance = parameters.ATDistance,

                UVBase = parameters.UVBase,
                TexWorldScale = parameters.TexWorldScale,
                InvTilingScale = parameters.InvTilingScale,
                UVMappingMask = parameters.UVMappingMask,
                NormalMapSpace = parameters.NormalMapSpace,

                TransmissionEnable = parameters.TransmissionEnable,

                DisplacementMode = parameters.DisplacementMode,
                DisplacementLockObjectScale = parameters.DisplacementLockObjectScale,
                DisplacementLockTilingScale = parameters.DisplacementLockTilingScale,

                // @notice after set DisplacementMode
                DepthOffsetEnable = parameters.DepthOffsetEnable,

                RequireSplitLighting = parameters.RequireSplitLighting,

                // Stencil state

                // Forward
                StencilRef = parameters.StencilRef,
                StencilWriteMask = parameters.StencilWriteMask,

                // GBuffer
                StencilRefGBuffer = parameters.StencilRefGBuffer,
                StencilWriteMaskGBuffer = parameters.StencilWriteMaskGBuffer,

                // Depth prepass
                StencilRefDepth = parameters.StencilRefDepth,
                StencilWriteMaskDepth = parameters.StencilWriteMaskDepth,

                // Motion vector pass
                StencilRefMV = parameters.StencilRefMV,
                StencilWriteMaskMV = parameters.StencilWriteMaskMV,

                // Distortion vector pass
                StencilRefDistortionVec = parameters.StencilRefDistortionVec,
                StencilWriteMaskDistortionVec = parameters.StencilWriteMaskDistortionVec,

                ZTestGBuffer = parameters.ZTestGBuffer,

                SupportDecals = parameters.SupportDecals,
                ReceivesSSR = parameters.ReceivesSSR,
                ReceivesSSRTransparent = parameters.ReceivesSSRTransparent,
                AddPrecomputedVelocity = parameters.AddPrecomputedVelocity,

                RayTracing = parameters.RayTracing,

                //DiffusionProfile = parameters.DiffusionProfile,
                DiffusionProfileAsset = parameters.DiffusionProfileAsset,
                DiffusionProfileHash = parameters.DiffusionProfileHash,

                // @notice last
                MaterialID = parameters.MaterialID,
            };
        }
    }
}