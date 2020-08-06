// ----------------------------------------------------------------------
// @Namespace : UniSkyboxShader
// @Class     : Utils
// ----------------------------------------------------------------------
namespace UniSkyboxShader
{
    using System;
    using UnityEngine;

    public static partial class Utils
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="material"></param>
        /// <param name="parameters"></param>
        public static void SetParametersToMaterial<T>(Material material, T parameters)
        {
            Type type = typeof(T);

            if (type == Skybox6SidedDefinitionType)
            {
                SetSkybox6SidedParametersToMaterial(material, parameters as Skybox6SidedDefinition);
            }
            else if (type == SkyboxCubemapDefinitionType)
            {
                SetSkyboxCubemapParametersToMaterial(material, parameters as SkyboxCubemapDefinition);
            }
            else if (type == SkyboxPanoramicDefinitionType)
            {
                SetSkyboxPanoramicParametersToMaterial(material, parameters as SkyboxPanoramicDefinition);
            }
            else if (type == SkyboxProceduralDefinitionType)
            {
                SetSkyboxProceduralParametersToMaterial(material, parameters as SkyboxProceduralDefinition);
            }
            else
            {
                throw new NotSupportedException();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <param name="parameters"></param>
        private static void SetSkybox6SidedParametersToMaterial(Material material, Skybox6SidedDefinition parameters)
        {
            SetColor(material, Property.Tint, parameters.Tint);
            SetFloat(material, Property.Exposure, parameters.Exposure);
            SetInt(material, Property.Rotation, parameters.Rotation);
            SetTexture(material, Property.FrontTex, parameters.FrontTex);
            SetTexture(material, Property.BackTex, parameters.BackTex);
            SetTexture(material, Property.LeftTex, parameters.LeftTex);
            SetTexture(material, Property.RightTex, parameters.RightTex);
            SetTexture(material, Property.UpTex, parameters.UpTex);
            SetTexture(material, Property.DownTex, parameters.DownTex);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <param name="parameters"></param>
        private static void SetSkyboxCubemapParametersToMaterial(Material material, SkyboxCubemapDefinition parameters)
        {
            SetColor(material, Property.Tint, parameters.Tint);
            SetFloat(material, Property.Exposure, parameters.Exposure);
            SetInt(material, Property.Rotation, parameters.Rotation);
            SetCubemap(material, Property.Tex, parameters.Tex);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <param name="parameters"></param>
        private static void SetSkyboxPanoramicParametersToMaterial(Material material, SkyboxPanoramicDefinition parameters)
        {
            SetColor(material, Property.Tint, parameters.Tint);
            SetFloat(material, Property.Exposure, parameters.Exposure);
            SetInt(material, Property.Rotation, parameters.Rotation);
            SetTexture(material, Property.MainTex, parameters.MainTex);
            SetInt(material, Property.Mapping, (int)parameters.Mapping);
            SetKeyword(material, Keyword.Mapping6FramesLayout, parameters.Mapping == Mapping.SixFramesLayout);
            SetInt(material, Property.ImageType, (int)parameters.ImageType);
            SetBool(material, Property.MirrorOnBack, parameters.MirrorOnBack);
            SetInt(material, Property.Layout, (int)parameters.Layout);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <param name="parameters"></param>
        private static void SetSkyboxProceduralParametersToMaterial(Material material, SkyboxProceduralDefinition parameters)
        {
            SetSunDisk(material, parameters.SunDisk);
            SetFloat(material, Property.SunSize, parameters.SunSize);
            SetInt(material, Property.SunSizeConvergence, parameters.SunSizeConvergence);
            SetFloat(material, Property.AtmosphereThickness, parameters.AtmosphereThickness);
            SetColor(material, Property.SkyTint, parameters.SkyTint);
            SetColor(material, Property.GroundColor, parameters.GroundColor);
            SetFloat(material, Property.Exposure, parameters.Exposure);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <param name="val"></param>
        private static void SetBool(Material material, string propertyName, bool val)
        {
            if (material.HasProperty(propertyName))
            {
                material.SetInt(propertyName, (val == true) ? 1 : 0);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <param name="val"></param>
        private static void SetInt(Material material, string propertyName, int val)
        {
            if (material.HasProperty(propertyName))
            {
                material.SetInt(propertyName, val);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <param name="val"></param>
        private static void SetFloat(Material material, string propertyName, float val)
        {
            if (material.HasProperty(propertyName))
            {
                material.SetFloat(propertyName, val);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <param name="color"></param>
        private static void SetColor(Material material, string propertyName, Color color)
        {
            if (material.HasProperty(propertyName))
            {
                material.SetColor(propertyName, color);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <param name="texture"></param>
        private static void SetTexture(Material material, string propertyName, Texture2D texture)
        {
            if (material.HasProperty(propertyName))
            {
                material.SetTexture(propertyName, texture);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <param name="cubemap"></param>
        private static void SetCubemap(Material material, string propertyName, Cubemap cubemap)
        {
            if (material.HasProperty(propertyName))
            {
                material.SetTexture(propertyName, cubemap);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <param name="keyword"></param>
        /// <param name="required"></param>
        private static void SetKeyword(Material material, string keyword, bool required)
        {
            if (required)
            {
                material.EnableKeyword(keyword);
            }
            else
            {
                material.DisableKeyword(keyword);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <param name="sunDisk"></param>
        public static void SetSunDisk(Material material, SunDisk sunDisk)
        {
            SetInt(material, Property.SunDisk, (int)sunDisk);

            switch (sunDisk)
            {
                case SunDisk.None:
                    SetKeyword(material, Keyword.SundiskNone, true);
                    SetKeyword(material, Keyword.SundiskSimple, false);
                    SetKeyword(material, Keyword.SundiskHighQuality, false);
                    break;
                case SunDisk.Simple:
                    SetKeyword(material, Keyword.SundiskNone, false);
                    SetKeyword(material, Keyword.SundiskSimple, true);
                    SetKeyword(material, Keyword.SundiskHighQuality, false);
                    break;
                case SunDisk.HighQuality:
                    SetKeyword(material, Keyword.SundiskNone, false);
                    SetKeyword(material, Keyword.SundiskSimple, false);
                    SetKeyword(material, Keyword.SundiskHighQuality, true);
                    break;
                default:
                    SetKeyword(material, Keyword.SundiskNone, true);
                    SetKeyword(material, Keyword.SundiskSimple, false);
                    SetKeyword(material, Keyword.SundiskHighQuality, false);
                    break;
            }
        }
    }
}