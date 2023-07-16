// ----------------------------------------------------------------------
// @Namespace : UniStandardShader
// @Class     : Utils
// ----------------------------------------------------------------------
namespace UniStandardShader
{
    using UnityEngine;

    public static class Utils
    {
        /// <summary>
        /// Get the parameters from the material.
        /// </summary>
        /// <param name="material">The standard material.</param>
        /// <returns></returns>
        public static StandardDefinition GetParametersFromMaterial(Material material)
        {
            var materialProxy = new StandardMaterialProxy(material);

            return new StandardDefinition
            {
                Mode = materialProxy.Mode,
                Color = materialProxy.Color,
                MainTex = materialProxy.MainTex,
                Cutoff = materialProxy.Cutoff,
                Glossiness = materialProxy.Glossiness,
                GlossMapScale = materialProxy.GlossMapScale,
                SmoothnessTextureChannel = materialProxy.SmoothnessTextureChannel,
                Metallic = materialProxy.Metallic,
                MetallicGlossMap = materialProxy.MetallicGlossMap,
                SpecularHighlights = materialProxy.SpecularHighlights,
                GlossyReflections = materialProxy.GlossyReflections,
                BumpScale = materialProxy.BumpScale,
                BumpMap = materialProxy.BumpMap,
                Parallax = materialProxy.Parallax,
                ParallaxMap = materialProxy.ParallaxMap,
                OcclusionStrength = materialProxy.OcclusionStrength,
                OcclusionMap = materialProxy.OcclusionMap,
                EmissionColor = materialProxy.EmissionColor,
                EmissionMap = materialProxy.EmissionMap,
                DetailMask = materialProxy.DetailMask,
                DetailAlbedoMap = materialProxy.DetailAlbedoMap,
                DetailNormalMapScale = materialProxy.DetailNormalMapScale,
                DetailNormalMap = materialProxy.DetailNormalMap,
                UVSec = materialProxy.UVSec,
            };
        }

        /// <summary>
        /// Set the parameter value to the material.
        /// </summary>
        /// <param name="material">The standard material.</param>
        /// <param name="parameters"></param>
        public static void SetParametersToMaterial(Material material, in StandardDefinition parameters)
        {
            var materialProxy = new StandardMaterialProxy(material)
            {
                Mode = parameters.Mode,
                Color = parameters.Color,
                MainTex = parameters.MainTex,
                Cutoff = parameters.Cutoff,
                Glossiness = parameters.Glossiness,
                GlossMapScale = parameters.GlossMapScale,
                SmoothnessTextureChannel = parameters.SmoothnessTextureChannel,
                Metallic = parameters.Metallic,
                MetallicGlossMap = parameters.MetallicGlossMap,
                SpecularHighlights = parameters.SpecularHighlights,
                GlossyReflections = parameters.GlossyReflections,
                BumpScale = parameters.BumpScale,
                BumpMap = parameters.BumpMap,
                Parallax = parameters.Parallax,
                ParallaxMap = parameters.ParallaxMap,
                OcclusionStrength = parameters.OcclusionStrength,
                OcclusionMap = parameters.OcclusionMap,
                EmissionColor = parameters.EmissionColor,
                EmissionMap = parameters.EmissionMap,
                DetailMask = parameters.DetailMask,
                DetailAlbedoMap = parameters.DetailAlbedoMap,
                DetailNormalMapScale = parameters.DetailNormalMapScale,
                DetailNormalMap = parameters.DetailNormalMap,
                UVSec = parameters.UVSec
            };

            // @notice
            materialProxy.SetKeyword(Keyword.DetailMulx2, (parameters.DetailMask != null) || (parameters.DetailAlbedoMap != null) || (parameters.DetailNormalMap != null));
        }

        /// <summary>
        /// Sets the mode.
        /// </summary>
        /// <param name="material"></param>
        /// <param name="mode"></param>
        public static void SetMode(Material material, in AlphaMode mode)
        {
            var materialProxy = new StandardMaterialProxy(material);

            materialProxy.SetMode(mode);
        }
    }
}