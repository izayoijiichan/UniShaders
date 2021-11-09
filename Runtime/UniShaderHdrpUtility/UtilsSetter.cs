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
        public static void SetParametersToMaterial<T>(Material material, T parameters)
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
        private static void SetHdrpEyeParametersToMaterial(Material material, HdrpEyeDefinition parameters)
        {
            // Surface Options
            SetInt(material, Property.SurfaceType, (int)parameters.SurfaceType);
            SetInt(material, Property.RenderQueueType, (int)parameters.RenderQueueType);
            SetInt(material, Property.BlendMode, (int)parameters.BlendMode);
            SetBool(material, Property.EnableBlendModePreserveSpecularLighting, parameters.EnableBlendModePreserveSpecularLighting);

            SetInt(material, Property.CullMode, (int)parameters.CullMode);
            SetInt(material, Property.CullModeForward, (int)parameters.CullModeForward);
            SetInt(material, Property.OpaqueCullMode, (int)parameters.OpaqueCullMode);

            SetFloat(material, Property.SrcBlend, parameters.SrcBlend);
            SetFloat(material, Property.DstBlend, parameters.DstBlend);
            SetBool(material, Property.ZWrite, parameters.ZWrite);

            // Transparent
            SetInt(material, Property.TransparentCullMode, (int)parameters.TransparentCullMode);
            SetBool(material, Property.EnableFogOnTransparent, parameters.EnableFogOnTransparent);
            SetFloat(material, Property.TransparentSortPriority, parameters.TransparentSortPriority);
            SetBool(material, Property.TransparentBackfaceEnable, parameters.TransparentBackfaceEnable);
            SetBool(material, Property.TransparentDepthPrepassEnable, parameters.TransparentDepthPrepassEnable);
            SetBool(material, Property.TransparentDepthPostpassEnable, parameters.TransparentDepthPostpassEnable);
            SetFloat(material, Property.TransparentWritingMotionVec, parameters.TransparentWritingMotionVec);
            SetBool(material, Property.TransparentZWrite, parameters.TransparentZWrite);

            SetInt(material, Property.ZTestDepthEqualForOpaque, parameters.ZTestDepthEqualForOpaque);
            SetInt(material, Property.ZTestTransparent, parameters.ZTestTransparent);

            // Alpha Clipping
            SetBool(material, Property.AlphaCutoffEnable, parameters.AlphaCutoffEnable);
            SetBool(material, Property.UseShadowThreshold, parameters.UseShadowThreshold);
            SetBool(material, Property.AlphaToMask, parameters.AlphaToMask);
            SetFloat(material, Property.AlphaToMaskInspectorValue, parameters.AlphaToMaskInspectorValue);

            SetFloat(material, Property.AlphaSrcBlend, parameters.AlphaSrcBlend);
            SetFloat(material, Property.AlphaDstBlend, parameters.AlphaDstBlend);

            // Double Sided
            SetBool(material, Property.DoubleSidedEnable, parameters.DoubleSidedEnable);
            SetInt(material, Property.DoubleSidedNormalMode, (int)parameters.DoubleSidedNormalMode);
            SetVector(material, Property.DoubleSidedConstants, parameters.DoubleSidedConstants);

            SetBool(material, Property.SupportDecals, parameters.SupportDecals);
            SetBool(material, Property.ReceivesSSR, parameters.ReceivesSSR);
            SetBool(material, Property.ReceivesSSRTransparent, parameters.ReceivesSSRTransparent);

            // Exposed Properties

            // Sclera
            SetTexture(material, Property.Texture2D_5F873FC1, parameters.Texture2D_5F873FC1);
            SetTexture(material, Property.Texture2D_B9F5688C, parameters.Texture2D_B9F5688C);
            SetFloat(material, Property.Vector1_70564D59, parameters.Vector1_70564D59);

            // Iris
            SetTexture(material, Property.Texture2D_D8BF6575, parameters.Texture2D_D8BF6575);
            SetTexture(material, Property.Texture2D_4DB28C10, parameters.Texture2D_4DB28C10);
            SetFloat(material, Property.Vector1_FC0895C8, parameters.Vector1_FC0895C8);
            SetColor(material, Property.Color_83777D09, parameters.Color_83777D09);

            // Pupil
            SetFloat(material, Property.Vector1_DFF948F3, parameters.Vector1_DFF948F3);
            SetBool(material, Property.Boolean_8D34052F, parameters.Boolean_8D34052F);
            SetFloat(material, Property.Vector1_FEA38ABB, parameters.Vector1_FEA38ABB);
            SetFloat(material, Property.Vector1_2D21A623, parameters.Vector1_2D21A623);
            SetFloat(material, Property.Vector1_49C490F5, parameters.Vector1_49C490F5);

            SetFloat(material, Property.Vector1_F084AE9E, parameters.Vector1_F084AE9E);
            SetFloat(material, Property.Vector1_8F0D1174, parameters.Vector1_8F0D1174);
            SetFloat(material, Property.Vector1_76BF2124, parameters.Vector1_76BF2124);

            // Limbal Ring
            SetFloat(material, Property.Vector1_C4ED1456, parameters.Vector1_C4ED1456);
            SetFloat(material, Property.Vector1_94E1614A, parameters.Vector1_94E1614A);
            SetFloat(material, Property.Vector1_6C2C412D, parameters.Vector1_6C2C412D);
            SetFloat(material, Property.Vector1_A6DA845F, parameters.Vector1_A6DA845F);

            // Iris Diffusion Profile
            SetFloat(material, Property.DiffusionProfile_bfbe0deb8ec4428a9cfcdb968651903c, parameters.DiffusionProfile_bfbe0deb8ec4428a9cfcdb968651903c);
            SetVector(material, Property.DiffusionProfile_bfbe0deb8ec4428a9cfcdb968651903c_Asset, parameters.DiffusionProfile_bfbe0deb8ec4428a9cfcdb968651903c_Asset);

            // Sclera Diffusion Profile
            SetFloat(material, Property.DiffusionProfile_261f48f1fbc94ccbafc421414859c159, parameters.DiffusionProfile_261f48f1fbc94ccbafc421414859c159);
            SetVector(material, Property.DiffusionProfile_261f48f1fbc94ccbafc421414859c159_Asset, parameters.DiffusionProfile_261f48f1fbc94ccbafc421414859c159_Asset);
        }

        /// <summary>
        /// Set the parameter value to the material.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="parameters"></param>
        private static void SetHdrpHairParametersToMaterial(Material material, HdrpHairDefinition parameters)
        {
            // Surface Options
            SetInt(material, Property.SurfaceType, (int)parameters.SurfaceType);
            SetInt(material, Property.RenderQueueType, (int)parameters.RenderQueueType);
            SetInt(material, Property.BlendMode, (int)parameters.BlendMode);
            SetBool(material, Property.EnableBlendModePreserveSpecularLighting, parameters.EnableBlendModePreserveSpecularLighting);

            SetInt(material, Property.CullMode, (int)parameters.CullMode);
            SetInt(material, Property.CullModeForward, (int)parameters.CullModeForward);
            SetInt(material, Property.OpaqueCullMode, (int)parameters.OpaqueCullMode);

            SetFloat(material, Property.SrcBlend, parameters.SrcBlend);
            SetFloat(material, Property.DstBlend, parameters.DstBlend);
            SetBool(material, Property.ZWrite, parameters.ZWrite);

            // Transparent
            SetInt(material, Property.TransparentCullMode, (int)parameters.TransparentCullMode);
            SetBool(material, Property.EnableFogOnTransparent, parameters.EnableFogOnTransparent);
            SetFloat(material, Property.TransparentSortPriority, parameters.TransparentSortPriority);
            SetBool(material, Property.TransparentBackfaceEnable, parameters.TransparentBackfaceEnable);
            SetBool(material, Property.TransparentDepthPrepassEnable, parameters.TransparentDepthPrepassEnable);
            SetBool(material, Property.TransparentDepthPostpassEnable, parameters.TransparentDepthPostpassEnable);
            SetFloat(material, Property.TransparentWritingMotionVec, parameters.TransparentWritingMotionVec);
            SetBool(material, Property.TransparentZWrite, parameters.TransparentZWrite);

            SetInt(material, Property.ZTestDepthEqualForOpaque, parameters.ZTestDepthEqualForOpaque);
            SetInt(material, Property.ZTestTransparent, parameters.ZTestTransparent);

            // Alpha Clipping
            SetBool(material, Property.AlphaCutoffEnable, parameters.AlphaCutoffEnable);
            SetBool(material, Property.UseShadowThreshold, parameters.UseShadowThreshold);
            SetBool(material, Property.AlphaToMask, parameters.AlphaToMask);
            SetFloat(material, Property.AlphaToMaskInspectorValue, parameters.AlphaToMaskInspectorValue);

            SetFloat(material, Property.AlphaSrcBlend, parameters.AlphaSrcBlend);
            SetFloat(material, Property.AlphaDstBlend, parameters.AlphaDstBlend);

            // Double Sided
            SetBool(material, Property.DoubleSidedEnable, parameters.DoubleSidedEnable);
            SetInt(material, Property.DoubleSidedNormalMode, (int)parameters.DoubleSidedNormalMode);
            SetVector(material, Property.DoubleSidedConstants, parameters.DoubleSidedConstants);

            SetBool(material, Property.SupportDecals, parameters.SupportDecals);
            SetBool(material, Property.ReceivesSSR, parameters.ReceivesSSR);
            SetBool(material, Property.ReceivesSSRTransparent, parameters.ReceivesSSRTransparent);

            // Exposed Properties

            // Base
            SetColor(material, Property.Color, parameters.BaseColor);
            SetTexture(material, Property.BaseColorMap, parameters.BaseColorMap);

            // Alpha
            SetBool(material, Property.Alpha, parameters.Alpha);
            SetFloat(material, Property.AlphaClipThreshold, parameters.AlphaClipThreshold);
            SetFloat(material, Property.AlphaClipThresholdDepthPrepass, parameters.AlphaClipThresholdDepthPrepass);
            SetFloat(material, Property.AlphaClipThresholdDepthPostpass, parameters.AlphaClipThresholdDepthPostpass);
            SetFloat(material, Property.AlphaThresholdShadow, parameters.AlphaThresholdShadow);

            // Base UV
            SetVector(material, Property.UVBaseST, parameters.UVBaseST);

            // Normal
            SetTexture(material, Property.NormalMap, parameters.NormalMap);
            SetFloat(material, Property.NormalScale, parameters.NormalScale);

            // Ambient Occulusion
            SetTexture(material, Property.MaskMap, parameters.MaskMap);
            SetBool(material, Property.LightmapUV, parameters.LightmapUV);

            // Smoothness
            SetTexture(material, Property.SmoothnessMask, parameters.SmoothnessMask);
            SetVector(material, Property.UVSmoothnessST, parameters.UVSmoothnessST);
            SetFloat(material, Property.SmoothnessMin, parameters.SmoothnessMin);
            SetFloat(material, Property.SmoothnessMax, parameters.SmoothnessMax);

            // Specular
            SetColor(material, Property.SpecularColor, parameters.SpecularColor);
            SetFloat(material, Property.Specular, parameters.Specular);
            SetFloat(material, Property.SpecularShift, parameters.SpecularShift);
            SetFloat(material, Property.SecondarySpecular, parameters.SecondarySpecular);
            SetFloat(material, Property.SecondarySpecularShift, parameters.SecondarySpecularShift);

            // Transmission
            SetColor(material, Property.TransmissionColor, parameters.TransmissionColor);
            SetFloat(material, Property.TransmissionRim, parameters.TransmissionRim);
        }

        /// <summary>
        /// Set the parameter value to the material.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="parameters"></param>
        private static void SetHdrpLitParametersToMaterial(Material material, HdrpLitDefinition parameters)
        {
            SetKeyword(material, Keyword.AlphaToMaskOn, parameters.AlphaToMask);
            SetKeyword(material, Keyword.DepthOffsetOn, parameters.DepthOffsetEnable);
            SetKeyword(material, Keyword.DoubleSidedOn, parameters.DoubleSidedEnable);

            SetKeyword(material, Keyword.VertexDisplacement, (parameters.DisplacementMode == DisplacementMode.Vertex));
            SetKeyword(material, Keyword.PixelDisplacement, (parameters.DisplacementMode == DisplacementMode.Pixel));

            // TODO
            SetKeyword(material, Keyword.VertexDisplacementLockObjectScale, (parameters.DisplacementMode == DisplacementMode.Vertex) && (parameters.DisplacementLockObjectScale > 0.0f));
            SetKeyword(material, Keyword.DisplacementLockTilingScale, (parameters.DisplacementLockTilingScale > 0.0f));
            SetKeyword(material, Keyword.PixelDisplacementLockObjectScale, (parameters.DisplacementMode == DisplacementMode.Pixel) && (parameters.DisplacementLockTilingScale > 0.0f));

            // TODO
            SetKeyword(material, Keyword.EmissiveMappingPlanar, (parameters.UVEmissive == UVEmissiveMapping.Planar));
            SetKeyword(material, Keyword.EmissiveMappingTriplanar, (parameters.UVEmissive == UVEmissiveMapping.Triplanar));
            SetKeyword(material, Keyword.EmissiveMappingBase, (parameters.UVEmissive == UVEmissiveMapping.SameAsBase));

            // TODO
            SetKeyword(material, Keyword.MappingPlanar, (parameters.UVBase == UVBaseMapping.Planar));
            SetKeyword(material, Keyword.MappingTriplanar, (parameters.UVBase == UVBaseMapping.Triplanar));

            SetKeyword(material, Keyword.NormalMapTangentSpace, (parameters.NormalMapSpace == NormalMapSpace.TangentSpace));

            // TODO
            SetKeyword(material, Keyword.RequireUv2, (parameters.UVBase == UVBaseMapping.UV2));
            SetKeyword(material, Keyword.RequireUv3, (parameters.UVBase == UVBaseMapping.UV3));

            SetKeyword(material, Keyword.MaskMap, (parameters.MaskMap != null));
            SetKeyword(material, Keyword.NormalMap, ((parameters.NormalMap != null) || (parameters.NormalMapOS != null)));
            SetKeyword(material, Keyword.BentNormalMap, ((parameters.BentNormalMap != null) || (parameters.BentNormalMapOS != null)));
            SetKeyword(material, Keyword.EmissiveColorMap, (parameters.EmissiveColorMap != null));

            // TODO
            SetKeyword(material, Keyword.EnableSpecularOcclusion, (parameters.SpecularOcclusionMode != SpecularOcclusionMode.Off));
            SetKeyword(material, Keyword.SpecularOcclusionNone, (parameters.SpecularOcclusionMode == SpecularOcclusionMode.Off));
            SetKeyword(material, Keyword.SpecularOcclusionFromBentNormalMap, (parameters.SpecularOcclusionMode == SpecularOcclusionMode.FromBentNormals));

            SetKeyword(material, Keyword.HeightMap, (parameters.HeightMap != null));
            SetKeyword(material, Keyword.TangentMap, (parameters.TangentMap != null));
            SetKeyword(material, Keyword.AnisotropyMap, (parameters.AnisotropyMap != null));
            SetKeyword(material, Keyword.DetailMap, (parameters.DetailMap != null));
            SetKeyword(material, Keyword.SubsurfaceMaskMap, (parameters.SubsurfaceMaskMap != null));
            SetKeyword(material, Keyword.ThicknessMap, (parameters.ThicknessMap != null));
            SetKeyword(material, Keyword.IridescenceThicknessMap, (parameters.IridescenceThicknessMap != null));
            SetKeyword(material, Keyword.SpecularColorMap, (parameters.SpecularColorMap != null));
            SetKeyword(material, Keyword.TransmittanceColorMap, (parameters.TransmittanceColorMap != null));

            SetKeyword(material, Keyword.DisableDecals, (parameters.SupportDecals == false));
            SetKeyword(material, Keyword.DisableSsr, (parameters.ReceivesSSR == false));
            SetKeyword(material, Keyword.DisableSsrTransparent, (parameters.ReceivesSSRTransparent == false));

            SetKeyword(material, Keyword.EnableGeometricSpecularAa, parameters.EnableGeometricSpecularAA);
            SetKeyword(material, Keyword.SurfaceTypeTransparent, (parameters.SurfaceType == SurfaceType.Transparent));
            SetKeyword(material, Keyword.EnableFogOnTransparent, parameters.EnableFogOnTransparent);

            // TODO
            SetKeyword(material, Keyword.TransparentWritesMotionVec, (parameters.TransparentWritingMotionVec > 0.0f));

            // TODO
            SetKeyword(material, Keyword.MaterialFeatureSubsurfaceScattering, (parameters.MaterialID == MaterialId.LitSSS));
            //SetKeyword(material, Keyword.MaterialFeatureTransmission, false);
            SetKeyword(material, Keyword.MaterialFeatureAnisotropy, (parameters.MaterialID == MaterialId.LitAniso));
            //SetKeyword(material, Keyword.MaterialFeatureClearCoat, false);
            SetKeyword(material, Keyword.MaterialFeatureIridscence, (parameters.MaterialID == MaterialId.LitIridescence));
            SetKeyword(material, Keyword.MaterialFeatureSpecularColor, (parameters.MaterialID == MaterialId.LitSpecular));

            SetKeyword(material, Keyword.AddPrecomputedVelocity, parameters.AddPrecomputedVelocity);

            SetSurfaceType(material, parameters.SurfaceType);

            // Base Map
            SetColor(material, Property.Color, parameters.BaseColor);
            SetTexture(material, Property.BaseColorMap, parameters.BaseColorMap);
            SetVector(material, Property.BaseColorMapMipInfo, parameters.BaseColorMapMipInfo);

            // Metallic Gloss Map
            SetFloat(material, Property.Metallic, parameters.Metallic);
            SetFloat(material, Property.Smoothness, parameters.Smoothness);
            SetTexture(material, Property.MaskMap, parameters.MaskMap);
            SetFloat(material, Property.MetallicRemapMin, parameters.MetallicRemapMin);
            SetFloat(material, Property.MetallicRemapMax, parameters.MetallicRemapMax);
            SetFloat(material, Property.SmoothnessRemapMin, parameters.SmoothnessRemapMin);
            SetFloat(material, Property.SmoothnessRemapMax, parameters.SmoothnessRemapMax);
            SetFloat(material, Property.AORemapMin, parameters.AORemapMin);
            SetFloat(material, Property.AORemapMax, parameters.AORemapMax);

            // Normal Map
            SetTexture(material, Property.NormalMap, parameters.NormalMap);
            SetTexture(material, Property.NormalMapOS, parameters.NormalMapOS);
            SetFloat(material, Property.NormalScale, parameters.NormalScale);

            // Bent Normal Map
            SetTexture(material, Property.BentNormalMap, parameters.BentNormalMap);
            SetTexture(material, Property.BentNormalMapOS, parameters.BentNormalMapOS);

            // Height Map
            SetTexture(material, Property.HeightMap, parameters.HeightMap);
            SetFloat(material, Property.HeightAmplitude, parameters.HeightAmplitude);
            SetFloat(material, Property.HeightCenter, parameters.HeightCenter);

            SetInt(material, Property.HeightMapParametrization, (int)parameters.HeightMapParametrization);

            SetFloat(material, Property.HeightOffset, parameters.HeightOffset);
            SetFloat(material, Property.HeightMin, parameters.HeightMin);
            SetFloat(material, Property.HeightMax, parameters.HeightMax);
            SetFloat(material, Property.HeightTessAmplitude, parameters.HeightTessAmplitude);
            SetFloat(material, Property.HeightTessCenter, parameters.HeightTessCenter);

            SetFloat(material, Property.HeightPoMAmplitude, parameters.HeightPoMAmplitude);

            // Detail Map
            SetTexture(material, Property.DetailMap, parameters.DetailMap);
            SetFloat(material, Property.DetailAlbedoScale, parameters.DetailAlbedoScale);
            SetFloat(material, Property.DetailNormalScale, parameters.DetailNormalScale);
            SetFloat(material, Property.DetailSmoothnessScale, parameters.DetailSmoothnessScale);

            // Tangent Map
            SetTexture(material, Property.TangentMap, parameters.TangentMap);
            SetTexture(material, Property.TangentMapOS, parameters.TangentMapOS);

            // Anisotropy Map
            SetFloat(material, Property.Anisotropy, parameters.Anisotropy);
            SetTexture(material, Property.AnisotropyMap, parameters.AnisotropyMap);

            // Subsurface Mask Map
            SetFloat(material, Property.SubsurfaceMask, parameters.SubsurfaceMask);
            SetTexture(material, Property.SubsurfaceMaskMap, parameters.SubsurfaceMaskMap);

            // Thickness Map
            SetFloat(material, Property.Thickness, parameters.Thickness);
            SetTexture(material, Property.ThicknessMap, parameters.ThicknessMap);
            SetVector(material, Property.ThicknessRemap, parameters.ThicknessRemap);

            // Iridescence Thickness Map
            SetFloat(material, Property.IridescenceThickness, parameters.IridescenceThickness);
            SetTexture(material, Property.IridescenceThicknessMap, parameters.IridescenceThicknessMap);
            SetVector(material, Property.IridescenceThicknessRemap, parameters.IridescenceThicknessRemap);

            // Iridescence Mask Map
            SetFloat(material, Property.IridescenceMask, parameters.IridescenceMask);
            SetTexture(material, Property.IridescenceMaskMap, parameters.IridescenceMaskMap);

            // Coat Mask Map
            SetFloat(material, Property.CoatMask, parameters.CoatMask);
            SetTexture(material, Property.CoatMaskMap, parameters.CoatMaskMap);

            // Specular Color Map
            SetFloat(material, Property.EnergyConservingSpecularColor, parameters.EnergyConservingSpecularColor);
            SetColor(material, Property.SpecularColor, parameters.SpecularColor);
            SetTexture(material, Property.SpecularColorMap, parameters.SpecularColorMap);
            SetInt(material, Property.SpecularOcclusionMode, (int)parameters.SpecularOcclusionMode);

            // Emissive Color Map
            SetColor(material, Property.EmissiveColor, parameters.EmissiveColor);
            SetColor(material, Property.EmissiveColorLDR, parameters.EmissiveColorLDR);
            SetTexture(material, Property.EmissiveColorMap, parameters.EmissiveColorMap);

            SetFloat(material, Property.AlbedoAffectEmissive, parameters.AlbedoAffectEmissive);
            SetInt(material, Property.EmissiveIntensityUnit, parameters.EmissiveIntensityUnit);
            SetBool(material, Property.UseEmissiveIntensity, parameters.UseEmissiveIntensity);
            SetFloat(material, Property.EmissiveIntensity, parameters.EmissiveIntensity);
            SetFloat(material, Property.EmissiveExposureWeight, parameters.EmissiveExposureWeight);

            // Distortion Vector Map
            SetTexture(material, Property.DistortionVectorMap, parameters.DistortionVectorMap);
            SetBool(material, Property.DistortionEnable, parameters.DistortionEnable);
            SetBool(material, Property.DistortionDepthTest, parameters.DistortionDepthTest);
            SetInt(material, Property.DistortionBlendMode, (int)parameters.DistortionBlendMode);
            SetInt(material, Property.DistortionSrcBlend, parameters.DistortionSrcBlend);
            SetInt(material, Property.DistortionDstBlend, parameters.DistortionDstBlend);
            SetInt(material, Property.DistortionBlurSrcBlend, parameters.DistortionBlurSrcBlend);
            SetInt(material, Property.DistortionBlurDstBlend, parameters.DistortionBlurDstBlend);
            SetInt(material, Property.DistortionBlurBlendMode, parameters.DistortionBlurBlendMode);
            SetFloat(material, Property.DistortionScale, parameters.DistortionScale);
            SetFloat(material, Property.DistortionVectorScale, parameters.DistortionVectorScale);
            SetFloat(material, Property.DistortionVectorBias, parameters.DistortionVectorBias);
            SetFloat(material, Property.DistortionBlurScale, parameters.DistortionBlurScale);
            SetFloat(material, Property.DistortionBlurRemapMin, parameters.DistortionBlurRemapMin);
            SetFloat(material, Property.DistortionBlurRemapMax, parameters.DistortionBlurRemapMax);

            SetBool(material, Property.UseShadowThreshold, parameters.UseShadowThreshold);

            SetBool(material, Property.AlphaCutoffEnable, parameters.AlphaCutoffEnable);
            SetFloat(material, Property.AlphaCutoff, parameters.AlphaCutoff);
            SetFloat(material, Property.AlphaCutoffShadow, parameters.AlphaCutoffShadow);
            SetFloat(material, Property.AlphaCutoffPrepass, parameters.AlphaCutoffPrepass);
            SetFloat(material, Property.AlphaCutoffPostpass, parameters.AlphaCutoffPostpass);

            SetBool(material, Property.TransparentDepthPrepassEnable, parameters.TransparentDepthPrepassEnable);
            SetBool(material, Property.TransparentBackfaceEnable, parameters.TransparentBackfaceEnable);
            SetBool(material, Property.TransparentDepthPostpassEnable, parameters.TransparentDepthPostpassEnable);
            SetFloat(material, Property.TransparentSortPriority, parameters.TransparentSortPriority);

            // Transparency
            SetInt(material, Property.RefractionModel, (int)parameters.RefractionModel);
            SetFloat(material, Property.Ior, parameters.Ior);
            SetColor(material, Property.TransmittanceColor, parameters.TransmittanceColor);
            SetTexture(material, Property.TransmittanceColorMap, parameters.TransmittanceColorMap);
            SetFloat(material, Property.ATDistance, parameters.ATDistance);
            SetFloat(material, Property.TransparentWritingMotionVec, parameters.TransparentWritingMotionVec);

            // Stencil state

            // Forward
            SetInt(material, Property.StencilRef, parameters.StencilRef);
            SetInt(material, Property.StencilWriteMask, parameters.StencilWriteMask);
            // GBuffer
            SetInt(material, Property.StencilRefGBuffer, parameters.StencilRefGBuffer);
            SetInt(material, Property.StencilWriteMaskGBuffer, parameters.StencilWriteMaskGBuffer);
            // Depth prepass
            SetInt(material, Property.StencilRefDepth, parameters.StencilRefDepth);
            SetInt(material, Property.StencilWriteMaskDepth, parameters.StencilWriteMaskDepth);
            // Motion vector pass
            SetInt(material, Property.StencilRefMV, parameters.StencilRefMV);
            SetInt(material, Property.StencilWriteMaskMV, parameters.StencilWriteMaskMV);
            // Distortion vector pass
            SetInt(material, Property.StencilRefDistortionVec, parameters.StencilRefDistortionVec);
            SetInt(material, Property.StencilWriteMaskDistortionVec, parameters.StencilWriteMaskDistortionVec);

            // Blending state
            SetInt(material, Property.SurfaceType, (int)parameters.SurfaceType);
            SetInt(material, Property.RenderQueueType, (int)parameters.RenderQueueType);
            SetInt(material, Property.BlendMode, (int)parameters.BlendMode);
            SetFloat(material, Property.SrcBlend, parameters.SrcBlend);
            SetFloat(material, Property.DstBlend, parameters.DstBlend);
            SetFloat(material, Property.AlphaSrcBlend, parameters.AlphaSrcBlend);
            SetFloat(material, Property.AlphaDstBlend, parameters.AlphaDstBlend);
            SetFloat(material, Property.AlphaToMaskInspectorValue, parameters.AlphaToMaskInspectorValue);
            SetBool(material, Property.AlphaToMask, parameters.AlphaToMask);
            SetBool(material, Property.ZWrite, parameters.ZWrite);
            SetBool(material, Property.TransparentZWrite, parameters.TransparentZWrite);
            SetInt(material, Property.CullMode, (int)parameters.CullMode);
            SetInt(material, Property.CullModeForward, (int)parameters.CullModeForward);
            SetInt(material, Property.TransparentCullMode, (int)parameters.TransparentCullMode);
            SetInt(material, Property.OpaqueCullMode, (int)parameters.OpaqueCullMode);
            SetInt(material, Property.ZTestDepthEqualForOpaque, parameters.ZTestDepthEqualForOpaque);
            SetInt(material, Property.ZTestModeDistortion, parameters.ZTestModeDistortion);
            SetInt(material, Property.ZTestTransparent, parameters.ZTestTransparent);

            SetBool(material, Property.EnableFogOnTransparent, parameters.EnableFogOnTransparent);
            SetBool(material, Property.EnableBlendModePreserveSpecularLighting, parameters.EnableBlendModePreserveSpecularLighting);

            // Double Sided
            SetBool(material, Property.DoubleSidedEnable, parameters.DoubleSidedEnable);
            SetInt(material, Property.DoubleSidedNormalMode, (int)parameters.DoubleSidedNormalMode);
            SetVector(material, Property.DoubleSidedConstants, parameters.DoubleSidedConstants);

            SetInt(material, Property.UVBase, (int)parameters.UVBase);
            SetFloat(material, Property.TexWorldScale, parameters.TexWorldScale);
            SetFloat(material, Property.InvTilingScale, parameters.InvTilingScale);
            SetColor(material, Property.UVMappingMask, parameters.UVMappingMask);
            SetInt(material, Property.NormalMapSpace, (int)parameters.NormalMapSpace);

            SetInt(material, Property.MaterialID, (int)parameters.MaterialID);
            SetBool(material, Property.TransmissionEnable, parameters.TransmissionEnable);

            SetInt(material, Property.DisplacementMode, (int)parameters.DisplacementMode);
            SetFloat(material, Property.DisplacementLockObjectScale, parameters.DisplacementLockObjectScale);
            SetFloat(material, Property.DisplacementLockTilingScale, parameters.DisplacementLockTilingScale);
            SetBool(material, Property.DepthOffsetEnable, parameters.DepthOffsetEnable);

            // Specular AA
            SetBool(material, Property.EnableGeometricSpecularAA, parameters.EnableGeometricSpecularAA);
            SetFloat(material, Property.SpecularAAScreenSpaceVariance, parameters.SpecularAAScreenSpaceVariance);
            SetFloat(material, Property.SpecularAAThreshold, parameters.SpecularAAThreshold);

            SetFloat(material, Property.PPDMinSamples, parameters.PPDMinSamples);
            SetFloat(material, Property.PPDMaxSamples, parameters.PPDMaxSamples);
            SetFloat(material, Property.PPDLodThreshold, parameters.PPDLodThreshold);
            SetFloat(material, Property.PPDPrimitiveLength, parameters.PPDPrimitiveLength);
            SetFloat(material, Property.PPDPrimitiveWidth, parameters.PPDPrimitiveWidth);
            SetVector(material, Property.InvPrimScale, parameters.InvPrimScale);

            SetInt(material, Property.UVDetail, (int)parameters.UVDetail);
            SetVector(material, Property.UVDetailsMappingMask, parameters.UVDetailsMappingMask);
            SetBool(material, Property.LinkDetailsWithBase, parameters.LinkDetailsWithBase);

            SetInt(material, Property.EmissiveColorMode, (int)parameters.EmissiveColorMode);
            SetInt(material, Property.UVEmissive, (int)parameters.UVEmissive);
            SetFloat(material, Property.TexWorldScaleEmissive, parameters.TexWorldScaleEmissive);
            SetColor(material, Property.UVMappingMaskEmissive, parameters.UVMappingMaskEmissive);

            SetColor(material, Property.EmissionColor, parameters.EmissionColor);

            SetTexture(material, Property.MainTex, parameters.MainTex);
            SetColor(material, Property.Color, parameters.Color);
            SetFloat(material, Property.Cutoff, parameters.Cutoff);

            SetBool(material, Property.SupportDecals, parameters.SupportDecals);
            SetBool(material, Property.ReceivesSSR, parameters.ReceivesSSR);
            SetBool(material, Property.ReceivesSSRTransparent, parameters.ReceivesSSRTransparent);
            SetBool(material, Property.AddPrecomputedVelocity, parameters.AddPrecomputedVelocity);

            SetBool(material, Property.RayTracing, parameters.RayTracing);

            //SetInt(material, Property.DiffusionProfile, parameters.DiffusionProfile);
            SetVector(material, Property.DiffusionProfileAsset, parameters.DiffusionProfileAsset);
            SetFloat(material, Property.DiffusionProfileHash, parameters.DiffusionProfileHash);

            //SetTexture2DArray(material, Property.UnityLightmaps, parameters.UnityLightmaps);
            //SetTexture2DArray(material, Property.UnityLightmapsInd, parameters.UnityLightmapsInd);
            //SetTexture2DArray(material, Property.UnityShadowMasks, parameters.UnityShadowMasks);
        }

        /// <summary>
        /// Sets the surface type.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="surfaceType"></param>
        /// <param name="blendMode"></param>
        public static void SetSurfaceType(Material material, SurfaceType surfaceType, BlendMode? blendMode = null)
        {
            material.SetInt(Property.SurfaceType, (int)surfaceType);

            if (blendMode.HasValue)
            {
                material.SetInt(Property.BlendMode, (int)blendMode);
            }

            switch (surfaceType)
            {
                case SurfaceType.Opaque:
                    material.SetInt(Property.SrcBlend, (int)UnityEngine.Rendering.BlendMode.One);
                    material.SetInt(Property.DstBlend, (int)UnityEngine.Rendering.BlendMode.Zero);
                    material.SetInt(Property.AlphaSrcBlend, (int)UnityEngine.Rendering.BlendMode.One);
                    material.SetInt(Property.AlphaDstBlend, (int)UnityEngine.Rendering.BlendMode.Zero);
                    material.SetInt(Property.ZWrite, 1);
                    material.SetInt(Property.TransparentZWrite, 0);
                    //SetKeyword(material, Keyword.AlphaTestOn, false);
                    //SetKeyword(material, Keyword.AlphaBlendOn, false);
                    material.renderQueue = 2225;  // @notice
                    break;

                case SurfaceType.Transparent:
                    switch (blendMode)
                    {
                        case BlendMode.Alpha:
                            material.SetInt(Property.SrcBlend, (int)UnityEngine.Rendering.BlendMode.One);
                            material.SetInt(Property.DstBlend, (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
                            material.SetInt(Property.AlphaSrcBlend, (int)UnityEngine.Rendering.BlendMode.One);
                            material.SetInt(Property.AlphaDstBlend, (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
                            material.SetInt(Property.ZWrite, 0);
                            material.SetInt(Property.TransparentZWrite, 0);
                            //SetKeyword(material, Keyword.AlphaTestOn, true);
                            //SetKeyword(material, Keyword.AlphaBlendOn, false);
                            //SetKeyword(material, Keyword.AlphaPremultiplyOn, false);
                            material.renderQueue = (int)UnityEngine.Rendering.RenderQueue.Transparent;
                            break;
                        case BlendMode.Additive:
                            material.SetInt(Property.SrcBlend, (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
                            material.SetInt(Property.DstBlend, (int)UnityEngine.Rendering.BlendMode.One);
                            material.SetInt(Property.AlphaSrcBlend, (int)UnityEngine.Rendering.BlendMode.SrcAlpha);
                            material.SetInt(Property.AlphaDstBlend, (int)UnityEngine.Rendering.BlendMode.One);
                            material.SetInt(Property.ZWrite, 0);
                            material.SetInt(Property.TransparentZWrite, 0);
                            //SetKeyword(material, Keyword.AlphaTestOn, false);
                            //SetKeyword(material, Keyword.AlphaBlendOn, true);
                            //SetKeyword(material, Keyword.AlphaPremultiplyOn, false);
                            material.renderQueue = (int)UnityEngine.Rendering.RenderQueue.Transparent;
                            break;
                        case BlendMode.Premultiply:
                            material.SetInt(Property.SrcBlend, (int)UnityEngine.Rendering.BlendMode.One);
                            material.SetInt(Property.DstBlend, (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
                            material.SetInt(Property.AlphaSrcBlend, (int)UnityEngine.Rendering.BlendMode.One);
                            material.SetInt(Property.AlphaDstBlend, (int)UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha);
                            material.SetInt(Property.ZWrite, 0);
                            material.SetInt(Property.TransparentZWrite, 0);
                            //SetKeyword(material, Keyword.AlphaTestOn, false);  // @notice true?
                            //SetKeyword(material, Keyword.AlphaBlendOn, false);
                            //SetKeyword(material, Keyword.AlphaPremultiplyOn, true);
                            material.renderQueue = (int)UnityEngine.Rendering.RenderQueue.Transparent;
                            break;
                    }
                    break;
            }
        }

        /// <summary>
        /// Sets bool value.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <param name="val"></param>
        private static void SetBool(Material material, string propertyName, bool val)
        {
            if (material.HasProperty(propertyName))
            {
                material.SetInt(propertyName, (val == true) ? 1 : 0);
            }
        }

        /// <summary>
        /// Sets int value.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <param name="val"></param>
        private static void SetInt(Material material, string propertyName, int val)
        {
            if (material.HasProperty(propertyName))
            {
                material.SetInt(propertyName, val);
            }
        }

        /// <summary>
        /// Sets float value.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <param name="val"></param>
        private static void SetFloat(Material material, string propertyName, float val)
        {
            if (material.HasProperty(propertyName))
            {
                material.SetFloat(propertyName, val);
            }
        }

        /// <summary>
        /// Sets color value.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <param name="color"></param>
        private static void SetColor(Material material, string propertyName, Color color)
        {
            if (material.HasProperty(propertyName))
            {
                material.SetColor(propertyName, color);
            }
        }

        /// <summary>
        /// Sets the Texture.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <param name="texture"></param>
        private static void SetTexture(Material material, string propertyName, Texture2D texture)
        {
            if (material.HasProperty(propertyName))
            {
                material.SetTexture(propertyName, texture);
            }
        }

        /// <summary>
        /// Sets the Vector.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <param name="vector"></param>
        private static void SetVector(Material material, string propertyName, Vector4 vector)
        {
            if (material.HasProperty(propertyName))
            {
                material.SetVector(propertyName, vector);
            }
        }

        /// <summary>
        /// Sets the keyword.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="keyword"></param>
        /// <param name="required"></param>
        private static void SetKeyword(Material material, string keyword, bool required)
        {
            if (required)
            {
                material.EnableKeyword(keyword);
            }
            else
            {
                material.DisableKeyword(keyword);
            }
        }
    }
}