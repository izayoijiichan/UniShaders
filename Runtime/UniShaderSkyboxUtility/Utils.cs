// ----------------------------------------------------------------------
// @Namespace : UniSkyboxShader
// @Class     : Utils
// ----------------------------------------------------------------------
using System;

namespace UniSkyboxShader
{
    /// <summary>
    /// 
    /// </summary>
    public static partial class Utils
    {
        #region Types

        /// <summary>Skybox/6 Sided</summary>
        public static Type Skybox6SidedDefinitionType = typeof(Skybox6SidedDefinition);

        /// <summary>Skybox/Cubemap</summary>
        public static Type SkyboxCubemapDefinitionType = typeof(SkyboxCubemapDefinition);

        /// <summary>Skybox/Panoramic</summary>
        public static Type SkyboxPanoramicDefinitionType = typeof(SkyboxPanoramicDefinition);

        /// <summary>Skybox/Procedural</summary>
        public static Type SkyboxProceduralDefinitionType = typeof(SkyboxProceduralDefinition);

        #endregion
    }
}