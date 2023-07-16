// ----------------------------------------------------------------------
// @Namespace : UniSkyboxShader
// @Class     : SkyboxProceduralDefinition
// ----------------------------------------------------------------------
namespace UniSkyboxShader
{
    using UnityEngine;

    /// <summary>
    /// Skybox Procedural Definition
    /// </summary>
    public class SkyboxProceduralDefinition
    {
        /// <summary>Sun</summary>
        public SunDisk SunDisk { get; set; }

        /// <summary>Sun Size</summary>
        //[Range(0.0f, 1.0f)]
        public float SunSize { get; set; }

        /// <summary>Sun Size Convergence</summary>
        //[Range(1f, 10f)]
        public int SunSizeConvergence { get; set; }

        /// <summary>Atmosphere Thickness</summary>
        //[Range(0.0f, 5.0f)]
        public float AtmosphereThickness { get; set; }

        /// <summary>Sky Tint Color</summary>
        public Color SkyTint { get; set; }

        /// <summary>Ground Color</summary>
        public Color GroundColor { get; set; }

        /// <summary>Exposure</summary>
        //[Range(0.0f, 8.0f)]
        public float Exposure { get; set; }
    }
}