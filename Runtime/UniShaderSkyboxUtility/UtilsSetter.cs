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
        public static void SetParametersToMaterial<T>(Material material, in T parameters)
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
        private static void SetSkybox6SidedParametersToMaterial(Material material, in Skybox6SidedDefinition parameters)
        {
            new Skybox6SidedMaterialProxy(material)
            {
                Tint = parameters.Tint,
                Exposure = parameters.Exposure,
                Rotation = parameters.Rotation,
                FrontTex = parameters.FrontTex,
                BackTex = parameters.BackTex,
                LeftTex = parameters.LeftTex,
                RightTex = parameters.RightTex,
                UpTex = parameters.UpTex,
                DownTex = parameters.DownTex,
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <param name="parameters"></param>
        private static void SetSkyboxCubemapParametersToMaterial(Material material, in SkyboxCubemapDefinition parameters)
        {
            new SkyboxCubemapMaterialProxy(material)
            {
                Tint = parameters.Tint,
                Exposure = parameters.Exposure,
                Rotation = parameters.Rotation,
                Tex = parameters.Tex,
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <param name="parameters"></param>
        private static void SetSkyboxPanoramicParametersToMaterial(Material material, in SkyboxPanoramicDefinition parameters)
        {
            new SkyboxPanoramicMaterialProxy(material)
            {
                Tint = parameters.Tint,
                Exposure = parameters.Exposure,
                Rotation = parameters.Rotation,
                MainTex = parameters.MainTex,
                Mapping = parameters.Mapping,
                ImageType = parameters.ImageType,
                MirrorOnBack = parameters.MirrorOnBack,
                Layout = parameters.Layout,
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="material"></param>
        /// <param name="parameters"></param>
        private static void SetSkyboxProceduralParametersToMaterial(Material material, in SkyboxProceduralDefinition parameters)
        {
            new SkyboxProceduralMaterialProxy(material)
            {
                SunDisk = parameters.SunDisk,
                SunSize = parameters.SunSize,
                SunSizeConvergence = parameters.SunSizeConvergence,
                AtmosphereThickness = parameters.AtmosphereThickness,
                SkyTint = parameters.SkyTint,
                GroundColor = parameters.GroundColor,
                Exposure = parameters.Exposure,
            };
        }
    }
}