// ----------------------------------------------------------------------
// @Namespace : UniSkyboxShader
// @Class     : Property
// ----------------------------------------------------------------------
namespace UniSkyboxShader
{
    /// <summary>
    /// Property
    /// </summary>
    public class Property
    {
        /// <summary>Tint</summary>
        public const string Tint = "_Tint";

        /// <summary>Exposure</summary>
        public const string Exposure = "_Exposure";

        /// <summary>Rotation</summary>
        public const string Rotation = "_Rotation";

        #region 6 Sided

        /// <summary>Front Texture</summary>
        public const string FrontTex = "_FrontTex";

        /// <summary>Back Texture</summary>
        public const string BackTex = "_BackTex";

        /// <summary>Left Texture</summary>
        public const string LeftTex = "_LeftTex";

        /// <summary>Right Texture</summary>
        public const string RightTex = "_RightTex";

        /// <summary>Up Texture</summary>
        public const string UpTex = "_UpTex";

        /// <summary>Down Texture</summary>
        public const string DownTex = "_DownTex";

        #endregion

        #region Cubemap

        /// <summary>Tex</summary>
        public const string Tex = "_Tex";

        #endregion

        #region Panoramic

        /// <summary>Main Texture</summary>
        public const string MainTex = "_MainTex";

        /// <summary>Mapping</summary>
        public const string Mapping = "_Mapping";

        /// <summary>Image Type</summary>
        public const string ImageType = "_ImageType";

        /// <summary>Mirror on Back</summary>
        public const string MirrorOnBack = "_MirrorOnBack";

        /// <summary>3D Layout</summary>
        public const string Layout = "_Layout";

        #endregion

        #region Procedural

        /// <summary>Sun Disk</summary>
        public const string SunDisk = "_SunDisk";

        /// <summary>Sun Size</summary>
        public const string SunSize = "_SunSize";

        /// <summary>Sun Size Convergence</summary>
        public const string SunSizeConvergence = "_SunSizeConvergence";

        /// <summary>Atmosphere Thickness</summary>
        public const string AtmosphereThickness = "_AtmosphereThickness";

        /// <summary>Sky Tint Color</summary>
        public const string SkyTint = "_SkyTint";

        /// <summary>Ground Color</summary>
        public const string GroundColor = "_GroundColor";

        #endregion
    }
}