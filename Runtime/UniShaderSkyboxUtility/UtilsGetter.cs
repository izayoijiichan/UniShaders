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
        /// <returns></returns>
        public static T GetParametersFromMaterial<T>(Material material) where T : class
        {
            Type type = typeof(T);

            if (type == Skybox6SidedDefinitionType)
            {
                return GetSkybox6SidedParametersFromMaterial(material) as T;
            }
            else if (type == SkyboxCubemapDefinitionType)
            {
                return GetSkyboxCubemapParametersFromMaterial(material) as T;
            }
            else if (type == SkyboxPanoramicDefinitionType)
            {
                return GetSkyboxPanoramicParametersFromMaterial(material) as T;
            }
            else if (type == SkyboxProceduralDefinitionType)
            {
                return GetSkyboxProceduralParametersFromMaterial(material) as T;
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
        /// <returns></returns>
        private static Skybox6SidedDefinition GetSkybox6SidedParametersFromMaterial(Material material)
        {
            return new Skybox6SidedDefinition
            {
                Tint = GetColor(material, Property.Tint),
                Exposure = GetFloat(material, Property.Exposure),
                Rotation = GetInt(material, Property.Rotation),
                FrontTex = GetTexture(material, Property.FrontTex),
                BackTex = GetTexture(material, Property.BackTex),
                LeftTex = GetTexture(material, Property.LeftTex),
                RightTex = GetTexture(material, Property.RightTex),
                UpTex = GetTexture(material, Property.UpTex),
                DownTex = GetTexture(material, Property.DownTex),
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        private static SkyboxCubemapDefinition GetSkyboxCubemapParametersFromMaterial(Material material)
        {
            return new SkyboxCubemapDefinition
            {
                Tint = GetColor(material, Property.Tint),
                Exposure = GetFloat(material, Property.Exposure),
                Rotation = GetInt(material, Property.Rotation),
                Tex = GetCubemap(material, Property.Tex),
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        private static SkyboxPanoramicDefinition GetSkyboxPanoramicParametersFromMaterial(Material material)
        {
            return new SkyboxPanoramicDefinition
            {
                Tint = GetColor(material, Property.Tint),
                Exposure = GetFloat(material, Property.Exposure),
                Rotation = GetInt(material, Property.Rotation),
                MainTex = GetTexture(material, Property.MainTex),
                Mapping = GetMapping(material),
                ImageType = GetImageType(material),
                MirrorOnBack = GetBool(material, Property.MirrorOnBack),
                Layout = GetLayout(material),
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        private static SkyboxProceduralDefinition GetSkyboxProceduralParametersFromMaterial(Material material)
        {
            return new SkyboxProceduralDefinition
            {
                SunDisk = GetSunDisk(material), 
                SunSize = GetFloat(material, Property.SunSize),
                SunSizeConvergence = GetInt(material, Property.SunSizeConvergence),
                AtmosphereThickness = GetFloat(material, Property.AtmosphereThickness),
                SkyTint = GetColor(material, Property.SkyTint),
                GroundColor = GetColor(material, Property.GroundColor),
                Exposure = GetFloat(material, Property.Exposure),
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        private static bool GetBool(Material material, string propertyName)
        {
            if (material.HasProperty(propertyName))
            {
                return material.GetInt(propertyName) == 1;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        private static Color GetColor(Material material, string propertyName)
        {
            if (material.HasProperty(propertyName))
            {
                return material.GetColor(propertyName);
            }
            else
            {
                return default;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        private static float GetFloat(Material material, string propertyName)
        {
            if (material.HasProperty(propertyName))
            {
                return material.GetFloat(propertyName);
            }
            else
            {
                return 0.0f;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        private static int GetInt(Material material, string propertyName)
        {
            if (material.HasProperty(propertyName))
            {
                return material.GetInt(propertyName);
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        private static Texture2D GetTexture(Material material, string propertyName)
        {
            if (material.HasProperty(propertyName))
            {
                return (Texture2D)material.GetTexture(propertyName);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        private static Cubemap GetCubemap(Material material, string propertyName)
        {
            if (material.HasProperty(propertyName))
            {
                return (Cubemap)material.GetTexture(propertyName);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        private static Mapping GetMapping(Material material)
        {
            if (GetInt(material, Property.Mapping) == 1)
            {
                return Mapping.LatitudeLongitudeLayout;
            }
            else
            {
                return Mapping.SixFramesLayout;
            }

            //if (material.IsKeywordEnabled(KeyMapping6FramesLayout))
            //{
            //    return Mapping.SixFramesLayout;
            //}
            //else
            //{
            //    return Mapping.LatitudeLongitudeLayout;
            //}
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        private static ImageType GetImageType(Material material)
        {
            if (GetInt(material, Property.ImageType) == 1)
            {
                return ImageType.Degrees180;
            }
            else
            {
                return ImageType.Degrees360;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        private static Layout GetLayout(Material material)
        {
            int iLayout = GetInt(material, Property.Layout);

            if (iLayout == 1)
            {
                return Layout.SideBySide;
            }
            if (iLayout == 2)
            {
                return Layout.OverUnder;
            }
            else
            {
                return Layout.None;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        private static SunDisk GetSunDisk(Material material)
        {
            int iSunDisk = GetInt(material, Property.SunDisk);

            if (iSunDisk == 1)
            {
                return SunDisk.Simple;
            }
            if (iSunDisk == 2)
            {
                return SunDisk.HighQuality;
            }
            else
            {
                return SunDisk.None;
            }
        }
    }
}