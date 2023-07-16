// ----------------------------------------------------------------------
// @Namespace : UniShader.Shared
// @Structure : IntRangeDefault
// ----------------------------------------------------------------------
namespace UniShader.Shared
{
    /// <summary>
    /// 
    /// </summary>
    public struct IntRangeDefault
    {
        /// <summary></summary>
        public int minValue;

        /// <summary></summary>
        public int maxValue;

        /// <summary></summary>
        public int defaultValue;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <param name="defaultValue"></param>
        public IntRangeDefault(int minValue, int maxValue, int defaultValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
            this.defaultValue = defaultValue;
        }
    }
}