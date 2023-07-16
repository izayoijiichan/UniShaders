// ----------------------------------------------------------------------
// @Namespace : UniShader.Shared
// @Structure : FloatRange
// ----------------------------------------------------------------------
namespace UniShader.Shared
{
    /// <summary>
    /// 
    /// </summary>
    public struct FloatRange
    {
        /// <summary></summary>
        public float minValue;

        /// <summary></summary>
        public float maxValue;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        public FloatRange(float minValue, float maxValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
        }
    }
}