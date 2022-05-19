// ----------------------------------------------------------------------
// @Namespace : UniUrpShader
// @Class     : UrpLitDefinitionBase
// ----------------------------------------------------------------------
namespace UniUrpShader
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Basic URP Lit Definition
    /// </summary>
    public abstract class UrpLitDefinitionBase : UrpDefinitionBase
    {
        #region Properties

        /// <summary>Smoothness</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float Smoothness { get; set; }

        /// <summary>Specular Color</summary>
        public Color SpecColor { get; set; }

        /// <summary>Specular Gloss Map</summary>
        public Texture2D SpecGlossMap { get; set; }

        /// <summary>Specular Highlights</summary>
        //[DefaultValue(true)]
        public bool SpecularHighlights { get; set; }

        /// <summary>Bump Scale</summary>
        //[DefaultValue(1.0f)]
        public float BumpScale { get; set; }

        /// <summary>Bump Map (Normal Map)</summary>
        public Texture2D BumpMap { get; set; }

        /// <summary>Emission Color</summary>
        public Color EmissionColor { get; set; }

        /// <summary>Emission Map</summary>
        public Texture2D EmissionMap { get; set; }

        /// <summary>Receive Shadows</summary>
        //[DefaultValue(true)]
        public bool ReceiveShadows { get; set; }

        #endregion

        #region Obsolete Properties

        /// <summary>unity_Lightmaps</summary>
        [Obsolete("Obsolete")]
        public Texture2DArray UnityLightmaps { get; set; }

        /// <summary>unity_LightmapsInd</summary>
        [Obsolete("Obsolete")]
        public Texture2DArray UnityLightmapsInd { get; set; }

        /// <summary>unity_ShadowMasks</summary>
        [Obsolete("Obsolete")]
        public Texture2DArray UnityShadowMasks { get; set; }

        #endregion
    }
}