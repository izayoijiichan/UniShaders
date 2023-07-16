// ----------------------------------------------------------------------
// @Namespace : UniHdrpShader
// @Class     : HdrpEyeMaterialProxy
// ----------------------------------------------------------------------
namespace UniHdrpShader
{
    using System;
    using UniShader.Shared;
    using UnityEngine;

    /// <summary>
    /// HDRP Eye Material Proxy
    /// </summary>
    /// <remarks>
    /// com.unity.render-pipelines.high-definition
    /// Eye.shadergraph
    /// </remarks>
    public class HdrpEyeMaterialProxy : HdrpMaterialProxyBase
    {
        #region Properties

        /// <summary>Sclera Texture</summary>
        public Texture2D Texture2D_5F873FC1
        {
            get => _Material.GetSafeTexture(Property.Texture2D_5F873FC1);
            set => _Material.SetSafeTexture(Property.Texture2D_5F873FC1, value);
        }

        /// <summary>Sclera Normal Map</summary>
        public Texture2D Texture2D_B9F5688C
        {
            get => _Material.GetSafeTexture(Property.Texture2D_B9F5688C);
            set => _Material.SetSafeTexture(Property.Texture2D_B9F5688C, value);
        }

        /// <summary>Sclera Normal Map Strength</summary>
        //[Range(0.0f, 8.0f)]
        //[DefaultValue(1.0f)]
        public float Vector1_70564D59
        {
            get => _Material.GetSafeFloat(Property.Vector1_70564D59, PropertyRange.Vector1_70564D59.defaultValue);
            set => _Material.SetSafeFloat(Property.Vector1_70564D59, PropertyRange.Vector1_70564D59, value);
        }

        /// <summary>Iris Texture</summary>
        public Texture2D Texture2D_D8BF6575
        {
            get => _Material.GetSafeTexture(Property.Texture2D_D8BF6575);
            set => _Material.SetSafeTexture(Property.Texture2D_D8BF6575, value);
        }

        /// <summary>Iris Normal Map</summary>
        public Texture2D Texture2D_4DB28C10
        {
            get => _Material.GetSafeTexture(Property.Texture2D_4DB28C10);
            set => _Material.SetSafeTexture(Property.Texture2D_4DB28C10, value);
        }

        /// <summary>Iris Normal Map Strength</summary>
        //[Range(0.0f, 8.0f)]
        //[DefaultValue(0.0f)]
        public float Vector1_FC0895C8
        {
            get => _Material.GetSafeFloat(Property.Vector1_FC0895C8, PropertyRange.Vector1_FC0895C8.defaultValue);
            set => _Material.SetSafeFloat(Property.Vector1_FC0895C8, PropertyRange.Vector1_FC0895C8, value);
        }

        /// <summary>Iris Clamp Color</summary>
        //[DefaultValue(0.5188679099082947f, 0.5188679099082947f, 0.5188679099082947f, 0.0f)]
        public Color Color_83777D09
        {
            get => _Material.GetSafeColor(Property.Color_83777D09, new Color(0.5188679099082947f, 0.5188679099082947f, 0.5188679099082947f, 0.0f));
            set => _Material.SetSafeColor(Property.Color_83777D09, value);
        }

        /// <summary>Pupil Radius</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float Vector1_DFF948F3
        {
            get => _Material.GetSafeFloat(Property.Vector1_DFF948F3, PropertyRange.Vector1_DFF948F3.defaultValue);
            set => _Material.SetSafeFloat(Property.Vector1_DFF948F3, PropertyRange.Vector1_DFF948F3, value);
        }

        /// <summary>Pupil Debug Mode</summary>
        //[DefaultValue(false)]
        public bool Boolean_8D34052F
        {
            get => _Material.GetSafeBool(Property.Boolean_8D34052F, false);
            set => _Material.SetSafeBool(Property.Boolean_8D34052F, value);
        }

        /// <summary>Pupil Aperture</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.5f)]
        public float Vector1_FEA38ABB
        {
            get => _Material.GetSafeFloat(Property.Vector1_FEA38ABB, PropertyRange.Vector1_FEA38ABB.defaultValue);
            set => _Material.SetSafeFloat(Property.Vector1_FEA38ABB, PropertyRange.Vector1_FEA38ABB, value);
        }

        /// <summary>Minimal Pupil Aperture</summary>
        //[Range(0.0f, 0.3f)]
        //[DefaultValue(0.05f)]
        public float Vector1_2D21A623
        {
            get => _Material.GetSafeFloat(Property.Vector1_2D21A623, PropertyRange.Vector1_2D21A623.defaultValue);
            set => _Material.SetSafeFloat(Property.Vector1_2D21A623, PropertyRange.Vector1_2D21A623, value);
        }

        /// <summary>Maximal Pupil Aperture</summary>
        //[Range(0.6f, 0.95f)]
        //[DefaultValue(0.8f)]
        public float Vector1_49C490F5
        {
            get => _Material.GetSafeFloat(Property.Vector1_49C490F5, PropertyRange.Vector1_49C490F5.defaultValue);
            set => _Material.SetSafeFloat(Property.Vector1_49C490F5, PropertyRange.Vector1_49C490F5, value);
        }

        /// <summary>Sclera Smoothness</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float Vector1_F084AE9E
        {
            get => _Material.GetSafeFloat(Property.Vector1_F084AE9E, PropertyRange.Vector1_F084AE9E.defaultValue);
            set => _Material.SetSafeFloat(Property.Vector1_F084AE9E, PropertyRange.Vector1_F084AE9E, value);
        }

        /// <summary>Cornea Smoothness</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float Vector1_8F0D1174
        {
            get => _Material.GetSafeFloat(Property.Vector1_8F0D1174, PropertyRange.Vector1_8F0D1174.defaultValue);
            set => _Material.SetSafeFloat(Property.Vector1_8F0D1174, PropertyRange.Vector1_8F0D1174, value);
        }

        /// <summary>Iris Offset</summary>
        //[Range(-0.02f, 0.02f)]
        //[DefaultValue(0.0f)]
        public float Vector1_76BF2124
        {
            get => _Material.GetSafeFloat(Property.Vector1_76BF2124, PropertyRange.Vector1_76BF2124.defaultValue);
            set => _Material.SetSafeFloat(Property.Vector1_76BF2124, PropertyRange.Vector1_76BF2124, value);
        }

        /// <summary>Limbal Ring Size Iris</summary>
        //[Range(0.01f, 0.3f)]
        //[DefaultValue(0.01f)]
        public float Vector1_C4ED1456
        {
            get => _Material.GetSafeFloat(Property.Vector1_C4ED1456, PropertyRange.Vector1_C4ED1456.defaultValue);
            set => _Material.SetSafeFloat(Property.Vector1_C4ED1456, PropertyRange.Vector1_C4ED1456, value);
        }

        /// <summary>Limbal Ring Size Sclera</summary>
        //[Range(0.01f, 0.2f)]
        //[DefaultValue(0.01f)]
        public float Vector1_94E1614A
        {
            get => _Material.GetSafeFloat(Property.Vector1_94E1614A, PropertyRange.Vector1_94E1614A.defaultValue);
            set => _Material.SetSafeFloat(Property.Vector1_94E1614A, PropertyRange.Vector1_94E1614A, value);
        }

        /// <summary>Limbal Ring Fade</summary>
        //[Range(0.0f, 1.0f)]
        //[DefaultValue(0.0f)]
        public float Vector1_6C2C412D
        {
            get => _Material.GetSafeFloat(Property.Vector1_6C2C412D, PropertyRange.Vector1_6C2C412D.defaultValue);
            set => _Material.SetSafeFloat(Property.Vector1_6C2C412D, PropertyRange.Vector1_6C2C412D, value);
        }

        /// <summary>Limbal Ring Intensity</summary>
        //[Range(0.0f, 5.0f)]
        //[DefaultValue(0.0f)]
        public float Vector1_A6DA845F
        {
            get => _Material.GetSafeFloat(Property.Vector1_A6DA845F, PropertyRange.Vector1_A6DA845F.defaultValue);
            set => _Material.SetSafeFloat(Property.Vector1_A6DA845F, PropertyRange.Vector1_A6DA845F, value);
        }

        /// <summary>Iris Diffusion Profile</summary>
        public float DiffusionProfile_bfbe0deb8ec4428a9cfcdb968651903c
        {
            get => _Material.GetSafeFloat(Property.DiffusionProfile_bfbe0deb8ec4428a9cfcdb968651903c);
            set => _Material.SetSafeFloat(Property.DiffusionProfile_bfbe0deb8ec4428a9cfcdb968651903c, value);
        }

        /// <summary></summary>
        public Vector4 DiffusionProfile_bfbe0deb8ec4428a9cfcdb968651903c_Asset
        {
            get => _Material.GetSafeVector4(Property.DiffusionProfile_bfbe0deb8ec4428a9cfcdb968651903c_Asset);
            set => _Material.SetSafeVector(Property.DiffusionProfile_bfbe0deb8ec4428a9cfcdb968651903c_Asset, value);
        }

        /// <summary>Sclera Diffusion Profile</summary>
        public float DiffusionProfile_261f48f1fbc94ccbafc421414859c159
        {
            get => _Material.GetSafeFloat(Property.DiffusionProfile_261f48f1fbc94ccbafc421414859c159);
            set => _Material.SetSafeFloat(Property.DiffusionProfile_261f48f1fbc94ccbafc421414859c159, value);
        }

        /// <summary></summary>
        public Vector4 DiffusionProfile_261f48f1fbc94ccbafc421414859c159_Asset
        {
            get => _Material.GetSafeVector4(Property.DiffusionProfile_261f48f1fbc94ccbafc421414859c159_Asset);
            set => _Material.SetSafeVector(Property.DiffusionProfile_261f48f1fbc94ccbafc421414859c159_Asset, value);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Create a new instance of HdrpEyeMaterialProxy.
        /// </summary>
        /// <param name="material">The HDRP eye material.</param>
        public HdrpEyeMaterialProxy(Material material) : base(material)
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

            if (material.shader.name != ShaderName.HDRP_Eye)
            {
                throw new ArgumentException();
            }
        }

        #endregion
    }
}