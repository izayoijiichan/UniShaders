// ----------------------------------------------------------------------
// @Namespace : UniHdrpShader
// @Class     : HdrpLitMaterialProxy
// ----------------------------------------------------------------------
namespace UniHdrpShader
{
    using System;
    using UniShader.Shared;
    using UnityEngine;
    using UnityEngine.Rendering;

    /// <summary>
    /// HDRP Lit Material Proxy
    /// </summary>
    /// <remarks>
    /// com.unity.render-pipelines.high-definition
    /// Lit.shader
    /// </remarks>
    public class HdrpLitMaterialProxy : HdrpMaterialProxyBase
    {
        #region Properties

        /// <summary>Color</summary>
        public Color BaseColor
        {
            get => _Material.GetSafeColor(Property.BaseColor);
            set => _Material.SetSafeColor(Property.BaseColor, value);
        }

        /// <summary>Base Color Map</summary>
        public Texture2D BaseColorMap
        {
            get => _Material.GetSafeTexture(Property.BaseColorMap);
            set => _Material.SetSafeTexture(Property.BaseColorMap, value);
        }

        /// <summary>Base Color Map Mip Info</summary>
        public Vector4 BaseColorMapMipInfo
        {
            get => _Material.GetSafeVector4(Property.BaseColorMapMipInfo);
            set => _Material.SetSafeVector(Property.BaseColorMapMipInfo, value);
        }

        /// <summary>Metallic</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float Metallic
        {
            get => _Material.GetSafeFloat(Property.Metallic, PropertyRange.Metallic.defaultValue);
            set => _Material.SetSafeFloat(Property.Metallic, PropertyRange.Metallic, value);
        }

        /// <summary>Smoothness</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float Smoothness
        {
            get => _Material.GetSafeFloat(Property.Smoothness, PropertyRange.Smoothness.defaultValue);
            set => _Material.SetSafeFloat(Property.Smoothness, PropertyRange.Smoothness, value);
        }

        /// <summary>Mask Map</summary>
        public Texture2D MaskMap
        {
            get => _Material.GetSafeTexture(Property.MaskMap);
            set
            {
                _Material.SetSafeTexture(Property.MaskMap, value);

                _Material.SetSafeKeyword(Keyword.MaskMap, value != null);
            }
        }

        /// <summary>Metallic Remapping Min</summary>
        //[DefaultValue(0.0f)]
        public float MetallicRemapMin
        {
            get => _Material.GetSafeFloat(Property.MetallicRemapMin, PropertyRange.MetallicRemapMin.defaultValue);
            set => _Material.SetSafeFloat(Property.MetallicRemapMin, PropertyRange.MetallicRemapMin, value);
        }

        /// <summary>Metallic Remapping Max</summary>
        //[DefaultValue(1.0f)]
        public float MetallicRemapMax
        {
            get => _Material.GetSafeFloat(Property.MetallicRemapMax, PropertyRange.MetallicRemapMax.defaultValue);
            set => _Material.SetSafeFloat(Property.MetallicRemapMax, PropertyRange.MetallicRemapMax, value);
        }

        /// <summary>Smoothness Remapping Min</summary>
        //[DefaultValue(0.0f)]
        public float SmoothnessRemapMin
        {
            get => _Material.GetSafeFloat(Property.SmoothnessRemapMin, PropertyRange.SmoothnessRemapMin.defaultValue);
            set => _Material.SetSafeFloat(Property.SmoothnessRemapMin, PropertyRange.SmoothnessRemapMin, value);
        }

        /// <summary>Smoothness Remapping Max</summary>
        //[DefaultValue(1.0f)]
        public float SmoothnessRemapMax
        {
            get => _Material.GetSafeFloat(Property.SmoothnessRemapMax, PropertyRange.SmoothnessRemapMax.defaultValue);
            set => _Material.SetSafeFloat(Property.SmoothnessRemapMax, PropertyRange.SmoothnessRemapMax, value);
        }

        /// <summary>Ambient Occlusion Remapping Min</summary>
        //[DefaultValue(0.0f)]
        public float AORemapMin
        {
            get => _Material.GetSafeFloat(Property.AORemapMin, PropertyRange.AORemapMin.defaultValue);
            set => _Material.SetSafeFloat(Property.AORemapMin, PropertyRange.AORemapMin, value);
        }

        /// <summary>Ambient Occlusion Remapping Max</summary>
        //[DefaultValue(1.0f)]
        public float AORemapMax
        {
            get => _Material.GetSafeFloat(Property.AORemapMax, PropertyRange.AORemapMax.defaultValue);
            set => _Material.SetSafeFloat(Property.AORemapMax, PropertyRange.AORemapMax, value);
        }

        /// <summary>Normal Map</summary>
        public Texture2D NormalMap
        {
            get => _Material.GetSafeTexture(Property.NormalMap);
            set
            {
                _Material.SetSafeTexture(Property.NormalMap, value);

                if (NormalMapSpace == NormalMapSpace.TangentSpace)
                {
                    _Material.SetSafeKeyword(Keyword.NormalMap, (value != null) || (DetailMap != null));
                }
            }
        }

        /// <summary>Normal Map Object Space</summary>
        public Texture2D NormalMapOS
        {
            get => _Material.GetSafeTexture(Property.NormalMapOS);
            set
            {
                _Material.SetSafeTexture(Property.NormalMapOS, value);

                if (NormalMapSpace == NormalMapSpace.ObjectSpace)
                {
                    _Material.SetSafeKeyword(Keyword.NormalMap, value != null);
                }
            }
        }

        /// <summary>Normal Scale</summary>
        //[Range(0.0f, 8.0f)]
        //[DefaultValue(1.0f)]
        public float NormalScale
        {
            get => _Material.GetSafeFloat(Property.NormalScale, PropertyRange.NormalScale.defaultValue);
            set => _Material.SetSafeFloat(Property.NormalScale, PropertyRange.NormalScale, value);
        }

        /// <summary>Bent Normal Map</summary>
        public Texture2D BentNormalMap
        {
            get => _Material.GetSafeTexture(Property.BentNormalMap);
            set
            {
                _Material.SetSafeTexture(Property.BentNormalMap, value);

                if (NormalMapSpace == NormalMapSpace.TangentSpace)
                {
                    _Material.SetSafeKeyword(Keyword.BentNormalMap, value != null);
                }
            }
        }

        /// <summary>Bent Normal Map Object Space</summary>
        public Texture2D BentNormalMapOS
        {
            get => _Material.GetSafeTexture(Property.BentNormalMapOS);
            set
            {
                _Material.SetSafeTexture(Property.BentNormalMapOS, value);

                if (NormalMapSpace == NormalMapSpace.ObjectSpace)
                {
                    _Material.SetSafeKeyword(Keyword.BentNormalMap, value != null);
                }
            }
        }

        /// <summary>Height Map</summary>
        public Texture2D HeightMap
        {
            get => _Material.GetSafeTexture(Property.HeightMap);
            set
            {
                _Material.SetSafeTexture(Property.HeightMap, value);

                _Material.SetSafeKeyword(Keyword.HeightMap, value != null);
            }
        }

        /// <summary>Height Amplitude</summary>
        //[DefaultValue(0.02f)]
        public float HeightAmplitude
        {
            get => _Material.GetSafeFloat(Property.HeightAmplitude, PropertyRange.HeightAmplitude.defaultValue);
            set => _Material.SetSafeFloat(Property.HeightAmplitude, PropertyRange.HeightAmplitude, value);
        }

        /// <summary>Height Center</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float HeightCenter
        {
            get => _Material.GetSafeFloat(Property.HeightCenter, PropertyRange.HeightCenter.defaultValue);
            set => _Material.SetSafeFloat(Property.HeightCenter, PropertyRange.HeightCenter, value);
        }

        /// <summary>HeightMap Parametrization</summary>
        //[DefaultValue(HeightmapParametrization.MinMax)]
        public HeightmapParametrization HeightMapParametrization
        {
            get => _Material.GetSafeEnum<HeightmapParametrization>(Property.HeightMapParametrization, HeightmapParametrization.MinMax);
            set => _Material.SetSafeInt(Property.HeightMapParametrization, (int)value);
        }

        /// <summary>Height Offset</summary>
        //[DefaultValue(0.0f)]
        public float HeightOffset
        {
            get => _Material.GetSafeFloat(Property.HeightOffset, PropertyRange.HeightOffset.defaultValue);
            set => _Material.SetSafeFloat(Property.HeightOffset, PropertyRange.HeightOffset, value);
        }

        /// <summary>Height Map Min</summary>
        //[DefaultValue(-1.0f)]
        public float HeightMin
        {
            get => _Material.GetSafeFloat(Property.HeightMin, PropertyRange.HeightMin.defaultValue);
            set => _Material.SetSafeFloat(Property.HeightMin, PropertyRange.HeightMin, value);
        }

        /// <summary>Height Map Max</summary>
        //[DefaultValue(1.0f)]
        public float HeightMax
        {
            get => _Material.GetSafeFloat(Property.HeightMax, PropertyRange.HeightMax.defaultValue);
            set => _Material.SetSafeFloat(Property.HeightMax, PropertyRange.HeightMax, value);
        }

        /// <summary>Height Tess Amplitude</summary>
        //[DefaultValue(2.0f)]
        public float HeightTessAmplitude
        {
            get => _Material.GetSafeFloat(Property.HeightTessAmplitude, PropertyRange.HeightTessAmplitude.defaultValue);
            set => _Material.SetSafeFloat(Property.HeightTessAmplitude, PropertyRange.HeightTessAmplitude, value);
        }

        /// <summary>Height Tess Center</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float HeightTessCenter
        {
            get => _Material.GetSafeFloat(Property.HeightTessCenter, PropertyRange.HeightTessCenter.defaultValue);
            set => _Material.SetSafeFloat(Property.HeightTessCenter, PropertyRange.HeightTessCenter, value);
        }

        /// <summary>Height PoM Amplitude</summary>
        //[DefaultValue(2.0f)]
        public float HeightPoMAmplitude
        {
            get => _Material.GetSafeFloat(Property.HeightPoMAmplitude, PropertyRange.HeightPoMAmplitude.defaultValue);
            set => _Material.SetSafeFloat(Property.HeightPoMAmplitude, PropertyRange.HeightPoMAmplitude, value);
        }

        /// <summary>Detail Map</summary>
        public Texture2D DetailMap
        {
            get => _Material.GetSafeTexture(Property.DetailMap);
            set
            {
                _Material.SetSafeTexture(Property.DetailMap, value);

                _Material.SetSafeKeyword(Keyword.DetailMap, value != null);
            }
        }

        /// <summary>Detail Albedo Scale</summary>
        //[Range(0.0f, 2.0f)]
        //[DefaultValue(1.0f)]
        public float DetailAlbedoScale
        {
            get => _Material.GetSafeFloat(Property.DetailAlbedoScale, PropertyRange.DetailAlbedoScale.defaultValue);
            set => _Material.SetSafeFloat(Property.DetailAlbedoScale, PropertyRange.DetailAlbedoScale, value);
        }

        /// <summary>Detail Normal Scale</summary>
        //[Range(0.0f, 2.0f)]
        //[DefaultValue(1.0f)]
        public float DetailNormalScale
        {
            get => _Material.GetSafeFloat(Property.DetailNormalScale, PropertyRange.DetailNormalScale.defaultValue);
            set => _Material.SetSafeFloat(Property.DetailNormalScale, PropertyRange.DetailNormalScale, value);
        }

        /// <summary>Detail Smoothness Scale</summary>
        //[Range(0.0f, 2.0f)]
        //[DefaultValue(1.0f)]
        public float DetailSmoothnessScale
        {
            get => _Material.GetSafeFloat(Property.DetailSmoothnessScale, PropertyRange.DetailSmoothnessScale.defaultValue);
            set => _Material.SetSafeFloat(Property.DetailSmoothnessScale, PropertyRange.DetailSmoothnessScale, value);
        }

        /// <summary>Tangent Map</summary>
        public Texture2D TangentMap
        {
            get => _Material.GetSafeTexture(Property.TangentMap);
            set
            {
                _Material.SetSafeTexture(Property.TangentMap, value);

                if (NormalMapSpace == NormalMapSpace.TangentSpace)
                {
                    _Material.SetSafeKeyword(Keyword.TangentMap, value != null);
                }
            }
        }

        /// <summary>Tangent Map Object Space</summary>
        public Texture2D TangentMapOS
        {
            get => _Material.GetSafeTexture(Property.TangentMapOS);
            set
            {
                _Material.SetSafeTexture(Property.TangentMapOS, value);

                if (NormalMapSpace == NormalMapSpace.ObjectSpace)
                {
                    _Material.SetSafeKeyword(Keyword.TangentMap, value != null);
                }
            }
        }

        /// <summary>Anisotropy</summary>
        //[Range(-1.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float Anisotropy
        {
            get => _Material.GetSafeFloat(Property.Anisotropy, PropertyRange.Anisotropy.defaultValue);
            set => _Material.SetSafeFloat(Property.Anisotropy, PropertyRange.Anisotropy, value);
        }

        /// <summary>Anisotropy Map</summary>
        public Texture2D AnisotropyMap
        {
            get => _Material.GetSafeTexture(Property.AnisotropyMap);
            set
            {
                _Material.SetSafeTexture(Property.AnisotropyMap, value);

                _Material.SetSafeKeyword(Keyword.AnisotropyMap, value != null);
            }
        }

        /// <summary>Subsurface Radius</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float SubsurfaceMask
        {
            get => _Material.GetSafeFloat(Property.SubsurfaceMask, PropertyRange.SubsurfaceMask.defaultValue);
            set => _Material.SetSafeFloat(Property.SubsurfaceMask, PropertyRange.SubsurfaceMask, value);
        }

        /// <summary>Subsurface Radius Map</summary>
        public Texture2D SubsurfaceMaskMap
        {
            get => _Material.GetSafeTexture(Property.SubsurfaceMaskMap);
            set
            {
                _Material.SetSafeTexture(Property.SubsurfaceMaskMap, value);

                _Material.SetSafeKeyword(Keyword.SubsurfaceMaskMap, value != null);
            }
        }

        /// <summary>Thickness</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float Thickness
        {
            get => _Material.GetSafeFloat(Property.Thickness, PropertyRange.Thickness.defaultValue);
            set => _Material.SetSafeFloat(Property.Thickness, PropertyRange.Thickness, value);
        }

        /// <summary>Thickness Map</summary>
        public Texture2D ThicknessMap
        {
            get => _Material.GetSafeTexture(Property.ThicknessMap);
            set
            {
                _Material.SetSafeTexture(Property.ThicknessMap, value);

                _Material.SetSafeKeyword(Keyword.ThicknessMap, value != null);
            }
        }

        /// <summary>Thickness Remap</summary>
        //[DefaultValue(0, 1, 0, 0)]
        public Vector4 ThicknessRemap
        {
            get => _Material.GetSafeVector4(Property.ThicknessRemap, new Vector4(0, 1, 0, 0));
            set => _Material.SetSafeVector(Property.ThicknessRemap, value);
        }

        /// <summary>Iridescence Thickness</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float IridescenceThickness
        {
            get => _Material.GetSafeFloat(Property.IridescenceThickness, PropertyRange.IridescenceThickness.defaultValue);
            set => _Material.SetSafeFloat(Property.IridescenceThickness, PropertyRange.IridescenceThickness, value);
        }

        /// <summary>Iridescence Thickness Map</summary>
        public Texture2D IridescenceThicknessMap
        {
            get => _Material.GetSafeTexture(Property.IridescenceThicknessMap);
            set
            {
                _Material.SetSafeTexture(Property.IridescenceThicknessMap, value);

                _Material.SetSafeKeyword(Keyword.IridescenceThicknessMap, value != null);
            }
        }

        /// <summary>Iridescence Thickness Remap</summary>
        //[DefaultValue(0, 1, 0, 0)]
        public Vector4 IridescenceThicknessRemap
        {
            get => _Material.GetSafeVector4(Property.IridescenceThicknessRemap, new Vector4(0, 1, 0, 0));
            set => _Material.SetSafeVector(Property.IridescenceThicknessRemap, value);
        }

        /// <summary>Iridescence Mask</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float IridescenceMask
        {
            get => _Material.GetSafeFloat(Property.IridescenceMask, PropertyRange.IridescenceMask.defaultValue);
            set => _Material.SetSafeFloat(Property.IridescenceMask, PropertyRange.IridescenceMask, value);
        }

        /// <summary>Iridescence Mask Map</summary>
        public Texture2D IridescenceMaskMap
        {
            get => _Material.GetSafeTexture(Property.IridescenceMaskMap);
            set => _Material.SetSafeTexture(Property.IridescenceMaskMap, value);
        }

        /// <summary>Coat Mask</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float CoatMask
        {
            get => _Material.GetSafeFloat(Property.CoatMask, PropertyRange.CoatMask.defaultValue);
            set => _Material.SetSafeFloat(Property.CoatMask, PropertyRange.CoatMask, value);
        }

        /// <summary>Coat Mask Map</summary>
        public Texture2D CoatMaskMap
        {
            get => _Material.GetSafeTexture(Property.CoatMaskMap);
            set => _Material.SetSafeTexture(Property.CoatMaskMap, value);
        }

        /// <summary>Energy Conserving Specular Color</summary>
        //[DefaultValue(1.0f)]
        public float EnergyConservingSpecularColor
        {
            get => _Material.GetSafeFloat(Property.EnergyConservingSpecularColor, PropertyRange.EnergyConservingSpecularColor.defaultValue);
            set => _Material.SetSafeFloat(Property.EnergyConservingSpecularColor, PropertyRange.EnergyConservingSpecularColor, value);
        }

        /// <summary>Specular Color</summary>
        public Color SpecularColor
        {
            get => _Material.GetSafeColor(Property.SpecularColor);
            set => _Material.SetSafeColor(Property.SpecularColor, value);
        }

        /// <summary>Specular Color Map</summary>
        public Texture2D SpecularColorMap
        {
            get => _Material.GetSafeTexture(Property.SpecularColorMap);
            set
            {
                _Material.SetSafeTexture(Property.SpecularColorMap, value);

                _Material.SetSafeKeyword(Keyword.SpecularColorMap, value != null);
            }
        }

        /// <summary>Specular Occlusion Mode</summary>
        //[DefaultValue(SpecularOcclusionMode.FromAmbientOcclusion)]
        public SpecularOcclusionMode SpecularOcclusionMode
        {
            get => _Material.GetSafeEnum<SpecularOcclusionMode>(Property.SpecularOcclusionMode, SpecularOcclusionMode.FromAmbientOcclusion);
            set
            {
                _Material.SetSafeInt(Property.SpecularOcclusionMode, (int)value);

                // @deprecated
                _Material.SetSafeKeyword(Keyword.EnableSpecularOcclusion, false);

                // @notice
                _Material.SetSafeKeyword(Keyword.SpecularOcclusionNone, value == SpecularOcclusionMode.Off);

                _Material.SetSafeKeyword(Keyword.SpecularOcclusionFromBentNormalMap, value == SpecularOcclusionMode.FromBentNormals);
            }
        }

        ///// <summary>Emissive Color</summary>
        //public Color EmissiveColor
        //{
        //    get => _Material.GetSafeColor(Property.EmissiveColor);
        //    set => _Material.SetSafeColor(Property.EmissiveColor, value);
        //}

        /// <summary>Emissive Color LDR</summary>
        public Color EmissiveColorLDR
        {
            get => _Material.GetSafeColor(Property.EmissiveColorLDR);
            set => _Material.SetSafeColor(Property.EmissiveColorLDR, value);
        }

        /// <summary>Emissive Color Map</summary>
        public Texture2D EmissiveColorMap
        {
            get => _Material.GetSafeTexture(Property.EmissiveColorMap);
            set
            {
                _Material.SetSafeTexture(Property.EmissiveColorMap, value);

                _Material.SetSafeKeyword(Keyword.EmissiveColorMap, value != null);
            }
        }

        /// <summary>Albedo Affect Emissive</summary>
        //[DefaultValue(1.0f)]
        public float AlbedoAffectEmissive
        {
            get => _Material.GetSafeFloat(Property.AlbedoAffectEmissive, PropertyRange.AlbedoAffectEmissive.defaultValue);
            set => _Material.SetSafeFloat(Property.AlbedoAffectEmissive, PropertyRange.AlbedoAffectEmissive, value);
        }

        /// <summary>Emissive Mode</summary>
        //[DefaultValue(0)]
        public int EmissiveIntensityUnit
        {
            get => _Material.GetSafeInt(Property.EmissiveIntensityUnit, 0);
            set => _Material.SetSafeInt(Property.EmissiveIntensityUnit, value);
        }

        /// <summary>Use Emissive Intensity</summary>
        //[DefaultValue(false)]
        public bool UseEmissiveIntensity
        {
            get => _Material.GetSafeBool(Property.UseEmissiveIntensity, false);
            set => _Material.SetSafeBool(Property.UseEmissiveIntensity, value);
        }

        /// <summary>Emissive Intensity</summary>
        //[DefaultValue(1.0f)]
        public float EmissiveIntensity
        {
            get => _Material.GetSafeFloat(Property.EmissiveIntensity, PropertyRange.EmissiveIntensity.defaultValue);
            set => _Material.SetSafeFloat(Property.EmissiveIntensity, PropertyRange.EmissiveIntensity, value);
        }

        /// <summary>Emissive Pre Exposure</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float EmissiveExposureWeight
        {
            get => _Material.GetSafeFloat(Property.EmissiveExposureWeight, PropertyRange.EmissiveExposureWeight.defaultValue);
            set => _Material.SetSafeFloat(Property.EmissiveExposureWeight, PropertyRange.EmissiveExposureWeight, value);
        }

        /// <summary>Distortion Vector Map</summary>
        public Texture2D DistortionVectorMap
        {
            get => _Material.GetSafeTexture(Property.DistortionVectorMap);
            set => _Material.SetSafeTexture(Property.DistortionVectorMap, value);
        }

        /// <summary>Enable Distortion</summary>
        //[DefaultValue(false)]
        public bool DistortionEnable
        {
            get => _Material.GetSafeBool(Property.DistortionEnable, false);
            set => _Material.SetSafeBool(Property.DistortionEnable, value);
        }

        /// <summary>Distortion Depth Test Enable</summary>
        //[DefaultValue(true)]
        public bool DistortionDepthTest
        {
            get => _Material.GetSafeBool(Property.DistortionDepthTest, true);
            set => _Material.SetSafeBool(Property.DistortionDepthTest, value);
        }

        /// <summary>Distortion Blend Mode</summary>
        //[DefaultValue(DistortionBlendMode.Add)]
        public DistortionBlendMode DistortionBlendMode
        {
            get => _Material.GetSafeEnum<DistortionBlendMode>(Property.DistortionBlendMode, DistortionBlendMode.Add);
            set => SetDistortionBlendMode(value);
        }

        /// <summary>Distortion Blend Src</summary>
        //[DefaultValue(0)]
        public UnityEngine.Rendering.BlendMode DistortionSrcBlend
        {
            get => _Material.GetSafeEnum<UnityEngine.Rendering.BlendMode>(Property.DistortionSrcBlend, UnityEngine.Rendering.BlendMode.Zero);
            private set => _Material.SetSafeInt(Property.DistortionSrcBlend, (int)value);
        }

        /// <summary>Distortion Blend Dst</summary>
        //[DefaultValue(0)]
        public UnityEngine.Rendering.BlendMode DistortionDstBlend
        {
            get => _Material.GetSafeEnum<UnityEngine.Rendering.BlendMode>(Property.DistortionDstBlend, UnityEngine.Rendering.BlendMode.Zero);
            private set => _Material.SetSafeInt(Property.DistortionDstBlend, (int)value);
        }

        /// <summary>Distortion Blur Blend Src</summary>
        //[DefaultValue(0)]
        public UnityEngine.Rendering.BlendMode DistortionBlurSrcBlend
        {
            get => _Material.GetSafeEnum<UnityEngine.Rendering.BlendMode>(Property.DistortionBlurSrcBlend, UnityEngine.Rendering.BlendMode.Zero);
            private set => _Material.SetSafeInt(Property.DistortionBlurSrcBlend, (int)value);
        }

        /// <summary>Distortion Blur Blend Dst</summary>
        //[DefaultValue(0)]
        public UnityEngine.Rendering.BlendMode DistortionBlurDstBlend
        {
            get => _Material.GetSafeEnum<UnityEngine.Rendering.BlendMode>(Property.DistortionBlurDstBlend, UnityEngine.Rendering.BlendMode.Zero);
            private set => _Material.SetSafeInt(Property.DistortionBlurDstBlend, (int)value);
        }

        /// <summary>Distortion Blur Blend Operator</summary>
        //[DefaultValue(0)]
        public BlendOp DistortionBlurBlendOp
        {
            get => _Material.GetSafeEnum<BlendOp>(Property.DistortionBlurBlendOp, BlendOp.Add);
            private set => _Material.SetSafeInt(Property.DistortionBlurBlendOp, (int)value);
        }

        /// <summary>Distortion Scale</summary>
        //[DefaultValue(1.0f)]
        public float DistortionScale
        {
            get => _Material.GetSafeFloat(Property.DistortionScale, PropertyRange.DistortionScale.defaultValue);
            set => _Material.SetSafeFloat(Property.DistortionScale, PropertyRange.DistortionScale, value);
        }

        /// <summary>Distortion Vector Scale</summary>
        //[DefaultValue(2.0f)]
        public float DistortionVectorScale
        {
            get => _Material.GetSafeFloat(Property.DistortionVectorScale, PropertyRange.DistortionVectorScale.defaultValue);
            set => _Material.SetSafeFloat(Property.DistortionVectorScale, PropertyRange.DistortionVectorScale, value);
        }

        /// <summary>Distortion Vector Bias</summary>
        //[DefaultValue(-1.0f)]
        public float DistortionVectorBias
        {
            get => _Material.GetSafeFloat(Property.DistortionVectorBias, PropertyRange.DistortionVectorBias.defaultValue);
            set => _Material.SetSafeFloat(Property.DistortionVectorBias, PropertyRange.DistortionVectorBias, value);
        }

        /// <summary>Distortion Blur Scale</summary>
        //[DefaultValue(1.0f)]
        public float DistortionBlurScale
        {
            get => _Material.GetSafeFloat(Property.DistortionBlurScale, PropertyRange.DistortionBlurScale.defaultValue);
            set => _Material.SetSafeFloat(Property.DistortionBlurScale, PropertyRange.DistortionBlurScale, value);
        }

        /// <summary>Distortion Blur Remap Min</summary>
        //[DefaultValue(0.0f)]
        public float DistortionBlurRemapMin
        {
            get => _Material.GetSafeFloat(Property.DistortionBlurRemapMin, PropertyRange.DistortionBlurRemapMin.defaultValue);
            set => _Material.SetSafeFloat(Property.DistortionBlurRemapMin, PropertyRange.DistortionBlurRemapMin, value);
        }

        /// <summary>Distortion Blur Remap Max</summary>
        //[DefaultValue(1.0f)]
        public float DistortionBlurRemapMax
        {
            get => _Material.GetSafeFloat(Property.DistortionBlurRemapMax, PropertyRange.DistortionBlurRemapMax.defaultValue);
            set => _Material.SetSafeFloat(Property.DistortionBlurRemapMax, PropertyRange.DistortionBlurRemapMax, value);
        }

        /// <summary>Alpha Cutoff</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float AlphaCutoff
        {
            get => _Material.GetSafeFloat(Property.AlphaCutoff, PropertyRange.AlphaCutoff.defaultValue);
            set => _Material.SetSafeFloat(Property.AlphaCutoff, PropertyRange.AlphaCutoff, value);
        }

        /// <summary>Alpha Cutoff Shadow</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float AlphaCutoffShadow
        {
            get => _Material.GetSafeFloat(Property.AlphaCutoffShadow, PropertyRange.AlphaCutoffShadow.defaultValue);
            set => _Material.SetSafeFloat(Property.AlphaCutoffShadow, PropertyRange.AlphaCutoffShadow, value);
        }

        /// <summary>Alpha Cutoff Prepass</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float AlphaCutoffPrepass
        {
            get => _Material.GetSafeFloat(Property.AlphaCutoffPrepass, PropertyRange.AlphaCutoffPrepass.defaultValue);
            set => _Material.SetSafeFloat(Property.AlphaCutoffPrepass, PropertyRange.AlphaCutoffPrepass, value);
        }

        /// <summary>Alpha Cutoff Postpass</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float AlphaCutoffPostpass
        {
            get => _Material.GetSafeFloat(Property.AlphaCutoffPostpass, PropertyRange.AlphaCutoffPostpass.defaultValue);
            set => _Material.SetSafeFloat(Property.AlphaCutoffPostpass, PropertyRange.AlphaCutoffPostpass, value);
        }

        /// <summary>Refraction Model</summary>
        //[DefaultValue(RefractionModel.None)]
        public RefractionModel RefractionModel
        {
            get => _Material.GetSafeEnum<RefractionModel>(Property.RefractionModel, RefractionModel.None);
            set
            {
                if (_Material.HasProperty(Property.RefractionModel))
                {
                    _Material.SetSafeInt(Property.RefractionModel, (int)value);

                    // @notice
                    bool canHaveRefraction = SurfaceType == SurfaceType.Transparent;

                    _Material.SetSafeKeyword(Keyword.RefractionPlane, canHaveRefraction && value == RefractionModel.Box);

                    _Material.SetSafeKeyword(Keyword.RefractionSphere, canHaveRefraction && value == RefractionModel.Sphere);

                    _Material.SetSafeKeyword(Keyword.RefractionThin, canHaveRefraction && value == RefractionModel.Thin);
                }
            }
        }

        /// <summary>Index Of Refraction</summary>
        //[Range(1.0f, 2.5f)]
        //[DefaultValue(1.5f)]
        public float Ior
        {
            get => _Material.GetSafeFloat(Property.Ior, PropertyRange.Ior.defaultValue);
            set => _Material.SetSafeFloat(Property.Ior, PropertyRange.Ior, value);
        }

        /// <summary>Transmittance Color</summary>
        public Color TransmittanceColor
        {
            get => _Material.GetSafeColor(Property.TransmittanceColor);
            set => _Material.SetSafeColor(Property.TransmittanceColor, value);
        }

        /// <summary>Transmittance Color Map</summary>
        public Texture2D TransmittanceColorMap
        {
            get => _Material.GetSafeTexture(Property.TransmittanceColorMap);
            set
            {
                _Material.SetSafeTexture(Property.TransmittanceColorMap, value);

                if (_Material.HasProperty(Property.RefractionModel))
                {
                    // @notice
                    bool canHaveRefraction = SurfaceType == SurfaceType.Transparent;

                    _Material.SetSafeKeyword(Keyword.TransmittanceColorMap, canHaveRefraction && value != null);
                }
            }
        }

        /// <summary>Transmittance Absorption Distance</summary>
        //[DefaultValue(1.0f)]
        public float ATDistance
        {
            get => _Material.GetSafeFloat(Property.ATDistance, PropertyRange.ATDistance.defaultValue);
            set => _Material.SetSafeFloat(Property.ATDistance, PropertyRange.ATDistance, value);
        }

        /// <summary>ZTest Mode Distortion</summary>
        //[DefaultValue(4)]
        public int ZTestModeDistortion
        {
            get => _Material.GetSafeInt(Property.ZTestModeDistortion, 4);
            set => _Material.SetSafeInt(Property.ZTestModeDistortion, value);
        }

        /// <summary>UV Set for base</summary>
        //[DefaultValue(UVBaseMapping.UV0)]
        public UVBaseMapping UVBase
        {
            get => _Material.GetSafeEnum<UVBaseMapping>(Property.UVBase, UVBaseMapping.UV0);
            set
            {
                _Material.SetSafeInt(Property.UVBase, (int)value);

                _Material.SetSafeKeyword(Keyword.MappingPlanar, value == UVBaseMapping.Planar);

                _Material.SetSafeKeyword(Keyword.MappingTriplanar, value == UVBaseMapping.Triplanar);

                SetRequreUVKeywords(value, UVDetail);
            }
        }

        /// <summary>Scale to apply on world coordinate</summary>
        //[DefaultValue(1.0f)]
        public float TexWorldScale
        {
            get => _Material.GetSafeFloat(Property.TexWorldScale, PropertyRange.TexWorldScale.defaultValue);
            set => _Material.SetSafeFloat(Property.TexWorldScale, PropertyRange.TexWorldScale, value);
        }

        /// <summary>Inverse tiling scale</summary>
        /// <remarks>2 / (abs(_BaseColorMap_ST.x) + abs(_BaseColorMap_ST.y))</remarks>
        //[DefaultValue(1.0f)]
        public float InvTilingScale
        {
            get => _Material.GetSafeFloat(Property.InvTilingScale, PropertyRange.InvTilingScale.defaultValue);
            set => _Material.SetSafeFloat(Property.InvTilingScale, PropertyRange.InvTilingScale, value);
        }

        /// <summary>UV Mapping Mask</summary>
        public Color UVMappingMask
        {
            get => _Material.GetSafeColor(Property.UVMappingMask);
            set => _Material.SetSafeColor(Property.UVMappingMask, value);
        }

        /// <summary>Normal Map space</summary>
        //[DefaultValue(NormalMapSpace.TangentSpace)]
        public NormalMapSpace NormalMapSpace
        {
            get => _Material.GetSafeEnum<NormalMapSpace>(Property.NormalMapSpace, NormalMapSpace.TangentSpace);
            set
            {
                _Material.SetSafeInt(Property.NormalMapSpace, (int)value);

                _Material.SetSafeKeyword(Keyword.NormalMapTangentSpace, value == NormalMapSpace.TangentSpace);

                if (value == NormalMapSpace.TangentSpace)
                {
                    _Material.SetSafeKeyword(Keyword.NormalMap, (NormalMap != null) || (DetailMap != null));

                    _Material.SetSafeKeyword(Keyword.TangentMap, TangentMap != null);

                    _Material.SetSafeKeyword(Keyword.BentNormalMap, BentNormalMap != null);
                }
                else  // NormalMapSpace.ObjectSpace
                {
                    _Material.SetSafeKeyword(Keyword.NormalMap, NormalMapOS != null);

                    _Material.SetSafeKeyword(Keyword.TangentMap, TangentMapOS != null);

                    _Material.SetSafeKeyword(Keyword.BentNormalMap, BentNormalMapOS != null);
                }
            }
        }

        /// <summary>Material ID</summary>
        //[DefaultValue(MaterialId.LitStandard)]
        public MaterialId MaterialID
        {
            get => _Material.GetSafeEnum<MaterialId>(Property.MaterialID, MaterialId.LitStandard);
            set
            {
                _Material.SetSafeInt(Property.MaterialID, (int)value);

                _Material.SetSafeKeyword(Keyword.MaterialFeatureSubsurfaceScattering, value == MaterialId.LitSSS);

                _Material.SetSafeKeyword(Keyword.MaterialFeatureTransmission, (value == MaterialId.LitTranslucent) || ((value == MaterialId.LitSSS) && TransmissionEnable));

                _Material.SetSafeKeyword(Keyword.MaterialFeatureAnisotropy, value == MaterialId.LitAniso);

                _Material.SetSafeKeyword(Keyword.MaterialFeatureClearCoat, (CoatMask > 0.0f) || (CoatMaskMap != null));

                _Material.SetSafeKeyword(Keyword.MaterialFeatureIridscence, value == MaterialId.LitIridescence);

                _Material.SetSafeKeyword(Keyword.MaterialFeatureSpecularColor, value == MaterialId.LitSpecular);
            }
        }

        /// <summary>Transmission Enable</summary>
        //[DefaultValue(true)]
        public bool TransmissionEnable
        {
            get => _Material.GetSafeBool(Property.TransmissionEnable, true);
            set => _Material.SetSafeBool(Property.TransmissionEnable, value);
        }

        /// <summary>Displacement Mode</summary>
        //[DefaultValue(DisplacementMode.None)]
        public DisplacementMode DisplacementMode
        {
            get => _Material.GetSafeEnum<DisplacementMode>(Property.DisplacementMode, DisplacementMode.None);
            set
            {
                _Material.SetSafeInt(Property.DisplacementMode, (int)value);

                _Material.SetSafeKeyword(Keyword.VertexDisplacement, value == DisplacementMode.Vertex);

                _Material.SetSafeKeyword(Keyword.PixelDisplacement, value == DisplacementMode.Pixel);

                _Material.SetSafeKeyword(Keyword.TessellationDisplacement, value == DisplacementMode.Tessellation);

                SetDisplacementLockObjectScaleKeyoword(value, DisplacementLockObjectScale);

                SetDisplacementLockTilingScaleKeyoword(value, DisplacementLockTilingScale);

                SetDepthOffsetOnKeyoword(value, DepthOffsetEnable);
            }
        }

        /// <summary>displacement lock object scale</summary>
        //[DefaultValue(1.0f)]
        public float DisplacementLockObjectScale
        {
            get => _Material.GetSafeFloat(Property.DisplacementLockObjectScale, PropertyRange.DisplacementLockObjectScale.defaultValue);
            set
            {
                _Material.SetSafeFloat(Property.DisplacementLockObjectScale, PropertyRange.DisplacementLockObjectScale, value);

                SetDisplacementLockObjectScaleKeyoword(DisplacementMode, value);
            }
        }

        /// <summary>displacement lock tiling scale</summary>
        //[DefaultValue(1.0f)]
        public float DisplacementLockTilingScale
        {
            get => _Material.GetSafeFloat(Property.DisplacementLockTilingScale, PropertyRange.DisplacementLockTilingScale.defaultValue);
            set
            {
                _Material.SetSafeFloat(Property.DisplacementLockTilingScale, PropertyRange.DisplacementLockTilingScale, value);

                SetDisplacementLockTilingScaleKeyoword(DisplacementMode, value);
            }
        }

        /// <summary>Enable Geometric Specular AA</summary>
        //[DefaultValue(false)]
        public bool EnableGeometricSpecularAA
        {
            get => _Material.GetSafeBool(Property.EnableGeometricSpecularAA, false);
            set
            {
                _Material.SetSafeBool(Property.EnableGeometricSpecularAA, value);

                _Material.SetSafeKeyword(Keyword.EnableGeometricSpecularAa, value == true);
            }
        }

        /// <summary>Specular AA Screen Space Variance</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.1f)]
        public float SpecularAAScreenSpaceVariance
        {
            get => _Material.GetSafeFloat(Property.SpecularAAScreenSpaceVariance, PropertyRange.SpecularAAScreenSpaceVariance.defaultValue);
            set => _Material.SetSafeFloat(Property.SpecularAAScreenSpaceVariance, PropertyRange.SpecularAAScreenSpaceVariance, value);
        }

        /// <summary>Specular AA Threshold</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.2f)]
        public float SpecularAAThreshold
        {
            get => _Material.GetSafeFloat(Property.SpecularAAThreshold, PropertyRange.SpecularAAThreshold.defaultValue);
            set => _Material.SetSafeFloat(Property.SpecularAAThreshold, PropertyRange.SpecularAAThreshold, value);
        }

        /// <summary>Min sample for POM</summary>
        //[Range(1.0f, 64.0f)]
        //[DefaultValue(5.0f)]
        public float PPDMinSamples
        {
            get => _Material.GetSafeFloat(Property.PPDMinSamples, PropertyRange.PPDMinSamples.defaultValue);
            set => _Material.SetSafeFloat(Property.PPDMinSamples, PropertyRange.PPDMinSamples, value);
        }

        /// <summary>Max sample for POM</summary>
        //[Range(1.0f, 64.0f)]
        //[DefaultValue(15.0f)]
        public float PPDMaxSamples
        {
            get => _Material.GetSafeFloat(Property.PPDMaxSamples, PropertyRange.PPDMaxSamples.defaultValue);
            set => _Material.SetSafeFloat(Property.PPDMaxSamples, PropertyRange.PPDMaxSamples, value);
        }

        /// <summary>Start lod to fade out the POM effect</summary>
        //[Range(0.0f, 16.0f)]
        //[DefaultValue(5.0f)]
        public float PPDLodThreshold
        {
            get => _Material.GetSafeFloat(Property.PPDLodThreshold, PropertyRange.PPDLodThreshold.defaultValue);
            set => _Material.SetSafeFloat(Property.PPDLodThreshold, PropertyRange.PPDLodThreshold, value);
        }

        /// <summary>Primitive length for POM</summary>
        //[DefaultValue(1)]
        public float PPDPrimitiveLength
        {
            get => _Material.GetSafeFloat(Property.PPDPrimitiveLength, PropertyRange.PPDPrimitiveLength.defaultValue);
            set => _Material.SetSafeFloat(Property.PPDPrimitiveLength, PropertyRange.PPDPrimitiveLength, value);
        }

        /// <summary>Primitive width for POM</summary>
        //[DefaultValue(1)]
        public float PPDPrimitiveWidth
        {
            get => _Material.GetSafeFloat(Property.PPDPrimitiveWidth, PropertyRange.PPDPrimitiveWidth.defaultValue);
            set => _Material.SetSafeFloat(Property.PPDPrimitiveWidth, PropertyRange.PPDPrimitiveWidth, value);
        }

        /// <summary>Inverse primitive scale for non-planar POM</summary>
        //[DefaultValue(1, 1, 0, 0)]
        public Vector4 InvPrimScale
        {
            get => _Material.GetSafeVector4(Property.InvPrimScale, new Vector4(1, 1, 0, 0));
            set => _Material.SetSafeVector(Property.InvPrimScale, value);
        }

        /// <summary>UV Set for detail</summary>
        //[DefaultValue(UVDetailMapping.UV0)]
        public UVDetailMapping UVDetail
        {
            get => _Material.GetSafeEnum<UVDetailMapping>(Property.UVDetail, UVDetailMapping.UV0);
            set
            {
                _Material.SetSafeInt(Property.UVDetail, (int)value);

                SetRequreUVKeywords(UVBase, value);
            }
        }

        /// <summary>UVDetailsMappingMask</summary>
        //[DefaultValue(1, 0, 0, 0)]
        public Vector4 UVDetailsMappingMask
        {
            get => _Material.GetSafeVector4(Property.UVDetailsMappingMask, new Vector4(1, 0, 0, 0));
            set => _Material.SetSafeVector(Property.UVDetailsMappingMask, value);
        }

        /// <summary>Link Details with Base</summary>
        //[DefaultValue(true)]
        public bool LinkDetailsWithBase
        {
            get => _Material.GetSafeBool(Property.LinkDetailsWithBase, true);
            set => _Material.SetSafeBool(Property.LinkDetailsWithBase, value);
        }

        /// <summary>Emissive color mode</summary>
        //[DefaultValue(EmissiveColorMode.UseEmissiveMask)]
        public EmissiveColorMode EmissiveColorMode
        {
            get => _Material.GetSafeEnum<EmissiveColorMode>(Property.EmissiveColorMode, EmissiveColorMode.UseEmissiveMask);
            set => _Material.SetSafeInt(Property.EmissiveColorMode, (int)value);
        }

        /// <summary>UV Set for emissive</summary>
        //[DefaultValue(UVEmissiveMapping.UV0)]
        public UVEmissiveMapping UVEmissive
        {
            get => _Material.GetSafeEnum<UVEmissiveMapping>(Property.UVEmissive, UVEmissiveMapping.UV0);
            set
            {
                _Material.SetSafeInt(Property.UVEmissive, (int)value);

                _Material.SetSafeKeyword(Keyword.EmissiveMappingPlanar, value == UVEmissiveMapping.Planar);

                _Material.SetSafeKeyword(Keyword.EmissiveMappingTriplanar, value == UVEmissiveMapping.Triplanar);

                _Material.SetSafeKeyword(Keyword.EmissiveMappingBase, value == UVEmissiveMapping.SameAsBase);
            }
        }

        /// <summary>Scale to apply on world coordinate</summary>
        //[DefaultValue(1.0f)]
        public float TexWorldScaleEmissive
        {
            get => _Material.GetSafeFloat(Property.TexWorldScaleEmissive, PropertyRange.TexWorldScaleEmissive.defaultValue);
            set => _Material.SetSafeFloat(Property.TexWorldScaleEmissive, PropertyRange.TexWorldScaleEmissive, value);
        }

        /// <summary>UV Mapping Mask Emissive</summary>
        public Color UVMappingMaskEmissive
        {
            get => _Material.GetSafeColor(Property.UVMappingMaskEmissive);
            set => _Material.SetSafeColor(Property.UVMappingMaskEmissive, value);
        }

        /// <summary>Emission Color</summary>
        public Color EmissionColor
        {
            get => _Material.GetSafeColor(Property.EmissionColor);
            set => _Material.SetSafeColor(Property.EmissionColor, value);
        }

        /// <summary>Albedo</summary>
        public Texture2D MainTex
        {
            get => _Material.GetSafeTexture(Property.MainTex);
            set => _Material.SetSafeTexture(Property.MainTex, value);
        }

        /// <summary>Color</summary>
        public Color Color
        {
            get => _Material.GetSafeColor(Property.Color);
            set => _Material.SetSafeColor(Property.Color, value);
        }

        /// <summary>Alpha Cutoff</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float Cutoff
        {
            get => _Material.GetSafeFloat(Property.Cutoff, PropertyRange.Cutoff.defaultValue);
            set => _Material.SetSafeFloat(Property.Cutoff, PropertyRange.Cutoff, value);
        }

        /// <summary>Add Precomputed Velocity</summary>
        //[DefaultValue(false)]
        public bool AddPrecomputedVelocity
        {
            get => _Material.GetSafeBool(Property.AddPrecomputedVelocity, false);
            set
            {
                _Material.SetSafeBool(Property.AddPrecomputedVelocity, value);

                _Material.SetSafeKeyword(Keyword.AddPrecomputedVelocity, value == true);
            }
        }

        /// <summary>Ray Tracing (Preview)</summary>
        //[DefaultValue(false)]
        public bool RayTracing
        {
            get => _Material.GetSafeBool(Property.RayTracing, false);
            set => _Material.SetSafeBool(Property.RayTracing, value);
        }

        /// <summary></summary>
        /// <remarks>Obsolete, kept for migration purpose</remarks>
        [Obsolete("Obsolete")]
        public int DiffusionProfile
        {
            get => _Material.GetSafeInt(Property.DiffusionProfile);
            set => _Material.SetSafeInt(Property.DiffusionProfile, value);
        }

        /// <summary>Diffusion Profile Asset</summary>
        //[DefaultValue(0, 0, 0, 0)]
        public Vector4 DiffusionProfileAsset
        {
            get => _Material.GetSafeVector4(Property.DiffusionProfileAsset, Vector4.zero);
            set => _Material.SetSafeVector(Property.DiffusionProfileAsset, value);
        }

        /// <summary>Diffusion Profile Hash</summary>
        //[DefaultValue(0)]
        public float DiffusionProfileHash
        {
            get => _Material.GetSafeFloat(Property.DiffusionProfileHash, PropertyRange.DiffusionProfileHash.defaultValue);
            set => _Material.SetSafeFloat(Property.DiffusionProfileHash, PropertyRange.DiffusionProfileHash, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of HdrpLitMaterialProxy.
        /// </summary>
        /// <param name="material">The HDRP lit material.</param>
        public HdrpLitMaterialProxy(Material material) : base(material)
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

            if (material.shader.name != ShaderName.HDRP_Lit)
            {
                throw new ArgumentException();
            }
        }

        #endregion

        #region Private Methods (Set)

        private void SetDistortionBlendMode(DistortionBlendMode distortionBlendMode)
        {
            _Material.SetSafeInt(Property.DistortionBlendMode, (int)distortionBlendMode);

            switch (distortionBlendMode)
            {
                default:
                case DistortionBlendMode.Add:
                    DistortionSrcBlend = UnityEngine.Rendering.BlendMode.One;
                    DistortionDstBlend = UnityEngine.Rendering.BlendMode.One;

                    DistortionBlurSrcBlend = UnityEngine.Rendering.BlendMode.One;
                    DistortionBlurDstBlend = UnityEngine.Rendering.BlendMode.One;
                    DistortionBlurBlendOp = BlendOp.Add;
                    break;

                case DistortionBlendMode.Multiply:
                    DistortionSrcBlend = UnityEngine.Rendering.BlendMode.DstColor;
                    DistortionDstBlend = UnityEngine.Rendering.BlendMode.Zero;

                    DistortionBlurSrcBlend = UnityEngine.Rendering.BlendMode.DstAlpha;
                    DistortionBlurDstBlend = UnityEngine.Rendering.BlendMode.Zero;
                    DistortionBlurBlendOp = BlendOp.Add;
                    break;

                case DistortionBlendMode.Replace:
                    DistortionSrcBlend = UnityEngine.Rendering.BlendMode.One;
                    DistortionDstBlend = UnityEngine.Rendering.BlendMode.Zero;

                    DistortionBlurSrcBlend = UnityEngine.Rendering.BlendMode.One;
                    DistortionBlurDstBlend = UnityEngine.Rendering.BlendMode.Zero;
                    DistortionBlurBlendOp = BlendOp.Add;
                    break;
            }
        }

        private void SetDisplacementLockObjectScaleKeyoword(DisplacementMode displacementMode, float lockObjectScale)
        {
            bool enableLockObjectScale = lockObjectScale > 0.0f;

            _Material.SetSafeKeyword(Keyword.VertexDisplacementLockObjectScale, (displacementMode == DisplacementMode.Vertex || displacementMode == DisplacementMode.Tessellation) && enableLockObjectScale);

            _Material.SetSafeKeyword(Keyword.PixelDisplacementLockObjectScale, (displacementMode == DisplacementMode.Pixel) && enableLockObjectScale);
        }

        private void SetDisplacementLockTilingScaleKeyoword(DisplacementMode displacementMode, float lockTilingScale)
        {
            bool enableLockTilingScale = lockTilingScale > 0.0f;

            _Material.SetSafeKeyword(Keyword.DisplacementLockTilingScale, (displacementMode != DisplacementMode.None) && enableLockTilingScale);
        }

        private void SetDepthOffsetOnKeyoword(DisplacementMode displacementMode, bool depthOffsetEnable)
        {
            // Depth offset is only enabled if per pixel displacement is
            _Material.SetSafeKeyword(Keyword.DepthOffsetOn, (displacementMode == DisplacementMode.Pixel) && depthOffsetEnable);
        }

        private void SetRequreUVKeywords(UVBaseMapping uvBase, UVDetailMapping uvDetail)
        {
            bool needUV2 = (uvBase == UVBaseMapping.UV2) || (uvDetail == UVDetailMapping.UV2);
            bool needUV3 = (uvBase == UVBaseMapping.UV3) || (uvDetail == UVDetailMapping.UV3);

            if (needUV3)
            {
                _Material.SetSafeKeyword(Keyword.RequireUv2, false);
                _Material.SetSafeKeyword(Keyword.RequireUv3, true);
            }
            else if (needUV2)
            {
                _Material.SetSafeKeyword(Keyword.RequireUv2, true);
                _Material.SetSafeKeyword(Keyword.RequireUv3, false);
            }
            else
            {
                _Material.SetSafeKeyword(Keyword.RequireUv2, false);
                _Material.SetSafeKeyword(Keyword.RequireUv3, false);
            }
        }

        #endregion
    }
}