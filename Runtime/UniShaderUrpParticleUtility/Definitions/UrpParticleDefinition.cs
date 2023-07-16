// ----------------------------------------------------------------------
// @Namespace : UniUrpParticleShader
// @Class     : UrpParticleDefinition
// ----------------------------------------------------------------------
namespace UniUrpParticleShader
{
    using System;
    using UnityEngine;
    using UnityEngine.Rendering;

    /// <summary>
    /// 
    /// </summary>
    public class UrpParticleDefinition
    {
        /// <summary>Surface Type</summary>
        //[DefaultValue(SurfaceType.Opaque)]
        public SurfaceType Surface { get; set; }

        /// <summary>Blend Mode</summary>
        //[DefaultValue(BlendMode.Alpha)]
        public BlendMode Blend { get; set; }

        /// <summary>Blend Mode Preserve Specular</summary>
        public bool BlendModePreserveSpecular { get; set; }

        /// <summary>Color Mode</summary>
        public ColorMode ColorMode { get; set; }

        /// <summary>Cull Mode</summary>
        //[DefaultValue(CullMode.Back)]
        public CullMode Cull { get; set; }

        /// <summary>Alpha Clip</summary>
        //[DefaultValue(false)]
        public bool AlphaClip { get; set; }

        /// <summary>Alpha to Mask</summary>
        //[DefaultValue(false)]
        public bool AlphaToMask { get; set; }

        /// <summary>Alpha Cutoff</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float Cutoff { get; set; }

        ///// <summary>Lighting Enabled</summary>
        ///// <remarks>Standard Surface only</remarks>
        //public bool LightingEnabled { get; set; }

        /// <summary>Receive Shadows</summary>
        //[DefaultValue(true)]
        public bool ReceiveShadows { get; set; }

        /// <summary>Base Color</summary>
        public Color BaseColor { get; set; }

        /// <summary>Base Color Add/Sub/Diff</summary>
        public Color BaseColorAddSubDiff { get; set; }

        /// <summary>Base Map</summary>
        public Texture2D BaseMap { get; set; }

        /// <summary>Base Map Scale</summary>
        public Vector2 BaseMapScale { get; set; }

        /// <summary>Base Map Offset</summary>
        public Vector2 BaseMapOffset { get; set; }

        /// <summary>Metallic Gloss Map</summary>
        public Texture2D MetallicGlossMap { get; set; }

        /// <summary>Metallic</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float Metallic { get; set; }

        /// <summary>Smoothness</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float Smoothness { get; set; }

        /// <summary>Bump Scale</summary>
        //[DefaultValue(1.0f)]
        public float BumpScale { get; set; }

        /// <summary>Bump Map (Normal Map)</summary>
        public Texture2D BumpMap { get; set; }

        ///// <summary>Emission Enabled</summary>
        ///// <remarks>@notice obsolete?</remarks>
        //public bool EmissionEnabled { get; set; }

        /// <summary>Emission Color</summary>
        public Color EmissionColor { get; set; }

        /// <summary>Emission Map</summary>
        public Texture2D EmissionMap { get; set; }

        /// <summary>Flipbook Blending</summary>
        public bool FlipbookBlending { get; set; }

        /// <summary>Soft Particles Enabled</summary>
        public bool SoftParticlesEnabled { get; set; }

        /// <summary>Soft Particle Fade Params</summary>
        public Vector4 SoftParticleFadeParams { get; set; }

        /// <summary>Soft Particles Near Fade Distance</summary>
        public float SoftParticlesNearFadeDistance { get; set; }

        /// <summary>Soft Particles Far Fade Distance</summary>
        public float SoftParticlesFarFadeDistance { get; set; }

        /// <summary>Camera Fading Enabled</summary>
        public bool CameraFadingEnabled { get; set; }

        /// <summary>Camera Fade Params</summary>
        public Vector4 CameraFadeParams { get; set; }

        /// <summary>Camera Near Fade Distance</summary>
        public float CameraNearFadeDistance { get; set; }

        /// <summary>Camera Far Fade Distance</summary>
        public float CameraFarFadeDistance { get; set; }

        /// <summary>Distortion Enabled</summary>
        public bool DistortionEnabled { get; set; }

        /// <summary>Distortion Blend</summary>
        public float DistortionBlend { get; set; }

        /// <summary>Distortion Strength</summary>
        public float DistortionStrength { get; set; }

        /// <summary>Distortion Strength Scaled</summary>
        public float DistortionStrengthScaled { get; set; }

        /// <summary>Queue Offset</summary>
        //[Range(-50, 50)]
        //[DefaultValue(0)]
        public int QueueOffset { get; set; }

        /// <summary>Blend Operation</summary>
        public BlendOp BlendOp { get; set; }

        /// <summary>Src Blend</summary>
        //[DefaultValue(1.0f)]
        public UnityEngine.Rendering.BlendMode SrcBlend { get; set; }

        /// <summary>Dst Blend</summary>
        //[DefaultValue(0.0f)]
        public UnityEngine.Rendering.BlendMode DstBlend { get; set; }

        /// <summary>ZWrite</summary>
        //[DefaultValue(true)]
        public bool ZWrite { get; set; }

        /// <summary>Blend Mode</summary>
        [Obsolete("Obsolete")]
        public BlendMode Mode { get; set; }

        /// <summary>Flip Book Mode</summary>
        [Obsolete("Obsolete")]
        public FlipBookMode FlipBookMode { get; set; }

        /// <summary>Main Color</summary>
        [Obsolete("Obsolete")]
        public Color Color { get; set; }

        /// <summary>Glossiness</summary>
        [Obsolete("Obsolete")]
        public float Glossiness { get; set; }

        ///// <summary>Main Texture</summary>
        //public Texture2D MainTex { get; set; }

        ///// <summary>Main Texture Scale Transform</summary>
        //public Vector4 MainTexSt { get; set; }
    }
}