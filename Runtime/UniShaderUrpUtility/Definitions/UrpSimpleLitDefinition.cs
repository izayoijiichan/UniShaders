// ----------------------------------------------------------------------
// @Namespace : UniUrpShader
// @Class     : UrpSimpleLitDefinition
// ----------------------------------------------------------------------
namespace UniUrpShader
{
    using System;

    /// <summary>
    /// Universal Render Pipeline/Simple Lit Definition
    /// </summary>
    /// <remarks>
    /// com.unity.render-pipelines.universal
    /// SimpleLit.shader
    /// </remarks>
    public class UrpSimpleLitDefinition : UrpLitDefinitionBase
    {
        #region Properties

        /// <summary>Smoothness Source</summary>
        //[DefaultValue(0.0f)]
        public float SmoothnessSource { get; set; }

        /// <summary>Blend Mode Preserve Specular</summary>
        //[DefaultValue(1.0f)]
        public float BlendModePreserveSpecular { get; set; }

        #endregion

        #region Obsolete Properties

        /// <summary>Shininess</summary>
        //[DefaultValue(0.0f)]
        [Obsolete("Obsolete")]
        public float Shininess { get; set; }

        /// <summary>Glossiness Source</summary>
        //[DefaultValue(0.0f)]
        [Obsolete("Obsolete")]
        public float GlossinessSource { get; set; }

        /// <summary>Spec Source</summary>
        //[DefaultValue(0.0f)]
        [Obsolete("Obsolete")]
        public float SpecSource { get; set; }

        #endregion
    }
}