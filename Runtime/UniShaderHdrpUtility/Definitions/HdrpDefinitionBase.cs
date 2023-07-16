// ----------------------------------------------------------------------
// @Namespace : UniHdrpShader
// @Class     : HdrpDefinitionBase
// ----------------------------------------------------------------------
namespace UniHdrpShader
{
    using UnityEngine;

    /// <summary>
    /// Basic HDRP Definition
    /// </summary>
    public class HdrpDefinitionBase
    {
        /// <summary>Emissive Color</summary>
        public Color EmissiveColor { get; set; }

        /// <summary>Render Queue Type</summary>
        public RenderQueueType RenderQueueType { get; set; }

        /// <summary>Depth Offset View space</summary>
        //[DefaultValue(false)]
        public bool DepthOffsetEnable { get; set; }

        /// <summary>Transparent Writing Motion Vec</summary>
        //[DefaultValue(0.0f)]
        public float TransparentWritingMotionVec { get; set; }

        /// <summary>Alpha Cutoff Enable</summary>
        //[DefaultValue(false)]
        public bool AlphaCutoffEnable { get; set; }

        /// <summary>Transparent Sort Priority</summary>
        //[DefaultValue(0.0f)]
        public float TransparentSortPriority { get; set; }

        /// <summary>Use Shadow Threshold</summary>
        //[DefaultValue(false)]
        public bool UseShadowThreshold { get; set; }

        /// <summary>Double sided enable</summary>
        //[DefaultValue(false)]
        public bool DoubleSidedEnable { get; set; }

        /// <summary>Double sided normal mode</summary>
        //[DefaultValue(DoubleSidedNormalMode.Mirror)]
        public DoubleSidedNormalMode DoubleSidedNormalMode { get; set; }

        /// <summary>Double Sided Constants</summary>
        //[DefaultValue(1, 1, -1, 0)]
        public Vector4 DoubleSidedConstants { get; set; }

        /// <summary>Transparent Depth Prepass Enable</summary>
        //[DefaultValue(false)]
        public bool TransparentDepthPrepassEnable { get; set; }

        /// <summary>Transparent Depth Postpass Enable</summary>
        //[DefaultValue(false)]
        public bool TransparentDepthPostpassEnable { get; set; }

        /// <summary>Surface Type</summary>
        //[DefaultValue(SurfaceType.Opaque)]
        public SurfaceType SurfaceType { get; set; }

        /// <summary>Blend Mode</summary>
        //[DefaultValue(BlendMode.Alpha)]
        public BlendMode BlendMode { get; set; }

        /// <summary>Src Blend</summary>
        //[DefaultValue(BlendMode.One)]
        public UnityEngine.Rendering.BlendMode SrcBlend { get; set; }

        /// <summary>Dst Blend</summary>
        //[DefaultValue(BlendMode.Zero)]
        public UnityEngine.Rendering.BlendMode DstBlend { get; set; }

        /// <summary>Alpha Src Blend</summary>
        //[DefaultValue(BlendMode.One)]
        public UnityEngine.Rendering.BlendMode AlphaSrcBlend { get; set; }

        /// <summary>Alpha Dst Blend</summary>
        //[DefaultValue(BlendMode.Zero)]
        public UnityEngine.Rendering.BlendMode AlphaDstBlend { get; set; }

        /// <summary>Alpha to Mask</summary>
        //[DefaultValue(false)]
        public bool AlphaToMask { get; set; }

        /// <summary>Alpha to Mask Inspector Value</summary>
        //[DefaultValue(0)]
        public float AlphaToMaskInspectorValue { get; set; }

        /// <summary>ZWrite</summary>
        //[DefaultValue(true)]
        public bool ZWrite { get; set; }

        /// <summary>Transparent ZWrite</summary>
        //[DefaultValue(false)]
        public bool TransparentZWrite { get; set; }

        /// <summary>Cull Mode</summary>
        //[DefaultValue(CullMode.Back)]
        public CullMode CullMode { get; set; }

        /// <summary>Cull Mode Forward</summary>
        //[DefaultValue(CullMode.Back)]
        public CullMode CullModeForward { get; set; }

        /// <summary>Transparent Cull Mode</summary>
        //[DefaultValue(CullMode.Back)]
        public TransparentCullMode TransparentCullMode { get; set; }

        /// <summary>Opaque Cull Mode</summary>
        //[DefaultValue(CullMode.Back)]
        public OpaqueCullMode OpaqueCullMode { get; set; }

        /// <summary>ZTest Depth Equal for Opaque</summary>
        //[DefaultValue(8)]
        public int ZTestDepthEqualForOpaque { get; set; }

        /// <summary>ZTest Transparent</summary>
        //[DefaultValue(4)]
        public int ZTestTransparent { get; set; }

        /// <summary>Transparent Backface Enable</summary>
        //[DefaultValue(false)]
        public bool TransparentBackfaceEnable { get; set; }

        /// <summary>Require Split Lighting</summary>
        //[DefaultValue(false)]
        public bool RequireSplitLighting { get; set; }  // @notice

        /// <summary>Receives SSR</summary>
        //[DefaultValue(true)]
        public bool ReceivesSSR { get; set; }

        /// <summary>Receives SSR Transparent</summary>
        //[DefaultValue(false)]
        public bool ReceivesSSRTransparent { get; set; }

        /// <summary>Support Decals</summary>
        //[DefaultValue(true)]
        public bool SupportDecals { get; set; }

        /// <summary>Enable Fog</summary>
        //[DefaultValue(true)]
        public bool EnableFogOnTransparent { get; set; }

        /// <summary>Enable Blend Mode Preserve Specular Lighting</summary>
        //[DefaultValue(true)]
        public bool EnableBlendModePreserveSpecularLighting { get; set; }

        /// <summary>Stencil Ref</summary>
        //[DefaultValue(0)]  // StencilUsage.Clear
        public StencilUsage StencilRef { get; set; }

        /// <summary>Stencil Ref Depth</summary>
        //[DefaultValue(0)]  // Nothing
        public StencilUsage StencilRefDepth { get; set; }

        /// <summary>Stencil Ref Distortion Vec</summary>
        //[DefaultValue(4)]  // StencilUsage.DistortionVectors
        public StencilUsage StencilRefDistortionVec { get; set; }

        /// <summary>Stencil Ref GBuffer</summary>
        //[DefaultValue(2)]  // StencilUsage.RequiresDeferredLighting
        public StencilUsage StencilRefGBuffer { get; set; }

        /// <summary>Stencil Ref MV</summary>
        //[DefaultValue(32)]  // StencilUsage.ObjectMotionVector
        public StencilUsage StencilRefMV { get; set; }

        /// <summary>Stencil Write Mask</summary>
        //[DefaultValue(6)]  // StencilUsage.RequiresDeferredLighting | StencilUsage.SubsurfaceScattering
        public StencilUsage StencilWriteMask { get; set; }

        /// <summary>Stencil Write Mask Depth</summary>
        //[DefaultValue(8)]  // StencilUsage.TraceReflectionRay
        public StencilUsage StencilWriteMaskDepth { get; set; }

        /// <summary>Stencil Write Mask Distortion Vec</summary>
        //[DefaultValue(4)]  // StencilUsage.DistortionVectors
        public StencilUsage StencilWriteMaskDistortionVec { get; set; }

        /// <summary>Stencil Write Mask GBuffer</summary>
        //[DefaultValue(3)]  // StencilUsage.RequiresDeferredLighting | StencilUsage.SubsurfaceScattering
        public StencilUsage StencilWriteMaskGBuffer { get; set; }

        /// <summary>Stencil Write Mask MV</summary>
        //[DefaultValue(32)]  // StencilUsage.ObjectMotionVector
        public StencilUsage StencilWriteMaskMV { get; set; }

        /// <summary>ZTest GBuffer</summary>
        public int ZTestGBuffer { get; set; }  // @notice

        /// <summary>unity_Lightmaps</summary>
        public Texture2DArray UnityLightmaps { get; set; }

        /// <summary>unity_LightmapsInd</summary>
        public Texture2DArray UnityLightmapsInd { get; set; }

        /// <summary>unity_ShadowMasks</summary>
        public Texture2DArray UnityShadowMasks { get; set; }
    }
}