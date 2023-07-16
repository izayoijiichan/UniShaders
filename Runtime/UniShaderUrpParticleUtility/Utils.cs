// ----------------------------------------------------------------------
// @Namespace : UniUrpParticleShader
// @Class     : Utils
// ----------------------------------------------------------------------
namespace UniUrpParticleShader
{
    using UniShader.Shared;
    using UnityEngine;

    /// <summary>
    /// 
    /// </summary>
    public static class Utils
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        public static UrpParticleDefinition GetParametersFromMaterial(Material material)
        {
            var materialProxy = new UrpParticleMaterialProxy(material);

            return new UrpParticleDefinition
            {
                Surface = materialProxy.Surface,
                Blend = materialProxy.Blend,
                BlendModePreserveSpecular = materialProxy.BlendModePreserveSpecular,
                ColorMode = materialProxy.ColorMode,
                Cull = materialProxy.Cull,
                AlphaClip = materialProxy.AlphaClip,
                AlphaToMask = materialProxy.AlphaToMask,
                Cutoff = materialProxy.Cutoff,
                ReceiveShadows = materialProxy.ReceiveShadows,

                BaseColor = materialProxy.BaseColor,
                BaseColorAddSubDiff = materialProxy.BaseColorAddSubDiff,
                BaseMap = materialProxy.BaseMap,
                BaseMapScale = materialProxy.BaseMapScale,
                BaseMapOffset = materialProxy.BaseMapOffset,

                MetallicGlossMap = materialProxy.MetallicGlossMap,
                Metallic = materialProxy.Metallic,
                Smoothness = materialProxy.Smoothness,

                BumpScale = materialProxy.BumpScale,
                BumpMap = materialProxy.BumpMap,

                //EmissionEnabled = materialProxy.EmissionEnabled,
                EmissionColor = materialProxy.EmissionColor,
                EmissionMap = materialProxy.EmissionMap,

                FlipbookBlending = materialProxy.FlipbookBlending,

                SoftParticlesEnabled = materialProxy.SoftParticlesEnabled,
                SoftParticleFadeParams = materialProxy.SoftParticleFadeParams,
                SoftParticlesNearFadeDistance = materialProxy.SoftParticlesNearFadeDistance,
                SoftParticlesFarFadeDistance  = materialProxy.SoftParticlesFarFadeDistance,

                CameraFadingEnabled = materialProxy.CameraFadingEnabled,
                CameraFadeParams = materialProxy.CameraFadeParams,
                CameraNearFadeDistance = materialProxy.CameraNearFadeDistance,
                CameraFarFadeDistance = materialProxy.CameraFarFadeDistance,

                DistortionEnabled = materialProxy.DistortionEnabled,
                DistortionBlend = materialProxy.DistortionBlend,
                DistortionStrength = materialProxy.DistortionStrength,
                DistortionStrengthScaled = materialProxy.DistortionStrengthScaled,

                BlendOp = materialProxy.BlendOp,
                SrcBlend = materialProxy.SrcBlend,
                DstBlend = materialProxy.DstBlend,
                ZWrite = materialProxy.ZWrite,

                //Mode = materialProxy.Mode,
                //FlipBookMode = materialProxy.FlipBookMode,
                //Color = materialProxy.Color,
                //Glossiness = materialProxy.Glossiness,

                //MainTex = materialProxy.MainTex,
                //MainTexSt = materialProxy.MainTexSt,
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        public static BlendMode GetBlendMode(Material material)
        {
            var materialProxy = new UrpParticleMaterialProxy(material);

            return materialProxy.Blend;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        public static ColorMode GetColorMode(Material material)
        {
            var materialProxy = new UrpParticleMaterialProxy(material);

            return materialProxy.ColorMode;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <param name="parameters"></param>
        public static void SetParametersToMaterial(Material material, UrpParticleDefinition parameters)
        {
            var materialProxy = new UrpParticleMaterialProxy(material)
            {
                Surface = parameters.Surface,
                Blend = parameters.Blend,
                BlendModePreserveSpecular = parameters.BlendModePreserveSpecular,
                ColorMode = parameters.ColorMode,
                Cull = parameters.Cull,
                AlphaClip = parameters.AlphaClip,
                AlphaToMask = parameters.AlphaToMask,
                Cutoff = parameters.Cutoff,
                ReceiveShadows = parameters.ReceiveShadows,

                BaseColor = parameters.BaseColor,
                BaseColorAddSubDiff = parameters.BaseColorAddSubDiff,
                BaseMap = parameters.BaseMap,
                BaseMapScale = parameters.BaseMapScale,
                BaseMapOffset = parameters.BaseMapOffset,

                MetallicGlossMap = parameters.MetallicGlossMap,
                Metallic = parameters.Metallic,
                Smoothness = parameters.Smoothness,

                BumpScale = parameters.BumpScale,
                BumpMap = parameters.BumpMap,

                //EmissionEnabled = parameters.EmissionEnabled,
                EmissionColor = parameters.EmissionColor,
                EmissionMap = parameters.EmissionMap,

                FlipbookBlending = parameters.FlipbookBlending,

                SoftParticlesEnabled = parameters.SoftParticlesEnabled,
                SoftParticleFadeParams = parameters.SoftParticleFadeParams,  // @important
                SoftParticlesNearFadeDistance = parameters.SoftParticlesNearFadeDistance,
                SoftParticlesFarFadeDistance = parameters.SoftParticlesFarFadeDistance,

                CameraFadingEnabled = parameters.CameraFadingEnabled,
                CameraFadeParams = parameters.CameraFadeParams,  // @important
                CameraNearFadeDistance = parameters.CameraNearFadeDistance,
                CameraFarFadeDistance = parameters.CameraFarFadeDistance,

                DistortionEnabled = parameters.DistortionEnabled,
                DistortionBlend = parameters.DistortionBlend,
                DistortionStrength = parameters.DistortionStrength,
                DistortionStrengthScaled = parameters.DistortionStrengthScaled,

                //BlendOp = parameters.BlendOp,
                //SrcBlend = parameters.SrcBlend,
                //DstBlend = parameters.DstBlend,
                //ZWrite = parameters.ZWrite,

                //Mode = materialProxy.Mode,
                //FlipBookMode = materialProxy.FlipBookMode,
                //Color = materialProxy.Color,
                //Glossiness = materialProxy.Glossiness,

                //MainTex = materialProxy.MainTex,
                //MainTexSt = materialProxy.MainTexSt,
            };

            // @notice after set RenderMode
            bool zWrite = materialProxy.ZWrite;

            bool useSoftParticles = parameters.SoftParticlesEnabled && zWrite == false;

            material.SetSafeKeyword(Keyword.SoftParticlesOn, useSoftParticles);

            bool useFading = parameters.CameraFadingEnabled && zWrite == false;

            material.SetSafeKeyword(Keyword.FadingOn, useFading);

            bool useDistortion = parameters.DistortionEnabled && zWrite == false;

            material.SetSafeKeyword(Keyword.DistortionOn, useDistortion);

            material.SetShaderPassEnabled("Always", useDistortion);
        }
    }
}