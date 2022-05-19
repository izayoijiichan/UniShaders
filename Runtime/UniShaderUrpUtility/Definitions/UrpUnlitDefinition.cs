// ----------------------------------------------------------------------
// @Namespace : UniUrpShader
// @Class     : UrpUnlitDefinition
// ----------------------------------------------------------------------
namespace UniUrpShader
{
    using System;

    /// <summary>
    /// Universal Render Pipeline/Unlit Definition
    /// </summary>
    /// <remarks>
    /// com.unity.render-pipelines.universal
    /// Unlit.shader
    /// </remarks>
    public class UrpUnlitDefinition : UrpDefinitionBase
    {
        #region Properties

        /// <summary>Blend Op</summary>
        //[DefaultValue(0.0f)]
        public float BlendOp { get; set; }

        #endregion

        #region Obsolete Properties

        /// <summary>Sample GI</summary>
        //[DefaultValue(0.0f)]
        [Obsolete("Obsolete")]
        public float SampleGI { get; set; }

        #endregion
    }
}