// ----------------------------------------------------------------------
// @Namespace : UniHdrpShader
// @Class     : HdrpEyeDefinition
// ----------------------------------------------------------------------
namespace UniHdrpShader
{
    using UnityEngine;

    /// <summary>
    /// HDRP/Eye Definition
    /// </summary>
    /// <remarks>
    /// com.unity.render-pipelines.high-definition
    /// Eye.shadergraph
    /// </remarks>
    public class HdrpEyeDefinition : HdrpDefinitionBase
    {
        /// <summary>Sclera Texture</summary>
        public Texture2D Texture2D_5F873FC1 { get; set; }

        /// <summary>Sclera Normal Map</summary>
        public Texture2D Texture2D_B9F5688C { get; set; }

        /// <summary>Sclera Normal Map Strength</summary>
        public float Vector1_70564D59 { get; set; }

        /// <summary>Iris Texture</summary>
        public Texture2D Texture2D_D8BF6575 { get; set; }

        /// <summary>Iris Normal Map</summary>
        public Texture2D Texture2D_4DB28C10 { get; set; }

        /// <summary>Iris Normal Map Strength</summary>
        public float Vector1_FC0895C8 { get; set; }

        /// <summary>Iris Clamp Color</summary>
        public Color Color_83777D09 { get; set; }

        /// <summary>Pupil Radius</summary>
        public float Vector1_DFF948F3 { get; set; }

        /// <summary>Pupil Debug Mode</summary>
        public bool Boolean_8D34052F { get; set; }

        /// <summary>Pupil Aperture</summary>
        public float Vector1_FEA38ABB { get; set; }

        /// <summary>Minimal Pupil Aperture</summary>
        public float Vector1_2D21A623 { get; set; }

        /// <summary>Maximal Pupil Aperture</summary>
        public float Vector1_49C490F5 { get; set; }

        /// <summary>Sclera Smoothness</summary>
        public float Vector1_F084AE9E { get; set; }

        /// <summary>Cornea Smoothness</summary>
        public float Vector1_8F0D1174 { get; set; }

        /// <summary>Iris Offset</summary>
        public float Vector1_76BF2124 { get; set; }

        /// <summary>Limbal Ring Size Iris</summary>
        public float Vector1_C4ED1456 { get; set; }

        /// <summary>Limbal Ring Size Sclera</summary>
        public float Vector1_94E1614A { get; set; }

        /// <summary>Limbal Ring Fade</summary>
        public float Vector1_6C2C412D { get; set; }

        /// <summary>Limbal Ring Intensity</summary>
        public float Vector1_A6DA845F { get; set; }

        /// <summary>Iris Diffusion Profile</summary>
        public float DiffusionProfile_bfbe0deb8ec4428a9cfcdb968651903c { get; set; }

        /// <summary></summary>
        public Vector4 DiffusionProfile_bfbe0deb8ec4428a9cfcdb968651903c_Asset { get; set; }

        /// <summary>Sclera Diffusion Profile</summary>
        public float DiffusionProfile_261f48f1fbc94ccbafc421414859c159 { get; set; }

        /// <summary></summary>
        public Vector4 DiffusionProfile_261f48f1fbc94ccbafc421414859c159_Asset { get; set; }
    }
}