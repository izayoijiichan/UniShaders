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
            var materialProxy = new Skybox6SidedMaterialProxy(material);

            return new Skybox6SidedDefinition
            {
                Tint = materialProxy.Tint,
                Exposure = materialProxy.Exposure,
                Rotation = materialProxy.Rotation,
                FrontTex = materialProxy.FrontTex,
                BackTex = materialProxy.BackTex,
                LeftTex = materialProxy.LeftTex,
                RightTex = materialProxy.RightTex,
                UpTex = materialProxy.UpTex,
                DownTex = materialProxy.DownTex,
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        private static SkyboxCubemapDefinition GetSkyboxCubemapParametersFromMaterial(Material material)
        {
            var materialProxy = new SkyboxCubemapMaterialProxy(material);

            return new SkyboxCubemapDefinition
            {
                Tint = materialProxy.Tint,
                Exposure = materialProxy.Exposure,
                Rotation = materialProxy.Rotation,
                Tex = materialProxy.Tex,
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        private static SkyboxPanoramicDefinition GetSkyboxPanoramicParametersFromMaterial(Material material)
        {
            var materialProxy = new SkyboxPanoramicMaterialProxy(material);

            return new SkyboxPanoramicDefinition
            {
                Tint = materialProxy.Tint,
                Exposure = materialProxy.Exposure,
                Rotation = materialProxy.Rotation,
                MainTex = materialProxy.MainTex,
                Mapping = materialProxy.Mapping,
                ImageType = materialProxy.ImageType,
                MirrorOnBack = materialProxy.MirrorOnBack,
                Layout = materialProxy.Layout,
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <returns></returns>
        private static SkyboxProceduralDefinition GetSkyboxProceduralParametersFromMaterial(Material material)
        {
            var materialProxy = new SkyboxProceduralMaterialProxy(material);

            return new SkyboxProceduralDefinition
            {
                SunDisk = materialProxy.SunDisk, 
                SunSize = materialProxy.SunSize,
                SunSizeConvergence = materialProxy.SunSizeConvergence,
                AtmosphereThickness = materialProxy.AtmosphereThickness,
                SkyTint = materialProxy.SkyTint,
                GroundColor = materialProxy.GroundColor,
                Exposure = materialProxy.Exposure,
            };
        }
    }
}