// ----------------------------------------------------------------------
// @Namespace : UniHdrpShader
// @Class     : Keyword
// ----------------------------------------------------------------------
namespace UniHdrpShader
{
    /// <summary>
    /// Keyword
    /// </summary>
    public class Keyword
    {
        /// <summary>Alpha Test On</summary>
        public const string AlphaTestOn = "_ALPHATEST_ON";

        /// <summary>Alpha to Mask On</summary>
        public const string AlphaToMaskOn = "_ALPHATOMASK_ON";

        /// <summary>Depth Offset On</summary>
        public const string DepthOffsetOn = "_DEPTHOFFSET_ON";

        /// <summary>Double Sided On</summary>
        public const string DoubleSidedOn = "_DOUBLESIDED_ON";

        /// <summary>Vertex Displacement</summary>
        public const string VertexDisplacement = "_VERTEX_DISPLACEMENT";

        /// <summary>Pixel Displacement</summary>
        public const string PixelDisplacement = "_PIXEL_DISPLACEMENT";

        /// <summary>Tessellation Displacement</summary>
        public const string TessellationDisplacement = "_TESSELLATION_DISPLACEMENT";

        /// <summary>Vertex Displacement Lock Object Scale</summary>
        public const string VertexDisplacementLockObjectScale = "_VERTEX_DISPLACEMENT_LOCK_OBJECT_SCALE";

        /// <summary>Displacement Lock Tiling Scale</summary>
        public const string DisplacementLockTilingScale = "_DISPLACEMENT_LOCK_TILING_SCALE";

        /// <summary>Pixel Displacement Lock Object Scale</summary>
        public const string PixelDisplacementLockObjectScale = "_PIXEL_DISPLACEMENT_LOCK_OBJECT_SCALE";

        /// <summary>Emissive Mapping Planar</summary>
        public const string EmissiveMappingPlanar = "_EMISSIVE_MAPPING_PLANAR";

        /// <summary>Emissive Mapping Triplanar</summary>
        public const string EmissiveMappingTriplanar = "_EMISSIVE_MAPPING_TRIPLANAR";

        /// <summary>Emissive Mapping Base</summary>
        public const string EmissiveMappingBase  = "_EMISSIVE_MAPPING_BASE";

        /// <summary>Mapping Planar</summary>
        public const string MappingPlanar = "_MAPPING_PLANAR";

        /// <summary>Mapping Triplanar</summary>
        public const string MappingTriplanar = "_MAPPING_TRIPLANAR";

        /// <summary>Normal Map Tangent Space</summary>
        public const string NormalMapTangentSpace = "_NORMALMAP_TANGENT_SPACE";

        /// <summary>Require UV2</summary>
        public const string RequireUv2 = "_REQUIRE_UV2";

        /// <summary>Require UV3</summary>
        public const string RequireUv3 = "_REQUIRE_UV3";

        /// <summary>Normal Map</summary>
        public const string NormalMap = "_NORMALMAP";

        /// <summary>Mask Map</summary>
        public const string MaskMap = "_MASKMAP";

        /// <summary>Bent Normal Map</summary>
        public const string BentNormalMap = "_BENTNORMALMAP";

        /// <summary>Emissive Color Map</summary>
        public const string EmissiveColorMap = "_EMISSIVE_COLOR_MAP";

        /// <summary>Enable Specular Occlusion</summary>
        public const string EnableSpecularOcclusion = "_ENABLESPECULAROCCLUSION";

        /// <summary>Specular Occlusion None</summary>
        public const string SpecularOcclusionNone = "_SPECULAR_OCCLUSION_NONE";

        /// <summary>Specular Occlusion from Bent Normal Map</summary>
        public const string SpecularOcclusionFromBentNormalMap = "_SPECULAR_OCCLUSION_FROM_BENT_NORMAL_MAP";

        /// <summary>Height Map</summary>
        public const string HeightMap = "_HEIGHTMAP";

        /// <summary>Tangent Map</summary>
        public const string TangentMap = "_TANGENTMAP";

        /// <summary>Anisotropy Map</summary>
        public const string AnisotropyMap = "_ANISOTROPYMAP";

        /// <summary>Detail Map</summary>
        public const string DetailMap = "_DETAIL_MAP";

        /// <summary>Subsurface Mask Map</summary>
        public const string SubsurfaceMaskMap = "_SUBSURFACE_MASK_MAP";

        /// <summary>Thickness Map</summary>
        public const string ThicknessMap = "_THICKNESSMAP";

        /// <summary>Iridescence Thickness Map</summary>
        public const string IridescenceThicknessMap = "_IRIDESCENCE_THICKNESSMAP";

        /// <summary>Specular Color Map</summary>
        public const string SpecularColorMap = "_SPECULARCOLORMAP";

        /// <summary>Transmittance Color Map</summary>
        public const string TransmittanceColorMap = "_TRANSMITTANCECOLORMAP";

        /// <summary>Disable Decals</summary>
        public const string DisableDecals = "_DISABLE_DECALS";

        /// <summary>Disable SSR</summary>
        public const string DisableSsr = "_DISABLE_SSR";

        /// <summary>Disable SSR Transparent</summary>
        public const string DisableSsrTransparent = "_DISABLE_SSR_TRANSPARENT";

        /// <summary>Enable Geometric Specular AA</summary>
        public const string EnableGeometricSpecularAa = "_ENABLE_GEOMETRIC_SPECULAR_AA";

        /// <summary>Surface Type Transparent</summary>
        public const string SurfaceTypeTransparent = "_SURFACE_TYPE_TRANSPARENT";

        /// <summary>Enable Fog on Transparent</summary>
        public const string EnableFogOnTransparent = "_ENABLE_FOG_ON_TRANSPARENT";

        /// <summary>Transparent Writes Motion Vec</summary>
        public const string TransparentWritesMotionVec = "_TRANSPARENT_WRITES_MOTION_VEC";

        /// <summary>Material Feature Subsurface Scattering</summary>
        public const string MaterialFeatureSubsurfaceScattering = "_MATERIAL_FEATURE_SUBSURFACE_SCATTERING";

        /// <summary>Material Feature Transmission</summary>
        public const string MaterialFeatureTransmission = "_MATERIAL_FEATURE_TRANSMISSION";

        /// <summary>Material Feature Anisotropy</summary>
        public const string MaterialFeatureAnisotropy = "_MATERIAL_FEATURE_ANISOTROPY";

        /// <summary>Material Feature Clear Coat</summary>
        public const string MaterialFeatureClearCoat = "_MATERIAL_FEATURE_CLEAR_COAT";

        /// <summary>Material Feature Iridscence</summary>
        public const string MaterialFeatureIridscence = "_MATERIAL_FEATURE_IRIDESCENCE";

        /// <summary>Material Feature Specular Color</summary>
        public const string MaterialFeatureSpecularColor = "_MATERIAL_FEATURE_SPECULAR_COLOR";

        /// <summary>Add Precomputed Velocity</summary>
        public const string AddPrecomputedVelocity = "_ADD_PRECOMPUTED_VELOCITY";

        /// <summary>Alpha Blend On</summary>
        public const string AlphaBlendOn = "_ALPHABLEND_ON";

        /// <summary>Metallic Gloss Map</summary>
        public const string MetallicGlossMap = "_METALLICGLOSSMAP";

        /// <summary>Refraction Plane</summary>
        public const string RefractionPlane = "_REFRACTION_PLANE";

        /// <summary>Refraction Sphere</summary>
        public const string RefractionSphere = "_REFRACTION_SPHERE";

        /// <summary>Refraction Thin</summary>
        public const string RefractionThin = "_REFRACTION_THIN";
    }
}