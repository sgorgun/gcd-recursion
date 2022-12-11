using System;

namespace GcdTask
{
    public static class IntegerExtensions
    {
        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue]  by the Euclidean algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int FindGcd(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new System.ArgumentException("Two numbers cannot be 0 at the same time.");
            }

            if (a is int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(a), $"{nameof(a)} can't be int.MinValue.");
            }

            if (b is <= int.MinValue)
            {
                throw new ArgumentOutOfRangeException(nameof(b), $"{nameof(b)} can't be int.MinValue.");
            }

            int y = GcdNumber(a, b);
            if (y > 0)
            {
                return y;
            }
            else
            {
                return -y;
            }
        }

        private static int GcdNumber(int x, int y)
        {
            if (y == 0)
            {
                return x;
            }

            int z = x % y;
            if (z == 0)
            {
                return y;
            }

            return GcdNumber(y, z);
        }
    }
}
