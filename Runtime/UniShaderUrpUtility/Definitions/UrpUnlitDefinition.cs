// ----------------------------------------------------------------------
// @Namespace : UniUrpShader
// @Class     : UrpUnlitDefinition
// ----------------------------------------------------------------------
namespace UniUrpShader
{
    using System;
    using UnityEngine.Rendering;

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

        /// <summary>Blend Operator</summary>
        //[DefaultValue(BlendOp.Add)]
        public BlendOp BlendOp { get; set; }

        #endregion

        #region Obsolete Properties

        /// <summary>Sample GI</summary>
        //[DefaultValue(0.0f)]
        [Obsolete("Obsolete")]
        public float SampleGI { get; set; }

        #endregion
    }
}