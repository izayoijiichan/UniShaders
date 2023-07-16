// ----------------------------------------------------------------------
// @Namespace : UniUrpShader
// @Class     : UrpLitMaterialProxy
// ----------------------------------------------------------------------
namespace UniUrpShader
{
    using System;
    using UniShader.Shared;
    using UnityEngine;

    /// <summary>
    /// URP Lit Material Proxy
    /// </summary>
    /// <remarks>
    /// com.unity.render-pipelines.universal
    /// Lit.shader
    /// </remarks>
    public class UrpLitMaterialProxy : UrpLitMaterialProxyBase
    {
        #region Properties

        /// <summary>Workflow Mode</summary>
        public WorkflowMode WorkflowMode
        {
            get => _Material.GetSafeEnum<WorkflowMode>(Property.WorkflowMode, WorkflowMode.Metallic);
            set
            {
                _Material.SetSafeInt(Property.WorkflowMode, (int)value);

                _Material.SetSafeKeyword(Keyword.SpecularSetup, value == WorkflowMode.Specular);
            }
        }

        /// <summary>Smoothness Texture Channel</summary>
        public SmoothnessTextureChannel SmoothnessTextureChannel
        {
            get => _Material.GetSafeEnum<SmoothnessTextureChannel>(Property.SmoothnessTextureChannel, SmoothnessTextureChannel.MetallicAlpha);
            set
            {
                _Material.SetSafeInt(Property.SmoothnessTextureChannel, (int)value);

                _Material.SetSafeKeyword(Keyword.SmoothnessTextureAlbedoChannelA, value == SmoothnessTextureChannel.AlbedoAlpha);
            }
        }

        /// <summary>Metallic</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float Metallic
        {
            get => _Material.GetSafeFloat(Property.Metallic, PropertyRange.Metallic.defaultValue);
            set => _Material.SetSafeFloat(Property.Metallic, PropertyRange.Metallic, value);
        }

        /// <summary>Metallic Gloss Map</summary>
        public Texture2D MetallicGlossMap
        {
            get => _Material.GetSafeTexture(Property.MetallicGlossMap);
            set => _Material.SetSafeTexture(Property.MetallicGlossMap, value);
        }

        /// <summary>Environment Reflections</summary>
        //[DefaultValue(true)]
        public bool EnvironmentReflections
        {
            get => _Material.GetSafeBool(Property.EnvironmentReflections, true);
            set
            {
                _Material.SetSafeBool(Property.EnvironmentReflections, value);

                _Material.SetSafeKeyword(Keyword.EnvironmentReflectionsOff, value == false);
            }
        }

        /// <summary>Parallax Scale</summary>
        //[Range(0.005f, 0.08f)]
        //[DefaultValue(0.005f)]
        public float Parallax
        {
            get => _Material.GetSafeFloat(Property.Parallax, PropertyRange.Parallax.defaultValue);
            set => _Material.SetSafeFloat(Property.Parallax, PropertyRange.Parallax, value);
        }

        /// <summary>Parallax Map (Height Map)</summary>
        public Texture2D ParallaxMap
        {
            get => _Material.GetSafeTexture(Property.ParallaxMap);
            set
            {
                _Material.SetSafeKeyword(Keyword.ParallaxMap, value != null);

                _Material.SetSafeTexture(Property.ParallaxMap, value);
            }
        }

        /// <summary>Occlusion Strength</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(1.0f)]
        public float OcclusionStrength
        {
            get => _Material.GetSafeFloat(Property.OcclusionStrength, PropertyRange.OcclusionStrength.defaultValue);
            set => _Material.SetSafeFloat(Property.OcclusionStrength, PropertyRange.OcclusionStrength, value);
        }

        /// <summary>Occlusion Map</summary>
        public Texture2D OcclusionMap
        {
            get => _Material.GetSafeTexture(Property.OcclusionMap);
            set
            {
                _Material.SetSafeKeyword(Keyword.OcclusionMap, value != null);

                _Material.SetSafeTexture(Property.OcclusionMap, value);
            }
        }

        /// <summary>Detail Mask</summary>
        public Texture2D DetailMask
        {
            get => _Material.GetSafeTexture(Property.DetailMask);
            set => _Material.SetSafeTexture(Property.DetailMask, value);
        }

        /// <summary>Detail Albedo Map Scale</summary>
        //[Range(0.0f, 2.0f)]
        //[DefaultValue(1.0f)]
        public float DetailAlbedoMapScale
        {
            get => _Material.GetSafeFloat(Property.DetailAlbedoMapScale, PropertyRange.DetailAlbedoMapScale.defaultValue);
            set => _Material.SetSafeFloat(Property.DetailAlbedoMapScale, PropertyRange.DetailAlbedoMapScale, value);
        }

        /// <summary>Detail Albedo Map</summary>
        public Texture2D DetailAlbedoMap
        {
            get => _Material.GetSafeTexture(Property.DetailAlbedoMap);
            set => _Material.SetSafeTexture(Property.DetailAlbedoMap, value);
        }

        /// <summary>Detail Normal Map Scale</summary>
        //[Range(0.0f, 2.0f)]
        //[DefaultValue(1.0f)]
        public float DetailNormalMapScale
        {
            get => _Material.GetSafeFloat(Property.DetailNormalMapScale, PropertyRange.DetailNormalMapScale.defaultValue);
            set => _Material.SetSafeFloat(Property.DetailNormalMapScale, PropertyRange.DetailNormalMapScale, value);
        }

        /// <summary>Detail Normal Map</summary>
        public Texture2D DetailNormalMap
        {
            get => _Material.GetSafeTexture(Property.DetailNormalMap);
            set => _Material.SetSafeTexture(Property.DetailNormalMap, value);
        }

        /// <summary>Clear Coat Mask</summary>
        //[DefaultValue(false)]
        public bool ClearCoatMask
        {
            get => _Material.GetSafeBool(Property.ClearCoatMask, false);
            set => _Material.SetSafeBool(Property.ClearCoatMask, value);
        }

        /// <summary>Clear Coat Smoothness</summary>
        //[DefaultValue(false)]
        public bool ClearCoatSmoothness
        {
            get => _Material.GetSafeBool(Property.ClearCoatSmoothness, false);
            set => _Material.SetSafeBool(Property.ClearCoatSmoothness, value);
        }

        #endregion

        #region Obsolete Properties

        /// <summary>Gloss Map Scale</summary>
        //[DefaultValue(0.0f)]
        [Obsolete("Obsolete")]
        public float GlossMapScale
        {
            get => _Material.GetSafeFloat(Property.GlossMapScale, 0.0f);
            set => _Material.SetSafeFloat(Property.GlossMapScale, PropertyRange.GlossMapScale, value);
        }

        /// <summary>Glossiness</summary>
        //[DefaultValue(0.0f)]
        [Obsolete("Obsolete")]
        public float Glossiness
        {
            get => _Material.GetSafeFloat(Property.Glossiness, 0.0f);
            set => _Material.SetSafeFloat(Property.Glossiness, PropertyRange.Glossiness, value);
        }

        /// <summary>Glossy Reflections</summary>
        //[DefaultValue(0.0f)]
        [Obsolete("Obsolete")]
        public float GlossyReflections
        {
            get => _Material.GetSafeFloat(Property.Glossiness, 0.0f);
            set => _Material.SetSafeFloat(Property.Glossiness, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of UrpLitMaterialProxy.
        /// </summary>
        /// <param name="material">The URP lit material.</param>
        public UrpLitMaterialProxy(Material material) : base(material)
        {
            if (material == null)
            {
                throw new ArgumentNullException(nameof(material));
            }

            if (material.shader == null)
            {
                throw new ArgumentException();
            }

            if (material.shader.name == null)
            {
                throw new ArgumentException();
            }

            if (material.shader.name != ShaderName.URP_Lit)
            {
                throw new ArgumentException();
            }
        }

        #endregion
    }
}