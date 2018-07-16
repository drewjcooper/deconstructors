using System;

namespace Extensions.Generic.Deconstructors
{
    public static class ArrayDecontructors
    {
        public static void Deconstruct<T>(this T[] array, out T item1, out T item2)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length < 2)
            {
                throw new ArgumentException("The provided array must have at least 2 elements.", nameof(array));
            }

            item1 = array[0];
            item2 = array[1];
        } 

        public static void Deconstruct<T>(this T[] array, out T item1, out T item2, out T item3)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length < 3)
            {
                throw new ArgumentException("The provided array must have at least 3 elements.", nameof(array));
            }

            item1 = array[0];
            item2 = array[1];
            item3 = array[2];
        }
    }
}