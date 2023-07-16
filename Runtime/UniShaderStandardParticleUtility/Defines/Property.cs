// ----------------------------------------------------------------------
// @Namespace : UniParticleShader
// @Class     : Property
// ----------------------------------------------------------------------
namespace UniParticleShader
{
    /// <summary>
    /// Property
    /// </summary>
    public class Property
    {
        /// <summary>Blend Mode</summary>
        public const string BlendMode = "_Mode";

        /// <summary>Color Mode</summary>
        public const string ColorMode = "_ColorMode";

        /// <summary>Cull Mode</summary>
        public const string Cull = "_Cull";

        /// <summary>Flipbook Mode</summary>
        public const string FlipbookMode = "_FlipbookMode";

        /// <summary>Lighting Enabled</summary>
        /// <remarks>Standard Surface only</remarks>
        public const string LightingEnabled = "_LightingEnabled";

        /// <summary>Albedo</summary>
        public const string MainTex = "_MainTex";

        /// <summary>Main Texture Scale Transform</summary>
        public const string MainTexSt = "_MainTex_ST";

        /// <summary>Color</summary>
        public const string Color = "_Color";

        /// <summary>Color Add/Sub/Diff</summary>
        public const string ColorAddSubDiff = "_ColorAddSubDiff";

        /// <summary>Alpha Cutoff</summary>
        public const string Cutoff = "_Cutoff";

        /// <summary>Metallic Gloss Map</summary>
        public const string MetallicGlossMap = "_MetallicGlossMap";

        /// <summary>Metallic</summary>
        public const string Metallic = "_Metallic";

        /// <summary>Glossiness</summary>
        public const string Glossiness = "_Glossiness";

        /// <summary>Bump Map</summary>
        public const string BumpMap = "_BumpMap";

        /// <summary>Bump Scale</summary>
        public const string BumpScale = "_BumpScale";

        /// <summary>Emission Enabled</summary>
        public const string EmissionEnabled = "_EmissionEnabled";

        /// <summaryEmission Color></summary>
        public const string EmissionColor = "_EmissionColor";

        /// <summary>Emission Map</summary>
        public const string EmissionMap = "_EmissionMap";

        /// <summary>Grab Texture</summary>
        /// <remarks>obsolete?</remarks>
        public const string GrabTexture = "_GrabTexture";

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

        /// <summary>Distortion Strength Scaled</summary>
        public const string DistortionStrengthScaled = "_DistortionStrengthScaled";

        /// <summary>Blend Operation</summary>
        public const string BlendOp = "_BlendOp";

        /// <summary>Src Blend</summary>
        public const string SrcBlend = "_SrcBlend";

        /// <summary>Dst Blend</summary>
        public const string DstBlend = "_DstBlend";

        /// <summary>ZWrite</summary>
        public const string ZWrite = "_ZWrite";
    }
}