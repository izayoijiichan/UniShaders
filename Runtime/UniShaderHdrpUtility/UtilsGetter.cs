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
            return new HdrpEyeDefinition
            {
                // Surface Options
                SurfaceType = GetEnum<SurfaceType>(material, Property.SurfaceType, SurfaceType.Opaque),
                RenderQueueType = GetEnum<RenderQueueType>(material, Property.RenderQueueType, RenderQueueType.Default),
                BlendMode = GetEnum<BlendMode>(material, Property.BlendMode, BlendMode.Alpha),
                EnableBlendModePreserveSpecularLighting = GetBool(material, Property.EnableBlendModePreserveSpecularLighting),
                CullMode = GetEnum<CullMode>(material, Property.CullMode, CullMode.Back),
                CullModeForward = GetEnum<CullMode>(material, Property.DistortionBlendMode, CullMode.Back),
                OpaqueCullMode = GetEnum<OpaqueCullMode>(material, Property.OpaqueCullMode, OpaqueCullMode.Back),

                SrcBlend = GetFloat(material, Property.SrcBlend),
                DstBlend = GetFloat(material, Property.DstBlend),
                ZWrite = GetBool(material, Property.ZWrite),

                // Transparent
                TransparentCullMode = GetEnum<TransparentCullMode>(material, Property.TransparentCullMode, TransparentCullMode.Back),
                EnableFogOnTransparent = GetBool(material, Property.EnableFogOnTransparent),
                TransparentSortPriority = GetFloat(material, Property.TransparentSortPriority),
                TransparentBackfaceEnable = GetBool(material, Property.TransparentBackfaceEnable),
                TransparentDepthPrepassEnable = GetBool(material, Property.TransparentDepthPrepassEnable),
                TransparentDepthPostpassEnable = GetBool(material, Property.TransparentDepthPostpassEnable),
                TransparentWritingMotionVec = GetFloat(material, Property.TransparentWritingMotionVec),
                TransparentZWrite = GetBool(material, Property.TransparentZWrite),

                ZTestDepthEqualForOpaque = GetInt(material, Property.ZTestDepthEqualForOpaque),
                ZTestTransparent = GetInt(material, Property.ZTestTransparent),

                // Alpha Clipping
                AlphaCutoffEnable = GetBool(material, Property.AlphaCutoffEnable),
                UseShadowThreshold = GetBool(material, Property.UseShadowThreshold),
                AlphaToMask = GetBool(material, Property.AlphaToMask),
                AlphaToMaskInspectorValue = GetFloat(material, Property.AlphaToMaskInspectorValue),

                AlphaSrcBlend = GetFloat(material, Property.AlphaSrcBlend),
                AlphaDstBlend = GetFloat(material, Property.AlphaDstBlend),

                // Double Sided
                DoubleSidedEnable = GetBool(material, Property.DoubleSidedEnable),
                DoubleSidedNormalMode = GetEnum<DoubleSidedNormalMode>(material, Property.DoubleSidedNormalMode, DoubleSidedNormalMode.Mirror),
                DoubleSidedConstants = GetVector4(material, Property.DoubleSidedConstants),

                SupportDecals = GetBool(material, Property.SupportDecals),
                ReceivesSSR = GetBool(material, Property.ReceivesSSR),
                ReceivesSSRTransparent = GetBool(material, Property.ReceivesSSRTransparent),

                // Exposed Properties

                // Sclera
                Texture2D_5F873FC1 = GetTexture(material, Property.Texture2D_5F873FC1),
                Texture2D_B9F5688C = GetTexture(material, Property.Texture2D_B9F5688C),
                Vector1_70564D59 = GetFloat(material, Property.Vector1_70564D59),

                // Iris
                Texture2D_D8BF6575 = GetTexture(material, Property.Texture2D_D8BF6575),
                Texture2D_4DB28C10 = GetTexture(material, Property.Texture2D_4DB28C10),
                Vector1_FC0895C8 = GetFloat(material, Property.Vector1_FC0895C8),
                Color_83777D09 = GetColor(material, Property.Color_83777D09),

                // Pupil
                Vector1_DFF948F3 = GetFloat(material, Property.Vector1_DFF948F3),
                Boolean_8D34052F = GetBool(material, Property.Boolean_8D34052F),
                Vector1_FEA38ABB = GetFloat(material, Property.Vector1_FEA38ABB),
                Vector1_2D21A623 = GetFloat(material, Property.Vector1_2D21A623),
                Vector1_49C490F5 = GetFloat(material, Property.Vector1_49C490F5),

                Vector1_F084AE9E = GetFloat(material, Property.Vector1_F084AE9E),
                Vector1_8F0D1174 = GetFloat(material, Property.Vector1_8F0D1174),
                Vector1_76BF2124 = GetFloat(material, Property.Vector1_76BF2124),

                // Limbal Ring
                Vector1_C4ED1456 = GetFloat(material, Property.Vector1_C4ED1456),
                Vector1_94E1614A = GetFloat(material, Property.Vector1_94E1614A),
                Vector1_6C2C412D = GetFloat(material, Property.Vector1_6C2C412D),
                Vector1_A6DA845F = GetFloat(material, Property.Vector1_A6DA845F),

                // Iris Diffusion Profile
                DiffusionProfile_bfbe0deb8ec4428a9cfcdb968651903c = GetFloat(material, Property.DiffusionProfile_bfbe0deb8ec4428a9cfcdb968651903c),
                DiffusionProfile_bfbe0deb8ec4428a9cfcdb968651903c_Asset = GetVector4(material, Property.DiffusionProfile_bfbe0deb8ec4428a9cfcdb968651903c_Asset),

                // Sclera Diffusion Profile
                DiffusionProfile_261f48f1fbc94ccbafc421414859c159 = GetFloat(material, Property.DiffusionProfile_261f48f1fbc94ccbafc421414859c159),
                DiffusionProfile_261f48f1fbc94ccbafc421414859c159_Asset = GetVector4(material, Property.DiffusionProfile_261f48f1fbc94ccbafc421414859c159_Asset),
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        private static HdrpHairDefinition GetHdrpHairParametersFromMaterial(Material material)
        {
            return new HdrpHairDefinition
            {
                // Surface Options
                SurfaceType = GetEnum<SurfaceType>(material, Property.SurfaceType, SurfaceType.Opaque),
                RenderQueueType = GetEnum<RenderQueueType>(material, Property.RenderQueueType, RenderQueueType.Default),
                BlendMode = GetEnum<BlendMode>(material, Property.BlendMode, BlendMode.Alpha),
                EnableBlendModePreserveSpecularLighting = GetBool(material, Property.EnableBlendModePreserveSpecularLighting),
                CullMode = GetEnum<CullMode>(material, Property.CullMode, CullMode.Back),
                CullModeForward = GetEnum<CullMode>(material, Property.DistortionBlendMode, CullMode.Back),
                OpaqueCullMode = GetEnum<OpaqueCullMode>(material, Property.OpaqueCullMode, OpaqueCullMode.Back),

                SrcBlend = GetFloat(material, Property.SrcBlend),
                DstBlend = GetFloat(material, Property.DstBlend),
                ZWrite = GetBool(material, Property.ZWrite),

                // Transparent
                TransparentCullMode = GetEnum<TransparentCullMode>(material, Property.TransparentCullMode, TransparentCullMode.Back),
                EnableFogOnTransparent = GetBool(material, Property.EnableFogOnTransparent),
                TransparentSortPriority = GetFloat(material, Property.TransparentSortPriority),
                TransparentBackfaceEnable = GetBool(material, Property.TransparentBackfaceEnable),
                TransparentDepthPrepassEnable = GetBool(material, Property.TransparentDepthPrepassEnable),
                TransparentDepthPostpassEnable = GetBool(material, Property.TransparentDepthPostpassEnable),
                TransparentWritingMotionVec = GetFloat(material, Property.TransparentWritingMotionVec),
                TransparentZWrite = GetBool(material, Property.TransparentZWrite),

                ZTestDepthEqualForOpaque = GetInt(material, Property.ZTestDepthEqualForOpaque),
                ZTestTransparent = GetInt(material, Property.ZTestTransparent),

                // Alpha Clipping
                AlphaCutoffEnable = GetBool(material, Property.AlphaCutoffEnable),
                UseShadowThreshold = GetBool(material, Property.UseShadowThreshold),
                AlphaToMask = GetBool(material, Property.AlphaToMask),
                AlphaToMaskInspectorValue = GetFloat(material, Property.AlphaToMaskInspectorValue),

                AlphaSrcBlend = GetFloat(material, Property.AlphaSrcBlend),
                AlphaDstBlend = GetFloat(material, Property.AlphaDstBlend),

                // Double Sided
                DoubleSidedEnable = GetBool(material, Property.DoubleSidedEnable),
                DoubleSidedNormalMode = GetEnum<DoubleSidedNormalMode>(material, Property.DoubleSidedNormalMode, DoubleSidedNormalMode.Mirror),
                DoubleSidedConstants = GetVector4(material, Property.DoubleSidedConstants),

                SupportDecals = GetBool(material, Property.SupportDecals),
                ReceivesSSR = GetBool(material, Property.ReceivesSSR),
                ReceivesSSRTransparent = GetBool(material, Property.ReceivesSSRTransparent),

                // Exposed Properties

                // Base
                BaseColor = GetColor(material, Property.BaseColor),
                BaseColorMap = GetTexture(material, Property.BaseColorMap),

                // Alpha
                Alpha = GetBool(material, Property.Alpha),
                AlphaClipThreshold = GetFloat(material, Property.AlphaClipThreshold),
                AlphaClipThresholdDepthPrepass = GetFloat(material, Property.AlphaClipThresholdDepthPrepass),
                AlphaClipThresholdDepthPostpass = GetFloat(material, Property.AlphaClipThresholdDepthPostpass),
                AlphaThresholdShadow = GetFloat(material, Property.AlphaThresholdShadow),

                // Base UV
                UVBaseST = GetVector4(material, Property.UVBaseST),

                // Normal
                NormalMap = GetTexture(material, Property.NormalMap),
                NormalScale = GetFloat(material, Property.NormalScale),

                // Ambient Occulusion
                MaskMap = GetTexture(material, Property.MaskMap),
                LightmapUV = GetBool(material, Property.LightmapUV),

                // Smoothness
                SmoothnessMask = GetTexture(material, Property.SmoothnessMask),
                UVSmoothnessST = GetVector4(material, Property.UVSmoothnessST),
                SmoothnessMin = GetFloat(material, Property.SmoothnessMin),
                SmoothnessMax = GetFloat(material, Property.SmoothnessMax),

                // Specular
                SpecularColor = GetColor(material, Property.SpecularColor),
                Specular = GetFloat(material, Property.Specular),
                SpecularShift = GetFloat(material, Property.SpecularShift),
                SecondarySpecular = GetFloat(material, Property.SecondarySpecular),
                SecondarySpecularShift = GetFloat(material, Property.SecondarySpecularShift),

                // Transmission
                TransmissionColor = GetColor(material, Property.TransmissionColor),
                TransmissionRim = GetFloat(material, Property.TransmissionRim),
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
            private static HdrpLitDefinition GetHdrpLitParametersFromMaterial(Material material)
        {
            return new HdrpLitDefinition
            {
                // Base Map
                BaseColor = GetColor(material, Property.Color),
                BaseColorMap = GetTexture(material, Property.BaseColorMap),
                BaseColorMapMipInfo = GetVector4(material, Property.BaseColorMapMipInfo),

                // Metallic Gloss Map
                Metallic = GetFloat(material, Property.Metallic),
                Smoothness = GetFloat(material, Property.Smoothness),
                MaskMap = GetTexture(material, Property.MaskMap),
                MetallicRemapMin = GetFloat(material, Property.MetallicRemapMin),
                MetallicRemapMax = GetFloat(material, Property.MetallicRemapMax),
                SmoothnessRemapMin = GetFloat(material, Property.SmoothnessRemapMin),
                SmoothnessRemapMax = GetFloat(material, Property.SmoothnessRemapMax),
                AORemapMin = GetFloat(material, Property.AORemapMin),
                AORemapMax = GetFloat(material, Property.AORemapMax),

                // Normal Map
                NormalMap = GetTexture(material, Property.NormalMap),
                NormalMapOS = GetTexture(material, Property.NormalMapOS),
                NormalScale = GetFloat(material, Property.NormalScale),

                // Bent Normal Map
                BentNormalMap = GetTexture(material, Property.BentNormalMap),
                BentNormalMapOS = GetTexture(material, Property.BentNormalMapOS),

                // Height Map
                HeightMap = GetTexture(material, Property.HeightMap),
                HeightAmplitude = GetFloat(material, Property.HeightAmplitude),
                HeightCenter = GetFloat(material, Property.HeightCenter),

                HeightMapParametrization = GetEnum<HeightmapParametrization>(material, Property.HeightMapParametrization, HeightmapParametrization.MinMax),

                HeightOffset = GetFloat(material, Property.HeightOffset),
                HeightMin = GetFloat(material, Property.HeightMin),
                HeightMax = GetFloat(material, Property.HeightMax),
                HeightTessAmplitude = GetFloat(material, Property.HeightTessAmplitude),
                HeightTessCenter = GetFloat(material, Property.HeightTessCenter),

                HeightPoMAmplitude = GetFloat(material, Property.HeightPoMAmplitude),

                // Detail Map
                DetailMap = GetTexture(material, Property.DetailMap),
                DetailAlbedoScale = GetFloat(material, Property.DetailAlbedoScale),
                DetailNormalScale = GetFloat(material, Property.DetailNormalScale),
                DetailSmoothnessScale = GetFloat(material, Property.DetailSmoothnessScale),

                // Tangent Map
                TangentMap = GetTexture(material, Property.TangentMap),
                TangentMapOS = GetTexture(material, Property.TangentMapOS),

                // Anisotropy Map
                Anisotropy = GetFloat(material, Property.Anisotropy),
                AnisotropyMap = GetTexture(material, Property.AnisotropyMap),

                // Subsurface Mask Map
                SubsurfaceMask = GetFloat(material, Property.SubsurfaceMask),
                SubsurfaceMaskMap = GetTexture(material, Property.SubsurfaceMaskMap),

                // Thickness Map
                Thickness = GetFloat(material, Property.Thickness),
                ThicknessMap = GetTexture(material, Property.ThicknessMap),
                ThicknessRemap = GetVector4(material, Property.ThicknessRemap),

                // Iridescence Thickness Map
                IridescenceThickness = GetFloat(material, Property.IridescenceThickness),
                IridescenceThicknessMap = GetTexture(material, Property.IridescenceThicknessMap),
                IridescenceThicknessRemap = GetVector4(material, Property.IridescenceThicknessRemap),

                // Iridescence Mask Map
                IridescenceMask = GetFloat(material, Property.IridescenceMask),
                IridescenceMaskMap = GetTexture(material, Property.IridescenceMaskMap),

                // Coat Mask Map
                CoatMask = GetFloat(material, Property.CoatMask),
                CoatMaskMap = GetTexture(material, Property.CoatMaskMap),

                // Specular Color Map
                EnergyConservingSpecularColor = GetFloat(material, Property.CoatMask),
                SpecularColor = GetColor(material, Property.SpecularColor),
                SpecularColorMap = GetTexture(material, Property.SpecularColorMap),
                SpecularOcclusionMode = GetEnum<SpecularOcclusionMode>(material, Property.SpecularOcclusionMode, SpecularOcclusionMode.FromAmbientOcclusion),

                // Emissive Color Map
                EmissiveColor = GetColor(material, Property.EmissiveColor),
                EmissiveColorLDR = GetColor(material, Property.EmissiveColorLDR),
                EmissiveColorMap = GetTexture(material, Property.EmissiveColorMap),

                AlbedoAffectEmissive = GetFloat(material, Property.AlbedoAffectEmissive),
                EmissiveIntensityUnit = GetInt(material, Property.EmissiveIntensityUnit),
                UseEmissiveIntensity = GetBool(material, Property.UseEmissiveIntensity),
                EmissiveIntensity = GetFloat(material, Property.EmissiveIntensity),
                EmissiveExposureWeight = GetFloat(material, Property.EmissiveExposureWeight),

                // Distortion Vector Map
                DistortionVectorMap = GetTexture(material, Property.DistortionVectorMap),
                DistortionEnable = GetBool(material, Property.DistortionEnable),
                DistortionDepthTest = GetBool(material, Property.DistortionDepthTest),
                DistortionBlendMode = GetEnum<DistortionBlendMode>(material, Property.DistortionBlendMode, DistortionBlendMode.Add),
                DistortionSrcBlend = GetInt(material, Property.DistortionSrcBlend),
                DistortionDstBlend = GetInt(material, Property.DistortionDstBlend),
                DistortionBlurSrcBlend = GetInt(material, Property.DistortionBlurSrcBlend),
                DistortionBlurDstBlend = GetInt(material, Property.DistortionBlurDstBlend),
                DistortionBlurBlendMode = GetInt(material, Property.DistortionBlurBlendMode),
                DistortionScale = GetFloat(material, Property.DistortionScale),
                DistortionVectorScale = GetFloat(material, Property.DistortionVectorScale),
                DistortionVectorBias = GetFloat(material, Property.DistortionVectorBias),
                DistortionBlurScale = GetFloat(material, Property.DistortionBlurScale),
                DistortionBlurRemapMin = GetFloat(material, Property.DistortionBlurRemapMin),
                DistortionBlurRemapMax = GetFloat(material, Property.DistortionBlurRemapMax),

                AlphaCutoffEnable = GetBool(material, Property.AlphaCutoffEnable),
                AlphaCutoff = GetFloat(material, Property.AlphaCutoff),
                UseShadowThreshold = GetBool(material, Property.UseShadowThreshold),
                AlphaCutoffShadow = GetFloat(material, Property.AlphaCutoffShadow),
                AlphaCutoffPrepass = GetFloat(material, Property.AlphaCutoffPrepass),
                AlphaCutoffPostpass = GetFloat(material, Property.AlphaCutoffPostpass),

                TransparentBackfaceEnable = GetBool(material, Property.TransparentBackfaceEnable),
                TransparentDepthPrepassEnable = GetBool(material, Property.TransparentDepthPrepassEnable),
                TransparentDepthPostpassEnable = GetBool(material, Property.TransparentDepthPostpassEnable),
                TransparentSortPriority = GetFloat(material, Property.TransparentSortPriority),

                // Transparency
                RefractionModel = GetEnum<RefractionModel>(material, Property.RefractionModel, RefractionModel.None),
                Ior = GetFloat(material, Property.Ior),
                TransmittanceColor = GetColor(material, Property.TransmittanceColor),
                TransmittanceColorMap = GetTexture(material, Property.TransmittanceColorMap),
                ATDistance = GetFloat(material, Property.ATDistance),
                TransparentWritingMotionVec = GetFloat(material, Property.TransparentWritingMotionVec),

                // Stencil state

                // Forward
                StencilRef = GetInt(material, Property.StencilRef),
                StencilWriteMask = GetInt(material, Property.StencilWriteMask),
                // GBuffer
                StencilRefGBuffer = GetInt(material, Property.StencilRefGBuffer),
                StencilWriteMaskGBuffer = GetInt(material, Property.StencilWriteMaskGBuffer),
                // Depth prepass
                StencilRefDepth = GetInt(material, Property.StencilRefDepth),
                StencilWriteMaskDepth = GetInt(material, Property.StencilWriteMaskDepth),
                // Motion vector pass
                StencilRefMV = GetInt(material, Property.StencilRefMV),
                StencilWriteMaskMV = GetInt(material, Property.StencilWriteMaskMV),
                // Distortion vector pass
                StencilRefDistortionVec = GetInt(material, Property.StencilRefDistortionVec),
                StencilWriteMaskDistortionVec = GetInt(material, Property.StencilWriteMaskDistortionVec),

                // Blending state
                SurfaceType = GetEnum<SurfaceType>(material, Property.SurfaceType, SurfaceType.Opaque),
                RenderQueueType = GetEnum<RenderQueueType>(material, Property.RenderQueueType, RenderQueueType.Default),  // @notice
                BlendMode = GetEnum<BlendMode>(material, Property.BlendMode, BlendMode.Alpha),
                SrcBlend = GetFloat(material, Property.SrcBlend),
                DstBlend = GetFloat(material, Property.DstBlend),
                AlphaSrcBlend = GetFloat(material, Property.AlphaSrcBlend),
                AlphaDstBlend = GetFloat(material, Property.AlphaDstBlend),
                AlphaToMaskInspectorValue = GetFloat(material, Property.AlphaToMaskInspectorValue),
                AlphaToMask = GetBool(material, Property.AlphaToMask),
                ZWrite = GetBool(material, Property.ZWrite),
                TransparentZWrite = GetBool(material, Property.TransparentZWrite),
                CullMode = GetEnum<CullMode>(material, Property.CullMode, CullMode.Back),
                CullModeForward = GetEnum<CullMode>(material, Property.DistortionBlendMode, CullMode.Back),
                TransparentCullMode = GetEnum<TransparentCullMode>(material, Property.TransparentCullMode, TransparentCullMode.Back),
                OpaqueCullMode = GetEnum<OpaqueCullMode>(material, Property.OpaqueCullMode, OpaqueCullMode.Back),
                ZTestDepthEqualForOpaque = GetInt(material, Property.ZTestDepthEqualForOpaque),
                ZTestModeDistortion = GetInt(material, Property.ZTestModeDistortion),
                ZTestTransparent = GetInt(material, Property.ZTestTransparent),

                EnableFogOnTransparent = GetBool(material, Property.EnableFogOnTransparent),
                EnableBlendModePreserveSpecularLighting = GetBool(material, Property.EnableBlendModePreserveSpecularLighting),

                // Double Sided
                DoubleSidedEnable = GetBool(material, Property.DoubleSidedEnable),
                DoubleSidedNormalMode = GetEnum<DoubleSidedNormalMode>(material, Property.DoubleSidedNormalMode, DoubleSidedNormalMode.Mirror),
                DoubleSidedConstants = GetVector4(material, Property.DoubleSidedConstants),

                UVBase = GetEnum<UVBaseMapping>(material, Property.UVBase, UVBaseMapping.UV0),
                TexWorldScale = GetFloat(material, Property.TexWorldScale),
                InvTilingScale = GetFloat(material, Property.InvTilingScale),
                UVMappingMask = GetColor(material, Property.UVMappingMask),
                NormalMapSpace = GetEnum<NormalMapSpace>(material, Property.NormalMapSpace, NormalMapSpace.TangentSpace),

                MaterialID = GetEnum<MaterialId>(material, Property.MaterialID, MaterialId.LitStandard),
                TransmissionEnable = GetBool(material, Property.TransmissionEnable),

                DisplacementMode = GetEnum<DisplacementMode>(material, Property.DisplacementMode, DisplacementMode.None),
                DisplacementLockObjectScale = GetFloat(material, Property.DisplacementLockObjectScale),
                DisplacementLockTilingScale = GetFloat(material, Property.DisplacementLockTilingScale),
                DepthOffsetEnable = GetBool(material, Property.DepthOffsetEnable),

                // Specular AA
                EnableGeometricSpecularAA = GetBool(material, Property.EnableGeometricSpecularAA),
                SpecularAAScreenSpaceVariance = GetFloat(material, Property.SpecularAAScreenSpaceVariance),
                SpecularAAThreshold = GetFloat(material, Property.SpecularAAThreshold),

                PPDMinSamples = GetFloat(material, Property.PPDMinSamples),
                PPDMaxSamples = GetFloat(material, Property.PPDMaxSamples),
                PPDLodThreshold = GetFloat(material, Property.PPDLodThreshold),
                PPDPrimitiveLength = GetFloat(material, Property.PPDPrimitiveLength),
                PPDPrimitiveWidth = GetFloat(material, Property.PPDPrimitiveWidth),
                InvPrimScale = GetVector4(material, Property.InvPrimScale),

                UVDetail = GetEnum<UVDetailMapping>(material, Property.UVDetail, UVDetailMapping.UV0),
                UVDetailsMappingMask = GetVector4(material, Property.UVDetailsMappingMask),
                LinkDetailsWithBase = GetBool(material, Property.LinkDetailsWithBase),

                EmissiveColorMode = GetEnum<EmissiveColorMode>(material, Property.EmissiveColorMode, EmissiveColorMode.UseEmissiveMask),
                UVEmissive = GetEnum<UVEmissiveMapping>(material, Property.UVEmissive, UVEmissiveMapping.UV0),
                TexWorldScaleEmissive = GetFloat(material, Property.TexWorldScaleEmissive),
                UVMappingMaskEmissive = GetColor(material, Property.UVMappingMaskEmissive),

                EmissionColor = GetColor(material, Property.EmissionColor),

                MainTex = GetTexture(material, Property.MainTex),
                Color = GetColor(material, Property.Color),
                Cutoff = GetFloat(material, Property.Cutoff),

                SupportDecals = GetBool(material, Property.SupportDecals),
                ReceivesSSR = GetBool(material, Property.ReceivesSSR),
                ReceivesSSRTransparent = GetBool(material, Property.ReceivesSSRTransparent),
                AddPrecomputedVelocity = GetBool(material, Property.AddPrecomputedVelocity),

                RayTracing = GetBool(material, Property.RayTracing),

                //DiffusionProfile = GetInt(material, Property.DiffusionProfile),
                DiffusionProfileAsset = GetVector4(material, Property.DiffusionProfileAsset),
                DiffusionProfileHash = GetFloat(material, Property.DiffusionProfileHash),

                //UnityLightmaps = GetTexture2DArray(material, Property.UnityLightmaps),
                //UnityLightmapsInd = GetTexture2DArray(material, Property.UnityLightmapsInd),
                //UnityShadowMasks = GetTexture2DArray(material, Property.UnityShadowMasks),
            };
        }

        /// <summary>
        /// Gets bool value.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        private static bool GetBool(Material material, string propertyName)
        {
            if (material.HasProperty(propertyName))
            {
                return material.GetInt(propertyName) == 1;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Gets color value.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        private static Color GetColor(Material material, string propertyName)
        {
            if (material.HasProperty(propertyName))
            {
                return material.GetColor(propertyName);
            }
            else
            {
                return default;
            }
        }

        /// <summary>
        /// Gets enum value.
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        private static TEnum GetEnum<TEnum>(Material material, string propertyName, TEnum? defaultValue = null) where TEnum : struct
        {
            int propertyValue = GetInt(material, propertyName);

            if (Enum.TryParse(propertyValue.ToString(), out TEnum result))
            {
                return result;
            }
            else if (defaultValue.HasValue)
            {
                return defaultValue.Value;
            }
            else
            {
                return default;
            }
        }

        /// <summary>
        /// Gets float value.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        private static float GetFloat(Material material, string propertyName)
        {
            if (material.HasProperty(propertyName))
            {
                return material.GetFloat(propertyName);
            }
            else
            {
                return 0.0f;
            }
        }

        /// <summary>
        /// Gets int value.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        private static int GetInt(Material material, string propertyName)
        {
            if (material.HasProperty(propertyName))
            {
                return material.GetInt(propertyName);
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Gets the Texture.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        private static Texture2D GetTexture(Material material, string propertyName)
        {
            if (material.HasProperty(propertyName))
            {
                return (Texture2D)material.GetTexture(propertyName);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Gets the Vector4.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        private static Vector4 GetVector4(Material material, string propertyName)
        {
            if (material.HasProperty(propertyName))
            {
                return material.GetVector(propertyName);
            }
            else
            {
                return default;
            }
        }
    }
}