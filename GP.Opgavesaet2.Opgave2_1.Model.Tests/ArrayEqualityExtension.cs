using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GP.Opgavesaet2.Opgave2_1.Model.Tests
{
    public static class ArrayEqualityExtension
    {
        public static void AreEqualTo<T>(this T[] array, T[] otherArray)
        {
            if (ReferenceEquals(array, otherArray)) return;

            if (array.Length != otherArray.Length) throw new AssertFailedException("The two arrays are not of equal length so they are not equal");

            for (var i = 0; i < array.Length; i++)
                if (!array[i].Equals(otherArray[i])) throw new AssertFailedException($"arrays are not equal at position {i}");
        }
    }
}