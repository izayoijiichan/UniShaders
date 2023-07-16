// ----------------------------------------------------------------------
// @Namespace : UniShader.Shared
// @Structure : FloatRangeDefault
// ----------------------------------------------------------------------
namespace UniShader.Shared
{
    /// <summary>
    /// 
    /// </summary>
    public struct FloatRangeDefault
    {
        /// <summary></summary>
        public float minValue;

        /// <summary></summary>
        public float maxValue;

        /// <summary></summary>
        public float defaultValue;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <param name="defaultValue"></param>
        public FloatRangeDefault(float minValue, float maxValue, float defaultValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
            this.defaultValue = defaultValue;
        }
    }
}