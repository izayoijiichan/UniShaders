// ----------------------------------------------------------------------
// @Namespace : UniShader.Shared
// @Class     : UnityMaterialExtensions
// ----------------------------------------------------------------------
#nullable enable
namespace UniShader.Shared
{
    using System;
    using UnityEngine;

    /// <summary>
    /// UnityEngine.Material Extensions
    /// </summary>
    public static class UnityMaterialExtensions
    {
        #region Methods (Get)

        /// <summary>
        /// Gets bool value.
        /// </summary>
        /// <param name="material">A material.</param>
        /// <param name="propertyNameId">A material property name ID.</param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static bool GetSafeBool(this Material material, int propertyNameId, bool defaultValue = false)
        {
#if UNITY_2021_2_OR_NEWER
            if (material.HasInt(propertyNameId))
            {
                return material.GetInt(propertyNameId) == 1;
            }
            else if (material.HasProperty(propertyNameId))
            {
                //Debug.LogError($"{material.name} {propertyNameId} property type is not int.");

                return defaultValue;
            }
#else
            if (material.HasProperty(propertyNameId))
            {
                return material.GetInt(propertyNameId) == 1;
            }
#endif
            else
            {
                //Debug.LogError($"{material.name} don't have {propertyNameId} property.");

                return defaultValue;
            }
        }

        /// <summary>
        /// Gets bool value.
        /// </summary>
        /// <param name="material">A material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static bool GetSafeBool(this Material material, string propertyName, bool defaultValue = false)
        {
#if UNITY_2021_2_OR_NEWER
            if (material.HasInt(propertyName))
            {
                return material.GetInt(propertyName) == 1;
            }
            else if (material.HasProperty(propertyName))
            {
                //Debug.LogError($"{material.name} {propertyName} property type is not int.");

                return defaultValue;
            }
#else
            if (material.HasProperty(propertyName))
            {
                return material.GetInt(propertyName) == 1;
            }
#endif
            else
            {
                //Debug.LogError($"{material.name} don't have {propertyName} property.");

                return defaultValue;
            }
        }

        /// <summary>
        /// Gets color value.
        /// </summary>
        /// <param name="material">A material.</param>
        /// <param name="propertyNameId">A material property name ID.</param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static Color GetSafeColor(this Material material, int propertyNameId, Color defaultValue = default)
        {
#if UNITY_2021_2_OR_NEWER
            if (material.HasColor(propertyNameId))
            {
                return material.GetColor(propertyNameId);
            }
            else if (material.HasProperty(propertyNameId))
            {
                //Debug.LogError($"{material.name} {propertyNameId} property type is not Color.");

                return defaultValue;
            }
#else
            if (material.HasProperty(propertyNameId))
            {
                return material.GetColor(propertyNameId);
            }
#endif
            else
            {
                //Debug.LogError($"{material.name} don't have {propertyNameId} property.");

                return defaultValue;
            }
        }

        /// <summary>
        /// Gets color value.
        /// </summary>
        /// <param name="material">A material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static Color GetSafeColor(this Material material, string propertyName, Color defaultValue = default)
        {
#if UNITY_2021_2_OR_NEWER
            if (material.HasColor(propertyName))
            {
                return material.GetColor(propertyName);
            }
            else if (material.HasProperty(propertyName))
            {
                //Debug.LogError($"{material.name} {propertyName} property type is not Color.");

                return defaultValue;
            }
#else
            if (material.HasProperty(propertyName))
            {
                return material.GetColor(propertyName);
            }
#endif
            else
            {
                //Debug.LogError($"{material.name} don't have {propertyName} property.");

                return defaultValue;
            }
        }

        /// <summary>
        /// Gets enum value.
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="material">A material.</param>
        /// <param name="propertyNameId">A material property name ID.</param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static TEnum GetSafeEnum<TEnum>(this Material material, int propertyNameId, TEnum? defaultValue = null) where TEnum : struct
        {
            int propertyValue = material.GetSafeInt(propertyNameId);

            if (Enum.TryParse(propertyValue.ToString(), out TEnum result))
            {
                return result;
            }
            else if (defaultValue.HasValue)
            {
                return defaultValue.Value;
            }
            else
            {
                return default;
            }
        }

        /// <summary>
        /// Gets enum value.
        /// </summary>
        /// <typeparam name="TEnum"></typeparam>
        /// <param name="material">A material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static TEnum GetSafeEnum<TEnum>(this Material material, string propertyName, TEnum? defaultValue = null) where TEnum : struct
        {
            int propertyValue = material.GetSafeInt(propertyName);

            if (Enum.TryParse(propertyValue.ToString(), out TEnum result))
            {
                return result;
            }
            else if (defaultValue.HasValue)
            {
                return defaultValue.Value;
            }
            else
            {
                return default;
            }
        }

        /// <summary>
        /// Gets float value.
        /// </summary>
        /// <param name="material">A material.</param>
        /// <param name="propertyNameId">A material property name ID.</param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static float GetSafeFloat(this Material material, int propertyNameId, float defaultValue = default)
        {
#if UNITY_2021_2_OR_NEWER
            if (material.HasFloat(propertyNameId))
            {
                return material.GetFloat(propertyNameId);
            }
            else if (material.HasProperty(propertyNameId))
            {
                //Debug.LogError($"{material.name} {propertyNameId} property type is not float.");

                return defaultValue;
            }
#else
            if (material.HasProperty(propertyNameId))
            {
                return material.GetFloat(propertyNameId);
            }
#endif
            else
            {
                //Debug.LogError($"{material.name} don't have {propertyNameId} property.");

                return defaultValue;
            }
        }

        /// <summary>
        /// Gets float value.
        /// </summary>
        /// <param name="material">A material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static float GetSafeFloat(this Material material, string propertyName, float defaultValue = default)
        {
#if UNITY_2021_2_OR_NEWER
            if (material.HasFloat(propertyName))
            {
                return material.GetFloat(propertyName);
            }
            else if (material.HasProperty(propertyName))
            {
                //Debug.LogError($"{material.name} {propertyName} property type is not float.");

                return defaultValue;
            }
#else
            if (material.HasProperty(propertyName))
            {
                return material.GetFloat(propertyName);
            }
#endif
            else
            {
                //Debug.LogError($"{material.name} don't have {propertyName} property.");

                return defaultValue;
            }
        }

        /// <summary>
        /// Gets int value.
        /// </summary>
        /// <param name="material">A material.</param>
        /// <param name="propertyNameId">A material property name ID.</param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static int GetSafeInt(this Material material, int propertyNameId, int defaultValue = default)
        {
            //return material.GetSafeInteger(propertyNameId);

#if UNITY_2021_2_OR_NEWER
            if (material.HasInt(propertyNameId))
            {
                return material.GetInt(propertyNameId);
            }
            else if (material.HasProperty(propertyNameId))
            {
                //Debug.LogError($"{material.name} {propertyNameId} property type is not int.");

                return defaultValue;
            }
#else
            if (material.HasProperty(propertyNameId))
            {
                return material.GetInt(propertyNameId);
            }
#endif
            else
            {
                //Debug.LogError($"{material.name} don't have {propertyNameId} property.");

                return defaultValue;
            }
        }

        /// <summary>
        /// Gets int value.
        /// </summary>
        /// <param name="material">A material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static int GetSafeInt(this Material material, string propertyName, int defaultValue = default)
        {
            //return material.GetSafeInteger(propertyName);

#if UNITY_2021_2_OR_NEWER
            if (material.HasInt(propertyName))
            {
                return material.GetInt(propertyName);
            }
            else if (material.HasProperty(propertyName))
            {
                //Debug.LogError($"{material.name} {propertyName} property type is not int.");

                return defaultValue;
            }
#else
            if (material.HasProperty(propertyName))
            {
                return material.GetInt(propertyName);
            }
#endif
            else
            {
                //Debug.LogError($"{material.name} don't have {propertyName} property.");

                return defaultValue;
            }
        }

        /// <summary>
        /// Gets int value.
        /// </summary>
        /// <param name="material">A material.</param>
        /// <param name="propertyNameId">A material property name ID.</param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static int GetSafeInteger(this Material material, int propertyNameId, int defaultValue = default)
        {
#if UNITY_2021_2_OR_NEWER
            if (material.HasInteger(propertyNameId))
            {
                return material.GetInteger(propertyNameId);
            }
            else if (material.HasProperty(propertyNameId))
            {
                //Debug.LogError($"{material.name} {propertyNameId} property type is not integer.");

                return defaultValue;
            }
            else
            {
                //Debug.LogError($"{material.name} don't have {propertyNameId} property.");

                return defaultValue;
            }
#else
            return GetSafeInt(material, propertyNameId);
#endif
        }

        /// <summary>
        /// Gets int value.
        /// </summary>
        /// <param name="material">A material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static int GetSafeInteger(this Material material, string propertyName, int defaultValue = default)
        {
#if UNITY_2021_2_OR_NEWER
            if (material.HasInteger(propertyName))
            {
                return material.GetInteger(propertyName);
            }
            else if (material.HasProperty(propertyName))
            {
                //Debug.LogError($"{material.name} {propertyName} property type is not integer.");

                return defaultValue;
            }
            else
            {
                //Debug.LogError($"{material.name} don't have {propertyName} property.");

                return defaultValue;
            }
#else
            return GetSafeInt(material, propertyName);
#endif
        }

        /// <summary>
        /// Gets the Texture.
        /// </summary>
        /// <param name="material">A material.</param>
        /// <param name="propertyNameId">A material property name ID.</param>
        /// <returns></returns>
        public static Texture2D? GetSafeTexture(this Material material, int propertyNameId)
        {
#if UNITY_2021_2_OR_NEWER
            if (material.HasTexture(propertyNameId))
            {
                Texture? texture = material.GetTexture(propertyNameId);

                if (texture == null)
                {
                    return default;
                }

                return texture as Texture2D;
            }
            else if (material.HasProperty(propertyNameId))
            {
                //Debug.LogError($"{material.name} {propertyNameId} property type is not Texture.");

                return default;
            }
#else
            if (material.HasProperty(propertyNameId))
            {
                return (Texture2D)material.GetTexture(propertyNameId);
            }
#endif
            else
            {
                //Debug.LogError($"{material.name} don't have {propertyNameId} property.");

                return default;
            }
        }

        /// <summary>
        /// Gets the Texture.
        /// </summary>
        /// <param name="material">A material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <returns></returns>
        public static Texture2D? GetSafeTexture(this Material material, string propertyName)
        {
#if UNITY_2021_2_OR_NEWER
            if (material.HasTexture(propertyName))
            {
                Texture? texture = material.GetTexture(propertyName);

                if (texture == null)
                {
                    return default;
                }

                return texture as Texture2D;
            }
            else if (material.HasProperty(propertyName))
            {
                //Debug.LogError($"{material.name} {propertyName} property type is not Texture.");

                return default;
            }
#else
            if (material.HasProperty(propertyName))
            {
                return (Texture2D)material.GetTexture(propertyName);
            }
#endif
            else
            {
                //Debug.LogError($"{material.name} don't have {propertyName} property.");

                return default;
            }
        }

        /// <summary>
        /// Gets Texture scale value.
        /// </summary>
        /// <param name="material">A material.</param>
        /// <param name="propertyNameId">A material property name ID.</param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static Vector2 GetSafeTextureScale(this Material material, int propertyNameId, Vector2 defaultValue = default)
        {
            if (material.HasProperty(propertyNameId))
            {
                return material.GetTextureScale(propertyNameId);
            }
            else
            {
                //Debug.LogError($"{material.name} don't have {propertyNameId} property.");

                return defaultValue;
            }
        }

        /// <summary>
        /// Gets Texture scale value.
        /// </summary>
        /// <param name="material">A material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static Vector2 GetSafeTextureScale(this Material material, string propertyName, Vector2 defaultValue = default)
        {
            if (material.HasProperty(propertyName))
            {
                return material.GetTextureScale(propertyName);
            }
            else
            {
                //Debug.LogError($"{material.name} don't have {propertyName} property.");

                return defaultValue;
            }
        }

        /// <summary>
        /// Gets Texture offset value.
        /// </summary>
        /// <param name="material">A material.</param>
        /// <param name="propertyNameId">A material property name ID.</param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static Vector2 GetSafeTextureOffset(this Material material, int propertyNameId, Vector2 defaultValue = default)
        {
            if (material.HasProperty(propertyNameId))
            {
                return material.GetTextureOffset(propertyNameId);
            }
            else
            {
                //Debug.LogError($"{material.name} don't have {propertyNameId} property.");

                return defaultValue;
            }
        }

        /// <summary>
        /// Gets Texture offset value.
        /// </summary>
        /// <param name="material">A material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static Vector2 GetSafeTextureOffset(this Material material, string propertyName, Vector2 defaultValue = default)
        {
            if (material.HasProperty(propertyName))
            {
                return material.GetTextureOffset(propertyName);
            }
            else
            {
                //Debug.LogError($"{material.name} don't have {propertyName} property.");

                return defaultValue;
            }
        }

        /// <summary>
        /// Gets Vector3 value.
        /// </summary>
        /// <param name="material">A material.</param>
        /// <param name="propertyNameId">A material property name ID.</param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static Vector3 GetSafeVector3(this Material material, int propertyNameId, Vector3 defaultValue = default)
        {
            return material.GetSafeVector4(propertyNameId, defaultValue);
        }

        /// <summary>
        /// Gets Vector3 value.
        /// </summary>
        /// <param name="material">A material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static Vector3 GetSafeVector3(this Material material, string propertyName, Vector3 defaultValue = default)
        {
            return material.GetSafeVector4(propertyName, defaultValue);
        }

        /// <summary>
        /// Gets Vector4 value.
        /// </summary>
        /// <param name="material">A material.</param>
        /// <param name="propertyNameId">A material property name ID.</param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static Vector4 GetSafeVector4(this Material material, int propertyNameId, Vector4 defaultValue = default)
        {
#if UNITY_2021_2_OR_NEWER
            if (material.HasVector(propertyNameId))
            {
                return material.GetVector(propertyNameId);
            }
            else if (material.HasProperty(propertyNameId))
            {
                //Debug.LogError($"{material.name} {propertyNameId} property type is not Vector.");

                return defaultValue;
            }
#else
            if (material.HasProperty(propertyNameId))
            {
                return material.GetVector(propertyNameId);
            }
#endif
            else
            {
                //Debug.LogError($"{material.name} don't have {propertyNameId} property.");

                return defaultValue;
            }
        }

        /// <summary>
        /// Gets Vector4 value.
        /// </summary>
        /// <param name="material">A material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public static Vector4 GetSafeVector4(this Material material, string propertyName, Vector4 defaultValue = default)
        {
#if UNITY_2021_2_OR_NEWER
            if (material.HasVector(propertyName))
            {
                return material.GetVector(propertyName);
            }
            else if (material.HasProperty(propertyName))
            {
                //Debug.LogError($"{material.name} {propertyName} property type is not Vector.");

                return defaultValue;
            }
#else
            if (material.HasProperty(propertyName))
            {
                return material.GetVector(propertyName);
            }
#endif
            else
            {
                //Debug.LogError($"{material.name} don't have {propertyName} property.");

                return defaultValue;
            }
        }

        #endregion

        #region Methods (Set)

        /// <summary>
        /// Sets bool value to property.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyNameId">A material property name ID.</param>
        /// <param name="value"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeBool(this Material material, int propertyNameId, bool value)
        {
            if (material.HasProperty(propertyNameId))
            {
                material.SetInt(propertyNameId, (value == true) ? 1 : 0);

                return true;
            }
            else
            {
                //Debug.LogWarning($"{material.name} don't have {propertyNameId} property.");

                return false;
            }
        }

        /// <summary>
        /// Sets bool value to property.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <param name="value"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeBool(this Material material, string propertyName, bool value)
        {
            if (material.HasProperty(propertyName))
            {
                material.SetInt(propertyName, (value == true) ? 1 : 0);

                return true;
            }
            else
            {
                //Debug.LogWarning($"{material.name} don't have {propertyName} property.");

                return false;
            }
        }

        /// <summary>
        /// Sets int value.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyNameId">A material property name ID.</param>
        /// <param name="value"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeInt(this Material material, int propertyNameId, int value, int? minValue = null, int? maxValue = null)
        {
            //return material.SetSafeInteger(propertyName, value, minValue, maxValue);

            if (material.HasProperty(propertyNameId))
            {
                int setValue = value;

                if (minValue.HasValue && value < minValue.Value)
                {
                    setValue = minValue.Value;
                }
                else if (maxValue.HasValue && value > maxValue.Value)
                {
                    setValue = maxValue.Value;
                }

                material.SetInt(propertyNameId, setValue);

                return true;
            }
            else
            {
                //Debug.LogWarning($"{material.name} don't have {propertyNameId} property.");

                return false;
            }
        }

        /// <summary>
        /// Sets int value.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyNameId">A material property name ID.</param>
        /// <param name="value"></param>
        /// <param name="range"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeInt(this Material material, int propertyNameId, int value, in IntRange range)
        {
            return SetSafeInt(material, propertyNameId, value, range.minValue, range.maxValue);
        }

        /// <summary>
        /// Sets int value.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyNameId">A material property name ID.</param>
        /// <param name="value"></param>
        /// <param name="range"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeInt(this Material material, int propertyNameId, int value, in IntRangeDefault range)
        {
            return SetSafeInt(material, propertyNameId, value, range.minValue, range.maxValue);
        }

        /// <summary>
        /// Sets int value.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyNameId">A material property name ID.</param>
        /// <param name="range"></param>
        /// <param name="value"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeInt(this Material material, int propertyNameId, in IntRange range, int value)
        {
            return SetSafeInt(material, propertyNameId, value, range.minValue, range.maxValue);
        }

        /// <summary>
        /// Sets int value.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyNameId">A material property name ID.</param>
        /// <param name="range"></param>
        /// <param name="value"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeInt(this Material material, int propertyNameId, in IntRangeDefault range, int value)
        {
            return SetSafeInt(material, propertyNameId, value, range.minValue, range.maxValue);
        }

        /// <summary>
        /// Sets int value.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <param name="value"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeInt(this Material material, string propertyName, int value, int? minValue = null, int? maxValue = null)
        {
            //return material.SetSafeInteger(propertyName, value, minValue, maxValue);

            if (material.HasProperty(propertyName))
            {
                int setValue = value;

                if (minValue.HasValue && value < minValue.Value)
                {
                    setValue = minValue.Value;
                }
                else if (maxValue.HasValue && value > maxValue.Value)
                {
                    setValue = maxValue.Value;
                }

                material.SetInt(propertyName, setValue);

                return true;
            }
            else
            {
                //Debug.LogWarning($"{material.name} don't have {propertyName} property.");

                return false;
            }
        }

        /// <summary>
        /// Sets int value.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <param name="value"></param>
        /// <param name="range"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeInt(this Material material, string propertyName, int value, in IntRange range)
        {
            return SetSafeInt(material, propertyName, value, range.minValue, range.maxValue);
        }

        /// <summary>
        /// Sets int value.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <param name="value"></param>
        /// <param name="range"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeInt(this Material material, string propertyName, int value, in IntRangeDefault range)
        {
            return SetSafeInt(material, propertyName, value, range.minValue, range.maxValue);
        }

        /// <summary>
        /// Sets int value.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <param name="range"></param>
        /// <param name="value"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeInt(this Material material, string propertyName, in IntRange range, int value)
        {
            return SetSafeInt(material, propertyName, value, range.minValue, range.maxValue);
        }

        /// <summary>
        /// Sets int value.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <param name="range"></param>
        /// <param name="value"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeInt(this Material material, string propertyName, in IntRangeDefault range, int value)
        {
            return SetSafeInt(material, propertyName, value, range.minValue, range.maxValue);
        }

        /// <summary>
        /// Sets int value.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyNameId">A material property name ID.</param>
        /// <param name="value"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeInteger(this Material material, int propertyNameId, int value, int? minValue = null, int? maxValue = null)
        {
            if (material.HasProperty(propertyNameId))
            {
                int setValue = value;

                if (minValue.HasValue && value < minValue.Value)
                {
                    setValue = minValue.Value;
                }
                else if (maxValue.HasValue && value > maxValue.Value)
                {
                    setValue = maxValue.Value;
                }

#if UNITY_2021_2_OR_NEWER
                material.SetInteger(propertyNameId, setValue);
#else
                material SetInt(propertyNameId, setValue);
#endif
                return true;
            }
            else
            {
                //Debug.LogWarning($"{material.name} don't have {propertyNameId} property.");

                return false;
            }
        }

        /// <summary>
        /// Sets int value.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyNameId">A material property name ID.</param>
        /// <param name="value"></param>
        /// <param name="range"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeInteger(this Material material, int propertyNameId, int value, in IntRange range)
        {
            return SetSafeInteger(material, propertyNameId, value, range.minValue, range.maxValue);
        }

        /// <summary>
        /// Sets int value.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyNameId">A material property name ID.</param>
        /// <param name="value"></param>
        /// <param name="range"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeInteger(this Material material, int propertyNameId, int value, in IntRangeDefault range)
        {
            return SetSafeInteger(material, propertyNameId, value, range.minValue, range.maxValue);
        }

        /// <summary>
        /// Sets int value.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyNameId">A material property name ID.</param>
        /// <param name="range"></param>
        /// <param name="value"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeInteger(this Material material, int propertyNameId, in IntRange range, int value)
        {
            return SetSafeInteger(material, propertyNameId, value, range.minValue, range.maxValue);
        }

        /// <summary>
        /// Sets int value.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyNameId">A material property name ID.</param>
        /// <param name="range"></param>
        /// <param name="value"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeInteger(this Material material, int propertyNameId, in IntRangeDefault range, int value)
        {
            return SetSafeInteger(material, propertyNameId, value, range.minValue, range.maxValue);
        }

        /// <summary>
        /// Sets int value.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <param name="value"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeInteger(this Material material, string propertyName, int value, int? minValue = null, int? maxValue = null)
        {
            if (material.HasProperty(propertyName))
            {
                int setValue = value;

                if (minValue.HasValue && value < minValue.Value)
                {
                    setValue = minValue.Value;
                }
                else if (maxValue.HasValue && value > maxValue.Value)
                {
                    setValue = maxValue.Value;
                }

#if UNITY_2021_2_OR_NEWER
                material.SetInteger(propertyName, setValue);
#else
                material SetInt(propertyName, setValue);
#endif
                return true;
            }
            else
            {
                //Debug.LogWarning($"{material.name} don't have {propertyName} property.");

                return false;
            }
        }

        /// <summary>
        /// Sets int value.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <param name="value"></param>
        /// <param name="range"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeInteger(this Material material, string propertyName, int value, in IntRange range)
        {
            return SetSafeInteger(material, propertyName, value, range.minValue, range.maxValue);
        }

        /// <summary>
        /// Sets int value.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <param name="value"></param>
        /// <param name="range"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeInteger(this Material material, string propertyName, int value, in IntRangeDefault range)
        {
            return SetSafeInteger(material, propertyName, value, range.minValue, range.maxValue);
        }

        /// <summary>
        /// Sets int value.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <param name="range"></param>
        /// <param name="value"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeInteger(this Material material, string propertyName, in IntRange range, int value)
        {
            return SetSafeInteger(material, propertyName, value, range.minValue, range.maxValue);
        }

        /// <summary>
        /// Sets int value.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <param name="range"></param>
        /// <param name="value"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeInteger(this Material material, string propertyName, in IntRangeDefault range, int value)
        {
            return SetSafeInteger(material, propertyName, value, range.minValue, range.maxValue);
        }

        /// <summary>
        /// Sets float value.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyNameId">A material property name ID.</param>
        /// <param name="value"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeFloat(this Material material, int propertyNameId, float value, float? minValue = null, float? maxValue = null)
        {
            if (material.HasProperty(propertyNameId))
            {
                float setValue = value;

                if (minValue.HasValue && value < minValue.Value)
                {
                    setValue = minValue.Value;
                }
                else if (maxValue.HasValue && value > maxValue.Value)
                {
                    setValue = maxValue.Value;
                }

                material.SetFloat(propertyNameId, setValue);

                return true;
            }
            else
            {
                //Debug.LogWarning($"{material.name} don't have {propertyNameId} property.");

                return false;
            }
        }

        /// <summary>
        /// Sets float value.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyNameId">A material property name ID.</param>
        /// <param name="value"></param>
        /// <param name="range"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeFloat(this Material material, int propertyNameId, float value, in FloatRange range)
        {
            return SetSafeFloat(material, propertyNameId, value, range.minValue, range.maxValue);
        }

        /// <summary>
        /// Sets float value.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyNameId">A material property name ID.</param>
        /// <param name="value"></param>
        /// <param name="range"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeFloat(this Material material, int propertyNameId, float value, in FloatRangeDefault range)
        {
            return SetSafeFloat(material, propertyNameId, value, range.minValue, range.maxValue);
        }

        /// <summary>
        /// Sets float value.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyNameId">A material property name ID.</param>
        /// <param name="range"></param>
        /// <param name="value"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeFloat(this Material material, int propertyNameId, in FloatRange range, float value)
        {
            return SetSafeFloat(material, propertyNameId, value, range.minValue, range.maxValue);
        }

        /// <summary>
        /// Sets float value.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyNameId">A material property name ID.</param>
        /// <param name="range"></param>
        /// <param name="value"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeFloat(this Material material, int propertyNameId, in FloatRangeDefault range, float value)
        {
            return SetSafeFloat(material, propertyNameId, value, range.minValue, range.maxValue);
        }

        /// <summary>
        /// Sets float value.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <param name="value"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeFloat(this Material material, string propertyName, float value, float? minValue = null, float? maxValue = null)
        {
            if (material.HasProperty(propertyName))
            {
                float setValue = value;

                if (minValue.HasValue && value < minValue.Value)
                {
                    setValue = minValue.Value;
                }
                else if (maxValue.HasValue && value > maxValue.Value)
                {
                    setValue = maxValue.Value;
                }

                material.SetFloat(propertyName, setValue);

                return true;
            }
            else
            {
                //Debug.LogWarning($"{material.name} don't have {propertyName} property.");

                return false;
            }
        }

        /// <summary>
        /// Sets float value.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <param name="value"></param>
        /// <param name="range"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeFloat(this Material material, string propertyName, float value, in FloatRange range)
        {
            return SetSafeFloat(material, propertyName, value, range.minValue, range.maxValue);
        }

        /// <summary>
        /// Sets float value.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <param name="value"></param>
        /// <param name="range"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeFloat(this Material material, string propertyName, float value, in FloatRangeDefault range)
        {
            return SetSafeFloat(material, propertyName, value, range.minValue, range.maxValue);
        }

        /// <summary>
        /// Sets float value.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <param name="range"></param>
        /// <param name="value"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeFloat(this Material material, string propertyName, in FloatRangeDefault range, float value)
        {
            return SetSafeFloat(material, propertyName, value, range.minValue, range.maxValue);
        }

        /// <summary>
        /// Sets color value.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyNameId">A material property name ID.</param>
        /// <param name="color"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeColor(this Material material, int propertyNameId, Color color)
        {
            if (material.HasProperty(propertyNameId))
            {
                material.SetColor(propertyNameId, color);

                return true;
            }
            else
            {
                Debug.LogWarning($"{material.name} don't have {propertyNameId} property.");

                return false;
            }
        }

        /// <summary>
        /// Sets color value.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <param name="color"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeColor(this Material material, string propertyName, Color color)
        {
            if (material.HasProperty(propertyName))
            {
                material.SetColor(propertyName, color);

                return true;
            }
            else
            {
                //Debug.LogWarning($"{material.name} don't have {propertyName} property.");

                return false;
            }
        }

        /// <summary>
        /// Sets the Texture.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyNameId">A material property name ID.</param>
        /// <param name="texture"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeTexture(this Material material, int propertyNameId, Texture2D texture)
        {
            if (material.HasProperty(propertyNameId))
            {
                material.SetTexture(propertyNameId, texture);

                return true;
            }
            else
            {
                //Debug.LogWarning($"{material.name} don't have {propertyNameId} property.");

                return false;
            }
        }

        /// <summary>
        /// Sets the Texture.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyNameId">A material property name ID.</param>
        /// <param name="texture"></param>
        /// <param name="textureOffset"></param>
        /// <param name="textureScale"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeTexture(this Material material, int propertyNameId, Texture2D texture, Vector2 textureOffset, Vector2 textureScale)
        {
            if (material.HasProperty(propertyNameId))
            {
                material.SetTexture(propertyNameId, texture);

                material.SetTextureOffset(propertyNameId, textureOffset);

                material.SetTextureScale(propertyNameId, textureScale);

                return true;
            }
            else
            {
                //Debug.LogWarning($"{material.name} don't have {propertyNameId} property.");

                return false;
            }
        }

        /// <summary>
        /// Sets the Texture.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <param name="texture"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeTexture(this Material material, string propertyName, Texture2D texture)
        {
            if (material.HasProperty(propertyName))
            {
                material.SetTexture(propertyName, texture);

                return true;
            }
            else
            {
                //Debug.LogWarning($"{material.name} don't have {propertyName} property.");

                return false;
            }
        }

        /// <summary>
        /// Sets the Texture.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <param name="texture"></param>
        /// <param name="textureOffset"></param>
        /// <param name="textureScale"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeTexture(this Material material, string propertyName, Texture2D texture, Vector2 textureOffset, Vector2 textureScale)
        {
            if (material.HasProperty(propertyName))
            {
                material.SetTexture(propertyName, texture);

                material.SetTextureOffset(propertyName, textureOffset);

                material.SetTextureScale(propertyName, textureScale);

                return true;
            }
            else
            {
                //Debug.LogWarning($"{material.name} don't have {propertyName} property.");

                return false;
            }
        }

        /// <summary>
        /// Sets the texture offset.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyNameId">A material property name ID.</param>
        /// <param name="textureOffset"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeTextureOffset(this Material material, int propertyNameId, Vector2 textureOffset)
        {
            if (material.HasProperty(propertyNameId))
            {
                material.SetTextureOffset(propertyNameId, textureOffset);

                return true;
            }
            else
            {
                //Debug.LogWarning($"{material.name} don't have {propertyNameId} property.");

                return false;
            }
        }

        /// <summary>
        /// Sets the texture offset.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <param name="textureOffset"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeTextureOffset(this Material material, string propertyName, Vector2 textureOffset)
        {
            if (material.HasProperty(propertyName))
            {
                material.SetTextureOffset(propertyName, textureOffset);

                return true;
            }
            else
            {
                //Debug.LogWarning($"{material.name} don't have {propertyName} property.");

                return false;
            }
        }

        /// <summary>
        /// Sets the texture scale.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyNameId">A material property name ID.</param>
        /// <param name="textureScale"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeTextureScale(this Material material, int propertyNameId, Vector2 textureScale)
        {
            if (material.HasProperty(propertyNameId))
            {
                material.SetTextureScale(propertyNameId, textureScale);

                return true;
            }
            else
            {
                //Debug.LogWarning($"{material.name} don't have {propertyNameId} property.");

                return false;
            }
        }

        /// <summary>
        /// Sets the texture scale.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <param name="textureScale"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeTextureScale(this Material material, string propertyName, Vector2 textureScale)
        {
            if (material.HasProperty(propertyName))
            {
                material.SetTextureScale(propertyName, textureScale);

                return true;
            }
            else
            {
                //Debug.LogWarning($"{material.name} don't have {propertyName} property.");

                return false;
            }
        }

        /// <summary>
        /// Sets the Vector value.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyNameId">A material property name ID.</param>
        /// <param name="vector"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeVector(this Material material, int propertyNameId, Vector4 vector)
        {
            if (material.HasProperty(propertyNameId))
            {
                material.SetVector(propertyNameId, vector);

                return true;
            }
            else
            {
                //Debug.LogWarning($"{material.name} don't have {propertyNameId} property.");

                return false;
            }
        }

        /// <summary>
        /// Sets the Vector value.
        /// </summary>
        /// <param name="material">A lilToon material.</param>
        /// <param name="propertyName">A material property name.</param>
        /// <param name="vector"></param>
        /// <returns>Whether it could be set.</returns>
        public static bool SetSafeVector(this Material material, string propertyName, Vector4 vector)
        {
            if (material.HasProperty(propertyName))
            {
                material.SetVector(propertyName, vector);

                return true;
            }
            else
            {
                //Debug.LogWarning($"{material.name} don't have {propertyName} property.");

                return false;
            }
        }

        /// <summary>
        /// Sets the keyword.
        /// </summary>
        /// <param name="material">A material.</param>
        /// <param name="keyword">A material keyword.</param>
        /// <param name="enable"></param>
        public static void SetKeyword(this Material material, string keyword, bool enable)
        {
            if (enable)
            {
                material.EnableKeyword(keyword);
            }
            else
            {
                material.DisableKeyword(keyword);
            }
        }

        /// <summary>
        /// Sets the keyword.
        /// </summary>
        /// <param name="material">A material.</param>
        /// <param name="keyword">A material keyword.</param>
        /// <param name="enable"></param>
        public static void SetSafeKeyword(this Material material, string keyword, bool enable)
        {
            try
            {
                if (enable)
                {
                    material.EnableKeyword(keyword);
                }
                else
                {
                    material.DisableKeyword(keyword);
                }
            }
            catch
            {
                //
            }
        }

        #endregion
    }
}
