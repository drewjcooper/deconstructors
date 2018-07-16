using System;

namespace Extensions.Generic.Deconstructors
{
    public static class ArrayDeconstructors
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

        public static void Deconstruct<T>(this T[] array, out T item1, out T item2, out T item3, 
            out T item4)
        {
            EnsureNotNull(array, nameof(array));
            EnsureMinimumLength(array, 4, nameof(array));

            item1 = array[0];
            item2 = array[1];
            item3 = array[2];
            item4 = array[3];
        }

        public static void Deconstruct<T>(this T[] array, out T item1, out T item2, out T item3, 
            out T item4, out T item5)
        {
            EnsureNotNull(array, nameof(array));
            EnsureMinimumLength(array, 5, nameof(array));

            item1 = array[0];
            item2 = array[1];
            item3 = array[2];
            item4 = array[3];
            item5 = array[4];
        }

        public static void Deconstruct<T>(this T[] array, out T item1, out T item2, out T item3, 
            out T item4, out T item5, out T item6)
        {
            EnsureNotNull(array, nameof(array));
            EnsureMinimumLength(array, 6, nameof(array));

            item1 = array[0];
            item2 = array[1];
            item3 = array[2];
            item4 = array[3];
            item5 = array[4];
            item6 = array[5];
        }

        public static void Deconstruct<T>(this T[] array, out T item1, out T item2, out T item3, 
            out T item4, out T item5, out T item6, out T item7)
        {
            EnsureNotNull(array, nameof(array));
            EnsureMinimumLength(array, 7, nameof(array));

            item1 = array[0];
            item2 = array[1];
            item3 = array[2];
            item4 = array[3];
            item5 = array[4];
            item6 = array[5];
            item7 = array[6];
        }

        public static void Deconstruct<T>(this T[] array, out T item1, out T item2, out T item3, 
            out T item4, out T item5, out T item6, out T item7, out T item8)
        {
            EnsureNotNull(array, nameof(array));
            EnsureMinimumLength(array, 8, nameof(array));

            item1 = array[0];
            item2 = array[1];
            item3 = array[2];
            item4 = array[3];
            item5 = array[4];
            item6 = array[5];
            item7 = array[6];
            item8 = array[7];
        }

        public static void Deconstruct<T>(this T[] array, out T item1, out T item2, out T item3, 
            out T item4, out T item5, out T item6, out T item7, out T item8, out T item9)
        {
            EnsureNotNull(array, nameof(array));
            EnsureMinimumLength(array, 9, nameof(array));

            item1 = array[0];
            item2 = array[1];
            item3 = array[2];
            item4 = array[3];
            item5 = array[4];
            item6 = array[5];
            item7 = array[6];
            item8 = array[7];
            item9 = array[8];
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