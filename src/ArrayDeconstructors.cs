using System;

namespace Extensions.Generic.Deconstructors
{
    public static class ArrayDecontructors
    {
        public static void Deconstruct<T>(this T[] array, out T item1, out T item2)
        {
            EnsureNotNull(array, nameof(array));
            EnsureMinimumLength(array, 2, nameof(array));

            item1 = array[0];
            item2 = array[1];
        }

        public static void Deconstruct<T>(this T[] array, out T item1, out T item2, out T item3)
        {
            EnsureNotNull(array, nameof(array));
            EnsureMinimumLength(array, 3, nameof(array));

            item1 = array[0];
            item2 = array[1];
            item3 = array[2];
        }

        public static void Deconstruct<T>(this T[] array, out T item1, out T item2, out T item3, out T item4)
        {
            EnsureNotNull(array, nameof(array));
            EnsureMinimumLength(array, 4, nameof(array));

            item1 = array[0];
            item2 = array[1];
            item3 = array[2];
            item4 = array[3];
        }

        private static void EnsureNotNull(object obj, string paramName)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(paramName);
            }
        }

        private static void EnsureMinimumLength<T>(T[] array, int minLength, string paramName)
        {
            if (array.Length < minLength)
            {
                throw new ArgumentException(
                    $"The provided array must have at least {minLength} elements.", paramName);
            }
        }
    }
}