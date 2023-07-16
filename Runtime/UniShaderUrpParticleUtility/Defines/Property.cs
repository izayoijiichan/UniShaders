// ----------------------------------------------------------------------
// @Namespace : UniUrpParticleShader
// @Class     : Property
// ----------------------------------------------------------------------
namespace UniUrpParticleShader
{
    using System;

    /// <summary>
    /// Property
    /// </summary>
    public class Property
    {
        /// <summary>Surface Type</summary>
        public const string Surface = "_Surface";

        /// <summary>Blend Mode</summary>
        public const string Blend = "_Blend";

        /// <summary>Blend Mode Preserve Specular</summary>
        public const string BlendModePreserveSpecular = "_BlendModePreserveSpecular";

        /// <summary>Color Mode</summary>
        public const string ColorMode = "_ColorMode";

        /// <summary>Cull Mode</summary>
        public const string Cull = "_Cull";

        /// <summary>Alpha Clip</summary>
        public const string AlphaClip = "_AlphaClip";

        /// <summary>Alpha to Mask</summary>
        public const string AlphaToMask = "_AlphaToMask";

        /// <summary>Alpha Cutoff</summary>
        public const string Cutoff = "_Cutoff";

        /// <summary>Receive Shadows</summary>
        public const string ReceiveShadows = "_ReceiveShadows";

        /// <summary>Base Map</summary>
        public const string BaseMap = "_BaseMap";

        /// <summary>Base Color</summary>
        public const string BaseColor = "_BaseColor";

        /// <summary>Base Color Add/Sub/Diff</summary>
        public const string BaseColorAddSubDiff = "_BaseColorAddSubDiff";

        /// <summary>Metallic Gloss Map</summary>
        public const string MetallicGlossMap = "_MetallicGlossMap";

        /// <summary>Metallic</summary>
        public const string Metallic = "_Metallic";

        /// <summary>Smoothness</summary>
        public const string Smoothness = "_Smoothness";

        /// <summary>Bump Scale</summary>
        public const string BumpScale = "_BumpScale";

        /// <summary>Bump Map</summary>
        public const string BumpMap = "_BumpMap";

        ///// <summary>Emission Enabled</summary>
        ///// <remarks>@notice obsolete?</remarks>
        //public const string EmissionEnabled = "_EmissionEnabled";

        /// <summary>Emission Color</summary>
        public const string EmissionColor = "_EmissionColor";

        /// <summary>Emission Map</summary>
        public const string EmissionMap = "_EmissionMap";

        /// <summary>Flipbook Blending</summary>
        public const string FlipbookBlending = "_FlipbookBlending";

        /// <summary>Soft Particles Enabled</summary>
        public const string SoftParticlesEnabled = "_SoftParticlesEnabled";

        /// <summary>Soft Particle Fade Params</summary>
        public const string SoftParticleFadeParams = "_SoftParticleFadeParams";

        /// <summary>Soft Particles Near Fade Distance</summary>
        public const string SoftParticlesNearFadeDistance = "_SoftParticlesNearFadeDistance";

        /// <summary>Soft Particles Far Fade Distance</summary>
        public const string SoftParticlesFarFadeDistance = "_SoftParticlesFarFadeDistance";

        /// <summary>Camera Fading Enabled</summary>
        public const string CameraFadingEnabled = "_CameraFadingEnabled";

        /// <summary>Camera Fade Params</summary>
        public const string CameraFadeParams = "_CameraFadeParams";

        /// <summary>Camera Near Fade Distance</summary>
        public const string CameraNearFadeDistance = "_CameraNearFadeDistance";

        /// <summary>Camera Far Fade Distance</summary>
        public const string CameraFarFadeDistance = "_CameraFarFadeDistance";

        /// <summary>Distortion Enabled</summary>
        public const string DistortionEnabled = "_DistortionEnabled";

        /// <summary>Distortion Blend</summary>
        public const string DistortionBlend = "_DistortionBlend";

        /// <summary>Distortion Strength</summary>
        public const string DistortionStrength = "_DistortionStrength";

        /// <summary>Distortion Strength Scaled</summary>
        public const string DistortionStrengthScaled = "_DistortionStrengthScaled";

        /// <summary>Queue Offset</summary>
        public const string QueueOffset = "_QueueOffset";

        /// <summary>Blend Operation</summary>
        public const string BlendOp = "_BlendOp";

        /// <summary>Src Blend</summary>
        public const string SrcBlend = "_SrcBlend";

        /// <summary>Dst Blend</summary>
        public const string DstBlend = "_DstBlend";

        /// <summary>ZWrite</summary>
        public const string ZWrite = "_ZWrite";

        /// <summary>Blend Mode</summary>
        [Obsolete("Obsolete")]
        public const string Mode = "_Mode";

        /// <summary>Flip Book Mode</summary>
        [Obsolete("Obsolete")]
        public const string FlipbookMode = "_FlipbookMode";

        /// <summary>Main Color</summary>
        [Obsolete("Obsolete")]
        public const string Color = "_Color";

        /// <summary>Glossiness</summary>
        [Obsolete("Obsolete")]
        public const string Glossiness = "_Glossiness";

        ///// <summary>Main Texture</summary>
        //public const string MainTex = "_MainTex";

        ///// <summary>Main Texture Scale Transform</summary>
        //public const string MainTexSt = "_MainTex_ST";

        ///// <summary>Lighting Enabled</summary>
        ///// <remarks>Standard Surface only</remarks>
        //public const string LightingEnabled = "_LightingEnabled";
    }
}