using System.Collections.Generic;

namespace CollectedUtils.Extensions
{
    public static class IntegerExtension
    {
        /// <summary>
        /// <remarks>The original source of this code is here: http://stackoverflow.com/questions/1137499/determine-if-a-number-falls-within-a-specified-set-of-ranges
        /// </remarks>
        /// </summary>
        /// <param name="value"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool Between(this int value, int left, int right)
        {
            return value >= left && value <= right;
        }

        public static bool BetweenInclusive(this int value, int left, int right)
        {
            return Between(value, left, right);
        }

        public static bool BetweenExclusive(this int value, int left, int right)
        {
            return value > left && value < right;
        }

        /// <summary>
        /// <remarks>The original question that prompted me to implement this code is here: http://stackoverflow.com/questions/10458/is-there-a-set-data-structure-in-net
        /// The extension methods are syntactic sugar to ease the re-implementation of logic originally written in SAS.
        /// </remarks>
        /// </summary>
        /// <param name="value"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static bool In(this int value, params int[] values)
        {
            var set = new HashSet<int>(values);

            return set.Contains(value);
        }

        public static bool In(this int? value, params int?[] values)
        {
            var set = new HashSet<int?>(values);

            return set.Contains(value);
        }
    }
}
