// ----------------------------------------------------------------------
// @Namespace : UniParticleShader
// @Class     : ParticleDefinition
// ----------------------------------------------------------------------
namespace UniParticleShader
{
    using UnityEngine;
    using UnityEngine.Rendering;

    /// <summary>
    /// 
    /// </summary>
    public class ParticleDefinition
    {
        /// <summary>Render Mode</summary>
        public BlendMode RenderMode { get; set; }

        /// <summary>Color Mode</summary>
        public ColorMode ColorMode { get; set; }

        /// <summary>Flip Book Mode</summary>
        public FlipBookMode FlipBookMode { get; set; }

        /// <summary>Cull Mode</summary>
        public CullMode Cull { get; set; }

        /// <summary>Two Sided</summary>
        public bool TwoSided { get; set; }

        /// <summary>Lighting Enabled</summary>
        /// <remarks>Standard Surface only</remarks>
        public bool LightingEnabled { get; set; }

        /// <summary>Main Texture</summary>
        public Texture2D MainTex { get; set; }

        /// <summary>Main Texture Scale Transform</summary>
        public Vector4 MainTexSt { get; set; }

        /// <summary>Main Texture Scale</summary>
        public Vector2 MainTexScale { get; set; }

        /// <summary>Main Texture Offset</summary>
        public Vector2 MainTexOffset { get; set; }

        /// <summary>Color</summary>
        public Color Color { get; set; }

        /// <summary>Color Add/Sub/Diff</summary>
        public Color ColorAddSubDiff { get; set; }

        /// <summary>Alpha Cutoff</summary>
        public float Cutoff { get; set; }

        /// <summary>Metallic GlossMap</summary>
        public Texture2D MetallicGlossMap { get; set; }

        /// <summary>Metallic</summary>
        public float Metallic { get; set; }

        /// <summary>Glossiness</summary>
        public float Glossiness { get; set; }

        /// <summary>Bump Map</summary>
        public Texture2D BumpMap { get; set; }

        /// <summary>Bump Scale</summary>
        public float BumpScale { get; set; }

        /// <summary>Emission Enabled</summary>
        public bool EmissionEnabled { get; set; }

        /// <summary>Emission Color</summary>
        public Color EmissionColor { get; set; }

        /// <summary>Emission Map</summary>
        public Texture2D EmissionMap { get; set; }

        /// <summary>Grab Texture</summary>
        /// <remarks>obsolete?</remarks>
        public Texture2D GrabTexture { get; set; }

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

        /// <summary>Distortion Strength Scaled</summary>
        public float DistortionStrengthScaled { get; set; }

        /// <summary>Blend Operation</summary>
        public BlendOp BlendOp { get; set; }

        /// <summary>Src Blend</summary>
        public UnityEngine.Rendering.BlendMode SrcBlend { get; set; }

        /// <summary>Dst Blend</summary>
        public UnityEngine.Rendering.BlendMode DstBlend { get; set; }

        /// <summary>ZWrite</summary>
        public bool ZWrite { get; set; }
    }
}