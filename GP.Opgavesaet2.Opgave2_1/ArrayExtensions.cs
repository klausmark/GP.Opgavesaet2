using System;

namespace GP.Opgavesaet2.Opgave2_1
{
    public static class ArrayExtensions
    {
        public static T[] Reversed<T>(this T[] array)
        {
            var reversedArray = new T[array.Length];
            for (var i = 0; i < array.Length; i++)
                reversedArray[array.Length - i - 1] = array[i];
            return reversedArray;
        }

        public static T[] SubArray<T>(this T[] array, int startPos, int count)
        {
            var subArray = new T[count];
            for (var i = 0; i < count; i++)
            {
                subArray[i] = array[startPos + i];
            }
            return subArray;
        }

        public static int OccurrencesOf<T>(this T[] array, T kind)
        {
            var numberOfKind = 0;
            for (var i = 0; i < array.Length; i++)
                if (array[i].Equals(kind)) numberOfKind++;
            return numberOfKind;
        }

        public static int FirstPositionOf<T>(this T[] array, T kind)
        {
            for (var i = 0; i < array.Length; i++)
                if (array[i].Equals(kind)) return i;
            throw new ArgumentException("No first occurrence of kind", nameof(kind));
        }
    }
}
