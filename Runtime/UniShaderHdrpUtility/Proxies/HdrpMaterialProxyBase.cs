// ----------------------------------------------------------------------
// @Namespace : UniHdrpShader
// @Class     : HdrpMaterialProxyBase
// ----------------------------------------------------------------------
namespace UniHdrpShader
{
    using System;
    using UniShader.Shared;
    using UnityEngine;
    using UnityEngine.Rendering;

    /// <summary>
    /// Basic HDRP Material Proxy
    /// </summary>
    public abstract class HdrpMaterialProxyBase
    {
        #region Fields

        /// <summary></summary>
        protected readonly Material _Material;

        #endregion

        #region Properties

        /// <summary>Emissive Color</summary>
        public Color EmissiveColor
        {
            get => _Material.GetSafeColor(Property.EmissiveColor, Color.white);
            set => _Material.SetSafeColor(Property.EmissiveColor, value);
        }

        /// <summary>Render Queue Type</summary>
        public RenderQueueType RenderQueueType
        {
            get => _Material.GetSafeEnum<RenderQueueType>(Property.RenderQueueType);
            set => _Material.SetSafeInt(Property.RenderQueueType, (int)value);
        }

        /// <summary>Depth Offset View space</summary>
        //[DefaultValue(false)]
        public bool DepthOffsetEnable
        {
            get => _Material.GetSafeBool(Property.DepthOffsetEnable, false);
            set
            {
                _Material.SetSafeBool(Property.DepthOffsetEnable, value);

                _Material.SetSafeKeyword(Keyword.DepthOffsetOn, value == true);
            }
        }

        /// <summary>Transparent Writing Motion Vec</summary>
        //[DefaultValue(0.0f)]
        public float TransparentWritingMotionVec
        {
            get => _Material.GetSafeFloat(Property.TransparentWritingMotionVec, PropertyRange.TransparentWritingMotionVec.defaultValue);
            set
            {
                _Material.SetSafeFloat(Property.TransparentWritingMotionVec, PropertyRange.TransparentWritingMotionVec, value);

                _Material.SetSafeKeyword(Keyword.TransparentWritesMotionVec, value > 0.0f);
            }
        }

        /// <summary>Alpha Cutoff Enable</summary>
        //[DefaultValue(false)]
        public bool AlphaCutoffEnable
        {
            get => _Material.GetSafeBool(Property.AlphaCutoffEnable, false);
            set
            {
                _Material.SetSafeBool(Property.AlphaCutoffEnable, value);

                _Material.SetSafeKeyword(Keyword.AlphaTestOn, value == true);
            }
        }

        /// <summary>Transparent Sort Priority</summary>
        //[DefaultValue(0.0f)]
        public float TransparentSortPriority
        {
            get => _Material.GetSafeFloat(Property.TransparentSortPriority, PropertyRange.TransparentSortPriority.defaultValue);
            set => _Material.SetSafeFloat(Property.TransparentSortPriority, PropertyRange.TransparentSortPriority, value);
        }

        /// <summary>Use Shadow Threshold</summary>
        //[DefaultValue(false)]
        public bool UseShadowThreshold
        {
            get => _Material.GetSafeBool(Property.UseShadowThreshold, false);
            set => _Material.SetSafeBool(Property.UseShadowThreshold, value);
        }

        /// <summary>Double sided enable</summary>
        //[DefaultValue(false)]
        public bool DoubleSidedEnable
        {
            get => _Material.GetSafeBool(Property.DoubleSidedEnable, false);
            set
            {
                _Material.SetSafeBool(Property.DoubleSidedEnable, value);

                _Material.SetSafeKeyword(Keyword.DoubleSidedOn, value == true);
            }
        }

        /// <summary>Double sided normal mode</summary>
        //[DefaultValue(DoubleSidedNormalMode.Mirror)]
        public DoubleSidedNormalMode DoubleSidedNormalMode
        {
            get => _Material.GetSafeEnum<DoubleSidedNormalMode>(Property.DoubleSidedNormalMode);
            set => _Material.SetSafeInt(Property.DoubleSidedNormalMode, (int)value);
        }

        /// <summary>Double Sided Constants</summary>
        //[DefaultValue(1, 1, -1, 0)]
        public Vector4 DoubleSidedConstants
        {
            get => _Material.GetSafeVector4(Property.DoubleSidedConstants, new Vector4(1, 1, -1, 0));
            set => _Material.SetSafeVector(Property.DoubleSidedConstants, value);
        }

        /// <summary>Transparent Depth Prepass Enable</summary>
        //[DefaultValue(false)]
        public bool TransparentDepthPrepassEnable
        {
            get => _Material.GetSafeBool(Property.TransparentDepthPrepassEnable, false);
            set => _Material.SetSafeBool(Property.TransparentDepthPrepassEnable, value);
        }

        /// <summary>Transparent Depth Postpass Enable</summary>
        //[DefaultValue(false)]
        public bool TransparentDepthPostpassEnable
        {
            get => _Material.GetSafeBool(Property.TransparentDepthPostpassEnable, false);
            set => _Material.SetSafeBool(Property.TransparentDepthPostpassEnable, value);
        }

        /// <summary>Surface Type</summary>
        //[DefaultValue(SurfaceType.Opaque)]
        public SurfaceType SurfaceType
        {
            get => _Material.GetSafeEnum<SurfaceType>(Property.SurfaceType, SurfaceType.Opaque);
            set => SetSurfaceType(value);
        }

        /// <summary>Blend Mode</summary>
        //[DefaultValue(BlendMode.Alpha)]
        public BlendMode BlendMode
        {
            get => _Material.GetSafeEnum<BlendMode>(Property.BlendMode, BlendMode.Alpha);
            set => SetBlendMode(value);
        }

        /// <summary>Src Blend</summary>
        //[DefaultValue(BlendMode.One)]
        public UnityEngine.Rendering.BlendMode SrcBlend
        {
            get => _Material.GetSafeEnum<UnityEngine.Rendering.BlendMode>(Property.SrcBlend, UnityEngine.Rendering.BlendMode.One);
            private set => _Material.SetSafeInt(Property.SrcBlend, (int)value);
        }

        /// <summary>Dst Blend</summary>
        //[DefaultValue(BlendMode.Zero)]
        public UnityEngine.Rendering.BlendMode DstBlend
        {
            get => _Material.GetSafeEnum<UnityEngine.Rendering.BlendMode>(Property.DstBlend, UnityEngine.Rendering.BlendMode.Zero);
            private set => _Material.SetSafeInt(Property.DstBlend, (int)value);
        }

        /// <summary>Alpha Src Blend</summary>
        //[DefaultValue(BlendMode.One)]
        public UnityEngine.Rendering.BlendMode AlphaSrcBlend
        {
            get => _Material.GetSafeEnum<UnityEngine.Rendering.BlendMode>(Property.AlphaSrcBlend, UnityEngine.Rendering.BlendMode.One);
            private set => _Material.SetSafeInt(Property.AlphaSrcBlend, (int)value);
        }

        /// <summary>Alpha Dst Blend</summary>
        //[DefaultValue(BlendMode.Zero)]
        public UnityEngine.Rendering.BlendMode AlphaDstBlend
        {
            get => _Material.GetSafeEnum<UnityEngine.Rendering.BlendMode>(Property.AlphaDstBlend, UnityEngine.Rendering.BlendMode.Zero);
            private set => _Material.SetSafeInt(Property.AlphaDstBlend, (int)value);
        }

        /// <summary>Alpha to Mask</summary>
        //[DefaultValue(false)]
        public bool AlphaToMask
        {
            get => _Material.GetSafeBool(Property.AlphaToMask, false);
            set
            {
                _Material.SetSafeBool(Property.AlphaToMask, value);

                _Material.SetSafeKeyword(Keyword.AlphaToMaskOn, value == true);
            }
        }

        /// <summary>Alpha to Mask Inspector Value</summary>
        //[DefaultValue(0)]
        public float AlphaToMaskInspectorValue
        {
            get => _Material.GetSafeFloat(Property.AlphaToMaskInspectorValue, PropertyRange.AlphaToMaskInspectorValue.defaultValue);
            set => _Material.SetSafeFloat(Property.AlphaToMaskInspectorValue, PropertyRange.AlphaToMaskInspectorValue, value);
        }

        /// <summary>ZWrite</summary>
        public bool ZWrite
        {
            get => _Material.GetSafeBool(Property.ZWrite, true);
            private set => _Material.SetSafeBool(Property.ZWrite, value);
        }

        /// <summary>Transparent ZWrite</summary>
        //[DefaultValue(false)]
        public bool TransparentZWrite
        {
            get => _Material.GetSafeBool(Property.TransparentZWrite, false);
            private set => _Material.SetSafeBool(Property.TransparentZWrite, value);
        }

        /// <summary>Cull Mode</summary>
        //[DefaultValue(CullMode.Back)]
        public CullMode CullMode
        {
            get => _Material.GetSafeEnum<CullMode>(Property.CullMode, CullMode.Back);
            set => _Material.SetSafeInt(Property.CullMode, (int)value);
        }

        /// <summary>Cull Mode Forward</summary>
        //[DefaultValue(CullMode.Back)]
        public CullMode CullModeForward
        {
            get => _Material.GetSafeEnum<CullMode>(Property.CullMode, CullMode.Back);
            set => _Material.SetSafeInt(Property.CullMode, (int)value);
        }

        /// <summary>Transparent Cull Mode</summary>
        //[DefaultValue(CullMode.Back)]
        public TransparentCullMode TransparentCullMode
        {
            get => _Material.GetSafeEnum<TransparentCullMode>(Property.TransparentCullMode, TransparentCullMode.Back);
            set => _Material.SetSafeInt(Property.TransparentCullMode, (int)value);
        }

        /// <summary>Opaque Cull Mode</summary>
        //[DefaultValue(CullMode.Back)]
        public OpaqueCullMode OpaqueCullMode
        {
            get => _Material.GetSafeEnum<OpaqueCullMode>(Property.OpaqueCullMode, OpaqueCullMode.Back);
            set => _Material.SetSafeInt(Property.OpaqueCullMode, (int)value);
        }

        /// <summary>ZTest Depth Equal for Opaque</summary>
        //[DefaultValue(8)]
        public int ZTestDepthEqualForOpaque
        {
            get => _Material.GetSafeInt(Property.ZTestDepthEqualForOpaque, PropertyRange.ZTestDepthEqualForOpaque.defaultValue);
            set => _Material.SetSafeInt(Property.ZTestDepthEqualForOpaque, PropertyRange.ZTestDepthEqualForOpaque, value);
        }

        /// <summary>ZTest Transparent</summary>
        //[DefaultValue(4)]
        public int ZTestTransparent
        {
            get => _Material.GetSafeInt(Property.ZTestTransparent, PropertyRange.ZTestTransparent.defaultValue);
            set => _Material.SetSafeInt(Property.ZTestTransparent, PropertyRange.ZTestTransparent, value);
        }

        /// <summary>Transparent Backface Enable</summary>
        //[DefaultValue(false)]
        public bool TransparentBackfaceEnable
        {
            get => _Material.GetSafeBool(Property.TransparentBackfaceEnable, false);
            set => _Material.SetSafeBool(Property.TransparentBackfaceEnable, value);
        }

        /// <summary>Require Split Lighting</summary>
        //[DefaultValue(false)]
        public bool RequireSplitLighting
        {
            get => _Material.GetSafeBool(Property.RequireSplitLighting, false);
            set => _Material.SetSafeBool(Property.RequireSplitLighting, value);
        }

        /// <summary>Receives SSR</summary>
        //[DefaultValue(true)]
        public bool ReceivesSSR
        {
            get => _Material.GetSafeBool(Property.ReceivesSSR, false);  // @notice
            set
            {
                _Material.SetSafeBool(Property.ReceivesSSR, value);

                _Material.SetSafeKeyword(Keyword.DisableSsr, value == false);
            }
        }

        /// <summary>Receives SSR Transparent</summary>
        //[DefaultValue(false)]
        public bool ReceivesSSRTransparent
        {
            get => _Material.GetSafeBool(Property.ReceivesSSRTransparent, false);
            set
            {
                _Material.SetSafeBool(Property.ReceivesSSRTransparent, value);

                _Material.SetSafeKeyword(Keyword.DisableSsrTransparent, value == false);
            }
        }

        /// <summary>Support Decals</summary>
        //[DefaultValue(true)]
        public bool SupportDecals
        {
            get => _Material.GetSafeBool(Property.SupportDecals, false);  // @notice
            set
            {
                _Material.SetSafeBool(Property.SupportDecals, value);

                _Material.SetSafeKeyword(Keyword.DisableDecals, value == false);
            }
        }

        /// <summary>Enable Fog</summary>
        //[DefaultValue(true)]
        public bool EnableFogOnTransparent
        {
            get => _Material.GetSafeBool(Property.EnableFogOnTransparent, true);
            set
            {
                _Material.SetSafeBool(Property.EnableFogOnTransparent, value);

                _Material.SetSafeKeyword(Keyword.EnableFogOnTransparent, value == true && SurfaceType == SurfaceType.Transparent);
            }
        }

        /// <summary>Enable Blend Mode Preserve Specular Lighting</summary>
        //[DefaultValue(true)]
        public bool EnableBlendModePreserveSpecularLighting
        {
            get => _Material.GetSafeBool(Property.EnableBlendModePreserveSpecularLighting, true);
            set => _Material.SetSafeBool(Property.EnableBlendModePreserveSpecularLighting, value);
        }

        /// <summary>Stencil Ref</summary>
        //[DefaultValue(0)]  // StencilUsage.Clear
        public StencilUsage StencilRef
        {
            get => _Material.GetSafeEnum<StencilUsage>(Property.StencilRef, StencilUsage.Clear);
            set => _Material.SetSafeInt(Property.StencilRef, (int)value);
        }

        /// <summary>Stencil Ref Depth</summary>
        //[DefaultValue(0)]  // Nothing
        public StencilUsage StencilRefDepth
        {
            get => _Material.GetSafeEnum<StencilUsage>(Property.StencilRefDepth, 0);
            set => _Material.SetSafeInt(Property.StencilRefDepth, (int)value);
        }

        /// <summary>Stencil Ref Distortion Vec</summary>
        //[DefaultValue(4)]  // StencilUsage.DistortionVectors
        public StencilUsage StencilRefDistortionVec
        {
            get => _Material.GetSafeEnum<StencilUsage>(Property.StencilRefDistortionVec, StencilUsage.DistortionVectors);
            set => _Material.SetSafeInt(Property.StencilRefDistortionVec, (int)value);
        }

        /// <summary>Stencil Ref GBuffer</summary>
        //[DefaultValue(2)]  // StencilUsage.RequiresDeferredLighting
        public StencilUsage StencilRefGBuffer
        {
            get => _Material.GetSafeEnum<StencilUsage>(Property.StencilRefGBuffer, StencilUsage.RequiresDeferredLighting);
            set => _Material.SetSafeInt(Property.StencilRefGBuffer, (int)value);
        }

        /// <summary>Stencil Ref MV</summary>
        //[DefaultValue(32)]  // StencilUsage.ObjectMotionVector
        public StencilUsage StencilRefMV
        {
            get => _Material.GetSafeEnum<StencilUsage>(Property.StencilRefMV, StencilUsage.ObjectMotionVector);
            set => _Material.SetSafeInt(Property.StencilRefMV, (int)value);
        }

        /// <summary>Stencil Write Mask</summary>
        //[DefaultValue(6)]  // StencilUsage.RequiresDeferredLighting | StencilUsage.SubsurfaceScattering
        public StencilUsage StencilWriteMask
        {
            get => _Material.GetSafeEnum<StencilUsage>(Property.StencilWriteMask, StencilUsage.RequiresDeferredLighting | StencilUsage.SubsurfaceScattering);
            set => _Material.SetSafeInt(Property.StencilWriteMask, (int)value);
        }

        /// <summary>Stencil Write Mask Depth</summary>
        //[DefaultValue(8)]  // StencilUsage.TraceReflectionRay
        public StencilUsage StencilWriteMaskDepth
        {
            get => _Material.GetSafeEnum<StencilUsage>(Property.StencilWriteMaskDepth, StencilUsage.TraceReflectionRay);
            set => _Material.SetSafeInt(Property.StencilWriteMaskDepth, (int)value);
        }

        /// <summary>Stencil Write Mask Distortion Vec</summary>
        //[DefaultValue(4)]  // StencilUsage.DistortionVectors
        public StencilUsage StencilWriteMaskDistortionVec
        {
            get => _Material.GetSafeEnum<StencilUsage>(Property.StencilWriteMaskDistortionVec, StencilUsage.DistortionVectors);
            set => _Material.SetSafeInt(Property.StencilWriteMaskDistortionVec, (int)value);
        }

        /// <summary>Stencil Write Mask GBuffer</summary>
        //[DefaultValue(3)]  // StencilUsage.RequiresDeferredLighting | StencilUsage.SubsurfaceScattering
        public StencilUsage StencilWriteMaskGBuffer
        {
            get => _Material.GetSafeEnum<StencilUsage>(Property.StencilWriteMaskGBuffer, StencilUsage.RequiresDeferredLighting | StencilUsage.SubsurfaceScattering);
            set => _Material.SetSafeInt(Property.StencilWriteMaskGBuffer, (int)value);
        }

        /// <summary>Stencil Write Mask MV</summary>
        //[DefaultValue(32)]  // StencilUsage.ObjectMotionVector
        public StencilUsage StencilWriteMaskMV
        {
            get => _Material.GetSafeEnum<StencilUsage>(Property.StencilWriteMaskMV, StencilUsage.ObjectMotionVector);
            set => _Material.SetSafeInt(Property.StencilWriteMaskMV, (int)value);
        }

        /// <summary>ZTest GBuffer</summary>
        public int ZTestGBuffer
        {
            get => _Material.GetSafeInt(Property.ZTestGBuffer);
            set => _Material.SetSafeInt(Property.ZTestGBuffer, value);
        }

        ///// <summary>unity_Lightmaps</summary>
        //public Texture2DArray UnityLightmaps { get; set; }

        ///// <summary>unity_LightmapsInd</summary>
        //public Texture2DArray UnityLightmapsInd { get; set; }

        ///// <summary>unity_ShadowMasks</summary>
        //public Texture2DArray UnityShadowMasks { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of HdrpMaterialProxyBase.
        /// </summary>
        /// <param name="material">The HDRP material.</param>
        public HdrpMaterialProxyBase(Material material)
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

            _Material = material;
        }

        #endregion

        #region Public Methods (Set)

        /// <summary>
        /// Sets the surface type.
        /// </summary>
        /// <param name="surfaceType"></param>
        /// <param name="blendMode"></param>
        public void SetSurfaceType(SurfaceType surfaceType, BlendMode? blendMode = null)
        {
            _Material.SetSafeInt(Property.SurfaceType, (int)surfaceType);

            if (blendMode.HasValue)
            {
                _Material.SetInt(Property.BlendMode, (int)blendMode);

                SetRenderKeyword(surfaceType, blendMode.Value);
            }
            else
            {
                SetRenderKeyword(surfaceType, BlendMode);
            }
        }

        /// <summary>
        /// Sets the blend mode.
        /// </summary>
        /// <param name="blendMode"></param>
        private void SetBlendMode(BlendMode blendMode)
        {
            _Material.SetSafeInt(Property.BlendMode, (int)blendMode);

            SetRenderKeyword(SurfaceType, blendMode);
        }

        /// <summary>
        /// Sets the render keywords.
        /// </summary>
        /// <param name="surfaceType"></param>
        /// <param name="blendMode"></param>
        private void SetRenderKeyword(SurfaceType surfaceType, BlendMode blendMode)
        {
            _Material.SetSafeKeyword(Keyword.SurfaceTypeTransparent, surfaceType == SurfaceType.Transparent);

            switch (surfaceType)
            {
                case SurfaceType.Opaque:
                    if (AlphaCutoffEnable)
                    {
                        _Material.SetOverrideTag(Tag.RenderType, RenderTypeValue.TransparentCutout);
                    }
                    else
                    {
                        _Material.SetOverrideTag(Tag.RenderType, RenderTypeValue.Opaque);
                    }

                    SrcBlend = UnityEngine.Rendering.BlendMode.One;
                    DstBlend = UnityEngine.Rendering.BlendMode.Zero;

                    AlphaSrcBlend = UnityEngine.Rendering.BlendMode.One;
                    AlphaDstBlend = UnityEngine.Rendering.BlendMode.Zero;

                    ZWrite = true;
                    TransparentZWrite = false;

                    _Material.renderQueue = 2225;  // @notice
                    break;

                case SurfaceType.Transparent:
                    _Material.SetOverrideTag(Tag.RenderType, RenderTypeValue.Transparent);

                    switch (blendMode)
                    {
                        case BlendMode.Alpha:
                            SrcBlend = UnityEngine.Rendering.BlendMode.One;
                            DstBlend = UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha;

                            AlphaSrcBlend = UnityEngine.Rendering.BlendMode.One;
                            AlphaDstBlend = UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha;

                            ZWrite = false;
                            TransparentZWrite = false;

                            _Material.renderQueue = (int)RenderQueue.Transparent;
                            break;
                        case BlendMode.Additive:
                            SrcBlend = UnityEngine.Rendering.BlendMode.One;
                            DstBlend = UnityEngine.Rendering.BlendMode.One;

                            AlphaSrcBlend = UnityEngine.Rendering.BlendMode.One;
                            AlphaDstBlend = UnityEngine.Rendering.BlendMode.One;

                            ZWrite = false;
                            TransparentZWrite = false;

                            _Material.renderQueue = (int)RenderQueue.Transparent;
                            break;
                        case BlendMode.Premultiply:
                            SrcBlend = UnityEngine.Rendering.BlendMode.One;
                            DstBlend = UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha;

                            AlphaSrcBlend = UnityEngine.Rendering.BlendMode.One;
                            AlphaDstBlend = UnityEngine.Rendering.BlendMode.OneMinusSrcAlpha;

                            ZWrite = false;
                            TransparentZWrite = false;

                            _Material.renderQueue = (int)RenderQueue.Transparent;
                            break;
                    }
                    break;
            }

            _Material.SetSafeKeyword(Keyword.EnableFogOnTransparent, EnableFogOnTransparent == true && surfaceType == SurfaceType.Transparent);
        }

        #endregion
    }
}