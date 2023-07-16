// ----------------------------------------------------------------------
// @Namespace : UniParticleShader
// @Class     : Utils
// ----------------------------------------------------------------------
namespace UniParticleShader
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
        public static ParticleDefinition GetParametersFromMaterial(Material material)
        {
            var materialProxy = new ParticleMaterialProxy(material);

            return new ParticleDefinition
            {
                RenderMode = materialProxy.RenderMode,
                ColorMode = materialProxy.ColorMode,
                FlipBookMode = materialProxy.FlipBookMode,
                Cull = materialProxy.Cull,
                LightingEnabled = materialProxy.LightingEnabled,
                MainTex = materialProxy.MainTex,
                MainTexSt = materialProxy.MainTexSt,
                MainTexScale = materialProxy.MainTexScale,
                MainTexOffset = materialProxy.MainTexOffset,
                Color = materialProxy.Color,
                ColorAddSubDiff = materialProxy.ColorAddSubDiff,
                Cutoff = materialProxy.Cutoff,
                MetallicGlossMap = materialProxy.MetallicGlossMap,
                Metallic = materialProxy.Metallic,
                Glossiness = materialProxy.Glossiness,
                BumpMap = materialProxy.BumpMap,
                BumpScale = materialProxy.BumpScale,
                EmissionEnabled = materialProxy.EmissionEnabled,
                EmissionColor = materialProxy.EmissionColor,
                EmissionMap = materialProxy.EmissionMap,
                GrabTexture = materialProxy.GrabTexture,
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
                DistortionStrengthScaled = materialProxy.DistortionStrengthScaled,
                BlendOp = materialProxy.BlendOp,
                SrcBlend = materialProxy.SrcBlend,
                DstBlend = materialProxy.DstBlend,
                ZWrite = materialProxy.ZWrite,
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        public static BlendMode GetBlendMode(Material material)
        {
            var materialProxy = new ParticleMaterialProxy(material);

            return materialProxy.RenderMode;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        public static ColorMode GetColorMode(Material material)
        {
            var materialProxy = new ParticleMaterialProxy(material);

            return materialProxy.ColorMode;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <param name="parameters"></param>
        public static void SetParametersToMaterial(Material material, in ParticleDefinition parameters)
        {
            var materialProxy = new ParticleMaterialProxy(material)
            {
                RenderMode = parameters.RenderMode,  // @notice
                ColorMode = parameters.ColorMode,    // @notice
                FlipBookMode = parameters.FlipBookMode,
                Cull = parameters.Cull,
                LightingEnabled = parameters.LightingEnabled,
                //MainTex = parameters.MainTex,
                //MainTexSt = parameters.MainTexSt,
                //MainTexScale = parameters.MainTexScale,
                //MainTexOffset = parameters.MainTexOffset,
                Color = parameters.Color,
                ColorAddSubDiff = parameters.ColorAddSubDiff,
                Cutoff = parameters.Cutoff,
                MetallicGlossMap = parameters.MetallicGlossMap,
                Metallic = parameters.Metallic,
                Glossiness = parameters.Glossiness,
                BumpMap = parameters.BumpMap,
                BumpScale = parameters.BumpScale,
                EmissionEnabled = parameters.EmissionEnabled,
                EmissionColor = parameters.EmissionColor,
                EmissionMap = parameters.EmissionMap,
                GrabTexture = parameters.GrabTexture,
                SoftParticlesEnabled = parameters.SoftParticlesEnabled,
                SoftParticleFadeParams = parameters.SoftParticleFadeParams,  // @important
                SoftParticlesNearFadeDistance = parameters.SoftParticlesNearFadeDistance,
                SoftParticlesFarFadeDistance  = parameters.SoftParticlesFarFadeDistance,
                CameraFadingEnabled = parameters.CameraFadingEnabled,
                CameraFadeParams = parameters.CameraFadeParams,  // @important
                CameraNearFadeDistance = parameters.CameraNearFadeDistance,
                CameraFarFadeDistance = parameters.CameraFarFadeDistance,
                DistortionEnabled = parameters.DistortionEnabled,
                DistortionBlend = parameters.DistortionBlend,
                DistortionStrengthScaled = parameters.DistortionStrengthScaled,
                //BlendOp = parameters.BlendOp,
                //SrcBlend = parameters.SrcBlend,
                //DstBlend = parameters.DstBlend,
                //ZWrite = parameters.ZWrite,
            };

            materialProxy.MainTexScale = parameters.MainTexScale;
            materialProxy.MainTexOffset = parameters.MainTexOffset;
            materialProxy.MainTexSt = parameters.MainTexSt;
            materialProxy.MainTex = parameters.MainTex;

            //materialProxy.RenderMode = parameters.RenderMode;
            //materialProxy.ColorMode = parameters.ColorMode;

            // @notice after set RenderMode
            bool zWrite = materialProxy.ZWrite;

            bool useFading = parameters.CameraFadingEnabled && zWrite == false;

            material.SetSafeKeyword(Keyword.FadingOn, useFading);

            bool useDistortion = parameters.DistortionEnabled && zWrite == false;

            material.SetSafeKeyword(Keyword.DistortionOn, useDistortion);

            material.SetSafeKeyword(Keyword.EffectBump, useDistortion);

            material.SetShaderPassEnabled("Always", useDistortion);
        }
    }
}