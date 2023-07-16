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
        /// Get the parameters from the material.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="material"></param>
        /// <returns></returns>
        public static T GetParametersFromMaterial<T>(Material material) where T : class
        {
            Type type = typeof(T);

            if (type == HdrpEyeDefinitionType)
            {
                return GetHdrpEyeParametersFromMaterial(material) as T;
            }
            else if (type == HdrpHairDefinitionType)
            {
                return GetHdrpHairParametersFromMaterial(material) as T;
            }
            else if (type == HdrpLitDefinitionType)
            {
                return GetHdrpLitParametersFromMaterial(material) as T;
            }
            else
            {
                throw new NotSupportedException();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        private static HdrpEyeDefinition GetHdrpEyeParametersFromMaterial(Material material)
        {
            var materialProxy = new HdrpEyeMaterialProxy(material);

            return new HdrpEyeDefinition
            {
                // Surface Options
                SurfaceType = materialProxy.SurfaceType,
                BlendMode = materialProxy.BlendMode,

                RenderQueueType = materialProxy.RenderQueueType,

                EnableBlendModePreserveSpecularLighting = materialProxy.EnableBlendModePreserveSpecularLighting,

                CullMode = materialProxy.CullMode,
                CullModeForward = materialProxy.CullModeForward,
                OpaqueCullMode = materialProxy.OpaqueCullMode,

                SrcBlend = materialProxy.SrcBlend,
                DstBlend = materialProxy.DstBlend,
                ZWrite = materialProxy.ZWrite,

                // Transparent
                TransparentCullMode = materialProxy.TransparentCullMode,
                EnableFogOnTransparent = materialProxy.EnableFogOnTransparent,
                TransparentSortPriority = materialProxy.TransparentSortPriority,
                TransparentBackfaceEnable = materialProxy.TransparentBackfaceEnable,
                TransparentDepthPrepassEnable = materialProxy.TransparentDepthPrepassEnable,
                TransparentDepthPostpassEnable = materialProxy.TransparentDepthPostpassEnable,
                TransparentWritingMotionVec = materialProxy.TransparentWritingMotionVec,
                TransparentZWrite = materialProxy.TransparentZWrite,

                ZTestDepthEqualForOpaque = materialProxy.ZTestDepthEqualForOpaque,
                ZTestTransparent = materialProxy.ZTestTransparent,

                // Alpha Clipping
                AlphaCutoffEnable = materialProxy.AlphaCutoffEnable,
                UseShadowThreshold = materialProxy.UseShadowThreshold,
                AlphaToMask = materialProxy.AlphaToMask,
                AlphaToMaskInspectorValue = materialProxy.AlphaToMaskInspectorValue,

                AlphaSrcBlend = materialProxy.AlphaSrcBlend,
                AlphaDstBlend = materialProxy.AlphaDstBlend,

                // Double Sided
                DoubleSidedEnable = materialProxy.DoubleSidedEnable,
                DoubleSidedNormalMode = materialProxy.DoubleSidedNormalMode,
                DoubleSidedConstants = materialProxy.DoubleSidedConstants,

                SupportDecals = materialProxy.SupportDecals,
                ReceivesSSR = materialProxy.ReceivesSSR,
                ReceivesSSRTransparent = materialProxy.ReceivesSSRTransparent,

                EmissiveColor = materialProxy.EmissiveColor,

                DepthOffsetEnable = materialProxy.DepthOffsetEnable,

                RequireSplitLighting = materialProxy.RequireSplitLighting,

                // Stencil
                StencilRef = materialProxy.StencilRef,
                StencilRefDepth = materialProxy.StencilRefDepth,
                StencilRefDistortionVec = materialProxy.StencilRefDistortionVec,
                StencilRefGBuffer = materialProxy.StencilRefGBuffer,
                StencilRefMV = materialProxy.StencilRefMV,
                StencilWriteMask = materialProxy.StencilWriteMask,
                StencilWriteMaskDepth = materialProxy.StencilWriteMaskDepth,
                StencilWriteMaskDistortionVec = materialProxy.StencilWriteMaskDistortionVec,
                StencilWriteMaskGBuffer = materialProxy.StencilWriteMaskGBuffer,
                StencilWriteMaskMV = materialProxy.StencilWriteMaskMV,

                ZTestGBuffer = materialProxy.ZTestGBuffer,

                // Exposed Properties

                // Sclera
                Texture2D_5F873FC1 = materialProxy.Texture2D_5F873FC1,
                Texture2D_B9F5688C = materialProxy.Texture2D_B9F5688C,
                Vector1_70564D59 = materialProxy.Vector1_70564D59,

                // Iris
                Texture2D_D8BF6575 = materialProxy.Texture2D_D8BF6575,
                Texture2D_4DB28C10 = materialProxy.Texture2D_4DB28C10,
                Vector1_FC0895C8 = materialProxy.Vector1_FC0895C8,
                Color_83777D09 = materialProxy.Color_83777D09,

                // Pupil
                Vector1_DFF948F3 = materialProxy.Vector1_DFF948F3,
                Boolean_8D34052F = materialProxy.Boolean_8D34052F,
                Vector1_FEA38ABB = materialProxy.Vector1_FEA38ABB,
                Vector1_2D21A623 = materialProxy.Vector1_2D21A623,
                Vector1_49C490F5 = materialProxy.Vector1_49C490F5,

                Vector1_F084AE9E = materialProxy.Vector1_F084AE9E,
                Vector1_8F0D1174 = materialProxy.Vector1_8F0D1174,
                Vector1_76BF2124 = materialProxy.Vector1_76BF2124,

                // Limbal Ring
                Vector1_C4ED1456 = materialProxy.Vector1_C4ED1456,
                Vector1_94E1614A = materialProxy.Vector1_94E1614A,
                Vector1_6C2C412D = materialProxy.Vector1_6C2C412D,
                Vector1_A6DA845F = materialProxy.Vector1_A6DA845F,

                // Iris Diffusion Profile
                DiffusionProfile_bfbe0deb8ec4428a9cfcdb968651903c = materialProxy.DiffusionProfile_bfbe0deb8ec4428a9cfcdb968651903c,
                DiffusionProfile_bfbe0deb8ec4428a9cfcdb968651903c_Asset = materialProxy.DiffusionProfile_bfbe0deb8ec4428a9cfcdb968651903c_Asset,

                // Sclera Diffusion Profile
                DiffusionProfile_261f48f1fbc94ccbafc421414859c159 = materialProxy.DiffusionProfile_261f48f1fbc94ccbafc421414859c159,
                DiffusionProfile_261f48f1fbc94ccbafc421414859c159_Asset = materialProxy.DiffusionProfile_261f48f1fbc94ccbafc421414859c159_Asset,
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        private static HdrpHairDefinition GetHdrpHairParametersFromMaterial(Material material)
        {
            var materialProxy = new HdrpHairMaterialProxy(material);

            return new HdrpHairDefinition
            {
                // Surface Options
                SurfaceType = materialProxy.SurfaceType,
                BlendMode = materialProxy.BlendMode,

                RenderQueueType = materialProxy.RenderQueueType,

                EnableBlendModePreserveSpecularLighting = materialProxy.EnableBlendModePreserveSpecularLighting,

                CullMode = materialProxy.CullMode,
                CullModeForward = materialProxy.CullModeForward,
                OpaqueCullMode = materialProxy.OpaqueCullMode,

                SrcBlend = materialProxy.SrcBlend,
                DstBlend = materialProxy.DstBlend,
                ZWrite = materialProxy.ZWrite,

                // Transparent
                TransparentCullMode = materialProxy.TransparentCullMode,
                EnableFogOnTransparent = materialProxy.EnableFogOnTransparent,
                TransparentSortPriority = materialProxy.TransparentSortPriority,
                TransparentBackfaceEnable = materialProxy.TransparentBackfaceEnable,
                TransparentDepthPrepassEnable = materialProxy.TransparentDepthPrepassEnable,
                TransparentDepthPostpassEnable = materialProxy.TransparentDepthPostpassEnable,
                TransparentWritingMotionVec = materialProxy.TransparentWritingMotionVec,
                TransparentZWrite = materialProxy.TransparentZWrite,

                ZTestDepthEqualForOpaque = materialProxy.ZTestDepthEqualForOpaque,
                ZTestTransparent = materialProxy.ZTestTransparent,

                // Alpha Clipping
                AlphaCutoffEnable = materialProxy.AlphaCutoffEnable,
                UseShadowThreshold = materialProxy.UseShadowThreshold,
                AlphaToMask = materialProxy.AlphaToMask,
                AlphaToMaskInspectorValue = materialProxy.AlphaToMaskInspectorValue,

                AlphaSrcBlend = materialProxy.AlphaSrcBlend,
                AlphaDstBlend = materialProxy.AlphaDstBlend,

                // Double Sided
                DoubleSidedEnable = materialProxy.DoubleSidedEnable,
                DoubleSidedNormalMode = materialProxy.DoubleSidedNormalMode,
                DoubleSidedConstants = materialProxy.DoubleSidedConstants,

                SupportDecals = materialProxy.SupportDecals,
                ReceivesSSR = materialProxy.ReceivesSSR,
                ReceivesSSRTransparent = materialProxy.ReceivesSSRTransparent,

                EmissiveColor = materialProxy.EmissiveColor,

                DepthOffsetEnable = materialProxy.DepthOffsetEnable,

                RequireSplitLighting = materialProxy.RequireSplitLighting,

                // Stencil
                StencilRef = materialProxy.StencilRef,
                StencilRefDepth = materialProxy.StencilRefDepth,
                StencilRefDistortionVec = materialProxy.StencilRefDistortionVec,
                StencilRefGBuffer = materialProxy.StencilRefGBuffer,
                StencilRefMV = materialProxy.StencilRefMV,
                StencilWriteMask = materialProxy.StencilWriteMask,
                StencilWriteMaskDepth = materialProxy.StencilWriteMaskDepth,
                StencilWriteMaskDistortionVec = materialProxy.StencilWriteMaskDistortionVec,
                StencilWriteMaskGBuffer = materialProxy.StencilWriteMaskGBuffer,
                StencilWriteMaskMV = materialProxy.StencilWriteMaskMV,

                ZTestGBuffer = materialProxy.ZTestGBuffer,

                // Exposed Properties

                // Base
                BaseColor = materialProxy.BaseColor,
                BaseColorMap = materialProxy.BaseColorMap,

                // Alpha
                Alpha = materialProxy.Alpha,
                AlphaClipThreshold = materialProxy.AlphaClipThreshold,
                AlphaClipThresholdDepthPrepass = materialProxy.AlphaClipThresholdDepthPrepass,
                AlphaClipThresholdDepthPostpass = materialProxy.AlphaClipThresholdDepthPostpass,
                AlphaThresholdShadow = materialProxy.AlphaThresholdShadow,

                // Base UV
                UVBaseST = materialProxy.UVBaseST,

                // Normal
                NormalMap = materialProxy.NormalMap,
                NormalScale = materialProxy.NormalScale,

                // Ambient Occulusion
                MaskMap = materialProxy.MaskMap,
                LightmapUV = materialProxy.LightmapUV,

                // Smoothness
                SmoothnessMask = materialProxy.SmoothnessMask,
                UVSmoothnessST = materialProxy.UVSmoothnessST,
                SmoothnessMin = materialProxy.SmoothnessMin,
                SmoothnessMax = materialProxy.SmoothnessMax,

                // Specular
                SpecularColor = materialProxy.SpecularColor,
                Specular = materialProxy.Specular,
                SpecularShift = materialProxy.SpecularShift,
                SecondarySpecular = materialProxy.SecondarySpecular,
                SecondarySpecularShift = materialProxy.SecondarySpecularShift,

                // Transmission
                TransmissionColor = materialProxy.TransmissionColor,
                TransmissionRim = materialProxy.TransmissionRim,
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        private static HdrpLitDefinition GetHdrpLitParametersFromMaterial(Material material)
        {
            var materialProxy = new HdrpLitMaterialProxy(material);

            return new HdrpLitDefinition
            {
                // Blending state

                // Surface Options
                SurfaceType = materialProxy.SurfaceType,
                BlendMode = materialProxy.BlendMode,
                RenderQueueType = materialProxy.RenderQueueType,

                SrcBlend = materialProxy.SrcBlend,
                DstBlend = materialProxy.DstBlend,
                AlphaSrcBlend = materialProxy.AlphaSrcBlend,
                AlphaDstBlend = materialProxy.AlphaDstBlend,

                AlphaToMask = materialProxy.AlphaToMask,
                AlphaToMaskInspectorValue = materialProxy.AlphaToMaskInspectorValue,

                ZWrite = materialProxy.ZWrite,
                TransparentZWrite = materialProxy.TransparentZWrite,

                CullMode = materialProxy.CullMode,
                CullModeForward = materialProxy.CullModeForward,
                TransparentCullMode = materialProxy.TransparentCullMode,
                OpaqueCullMode = materialProxy.OpaqueCullMode,

                ZTestDepthEqualForOpaque = materialProxy.ZTestDepthEqualForOpaque,
                ZTestModeDistortion = materialProxy.ZTestModeDistortion,
                ZTestTransparent = materialProxy.ZTestTransparent,

                EnableFogOnTransparent = materialProxy.EnableFogOnTransparent,
                EnableBlendModePreserveSpecularLighting = materialProxy.EnableBlendModePreserveSpecularLighting,

                // Double Sided
                DoubleSidedEnable = materialProxy.DoubleSidedEnable,
                DoubleSidedNormalMode = materialProxy.DoubleSidedNormalMode,
                DoubleSidedConstants = materialProxy.DoubleSidedConstants,

                MainTex = materialProxy.MainTex,
                Color = materialProxy.Color,
                Cutoff = materialProxy.Cutoff,

                // Base Map
                BaseColor = materialProxy.BaseColor,
                BaseColorMap = materialProxy.BaseColorMap,
                BaseColorMapMipInfo = materialProxy.BaseColorMapMipInfo,

                // Metallic Gloss Map
                Metallic = materialProxy.Metallic,
                Smoothness = materialProxy.Smoothness,
                MetallicRemapMin = materialProxy.MetallicRemapMin,
                MetallicRemapMax = materialProxy.MetallicRemapMax,
                SmoothnessRemapMin = materialProxy.SmoothnessRemapMin,
                SmoothnessRemapMax = materialProxy.SmoothnessRemapMax,

                // Ambient Occulusion
                MaskMap = materialProxy.MaskMap,
                AORemapMin = materialProxy.AORemapMin,
                AORemapMax = materialProxy.AORemapMax,

                // Normal Map
                NormalMap = materialProxy.NormalMap,
                NormalMapOS = materialProxy.NormalMapOS,
                NormalScale = materialProxy.NormalScale,

                // Bent Normal Map
                BentNormalMap = materialProxy.BentNormalMap,
                BentNormalMapOS = materialProxy.BentNormalMapOS,

                // Height Map
                HeightMap = materialProxy.HeightMap,
                HeightAmplitude = materialProxy.HeightAmplitude,
                HeightCenter = materialProxy.HeightCenter,

                HeightMapParametrization = materialProxy.HeightMapParametrization,

                HeightOffset = materialProxy.HeightOffset,
                HeightMin = materialProxy.HeightMin,
                HeightMax = materialProxy.HeightMax,
                HeightTessAmplitude = materialProxy.HeightTessAmplitude,
                HeightTessCenter = materialProxy.HeightTessCenter,

                HeightPoMAmplitude = materialProxy.HeightPoMAmplitude,

                // Detail Map
                DetailMap = materialProxy.DetailMap,
                DetailAlbedoScale = materialProxy.DetailAlbedoScale,
                DetailNormalScale = materialProxy.DetailNormalScale,
                DetailSmoothnessScale = materialProxy.DetailSmoothnessScale,

                // Tangent Map
                TangentMap = materialProxy.TangentMap,
                TangentMapOS = materialProxy.TangentMapOS,

                // Anisotropy Map
                Anisotropy = materialProxy.Anisotropy,
                AnisotropyMap = materialProxy.AnisotropyMap,

                // Subsurface Mask Map
                SubsurfaceMask = materialProxy.SubsurfaceMask,
                SubsurfaceMaskMap = materialProxy.SubsurfaceMaskMap,

                // Thickness Map
                Thickness = materialProxy.Thickness,
                ThicknessMap = materialProxy.ThicknessMap,
                ThicknessRemap = materialProxy.ThicknessRemap,

                // Iridescence Thickness Map
                IridescenceThickness = materialProxy.IridescenceThickness,
                IridescenceThicknessMap = materialProxy.IridescenceThicknessMap,
                IridescenceThicknessRemap = materialProxy.IridescenceThicknessRemap,

                // Iridescence Mask Map
                IridescenceMask = materialProxy.IridescenceMask,
                IridescenceMaskMap = materialProxy.IridescenceMaskMap,

                // Coat Mask Map
                CoatMask = materialProxy.CoatMask,
                CoatMaskMap = materialProxy.CoatMaskMap,

                // Specular Color Map
                EnergyConservingSpecularColor = materialProxy.EnergyConservingSpecularColor,
                SpecularColor = materialProxy.SpecularColor,
                SpecularColorMap = materialProxy.SpecularColorMap,
                SpecularOcclusionMode = materialProxy.SpecularOcclusionMode,

                // Specular AA
                EnableGeometricSpecularAA = materialProxy.EnableGeometricSpecularAA,
                SpecularAAScreenSpaceVariance = materialProxy.SpecularAAScreenSpaceVariance,
                SpecularAAThreshold = materialProxy.SpecularAAThreshold,

                PPDMinSamples = materialProxy.PPDMinSamples,
                PPDMaxSamples = materialProxy.PPDMaxSamples,
                PPDLodThreshold = materialProxy.PPDLodThreshold,
                PPDPrimitiveLength = materialProxy.PPDPrimitiveLength,
                PPDPrimitiveWidth = materialProxy.PPDPrimitiveWidth,
                InvPrimScale = materialProxy.InvPrimScale,

                UVDetail = materialProxy.UVDetail,
                UVDetailsMappingMask = materialProxy.UVDetailsMappingMask,
                LinkDetailsWithBase = materialProxy.LinkDetailsWithBase,

                // Emissive Color Map

                EmissiveColorMode = materialProxy.EmissiveColorMode,
                EmissiveColor = materialProxy.EmissiveColor,
                EmissionColor = materialProxy.EmissionColor,
                EmissiveColorLDR = materialProxy.EmissiveColorLDR,
                EmissiveColorMap = materialProxy.EmissiveColorMap,

                UVEmissive = materialProxy.UVEmissive,
                TexWorldScaleEmissive = materialProxy.TexWorldScaleEmissive,
                UVMappingMaskEmissive = materialProxy.UVMappingMaskEmissive,

                AlbedoAffectEmissive = materialProxy.AlbedoAffectEmissive,
                EmissiveIntensityUnit = materialProxy.EmissiveIntensityUnit,
                UseEmissiveIntensity = materialProxy.UseEmissiveIntensity,
                EmissiveIntensity = materialProxy.EmissiveIntensity,
                EmissiveExposureWeight = materialProxy.EmissiveExposureWeight,

                // Distortion Vector Map
                DistortionVectorMap = materialProxy.DistortionVectorMap,
                DistortionEnable = materialProxy.DistortionEnable,
                DistortionDepthTest = materialProxy.DistortionDepthTest,
                DistortionBlendMode = materialProxy.DistortionBlendMode,
                DistortionSrcBlend = materialProxy.DistortionSrcBlend,
                DistortionDstBlend = materialProxy.DistortionDstBlend,
                DistortionBlurSrcBlend = materialProxy.DistortionBlurSrcBlend,
                DistortionBlurDstBlend = materialProxy.DistortionBlurDstBlend,
                DistortionBlurBlendOp = materialProxy.DistortionBlurBlendOp,
                DistortionScale = materialProxy.DistortionScale,
                DistortionVectorScale = materialProxy.DistortionVectorScale,
                DistortionVectorBias = materialProxy.DistortionVectorBias,
                DistortionBlurScale = materialProxy.DistortionBlurScale,
                DistortionBlurRemapMin = materialProxy.DistortionBlurRemapMin,
                DistortionBlurRemapMax = materialProxy.DistortionBlurRemapMax,

                UseShadowThreshold = materialProxy.UseShadowThreshold,

                // Alpha Clipping
                AlphaCutoffEnable = materialProxy.AlphaCutoffEnable,
                AlphaCutoff = materialProxy.AlphaCutoff,
                AlphaCutoffShadow = materialProxy.AlphaCutoffShadow,
                AlphaCutoffPrepass = materialProxy.AlphaCutoffPrepass,
                AlphaCutoffPostpass = materialProxy.AlphaCutoffPostpass,

                // Transparent
                TransparentSortPriority = materialProxy.TransparentSortPriority,
                TransparentBackfaceEnable = materialProxy.TransparentBackfaceEnable,
                TransparentDepthPrepassEnable = materialProxy.TransparentDepthPrepassEnable,
                TransparentDepthPostpassEnable = materialProxy.TransparentDepthPostpassEnable,
                TransparentWritingMotionVec = materialProxy.TransparentWritingMotionVec,

                // Transparency
                RefractionModel = materialProxy.RefractionModel,
                Ior = materialProxy.Ior,
                TransmittanceColor = materialProxy.TransmittanceColor,
                TransmittanceColorMap = materialProxy.TransmittanceColorMap,
                ATDistance = materialProxy.ATDistance,

                UVBase = materialProxy.UVBase,
                TexWorldScale = materialProxy.TexWorldScale,
                InvTilingScale = materialProxy.InvTilingScale,
                UVMappingMask = materialProxy.UVMappingMask,
                NormalMapSpace = materialProxy.NormalMapSpace,

                MaterialID = materialProxy.MaterialID,
                TransmissionEnable = materialProxy.TransmissionEnable,

                DisplacementMode = materialProxy.DisplacementMode,
                DisplacementLockObjectScale = materialProxy.DisplacementLockObjectScale,
                DisplacementLockTilingScale = materialProxy.DisplacementLockTilingScale,

                DepthOffsetEnable = materialProxy.DepthOffsetEnable,

                RequireSplitLighting = materialProxy.RequireSplitLighting,

                // Stencil state

                // Forward
                StencilRef = materialProxy.StencilRef,
                StencilWriteMask = materialProxy.StencilWriteMask,

                // GBuffer
                StencilRefGBuffer = materialProxy.StencilRefGBuffer,
                StencilWriteMaskGBuffer = materialProxy.StencilWriteMaskGBuffer,

                // Depth prepass
                StencilRefDepth = materialProxy.StencilRefDepth,
                StencilWriteMaskDepth = materialProxy.StencilWriteMaskDepth,

                // Motion vector pass
                StencilRefMV = materialProxy.StencilRefMV,
                StencilWriteMaskMV = materialProxy.StencilWriteMaskMV,

                // Distortion vector pass
                StencilRefDistortionVec = materialProxy.StencilRefDistortionVec,
                StencilWriteMaskDistortionVec = materialProxy.StencilWriteMaskDistortionVec,

                ZTestGBuffer = materialProxy.ZTestGBuffer,

                SupportDecals = materialProxy.SupportDecals,
                ReceivesSSR = materialProxy.ReceivesSSR,
                ReceivesSSRTransparent = materialProxy.ReceivesSSRTransparent,
                AddPrecomputedVelocity = materialProxy.AddPrecomputedVelocity,

                RayTracing = materialProxy.RayTracing,

                //DiffusionProfile = materialProxy.DiffusionProfile,
                DiffusionProfileAsset = materialProxy.DiffusionProfileAsset,
                DiffusionProfileHash = materialProxy.DiffusionProfileHash,

                //UnityLightmaps = materialProxy.UnityLightmaps,
                //UnityLightmapsInd = materialProxy.UnityLightmapsInd,
                //UnityShadowMasks = materialProxy.UnityShadowMasks,
            };
        }
    }
}