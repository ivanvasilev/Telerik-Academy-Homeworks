namespace IEnumerableExtensions
{
    using System.Collections.Generic;

    public static class IEnumerableT
    {
        // Extension Methods
        public static T Sum<T>(this IEnumerable<T> input)
        {
            T sum = (dynamic)0;
            foreach (var item in input)
            {
                sum += (dynamic)item;
            }
            return sum;
        }

        public static T Product<T>(this IEnumerable<T> input)
        {
            T product = (dynamic)1;
            foreach (var item in input)
            {
                product *= (dynamic)item;
            }
            return product;
        }

        public static T Min<T>(this IEnumerable<T> input)
        {
            T min = (dynamic)long.MaxValue;
            foreach (var item in input)
            {
                T temp = item;
                if (min > (dynamic)temp)
                {
                    min = (dynamic)item;
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> input)
        {
            T max = (dynamic)long.MinValue;
            foreach (var item in input)
            {
                T temp = item;
                if (max < (dynamic)temp)
                {
                    max = (dynamic)item;
                }
            }
            return max;
        }

        public static T Average<T>(this IEnumerable<T> input)
        {
            T sum = (dynamic)0;
            int count = 0;

            foreach (var item in input)
            {
                sum += (dynamic)item;
                count++;
            }
            return (dynamic)sum / count;
        }
    }
}
