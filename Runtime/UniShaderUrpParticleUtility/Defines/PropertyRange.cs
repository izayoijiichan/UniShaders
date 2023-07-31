// ----------------------------------------------------------------------
// @Namespace : UniUrpParticleShader
// @Class     : PropertyRange
// ----------------------------------------------------------------------
namespace UniUrpParticleShader
{
    using System;
    using UniShader.Shared;

    /// <summary>
    /// Property Range
    /// </summary>
    public class PropertyRange
    {
        /// <summary>Alpha Cutoff</summary>
        public static FloatRangeDefault Cutoff = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        /// <summary>Metallic</summary>
        public static FloatRangeDefault Metallic = new FloatRangeDefault(0.0f, 1.0f, 0.0f);

        /// <summary>Smoothness</summary>
        public static FloatRangeDefault Smoothness = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        /// <summary>Glossiness</summary>
        [Obsolete("Obsolete")]
        public static FloatRangeDefault Glossiness = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        /// <summary>Normal Map Scale</summary>
        public static FloatRangeDefault BumpScale = new FloatRangeDefault(0.0f, 1.0f, 1.0f);

        /// <summary>Soft Particles Near Fade Distance</summary>
        public static FloatRangeDefault SoftParticlesNearFadeDistance = new FloatRangeDefault(0.0f, float.MaxValue, 0.0f);

        /// <summary>Soft Particles Far Fade Distance</summary>
        public static FloatRangeDefault SoftParticlesFarFadeDistance = new FloatRangeDefault(0.0f, float.MaxValue, 1.0f);

        /// <summary>Camera Near Fade Distance</summary>
        public static FloatRangeDefault CameraNearFadeDistance = new FloatRangeDefault(0.0f, float.MaxValue, 1.0f);

        /// <summary>Camera Far Fade Distance</summary>
        public static FloatRangeDefault CameraFarFadeDistance = new FloatRangeDefault(0.0f, float.MaxValue, 2.0f);

        /// <summary>Distortion Blend</summary>
        public static FloatRangeDefault DistortionBlend = new FloatRangeDefault(0.0f, 1.0f, 0.5f);

        /// <summary>Distortion Strength</summary>
        public static FloatRangeDefault DistortionStrength = new FloatRangeDefault(float.MinValue, float.MaxValue, 1.0f);

        /// <summary>Distortion Strength Scaled</summary>
        public static FloatRangeDefault DistortionStrengthScaled = new FloatRangeDefault(float.MinValue, float.MaxValue, 1.0f);

        /// <summary>Queue Offset</summary>
        public static IntRangeDefault QueueOffset = new IntRangeDefault(-50, 50, 0);
    }
}