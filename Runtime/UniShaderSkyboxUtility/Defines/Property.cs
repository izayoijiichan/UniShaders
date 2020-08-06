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

        /// <summary>FrontTex</summary>
        public const string FrontTex = "_FrontTex";

        /// <summary>BackTex</summary>
        public const string BackTex = "_BackTex";

        /// <summary>LeftTex</summary>
        public const string LeftTex = "_LeftTex";

        /// <summary>RightTex</summary>
        public const string RightTex = "_RightTex";

        /// <summary>UpTex</summary>
        public const string UpTex = "_UpTex";

        /// <summary>DownTex</summary>
        public const string DownTex = "_DownTex";

        #endregion

        #region Cubemap

        /// <summary>Tex</summary>
        public const string Tex = "_Tex";

        #endregion

        #region Panoramic

        /// <summary>MainTex</summary>
        public const string MainTex = "_MainTex";

        /// <summary>Mapping</summary>
        public const string Mapping = "_Mapping";

        /// <summary>ImageType</summary>
        public const string ImageType = "_ImageType";

        /// <summary>MirrorOnBack</summary>
        public const string MirrorOnBack = "_MirrorOnBack";

        /// <summary>Layout</summary>
        public const string Layout = "_Layout";

        #endregion

        #region Procedural

        /// <summary></summary>
        public const string SunDisk = "_SunDisk";

        /// <summary></summary>
        public const string SunSize = "_SunSize";

        /// <summary></summary>
        public const string SunSizeConvergence = "_SunSizeConvergence";

        /// <summary></summary>
        public const string AtmosphereThickness = "_AtmosphereThickness";

        /// <summary></summary>
        public const string SkyTint = "_SkyTint";

        /// <summary></summary>
        public const string GroundColor = "_GroundColor";

        #endregion
    }
}