// ----------------------------------------------------------------------
// @Namespace : UniUrpShader
// @Class     : UrpDefinitionBase
// ----------------------------------------------------------------------
namespace UniUrpShader
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Basic URP Definition
    /// </summary>
    public abstract class UrpDefinitionBase
    {
        #region Properties

        /// <summary>Base Map</summary>
        public Texture2D BaseMap { get; set; }

        /// <summary>Base Map Scale</summary>
        public Vector2 BaseMapScale { get; set; }

        /// <summary>Base Map Offset</summary>
        public Vector2 BaseMapOffset { get; set; }

        /// <summary>Base Color</summary>
        public Color BaseColor { get; set; }

        /// <summary>Alpha Cutoff</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float Cutoff { get; set; }

        /// <summary>Surface Type</summary>
        //[DefaultValue(SurfaceType.Opaque)]
        public SurfaceType Surface { get; set; }

        /// <summary>Blend Mode</summary>
        //[DefaultValue(BlendMode.Alpha)]
        public BlendMode Blend { get; set; }

        /// <summary>Cull Mode</summary>
        //[DefaultValue(CullMode.Back)]
        public CullMode Cull { get; set; }

        /// <summary>Alpha Clip</summary>
        //[DefaultValue(false)]
        public bool AlphaClip { get; set; }

        /// <summary>Src Blend</summary>
        //[DefaultValue(1.0f)]
        public UnityEngine.Rendering.BlendMode SrcBlend { get; set; }

        /// <summary>Dst Blend</summary>
        //[DefaultValue(0.0f)]
        public UnityEngine.Rendering.BlendMode DstBlend { get; set; }

        /// <summary>Src Blend Alpha</summary>
        //[DefaultValue(1.0f)]
        public UnityEngine.Rendering.BlendMode SrcBlendAlpha { get; set; }

        /// <summary>Dst Blend Alpha</summary>
        //[DefaultValue(0.0f)]
        public UnityEngine.Rendering.BlendMode DstBlendAlpha { get; set; }

        /// <summary>ZWrite</summary>
        //[DefaultValue(true)]
        public bool ZWrite { get; set; }

        /// <summary>Alpha to Mask</summary>
        //[DefaultValue(false)]
        public bool AlphaToMask { get; set; }

        /// <summary>Queue Offset</summary>
        //[Range(-50, 50)]
        //[DefaultValue(0)]
        public int QueueOffset { get; set; }

        #endregion

        #region Obsolete Properties

        /// <summary>Main Texture</summary>
        [Obsolete("Obsolete")]
        public Texture2D MainTex { get; set; }

        /// <summary>Color</summary>
        [Obsolete("Obsolete")]
        public Color Color { get; set; }

        #endregion
    }
}