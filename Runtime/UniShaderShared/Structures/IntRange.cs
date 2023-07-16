// ----------------------------------------------------------------------
// @Namespace : UniShader.Shared
// @Structure : IntRange
// ----------------------------------------------------------------------
namespace UniShader.Shared
{
    /// <summary>
    /// 
    /// </summary>
    public struct IntRange
    {
        /// <summary></summary>
        public int minValue;

        /// <summary></summary>
        public int maxValue;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        public IntRange(int minValue, int maxValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
        }
    }
}